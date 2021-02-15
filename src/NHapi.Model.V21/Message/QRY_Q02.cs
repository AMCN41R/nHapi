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
/// Represents a QRY_Q02 message structure (see chapter [AAA]). This structure contains the
/// following elements:.
/// <ol>
/// <li>0: MSH (MESSAGE HEADER) </li>
/// <li>1: QRD (QUERY DEFINITION) </li>
/// <li>2: QRF (QUERY FILTER) optional </li>
/// <li>3: DSC (CONTINUATION POINTER) </li>
/// </ol>
/// </summary>
[Serializable]
public class QRY_Q02 : AbstractMessage  {

    /// <summary>
    /// Creates a new QRY_Q02 Group with custom IModelClassFactory.
    /// </summary>
    public QRY_Q02(IModelClassFactory factory)
        : base(factory){
       init(factory);
    }

    /// <summary>
    /// Creates a new QRY_Q02 Group with DefaultModelClassFactory.
    /// </summary>
    public QRY_Q02()
        : base(new DefaultModelClassFactory()) {
       init(new DefaultModelClassFactory());
    }

    /// <summary>
    /// initalize method for QRY_Q02.  This does the segment setup for the message.
    /// </summary>
    private void init(IModelClassFactory factory) {
       try {
          add(typeof(MSH), true, false);
          add(typeof(QRD), true, false);
          add(typeof(QRF), false, false);
          add(typeof(DSC), true, false);
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating QRY_Q02 - this is probably a bug in the source code generator.", e);
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
    /// Returns QRD (QUERY DEFINITION) - creates it if necessary.
    /// </summary>
    public QRD QRD {
get{
       QRD ret = null;
       try {
          ret = (QRD)GetStructure("QRD");
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
          throw new Exception("An unexpected error occurred",e);
       }

       return ret;
    }
    }

    /// <summary>
    /// Returns QRF (QUERY FILTER) - creates it if necessary.
    /// </summary>
    public QRF QRF {
get{
       QRF ret = null;
       try {
          ret = (QRF)GetStructure("QRF");
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
          throw new Exception("An unexpected error occurred",e);
       }

       return ret;
    }
    }

    /// <summary>
    /// Returns DSC (CONTINUATION POINTER) - creates it if necessary.
    /// </summary>
    public DSC DSC {
get{
       DSC ret = null;
       try {
          ret = (DSC)GetStructure("DSC");
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
          throw new Exception("An unexpected error occurred",e);
       }

       return ret;
    }
    }
}
}
