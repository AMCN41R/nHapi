namespace NHapi.Model.V21.Message
{
    using System;
    using System.Collections.Generic;

    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Group;
    using NHapi.Model.V21.Segment;

    /// <summary>
    /// Represents a ADR_A19 message structure (see chapter [AAA]). This structure contains the
    /// following elements...
    /// <ol>
    /// <li>0: MSH (MESSAGE HEADER)</li>
    /// <li>1: MSA (MESSAGE ACKNOWLEDGMENT)</li>
    /// <li>2: QRD (QUERY DEFINITION)</li>
    /// <li>3: ADR_A19_QUERY_RESPONSE (a Group object) repeating</li>
    /// <li>4: DSC (CONTINUATION POINTER) optional</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class ADR_A19 : AbstractMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ADR_A19"/> class.
        /// </summary>
        /// <param name="factory">The model class factory.</param>
        public ADR_A19(IModelClassFactory factory)
            : base(factory)
        {
            try
            {
                add(typeof(MSH), true, false);
                add(typeof(MSA), true, false);
                add(typeof(QRD), true, false);
                add(typeof(ADR_A19_QUERY_RESPONSE), true, true);
                add(typeof(DSC), false, false);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ADR_A19 - this is probably a bug in the source code generator.", e);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ADR_A19"/> class.
        /// </summary>
        public ADR_A19()
            : this(new DefaultModelClassFactory())
        {
        }

        /// <summary>
        /// Gets the version.
        /// </summary>
        public override string Version => Constants.VERSION;

        /// <summary>
        /// Gets the MSH (MESSAGE HEADER) - creates it if necessary.
        /// </summary>
        public MSH MSH
        {
            get
            {
                try
                {
                    return (MSH)GetStructure("MSH");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the MSA (MESSAGE ACKNOWLEDGMENT) - creates it if necessary.
        /// </summary>
        public MSA MSA
        {
            get
            {
                try
                {
                    return (MSA)GetStructure("MSA");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the QRD (QUERY DEFINITION) - creates it if necessary.
        /// </summary>
        public QRD QRD
        {
            get
            {
                try
                {
                    return (QRD)GetStructure("QRD");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the number of existing repetitions of ADR_A19_QUERY_RESPONSE.
        /// </summary>
        public int QUERY_RESPONSERepetitionsUsed
        {
            get
            {
                try
                {
                    return GetAll("QUERY_RESPONSE").Length;
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
        /// Gets the ADR_A19_QUERY_RESPONSE results.
        /// </summary>
        public IEnumerable<ADR_A19_QUERY_RESPONSE> QUERY_RESPONSEs
        {
            get
            {
                for (var rep = 0; rep < QUERY_RESPONSERepetitionsUsed; rep++)
                {
                    yield return (ADR_A19_QUERY_RESPONSE)GetStructure("QUERY_RESPONSE", rep);
                }
            }
        }

        /// <summary>
        /// Gets the DSC (CONTINUATION POINTER) - creates it if necessary.
        /// </summary>
        public DSC DSC
        {
            get
            {
                try
                {
                    return (DSC)GetStructure("DSC");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Returns  first repetition of ADR_A19_QUERY_RESPONSE (a Group object) - creates it if necessary.
        /// </summary>
        /// <returns>A ADR_A19_QUERY_RESPONSE group object.</returns>
        public ADR_A19_QUERY_RESPONSE GetQUERY_RESPONSE()
        {
            try
            {
                return (ADR_A19_QUERY_RESPONSE)GetStructure("QUERY_RESPONSE");
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                throw new Exception("An unexpected error occurred", e);
            }
        }

        /// <summary>
        /// Returns a specific repetition of ADR_A19_QUERY_RESPONSE * (a Group object) - creates it if necessary.
        /// </summary>
        /// <param name="rep">The number of repetitions.</param>
        /// <returns>A ADR_A19_QUERY_RESPONSE group object.</returns>
        /// <exception cref="HL7Exception">Thrown if the repetition requested is more than one greater than the number of existing repetitions.</exception>
        public ADR_A19_QUERY_RESPONSE GetQUERY_RESPONSE(int rep)
        {
            return (ADR_A19_QUERY_RESPONSE)GetStructure("QUERY_RESPONSE", rep);
        }

        /// <summary>
        /// Adds a new ADR_A19_QUERY_RESPONSE.
        /// </summary>
        /// <returns>A ADR_A19_QUERY_RESPONSE group object.</returns>
        public ADR_A19_QUERY_RESPONSE AddQUERY_RESPONSE()
        {
            return AddStructure("QUERY_RESPONSE") as ADR_A19_QUERY_RESPONSE;
        }

        /// <summary>
        /// Removes the given ADR_A19_QUERY_RESPONSE.
        /// </summary>
        /// <param name="toRemove">The segment to remove.</param>
        public void RemoveQUERY_RESPONSE(ADR_A19_QUERY_RESPONSE toRemove)
        {
            RemoveStructure("QUERY_RESPONSE", toRemove);
        }

        /// <summary>
        /// Removes the ADR_A19_QUERY_RESPONSE at the given index.
        /// </summary>
        /// <param name="index">The index of the segment to remove.</param>
        public void RemoveQUERY_RESPONSEAt(int index)
        {
            RemoveRepetition("QUERY_RESPONSE", index);
        }
    }
}
