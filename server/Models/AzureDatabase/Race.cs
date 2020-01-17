using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DnDCharGen.Models.AzureDatabase
{
  [Table("races", Schema = "dbo")]
  public partial class Race
  {
    [Key]

    [Column("race")]
    public string race1
    {
      get;
      set;
    }
    public string size
    {
      get;
      set;
    }
    public int? speed
    {
      get;
      set;
    }
    public int? darkvision
    {
      get;
      set;
    }
    public int? strBonus
    {
      get;
      set;
    }
    public int? dexBonus
    {
      get;
      set;
    }
    public int? conBonus
    {
      get;
      set;
    }
    public int? intBonus
    {
      get;
      set;
    }
    public int? wisBonus
    {
      get;
      set;
    }
    public int? chaBonus
    {
      get;
      set;
    }
    public string feature1
    {
      get;
      set;
    }
    public string f1desc
    {
      get;
      set;
    }
    public string feature2
    {
      get;
      set;
    }
    public string f2desc
    {
      get;
      set;
    }
    public string feature3
    {
      get;
      set;
    }
    public string f3desc
    {
      get;
      set;
    }
    public string feature4
    {
      get;
      set;
    }
    public string f4desc
    {
      get;
      set;
    }
    public string feature5
    {
      get;
      set;
    }
    public string f5desc
    {
      get;
      set;
    }
    public string feature6
    {
      get;
      set;
    }
    public string f6desc
    {
      get;
      set;
    }
  }
}
