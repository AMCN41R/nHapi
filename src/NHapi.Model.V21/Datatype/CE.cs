namespace NHapi.Model.V21.Datatype
{
    using System;

    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;

    /// <summary>
    /// The HL7 CE (coded element) data type.  Consists of the following components...
    /// <ol>
    /// <li>identifier (ID)</li>
    /// <li>text (ST)</li>
    /// <li>name of coding system (ST)</li>
    /// <li>alternate identifier (ST)</li>
    /// <li>alternate text (ST)</li>
    /// <li>name of alternate coding system (ST)</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class CE : AbstractType, IComposite
    {
        private readonly IType[] data;

        /// <summary>
        /// Initializes a new instance of the <see cref="CE"/> class.
        /// </summary>
        /// <param name="message">The Message to which this Type belongs.</param>
        public CE(IMessage message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CE"/> class.
        /// </summary>
        /// <param name="message">The Message to which this Type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public CE(IMessage message, string description)
            : base(message, description)
        {
            data = new IType[6];
            data[0] = new ID(message, 0, "Identifier");
            data[1] = new ST(message, "Text");
            data[2] = new ST(message, "Name of coding system");
            data[3] = new ST(message, "Alternate identifier");
            data[4] = new ST(message, "Alternate text");
            data[5] = new ST(message, "Name of alternate coding system");
        }

        /// <summary>
        /// Gets an array containing the data elements.
        /// </summary>
        public IType[] Components => data;

        /// <summary>
        /// Gets the identifier (component #0). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ID Identifier
        {
            get
            {
                try
                {
                    return (ID)this[0];
                }
                catch (DataTypeException e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the text (component #1). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST Text
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
        /// Gets the name of coding system (component #2). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST NameOfCodingSystem
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
        /// Gets the alternate identifier (component #3). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST AlternateIdentifier
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
        /// Gets the alternate text (component #4). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST AlternateText
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
        /// Gets the name of alternate coding system (component #5).  This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST NameOfAlternateCodingSystem
        {
            get
            {
                try
                {
                    return (ST)this[5];
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
                    throw new DataTypeException($"Element {index} doesn't exist in 6 element CE composite");
                }
            }
        }
    }
}