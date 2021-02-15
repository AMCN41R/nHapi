namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 MSA message segment.
/// This segment has the following fields:<ol>
/// <li>MSA-1: ACKNOWLEDGMENT CODE (ID)</li>
/// <li>MSA-2: MESSAGE CONTROL ID (ST)</li>
/// <li>MSA-3: TEXT MESSAGE (ST)</li>
/// <li>MSA-4: EXPECTED SEQUENCE NUMBER (NM)</li>
/// <li>MSA-5: DELAYED ACKNOWLEDGMENT TYPE (ID)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class MSA : AbstractSegment  {

  /**
   * Creates a MSA (MESSAGE ACKNOWLEDGMENT) segment object that belongs to the given
   * message.
   */
    public MSA(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(ID), true, 1, 2, new object[]{message, 8}, "ACKNOWLEDGMENT CODE");
       add(typeof(ST), true, 1, 20, new object[]{message}, "MESSAGE CONTROL ID");
       add(typeof(ST), false, 1, 80, new object[]{message}, "TEXT MESSAGE");
       add(typeof(NM), false, 1, 15, new object[]{message}, "EXPECTED SEQUENCE NUMBER");
       add(typeof(ID), false, 1, 1, new object[]{message, 102}, "DELAYED ACKNOWLEDGMENT TYPE");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns ACKNOWLEDGMENT CODE(MSA-1).
    /// </summary>
    public ID ACKNOWLEDGMENTCODE
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
    /// Returns MESSAGE CONTROL ID(MSA-2).
    /// </summary>
    public ST MESSAGECONTROLID
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
    /// Returns TEXT MESSAGE(MSA-3).
    /// </summary>
    public ST TEXTMESSAGE
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
    /// Returns EXPECTED SEQUENCE NUMBER(MSA-4).
    /// </summary>
    public NM EXPECTEDSEQUENCENUMBER
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(4, 0);
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
    /// Returns DELAYED ACKNOWLEDGMENT TYPE(MSA-5).
    /// </summary>
    public ID DELAYEDACKNOWLEDGMENTTYPE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(5, 0);
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