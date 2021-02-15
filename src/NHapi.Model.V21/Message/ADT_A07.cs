namespace NHapi.Model.V21.Message

{
    using System;
    using System.Collections.Generic;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;
    using NHapi.Model.V21.Group;
    using NHapi.Model.V21.Segment;

/// <summary>
/// Represents a ADT_A07 message structure (see chapter [AAA]). This structure contains the
/// following elements:.
/// <ol>
/// <li>0: MSH (MESSAGE HEADER) </li>
/// <li>1: EVN (EVENT TYPE) </li>
/// <li>2: PID (PATIENT IDENTIFICATION) </li>
/// <li>3: PV1 (PATIENT VISIT) </li>
/// </ol>
/// </summary>
[Serializable]
public class ADT_A07 : AbstractMessage  {

    /// <summary>
    /// Creates a new ADT_A07 Group with custom IModelClassFactory.
    /// </summary>
    public ADT_A07(IModelClassFactory factory)
        : base(factory){
       init(factory);
    }

    /// <summary>
    /// Creates a new ADT_A07 Group with DefaultModelClassFactory.
    /// </summary>
    public ADT_A07()
        : base(new DefaultModelClassFactory()) {
       init(new DefaultModelClassFactory());
    }

    /// <summary>
    /// initalize method for ADT_A07.  This does the segment setup for the message.
    /// </summary>
    private void init(IModelClassFactory factory) {
       try {
          add(typeof(MSH), true, false);
          add(typeof(EVN), true, false);
          add(typeof(PID), true, false);
          add(typeof(PV1), true, false);
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ADT_A07 - this is probably a bug in the source code generator.", e);
       }
    }

    public override string Version
        {
            get{
            return Constants.VERSION;
            }
        }

    /// <summary>
    /// Returns MSH (MESSAGE HEADER) - creates it if necessary.
    /// </summary>
    public MSH MSH {
get{
       MSH ret = null;
       try {
          ret = (MSH)GetStructure("MSH");
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
          throw new Exception("An unexpected error occurred",e);
       }

       return ret;
    }
    }

    /// <summary>
    /// Returns EVN (EVENT TYPE) - creates it if necessary.
    /// </summary>
    public EVN EVN {
get{
       EVN ret = null;
       try {
          ret = (EVN)GetStructure("EVN");
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
          throw new Exception("An unexpected error occurred",e);
       }

       return ret;
    }
    }

    /// <summary>
    /// Returns PID (PATIENT IDENTIFICATION) - creates it if necessary.
    /// </summary>
    public PID PID {
get{
       PID ret = null;
       try {
          ret = (PID)GetStructure("PID");
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
          throw new Exception("An unexpected error occurred",e);
       }

       return ret;
    }
    }

    /// <summary>
    /// Returns PV1 (PATIENT VISIT) - creates it if necessary.
    /// </summary>
    public PV1 PV1 {
get{
       PV1 ret = null;
       try {
          ret = (PV1)GetStructure("PV1");
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
          throw new Exception("An unexpected error occurred",e);
       }

       return ret;
    }
    }
}
}
