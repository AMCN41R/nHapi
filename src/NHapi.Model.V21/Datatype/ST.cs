namespace NHapi.Model.V21.Datatype
{
    using NHapi.Base.Model;

    /// <summary>
    /// The HL7 ST data type.
    /// </summary>
    public class ST : AbstractPrimitive
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ST"/> class.
        /// </summary>
        /// <param name="theMessage">The message to which this type belongs.</param>
        public ST(IMessage theMessage)
            : base(theMessage)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ST"/> class.
        /// </summary>
        /// <param name="message">The message to which this Type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public ST(IMessage message, string description)
            : base(message, description)
        {
        }

        /// <summary>
        /// Gets the version.
        /// </summary>
        public virtual string Version => Constants.VERSION;
    }
}
