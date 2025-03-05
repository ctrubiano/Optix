using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "QuickStart", Guid = "5708f69376d33df4e0d30b5b426240ea")]
public class TrendTimeRange : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public DateTime StartTime
    {
        get
        {
            return (DateTime)Refs.GetVariable("StartTime").Value.Value;
        }
        set
        {
            Refs.GetVariable("StartTime").SetValue(value);
        }
    }
    public IUAVariable StartTimeVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("StartTime");
        }
    }
    public DateTime EndTime
    {
        get
        {
            return (DateTime)Refs.GetVariable("EndTime").Value.Value;
        }
        set
        {
            Refs.GetVariable("EndTime").SetValue(value);
        }
    }
    public IUAVariable EndTimeVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("EndTime");
        }
    }
    public double TimeSpan
    {
        get
        {
            return (double)Refs.GetVariable("TimeSpan").Value.Value;
        }
        set
        {
            Refs.GetVariable("TimeSpan").SetValue(value);
        }
    }
    public IUAVariable TimeSpanVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("TimeSpan");
        }
    }
    public UAManagedCore.IUAObject Statistics
    {
        get
        {
            return (UAManagedCore.IUAObject)Refs.GetObject("Statistics");
        }
    }
#endregion
}
