namespace NHapi.Model.V21.Datatype
{
    using System;

    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;

    /// <summary>
    /// The HL7 CN (composite ID number and name) data type.  Consists of the following components...
    /// <ol>
    /// <li>ID (ST)</li>
    /// <li>family name (ST)</li>
    /// <li>given name (ST)</li>
    /// <li>middle initial or name (ST)</li>
    /// <li>degree (ST)</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class CN : AbstractType, IComposite
    {
        private readonly IType[] data;

        /// <summary>
        /// Initializes a new instance of the <see cref="CN"/> class.
        /// </summary>
        /// <param name="message">The Message to which this Type belongs.</param>
        public CN(IMessage message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CN"/> class.
        /// </summary>
        /// <param name="message">The Message to which this Type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public CN(IMessage message, string description)
            : base(message, description)
        {
            data = new IType[5];
            data[0] = new ST(message, "ID");
            data[1] = new ST(message, "Family name");
            data[2] = new ST(message, "Given name");
            data[3] = new ST(message, "Middle initial or name");
            data[4] = new ST(message, "Degree");
        }

        /// <summary>
        /// Gets an array containing the data elements.
        /// </summary>
        public IType[] Components => data;

        /// <summary>
        /// Gets the ID (component #0). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST ID
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
        /// Gets the family name (component #1). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST FamilyName
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
        /// Gets the given name (component #2). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST GivenName
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
        /// Gets the middle initial or name (component #3). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST MiddleInitialOrName
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
        /// Gets the degree (component #4). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST Degree
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
                    throw new DataTypeException($"Element {index} doesn't exist in 5 element CN composite");
                }
            }
        }
    }
}