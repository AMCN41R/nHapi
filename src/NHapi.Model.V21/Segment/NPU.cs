namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 NPU message segment.
/// This segment has the following fields:<ol>
/// <li>NPU-1: BED LOCATION (ID)</li>
/// <li>NPU-2: BED STATUS (ID)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class NPU : AbstractSegment  {

  /**
   * Creates a NPU (NON-PATIENT UPDATE) segment object that belongs to the given
   * message.
   */
    public NPU(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(ID), true, 1, 12, new object[]{message, 79}, "BED LOCATION");
       add(typeof(ID), false, 1, 1, new object[]{message, 116}, "BED STATUS");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns BED LOCATION(NPU-1).
    /// </summary>
    public ID BEDLOCATION
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(1, 0);
                ret = (ID)t;
            }
             catch (HL7Exception he) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
                throw new Exception("An unexpected error occurred", he);
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
    }
  }

    /// <summary>
    /// Returns BED STATUS(NPU-2).
    /// </summary>
    public ID BEDSTATUS
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(2, 0);
                ret = (ID)t;
            }
             catch (HL7Exception he) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
                throw new Exception("An unexpected error occurred", he);
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
    }
  }
}}