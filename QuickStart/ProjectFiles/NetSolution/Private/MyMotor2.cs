using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "QuickStart", Guid = "3429ca913e0bc90c7c5f7788952ea231")]
public class MyMotor2 : UAObject
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public int Speed
    {
        get
        {
            return (int)Refs.GetVariable("Speed").Value.Value;
        }
        set
        {
            Refs.GetVariable("Speed").SetValue(value);
        }
    }
    public IUAVariable SpeedVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Speed");
        }
    }
#endregion
}
