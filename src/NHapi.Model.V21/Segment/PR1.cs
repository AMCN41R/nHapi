namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 PR1 message segment.
/// This segment has the following fields:<ol>
/// <li>PR1-1: SET ID - PROCEDURE (SI)</li>
/// <li>PR1-2: PROCEDURE CODING METHOD. (ID)</li>
/// <li>PR1-3: PROCEDURE CODE (ID)</li>
/// <li>PR1-4: PROCEDURE DESCRIPTION (ST)</li>
/// <li>PR1-5: PROCEDURE DATE/TIME (TS)</li>
/// <li>PR1-6: PROCEDURE TYPE (ID)</li>
/// <li>PR1-7: PROCEDURE MINUTES (NM)</li>
/// <li>PR1-8: ANESTHESIOLOGIST (CN)</li>
/// <li>PR1-9: ANESTHESIA CODE (ID)</li>
/// <li>PR1-10: ANESTHESIA MINUTES (NM)</li>
/// <li>PR1-11: SURGEON (CN)</li>
/// <li>PR1-12: RESIDENT CODE (CN)</li>
/// <li>PR1-13: CONSENT CODE (ID)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class PR1 : AbstractSegment  {

  /**
   * Creates a PR1 (PROCEDURES) segment object that belongs to the given
   * message.
   */
    public PR1(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(SI), true, 0, 4, new object[]{message}, "SET ID - PROCEDURE");
       add(typeof(ID), true, 1, 2, new object[]{message, 89}, "PROCEDURE CODING METHOD.");
       add(typeof(ID), true, 1, 10, new object[]{message, 88}, "PROCEDURE CODE");
       add(typeof(ST), false, 1, 40, new object[]{message}, "PROCEDURE DESCRIPTION");
       add(typeof(TS), true, 1, 19, new object[]{message}, "PROCEDURE DATE/TIME");
       add(typeof(ID), true, 1, 2, new object[]{message, 90}, "PROCEDURE TYPE");
       add(typeof(NM), false, 1, 4, new object[]{message}, "PROCEDURE MINUTES");
       add(typeof(CN), false, 1, 60, new object[]{message}, "ANESTHESIOLOGIST");
       add(typeof(ID), false, 1, 2, new object[]{message, 19}, "ANESTHESIA CODE");
       add(typeof(NM), false, 1, 4, new object[]{message}, "ANESTHESIA MINUTES");
       add(typeof(CN), false, 1, 60, new object[]{message}, "SURGEON");
       add(typeof(CN), false, 1, 60, new object[]{message}, "RESIDENT CODE");
       add(typeof(ID), false, 1, 2, new object[]{message, 59}, "CONSENT CODE");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns a single repetition of SET ID - PROCEDURE(PR1-1).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public SI GetSETIDPROCEDURE(int rep)
    {
            SI ret = null;
            try
            {
            var t = GetField(1, rep);
                ret = (SI)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of SET ID - PROCEDURE (PR1-1).
   /// </summary>
  public SI[] GetSETIDPROCEDURE() {
     SI[] ret = null;
    try {
        var t = GetField(1);
        ret = new SI[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (SI)t[i];
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
  /// Returns the total repetitions of SET ID - PROCEDURE (PR1-1).
   /// </summary>
  public int SETIDPROCEDURERepetitionsUsed
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
    /// Returns PROCEDURE CODING METHOD.(PR1-2).
    /// </summary>
    public ID PROCEDURECODINGMETHOD
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
    /// Returns PROCEDURE CODE(PR1-3).
    /// </summary>
    public ID PROCEDURECODE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(3, 0);
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
    /// Returns PROCEDURE DESCRIPTION(PR1-4).
    /// </summary>
    public ST PROCEDUREDESCRIPTION
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(4, 0);
                ret = (ST)t;
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
    /// Returns PROCEDURE DATE/TIME(PR1-5).
    /// </summary>
    public TS PROCEDUREDATETIME
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(5, 0);
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
    /// Returns PROCEDURE TYPE(PR1-6).
    /// </summary>
    public ID PROCEDURETYPE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(6, 0);
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
    /// Returns PROCEDURE MINUTES(PR1-7).
    /// </summary>
    public NM PROCEDUREMINUTES
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(7, 0);
                ret = (NM)t;
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
    /// Returns ANESTHESIOLOGIST(PR1-8).
    /// </summary>
    public CN ANESTHESIOLOGIST
    {
        get{
            CN ret = null;
            try
            {
            var t = GetField(8, 0);
                ret = (CN)t;
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
    /// Returns ANESTHESIA CODE(PR1-9).
    /// </summary>
    public ID ANESTHESIACODE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(9, 0);
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
    /// Returns ANESTHESIA MINUTES(PR1-10).
    /// </summary>
    public NM ANESTHESIAMINUTES
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(10, 0);
                ret = (NM)t;
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
    /// Returns SURGEON(PR1-11).
    /// </summary>
    public CN SURGEON
    {
        get{
            CN ret = null;
            try
            {
            var t = GetField(11, 0);
                ret = (CN)t;
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
    /// Returns RESIDENT CODE(PR1-12).
    /// </summary>
    public CN RESIDENTCODE
    {
        get{
            CN ret = null;
            try
            {
            var t = GetField(12, 0);
                ret = (CN)t;
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
    /// Returns CONSENT CODE(PR1-13).
    /// </summary>
    public ID CONSENTCODE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(13, 0);
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