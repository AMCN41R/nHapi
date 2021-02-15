namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 URD message segment.
/// This segment has the following fields:<ol>
/// <li>URD-1: R/U DATE/TIME (TS)</li>
/// <li>URD-2: REPORT PRIORITY (ID)</li>
/// <li>URD-3: R/U WHO SUBJECT DEFINITION (ST)</li>
/// <li>URD-4: R/U WHAT SUBJECT DEFINITION (ID)</li>
/// <li>URD-5: R/U WHAT DEPARTMENT CODE (ST)</li>
/// <li>URD-6: R/U DISPLAY/PRINT LOCATIONS (ST)</li>
/// <li>URD-7: R/U RESULTS LEVEL (ID)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class URD : AbstractSegment  {

  /**
   * Creates a URD (RESULTS/UPDATE DEFINITION) segment object that belongs to the given
   * message.
   */
    public URD(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(TS), false, 1, 19, new object[]{message}, "R/U DATE/TIME");
       add(typeof(ID), false, 1, 1, new object[]{message, 109}, "REPORT PRIORITY");
       add(typeof(ST), true, 0, 20, new object[]{message}, "R/U WHO SUBJECT DEFINITION");
       add(typeof(ID), false, 0, 3, new object[]{message, 48}, "R/U WHAT SUBJECT DEFINITION");
       add(typeof(ST), false, 0, 20, new object[]{message}, "R/U WHAT DEPARTMENT CODE");
       add(typeof(ST), false, 0, 20, new object[]{message}, "R/U DISPLAY/PRINT LOCATIONS");
       add(typeof(ID), false, 1, 1, new object[]{message, 108}, "R/U RESULTS LEVEL");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns R/U DATE/TIME(URD-1).
    /// </summary>
    public TS RUDATETIME
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(1, 0);
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
    /// Returns REPORT PRIORITY(URD-2).
    /// </summary>
    public ID REPORTPRIORITY
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
    /// Returns a single repetition of R/U WHO SUBJECT DEFINITION(URD-3).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public ST GetRUWHOSUBJECTDEFINITION(int rep)
    {
            ST ret = null;
            try
            {
            var t = GetField(3, rep);
                ret = (ST)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of R/U WHO SUBJECT DEFINITION (URD-3).
   /// </summary>
  public ST[] GetRUWHOSUBJECTDEFINITION() {
     ST[] ret = null;
    try {
        var t = GetField(3);
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
  /// Returns the total repetitions of R/U WHO SUBJECT DEFINITION (URD-3).
   /// </summary>
  public int RUWHOSUBJECTDEFINITIONRepetitionsUsed
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
    /// Returns a single repetition of R/U WHAT SUBJECT DEFINITION(URD-4).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public ID GetRUWHATSUBJECTDEFINITION(int rep)
    {
            ID ret = null;
            try
            {
            var t = GetField(4, rep);
                ret = (ID)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of R/U WHAT SUBJECT DEFINITION (URD-4).
   /// </summary>
  public ID[] GetRUWHATSUBJECTDEFINITION() {
     ID[] ret = null;
    try {
        var t = GetField(4);
        ret = new ID[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (ID)t[i];
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
  /// Returns the total repetitions of R/U WHAT SUBJECT DEFINITION (URD-4).
   /// </summary>
  public int RUWHATSUBJECTDEFINITIONRepetitionsUsed
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
    /// Returns a single repetition of R/U WHAT DEPARTMENT CODE(URD-5).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public ST GetRUWHATDEPARTMENTCODE(int rep)
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
  /// Returns all repetitions of R/U WHAT DEPARTMENT CODE (URD-5).
   /// </summary>
  public ST[] GetRUWHATDEPARTMENTCODE() {
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
  /// Returns the total repetitions of R/U WHAT DEPARTMENT CODE (URD-5).
   /// </summary>
  public int RUWHATDEPARTMENTCODERepetitionsUsed
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

    /// <summary>
    /// Returns a single repetition of R/U DISPLAY/PRINT LOCATIONS(URD-6).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public ST GetRUDISPLAYPRINTLOCATIONS(int rep)
    {
            ST ret = null;
            try
            {
            var t = GetField(6, rep);
                ret = (ST)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of R/U DISPLAY/PRINT LOCATIONS (URD-6).
   /// </summary>
  public ST[] GetRUDISPLAYPRINTLOCATIONS() {
     ST[] ret = null;
    try {
        var t = GetField(6);
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
  /// Returns the total repetitions of R/U DISPLAY/PRINT LOCATIONS (URD-6).
   /// </summary>
  public int RUDISPLAYPRINTLOCATIONSRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(6);
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
    /// Returns R/U RESULTS LEVEL(URD-7).
    /// </summary>
    public ID RURESULTSLEVEL
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(7, 0);
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