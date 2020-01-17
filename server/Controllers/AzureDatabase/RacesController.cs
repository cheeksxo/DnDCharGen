using System;
using System.Net;
using System.Data;
using System.Linq;
using System.Data.SqlClient;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNet.OData.Query;



namespace DnDCharGen.Controllers.AzureDatabase
{
  using Models;
  using Data;
  using Models.AzureDatabase;

  [ODataRoutePrefix("odata/AzureDatabase/Races")]
  [Route("mvc/odata/AzureDatabase/Races")]
  public partial class RacesController : ODataController
  {
    private Data.AzureDatabaseContext context;

    public RacesController(Data.AzureDatabaseContext context)
    {
      this.context = context;
    }
    // GET /odata/AzureDatabase/Races
    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet]
    public IEnumerable<Models.AzureDatabase.Race> GetRaces()
    {
      var items = this.context.Races.AsNoTracking().AsQueryable<Models.AzureDatabase.Race>();
      this.OnRacesRead(ref items);

      return items;
    }

    partial void OnRacesRead(ref IQueryable<Models.AzureDatabase.Race> items);

    [EnableQuery(MaxExpansionDepth=10,MaxNodeCount=1000)]
    [HttpGet("{race1}")]
    public SingleResult<Race> GetRace(string key)
    {
        var items = this.context.Races.AsNoTracking().Where(i=>i.race1 == key);
        this.OnRacesGet(ref items);

        return SingleResult.Create(items);
    }

    partial void OnRacesGet(ref IQueryable<Models.AzureDatabase.Race> items);

  }
}
