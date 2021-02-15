namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 EVN message segment.
/// This segment has the following fields:<ol>
/// <li>EVN-1: EVENT TYPE CODE (ID)</li>
/// <li>EVN-2: DATE/TIME OF EVENT (TS)</li>
/// <li>EVN-3: DATE/TIME PLANNED EVENT (TS)</li>
/// <li>EVN-4: EVENT REASON CODE (ID)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class EVN : AbstractSegment  {

  /**
   * Creates a EVN (EVENT TYPE) segment object that belongs to the given
   * message.
   */
    public EVN(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(ID), true, 1, 3, new object[]{message, 3}, "EVENT TYPE CODE");
       add(typeof(TS), true, 1, 19, new object[]{message}, "DATE/TIME OF EVENT");
       add(typeof(TS), false, 1, 19, new object[]{message}, "DATE/TIME PLANNED EVENT");
       add(typeof(ID), false, 1, 3, new object[]{message, 62}, "EVENT REASON CODE");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns EVENT TYPE CODE(EVN-1).
    /// </summary>
    public ID EVENTTYPECODE
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
    /// Returns DATE/TIME OF EVENT(EVN-2).
    /// </summary>
    public TS DATETIMEOFEVENT
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(2, 0);
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
    /// Returns DATE/TIME PLANNED EVENT(EVN-3).
    /// </summary>
    public TS DATETIMEPLANNEDEVENT
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(3, 0);
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
    /// Returns EVENT REASON CODE(EVN-4).
    /// </summary>
    public ID EVENTREASONCODE
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
}}