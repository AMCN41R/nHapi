namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 NK1 message segment.
/// This segment has the following fields:<ol>
/// <li>NK1-1: SET ID - NEXT OF KIN (SI)</li>
/// <li>NK1-2: NEXT OF KIN NAME (PN)</li>
/// <li>NK1-3: NEXT OF KIN RELATIONSHIP (ST)</li>
/// <li>NK1-4: NEXT OF KIN - ADDRESS (AD)</li>
/// <li>NK1-5: NEXT OF KIN - PHONE NUMBER (TN)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class NK1 : AbstractSegment  {

  /**
   * Creates a NK1 (NEXT OF KIN) segment object that belongs to the given
   * message.
   */
    public NK1(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(SI), true, 1, 4, new object[]{message}, "SET ID - NEXT OF KIN");
       add(typeof(PN), false, 1, 48, new object[]{message}, "NEXT OF KIN NAME");
       add(typeof(ST), false, 1, 15, new object[]{message}, "NEXT OF KIN RELATIONSHIP");
       add(typeof(AD), false, 1, 106, new object[]{message}, "NEXT OF KIN - ADDRESS");
       add(typeof(TN), false, 0, 40, new object[]{message}, "NEXT OF KIN - PHONE NUMBER");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns SET ID - NEXT OF KIN(NK1-1).
    /// </summary>
    public SI SETIDNEXTOFKIN
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
    /// Returns NEXT OF KIN NAME(NK1-2).
    /// </summary>
    public PN NEXTOFKINNAME
    {
        get{
            PN ret = null;
            try
            {
            var t = GetField(2, 0);
                ret = (PN)t;
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
    /// Returns NEXT OF KIN RELATIONSHIP(NK1-3).
    /// </summary>
    public ST NEXTOFKINRELATIONSHIP
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
    /// Returns NEXT OF KIN - ADDRESS(NK1-4).
    /// </summary>
    public AD NEXTOFKINADDRESS
    {
        get{
            AD ret = null;
            try
            {
            var t = GetField(4, 0);
                ret = (AD)t;
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
    /// Returns a single repetition of NEXT OF KIN - PHONE NUMBER(NK1-5).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public TN GetNEXTOFKINPHONENUMBER(int rep)
    {
            TN ret = null;
            try
            {
            var t = GetField(5, rep);
                ret = (TN)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of NEXT OF KIN - PHONE NUMBER (NK1-5).
   /// </summary>
  public TN[] GetNEXTOFKINPHONENUMBER() {
     TN[] ret = null;
    try {
        var t = GetField(5);
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
  /// Returns the total repetitions of NEXT OF KIN - PHONE NUMBER (NK1-5).
   /// </summary>
  public int NEXTOFKINPHONENUMBERRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(5);
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