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
/// Represents a ORR_O02 message structure (see chapter [AAA]). This structure contains the
/// following elements:.
/// <ol>
/// <li>0: MSH (MESSAGE HEADER) </li>
/// <li>1: MSA (MESSAGE ACKNOWLEDGMENT) </li>
/// <li>2: NTE (NOTES AND COMMENTS) optional repeating</li>
/// <li>3: ORR_O02_PATIENT (a Group object) optional </li>
/// </ol>
/// </summary>
[Serializable]
public class ORR_O02 : AbstractMessage  {

    /// <summary>
    /// Creates a new ORR_O02 Group with custom IModelClassFactory.
    /// </summary>
    public ORR_O02(IModelClassFactory factory)
        : base(factory){
       init(factory);
    }

    /// <summary>
    /// Creates a new ORR_O02 Group with DefaultModelClassFactory.
    /// </summary>
    public ORR_O02()
        : base(new DefaultModelClassFactory()) {
       init(new DefaultModelClassFactory());
    }

    /// <summary>
    /// initalize method for ORR_O02.  This does the segment setup for the message.
    /// </summary>
    private void init(IModelClassFactory factory) {
       try {
          add(typeof(MSH), true, false);
          add(typeof(MSA), true, false);
          add(typeof(NTE), false, true);
          add(typeof(ORR_O02_PATIENT), false, false);
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORR_O02 - this is probably a bug in the source code generator.", e);
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
    /// Returns MSA (MESSAGE ACKNOWLEDGMENT) - creates it if necessary.
    /// </summary>
    public MSA MSA {
get{
       MSA ret = null;
       try {
          ret = (MSA)GetStructure("MSA");
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
    /// Returns ORR_O02_PATIENT (a Group object) - creates it if necessary.
    /// </summary>
    public ORR_O02_PATIENT PATIENT {
get{
       ORR_O02_PATIENT ret = null;
       try {
          ret = (ORR_O02_PATIENT)GetStructure("PATIENT");
       } catch(HL7Exception e) {
          HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
          throw new Exception("An unexpected error occurred",e);
       }

       return ret;
    }
    }
}
}
