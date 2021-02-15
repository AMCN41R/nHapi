namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 ORC message segment.
/// This segment has the following fields:<ol>
/// <li>ORC-1: ORDER CONTROL (ST)</li>
/// <li>ORC-2: PLACER ORDER # (CM)</li>
/// <li>ORC-3: FILLER ORDER # (CM)</li>
/// <li>ORC-4: PLACER GROUP # (CM)</li>
/// <li>ORC-5: ORDER STATUS (ST)</li>
/// <li>ORC-6: RESPONSE FLAG (ST)</li>
/// <li>ORC-7: TIMING/QUANTITY (CM)</li>
/// <li>ORC-8: PARENT (CM)</li>
/// <li>ORC-9: DATE/TIME OF TRANSACTION (TS)</li>
/// <li>ORC-10: ENTERED BY (CN)</li>
/// <li>ORC-11: VERIFIED BY (CN)</li>
/// <li>ORC-12: ORDERING PROVIDER (CN)</li>
/// <li>ORC-13: ENTERER'S LOCATION (CM)</li>
/// <li>ORC-14: CALL BACK PHONE NUMBER (TN)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class ORC : AbstractSegment  {

  /**
   * Creates a ORC (COMMON ORDER) segment object that belongs to the given
   * message.
   */
    public ORC(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(ST), true, 1, 2, new object[]{message}, "ORDER CONTROL");
       add(typeof(CM), false, 1, 75, new object[]{message}, "PLACER ORDER #");
       add(typeof(CM), false, 1, 75, new object[]{message}, "FILLER ORDER #");
       add(typeof(CM), false, 1, 75, new object[]{message}, "PLACER GROUP #");
       add(typeof(ST), false, 1, 2, new object[]{message}, "ORDER STATUS");
       add(typeof(ST), false, 1, 1, new object[]{message}, "RESPONSE FLAG");
       add(typeof(CM), false, 1, 200, new object[]{message}, "TIMING/QUANTITY");
       add(typeof(CM), false, 1, 200, new object[]{message}, "PARENT");
       add(typeof(TS), false, 1, 19, new object[]{message}, "DATE/TIME OF TRANSACTION");
       add(typeof(CN), false, 1, 80, new object[]{message}, "ENTERED BY");
       add(typeof(CN), false, 1, 80, new object[]{message}, "VERIFIED BY");
       add(typeof(CN), false, 1, 80, new object[]{message}, "ORDERING PROVIDER");
       add(typeof(CM), false, 1, 80, new object[]{message}, "ENTERER'S LOCATION");
       add(typeof(TN), false, 2, 40, new object[]{message}, "CALL BACK PHONE NUMBER");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns ORDER CONTROL(ORC-1).
    /// </summary>
    public ST ORDERCONTROL
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
    /// Returns PLACER ORDER #(ORC-2).
    /// </summary>
    public CM PLACERORDER
    {
        get{
            CM ret = null;
            try
            {
            var t = GetField(2, 0);
                ret = (CM)t;
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
    /// Returns FILLER ORDER #(ORC-3).
    /// </summary>
    public CM FILLERORDER
    {
        get{
            CM ret = null;
            try
            {
            var t = GetField(3, 0);
                ret = (CM)t;
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
    /// Returns PLACER GROUP #(ORC-4).
    /// </summary>
    public CM PLACERGROUP
    {
        get{
            CM ret = null;
            try
            {
            var t = GetField(4, 0);
                ret = (CM)t;
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
    /// Returns ORDER STATUS(ORC-5).
    /// </summary>
    public ST ORDERSTATUS
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
    /// Returns RESPONSE FLAG(ORC-6).
    /// </summary>
    public ST RESPONSEFLAG
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
    /// Returns TIMING/QUANTITY(ORC-7).
    /// </summary>
    public CM TIMINGQUANTITY
    {
        get{
            CM ret = null;
            try
            {
            var t = GetField(7, 0);
                ret = (CM)t;
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
    /// Returns PARENT(ORC-8).
    /// </summary>
    public CM PARENT
    {
        get{
            CM ret = null;
            try
            {
            var t = GetField(8, 0);
                ret = (CM)t;
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
    /// Returns DATE/TIME OF TRANSACTION(ORC-9).
    /// </summary>
    public TS DATETIMEOFTRANSACTION
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(9, 0);
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
    /// Returns ENTERED BY(ORC-10).
    /// </summary>
    public CN ENTEREDBY
    {
        get{
            CN ret = null;
            try
            {
            var t = GetField(10, 0);
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
    /// Returns VERIFIED BY(ORC-11).
    /// </summary>
    public CN VERIFIEDBY
    {
        get{
            CN ret = null;
            try
            {
            var t = GetField(11, 0);
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
    /// Returns ORDERING PROVIDER(ORC-12).
    /// </summary>
    public CN ORDERINGPROVIDER
    {
        get{
            CN ret = null;
            try
            {
            var t = GetField(12, 0);
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
    /// Returns ENTERER'S LOCATION(ORC-13).
    /// </summary>
    public CM ENTERERSLOCATION
    {
        get{
            CM ret = null;
            try
            {
            var t = GetField(13, 0);
                ret = (CM)t;
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
    /// Returns a single repetition of CALL BACK PHONE NUMBER(ORC-14).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public TN GetCALLBACKPHONENUMBER(int rep)
    {
            TN ret = null;
            try
            {
            var t = GetField(14, rep);
                ret = (TN)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of CALL BACK PHONE NUMBER (ORC-14).
   /// </summary>
  public TN[] GetCALLBACKPHONENUMBER() {
     TN[] ret = null;
    try {
        var t = GetField(14);
        ret = new TN[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (TN)t[i];
        }
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new Exception("An unexpected error occurred", he);
    } catch (Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new Exception("An unexpected error occurred", cce);
  }

 return ret;
}

  /// <summary>
  /// Returns the total repetitions of CALL BACK PHONE NUMBER (ORC-14).
   /// </summary>
  public int CALLBACKPHONENUMBERRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(14);
    }
catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
        throw new Exception("An unexpected error occurred", he);
} catch (Exception cce) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", cce);
        throw new Exception("An unexpected error occurred", cce);
}
}
}
}}