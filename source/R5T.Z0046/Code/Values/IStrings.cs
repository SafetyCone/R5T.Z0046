using System;

using R5T.T0131;


namespace R5T.Z0046
{
    [ValuesMarker]
    public partial interface IStrings : IValuesMarker,
        Z0000.IStrings
    {
#pragma warning disable IDE1006 // Naming Styles
        public Platform.Examples.IStrings _Platform => Platform.Examples.Strings.Instance;
#pragma warning restore IDE1006 // Naming Styles
    }
}
