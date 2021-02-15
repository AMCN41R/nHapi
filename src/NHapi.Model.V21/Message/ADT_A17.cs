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
/// Represents a ADT_A17 message structure (see chapter [AAA]). This structure contains the
/// following elements:.
/// <ol>
/// <li>0: MSH (MESSAGE HEADER) </li>
/// <li>1: EVN (EVENT TYPE) </li>
/// <li>2: ADT_A17_PATIENT (a Group object) repeating</li>
/// </ol>
/// </summary>
[Serializable]
public class ADT_A17 : AbstractMessage  {

    /// <summary>
    /// Creates a new ADT_A17 Group with custom IModelClassFactory.
    /// </summary>
    public ADT_A17(IModelClassFactory factory)
        : base(factory){
       init(factory);
    }

    /// <summary>
    /// Creates a new ADT_A17 Group with DefaultModelClassFactory.
    /// </summary>
    public ADT_A17()
        : base(new DefaultModelClassFactory()) {
       init(new DefaultModelClassFactory());
    }

    /// <summary>
    /// initalize method for ADT_A17.  This does the segment setup for the message.
    /// </summary>
    private void init(IModelClassFactory factory) {
       try {
          add(typeof(MSH), true, false);
          add(typeof(EVN), true, false);
          add(typeof(ADT_A17_PATIENT), true, true);
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ADT_A17 - this is probably a bug in the source code generator.", e);
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
    /// Returns EVN (EVENT TYPE) - creates it if necessary.
    /// </summary>
    public EVN EVN {
get{
       EVN ret = null;
       try {
          ret = (EVN)GetStructure("EVN");
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
          throw new Exception("An unexpected error occurred",e);
       }

       return ret;
    }
    }

    /// <summary>
    /// Returns  first repetition of ADT_A17_PATIENT (a Group object) - creates it if necessary.
    /// </summary>
    public ADT_A17_PATIENT GetPATIENT() {
       ADT_A17_PATIENT ret = null;
       try {
          ret = (ADT_A17_PATIENT)GetStructure("PATIENT");
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
          throw new Exception("An unexpected error occurred",e);
       }

       return ret;
    }

    /// <summary>
    /// Returns a specific repetition of ADT_A17_PATIENT
    /// * (a Group object) - creates it if necessary
    /// throws HL7Exception if the repetition requested is more than one
    ///     greater than the number of existing repetitions.
    /// </summary>
    public ADT_A17_PATIENT GetPATIENT(int rep) {
       return (ADT_A17_PATIENT)GetStructure("PATIENT", rep);
    }

    /**
     * Returns the number of existing repetitions of ADT_A17_PATIENT
     */
    public int PATIENTRepetitionsUsed {
get{
        var reps = -1;
        try {
            reps = GetAll("PATIENT").Length;
        } catch (HL7Exception e) {
            var message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
            HapiLogFactory.GetHapiLog(GetType()).Error(message, e);
            throw new Exception(message);
        }

        return reps;
    }
    }

    /**
     * Enumerate over the ADT_A17_PATIENT results
     */
    public IEnumerable<ADT_A17_PATIENT> PATIENTs
    {
        get
        {
            for (var rep = 0; rep < PATIENTRepetitionsUsed; rep++)
            {
                yield return (ADT_A17_PATIENT)GetStructure("PATIENT", rep);
            }
        }
    }

    /// <summary>
    /// Adds a new ADT_A17_PATIENT.
    /// </summary>
    public ADT_A17_PATIENT AddPATIENT()
    {
        return AddStructure("PATIENT") as ADT_A17_PATIENT;
    }

    /// <summary>
    /// Removes the given ADT_A17_PATIENT.
    /// </summary>
    public void RemovePATIENT(ADT_A17_PATIENT toRemove)
    {
        RemoveStructure("PATIENT", toRemove);
    }

    /// <summary>
    /// Removes the ADT_A17_PATIENT at the given index.
    /// </summary>
    public void RemovePATIENTAt(int index)
    {
        RemoveRepetition("PATIENT", index);
    }
}
}
