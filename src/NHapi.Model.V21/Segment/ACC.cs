namespace NHapi.Model.V21.Segment
{
    using System;

    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Parser;
    using NHapi.Model.V21.Datatype;

    /// <summary>
    /// Represents an HL7 ACC message segment.
    /// This segment has the following fields...
    /// <ol>
    /// <li>ACC-1: ACCIDENT DATE/TIME (TS)</li>
    /// <li>ACC-2: ACCIDENT CODE (ID)</li>
    /// <li>ACC-3: ACCIDENT LOCATION (ST)</li>
    /// </ol>
    /// <para>
    /// The get...() methods return data from individual fields. These methods
    /// do not throw exceptions and may therefore have to handle exceptions internally.
    /// If an exception is handled internally, it is logged and null is returned.
    /// This is not expected to happen - if it does happen this indicates not so much
    /// an exceptional circumstance as a bug in the code for this class.
    /// </para>
    /// </summary>
    [Serializable]
    public class ACC : AbstractSegment
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ACC"/> class.
        /// </summary>
        /// <param name="parent">The parent group.</param>
        /// <param name="factory">The model class factory.</param>
        public ACC(IGroup parent, IModelClassFactory factory)
            : base(parent, factory)
        {
            var message = Message;
            try
            {
                add(typeof(TS), false, 1, 19, new object[] { message }, "ACCIDENT DATE/TIME");
                add(typeof(ID), false, 1, 2, new object[] { message, 50 }, "ACCIDENT CODE");
                add(typeof(ST), false, 1, 25, new object[] { message }, "ACCIDENT LOCATION");
            }
            catch (HL7Exception he)
            {
                HapiLogFactory.GetHapiLog(GetType()).Error("Can't instantiate " + GetType().Name, he);
            }
        }

        /// <summary>
        /// Gets the ACCIDENT DATE/TIME(ACC-1).
        /// </summary>
        public TS ACCIDENTDATETIME
        {
            get
            {
                try
                {
                    return (TS)GetField(1, 0);
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new Exception("An unexpected error occurred", he);
                }
                catch (Exception ex)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new Exception("An unexpected error occurred", ex);
                }
            }
        }

        /// <summary>
        /// Gets the ACCIDENT CODE(ACC-2).
        /// </summary>
        public ID ACCIDENTCODE
        {
            get
            {
                try
                {
                    return (ID)GetField(2, 0);
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new Exception("An unexpected error occurred", he);
                }
                catch (Exception ex)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new Exception("An unexpected error occurred", ex);
                }
            }
        }

        /// <summary>
        /// Gets the ACCIDENT LOCATION(ACC-3).
        /// </summary>
        public ST ACCIDENTLOCATION
        {
            get
            {
                try
                {
                    return (ST)GetField(3, 0);
                }
                catch (HL7Exception he)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", he);
                    throw new Exception("An unexpected error occurred", he);
                }
                catch (Exception ex)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem obtaining field value.  This is a bug.", ex);
                    throw new Exception("An unexpected error occurred", ex);
                }
            }
        }
    }
}