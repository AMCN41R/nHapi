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
    /// Represents the ORM_O01_ORDER_DETAIL Group. A Group is an ordered collection of message
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements...
    /// <ol>
    /// <li>0: OBR (OBSERVATION REQUEST)</li>
    /// <li>1: ORO (ORDER OTHER)</li>
    /// <li>2: RX1 (PHARMACY ORDER)</li>
    /// <li>3: NTE (NOTES AND COMMENTS) optional repeating</li>
    /// <li>4: OBX (RESULT) optional repeating</li>
    /// <li>5: NTE (NOTES AND COMMENTS) optional repeating</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class ORM_O01_ORDER_DETAIL : AbstractGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ORM_O01_ORDER_DETAIL"/> class.
        /// </summary>
        /// <param name="parent">The parent group.</param>
        /// <param name="factory">The model class factory.</param>
        public ORM_O01_ORDER_DETAIL(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                add(typeof(OBR), true, false);
                add(typeof(ORO), true, false);
                add(typeof(RX1), true, false);
                add(typeof(NTE), false, true);
                add(typeof(OBX), false, true);
                add(typeof(NTE), false, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORM_O01_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
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
        /// Gets the ORO (ORDER OTHER) - creates it if necessary.
        /// </summary>
        public ORO ORO
        {
            get
            {
                try
                {
                    return (ORO)GetStructure("ORO");
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
        /// Gets the number of existing repetitions of OBX.
        /// </summary>
        public int OBXRepetitionsUsed
        {
            get
            {
                try
                {
                    return GetAll("OBX").Length;
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
        /// Gets the OBX results.
        /// </summary>
        public IEnumerable<OBX> OBXs
        {
            get
            {
                for (var rep = 0; rep < OBXRepetitionsUsed; rep++)
                {
                    yield return (OBX)GetStructure("OBX", rep);
                }
            }
        }

        /// <summary>
        /// Gets the RX1 (PHARMACY ORDER) - creates it if necessary.
        /// </summary>
        public RX1 RX1
        {
            get
            {
                try
                {
                    return (RX1)GetStructure("RX1");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the number of existing repetitions of NTE2.
        /// </summary>
        public int NTE2RepetitionsUsed
        {
            get
            {
                try
                {
                    return GetAll("NTE2").Length;
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
        public IEnumerable<NTE> NTE2s
        {
            get
            {
                for (var rep = 0; rep < NTE2RepetitionsUsed; rep++)
                {
                    yield return (NTE)GetStructure("NTE2", rep);
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
        /// Returns  first repetition of OBX (RESULT) - creates it if necessary.
        /// </summary>
        /// <returns>An OBX segment.</returns>
        public OBX GetOBX()
        {
            try
            {
                return (OBX)GetStructure("OBX");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new Exception("An unexpected error occurred", e);
            }
        }

        /// <summary>
        /// Returns a specific repetition of OBX * (RESULT) - creates it if necessary.
        /// </summary>
        /// <param name="rep">The number of repetitions.</param>
        /// <returns>An OBX segment.</returns>
        /// <exception cref="HL7Exception">Thrown if the repetition requested is more than one greater than the number of existing repetitions.</exception>
        public OBX GetOBX(int rep)
        {
            return (OBX)GetStructure("OBX", rep);
        }

        /// <summary>
        /// Adds a new OBX.
        /// </summary>
        /// <returns>An OBX segment.</returns>
        public OBX AddOBX()
        {
            return AddStructure("OBX") as OBX;
        }

        /// <summary>
        /// Removes the given OBX.
        /// </summary>
        /// <param name="toRemove">The segment to remove.</param>
        public void RemoveOBX(OBX toRemove)
        {
            RemoveStructure("OBX", toRemove);
        }

        /// <summary>
        /// Removes the OBX at the given index.
        /// </summary>
        /// <param name="index">The index of the segment to remove.</param>
        public void RemoveOBXAt(int index)
        {
            RemoveRepetition("OBX", index);
        }

        /// <summary>
        /// Returns  first repetition of NTE2 (NOTES AND COMMENTS) - creates it if necessary.
        /// </summary>
        /// <returns>An NTE segment.</returns>
        public NTE GetNTE2()
        {
            try
            {
                return (NTE)GetStructure("NTE2");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new Exception("An unexpected error occurred", e);
            }
        }

        /// <summary>
        /// Returns a specific repetition of NTE2 * (NOTES AND COMMENTS) - creates it if necessary.
        /// </summary>
        /// <param name="rep">The number of repetitions.</param>
        /// <returns>An NTE segment.</returns>
        /// <exception cref="HL7Exception">Thrown if the repetition requested is more than one greater than the number of existing repetitions.</exception>
        public NTE GetNTE2(int rep)
        {
            return (NTE)GetStructure("NTE2", rep);
        }

        /// <summary>
        /// Adds a new NTE.
        /// </summary>
        /// <returns> A NTE segment.</returns>
        public NTE AddNTE2()
        {
            return AddStructure("NTE2") as NTE;
        }

        /// <summary>
        /// Removes the given NTE.
        /// </summary>
        /// <param name="toRemove">The segment to remove.</param>
        public void RemoveNTE2(NTE toRemove)
        {
            RemoveStructure("NTE2", toRemove);
        }

        /// <summary>
        /// Removes the NTE at the given index.
        /// </summary>
        /// <param name="index">The index of the segment to remove.</param>
        public void RemoveNTE2At(int index)
        {
            RemoveRepetition("NTE2", index);
        }
    }
}
