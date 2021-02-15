namespace NHapi.Model.V21.Datatype
{
    using System;

    using NHapi.Base;
    using NHapi.Base.Log;
    using NHapi.Base.Model;

    /// <summary>
    /// <p>The HL7 CQ (composite quantity with units) data type.  Consists of the following components: </p><ol>
    /// <li>country (ST)</li>
    /// <li>quantity (NM)</li>
    /// </ol>
    /// </summary>
    [Serializable]
    public class CQ : AbstractType, IComposite
    {
        private readonly IType[] data;

        /// <summary>
        /// Initializes a new instance of the <see cref="CQ"/> class.
        /// </summary>
        /// <param name="message">The Message to which this Type belongs.</param>
        public CQ(IMessage message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CQ"/> class.
        /// </summary>
        /// <param name="message">The Message to which this Type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public CQ(IMessage message, string description)
            : base(message, description)
        {
            data = new IType[2];
            data[0] = new ST(message, "Country");
            data[1] = new NM(message, "Quantity");
        }

        /// <summary>
        /// Gets an array containing the data elements.
        /// </summary>
        public IType[] Components => data;

        /// <summary>
        /// Gets the country (component #0). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public ST Country
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
        /// Gets the quantity (component #1). This is a convenience method that saves you from
        /// casting and handling an exception.
        /// </summary>
        public NM Quantity
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
                    throw new DataTypeException($"Element {index} doesn't exist in 2 element CQ composite");
                }
            }
        }
    }
}