namespace NHapi.Model.V21.Datatype
{
    using NHapi.Base.Model;

    /// <summary>
    /// The HL7 IS data type.
    /// </summary>
    public class IS : Base.Model.Primitive.IS
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IS"/> class.
        /// </summary>
        /// <param name="theMessage">The message to which this Type belongs.</param>
        public IS(IMessage theMessage)
            : base(theMessage)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IS"/> class.
        /// </summary>
        /// <param name="theMessage">The message to which this Type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public IS(IMessage theMessage, string description)
            : base(theMessage, description)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IS"/> class.
        /// </summary>
        /// <param name="theMessage">The message to which this Type belongs.</param>
        /// <param name="theTable">The table which this type belongs.</param>
        public IS(IMessage theMessage, int theTable)
              : base(theMessage, theTable)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IS"/> class.
        /// </summary>
        /// <param name="message">The message to which this Type belongs.</param>
        /// <param name="theTable">The table which this type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public IS(IMessage message, int theTable, string description)
              : base(message, theTable, description)
        {
        }

        /// <summary>
        /// Gets the version.
        /// </summary>
        public virtual string Version => Constants.VERSION;
    }
}
