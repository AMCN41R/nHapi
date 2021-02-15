namespace NHapi.Model.V21.Datatype
{
    using NHapi.Base.Model;

    /// <summary>
    /// The HL7 DT data type.
    /// </summary>
    public class DT : Base.Model.Primitive.DT
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DT"/> class.
        /// </summary>
        /// <param name="theMessage">The message to which this type belongs.</param>
        public DT(IMessage theMessage)
            : base(theMessage)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DT"/> class.
        /// </summary>
        /// <param name="theMessage">The message to which this type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public DT(IMessage theMessage, string description)
            : base(theMessage, description)
        {
        }

        /// <summary>
        /// Gets the version.
        /// </summary>
        public virtual string Version => Constants.VERSION;
    }
}
