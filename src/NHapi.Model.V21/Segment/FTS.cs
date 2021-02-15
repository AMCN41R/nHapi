namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 FTS message segment.
/// This segment has the following fields:<ol>
/// <li>FTS-1: FILE BATCH COUNT (ST)</li>
/// <li>FTS-2: FILE TRAILER COMMENT (ST)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class FTS : AbstractSegment  {

  /**
   * Creates a FTS (FILE TRAILER) segment object that belongs to the given
   * message.
   */
    public FTS(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(ST), false, 1, 10, new object[]{message}, "FILE BATCH COUNT");
       add(typeof(ST), false, 1, 80, new object[]{message}, "FILE TRAILER COMMENT");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns FILE BATCH COUNT(FTS-1).
    /// </summary>
    public ST FILEBATCHCOUNT
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
    /// Returns FILE TRAILER COMMENT(FTS-2).
    /// </summary>
    public ST FILETRAILERCOMMENT
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
}}