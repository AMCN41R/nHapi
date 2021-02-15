namespace NHapi.Model.V21.Datatype
{
    using NHapi.Base.Model;

    /// <summary>
    /// The HL7 TM data type.
    /// </summary>
    public class TM : Base.Model.Primitive.TM
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TM"/> class.
        /// </summary>
        /// <param name="theMessage">The message to which this type belongs.</param>
        public TM(IMessage theMessage)
              : base(theMessage)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TM"/> class.
        /// </summary>
        /// <param name="theMessage">The message to which this type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public TM(IMessage theMessage, string description)
              : base(theMessage, description)
        {
        }

        /// <summary>
        /// Gets the version.
        /// </summary>
        public virtual string Version => Constants.VERSION;
    }
}
