namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 GT1 message segment.
/// This segment has the following fields:<ol>
/// <li>GT1-1: SET ID - GUARANTOR (SI)</li>
/// <li>GT1-2: GUARANTOR NUMBER (ID)</li>
/// <li>GT1-3: GUARANTOR NAME (PN)</li>
/// <li>GT1-4: GUARANTOR SPOUSE NAME (PN)</li>
/// <li>GT1-5: GUARANTOR ADDRESS (AD)</li>
/// <li>GT1-6: GUARANTOR PH. NUM.- HOME (TN)</li>
/// <li>GT1-7: GUARANTOR PH. NUM-BUSINESS (TN)</li>
/// <li>GT1-8: GUARANTOR DATE OF BIRTH (DT)</li>
/// <li>GT1-9: GUARANTOR SEX (ID)</li>
/// <li>GT1-10: GUARANTOR TYPE (ID)</li>
/// <li>GT1-11: GUARANTOR RELATIONSHIP (ID)</li>
/// <li>GT1-12: GUARANTOR SSN (ST)</li>
/// <li>GT1-13: GUARANTOR DATE - BEGIN (DT)</li>
/// <li>GT1-14: GUARANTOR DATE - END (DT)</li>
/// <li>GT1-15: GUARANTOR PRIORITY (NM)</li>
/// <li>GT1-16: GUARANTOR EMPLOYER NAME (ST)</li>
/// <li>GT1-17: GUARANTOR EMPLOYER ADDRESS (AD)</li>
/// <li>GT1-18: GUARANTOR EMPLOY PHONE # (TN)</li>
/// <li>GT1-19: GUARANTOR EMPLOYEE ID NUM (ST)</li>
/// <li>GT1-20: GUARANTOR EMPLOYMENT STATUS (ID)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class GT1 : AbstractSegment  {

  /**
   * Creates a GT1 (GUARANTOR) segment object that belongs to the given
   * message.
   */
    public GT1(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(SI), true, 1, 4, new object[]{message}, "SET ID - GUARANTOR");
       add(typeof(ID), false, 1, 20, new object[]{message, 0}, "GUARANTOR NUMBER");
       add(typeof(PN), true, 1, 48, new object[]{message}, "GUARANTOR NAME");
       add(typeof(PN), false, 1, 48, new object[]{message}, "GUARANTOR SPOUSE NAME");
       add(typeof(AD), false, 1, 106, new object[]{message}, "GUARANTOR ADDRESS");
       add(typeof(TN), false, 1, 40, new object[]{message}, "GUARANTOR PH. NUM.- HOME");
       add(typeof(TN), false, 1, 40, new object[]{message}, "GUARANTOR PH. NUM-BUSINESS");
       add(typeof(DT), false, 1, 8, new object[]{message}, "GUARANTOR DATE OF BIRTH");
       add(typeof(ID), false, 1, 1, new object[]{message, 1}, "GUARANTOR SEX");
       add(typeof(ID), false, 1, 2, new object[]{message, 68}, "GUARANTOR TYPE");
       add(typeof(ID), false, 1, 2, new object[]{message, 63}, "GUARANTOR RELATIONSHIP");
       add(typeof(ST), false, 1, 11, new object[]{message}, "GUARANTOR SSN");
       add(typeof(DT), false, 1, 8, new object[]{message}, "GUARANTOR DATE - BEGIN");
       add(typeof(DT), false, 1, 8, new object[]{message}, "GUARANTOR DATE - END");
       add(typeof(NM), false, 1, 2, new object[]{message}, "GUARANTOR PRIORITY");
       add(typeof(ST), false, 1, 45, new object[]{message}, "GUARANTOR EMPLOYER NAME");
       add(typeof(AD), false, 1, 106, new object[]{message}, "GUARANTOR EMPLOYER ADDRESS");
       add(typeof(TN), false, 1, 40, new object[]{message}, "GUARANTOR EMPLOY PHONE #");
       add(typeof(ST), false, 1, 20, new object[]{message}, "GUARANTOR EMPLOYEE ID NUM");
       add(typeof(ID), false, 1, 2, new object[]{message, 66}, "GUARANTOR EMPLOYMENT STATUS");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns SET ID - GUARANTOR(GT1-1).
    /// </summary>
    public SI SETIDGUARANTOR
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
    /// Returns GUARANTOR NUMBER(GT1-2).
    /// </summary>
    public ID GUARANTORNUMBER
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
    /// Returns GUARANTOR NAME(GT1-3).
    /// </summary>
    public PN GUARANTORNAME
    {
        get{
            PN ret = null;
            try
            {
            var t = GetField(3, 0);
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
    /// Returns GUARANTOR SPOUSE NAME(GT1-4).
    /// </summary>
    public PN GUARANTORSPOUSENAME
    {
        get{
            PN ret = null;
            try
            {
            var t = GetField(4, 0);
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
    /// Returns GUARANTOR ADDRESS(GT1-5).
    /// </summary>
    public AD GUARANTORADDRESS
    {
        get{
            AD ret = null;
            try
            {
            var t = GetField(5, 0);
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
    /// Returns GUARANTOR PH. NUM.- HOME(GT1-6).
    /// </summary>
    public TN GUARANTORPHNUMHOME
    {
        get{
            TN ret = null;
            try
            {
            var t = GetField(6, 0);
                ret = (TN)t;
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
    /// Returns GUARANTOR PH. NUM-BUSINESS(GT1-7).
    /// </summary>
    public TN GUARANTORPHNUMBUSINESS
    {
        get{
            TN ret = null;
            try
            {
            var t = GetField(7, 0);
                ret = (TN)t;
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
    /// Returns GUARANTOR DATE OF BIRTH(GT1-8).
    /// </summary>
    public DT GUARANTORDATEOFBIRTH
    {
        get{
            DT ret = null;
            try
            {
            var t = GetField(8, 0);
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
    /// Returns GUARANTOR SEX(GT1-9).
    /// </summary>
    public ID GUARANTORSEX
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
    /// Returns GUARANTOR TYPE(GT1-10).
    /// </summary>
    public ID GUARANTORTYPE
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
    /// Returns GUARANTOR RELATIONSHIP(GT1-11).
    /// </summary>
    public ID GUARANTORRELATIONSHIP
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
    /// Returns GUARANTOR SSN(GT1-12).
    /// </summary>
    public ST GUARANTORSSN
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(12, 0);
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
    /// Returns GUARANTOR DATE - BEGIN(GT1-13).
    /// </summary>
    public DT GUARANTORDATEBEGIN
    {
        get{
            DT ret = null;
            try
            {
            var t = GetField(13, 0);
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
    /// Returns GUARANTOR DATE - END(GT1-14).
    /// </summary>
    public DT GUARANTORDATEEND
    {
        get{
            DT ret = null;
            try
            {
            var t = GetField(14, 0);
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
    /// Returns GUARANTOR PRIORITY(GT1-15).
    /// </summary>
    public NM GUARANTORPRIORITY
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(15, 0);
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
    /// Returns GUARANTOR EMPLOYER NAME(GT1-16).
    /// </summary>
    public ST GUARANTOREMPLOYERNAME
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(16, 0);
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
    /// Returns GUARANTOR EMPLOYER ADDRESS(GT1-17).
    /// </summary>
    public AD GUARANTOREMPLOYERADDRESS
    {
        get{
            AD ret = null;
            try
            {
            var t = GetField(17, 0);
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
    /// Returns GUARANTOR EMPLOY PHONE #(GT1-18).
    /// </summary>
    public TN GUARANTOREMPLOYPHONE
    {
        get{
            TN ret = null;
            try
            {
            var t = GetField(18, 0);
                ret = (TN)t;
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
    /// Returns GUARANTOR EMPLOYEE ID NUM(GT1-19).
    /// </summary>
    public ST GUARANTOREMPLOYEEIDNUM
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
    /// Returns GUARANTOR EMPLOYMENT STATUS(GT1-20).
    /// </summary>
    public ID GUARANTOREMPLOYMENTSTATUS
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(20, 0);
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