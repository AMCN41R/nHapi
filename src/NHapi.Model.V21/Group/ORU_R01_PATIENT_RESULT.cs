namespace NHapi.Model.V21.Group
{
    using System;
    using System.Collections.Generic;

    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;

    /// <summary>
    /// Represents the ORU_R01_PATIENT_RESULT Group. A Group is an ordered collection of message
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements...
    /// <ol>
    /// <li>0: ORU_R01_PATIENT (a Group object) optional</li>
    /// <li>1: ORU_R01_ORDER_OBSERVATION (a Group object) repeating</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class ORU_R01_PATIENT_RESULT : AbstractGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ORU_R01_PATIENT_RESULT"/> class.
        /// </summary>
        /// <param name="parent">The parent group.</param>
        /// <param name="factory">The model class factory.</param>
        public ORU_R01_PATIENT_RESULT(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                add(typeof(ORU_R01_PATIENT), false, false);
                add(typeof(ORU_R01_ORDER_OBSERVATION), true, true);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORU_R01_PATIENT_RESULT - this is probably a bug in the source code generator.", e);
            }
        }

        /// <summary>
        /// Gets the ORU_R01_PATIENT (a Group object) - creates it if necessary.
        /// </summary>
        public ORU_R01_PATIENT PATIENT
        {
            get
            {
                try
                {
                    return (ORU_R01_PATIENT)GetStructure("PATIENT");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the number of existing repetitions of ORU_R01_ORDER_OBSERVATION.
        /// </summary>
        public int ORDER_OBSERVATIONRepetitionsUsed
        {
            get
            {
                try
                {
                    return GetAll("ORDER_OBSERVATION").Length;
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
        /// Gets the ORU_R01_ORDER_OBSERVATION results.
        /// </summary>
        public IEnumerable<ORU_R01_ORDER_OBSERVATION> ORDER_OBSERVATIONs
        {
            get
            {
                for (var rep = 0; rep < ORDER_OBSERVATIONRepetitionsUsed; rep++)
                {
                    yield return (ORU_R01_ORDER_OBSERVATION)GetStructure("ORDER_OBSERVATION", rep);
                }
            }
        }

        /// <summary>
        /// Returns the first repetition of ORU_R01_ORDER_OBSERVATION (a Group object) - creates it if necessary.
        /// </summary>
        /// <returns>An ORU_R01_ORDER_OBSERVATION group object.</returns>
        public ORU_R01_ORDER_OBSERVATION GetORDER_OBSERVATION()
        {
            try
            {
                return (ORU_R01_ORDER_OBSERVATION)GetStructure("ORDER_OBSERVATION");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new Exception("An unexpected error occurred", e);
            }
        }

        /// <summary>
        /// Returns a specific repetition of ORU_R01_ORDER_OBSERVATION * (a Group object) - creates it if necessary.
        /// </summary>
        /// <param name="rep">The number of repetitions.</param>
        /// <returns>An ORU_R01_ORDER_OBSERVATION group object.</returns>
        /// <exception cref="HL7Exception">Thrown if the repetition requested is more than one greater than the number of existing repetitions.</exception>
        public ORU_R01_ORDER_OBSERVATION GetORDER_OBSERVATION(int rep)
        {
            return (ORU_R01_ORDER_OBSERVATION)GetStructure("ORDER_OBSERVATION", rep);
        }

        /// <summary>
        /// Adds a new ORU_R01_ORDER_OBSERVATION.
        /// </summary>
        /// <returns>An ORU_R01_ORDER_OBSERVATION group object.</returns>
        public ORU_R01_ORDER_OBSERVATION AddORDER_OBSERVATION()
        {
            return AddStructure("ORDER_OBSERVATION") as ORU_R01_ORDER_OBSERVATION;
        }

        /// <summary>
        /// Removes the given ORU_R01_ORDER_OBSERVATION.
        /// </summary>
        /// <param name="toRemove">The segment to remove.</param>
        public void RemoveORDER_OBSERVATION(ORU_R01_ORDER_OBSERVATION toRemove)
        {
            RemoveStructure("ORDER_OBSERVATION", toRemove);
        }

        /// <summary>
        /// Removes the ORU_R01_ORDER_OBSERVATION at the given index.
        /// </summary>
        /// <param name="index">The index of the segment to remove.</param>
        public void RemoveORDER_OBSERVATIONAt(int index)
        {
            RemoveRepetition("ORDER_OBSERVATION", index);
        }
    }
}
