namespace NHapi.Model.V21.Group
{
    using System;

    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Segment;

    /// <summary>
    /// Represents the ARD_A19_QUERY_RESPONSE Group.  A Group is an ordered collection of message
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements...
    /// <ol>
    /// <li>0: EVN (EVENT TYPE) optional</li>
    /// <li>1: PID (PATIENT IDENTIFICATION)</li>
    /// <li>2: PV1 (PATIENT VISIT)</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class ARD_A19_QUERY_RESPONSE : AbstractGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ARD_A19_QUERY_RESPONSE"/> class.
        /// </summary>
        /// <param name="parent">The parent group.</param>
        /// <param name="factory">The model class factory.</param>
        public ARD_A19_QUERY_RESPONSE(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                add(typeof(EVN), false, false);
                add(typeof(PID), true, false);
                add(typeof(PV1), true, false);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ARD_A19_QUERY_RESPONSE - this is probably a bug in the source code generator.", e);
            }
        }

        /// <summary>
        /// Gets the EVN (EVENT TYPE) - creates it if necessary.
        /// </summary>
        public EVN EVN
        {
            get
            {
                try
                {
                    return (EVN)GetStructure("EVN");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
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
    }
}
