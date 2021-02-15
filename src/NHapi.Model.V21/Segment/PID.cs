namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 PID message segment.
/// This segment has the following fields:<ol>
/// <li>PID-1: SET ID - PATIENT ID (SI)</li>
/// <li>PID-2: PATIENT ID EXTERNAL (EXTERNAL ID) (CK)</li>
/// <li>PID-3: PATIENT ID INTERNAL (INTERNAL ID) (CK)</li>
/// <li>PID-4: ALTERNATE PATIENT ID (ST)</li>
/// <li>PID-5: PATIENT NAME (PN)</li>
/// <li>PID-6: MOTHER'S MAIDEN NAME (ST)</li>
/// <li>PID-7: DATE OF BIRTH (DT)</li>
/// <li>PID-8: SEX (ID)</li>
/// <li>PID-9: PATIENT ALIAS (PN)</li>
/// <li>PID-10: ETHNIC GROUP (ID)</li>
/// <li>PID-11: PATIENT ADDRESS (AD)</li>
/// <li>PID-12: COUNTY CODE (ID)</li>
/// <li>PID-13: PHONE NUMBER - HOME (TN)</li>
/// <li>PID-14: PHONE NUMBER - BUSINESS (TN)</li>
/// <li>PID-15: LANGUAGE - PATIENT (ST)</li>
/// <li>PID-16: MARITAL STATUS (ID)</li>
/// <li>PID-17: RELIGION (ID)</li>
/// <li>PID-18: PATIENT ACCOUNT NUMBER (CK)</li>
/// <li>PID-19: SSN NUMBER - PATIENT (ST)</li>
/// <li>PID-20: DRIVER'S LIC NUM - PATIENT (CM)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class PID : AbstractSegment  {

  /**
   * Creates a PID (PATIENT IDENTIFICATION) segment object that belongs to the given
   * message.
   */
    public PID(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(SI), false, 1, 4, new object[]{message}, "SET ID - PATIENT ID");
       add(typeof(CK), false, 1, 16, new object[]{message}, "PATIENT ID EXTERNAL (EXTERNAL ID)");
       add(typeof(CK), true, 1, 16, new object[]{message}, "PATIENT ID INTERNAL (INTERNAL ID)");
       add(typeof(ST), false, 1, 12, new object[]{message}, "ALTERNATE PATIENT ID");
       add(typeof(PN), true, 1, 48, new object[]{message}, "PATIENT NAME");
       add(typeof(ST), false, 1, 30, new object[]{message}, "MOTHER'S MAIDEN NAME");
       add(typeof(DT), false, 1, 8, new object[]{message}, "DATE OF BIRTH");
       add(typeof(ID), false, 1, 1, new object[]{message, 1}, "SEX");
       add(typeof(PN), false, 0, 48, new object[]{message}, "PATIENT ALIAS");
       add(typeof(ID), false, 1, 1, new object[]{message, 5}, "ETHNIC GROUP");
       add(typeof(AD), false, 1, 106, new object[]{message}, "PATIENT ADDRESS");
       add(typeof(ID), false, 1, 4, new object[]{message, 0}, "COUNTY CODE");
       add(typeof(TN), false, 3, 40, new object[]{message}, "PHONE NUMBER - HOME");
       add(typeof(TN), false, 3, 40, new object[]{message}, "PHONE NUMBER - BUSINESS");
       add(typeof(ST), false, 1, 25, new object[]{message}, "LANGUAGE - PATIENT");
       add(typeof(ID), false, 1, 1, new object[]{message, 2}, "MARITAL STATUS");
       add(typeof(ID), false, 1, 3, new object[]{message, 6}, "RELIGION");
       add(typeof(CK), false, 1, 20, new object[]{message}, "PATIENT ACCOUNT NUMBER");
       add(typeof(ST), false, 1, 16, new object[]{message}, "SSN NUMBER - PATIENT");
       add(typeof(CM), false, 1, 25, new object[]{message}, "DRIVER'S LIC NUM - PATIENT");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns SET ID - PATIENT ID(PID-1).
    /// </summary>
    public SI SETIDPATIENTID
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
    /// Returns PATIENT ID EXTERNAL (EXTERNAL ID)(PID-2).
    /// </summary>
    public CK PATIENTIDEXTERNALEXTERNALID
    {
        get{
            CK ret = null;
            try
            {
            var t = GetField(2, 0);
                ret = (CK)t;
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
    /// Returns PATIENT ID INTERNAL (INTERNAL ID)(PID-3).
    /// </summary>
    public CK PATIENTIDINTERNALINTERNALID
    {
        get{
            CK ret = null;
            try
            {
            var t = GetField(3, 0);
                ret = (CK)t;
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
    /// Returns ALTERNATE PATIENT ID(PID-4).
    /// </summary>
    public ST ALTERNATEPATIENTID
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
    /// Returns PATIENT NAME(PID-5).
    /// </summary>
    public PN PATIENTNAME
    {
        get{
            PN ret = null;
            try
            {
            var t = GetField(5, 0);
                ret = (PN)t;
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
    /// Returns MOTHER'S MAIDEN NAME(PID-6).
    /// </summary>
    public ST MOTHERSMAIDENNAME
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(6, 0);
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
    /// Returns DATE OF BIRTH(PID-7).
    /// </summary>
    public DT DATEOFBIRTH
    {
        get{
            DT ret = null;
            try
            {
            var t = GetField(7, 0);
                ret = (DT)t;
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
    /// Returns SEX(PID-8).
    /// </summary>
    public ID SEX
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(8, 0);
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
    /// Returns a single repetition of PATIENT ALIAS(PID-9).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public PN GetPATIENTALIAS(int rep)
    {
            PN ret = null;
            try
            {
            var t = GetField(9, rep);
                ret = (PN)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of PATIENT ALIAS (PID-9).
   /// </summary>
  public PN[] GetPATIENTALIAS() {
     PN[] ret = null;
    try {
        var t = GetField(9);
        ret = new PN[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (PN)t[i];
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
  /// Returns the total repetitions of PATIENT ALIAS (PID-9).
   /// </summary>
  public int PATIENTALIASRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(9);
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
    /// Returns ETHNIC GROUP(PID-10).
    /// </summary>
    public ID ETHNICGROUP
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(10, 0);
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
    /// Returns PATIENT ADDRESS(PID-11).
    /// </summary>
    public AD PATIENTADDRESS
    {
        get{
            AD ret = null;
            try
            {
            var t = GetField(11, 0);
                ret = (AD)t;
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
    /// Returns COUNTY CODE(PID-12).
    /// </summary>
    public ID COUNTYCODE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(12, 0);
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
    /// Returns a single repetition of PHONE NUMBER - HOME(PID-13).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public TN GetPHONENUMBERHOME(int rep)
    {
            TN ret = null;
            try
            {
            var t = GetField(13, rep);
                ret = (TN)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of PHONE NUMBER - HOME (PID-13).
   /// </summary>
  public TN[] GetPHONENUMBERHOME() {
     TN[] ret = null;
    try {
        var t = GetField(13);
        ret = new TN[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (TN)t[i];
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
  /// Returns the total repetitions of PHONE NUMBER - HOME (PID-13).
   /// </summary>
  public int PHONENUMBERHOMERepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(13);
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
    /// Returns a single repetition of PHONE NUMBER - BUSINESS(PID-14).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public TN GetPHONENUMBERBUSINESS(int rep)
    {
            TN ret = null;
            try
            {
            var t = GetField(14, rep);
                ret = (TN)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of PHONE NUMBER - BUSINESS (PID-14).
   /// </summary>
  public TN[] GetPHONENUMBERBUSINESS() {
     TN[] ret = null;
    try {
        var t = GetField(14);
        ret = new TN[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (TN)t[i];
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
  /// Returns the total repetitions of PHONE NUMBER - BUSINESS (PID-14).
   /// </summary>
  public int PHONENUMBERBUSINESSRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(14);
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
    /// Returns LANGUAGE - PATIENT(PID-15).
    /// </summary>
    public ST LANGUAGEPATIENT
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(15, 0);
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
    /// Returns MARITAL STATUS(PID-16).
    /// </summary>
    public ID MARITALSTATUS
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(16, 0);
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
    /// Returns RELIGION(PID-17).
    /// </summary>
    public ID RELIGION
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(17, 0);
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
    /// Returns PATIENT ACCOUNT NUMBER(PID-18).
    /// </summary>
    public CK PATIENTACCOUNTNUMBER
    {
        get{
            CK ret = null;
            try
            {
            var t = GetField(18, 0);
                ret = (CK)t;
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
    /// Returns SSN NUMBER - PATIENT(PID-19).
    /// </summary>
    public ST SSNNUMBERPATIENT
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(19, 0);
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
    /// Returns DRIVER'S LIC NUM - PATIENT(PID-20).
    /// </summary>
    public CM DRIVERSLICNUMPATIENT
    {
        get{
            CM ret = null;
            try
            {
            var t = GetField(20, 0);
                ret = (CM)t;
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