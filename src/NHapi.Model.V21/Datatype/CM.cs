namespace NHapi.Model.V21.Datatype
{
    using NHapi.Base.Model;

    /// <summary>
    /// Composite message.
    /// </summary>
    public class CM : GenericComposite
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CM"/> class.
        /// </summary>
        /// <param name="theMessage">The message to which this type belongs.</param>
        public CM(IMessage theMessage)
            : base(theMessage)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CM"/> class.
        /// </summary>
        /// <param name="theMessage">The message to which this type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public CM(IMessage theMessage, string description)
            : base(theMessage, description)
        {
        }
    }
}
