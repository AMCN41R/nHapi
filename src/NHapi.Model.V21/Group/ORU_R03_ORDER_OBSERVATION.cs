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
    /// Represents the ORU_R03_ORDER_OBSERVATION Group. A Group is an ordered collection of message
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements...
    /// <ol>
    /// <li>0: ORC (COMMON ORDER) optional</li>
    /// <li>1: OBR (OBSERVATION REQUEST)</li>
    /// <li>2: NTE (NOTES AND COMMENTS) optional repeating</li>
    /// <li>3: ORU_R03_OBSERVATION (a Group object) repeating</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class ORU_R03_ORDER_OBSERVATION : AbstractGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ORU_R03_ORDER_OBSERVATION"/> class.
        /// </summary>
        /// <param name="parent">The parent group.</param>
        /// <param name="factory">The model class factory.</param>
        public ORU_R03_ORDER_OBSERVATION(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                add(typeof(ORC), false, false);
                add(typeof(OBR), true, false);
                add(typeof(NTE), false, true);
                add(typeof(ORU_R03_OBSERVATION), true, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORU_R03_ORDER_OBSERVATION - this is probably a bug in the source code generator.", e);
            }
        }

        /// <summary>
        /// Gets the ORC (COMMON ORDER) - creates it if necessary.
        /// </summary>
        public ORC ORC
        {
            get
            {
                try
                {
                    return (ORC)GetStructure("ORC");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the OBR (OBSERVATION REQUEST) - creates it if necessary.
        /// </summary>
        public OBR OBR
        {
            get
            {
                try
                {
                    return (OBR)GetStructure("OBR");
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
        /// Gets the number of existing repetitions of ORU_R03_OBSERVATION.
        /// </summary>
        public int OBSERVATIONRepetitionsUsed
        {
            get
            {
                try
                {
                    return GetAll("OBSERVATION").Length;
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
        /// Gets  the ORU_R03_OBSERVATION results.
        /// </summary>
        public IEnumerable<ORU_R03_OBSERVATION> OBSERVATIONs
        {
            get
            {
                for (var rep = 0; rep < OBSERVATIONRepetitionsUsed; rep++)
                {
                    yield return (ORU_R03_OBSERVATION)GetStructure("OBSERVATION", rep);
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

        /// <summary>
        /// Returns  first repetition of ORU_R03_OBSERVATION (a Group object) - creates it if necessary.
        /// </summary>
        /// <returns>An ORU_R03_OBSERVATION group object.</returns>
        public ORU_R03_OBSERVATION GetOBSERVATION()
        {
            try
            {
                return (ORU_R03_OBSERVATION)GetStructure("OBSERVATION");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new Exception("An unexpected error occurred", e);
            }
        }

        /// <summary>
        /// Returns a specific repetition of ORU_R03_OBSERVATION * (a Group object) - creates it if necessary.
        /// </summary>
        /// <param name="rep">The number of repetitions.</param>
        /// <returns>An ORU_R03_OBSERVATION group object.</returns>
        /// <exception cref="HL7Exception">Thrown if the repetition requested is more than one greater than the number of existing repetitions.</exception>
        public ORU_R03_OBSERVATION GetOBSERVATION(int rep)
        {
            return (ORU_R03_OBSERVATION)GetStructure("OBSERVATION", rep);
        }

        /// <summary>
        /// Adds a new ORU_R03_OBSERVATION.
        /// </summary>
        /// <returns>An ORU_R03_OBSERVATION group object.</returns>
        public ORU_R03_OBSERVATION AddOBSERVATION()
        {
            return AddStructure("OBSERVATION") as ORU_R03_OBSERVATION;
        }

        /// <summary>
        /// Removes the given ORU_R03_OBSERVATION.
        /// </summary>
        /// <param name="toRemove">The segment to remove.</param>
        public void RemoveOBSERVATION(ORU_R03_OBSERVATION toRemove)
        {
            RemoveStructure("OBSERVATION", toRemove);
        }

        /// <summary>
        /// Removes the ORU_R03_OBSERVATION at the given index.
        /// </summary>
        /// <param name="index">The index of the segment to remove.</param>
        public void RemoveOBSERVATIONAt(int index)
        {
            RemoveRepetition("OBSERVATION", index);
        }
    }
}
