namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 NTE message segment.
/// This segment has the following fields:<ol>
/// <li>NTE-1: SET ID - NOTES AND COMMENTS (SI)</li>
/// <li>NTE-2: SOURCE OF COMMENT (ID)</li>
/// <li>NTE-3: COMMENT (TX)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class NTE : AbstractSegment  {

  /**
   * Creates a NTE (NOTES AND COMMENTS) segment object that belongs to the given
   * message.
   */
    public NTE(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(SI), false, 1, 4, new object[]{message}, "SET ID - NOTES AND COMMENTS");
       add(typeof(ID), false, 1, 8, new object[]{message, 105}, "SOURCE OF COMMENT");
       add(typeof(TX), true, 0, 120, new object[]{message}, "COMMENT");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns SET ID - NOTES AND COMMENTS(NTE-1).
    /// </summary>
    public SI SETIDNOTESANDCOMMENTS
    {
        get{
            SI ret = null;
            try
            {
            var t = GetField(1, 0);
                ret = (SI)t;
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
    /// Returns SOURCE OF COMMENT(NTE-2).
    /// </summary>
    public ID SOURCEOFCOMMENT
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
    /// Returns a single repetition of COMMENT(NTE-3).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public TX GetCOMMENT(int rep)
    {
            TX ret = null;
            try
            {
            var t = GetField(3, rep);
                ret = (TX)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of COMMENT (NTE-3).
   /// </summary>
  public TX[] GetCOMMENT() {
     TX[] ret = null;
    try {
        var t = GetField(3);
        ret = new TX[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (TX)t[i];
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
  /// Returns the total repetitions of COMMENT (NTE-3).
   /// </summary>
  public int COMMENTRepetitionsUsed
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
}}