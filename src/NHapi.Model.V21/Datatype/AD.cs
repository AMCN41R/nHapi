namespace NHapi.Model.V21.Datatype
{
    using System;

    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;

    /// <summary>
    /// The HL7 AD (address) data type. Consists of the following components...
    /// <ol>
    /// <li>Street address (ST)</li>
    /// <li>Other designation (ST)</li>
    /// <li>city (ST)</li>
    /// <li>state or province (ST)</li>
    /// <li>zip (ST)</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class AD : AbstractType, IComposite
    {
        private readonly IType[] data;

        /// <summary>
        /// Initializes a new instance of the <see cref="AD"/> class.
        /// </summary>
        /// <param name="message">The Message to which this Type belongs.</param>
        public AD(IMessage message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AD"/> class.
        /// </summary>
        /// <param name="message">The Message to which this Type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public AD(IMessage message, string description)
            : base(message, description)
        {
            data = new IType[5];
            data[0] = new ST(message, "Street address");
            data[1] = new ST(message, "Other designation");
            data[2] = new ST(message, "City");
            data[3] = new ST(message, "State or province");
            data[4] = new ST(message, "Zip");
        }

        /// <summary>
        /// Gets an array containing the data elements.
        /// </summary>
        public IType[] Components => data;

        /// <summary>
        /// Gets the street address (component #0). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST StreetAddress
        {
            get
            {
                try
                {
                    return (ST)this[0];
                }
                catch (DataTypeException e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the other designation (component #1). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST OtherDesignation
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
        /// Gets the city (component #2). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST City
        {
            get
            {
                try
                {
                    return (ST)this[2];
                }
                catch (DataTypeException e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the state or province (component #3). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST StateOrProvince
        {
            get
            {
                try
                {
                    return (ST)this[3];
                }
                catch (DataTypeException e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the zip (component #4). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST Zip
        {
            get
            {
                try
                {
                    return (ST)this[4];
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
                    throw new DataTypeException($"Element {index} doesn't exist in 5 element AD composite");
                }
            }
        }
    }
}