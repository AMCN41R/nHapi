namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 QRF message segment.
/// This segment has the following fields:<ol>
/// <li>QRF-1: WHERE SUBJECT FILTER (ST)</li>
/// <li>QRF-2: WHEN DATA START DATE/TIME (TS)</li>
/// <li>QRF-3: WHEN DATA END DATE/TIME (TS)</li>
/// <li>QRF-4: WHAT USER QUALIFIER (ST)</li>
/// <li>QRF-5: OTHER QRY SUBJECT FILTER (ST)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class QRF : AbstractSegment  {

  /**
   * Creates a QRF (QUERY FILTER) segment object that belongs to the given
   * message.
   */
    public QRF(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(ST), true, 0, 20, new object[]{message}, "WHERE SUBJECT FILTER");
       add(typeof(TS), false, 1, 19, new object[]{message}, "WHEN DATA START DATE/TIME");
       add(typeof(TS), false, 1, 19, new object[]{message}, "WHEN DATA END DATE/TIME");
       add(typeof(ST), false, 0, 20, new object[]{message}, "WHAT USER QUALIFIER");
       add(typeof(ST), false, 0, 20, new object[]{message}, "OTHER QRY SUBJECT FILTER");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns a single repetition of WHERE SUBJECT FILTER(QRF-1).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public ST GetWHERESUBJECTFILTER(int rep)
    {
            ST ret = null;
            try
            {
            var t = GetField(1, rep);
                ret = (ST)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of WHERE SUBJECT FILTER (QRF-1).
   /// </summary>
  public ST[] GetWHERESUBJECTFILTER() {
     ST[] ret = null;
    try {
        var t = GetField(1);
        ret = new ST[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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
  /// Returns the total repetitions of WHERE SUBJECT FILTER (QRF-1).
   /// </summary>
  public int WHERESUBJECTFILTERRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(1);
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
    /// Returns WHEN DATA START DATE/TIME(QRF-2).
    /// </summary>
    public TS WHENDATASTARTDATETIME
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(2, 0);
                ret = (TS)t;
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
    /// Returns WHEN DATA END DATE/TIME(QRF-3).
    /// </summary>
    public TS WHENDATAENDDATETIME
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(3, 0);
                ret = (TS)t;
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
    /// Returns a single repetition of WHAT USER QUALIFIER(QRF-4).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public ST GetWHATUSERQUALIFIER(int rep)
    {
            ST ret = null;
            try
            {
            var t = GetField(4, rep);
                ret = (ST)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of WHAT USER QUALIFIER (QRF-4).
   /// </summary>
  public ST[] GetWHATUSERQUALIFIER() {
     ST[] ret = null;
    try {
        var t = GetField(4);
        ret = new ST[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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
  /// Returns the total repetitions of WHAT USER QUALIFIER (QRF-4).
   /// </summary>
  public int WHATUSERQUALIFIERRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(4);
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
    /// Returns a single repetition of OTHER QRY SUBJECT FILTER(QRF-5).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public ST GetOTHERQRYSUBJECTFILTER(int rep)
    {
            ST ret = null;
            try
            {
            var t = GetField(5, rep);
                ret = (ST)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of OTHER QRY SUBJECT FILTER (QRF-5).
   /// </summary>
  public ST[] GetOTHERQRYSUBJECTFILTER() {
     ST[] ret = null;
    try {
        var t = GetField(5);
        ret = new ST[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (ST)t[i];
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
  /// Returns the total repetitions of OTHER QRY SUBJECT FILTER (QRF-5).
   /// </summary>
  public int OTHERQRYSUBJECTFILTERRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(5);
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