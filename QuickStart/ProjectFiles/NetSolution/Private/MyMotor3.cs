using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "QuickStart", Guid = "9ba573fefb1fd1bdd54dbd88073d86de")]
public class MyMotor3 : UAObject
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
