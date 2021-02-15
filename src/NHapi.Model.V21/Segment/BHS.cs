namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 BHS message segment.
/// This segment has the following fields:<ol>
/// <li>BHS-1: BATCH FIELD SEPARATOR (ST)</li>
/// <li>BHS-2: BATCH ENCODING CHARACTERS (ST)</li>
/// <li>BHS-3: BATCH SENDING APPLICATION (ST)</li>
/// <li>BHS-4: BATCH SENDING FACILITY (ST)</li>
/// <li>BHS-5: BATCH RECEIVING APPLICATION (ST)</li>
/// <li>BHS-6: BATCH RECEIVING FACILITY (ST)</li>
/// <li>BHS-7: BATCH CREATION DATE/TIME (TS)</li>
/// <li>BHS-8: BATCH SECURITY (ST)</li>
/// <li>BHS-9: BATCH NAME/ID/TYPE (ST)</li>
/// <li>BHS-10: BATCH COMMENT (ST)</li>
/// <li>BHS-11: BATCH CONTROL ID (ST)</li>
/// <li>BHS-12: REFERENCE BATCH CONTROL ID (ST)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class BHS : AbstractSegment  {

  /**
   * Creates a BHS (BATCH HEADER) segment object that belongs to the given
   * message.
   */
    public BHS(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(ST), true, 1, 1, new object[]{message}, "BATCH FIELD SEPARATOR");
       add(typeof(ST), true, 1, 3, new object[]{message}, "BATCH ENCODING CHARACTERS");
       add(typeof(ST), false, 1, 15, new object[]{message}, "BATCH SENDING APPLICATION");
       add(typeof(ST), false, 1, 20, new object[]{message}, "BATCH SENDING FACILITY");
       add(typeof(ST), false, 1, 15, new object[]{message}, "BATCH RECEIVING APPLICATION");
       add(typeof(ST), false, 1, 20, new object[]{message}, "BATCH RECEIVING FACILITY");
       add(typeof(TS), false, 1, 19, new object[]{message}, "BATCH CREATION DATE/TIME");
       add(typeof(ST), false, 1, 40, new object[]{message}, "BATCH SECURITY");
       add(typeof(ST), false, 1, 20, new object[]{message}, "BATCH NAME/ID/TYPE");
       add(typeof(ST), false, 1, 80, new object[]{message}, "BATCH COMMENT");
       add(typeof(ST), false, 1, 20, new object[]{message}, "BATCH CONTROL ID");
       add(typeof(ST), false, 1, 20, new object[]{message}, "REFERENCE BATCH CONTROL ID");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns BATCH FIELD SEPARATOR(BHS-1).
    /// </summary>
    public ST BATCHFIELDSEPARATOR
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(1, 0);
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
    /// Returns BATCH ENCODING CHARACTERS(BHS-2).
    /// </summary>
    public ST BATCHENCODINGCHARACTERS
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
    /// Returns BATCH SENDING APPLICATION(BHS-3).
    /// </summary>
    public ST BATCHSENDINGAPPLICATION
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
    /// Returns BATCH SENDING FACILITY(BHS-4).
    /// </summary>
    public ST BATCHSENDINGFACILITY
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
    /// Returns BATCH RECEIVING APPLICATION(BHS-5).
    /// </summary>
    public ST BATCHRECEIVINGAPPLICATION
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
    /// Returns BATCH RECEIVING FACILITY(BHS-6).
    /// </summary>
    public ST BATCHRECEIVINGFACILITY
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
    /// Returns BATCH CREATION DATE/TIME(BHS-7).
    /// </summary>
    public TS BATCHCREATIONDATETIME
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(7, 0);
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
    /// Returns BATCH SECURITY(BHS-8).
    /// </summary>
    public ST BATCHSECURITY
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
    /// Returns BATCH NAME/ID/TYPE(BHS-9).
    /// </summary>
    public ST BATCHNAMEIDTYPE
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
    /// Returns BATCH COMMENT(BHS-10).
    /// </summary>
    public ST BATCHCOMMENT
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(10, 0);
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
    /// Returns BATCH CONTROL ID(BHS-11).
    /// </summary>
    public ST BATCHCONTROLID
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(11, 0);
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
    /// Returns REFERENCE BATCH CONTROL ID(BHS-12).
    /// </summary>
    public ST REFERENCEBATCHCONTROLID
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
}}