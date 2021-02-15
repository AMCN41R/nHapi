namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 MSH message segment.
/// This segment has the following fields:<ol>
/// <li>MSH-1: FIELD SEPARATOR (ST)</li>
/// <li>MSH-2: ENCODING CHARACTERS (ST)</li>
/// <li>MSH-3: SENDING APPLICATION (ST)</li>
/// <li>MSH-4: SENDING FACILITY (ST)</li>
/// <li>MSH-5: RECEIVING APPLICATION (ST)</li>
/// <li>MSH-6: RECEIVING FACILITY (ST)</li>
/// <li>MSH-7: DATE/TIME OF MESSAGE (TS)</li>
/// <li>MSH-8: Security (ST)</li>
/// <li>MSH-9: MESSAGE TYPE (ID)</li>
/// <li>MSH-10: MESSAGE CONTROL ID (ST)</li>
/// <li>MSH-11: PROCESSING ID (ID)</li>
/// <li>MSH-12: VERSION ID (NM)</li>
/// <li>MSH-13: SEQUENCE NUMBER (NM)</li>
/// <li>MSH-14: CONTINUATION POINTER (ST)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class MSH : AbstractSegment  {

  /**
   * Creates a MSH (MESSAGE HEADER) segment object that belongs to the given
   * message.
   */
    public MSH(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(ST), true, 1, 1, new object[]{message}, "FIELD SEPARATOR");
       add(typeof(ST), true, 1, 4, new object[]{message}, "ENCODING CHARACTERS");
       add(typeof(ST), false, 1, 15, new object[]{message}, "SENDING APPLICATION");
       add(typeof(ST), false, 1, 20, new object[]{message}, "SENDING FACILITY");
       add(typeof(ST), false, 1, 15, new object[]{message}, "RECEIVING APPLICATION");
       add(typeof(ST), false, 1, 30, new object[]{message}, "RECEIVING FACILITY");
       add(typeof(TS), false, 1, 19, new object[]{message}, "DATE/TIME OF MESSAGE");
       add(typeof(ST), false, 1, 40, new object[]{message}, "Security");
       add(typeof(ID), true, 1, 7, new object[]{message, 76}, "MESSAGE TYPE");
       add(typeof(ST), true, 1, 20, new object[]{message}, "MESSAGE CONTROL ID");
       add(typeof(ID), true, 1, 1, new object[]{message, 103}, "PROCESSING ID");
       add(typeof(NM), true, 1, 8, new object[]{message}, "VERSION ID");
       add(typeof(NM), false, 1, 15, new object[]{message}, "SEQUENCE NUMBER");
       add(typeof(ST), false, 1, 180, new object[]{message}, "CONTINUATION POINTER");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns FIELD SEPARATOR(MSH-1).
    /// </summary>
    public ST FIELDSEPARATOR
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
    /// Returns ENCODING CHARACTERS(MSH-2).
    /// </summary>
    public ST ENCODINGCHARACTERS
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
    /// Returns SENDING APPLICATION(MSH-3).
    /// </summary>
    public ST SENDINGAPPLICATION
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
    /// Returns SENDING FACILITY(MSH-4).
    /// </summary>
    public ST SENDINGFACILITY
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
    /// Returns RECEIVING APPLICATION(MSH-5).
    /// </summary>
    public ST RECEIVINGAPPLICATION
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
    /// Returns RECEIVING FACILITY(MSH-6).
    /// </summary>
    public ST RECEIVINGFACILITY
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
    /// Returns DATE/TIME OF MESSAGE(MSH-7).
    /// </summary>
    public TS DATETIMEOFMESSAGE
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
    /// Returns Security(MSH-8).
    /// </summary>
    public ST Security
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
    /// Returns MESSAGE TYPE(MSH-9).
    /// </summary>
    public ID MESSAGETYPE
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
    /// Returns MESSAGE CONTROL ID(MSH-10).
    /// </summary>
    public ST MESSAGECONTROLID
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
    /// Returns PROCESSING ID(MSH-11).
    /// </summary>
    public ID PROCESSINGID
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
    /// Returns VERSION ID(MSH-12).
    /// </summary>
    public NM VERSIONID
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
    /// Returns SEQUENCE NUMBER(MSH-13).
    /// </summary>
    public NM SEQUENCENUMBER
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
    /// Returns CONTINUATION POINTER(MSH-14).
    /// </summary>
    public ST CONTINUATIONPOINTER
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