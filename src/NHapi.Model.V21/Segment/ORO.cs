namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 ORO message segment.
/// This segment has the following fields:<ol>
/// <li>ORO-1: ORDER ITEM ID (CE)</li>
/// <li>ORO-2: SUBSTITUTE ALLOWED (ID)</li>
/// <li>ORO-3: RESULTS COPIES TO (CN)</li>
/// <li>ORO-4: STOCK LOCATION (ID)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class ORO : AbstractSegment  {

  /**
   * Creates a ORO (ORDER OTHER) segment object that belongs to the given
   * message.
   */
    public ORO(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(CE), false, 1, 200, new object[]{message}, "ORDER ITEM ID");
       add(typeof(ID), false, 1, 1, new object[]{message, 0}, "SUBSTITUTE ALLOWED");
       add(typeof(CN), false, 0, 80, new object[]{message}, "RESULTS COPIES TO");
       add(typeof(ID), false, 1, 2, new object[]{message, 12}, "STOCK LOCATION");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns ORDER ITEM ID(ORO-1).
    /// </summary>
    public CE ORDERITEMID
    {
        get{
            CE ret = null;
            try
            {
            var t = GetField(1, 0);
                ret = (CE)t;
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
    /// Returns SUBSTITUTE ALLOWED(ORO-2).
    /// </summary>
    public ID SUBSTITUTEALLOWED
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

    /// <summary>
    /// Returns a single repetition of RESULTS COPIES TO(ORO-3).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public CN GetRESULTSCOPIESTO(int rep)
    {
            CN ret = null;
            try
            {
            var t = GetField(3, rep);
                ret = (CN)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of RESULTS COPIES TO (ORO-3).
   /// </summary>
  public CN[] GetRESULTSCOPIESTO() {
     CN[] ret = null;
    try {
        var t = GetField(3);
        ret = new CN[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (CN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new Exception("An unexpected error occurred", he);
    } catch (Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new Exception("An unexpected error occurred", cce);
  }

 return ret;
}

  /// <summary>
  /// Returns the total repetitions of RESULTS COPIES TO (ORO-3).
   /// </summary>
  public int RESULTSCOPIESTORepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(3);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new Exception("An unexpected error occurred", he);
} catch (Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new Exception("An unexpected error occurred", cce);
}
}
}

    /// <summary>
    /// Returns STOCK LOCATION(ORO-4).
    /// </summary>
    public ID STOCKLOCATION
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(4, 0);
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