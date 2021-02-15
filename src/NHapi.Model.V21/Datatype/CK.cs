namespace NHapi.Model.V21.Datatype
{
    using System;

    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;

    /// <summary>
    /// The HL7 CK (composite ID with check digit) data type.  Consists of the following components...
    /// <ol>
    /// <li>ID Number (NM)</li>
    /// <li>Check Digit (NM)</li>
    /// <li>code identifying check digit scheme employed (ID)</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class CK : AbstractType, IComposite
    {
        private readonly IType[] data;

        /// <summary>
        /// Initializes a new instance of the <see cref="CK"/> class.
        /// </summary>
        /// <param name="message">The Message to which this Type belongs.</param>
        public CK(IMessage message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CK"/> class.
        /// </summary>
        /// <param name="message">The Message to which this Type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public CK(IMessage message, string description)
            : base(message, description)
        {
            data = new IType[3];
            data[0] = new NM(message, "ID Number");
            data[1] = new NM(message, "Check Digit");
            data[2] = new ID(message, 0, "Code identifying check digit scheme employed");
        }

        /// <summary>
        /// Gets an array containing the data elements.
        /// </summary>
        public IType[] Components => data;

        /// <summary>
        /// Gets the ID Number (component #0). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public NM IDNumber
        {
            get
            {
                try
                {
                    return (NM)this[0];
                }
                catch (DataTypeException e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the Check Digit (component #1). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public NM CheckDigit
        {
            get
            {
                try
                {
                    return (NM)this[1];
                }
                catch (DataTypeException e)
                {
                    HapiLogFactory.GetHapiLog(GetType()).Error("Unexpected problem accessing known data type component - this is a bug.", e);
                    throw new Exception("An unexpected error occurred", e);
                }
            }
        }

        /// <summary>
        /// Gets the code identifying check digit scheme employed (component #2). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ID CodeIdentifyingCheckDigitSchemeEmployed
        {
            get
            {
                try
                {
                    return (ID)this[2];
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
                    throw new DataTypeException($"Element {index} doesn't exist in 3 element CK composite");
                }
            }
        }
    }
}