/*
  The contents of this file are subject to the Mozilla Public License Version 1.1
  (the "License"); you may not use this file except in compliance with the License.
  You may obtain a copy of the License at http://www.mozilla.org/MPL/
  Software distributed under the License is distributed on an "AS IS" basis,
  WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License for the
  specific language governing rights and limitations under the License.

  The Original Code is "RuleBinding.java".  Description:
  "An association between a type of item to be validated (eg a datatype or message) and a validation Rule."

  The Initial Developer of the Original Code is University Health Network. Copyright (C)
  2004.  All Rights Reserved.

  Contributor(s): ______________________________________.

  Alternatively, the contents of this file may be used under the terms of the
  GNU General Public License (the "GPL"), in which case the provisions of the GPL are
  applicable instead of those above.  If you wish to allow use of your version of this
  file only under the terms of the GPL and not to allow others to use your version
  of this file under the MPL, indicate your decision by deleting  the provisions above
  and replace  them with the notice and other provisions required by the GPL License.
  If you do not delete the provisions above, a recipient may use your version of
  this file under either the MPL or the GPL.
*/

namespace NHapi.Base.Validation.Implementation
{
    using System;

    /// <summary>
    /// An association between a type of item to be validated (eg a datatype or
    /// message) and a validation <see cref="IRule"/>.
    /// </summary>
    /// <author><a href="mailto:bryan.tripp@uhn.on.ca">Bryan Tripp</a></author>
    /// <version>
    /// $Revision: 1.3 $ updated on $Date: 2005/06/14 20:16:01 $ by $Author: bryan_tripp $.
    /// </version>
    public class RuleBinding
    {
        /// <summary> Active by default.
        ///
        /// </summary>
        /// <param name="theVersion">see {@link #getVersion()}.
        /// </param>
        /// <param name="theScope">see {@link #getScope()}.
        /// </param>
        /// <param name="theRule">see {@link #getRule()}.
        /// </param>
        public RuleBinding(string theVersion, string theScope, IRule theRule)
        {
            Active = true;
            Version = theVersion;
            Scope = theScope;
            Rule = theRule;
        }

        /// <summary>
        /// Gets or sets a value indicating whether or not the binding is currently active.
        /// </summary>
        public virtual bool Active { get; set; }

        /// <summary>
        /// Gets the version to which the binding applies (* means all versions).
        /// </summary>
        public virtual string Version { get; }

        /// <summary>
        /// Gets the scope of item types to which the rule applies.
        /// </summary>
        /// <remarks>
        /// <para>
        /// For <see cref="IMessageRule"/> this is the message type and trigger event,
        /// separated by a ^ (either value may be *, meaning any).
        /// </para>
        /// <para>
        /// For <see cref="IPrimitiveTypeRule"/> this is the datatype name (* means any).
        /// </para>
        /// <para>
        /// For <see cref="IEncodingRule"/> this is the encoding name (again, * means any).
        /// </para>
        /// </remarks>
        public virtual string Scope { get; }

        /// <summary>
        /// Gets the rule that applies to the associated version and scope.
        /// </summary>
        public virtual IRule Rule { get; }

        [Obsolete("This method has been replaced by 'AppliesToVersion'.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "StyleCop.CSharp.NamingRules",
            "SA1300:Element should begin with upper-case letter",
            Justification = "As this is a public member, we will duplicate the method and mark this one as obsolete.")]
        public virtual bool appliesToVersion(string theVersion)
        {
            return AppliesToVersion(theVersion);
        }

        /// <param name="theVersion">an HL7 version.
        /// </param>
        /// <returns> true if this binding applies to the given version (ie getVersion() matches or is *).
        /// </returns>
        public virtual bool AppliesToVersion(string theVersion)
        {
            return Applies(Version, theVersion);
        }

        [Obsolete("This method has been replaced by 'AppliesToScope'.")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
            "StyleCop.CSharp.NamingRules",
            "SA1300:Element should begin with upper-case letter",
            Justification = "As this is a public member, we will duplicate the method and mark this one as obsolete.")]
        public virtual bool appliesToScope(string theType)
        {
            return AppliesToScope(theType);
        }

        /// <param name="theType">an item description to be checked against getScope().
        /// </param>
        /// <returns> true if the given type is within scope, ie if it matches getScope() or getScope() is *.
        /// </returns>
        public virtual bool AppliesToScope(string theType)
        {
            return Applies(Scope, theType);
        }

        /// <summary>
        /// An abstraction of appliesToVersion() and appliesToScope().
        /// </summary>
        /// <param name="theBindingData"></param>
        /// <param name="theItemData"></param>
        /// <returns></returns>
        protected internal virtual bool Applies(string theBindingData, string theItemData)
        {
            return theBindingData.Equals(theItemData) || theBindingData.Equals("*");
        }
    }
}