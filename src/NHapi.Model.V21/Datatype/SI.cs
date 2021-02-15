namespace NHapi.Model.V21.Datatype
{
    using System;

    using NHapi.Base.Model;

    /// <summary>
    /// Represents the HL7 SI (SET ID) datatype. A SI contains a single String value.
    /// </summary>
    [Serializable]
    public class SI : AbstractPrimitive
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SI"/> class.
        /// </summary>
        /// <param name="message">The Message to which this Type belongs.</param>
        public SI(IMessage message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SI"/> class.
        /// </summary>
        /// <param name="message">The Message to which this Type belongs.</param>
        /// <param name="description">The description of this type.</param>
        public SI(IMessage message, string description)
            : base(message, description)
        {
        }

        /// <summary>
        /// Gets the version.
        /// </summary>
        public string Version => Constants.VERSION;

        /// <summary>
        /// Returns the version.
        /// </summary>
        /// <returns>The version.</returns>
        [Obsolete("This method has been replaced by the property 'Version'.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "StyleCop.CSharp.NamingRules",
            "SA1300:Element should begin with upper-case letter",
            Justification = "As this is a public member, we will duplicate the method and mark this one as obsolete.")]
        public string getVersion()
        {
            return Version;
        }
    }
}