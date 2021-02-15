namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 DSP message segment.
/// This segment has the following fields:<ol>
/// <li>DSP-1: SET ID - DISPLAY DATA (SI)</li>
/// <li>DSP-2: DISPLAY LEVEL (SI)</li>
/// <li>DSP-3: DATA LINE (TX)</li>
/// <li>DSP-4: LOGICAL BREAK POINT (ST)</li>
/// <li>DSP-5: RESULT ID (TX)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class DSP : AbstractSegment  {

  /**
   * Creates a DSP (DISPLAY DATA) segment object that belongs to the given
   * message.
   */
    public DSP(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(SI), false, 1, 4, new object[]{message}, "SET ID - DISPLAY DATA");
       add(typeof(SI), false, 1, 4, new object[]{message}, "DISPLAY LEVEL");
       add(typeof(TX), true, 1, 300, new object[]{message}, "DATA LINE");
       add(typeof(ST), false, 1, 2, new object[]{message}, "LOGICAL BREAK POINT");
       add(typeof(TX), false, 1, 20, new object[]{message}, "RESULT ID");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns SET ID - DISPLAY DATA(DSP-1).
    /// </summary>
    public SI SETIDDISPLAYDATA
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
    /// Returns DISPLAY LEVEL(DSP-2).
    /// </summary>
    public SI DISPLAYLEVEL
    {
        get{
            SI ret = null;
            try
            {
            var t = GetField(2, 0);
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
    /// Returns DATA LINE(DSP-3).
    /// </summary>
    public TX DATALINE
    {
        get{
            TX ret = null;
            try
            {
            var t = GetField(3, 0);
                ret = (TX)t;
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
    /// Returns LOGICAL BREAK POINT(DSP-4).
    /// </summary>
    public ST LOGICALBREAKPOINT
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
    /// Returns RESULT ID(DSP-5).
    /// </summary>
    public TX RESULTID
    {
        get{
            TX ret = null;
            try
            {
            var t = GetField(5, 0);
                ret = (TX)t;
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