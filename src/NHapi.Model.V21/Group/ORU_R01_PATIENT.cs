namespace NHapi.Model.V21.Group
{
    using System;
    using System.Collections.Generic;

    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Segment;

    /// <summary>
    /// Represents the ORU_R01_PATIENT Group. A Group is an ordered collection of message
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements...
    /// <ol>
    /// <li>0: PID (PATIENT IDENTIFICATION)</li>
    /// <li>1: NTE (NOTES AND COMMENTS) optional repeating</li>
    /// <li>2: PV1 (PATIENT VISIT) optional</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class ORU_R01_PATIENT : AbstractGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ORU_R01_PATIENT"/> class.
        /// </summary>
        /// <param name="parent">The parent group.</param>
        /// <param name="factory">The model class factory.</param>
        public ORU_R01_PATIENT(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                add(typeof(PID), true, false);
                add(typeof(NTE), false, true);
                add(typeof(PV1), false, false);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORU_R01_PATIENT - this is probably a bug in the source code generator.", e);
            }
        }

        /// <summary>
        /// Gets the PID (PATIENT IDENTIFICATION) - creates it if necessary.
        /// </summary>
        public PID PID
        {
            get
            {
                try
                {
                    return (PID)GetStructure("PID");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the number of existing repetitions of NTE.
        /// </summary>
        public int NTERepetitionsUsed
        {
            get
            {
                try
                {
                    return GetAll("NTE").Length;
                }
                catch (HL7Exception e)
                {
                    var message = "Unexpected error accessing data - this is probably a bug in the source code generator.";
                    HapiLogFactory.GetHapiLog(GetType()).Error(message, e);
                    throw new Exception(message);
                }
            }
        }

        /// <summary>
        /// Gets the NTE results.
        /// </summary>
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
        /// Gets the PV1 (PATIENT VISIT) - creates it if necessary.
        /// </summary>
        public PV1 PV1
        {
            get
            {
                try
                {
                    return (PV1)GetStructure("PV1");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Returns the first repetition of NTE (NOTES AND COMMENTS) - creates it if necessary.
        /// </summary>
        /// <returns>An NTE segment.</returns>
        public NTE GetNTE()
        {
            try
            {
                return (NTE)GetStructure("NTE");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new Exception("An unexpected error occurred", e);
            }
        }

        /// <summary>
        /// Returns a specific repetition of NTE * (NOTES AND COMMENTS) - creates it if necessary.
        /// </summary>
        /// <param name="rep">The number of repetitions.</param>
        /// <returns>An NTE segment.</returns>
        /// <exception cref="HL7Exception">Thrown if the repetition requested is more than one greater than the number of existing repetitions.</exception>
        public NTE GetNTE(int rep)
        {
            return (NTE)GetStructure("NTE", rep);
        }

        /// <summary>
        /// Adds a new NTE.
        /// </summary>
        /// <returns>An NTE segment.</returns>
        public NTE AddNTE()
        {
            return AddStructure("NTE") as NTE;
        }

        /// <summary>
        /// Removes the given NTE.
        /// </summary>
        /// <param name="toRemove">The segment to remove.</param>
        public void RemoveNTE(NTE toRemove)
        {
            RemoveStructure("NTE", toRemove);
        }

        /// <summary>
        /// Removes the NTE at the given index.
        /// </summary>
        /// <param name="index">The index of the segment to remove.</param>
        public void RemoveNTEAt(int index)
        {
            RemoveRepetition("NTE", index);
        }
    }
}
