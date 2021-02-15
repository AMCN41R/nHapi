namespace NHapi.Model.V21.Datatype
{
    using System;

    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;
    using NHapi.Base.Model.Primitive;

    /// <summary>
    /// The HL7 TS (time stamp) data type. Consists of the following components...
    /// <ol>
    /// <li>time of an event (TSComponentOne)</li>
    /// <li>degree of precision (ST)</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class TS : AbstractType, IComposite
    {
        private readonly IType[] data;

        /// <summary>
        /// Initializes a new instance of the <see cref="TS"/> class.
        /// </summary>
        /// <param name="message">The Message to which this Type belongs.</param>
        public TS(IMessage message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TS"/> class.
        /// </summary>
        /// <param name="message">The Message to which this Type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public TS(IMessage message, string description)
            : base(message, description)
        {
            data = new IType[2];
            data[0] = new TSComponentOne(message, "Time of an event");
            data[1] = new ST(message, "Degree of precision");
        }

        /// <summary>
        /// Gets an array containing the data elements.
        /// </summary>
        public IType[] Components => data;

        /// <summary>
        /// Gets time of an event (component #0). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public TSComponentOne TimeOfAnEvent
        {
            get
            {
                try
                {
                    return (TSComponentOne)this[0];
                }
                catch (DataTypeException e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets degree of precision (component #1). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST DegreeOfPrecision
        {
            get
            {
                try
                {
                    return (ST)this[1];
                }
                catch (DataTypeException e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets an individual data component.
        /// </summary>
        /// <param name="index">The index item to get (zero based).</param>
        /// <returns>The data component (as a type) at the requested number (ordinal).</returns>
        /// <exception cref="DataTypeException">Thrown if the given element number is out of range.</exception>
        public IType this[int index]
        {
            get
            {
                try
                {
                    return data[index];
                }
                catch (ArgumentOutOfRangeException)
                {
                    throw new DataTypeException($"Element {index} doesn't exist in 2 element TS composite");
                }
            }
        }
    }
}