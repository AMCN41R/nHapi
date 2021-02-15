namespace NHapi.Model.V21.Group
{
    using System;

    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Segment;

    /// <summary>
    /// Represents the ORR_O02_ORDER_DETAIL Group. A Group is an ordered collection of message
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements...
    /// <ol>
    /// <li>0: OBR (OBSERVATION REQUEST)</li>
    /// <li>1: ORO (ORDER OTHER)</li>
    /// <li>2: RX1 (PHARMACY ORDER)</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class ORR_O02_ORDER_DETAIL : AbstractGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ORR_O02_ORDER_DETAIL"/> class.
        /// </summary>
        /// <param name="parent">The parent group.</param>
        /// <param name="factory">The model class factory.</param>
        public ORR_O02_ORDER_DETAIL(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                add(typeof(OBR), true, false);
                add(typeof(ORO), true, false);
                add(typeof(RX1), true, false);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORR_O02_ORDER_DETAIL - this is probably a bug in the source code generator.", e);
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
    }
}
