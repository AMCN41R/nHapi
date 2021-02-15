namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 FT1 message segment.
/// This segment has the following fields:<ol>
/// <li>FT1-1: SET ID - FINANCIAL TRANSACTION (SI)</li>
/// <li>FT1-2: TRANSACTION ID (ST)</li>
/// <li>FT1-3: TRANSACTION BATCH ID (ST)</li>
/// <li>FT1-4: TRANSACTION DATE (DT)</li>
/// <li>FT1-5: TRANSACTION POSTING DATE (DT)</li>
/// <li>FT1-6: TRANSACTION TYPE (ID)</li>
/// <li>FT1-7: TRANSACTION CODE (ID)</li>
/// <li>FT1-8: TRANSACTION DESCRIPTION (ST)</li>
/// <li>FT1-9: TRANSACTION DESCRIPTION - ALT (ST)</li>
/// <li>FT1-10: TRANSACTION AMOUNT - EXTENDED (NM)</li>
/// <li>FT1-11: TRANSACTION QUANTITY (NM)</li>
/// <li>FT1-12: TRANSACTION AMOUNT - UNIT (NM)</li>
/// <li>FT1-13: DEPARTMENT CODE (ST)</li>
/// <li>FT1-14: INSURANCE PLAN ID (ID)</li>
/// <li>FT1-15: INSURANCE AMOUNT (NM)</li>
/// <li>FT1-16: PATIENT LOCATION (ST)</li>
/// <li>FT1-17: FEE SCHEDULE (ID)</li>
/// <li>FT1-18: PATIENT TYPE (ID)</li>
/// <li>FT1-19: DIAGNOSIS CODE (ID)</li>
/// <li>FT1-20: PERFORMED BY CODE (CN)</li>
/// <li>FT1-21: ORDERED BY CODE (CN)</li>
/// <li>FT1-22: UNIT COST (NM)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class FT1 : AbstractSegment  {

  /**
   * Creates a FT1 (FINANCIAL TRANSACTION) segment object that belongs to the given
   * message.
   */
    public FT1(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(SI), false, 1, 4, new object[]{message}, "SET ID - FINANCIAL TRANSACTION");
       add(typeof(ST), false, 1, 12, new object[]{message}, "TRANSACTION ID");
       add(typeof(ST), false, 1, 5, new object[]{message}, "TRANSACTION BATCH ID");
       add(typeof(DT), true, 1, 8, new object[]{message}, "TRANSACTION DATE");
       add(typeof(DT), false, 1, 8, new object[]{message}, "TRANSACTION POSTING DATE");
       add(typeof(ID), true, 1, 8, new object[]{message, 17}, "TRANSACTION TYPE");
       add(typeof(ID), true, 1, 20, new object[]{message, 96}, "TRANSACTION CODE");
       add(typeof(ST), false, 1, 40, new object[]{message}, "TRANSACTION DESCRIPTION");
       add(typeof(ST), false, 1, 40, new object[]{message}, "TRANSACTION DESCRIPTION - ALT");
       add(typeof(NM), false, 1, 12, new object[]{message}, "TRANSACTION AMOUNT - EXTENDED");
       add(typeof(NM), false, 1, 4, new object[]{message}, "TRANSACTION QUANTITY");
       add(typeof(NM), false, 1, 12, new object[]{message}, "TRANSACTION AMOUNT - UNIT");
       add(typeof(ST), false, 1, 16, new object[]{message}, "DEPARTMENT CODE");
       add(typeof(ID), false, 1, 8, new object[]{message, 72}, "INSURANCE PLAN ID");
       add(typeof(NM), false, 1, 12, new object[]{message}, "INSURANCE AMOUNT");
       add(typeof(ST), false, 1, 12, new object[]{message}, "PATIENT LOCATION");
       add(typeof(ID), false, 1, 1, new object[]{message, 24}, "FEE SCHEDULE");
       add(typeof(ID), false, 1, 2, new object[]{message, 18}, "PATIENT TYPE");
       add(typeof(ID), false, 1, 8, new object[]{message, 51}, "DIAGNOSIS CODE");
       add(typeof(CN), false, 1, 60, new object[]{message}, "PERFORMED BY CODE");
       add(typeof(CN), false, 1, 60, new object[]{message}, "ORDERED BY CODE");
       add(typeof(NM), false, 1, 12, new object[]{message}, "UNIT COST");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns SET ID - FINANCIAL TRANSACTION(FT1-1).
    /// </summary>
    public SI SETIDFINANCIALTRANSACTION
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
    /// Returns TRANSACTION ID(FT1-2).
    /// </summary>
    public ST TRANSACTIONID
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(2, 0);
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
    /// Returns TRANSACTION BATCH ID(FT1-3).
    /// </summary>
    public ST TRANSACTIONBATCHID
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
    /// Returns TRANSACTION DATE(FT1-4).
    /// </summary>
    public DT TRANSACTIONDATE
    {
        get{
            DT ret = null;
            try
            {
            var t = GetField(4, 0);
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
    /// Returns TRANSACTION POSTING DATE(FT1-5).
    /// </summary>
    public DT TRANSACTIONPOSTINGDATE
    {
        get{
            DT ret = null;
            try
            {
            var t = GetField(5, 0);
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
    /// Returns TRANSACTION TYPE(FT1-6).
    /// </summary>
    public ID TRANSACTIONTYPE
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
    /// Returns TRANSACTION CODE(FT1-7).
    /// </summary>
    public ID TRANSACTIONCODE
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

    /// <summary>
    /// Returns TRANSACTION DESCRIPTION(FT1-8).
    /// </summary>
    public ST TRANSACTIONDESCRIPTION
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(8, 0);
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
    /// Returns TRANSACTION DESCRIPTION - ALT(FT1-9).
    /// </summary>
    public ST TRANSACTIONDESCRIPTIONALT
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(9, 0);
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
    /// Returns TRANSACTION AMOUNT - EXTENDED(FT1-10).
    /// </summary>
    public NM TRANSACTIONAMOUNTEXTENDED
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
    /// Returns TRANSACTION QUANTITY(FT1-11).
    /// </summary>
    public NM TRANSACTIONQUANTITY
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
    /// Returns TRANSACTION AMOUNT - UNIT(FT1-12).
    /// </summary>
    public NM TRANSACTIONAMOUNTUNIT
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(12, 0);
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
    /// Returns DEPARTMENT CODE(FT1-13).
    /// </summary>
    public ST DEPARTMENTCODE
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(13, 0);
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
    /// Returns INSURANCE PLAN ID(FT1-14).
    /// </summary>
    public ID INSURANCEPLANID
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
    /// Returns INSURANCE AMOUNT(FT1-15).
    /// </summary>
    public NM INSURANCEAMOUNT
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
    /// Returns PATIENT LOCATION(FT1-16).
    /// </summary>
    public ST PATIENTLOCATION
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
    /// Returns FEE SCHEDULE(FT1-17).
    /// </summary>
    public ID FEESCHEDULE
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
    /// Returns PATIENT TYPE(FT1-18).
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
    /// Returns DIAGNOSIS CODE(FT1-19).
    /// </summary>
    public ID DIAGNOSISCODE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(19, 0);
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
    /// Returns PERFORMED BY CODE(FT1-20).
    /// </summary>
    public CN PERFORMEDBYCODE
    {
        get{
            CN ret = null;
            try
            {
            var t = GetField(20, 0);
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
    /// Returns ORDERED BY CODE(FT1-21).
    /// </summary>
    public CN ORDEREDBYCODE
    {
        get{
            CN ret = null;
            try
            {
            var t = GetField(21, 0);
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
    /// Returns UNIT COST(FT1-22).
    /// </summary>
    public NM UNITCOST
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(22, 0);
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