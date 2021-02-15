namespace NHapi.Model.V21.Datatype
{
    using NHapi.Base.Model;

    /// <summary>
    /// The HL7 ID data type.
    /// </summary>
    public class ID : Base.Model.Primitive.ID
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ID"/> class.
        /// </summary>
        /// <param name="theMessage">The message to which this Type belongs.</param>
        public ID(IMessage theMessage)
            : base(theMessage)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ID"/> class.
        /// </summary>
        /// <param name="theMessage">The message to which this Type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public ID(IMessage theMessage, string description)
            : base(theMessage, description)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ID"/> class.
        /// </summary>
        /// <param name="theMessage">The message to which this Type belongs.</param>
        /// <param name="theTable">The table which this type belongs.</param>
        public ID(IMessage theMessage, int theTable)
            : base(theMessage, theTable)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ID"/> class.
        /// </summary>
        /// <param name="theMessage">The message to which this Type belongs.</param>
        /// <param name="theTable">The table which this type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public ID(IMessage theMessage, int theTable, string description)
            : base(theMessage, theTable, description)
        {
        }

        /// <summary>
        /// Gets the version.
        /// </summary>
        public virtual string Version => Constants.VERSION;
    }
}
