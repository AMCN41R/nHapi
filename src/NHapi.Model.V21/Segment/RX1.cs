namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 RX1 message segment.
/// This segment has the following fields:<ol>
/// <li>RX1-1: UNUSED (ST)</li>
/// <li>RX1-2: UNUSED (ST)</li>
/// <li>RX1-3: ROUTE (ST)</li>
/// <li>RX1-4: SITE ADMINISTERED (ST)</li>
/// <li>RX1-5: IV SOLUTION RATE (CQ)</li>
/// <li>RX1-6: DRUG STRENGTH (CQ)</li>
/// <li>RX1-7: FINAL CONCENTRATION (NM)</li>
/// <li>RX1-8: FINAL VOLUME IN ML. (NM)</li>
/// <li>RX1-9: DRUG DOSE (CM)</li>
/// <li>RX1-10: DRUG ROLE (ID)</li>
/// <li>RX1-11: PRESCRIPTION SEQUENCE # (NM)</li>
/// <li>RX1-12: QUANTITY DISPENSED (CQ)</li>
/// <li>RX1-13: UNUSED (ST)</li>
/// <li>RX1-14: DRUG ID (CE)</li>
/// <li>RX1-15: COMPONENT DRUG IDS (ID)</li>
/// <li>RX1-16: PRESCRIPTION TYPE (ID)</li>
/// <li>RX1-17: SUBSTITUTION STATUS (ID)</li>
/// <li>RX1-18: RX ORDER STATUS (ID)</li>
/// <li>RX1-19: NUMBER OF REFILLS (NM)</li>
/// <li>RX1-20: UNUSED (ST)</li>
/// <li>RX1-21: REFILLS REMAINING (NM)</li>
/// <li>RX1-22: DEA CLASS (ID)</li>
/// <li>RX1-23: ORDERING MD'S DEA NUMBER (NM)</li>
/// <li>RX1-24: UNUSED (ST)</li>
/// <li>RX1-25: LAST REFILL DATE/TIME (TS)</li>
/// <li>RX1-26: RX NUMBER (ST)</li>
/// <li>RX1-27: PRN STATUS (ID)</li>
/// <li>RX1-28: PHARMACY INSTRUCTIONS (TX)</li>
/// <li>RX1-29: PATIENT INSTRUCTIONS (TX)</li>
/// <li>RX1-30: INSTRUCTIONS (SIG) (TX)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class RX1 : AbstractSegment  {

  /**
   * Creates a RX1 (PHARMACY ORDER) segment object that belongs to the given
   * message.
   */
    public RX1(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(ST), false, 1, 0, new object[]{message}, "UNUSED");
       add(typeof(ST), false, 1, 0, new object[]{message}, "UNUSED");
       add(typeof(ST), false, 1, 8, new object[]{message}, "ROUTE");
       add(typeof(ST), false, 1, 20, new object[]{message}, "SITE ADMINISTERED");
       add(typeof(CQ), false, 1, 10, new object[]{message}, "IV SOLUTION RATE");
       add(typeof(CQ), false, 1, 14, new object[]{message}, "DRUG STRENGTH");
       add(typeof(NM), false, 1, 10, new object[]{message}, "FINAL CONCENTRATION");
       add(typeof(NM), false, 1, 10, new object[]{message}, "FINAL VOLUME IN ML.");
       add(typeof(CM), false, 1, 10, new object[]{message}, "DRUG DOSE");
       add(typeof(ID), false, 1, 1, new object[]{message, 0}, "DRUG ROLE");
       add(typeof(NM), false, 1, 3, new object[]{message}, "PRESCRIPTION SEQUENCE #");
       add(typeof(CQ), false, 1, 4, new object[]{message}, "QUANTITY DISPENSED");
       add(typeof(ST), false, 1, 0, new object[]{message}, "UNUSED");
       add(typeof(CE), false, 1, 5, new object[]{message}, "DRUG ID");
       add(typeof(ID), false, 5, 5, new object[]{message, 0}, "COMPONENT DRUG IDS");
       add(typeof(ID), false, 1, 2, new object[]{message, 0}, "PRESCRIPTION TYPE");
       add(typeof(ID), false, 1, 1, new object[]{message, 0}, "SUBSTITUTION STATUS");
       add(typeof(ID), false, 1, 2, new object[]{message, 38}, "RX ORDER STATUS");
       add(typeof(NM), false, 1, 3, new object[]{message}, "NUMBER OF REFILLS");
       add(typeof(ST), false, 1, 0, new object[]{message}, "UNUSED");
       add(typeof(NM), false, 1, 3, new object[]{message}, "REFILLS REMAINING");
       add(typeof(ID), false, 1, 5, new object[]{message, 0}, "DEA CLASS");
       add(typeof(NM), false, 1, 10, new object[]{message}, "ORDERING MD'S DEA NUMBER");
       add(typeof(ST), false, 1, 0, new object[]{message}, "UNUSED");
       add(typeof(TS), false, 1, 19, new object[]{message}, "LAST REFILL DATE/TIME");
       add(typeof(ST), false, 1, 20, new object[]{message}, "RX NUMBER");
       add(typeof(ID), false, 1, 5, new object[]{message, 0}, "PRN STATUS");
       add(typeof(TX), false, 5, 80, new object[]{message}, "PHARMACY INSTRUCTIONS");
       add(typeof(TX), false, 5, 80, new object[]{message}, "PATIENT INSTRUCTIONS");
       add(typeof(TX), false, 0, 500, new object[]{message}, "INSTRUCTIONS (SIG)");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns ROUTE(RX1-3).
    /// </summary>
    public ST ROUTE
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(3, 0);
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
    /// Returns SITE ADMINISTERED(RX1-4).
    /// </summary>
    public ST SITEADMINISTERED
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
    /// Returns IV SOLUTION RATE(RX1-5).
    /// </summary>
    public CQ IVSOLUTIONRATE
    {
        get{
            CQ ret = null;
            try
            {
            var t = GetField(5, 0);
                ret = (CQ)t;
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
    /// Returns DRUG STRENGTH(RX1-6).
    /// </summary>
    public CQ DRUGSTRENGTH
    {
        get{
            CQ ret = null;
            try
            {
            var t = GetField(6, 0);
                ret = (CQ)t;
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
    /// Returns FINAL CONCENTRATION(RX1-7).
    /// </summary>
    public NM FINALCONCENTRATION
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
    /// Returns FINAL VOLUME IN ML.(RX1-8).
    /// </summary>
    public NM FINALVOLUMEINML
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(8, 0);
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
    /// Returns DRUG DOSE(RX1-9).
    /// </summary>
    public CM DRUGDOSE
    {
        get{
            CM ret = null;
            try
            {
            var t = GetField(9, 0);
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

    /// <summary>
    /// Returns DRUG ROLE(RX1-10).
    /// </summary>
    public ID DRUGROLE
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
    /// Returns PRESCRIPTION SEQUENCE #(RX1-11).
    /// </summary>
    public NM PRESCRIPTIONSEQUENCE
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(11, 0);
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
    /// Returns QUANTITY DISPENSED(RX1-12).
    /// </summary>
    public CQ QUANTITYDISPENSED
    {
        get{
            CQ ret = null;
            try
            {
            var t = GetField(12, 0);
                ret = (CQ)t;
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
    /// Returns DRUG ID(RX1-14).
    /// </summary>
    public CE DRUGID
    {
        get{
            CE ret = null;
            try
            {
            var t = GetField(14, 0);
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
    /// Returns a single repetition of COMPONENT DRUG IDS(RX1-15).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public ID GetCOMPONENTDRUGIDS(int rep)
    {
            ID ret = null;
            try
            {
            var t = GetField(15, rep);
                ret = (ID)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of COMPONENT DRUG IDS (RX1-15).
   /// </summary>
  public ID[] GetCOMPONENTDRUGIDS() {
     ID[] ret = null;
    try {
        var t = GetField(15);
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
  /// Returns the total repetitions of COMPONENT DRUG IDS (RX1-15).
   /// </summary>
  public int COMPONENTDRUGIDSRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(15);
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
    /// Returns PRESCRIPTION TYPE(RX1-16).
    /// </summary>
    public ID PRESCRIPTIONTYPE
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
    /// Returns SUBSTITUTION STATUS(RX1-17).
    /// </summary>
    public ID SUBSTITUTIONSTATUS
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
    /// Returns RX ORDER STATUS(RX1-18).
    /// </summary>
    public ID RXORDERSTATUS
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
    /// Returns NUMBER OF REFILLS(RX1-19).
    /// </summary>
    public NM NUMBEROFREFILLS
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
    /// Returns REFILLS REMAINING(RX1-21).
    /// </summary>
    public NM REFILLSREMAINING
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(21, 0);
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
    /// Returns DEA CLASS(RX1-22).
    /// </summary>
    public ID DEACLASS
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
    /// Returns ORDERING MD'S DEA NUMBER(RX1-23).
    /// </summary>
    public NM ORDERINGMDSDEANUMBER
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(23, 0);
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
    /// Returns LAST REFILL DATE/TIME(RX1-25).
    /// </summary>
    public TS LASTREFILLDATETIME
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(25, 0);
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
    /// Returns RX NUMBER(RX1-26).
    /// </summary>
    public ST RXNUMBER
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(26, 0);
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
    /// Returns PRN STATUS(RX1-27).
    /// </summary>
    public ID PRNSTATUS
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(27, 0);
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
    /// Returns a single repetition of PHARMACY INSTRUCTIONS(RX1-28).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public TX GetPHARMACYINSTRUCTIONS(int rep)
    {
            TX ret = null;
            try
            {
            var t = GetField(28, rep);
                ret = (TX)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of PHARMACY INSTRUCTIONS (RX1-28).
   /// </summary>
  public TX[] GetPHARMACYINSTRUCTIONS() {
     TX[] ret = null;
    try {
        var t = GetField(28);
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
  /// Returns the total repetitions of PHARMACY INSTRUCTIONS (RX1-28).
   /// </summary>
  public int PHARMACYINSTRUCTIONSRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(28);
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
    /// Returns a single repetition of PATIENT INSTRUCTIONS(RX1-29).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public TX GetPATIENTINSTRUCTIONS(int rep)
    {
            TX ret = null;
            try
            {
            var t = GetField(29, rep);
                ret = (TX)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of PATIENT INSTRUCTIONS (RX1-29).
   /// </summary>
  public TX[] GetPATIENTINSTRUCTIONS() {
     TX[] ret = null;
    try {
        var t = GetField(29);
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
  /// Returns the total repetitions of PATIENT INSTRUCTIONS (RX1-29).
   /// </summary>
  public int PATIENTINSTRUCTIONSRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(29);
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
    /// Returns a single repetition of INSTRUCTIONS (SIG)(RX1-30).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public TX GetINSTRUCTIONS(int rep)
    {
            TX ret = null;
            try
            {
            var t = GetField(30, rep);
                ret = (TX)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of INSTRUCTIONS (SIG) (RX1-30).
   /// </summary>
  public TX[] GetINSTRUCTIONS() {
     TX[] ret = null;
    try {
        var t = GetField(30);
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
  /// Returns the total repetitions of INSTRUCTIONS (SIG) (RX1-30).
   /// </summary>
  public int INSTRUCTIONSRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(30);
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