using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "QuickStart", Guid = "bdfc03d535bb8d579a8610801f158976")]
public class MyMotor1 : UAObject
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
    public int Accell
    {
        get
        {
            return (int)Refs.GetVariable("Accell").Value.Value;
        }
        set
        {
            Refs.GetVariable("Accell").SetValue(value);
        }
    }
    public IUAVariable AccellVariable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("Accell");
        }
    }
#endregion
}
