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
    /// Represents the ORR_O02_PATIENT Group. A Group is an ordered collection of message
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements...
    /// <ol>
    /// <li>0: PID (PATIENT IDENTIFICATION) optional</li>
    /// <li>1: NTE (NOTES AND COMMENTS) optional repeating</li>
    /// <li>2: ORR_O02_ORDER (a Group object) repeating</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class ORR_O02_PATIENT : AbstractGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ORR_O02_PATIENT"/> class.
        /// </summary>
        /// <param name="parent">The parent group.</param>
        /// <param name="factory">The model class factory.</param>
        public ORR_O02_PATIENT(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                add(typeof(PID), false, false);
                add(typeof(NTE), false, true);
                add(typeof(ORR_O02_ORDER), true, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORR_O02_PATIENT - this is probably a bug in the source code generator.", e);
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
        /// Gets the number of existing repetitions of ORR_O02_ORDER.
        /// </summary>
        public int ORDERRepetitionsUsed
        {
            get
            {
                try
                {
                    return GetAll("ORDER").Length;
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
        /// Gets the ORR_O02_ORDER results.
        /// </summary>
        public IEnumerable<ORR_O02_ORDER> ORDERs
        {
            get
            {
                for (var rep = 0; rep < ORDERRepetitionsUsed; rep++)
                {
                    yield return (ORR_O02_ORDER)GetStructure("ORDER", rep);
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
        /// Returns the first repetition of ORR_O02_ORDER (a Group object) - creates it if necessary.
        /// </summary>
        /// <returns>An ORR_O02_ORDER group object.</returns>
        public ORR_O02_ORDER GetORDER()
        {
            try
            {
                return (ORR_O02_ORDER)GetStructure("ORDER");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new Exception("An unexpected error occurred", e);
            }
        }

        /// <summary>
        /// Returns a specific repetition of ORR_O02_ORDER * (a Group object) - creates it if necessary.
        /// </summary>
        /// <param name="rep">The number of repetitions.</param>
        /// <returns>An ORR_O02_ORDER group object.</returns>
        /// <exception cref="HL7Exception">Thrown if the repetition requested is more than one greater than the number of existing repetitions.</exception>
        public ORR_O02_ORDER GetORDER(int rep)
        {
            return (ORR_O02_ORDER)GetStructure("ORDER", rep);
        }

        /// <summary>
        /// Adds a new ORR_O02_ORDER.
        /// </summary>
        /// <returns>An ORR_O02_ORDER group object.</returns>
        public ORR_O02_ORDER AddORDER()
        {
            return AddStructure("ORDER") as ORR_O02_ORDER;
        }

        /// <summary>
        /// Removes the given ORR_O02_ORDER.
        /// </summary>
        /// <param name="toRemove">The segment to remove.</param>
        public void RemoveORDER(ORR_O02_ORDER toRemove)
        {
            RemoveStructure("ORDER", toRemove);
        }

        /// <summary>
        /// Removes the ORR_O02_ORDER at the given index.
        /// </summary>
        /// <param name="index">The index of the segment to remove.</param>
        public void RemoveORDERAt(int index)
        {
            RemoveRepetition("ORDER", index);
        }
    }
}
