using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "QuickStart", Guid = "4c907028ffc81a6db8b76be2097ace8f")]
public class RangeStatistics : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public double Max
    {
        get
        {
            return (double)Refs.GetVariable("Max").Value.Value;
        }
        set
        {
            Refs.GetVariable("Max").SetValue(value);
        }
    }
    public IUAVariable MaxVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Max");
        }
    }
    public double Min
    {
        get
        {
            return (double)Refs.GetVariable("Min").Value.Value;
        }
        set
        {
            Refs.GetVariable("Min").SetValue(value);
        }
    }
    public IUAVariable MinVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Min");
        }
    }
    public double Avg
    {
        get
        {
            return (double)Refs.GetVariable("Avg").Value.Value;
        }
        set
        {
            Refs.GetVariable("Avg").SetValue(value);
        }
    }
    public IUAVariable AvgVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Avg");
        }
    }
    public UAManagedCore.NodeId Pen
    {
        get
        {
            return (UAManagedCore.NodeId)Refs.GetVariable("Pen").Value.Value;
        }
        set
        {
            Refs.GetVariable("Pen").SetValue(value);
        }
    }
    public FTOptix.Core.NodePointer PenVariable
    {
        get
        {
            return (FTOptix.Core.NodePointer)Refs.GetVariable("Pen");
        }
    }
#endregion
}
