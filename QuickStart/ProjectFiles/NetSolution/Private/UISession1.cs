using System;
using UAManagedCore;

//-------------------------------------------
// WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
//-------------------------------------------

[MapType(NamespaceUri = "QuickStart", Guid = "ffa48578848bb51f8d39a53ffd438b70")]
public class UISession1 : FTOptix.UI.UISession
{
#region Children properties
    //-------------------------------------------
    // WARNING: AUTO-GENERATED CODE, DO NOT EDIT!
    //-------------------------------------------
    public int SessionVar1
    {
        get
        {
            return (int)Refs.GetVariable("SessionVar1").Value.Value;
        }
        set
        {
            Refs.GetVariable("SessionVar1").SetValue(value);
        }
    }
    public IUAVariable SessionVar1Variable
    {
        get
        {
            return (IUAVariable)Refs.GetVariable("SessionVar1");
        }
    }
#endregion
}
