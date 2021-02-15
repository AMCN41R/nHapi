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
    /// Represents the BAR_P01_VISIT Group.  A Group is an ordered collection of message
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements...
    /// <ol>
    /// <li>0: PV1 (PATIENT VISIT) optional</li>
    /// <li>1: DG1 (DIAGNOSIS) optional repeating</li>
    /// <li>2: PR1 (PROCEDURES) optional repeating</li>
    /// <li>3: GT1 (GUARANTOR) optional repeating</li>
    /// <li>4: NK1 (NEXT OF KIN) optional repeating</li>
    /// <li>5: IN1 (INSURANCE) optional repeating</li>
    /// <li>6: ACC (ACCIDENT) optional</li>
    /// <li>7: UB1 (UB82 DATA) optional</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class BAR_P01_VISIT : AbstractGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BAR_P01_VISIT"/> class.
        /// </summary>
        /// <param name="parent">The parent group.</param>
        /// <param name="factory">The model class factory.</param>
        public BAR_P01_VISIT(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                add(typeof(PV1), false, false);
                add(typeof(DG1), false, true);
                add(typeof(PR1), false, true);
                add(typeof(GT1), false, true);
                add(typeof(NK1), false, true);
                add(typeof(IN1), false, true);
                add(typeof(ACC), false, false);
                add(typeof(UB1), false, false);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating BAR_P01_VISIT - this is probably a bug in the source code generator.", e);
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
        /// Gets the number of existing repetitions of DG1.
        /// </summary>
        public int DG1RepetitionsUsed
        {
            get
            {
                try
                {
                    return GetAll("DG1").Length;
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
        /// Gets the DG1 results.
        /// </summary>
        public IEnumerable<DG1> DG1s
        {
            get
            {
                for (var rep = 0; rep < DG1RepetitionsUsed; rep++)
                {
                    yield return (DG1)GetStructure("DG1", rep);
                }
            }
        }

        /// <summary>
        /// Gets the number of existing repetitions of PR1.
        /// </summary>
        public int PR1RepetitionsUsed
        {
            get
            {
                try
                {
                    return GetAll("PR1").Length;
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
        /// Gets the PR1 results.
        /// </summary>
        public IEnumerable<PR1> PR1s
        {
            get
            {
                for (var rep = 0; rep < PR1RepetitionsUsed; rep++)
                {
                    yield return (PR1)GetStructure("PR1", rep);
                }
            }
        }

        /// <summary>
        /// Gets the number of existing repetitions of GT1.
        /// </summary>
        public int GT1RepetitionsUsed
        {
            get
            {
                try
                {
                    return GetAll("GT1").Length;
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
        /// Gets the GT1 results.
        /// </summary>
        public IEnumerable<GT1> GT1s
        {
            get
            {
                for (var rep = 0; rep < GT1RepetitionsUsed; rep++)
                {
                    yield return (GT1)GetStructure("GT1", rep);
                }
            }
        }

        /// <summary>
        /// Gets the number of existing repetitions of NK1.
        /// </summary>
        public int NK1RepetitionsUsed
        {
            get
            {
                try
                {
                    return GetAll("NK1").Length;
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
        /// Gets the NK1 results.
        /// </summary>
        public IEnumerable<NK1> NK1s
        {
            get
            {
                for (var rep = 0; rep < NK1RepetitionsUsed; rep++)
                {
                    yield return (NK1)GetStructure("NK1", rep);
                }
            }
        }

        /// <summary>
        /// Gets the number of existing repetitions of IN1.
        /// </summary>
        public int IN1RepetitionsUsed
        {
            get
            {
                try
                {
                    return GetAll("IN1").Length;
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
        /// Gets the IN1 results.
        /// </summary>
        public IEnumerable<IN1> IN1s
        {
            get
            {
                for (var rep = 0; rep < IN1RepetitionsUsed; rep++)
                {
                    yield return (IN1)GetStructure("IN1", rep);
                }
            }
        }

        /// <summary>
        /// Gets the ACC (ACCIDENT) - creates it if necessary.
        /// </summary>
        public ACC ACC
        {
            get
            {
                try
                {
                    return (ACC)GetStructure("ACC");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the UB1 (UB82 DATA) - creates it if necessary.
        /// </summary>
        public UB1 UB1
        {
            get
            {
                try
                {
                    return (UB1)GetStructure("UB1");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Returns the first repetition of DG1 (DIAGNOSIS) - creates it if necessary.
        /// </summary>
        /// <returns>A DG1 segment.</returns>
        public DG1 GetDG1()
        {
            try
            {
                return (DG1)GetStructure("DG1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new Exception("An unexpected error occurred", e);
            }
        }

        /// <summary>
        /// Returns a specific repetition of DG1 (DIAGNOSIS) - creates it if necessary.
        /// </summary>
        /// <param name="rep">The repetition.</param>
        /// <returns>A DG1 segment.</returns>
        /// <exception cref="HL7Exception">Thrown if the repetition requested is more than one greater than the number of existing repetitions.</exception>
        public DG1 GetDG1(int rep)
        {
            return (DG1)GetStructure("DG1", rep);
        }

        /// <summary>
        /// Adds a new DG1.
        /// </summary>
        /// <returns>A DG1 segment.</returns>
        public DG1 AddDG1()
        {
            return AddStructure("DG1") as DG1;
        }

        /// <summary>
        /// Removes the given DG1.
        /// </summary>
        /// <param name="toRemove">The segment to remove.</param>
        public void RemoveDG1(DG1 toRemove)
        {
            RemoveStructure("DG1", toRemove);
        }

        /// <summary>
        /// Removes the DG1 at the given index.
        /// </summary>
        /// <param name="index">The index of the segment to remove.</param>
        public void RemoveDG1At(int index)
        {
            RemoveRepetition("DG1", index);
        }

        /// <summary>
        /// Returns  first repetition of PR1 (PROCEDURES) - creates it if necessary.
        /// </summary>
        /// <returns>A PR1 segment.</returns>
        public PR1 GetPR1()
        {
            try
            {
                return (PR1)GetStructure("PR1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new Exception("An unexpected error occurred", e);
            }
        }

        /// <summary>
        /// Returns a specific repetition of PR1 * (PROCEDURES) - creates it if necessary.
        /// </summary>
        /// <param name="rep">The number of repetitions.</param>
        /// <returns>A PR1 segment.</returns>
        /// <exception cref="HL7Exception">Thrown if the repetition requested is more than one greater than the number of existing repetitions.</exception>
        public PR1 GetPR1(int rep)
        {
            return (PR1)GetStructure("PR1", rep);
        }

        /// <summary>
        /// Adds a new PR1.
        /// </summary>
        /// <returns>The new PR1 segment.</returns>
        public PR1 AddPR1()
        {
            return AddStructure("PR1") as PR1;
        }

        /// <summary>
        /// Removes the given PR1.
        /// </summary>
        /// <param name="toRemove">The segment to remove.</param>
        public void RemovePR1(PR1 toRemove)
        {
            RemoveStructure("PR1", toRemove);
        }

        /// <summary>
        /// Removes the PR1 at the given index.
        /// </summary>
        /// <param name="index">The index of the segment to remove.</param>
        public void RemovePR1At(int index)
        {
            RemoveRepetition("PR1", index);
        }

        /// <summary>
        /// Returns the first repetition of GT1 (GUARANTOR) - creates it if necessary.
        /// </summary>
        /// <returns>A GT1 segment.</returns>
        public GT1 GetGT1()
        {
            try
            {
                return (GT1)GetStructure("GT1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new Exception("An unexpected error occurred", e);
            }
        }

        /// <summary>
        /// Returns a specific repetition of GT1 * (GUARANTOR) - creates it if necessary.
        /// </summary>
        /// <param name="rep">The number of repetitions.</param>
        /// <returns>A GT1 segment.</returns>
        /// <exception cref="HL7Exception">Thrown if the repetition requested is more than one greater than the number of existing repetitions.</exception>
        public GT1 GetGT1(int rep)
        {
            return (GT1)GetStructure("GT1", rep);
        }

        /// <summary>
        /// Adds a new GT1.
        /// </summary>
        /// <returns>The new GT1 segment.</returns>
        public GT1 AddGT1()
        {
            return AddStructure("GT1") as GT1;
        }

        /// <summary>
        /// Removes the given GT1.
        /// </summary>
        /// <param name="toRemove">The segment to remove.</param>
        public void RemoveGT1(GT1 toRemove)
        {
            RemoveStructure("GT1", toRemove);
        }

        /// <summary>
        /// Removes the GT1 at the given index.
        /// </summary>
        /// <param name="index">The index of the segment to remove.</param>
        public void RemoveGT1At(int index)
        {
            RemoveRepetition("GT1", index);
        }

        /// <summary>
        /// Returns the first repetition of NK1 (NEXT OF KIN) - creates it if necessary.
        /// </summary>
        /// <returns>A NK1 segment.</returns>
        public NK1 GetNK1()
        {
            try
            {
                return (NK1)GetStructure("NK1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new Exception("An unexpected error occurred", e);
            }
        }

        /// <summary>
        /// Returns a specific repetition of NK1 * (NEXT OF KIN) - creates it if necessary.
        /// </summary>
        /// <param name="rep">The number of repetitions.</param>
        /// <returns>A NK1 segment.</returns>
        /// <exception cref="HL7Exception">Thrown if the repetition requested is more than one greater than the number of existing repetitions.</exception>
        public NK1 GetNK1(int rep)
        {
            return (NK1)GetStructure("NK1", rep);
        }

        /// <summary>
        /// Adds a new NK1.
        /// </summary>
        /// <returns>A NK1 segment.</returns>
        public NK1 AddNK1()
        {
            return AddStructure("NK1") as NK1;
        }

        /// <summary>
        /// Removes the given NK1.
        /// </summary>
        /// <param name="toRemove">The segment to remove.</param>
        public void RemoveNK1(NK1 toRemove)
        {
            RemoveStructure("NK1", toRemove);
        }

        /// <summary>
        /// Removes the NK1 at the given index.
        /// </summary>
        /// <param name="index">The index of the segment to remove.</param>
        public void RemoveNK1At(int index)
        {
            RemoveRepetition("NK1", index);
        }

        /// <summary>
        /// Returns the first repetition of IN1 (INSURANCE) - creates it if necessary.
        /// </summary>
        /// <returns>A IN1 segment.</returns>
        public IN1 GetIN1()
        {
            try
            {
                return (IN1)GetStructure("IN1");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new Exception("An unexpected error occurred", e);
            }
        }

        /// <summary>
        /// Returns a specific repetition of IN1 * (INSURANCE) - creates it if necessary.
        /// </summary>
        /// <param name="rep">The number of repetitions.</param>
        /// <returns>A IN1 segment.</returns>
        /// <exception cref="HL7Exception">Thrown if the repetition requested is more than one greater than the number of existing repetitions.</exception>
        public IN1 GetIN1(int rep)
        {
            return (IN1)GetStructure("IN1", rep);
        }

        /// <summary>
        /// Adds a new IN1.
        /// </summary>
        /// <returns>The new IN1 segment.</returns>
        public IN1 AddIN1()
        {
            return AddStructure("IN1") as IN1;
        }

        /// <summary>
        /// Removes the given IN1.
        /// </summary>
        /// <param name="toRemove">The segment to remove.</param>
        public void RemoveIN1(IN1 toRemove)
        {
            RemoveStructure("IN1", toRemove);
        }

        /// <summary>
        /// Removes the IN1 at the given index.
        /// </summary>
        /// <param name="index">The index of the segment to remove.</param>
        public void RemoveIN1At(int index)
        {
            RemoveRepetition("IN1", index);
        }
    }
}
