namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 URS message segment.
/// This segment has the following fields:<ol>
/// <li>URS-1: R/U WHERE SUBJECT DEFINITION (ST)</li>
/// <li>URS-2: R/U WHEN DATA START DATE/TIME (TS)</li>
/// <li>URS-3: R/U WHEN DATA END DATE/TIME (TS)</li>
/// <li>URS-4: R/U WHAT USER QUALIFIER (ST)</li>
/// <li>URS-5: R/U OTHER RESULTS SUBJECT DEFINI (ST)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class URS : AbstractSegment  {

  /**
   * Creates a URS (UNSOLICITED SELECTION) segment object that belongs to the given
   * message.
   */
    public URS(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(ST), true, 0, 20, new object[]{message}, "R/U WHERE SUBJECT DEFINITION");
       add(typeof(TS), false, 1, 19, new object[]{message}, "R/U WHEN DATA START DATE/TIME");
       add(typeof(TS), false, 1, 19, new object[]{message}, "R/U WHEN DATA END DATE/TIME");
       add(typeof(ST), false, 0, 20, new object[]{message}, "R/U WHAT USER QUALIFIER");
       add(typeof(ST), false, 0, 20, new object[]{message}, "R/U OTHER RESULTS SUBJECT DEFINI");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns a single repetition of R/U WHERE SUBJECT DEFINITION(URS-1).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public ST GetRUWHERESUBJECTDEFINITION(int rep)
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
  /// Returns all repetitions of R/U WHERE SUBJECT DEFINITION (URS-1).
   /// </summary>
  public ST[] GetRUWHERESUBJECTDEFINITION() {
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
  /// Returns the total repetitions of R/U WHERE SUBJECT DEFINITION (URS-1).
   /// </summary>
  public int RUWHERESUBJECTDEFINITIONRepetitionsUsed
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
    /// Returns R/U WHEN DATA START DATE/TIME(URS-2).
    /// </summary>
    public TS RUWHENDATASTARTDATETIME
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
    /// Returns R/U WHEN DATA END DATE/TIME(URS-3).
    /// </summary>
    public TS RUWHENDATAENDDATETIME
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
    /// Returns a single repetition of R/U WHAT USER QUALIFIER(URS-4).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public ST GetRUWHATUSERQUALIFIER(int rep)
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
  /// Returns all repetitions of R/U WHAT USER QUALIFIER (URS-4).
   /// </summary>
  public ST[] GetRUWHATUSERQUALIFIER() {
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
  /// Returns the total repetitions of R/U WHAT USER QUALIFIER (URS-4).
   /// </summary>
  public int RUWHATUSERQUALIFIERRepetitionsUsed
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
    /// Returns a single repetition of R/U OTHER RESULTS SUBJECT DEFINI(URS-5).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public ST GetRUOTHERRESULTSSUBJECTDEFINI(int rep)
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
  /// Returns all repetitions of R/U OTHER RESULTS SUBJECT DEFINI (URS-5).
   /// </summary>
  public ST[] GetRUOTHERRESULTSSUBJECTDEFINI() {
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
  /// Returns the total repetitions of R/U OTHER RESULTS SUBJECT DEFINI (URS-5).
   /// </summary>
  public int RUOTHERRESULTSSUBJECTDEFINIRepetitionsUsed
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