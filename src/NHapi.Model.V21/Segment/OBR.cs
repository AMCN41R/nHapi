namespace NHapi.Model.V21.Segment{
    using System;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

/// <summary>
/// Represents an HL7 OBR message segment.
/// This segment has the following fields:<ol>
/// <li>OBR-1: SET ID - OBSERVATION REQUEST (SI)</li>
/// <li>OBR-2: PLACER ORDER # (CM)</li>
/// <li>OBR-3: FILLER ORDER # (CM)</li>
/// <li>OBR-4: UNIVERSAL SERVICE IDENT. (CE)</li>
/// <li>OBR-5: PRIORITY (ST)</li>
/// <li>OBR-6: REQUESTED DATE-TIME (TS)</li>
/// <li>OBR-7: OBSERVATION DATE/TIME (TS)</li>
/// <li>OBR-8: OBSERVATION END DATE/TIME (TS)</li>
/// <li>OBR-9: COLLECTION VOLUME (CQ)</li>
/// <li>OBR-10: COLLECTOR IDENTIFIER (CN)</li>
/// <li>OBR-11: SPECIMEN ACTION CODE (ST)</li>
/// <li>OBR-12: DANGER CODE (CM)</li>
/// <li>OBR-13: RELEVANT CLINICAL INFO. (ST)</li>
/// <li>OBR-14: SPECIMEN RECEIVED DATE/TIME (TS)</li>
/// <li>OBR-15: SPECIMEN SOURCE (CM)</li>
/// <li>OBR-16: ORDERING PROVIDER (CN)</li>
/// <li>OBR-17: ORDER CALL-BACK PHONE NUM (TN)</li>
/// <li>OBR-18: PLACERS FIELD #1 (ST)</li>
/// <li>OBR-19: PLACERS FIELD #2 (ST)</li>
/// <li>OBR-20: FILLERS FIELD #1 (ST)</li>
/// <li>OBR-21: FILLERS FIELD #2 (ST)</li>
/// <li>OBR-22: RESULTS RPT/STATUS CHNG - DATE/T (TS)</li>
/// <li>OBR-23: CHARGE TO PRACTICE (CM)</li>
/// <li>OBR-24: DIAGNOSTIC SERV SECT ID (ID)</li>
/// <li>OBR-25: RESULT STATUS (ID)</li>
/// <li>OBR-26: LINKED RESULTS (CE)</li>
/// <li>OBR-27: QUANTITY/TIMING (CM)</li>
/// <li>OBR-28: RESULT COPIES TO (CN)</li>
/// <li>OBR-29: PARENT ACCESSION # (CM)</li>
/// <li>OBR-30: TRANSPORTATION MODE (ID)</li>
/// <li>OBR-31: REASON FOR STUDY (CE)</li>
/// <li>OBR-32: PRINCIPAL RESULT INTERPRETER (CN)</li>
/// <li>OBR-33: ASSISTANT RESULT INTERPRETER (CN)</li>
/// <li>OBR-34: TECHNICIAN (CN)</li>
/// <li>OBR-35: TRANSCRIPTIONIST (CN)</li>
/// <li>OBR-36: SCHEDULED - DATE/TIME (TS)</li>
/// </ol>
/// The get...() methods return data from individual fields.  These methods
/// do not throw exceptions and may therefore have to handle exceptions internally.
/// If an exception is handled internally, it is logged and null is returned.
/// This is not expected to happen - if it does happen this indicates not so much
/// an exceptional circumstance as a bug in the code for this class.
/// </summary>
[Serializable]
public class OBR : AbstractSegment  {

  /**
   * Creates a OBR (OBSERVATION REQUEST) segment object that belongs to the given
   * message.
   */
    public OBR(IGroup parent, IModelClassFactory factory)
        : base(parent,factory) {
    var message = Message;
    try {
       add(typeof(SI), false, 1, 4, new object[]{message}, "SET ID - OBSERVATION REQUEST");
       add(typeof(CM), false, 1, 75, new object[]{message}, "PLACER ORDER #");
       add(typeof(CM), false, 1, 75, new object[]{message}, "FILLER ORDER #");
       add(typeof(CE), true, 1, 200, new object[]{message}, "UNIVERSAL SERVICE IDENT.");
       add(typeof(ST), false, 1, 2, new object[]{message}, "PRIORITY");
       add(typeof(TS), false, 1, 19, new object[]{message}, "REQUESTED DATE-TIME");
       add(typeof(TS), true, 1, 19, new object[]{message}, "OBSERVATION DATE/TIME");
       add(typeof(TS), true, 1, 19, new object[]{message}, "OBSERVATION END DATE/TIME");
       add(typeof(CQ), true, 1, 20, new object[]{message}, "COLLECTION VOLUME");
       add(typeof(CN), false, 0, 60, new object[]{message}, "COLLECTOR IDENTIFIER");
       add(typeof(ST), false, 1, 1, new object[]{message}, "SPECIMEN ACTION CODE");
       add(typeof(CM), false, 1, 60, new object[]{message}, "DANGER CODE");
       add(typeof(ST), false, 1, 300, new object[]{message}, "RELEVANT CLINICAL INFO.");
       add(typeof(TS), true, 1, 19, new object[]{message}, "SPECIMEN RECEIVED DATE/TIME");
       add(typeof(CM), false, 1, 300, new object[]{message}, "SPECIMEN SOURCE");
       add(typeof(CN), false, 0, 60, new object[]{message}, "ORDERING PROVIDER");
       add(typeof(TN), false, 2, 40, new object[]{message}, "ORDER CALL-BACK PHONE NUM");
       add(typeof(ST), false, 1, 60, new object[]{message}, "PLACERS FIELD #1");
       add(typeof(ST), false, 1, 60, new object[]{message}, "PLACERS FIELD #2");
       add(typeof(ST), false, 1, 60, new object[]{message}, "FILLERS FIELD #1");
       add(typeof(ST), false, 1, 60, new object[]{message}, "FILLERS FIELD #2");
       add(typeof(TS), true, 1, 19, new object[]{message}, "RESULTS RPT/STATUS CHNG - DATE/T");
       add(typeof(CM), false, 1, 40, new object[]{message}, "CHARGE TO PRACTICE");
       add(typeof(ID), false, 1, 10, new object[]{message, 74}, "DIAGNOSTIC SERV SECT ID");
       add(typeof(ID), false, 1, 1, new object[]{message, 123}, "RESULT STATUS");
       add(typeof(CE), false, 1, 200, new object[]{message}, "LINKED RESULTS");
       add(typeof(CM), false, 0, 200, new object[]{message}, "QUANTITY/TIMING");
       add(typeof(CN), false, 5, 80, new object[]{message}, "RESULT COPIES TO");
       add(typeof(CM), false, 1, 150, new object[]{message}, "PARENT ACCESSION #");
       add(typeof(ID), false, 1, 20, new object[]{message, 124}, "TRANSPORTATION MODE");
       add(typeof(CE), false, 0, 300, new object[]{message}, "REASON FOR STUDY");
       add(typeof(CN), false, 1, 60, new object[]{message}, "PRINCIPAL RESULT INTERPRETER");
       add(typeof(CN), false, 1, 60, new object[]{message}, "ASSISTANT RESULT INTERPRETER");
       add(typeof(CN), false, 1, 60, new object[]{message}, "TECHNICIAN");
       add(typeof(CN), false, 1, 60, new object[]{message}, "TRANSCRIPTIONIST");
       add(typeof(TS), false, 1, 19, new object[]{message}, "SCHEDULED - DATE/TIME");
    } catch (HL7Exception he) {
        HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
    }
  }

    /// <summary>
    /// Returns SET ID - OBSERVATION REQUEST(OBR-1).
    /// </summary>
    public SI SETIDOBSERVATIONREQUEST
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
    /// Returns PLACER ORDER #(OBR-2).
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
    /// Returns FILLER ORDER #(OBR-3).
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
    /// Returns UNIVERSAL SERVICE IDENT.(OBR-4).
    /// </summary>
    public CE UNIVERSALSERVICEIDENT
    {
        get{
            CE ret = null;
            try
            {
            var t = GetField(4, 0);
                ret = (CE)t;
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
    /// Returns PRIORITY(OBR-5).
    /// </summary>
    public ST PRIORITY
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
    /// Returns REQUESTED DATE-TIME(OBR-6).
    /// </summary>
    public TS REQUESTEDDATETIME
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(6, 0);
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
    /// Returns OBSERVATION DATE/TIME(OBR-7).
    /// </summary>
    public TS OBSERVATIONDATETIME
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
    /// Returns OBSERVATION END DATE/TIME(OBR-8).
    /// </summary>
    public TS OBSERVATIONENDDATETIME
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(8, 0);
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
    /// Returns COLLECTION VOLUME(OBR-9).
    /// </summary>
    public CQ COLLECTIONVOLUME
    {
        get{
            CQ ret = null;
            try
            {
            var t = GetField(9, 0);
                ret = (CQ)t;
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
    /// Returns a single repetition of COLLECTOR IDENTIFIER(OBR-10).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public CN GetCOLLECTORIDENTIFIER(int rep)
    {
            CN ret = null;
            try
            {
            var t = GetField(10, rep);
                ret = (CN)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of COLLECTOR IDENTIFIER (OBR-10).
   /// </summary>
  public CN[] GetCOLLECTORIDENTIFIER() {
     CN[] ret = null;
    try {
        var t = GetField(10);
        ret = new CN[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (CN)t[i];
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
  /// Returns the total repetitions of COLLECTOR IDENTIFIER (OBR-10).
   /// </summary>
  public int COLLECTORIDENTIFIERRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(10);
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

    /// <summary>
    /// Returns SPECIMEN ACTION CODE(OBR-11).
    /// </summary>
    public ST SPECIMENACTIONCODE
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
    /// Returns DANGER CODE(OBR-12).
    /// </summary>
    public CM DANGERCODE
    {
        get{
            CM ret = null;
            try
            {
            var t = GetField(12, 0);
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
    /// Returns RELEVANT CLINICAL INFO.(OBR-13).
    /// </summary>
    public ST RELEVANTCLINICALINFO
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(13, 0);
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
    /// Returns SPECIMEN RECEIVED DATE/TIME(OBR-14).
    /// </summary>
    public TS SPECIMENRECEIVEDDATETIME
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(14, 0);
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
    /// Returns SPECIMEN SOURCE(OBR-15).
    /// </summary>
    public CM SPECIMENSOURCE
    {
        get{
            CM ret = null;
            try
            {
            var t = GetField(15, 0);
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
    /// Returns a single repetition of ORDERING PROVIDER(OBR-16).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public CN GetORDERINGPROVIDER(int rep)
    {
            CN ret = null;
            try
            {
            var t = GetField(16, rep);
                ret = (CN)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of ORDERING PROVIDER (OBR-16).
   /// </summary>
  public CN[] GetORDERINGPROVIDER() {
     CN[] ret = null;
    try {
        var t = GetField(16);
        ret = new CN[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (CN)t[i];
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
  /// Returns the total repetitions of ORDERING PROVIDER (OBR-16).
   /// </summary>
  public int ORDERINGPROVIDERRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(16);
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

    /// <summary>
    /// Returns a single repetition of ORDER CALL-BACK PHONE NUM(OBR-17).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public TN GetORDERCALLBACKPHONENUM(int rep)
    {
            TN ret = null;
            try
            {
            var t = GetField(17, rep);
                ret = (TN)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of ORDER CALL-BACK PHONE NUM (OBR-17).
   /// </summary>
  public TN[] GetORDERCALLBACKPHONENUM() {
     TN[] ret = null;
    try {
        var t = GetField(17);
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
  /// Returns the total repetitions of ORDER CALL-BACK PHONE NUM (OBR-17).
   /// </summary>
  public int ORDERCALLBACKPHONENUMRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(17);
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

    /// <summary>
    /// Returns PLACERS FIELD #1(OBR-18).
    /// </summary>
    public ST PLACERSFIELD1
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(18, 0);
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
    /// Returns PLACERS FIELD #2(OBR-19).
    /// </summary>
    public ST PLACERSFIELD2
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(19, 0);
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
    /// Returns FILLERS FIELD #1(OBR-20).
    /// </summary>
    public ST FILLERSFIELD1
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(20, 0);
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
    /// Returns FILLERS FIELD #2(OBR-21).
    /// </summary>
    public ST FILLERSFIELD2
    {
        get{
            ST ret = null;
            try
            {
            var t = GetField(21, 0);
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
    /// Returns RESULTS RPT/STATUS CHNG - DATE/T(OBR-22).
    /// </summary>
    public TS RESULTSRPTSTATUSCHNGDATET
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(22, 0);
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
    /// Returns CHARGE TO PRACTICE(OBR-23).
    /// </summary>
    public CM CHARGETOPRACTICE
    {
        get{
            CM ret = null;
            try
            {
            var t = GetField(23, 0);
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
    /// Returns DIAGNOSTIC SERV SECT ID(OBR-24).
    /// </summary>
    public ID DIAGNOSTICSERVSECTID
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(24, 0);
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
    /// Returns RESULT STATUS(OBR-25).
    /// </summary>
    public ID RESULTSTATUS
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(25, 0);
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
    /// Returns LINKED RESULTS(OBR-26).
    /// </summary>
    public CE LINKEDRESULTS
    {
        get{
            CE ret = null;
            try
            {
            var t = GetField(26, 0);
                ret = (CE)t;
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
    /// Returns a single repetition of QUANTITY/TIMING(OBR-27).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public CM GetQUANTITYTIMING(int rep)
    {
            CM ret = null;
            try
            {
            var t = GetField(27, rep);
                ret = (CM)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of QUANTITY/TIMING (OBR-27).
   /// </summary>
  public CM[] GetQUANTITYTIMING() {
     CM[] ret = null;
    try {
        var t = GetField(27);
        ret = new CM[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (CM)t[i];
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
  /// Returns the total repetitions of QUANTITY/TIMING (OBR-27).
   /// </summary>
  public int QUANTITYTIMINGRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(27);
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

    /// <summary>
    /// Returns a single repetition of RESULT COPIES TO(OBR-28).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public CN GetRESULTCOPIESTO(int rep)
    {
            CN ret = null;
            try
            {
            var t = GetField(28, rep);
                ret = (CN)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of RESULT COPIES TO (OBR-28).
   /// </summary>
  public CN[] GetRESULTCOPIESTO() {
     CN[] ret = null;
    try {
        var t = GetField(28);
        ret = new CN[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (CN)t[i];
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
  /// Returns the total repetitions of RESULT COPIES TO (OBR-28).
   /// </summary>
  public int RESULTCOPIESTORepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(28);
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

    /// <summary>
    /// Returns PARENT ACCESSION #(OBR-29).
    /// </summary>
    public CM PARENTACCESSION
    {
        get{
            CM ret = null;
            try
            {
            var t = GetField(29, 0);
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
    /// Returns TRANSPORTATION MODE(OBR-30).
    /// </summary>
    public ID TRANSPORTATIONMODE
    {
        get{
            ID ret = null;
            try
            {
            var t = GetField(30, 0);
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
    /// Returns a single repetition of REASON FOR STUDY(OBR-31).
    /// throws HL7Exception if the repetition number is invalid.
    /// <param name="rep">The repetition number (this is a repeating field)</param>
    /// </summary>
    public CE GetREASONFORSTUDY(int rep)
    {
            CE ret = null;
            try
            {
            var t = GetField(31, rep);
                ret = (CE)t;
        } catch (Exception ex) {
            HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                throw new Exception("An unexpected error occurred", ex);
    }

            return ret;
  }

  /// <summary>
  /// Returns all repetitions of REASON FOR STUDY (OBR-31).
   /// </summary>
  public CE[] GetREASONFORSTUDY() {
     CE[] ret = null;
    try {
        var t = GetField(31);
        ret = new CE[t.Length];
        for (var i = 0; i < ret.Length; i++) {
            ret[i] = (CE)t[i];
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
  /// Returns the total repetitions of REASON FOR STUDY (OBR-31).
   /// </summary>
  public int REASONFORSTUDYRepetitionsUsed
{
get{
    try {
    return GetTotalFieldRepetitionsUsed(31);
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

    /// <summary>
    /// Returns PRINCIPAL RESULT INTERPRETER(OBR-32).
    /// </summary>
    public CN PRINCIPALRESULTINTERPRETER
    {
        get{
            CN ret = null;
            try
            {
            var t = GetField(32, 0);
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
    /// Returns ASSISTANT RESULT INTERPRETER(OBR-33).
    /// </summary>
    public CN ASSISTANTRESULTINTERPRETER
    {
        get{
            CN ret = null;
            try
            {
            var t = GetField(33, 0);
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
    /// Returns TECHNICIAN(OBR-34).
    /// </summary>
    public CN TECHNICIAN
    {
        get{
            CN ret = null;
            try
            {
            var t = GetField(34, 0);
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
    /// Returns TRANSCRIPTIONIST(OBR-35).
    /// </summary>
    public CN TRANSCRIPTIONIST
    {
        get{
            CN ret = null;
            try
            {
            var t = GetField(35, 0);
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
    /// Returns SCHEDULED - DATE/TIME(OBR-36).
    /// </summary>
    public TS SCHEDULEDDATETIME
    {
        get{
            TS ret = null;
            try
            {
            var t = GetField(36, 0);
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
}}