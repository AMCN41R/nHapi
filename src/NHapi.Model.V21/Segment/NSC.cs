namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 NSC message segment.
/// This segment has the following fields:<ol>
/// <li>NSC-1: NETWORK CHANGE TYPE (ID)</li>
/// <li>NSC-2: CURRENT CPU (ST)</li>
/// <li>NSC-3: CURRENT FILESERVER (ST)</li>
/// <li>NSC-4: CURRENT APPLICATION (ST)</li>
/// <li>NSC-5: CURRENT FACILITY (ST)</li>
/// <li>NSC-6: NEW CPU (ST)</li>
/// <li>NSC-7: NEW FILESERVER (ST)</li>
/// <li>NSC-8: NEW APPLICATION (ST)</li>
/// <li>NSC-9: NEW FACILITY (ST)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class NSC : AbstractSegment  {

  /**
   * Creates a NSC (STATUS CHANGE) segment object that belongs to the given
   * message.
   */
    public NSC(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(ID), true, 1, 4, new object[]{message, 0}, "NETWORK CHANGE TYPE");
       add(typeof(ST), false, 1, 30, new object[]{message}, "CURRENT CPU");
       add(typeof(ST), false, 1, 30, new object[]{message}, "CURRENT FILESERVER");
       add(typeof(ST), false, 1, 30, new object[]{message}, "CURRENT APPLICATION");
       add(typeof(ST), false, 1, 30, new object[]{message}, "CURRENT FACILITY");
       add(typeof(ST), false, 1, 30, new object[]{message}, "NEW CPU");
       add(typeof(ST), false, 1, 30, new object[]{message}, "NEW FILESERVER");
       add(typeof(ST), false, 1, 30, new object[]{message}, "NEW APPLICATION");
       add(typeof(ST), false, 1, 30, new object[]{message}, "NEW FACILITY");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns NETWORK CHANGE TYPE(NSC-1).
    /// </summary>
    public ID NETWORKCHANGETYPE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(1, 0);
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
    /// Returns CURRENT CPU(NSC-2).
    /// </summary>
    public ST CURRENTCPU
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
    /// Returns CURRENT FILESERVER(NSC-3).
    /// </summary>
    public ST CURRENTFILESERVER
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
    /// Returns CURRENT APPLICATION(NSC-4).
    /// </summary>
    public ST CURRENTAPPLICATION
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
    /// Returns CURRENT FACILITY(NSC-5).
    /// </summary>
    public ST CURRENTFACILITY
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
    /// Returns NEW CPU(NSC-6).
    /// </summary>
    public ST NEWCPU
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
    /// Returns NEW FILESERVER(NSC-7).
    /// </summary>
    public ST NEWFILESERVER
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
    /// Returns NEW APPLICATION(NSC-8).
    /// </summary>
    public ST NEWAPPLICATION
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
    /// Returns NEW FACILITY(NSC-9).
    /// </summary>
    public ST NEWFACILITY
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
}}