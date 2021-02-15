namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 NST message segment.
/// This segment has the following fields:<ol>
/// <li>NST-1: STATISTICS AVAILABLE (ID)</li>
/// <li>NST-2: SOURCE IDENTIFIER (ST)</li>
/// <li>NST-3: SOURCE TYPE (ID)</li>
/// <li>NST-4: STATISTICS START (TS)</li>
/// <li>NST-5: STATISTICS END (TS)</li>
/// <li>NST-6: RECEIVE CHARACTER COUNT (NM)</li>
/// <li>NST-7: SEND CHARACTER COUNT (NM)</li>
/// <li>NST-8: MESSAGES RECEIVED (NM)</li>
/// <li>NST-9: MESSAGES SENT (NM)</li>
/// <li>NST-10: CHECKSUM ERRORS RECEIVED (NM)</li>
/// <li>NST-11: LENGTH ERRORS RECEIVED (NM)</li>
/// <li>NST-12: OTHER ERRORS RECEIVED (NM)</li>
/// <li>NST-13: CONNECT TIMEOUTS (NM)</li>
/// <li>NST-14: RECEIVE TIMEOUTS (NM)</li>
/// <li>NST-15: NETWORK ERRORS (NM)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class NST : AbstractSegment  {

  /**
   * Creates a NST (STATISTICS) segment object that belongs to the given
   * message.
   */
    public NST(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(ID), true, 1, 1, new object[]{message, 0}, "STATISTICS AVAILABLE");
       add(typeof(ST), false, 1, 30, new object[]{message}, "SOURCE IDENTIFIER");
       add(typeof(ID), false, 1, 3, new object[]{message, 0}, "SOURCE TYPE");
       add(typeof(TS), false, 1, 19, new object[]{message}, "STATISTICS START");
       add(typeof(TS), false, 1, 19, new object[]{message}, "STATISTICS END");
       add(typeof(NM), false, 1, 10, new object[]{message}, "RECEIVE CHARACTER COUNT");
       add(typeof(NM), false, 1, 10, new object[]{message}, "SEND CHARACTER COUNT");
       add(typeof(NM), false, 1, 10, new object[]{message}, "MESSAGES RECEIVED");
       add(typeof(NM), false, 1, 10, new object[]{message}, "MESSAGES SENT");
       add(typeof(NM), false, 1, 10, new object[]{message}, "CHECKSUM ERRORS RECEIVED");
       add(typeof(NM), false, 1, 10, new object[]{message}, "LENGTH ERRORS RECEIVED");
       add(typeof(NM), false, 1, 10, new object[]{message}, "OTHER ERRORS RECEIVED");
       add(typeof(NM), false, 1, 10, new object[]{message}, "CONNECT TIMEOUTS");
       add(typeof(NM), false, 1, 10, new object[]{message}, "RECEIVE TIMEOUTS");
       add(typeof(NM), false, 1, 10, new object[]{message}, "NETWORK ERRORS");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns STATISTICS AVAILABLE(NST-1).
    /// </summary>
    public ID STATISTICSAVAILABLE
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
    /// Returns SOURCE IDENTIFIER(NST-2).
    /// </summary>
    public ST SOURCEIDENTIFIER
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
    /// Returns SOURCE TYPE(NST-3).
    /// </summary>
    public ID SOURCETYPE
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
    /// Returns STATISTICS START(NST-4).
    /// </summary>
    public TS STATISTICSSTART
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(4, 0);
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
    /// Returns STATISTICS END(NST-5).
    /// </summary>
    public TS STATISTICSEND
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
    /// Returns RECEIVE CHARACTER COUNT(NST-6).
    /// </summary>
    public NM RECEIVECHARACTERCOUNT
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(6, 0);
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
    /// Returns SEND CHARACTER COUNT(NST-7).
    /// </summary>
    public NM SENDCHARACTERCOUNT
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
    /// Returns MESSAGES RECEIVED(NST-8).
    /// </summary>
    public NM MESSAGESRECEIVED
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
    /// Returns MESSAGES SENT(NST-9).
    /// </summary>
    public NM MESSAGESSENT
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(9, 0);
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
    /// Returns CHECKSUM ERRORS RECEIVED(NST-10).
    /// </summary>
    public NM CHECKSUMERRORSRECEIVED
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
    /// Returns LENGTH ERRORS RECEIVED(NST-11).
    /// </summary>
    public NM LENGTHERRORSRECEIVED
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
    /// Returns OTHER ERRORS RECEIVED(NST-12).
    /// </summary>
    public NM OTHERERRORSRECEIVED
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
    /// Returns CONNECT TIMEOUTS(NST-13).
    /// </summary>
    public NM CONNECTTIMEOUTS
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
    /// Returns RECEIVE TIMEOUTS(NST-14).
    /// </summary>
    public NM RECEIVETIMEOUTS
    {
        get{
            NM ret = null;
            try
            {
            var t = GetField(14, 0);
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
    /// Returns NETWORK ERRORS(NST-15).
    /// </summary>
    public NM NETWORKERRORS
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
}}