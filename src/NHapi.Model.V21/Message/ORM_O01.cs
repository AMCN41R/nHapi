namespace NHapi.Model.V21.Message

{
    using System;
    using System.Collections.Generic;
    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;
    using NHapi.Model.V21.Group;
    using NHapi.Model.V21.Segment;

/// <summary>
/// Represents a ORM_O01 message structure (see chapter [AAA]). This structure contains the
/// following elements:.
/// <ol>
/// <li>0: MSH (MESSAGE HEADER) </li>
/// <li>1: NTE (NOTES AND COMMENTS) optional repeating</li>
/// <li>2: ORM_O01_PATIENT (a Group object) optional </li>
/// <li>3: ORM_O01_ORDER (a Group object) repeating</li>
/// </ol>
/// </summary>
[Serializable]
public class ORM_O01 : AbstractMessage  {

    /// <summary>
    /// Creates a new ORM_O01 Group with custom IModelClassFactory.
    /// </summary>
    public ORM_O01(IModelClassFactory factory)
        : base(factory){
       init(factory);
    }

    /// <summary>
    /// Creates a new ORM_O01 Group with DefaultModelClassFactory.
    /// </summary>
    public ORM_O01()
        : base(new DefaultModelClassFactory()) {
       init(new DefaultModelClassFactory());
    }

    /// <summary>
    /// initalize method for ORM_O01.  This does the segment setup for the message.
    /// </summary>
    private void init(IModelClassFactory factory) {
       try {
          add(typeof(MSH), true, false);
          add(typeof(NTE), false, true);
          add(typeof(ORM_O01_PATIENT), false, false);
          add(typeof(ORM_O01_ORDER), true, true);
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORM_O01 - this is probably a bug in the source code generator.", e);
       }
    }

    public override string Version
        {
            get{
            return Constants.VERSION;
            }
        }

    /// <summary>
    /// Returns MSH (MESSAGE HEADER) - creates it if necessary.
    /// </summary>
    public MSH MSH {
get{
       MSH ret = null;
       try {
          ret = (MSH)GetStructure("MSH");
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
          throw new Exception("An unexpected error occurred",e);
       }

       return ret;
    }
    }

    /// <summary>
    /// Returns  first repetition of NTE (NOTES AND COMMENTS) - creates it if necessary.
    /// </summary>
    public NTE GetNTE() {
       NTE ret = null;
       try {
          ret = (NTE)GetStructure("NTE");
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
          throw new Exception("An unexpected error occurred",e);
       }

       return ret;
    }

    /// <summary>
    /// Returns a specific repetition of NTE
    /// * (NOTES AND COMMENTS) - creates it if necessary
    /// throws HL7Exception if the repetition requested is more than one
    ///     greater than the number of existing repetitions.
    /// </summary>
    public NTE GetNTE(int rep) {
       return (NTE)GetStructure("NTE", rep);
    }

    /**
     * Returns the number of existing repetitions of NTE
     */
    public int NTERepetitionsUsed {
get{
        var reps = -1;
        try {
            reps = GetAll("NTE").Length;
        } catch (HL7Exception e) {
            var message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
            HapiLogFactory.GetHapiLog(GetType()).Error(message, e);
            throw new Exception(message);
        }

        return reps;
    }
    }

    /**
     * Enumerate over the NTE results
     */
    public IEnumerable<NTE> NTEs
    {
        get
        {
            for (var rep = 0; rep < NTERepetitionsUsed; rep++)
            {
                yield return (NTE)GetStructure("NTE", rep);
            }
        }
    }

    /// <summary>
    /// Adds a new NTE.
    /// </summary>
    public NTE AddNTE()
    {
        return AddStructure("NTE") as NTE;
    }

    /// <summary>
    /// Removes the given NTE.
    /// </summary>
    public void RemoveNTE(NTE toRemove)
    {
        RemoveStructure("NTE", toRemove);
    }

    /// <summary>
    /// Removes the NTE at the given index.
    /// </summary>
    public void RemoveNTEAt(int index)
    {
        RemoveRepetition("NTE", index);
    }

    /// <summary>
    /// Returns ORM_O01_PATIENT (a Group object) - creates it if necessary.
    /// </summary>
    public ORM_O01_PATIENT PATIENT {
get{
       ORM_O01_PATIENT ret = null;
       try {
          ret = (ORM_O01_PATIENT)GetStructure("PATIENT");
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
          throw new Exception("An unexpected error occurred",e);
       }

       return ret;
    }
    }

    /// <summary>
    /// Returns  first repetition of ORM_O01_ORDER (a Group object) - creates it if necessary.
    /// </summary>
    public ORM_O01_ORDER GetORDER() {
       ORM_O01_ORDER ret = null;
       try {
          ret = (ORM_O01_ORDER)GetStructure("ORDER");
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
          throw new Exception("An unexpected error occurred",e);
       }

       return ret;
    }

    /// <summary>
    /// Returns a specific repetition of ORM_O01_ORDER
    /// * (a Group object) - creates it if necessary
    /// throws HL7Exception if the repetition requested is more than one
    ///     greater than the number of existing repetitions.
    /// </summary>
    public ORM_O01_ORDER GetORDER(int rep) {
       return (ORM_O01_ORDER)GetStructure("ORDER", rep);
    }

    /**
     * Returns the number of existing repetitions of ORM_O01_ORDER
     */
    public int ORDERRepetitionsUsed {
get{
        var reps = -1;
        try {
            reps = GetAll("ORDER").Length;
        } catch (HL7Exception e) {
            var message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
            HapiLogFactory.GetHapiLog(GetType()).Error(message, e);
            throw new Exception(message);
        }

        return reps;
    }
    }

    /**
     * Enumerate over the ORM_O01_ORDER results
     */
    public IEnumerable<ORM_O01_ORDER> ORDERs
    {
        get
        {
            for (var rep = 0; rep < ORDERRepetitionsUsed; rep++)
            {
                yield return (ORM_O01_ORDER)GetStructure("ORDER", rep);
            }
        }
    }

    /// <summary>
    /// Adds a new ORM_O01_ORDER.
    /// </summary>
    public ORM_O01_ORDER AddORDER()
    {
        return AddStructure("ORDER") as ORM_O01_ORDER;
    }

    /// <summary>
    /// Removes the given ORM_O01_ORDER.
    /// </summary>
    public void RemoveORDER(ORM_O01_ORDER toRemove)
    {
        RemoveStructure("ORDER", toRemove);
    }

    /// <summary>
    /// Removes the ORM_O01_ORDER at the given index.
    /// </summary>
    public void RemoveORDERAt(int index)
    {
        RemoveRepetition("ORDER", index);
    }
}
}
