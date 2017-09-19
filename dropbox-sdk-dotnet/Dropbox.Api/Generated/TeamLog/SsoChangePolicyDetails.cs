// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>Change the single sign-on policy for the team.</para>
    /// </summary>
    public class SsoChangePolicyDetails
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SsoChangePolicyDetails> Encoder = new SsoChangePolicyDetailsEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SsoChangePolicyDetails> Decoder = new SsoChangePolicyDetailsDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SsoChangePolicyDetails" />
        /// class.</para>
        /// </summary>
        /// <param name="newValue">New single sign-on policy.</param>
        /// <param name="previousValue">Previous single sign-on policy. Might be missing due to
        /// historical data gap.</param>
        public SsoChangePolicyDetails(global::Dropbox.Api.TeamPolicies.SsoPolicy newValue,
                                      global::Dropbox.Api.TeamPolicies.SsoPolicy previousValue = null)
        {
            if (newValue == null)
            {
                throw new sys.ArgumentNullException("newValue");
            }

            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SsoChangePolicyDetails" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        [sys.ComponentModel.EditorBrowsable(sys.ComponentModel.EditorBrowsableState.Never)]
        public SsoChangePolicyDetails()
        {
        }

        /// <summary>
        /// <para>New single sign-on policy.</para>
        /// </summary>
        public global::Dropbox.Api.TeamPolicies.SsoPolicy NewValue { get; protected set; }

        /// <summary>
        /// <para>Previous single sign-on policy. Might be missing due to historical data
        /// gap.</para>
        /// </summary>
        public global::Dropbox.Api.TeamPolicies.SsoPolicy PreviousValue { get; protected set; }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SsoChangePolicyDetails" />.</para>
        /// </summary>
        private class SsoChangePolicyDetailsEncoder : enc.StructEncoder<SsoChangePolicyDetails>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SsoChangePolicyDetails value, enc.IJsonWriter writer)
            {
                WriteProperty("new_value", value.NewValue, writer, global::Dropbox.Api.TeamPolicies.SsoPolicy.Encoder);
                if (value.PreviousValue != null)
                {
                    WriteProperty("previous_value", value.PreviousValue, writer, global::Dropbox.Api.TeamPolicies.SsoPolicy.Encoder);
                }
            }
        }

        #endregion


        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SsoChangePolicyDetails" />.</para>
        /// </summary>
        private class SsoChangePolicyDetailsDecoder : enc.StructDecoder<SsoChangePolicyDetails>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="SsoChangePolicyDetails"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SsoChangePolicyDetails Create()
            {
                return new SsoChangePolicyDetails();
            }

            /// <summary>
            /// <para>Set given field.</para>
            /// </summary>
            /// <param name="value">The field value.</param>
            /// <param name="fieldName">The field name.</param>
            /// <param name="reader">The json reader.</param>
            protected override void SetField(SsoChangePolicyDetails value, string fieldName, enc.IJsonReader reader)
            {
                switch (fieldName)
                {
                    case "new_value":
                        value.NewValue = global::Dropbox.Api.TeamPolicies.SsoPolicy.Decoder.Decode(reader);
                        break;
                    case "previous_value":
                        value.PreviousValue = global::Dropbox.Api.TeamPolicies.SsoPolicy.Decoder.Decode(reader);
                        break;
                    default:
                        reader.Skip();
                        break;
                }
            }
        }

        #endregion
    }
}
