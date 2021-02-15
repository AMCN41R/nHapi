namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 DG1 message segment.
/// This segment has the following fields:<ol>
/// <li>DG1-1: SET ID - DIAGNOSIS (SI)</li>
/// <li>DG1-2: DIAGNOSIS CODING METHOD (ID)</li>
/// <li>DG1-3: DIAGNOSIS CODE (ID)</li>
/// <li>DG1-4: DIAGNOSIS DESCRIPTION (ST)</li>
/// <li>DG1-5: DIAGNOSIS DATE/TIME (TS)</li>
/// <li>DG1-6: DIAGNOSIS/DRG TYPE (ID)</li>
/// <li>DG1-7: MAJOR DIAGNOSTIC CATEGORY (ST)</li>
/// <li>DG1-8: DIAGNOSTIC RELATED GROUP (ID)</li>
/// <li>DG1-9: DRG APPROVAL INDICATOR (ID)</li>
/// <li>DG1-10: DRG GROUPER REVIEW CODE (ID)</li>
/// <li>DG1-11: OUTLIER TYPE (ID)</li>
/// <li>DG1-12: OUTLIER DAYS (NM)</li>
/// <li>DG1-13: OUTLIER COST (NM)</li>
/// <li>DG1-14: GROUPER VERSION AND TYPE (ST)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class DG1 : AbstractSegment  {

  /**
   * Creates a DG1 (DIAGNOSIS) segment object that belongs to the given
   * message.
   */
    public DG1(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(SI), true, 1, 4, new object[]{message}, "SET ID - DIAGNOSIS");
       add(typeof(ID), true, 1, 2, new object[]{message, 53}, "DIAGNOSIS CODING METHOD");
       add(typeof(ID), false, 1, 8, new object[]{message, 51}, "DIAGNOSIS CODE");
       add(typeof(ST), false, 1, 40, new object[]{message}, "DIAGNOSIS DESCRIPTION");
       add(typeof(TS), false, 1, 19, new object[]{message}, "DIAGNOSIS DATE/TIME");
       add(typeof(ID), true, 1, 2, new object[]{message, 52}, "DIAGNOSIS/DRG TYPE");
       add(typeof(ST), false, 1, 4, new object[]{message}, "MAJOR DIAGNOSTIC CATEGORY");
       add(typeof(ID), false, 1, 4, new object[]{message, 55}, "DIAGNOSTIC RELATED GROUP");
       add(typeof(ID), false, 1, 2, new object[]{message, 0}, "DRG APPROVAL INDICATOR");
       add(typeof(ID), false, 1, 2, new object[]{message, 56}, "DRG GROUPER REVIEW CODE");
       add(typeof(ID), false, 1, 2, new object[]{message, 83}, "OUTLIER TYPE");
       add(typeof(NM), false, 1, 3, new object[]{message}, "OUTLIER DAYS");
       add(typeof(NM), false, 1, 12, new object[]{message}, "OUTLIER COST");
       add(typeof(ST), false, 1, 4, new object[]{message}, "GROUPER VERSION AND TYPE");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns SET ID - DIAGNOSIS(DG1-1).
    /// </summary>
    public SI SETIDDIAGNOSIS
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
    /// Returns DIAGNOSIS CODING METHOD(DG1-2).
    /// </summary>
    public ID DIAGNOSISCODINGMETHOD
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
    /// Returns DIAGNOSIS CODE(DG1-3).
    /// </summary>
    public ID DIAGNOSISCODE
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
    /// Returns DIAGNOSIS DESCRIPTION(DG1-4).
    /// </summary>
    public ST DIAGNOSISDESCRIPTION
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
    /// Returns DIAGNOSIS DATE/TIME(DG1-5).
    /// </summary>
    public TS DIAGNOSISDATETIME
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
    /// Returns DIAGNOSIS/DRG TYPE(DG1-6).
    /// </summary>
    public ID DIAGNOSISDRGTYPE
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
    /// Returns MAJOR DIAGNOSTIC CATEGORY(DG1-7).
    /// </summary>
    public ST MAJORDIAGNOSTICCATEGORY
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(7, 0);
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
    /// Returns DIAGNOSTIC RELATED GROUP(DG1-8).
    /// </summary>
    public ID DIAGNOSTICRELATEDGROUP
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
    /// Returns DRG APPROVAL INDICATOR(DG1-9).
    /// </summary>
    public ID DRGAPPROVALINDICATOR
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
    /// Returns DRG GROUPER REVIEW CODE(DG1-10).
    /// </summary>
    public ID DRGGROUPERREVIEWCODE
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
    /// Returns OUTLIER TYPE(DG1-11).
    /// </summary>
    public ID OUTLIERTYPE
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
    /// Returns OUTLIER DAYS(DG1-12).
    /// </summary>
    public NM OUTLIERDAYS
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
    /// Returns OUTLIER COST(DG1-13).
    /// </summary>
    public NM OUTLIERCOST
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(13, 0);
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
    /// Returns GROUPER VERSION AND TYPE(DG1-14).
    /// </summary>
    public ST GROUPERVERSIONANDTYPE
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(14, 0);
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
}}