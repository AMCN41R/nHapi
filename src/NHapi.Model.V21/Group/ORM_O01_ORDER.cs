namespace NHapi.Model.V21.Group
{
    using System;

    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Segment;

    /// <summary>
    /// Represents the ORM_O01_ORDER Group. A Group is an ordered collection of message
    /// segments that can repeat together or be optionally in/excluded together.
    /// This Group contains the following elements...
    /// <ol>
    /// <li>0: ORC (COMMON ORDER)</li>
    /// <li>1: ORM_O01_ORDER_DETAIL (a Group object) optional</li>
    /// <li>2: BLG (BILLING) optional</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class ORM_O01_ORDER : AbstractGroup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ORM_O01_ORDER"/> class.
        /// </summary>
        /// <param name="parent">The parent group.</param>
        /// <param name="factory">The model class factory.</param>
        public ORM_O01_ORDER(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            try
            {
                add(typeof(ORC), true, false);
                add(typeof(ORM_O01_ORDER_DETAIL), false, false);
                add(typeof(BLG), false, false);
            }
            catch (HL7Exception e)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error creating ORM_O01_ORDER - this is probably a bug in the source code generator.", e);
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
        /// Gets the ORM_O01_ORDER_DETAIL (a Group object) - creates it if necessary.
        /// </summary>
        public ORM_O01_ORDER_DETAIL ORDER_DETAIL
        {
            get
            {
                try
                {
                    return (ORM_O01_ORDER_DETAIL)GetStructure("ORDER_DETAIL");
                }
                catch (HL7Exception e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected error accessing data - this is probably a bug in the source code generator.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the BLG (BILLING) - creates it if necessary.
        /// </summary>
        public BLG BLG
        {
            get
            {
                try
                {
                    return (BLG)GetStructure("BLG");
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
