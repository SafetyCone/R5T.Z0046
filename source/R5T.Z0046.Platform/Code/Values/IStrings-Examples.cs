using System;

using R5T.T0131;


namespace R5T.Z0046.Platform.Examples
{
    [ValuesMarker]
    public partial interface IStrings : IValuesMarker
    {
        /// <summary>
        /// <para><inheritdoc cref="NumericDigits" path="/summary/descendant::value"/></para>
        /// The numeric digits 0 through 9 provide a perfect example string:
        /// <list type="number">
        /// <item>The first and last characters of the string are </item>
        /// </list>
        /// </summary>
        public string Example => this.NumericDigits;

        /// <summary>
        /// <para><value>"0123456789"</value></para>
        /// The numeric digits 0 through 9.
        /// </summary>
        public string NumericDigits => "0123456789";
    }
}
