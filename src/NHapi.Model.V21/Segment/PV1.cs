namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 PV1 message segment.
/// This segment has the following fields:<ol>
/// <li>PV1-1: SET ID - PATIENT VISIT (SI)</li>
/// <li>PV1-2: PATIENT CLASS (ID)</li>
/// <li>PV1-3: ASSIGNED PATIENT LOCATION (ID)</li>
/// <li>PV1-4: ADMISSION TYPE (ID)</li>
/// <li>PV1-5: PRE-ADMIT NUMBER (ST)</li>
/// <li>PV1-6: PRIOR PATIENT LOCATION (ID)</li>
/// <li>PV1-7: ATTENDING DOCTOR (CN)</li>
/// <li>PV1-8: REFERRING DOCTOR (CN)</li>
/// <li>PV1-9: CONSULTING DOCTOR (CN)</li>
/// <li>PV1-10: HOSPITAL SERVICE (ID)</li>
/// <li>PV1-11: TEMPORARY LOCATION (ID)</li>
/// <li>PV1-12: PRE-ADMIT TEST INDICATOR (ID)</li>
/// <li>PV1-13: RE-ADMISSION INDICATOR (ID)</li>
/// <li>PV1-14: ADMIT SOURCE (ID)</li>
/// <li>PV1-15: AMBULATORY STATUS (ID)</li>
/// <li>PV1-16: VIP INDICATOR (ID)</li>
/// <li>PV1-17: ADMITTING DOCTOR (CN)</li>
/// <li>PV1-18: PATIENT TYPE (ID)</li>
/// <li>PV1-19: VISIT NUMBER (NM)</li>
/// <li>PV1-20: FINANCIAL CLASS (ID)</li>
/// <li>PV1-21: CHARGE PRICE INDICATOR (ID)</li>
/// <li>PV1-22: COURTESY CODE (ID)</li>
/// <li>PV1-23: CREDIT RATING (ID)</li>
/// <li>PV1-24: CONTRACT CODE (ID)</li>
/// <li>PV1-25: CONTRACT EFFECTIVE DATE (DT)</li>
/// <li>PV1-26: CONTRACT AMOUNT (NM)</li>
/// <li>PV1-27: CONTRACT PERIOD (NM)</li>
/// <li>PV1-28: INTEREST CODE (ID)</li>
/// <li>PV1-29: TRANSFER TO BAD DEBT CODE (ID)</li>
/// <li>PV1-30: TRANSFER TO BAD DEBT DATE (DT)</li>
/// <li>PV1-31: BAD DEBT AGENCY CODE (ST)</li>
/// <li>PV1-32: BAD DEBT TRANSFER AMOUNT (NM)</li>
/// <li>PV1-33: BAD DEBT RECOVERY AMOUNT (NM)</li>
/// <li>PV1-34: DELETE ACCOUNT INDICATOR (ID)</li>
/// <li>PV1-35: DELETE ACCOUNT DATE (DT)</li>
/// <li>PV1-36: DISCHARGE DISPOSITION (ID)</li>
/// <li>PV1-37: DISCHARGED TO LOCATION (ID)</li>
/// <li>PV1-38: DIET TYPE (ID)</li>
/// <li>PV1-39: SERVICING FACILITY (ID)</li>
/// <li>PV1-40: BED STATUS (ID)</li>
/// <li>PV1-41: ACCOUNT STATUS (ID)</li>
/// <li>PV1-42: PENDING LOCATION (ID)</li>
/// <li>PV1-43: PRIOR TEMPORARY LOCATION (ID)</li>
/// <li>PV1-44: ADMIT DATE/TIME (TS)</li>
/// <li>PV1-45: DISCHARGE DATE/TIME (TS)</li>
/// <li>PV1-46: CURRENT PATIENT BALANCE (NM)</li>
/// <li>PV1-47: TOTAL CHARGES (NM)</li>
/// <li>PV1-48: TOTAL ADJUSTMENTS (NM)</li>
/// <li>PV1-49: TOTAL PAYMENTS (NM)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class PV1 : AbstractSegment  {

  /**
   * Creates a PV1 (PATIENT VISIT) segment object that belongs to the given
   * message.
   */
    public PV1(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(SI), false, 1, 4, new object[]{message}, "SET ID - PATIENT VISIT");
       add(typeof(ID), true, 1, 1, new object[]{message, 4}, "PATIENT CLASS");
       add(typeof(ID), true, 1, 12, new object[]{message, 79}, "ASSIGNED PATIENT LOCATION");
       add(typeof(ID), false, 1, 2, new object[]{message, 7}, "ADMISSION TYPE");
       add(typeof(ST), false, 1, 20, new object[]{message}, "PRE-ADMIT NUMBER");
       add(typeof(ID), false, 1, 12, new object[]{message, 79}, "PRIOR PATIENT LOCATION");
       add(typeof(CN), false, 1, 60, new object[]{message}, "ATTENDING DOCTOR");
       add(typeof(CN), false, 1, 60, new object[]{message}, "REFERRING DOCTOR");
       add(typeof(CN), false, 0, 60, new object[]{message}, "CONSULTING DOCTOR");
       add(typeof(ID), false, 1, 3, new object[]{message, 69}, "HOSPITAL SERVICE");
       add(typeof(ID), false, 1, 12, new object[]{message, 79}, "TEMPORARY LOCATION");
       add(typeof(ID), false, 1, 2, new object[]{message, 87}, "PRE-ADMIT TEST INDICATOR");
       add(typeof(ID), false, 1, 2, new object[]{message, 92}, "RE-ADMISSION INDICATOR");
       add(typeof(ID), false, 1, 3, new object[]{message, 23}, "ADMIT SOURCE");
       add(typeof(ID), false, 1, 2, new object[]{message, 9}, "AMBULATORY STATUS");
       add(typeof(ID), false, 1, 2, new object[]{message, 99}, "VIP INDICATOR");
       add(typeof(CN), false, 1, 60, new object[]{message}, "ADMITTING DOCTOR");
       add(typeof(ID), false, 1, 2, new object[]{message, 18}, "PATIENT TYPE");
       add(typeof(NM), false, 1, 4, new object[]{message}, "VISIT NUMBER");
       add(typeof(ID), false, 4, 11, new object[]{message, 64}, "FINANCIAL CLASS");
       add(typeof(ID), false, 1, 2, new object[]{message, 32}, "CHARGE PRICE INDICATOR");
       add(typeof(ID), false, 1, 2, new object[]{message, 45}, "COURTESY CODE");
       add(typeof(ID), false, 1, 2, new object[]{message, 46}, "CREDIT RATING");
       add(typeof(ID), false, 0, 2, new object[]{message, 44}, "CONTRACT CODE");
       add(typeof(DT), false, 0, 8, new object[]{message}, "CONTRACT EFFECTIVE DATE");
       add(typeof(NM), false, 0, 12, new object[]{message}, "CONTRACT AMOUNT");
       add(typeof(NM), false, 0, 3, new object[]{message}, "CONTRACT PERIOD");
       add(typeof(ID), false, 1, 2, new object[]{message, 73}, "INTEREST CODE");
       add(typeof(ID), false, 1, 1, new object[]{message, 110}, "TRANSFER TO BAD DEBT CODE");
       add(typeof(DT), false, 1, 8, new object[]{message}, "TRANSFER TO BAD DEBT DATE");
       add(typeof(ST), false, 1, 10, new object[]{message}, "BAD DEBT AGENCY CODE");
       add(typeof(NM), false, 1, 12, new object[]{message}, "BAD DEBT TRANSFER AMOUNT");
       add(typeof(NM), false, 1, 12, new object[]{message}, "BAD DEBT RECOVERY AMOUNT");
       add(typeof(ID), false, 1, 1, new object[]{message, 111}, "DELETE ACCOUNT INDICATOR");
       add(typeof(DT), false, 1, 8, new object[]{message}, "DELETE ACCOUNT DATE");
       add(typeof(ID), false, 1, 2, new object[]{message, 112}, "DISCHARGE DISPOSITION");
       add(typeof(ID), false, 1, 2, new object[]{message, 113}, "DISCHARGED TO LOCATION");
       add(typeof(ID), false, 1, 2, new object[]{message, 114}, "DIET TYPE");
       add(typeof(ID), false, 1, 2, new object[]{message, 115}, "SERVICING FACILITY");
       add(typeof(ID), false, 1, 1, new object[]{message, 116}, "BED STATUS");
       add(typeof(ID), false, 1, 2, new object[]{message, 117}, "ACCOUNT STATUS");
       add(typeof(ID), false, 1, 12, new object[]{message, 79}, "PENDING LOCATION");
       add(typeof(ID), false, 1, 12, new object[]{message, 79}, "PRIOR TEMPORARY LOCATION");
       add(typeof(TS), false, 1, 19, new object[]{message}, "ADMIT DATE/TIME");
       add(typeof(TS), false, 1, 19, new object[]{message}, "DISCHARGE DATE/TIME");
       add(typeof(NM), false, 1, 12, new object[]{message}, "CURRENT PATIENT BALANCE");
       add(typeof(NM), false, 1, 12, new object[]{message}, "TOTAL CHARGES");
       add(typeof(NM), false, 1, 12, new object[]{message}, "TOTAL ADJUSTMENTS");
       add(typeof(NM), false, 1, 12, new object[]{message}, "TOTAL PAYMENTS");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns SET ID - PATIENT VISIT(PV1-1).
    /// </summary>
    public SI SETIDPATIENTVISIT
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
    /// Returns PATIENT CLASS(PV1-2).
    /// </summary>
    public ID PATIENTCLASS
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
    /// Returns ASSIGNED PATIENT LOCATION(PV1-3).
    /// </summary>
    public ID ASSIGNEDPATIENTLOCATION
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
    /// Returns ADMISSION TYPE(PV1-4).
    /// </summary>
    public ID ADMISSIONTYPE
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

    /// <summary>
    /// Returns PRE-ADMIT NUMBER(PV1-5).
    /// </summary>
    public ST PREADMITNUMBER
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(5, 0);
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
    /// Returns PRIOR PATIENT LOCATION(PV1-6).
    /// </summary>
    public ID PRIORPATIENTLOCATION
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
    /// Returns ATTENDING DOCTOR(PV1-7).
    /// </summary>
    public CN ATTENDINGDOCTOR
    {
        get{
            CN ret = null;
            try
            {
            var t = GetField(7, 0);
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
    /// Returns REFERRING DOCTOR(PV1-8).
    /// </summary>
    public CN REFERRINGDOCTOR
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
    /// Returns a single repetition of CONSULTING DOCTOR(PV1-9).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public CN GetCONSULTINGDOCTOR(int rep)
    {
            CN ret = null;
            try
            {
            var t = GetField(9, rep);
                ret = (CN)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of CONSULTING DOCTOR (PV1-9).
   /// </summary>
  public CN[] GetCONSULTINGDOCTOR() {
     CN[] ret = null;
    try {
        var t = GetField(9);
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
  /// Returns the total repetitions of CONSULTING DOCTOR (PV1-9).
   /// </summary>
  public int CONSULTINGDOCTORRepetitionsUsed
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
    /// Returns HOSPITAL SERVICE(PV1-10).
    /// </summary>
    public ID HOSPITALSERVICE
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
    /// Returns TEMPORARY LOCATION(PV1-11).
    /// </summary>
    public ID TEMPORARYLOCATION
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(11, 0);
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
    /// Returns PRE-ADMIT TEST INDICATOR(PV1-12).
    /// </summary>
    public ID PREADMITTESTINDICATOR
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
    /// Returns RE-ADMISSION INDICATOR(PV1-13).
    /// </summary>
    public ID READMISSIONINDICATOR
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

    /// <summary>
    /// Returns ADMIT SOURCE(PV1-14).
    /// </summary>
    public ID ADMITSOURCE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(14, 0);
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
    /// Returns AMBULATORY STATUS(PV1-15).
    /// </summary>
    public ID AMBULATORYSTATUS
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(15, 0);
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
    /// Returns VIP INDICATOR(PV1-16).
    /// </summary>
    public ID VIPINDICATOR
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
    /// Returns ADMITTING DOCTOR(PV1-17).
    /// </summary>
    public CN ADMITTINGDOCTOR
    {
        get{
            CN ret = null;
            try
            {
            var t = GetField(17, 0);
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
    /// Returns PATIENT TYPE(PV1-18).
    /// </summary>
    public ID PATIENTTYPE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(18, 0);
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
    /// Returns VISIT NUMBER(PV1-19).
    /// </summary>
    public NM VISITNUMBER
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(19, 0);
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
    /// Returns a single repetition of FINANCIAL CLASS(PV1-20).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public ID GetFINANCIALCLASS(int rep)
    {
            ID ret = null;
            try
            {
            var t = GetField(20, rep);
                ret = (ID)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of FINANCIAL CLASS (PV1-20).
   /// </summary>
  public ID[] GetFINANCIALCLASS() {
     ID[] ret = null;
    try {
        var t = GetField(20);
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
  /// Returns the total repetitions of FINANCIAL CLASS (PV1-20).
   /// </summary>
  public int FINANCIALCLASSRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(20);
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
    /// Returns CHARGE PRICE INDICATOR(PV1-21).
    /// </summary>
    public ID CHARGEPRICEINDICATOR
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(21, 0);
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
    /// Returns COURTESY CODE(PV1-22).
    /// </summary>
    public ID COURTESYCODE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(22, 0);
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
    /// Returns CREDIT RATING(PV1-23).
    /// </summary>
    public ID CREDITRATING
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(23, 0);
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
    /// Returns a single repetition of CONTRACT CODE(PV1-24).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public ID GetCONTRACTCODE(int rep)
    {
            ID ret = null;
            try
            {
            var t = GetField(24, rep);
                ret = (ID)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of CONTRACT CODE (PV1-24).
   /// </summary>
  public ID[] GetCONTRACTCODE() {
     ID[] ret = null;
    try {
        var t = GetField(24);
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
  /// Returns the total repetitions of CONTRACT CODE (PV1-24).
   /// </summary>
  public int CONTRACTCODERepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(24);
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
    /// Returns a single repetition of CONTRACT EFFECTIVE DATE(PV1-25).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public DT GetCONTRACTEFFECTIVEDATE(int rep)
    {
            DT ret = null;
            try
            {
            var t = GetField(25, rep);
                ret = (DT)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of CONTRACT EFFECTIVE DATE (PV1-25).
   /// </summary>
  public DT[] GetCONTRACTEFFECTIVEDATE() {
     DT[] ret = null;
    try {
        var t = GetField(25);
        ret = new DT[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (DT)t[i];
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
  /// Returns the total repetitions of CONTRACT EFFECTIVE DATE (PV1-25).
   /// </summary>
  public int CONTRACTEFFECTIVEDATERepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(25);
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
    /// Returns a single repetition of CONTRACT AMOUNT(PV1-26).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public NM GetCONTRACTAMOUNT(int rep)
    {
            NM ret = null;
            try
            {
            var t = GetField(26, rep);
                ret = (NM)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of CONTRACT AMOUNT (PV1-26).
   /// </summary>
  public NM[] GetCONTRACTAMOUNT() {
     NM[] ret = null;
    try {
        var t = GetField(26);
        ret = new NM[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (NM)t[i];
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
  /// Returns the total repetitions of CONTRACT AMOUNT (PV1-26).
   /// </summary>
  public int CONTRACTAMOUNTRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(26);
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
    /// Returns a single repetition of CONTRACT PERIOD(PV1-27).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public NM GetCONTRACTPERIOD(int rep)
    {
            NM ret = null;
            try
            {
            var t = GetField(27, rep);
                ret = (NM)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of CONTRACT PERIOD (PV1-27).
   /// </summary>
  public NM[] GetCONTRACTPERIOD() {
     NM[] ret = null;
    try {
        var t = GetField(27);
        ret = new NM[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (NM)t[i];
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
  /// Returns the total repetitions of CONTRACT PERIOD (PV1-27).
   /// </summary>
  public int CONTRACTPERIODRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(27);
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
    /// Returns INTEREST CODE(PV1-28).
    /// </summary>
    public ID INTERESTCODE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(28, 0);
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
    /// Returns TRANSFER TO BAD DEBT CODE(PV1-29).
    /// </summary>
    public ID TRANSFERTOBADDEBTCODE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(29, 0);
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
    /// Returns TRANSFER TO BAD DEBT DATE(PV1-30).
    /// </summary>
    public DT TRANSFERTOBADDEBTDATE
    {
        get{
            DT ret = null;
            try
            {
            var t = GetField(30, 0);
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
    /// Returns BAD DEBT AGENCY CODE(PV1-31).
    /// </summary>
    public ST BADDEBTAGENCYCODE
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(31, 0);
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
    /// Returns BAD DEBT TRANSFER AMOUNT(PV1-32).
    /// </summary>
    public NM BADDEBTTRANSFERAMOUNT
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(32, 0);
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
    /// Returns BAD DEBT RECOVERY AMOUNT(PV1-33).
    /// </summary>
    public NM BADDEBTRECOVERYAMOUNT
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(33, 0);
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
    /// Returns DELETE ACCOUNT INDICATOR(PV1-34).
    /// </summary>
    public ID DELETEACCOUNTINDICATOR
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(34, 0);
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
    /// Returns DELETE ACCOUNT DATE(PV1-35).
    /// </summary>
    public DT DELETEACCOUNTDATE
    {
        get{
            DT ret = null;
            try
            {
            var t = GetField(35, 0);
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
    /// Returns DISCHARGE DISPOSITION(PV1-36).
    /// </summary>
    public ID DISCHARGEDISPOSITION
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(36, 0);
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
    /// Returns DISCHARGED TO LOCATION(PV1-37).
    /// </summary>
    public ID DISCHARGEDTOLOCATION
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(37, 0);
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
    /// Returns DIET TYPE(PV1-38).
    /// </summary>
    public ID DIETTYPE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(38, 0);
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
    /// Returns SERVICING FACILITY(PV1-39).
    /// </summary>
    public ID SERVICINGFACILITY
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(39, 0);
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
    /// Returns BED STATUS(PV1-40).
    /// </summary>
    public ID BEDSTATUS
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(40, 0);
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
    /// Returns ACCOUNT STATUS(PV1-41).
    /// </summary>
    public ID ACCOUNTSTATUS
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(41, 0);
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
    /// Returns PENDING LOCATION(PV1-42).
    /// </summary>
    public ID PENDINGLOCATION
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(42, 0);
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
    /// Returns PRIOR TEMPORARY LOCATION(PV1-43).
    /// </summary>
    public ID PRIORTEMPORARYLOCATION
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(43, 0);
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
    /// Returns ADMIT DATE/TIME(PV1-44).
    /// </summary>
    public TS ADMITDATETIME
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(44, 0);
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
    /// Returns DISCHARGE DATE/TIME(PV1-45).
    /// </summary>
    public TS DISCHARGEDATETIME
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(45, 0);
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
    /// Returns CURRENT PATIENT BALANCE(PV1-46).
    /// </summary>
    public NM CURRENTPATIENTBALANCE
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(46, 0);
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
    /// Returns TOTAL CHARGES(PV1-47).
    /// </summary>
    public NM TOTALCHARGES
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(47, 0);
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
    /// Returns TOTAL ADJUSTMENTS(PV1-48).
    /// </summary>
    public NM TOTALADJUSTMENTS
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(48, 0);
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
    /// Returns TOTAL PAYMENTS(PV1-49).
    /// </summary>
    public NM TOTALPAYMENTS
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(49, 0);
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
}}