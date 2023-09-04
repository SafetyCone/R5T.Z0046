using System;


namespace R5T.Z0046
{
    public class Strings : IStrings
    {
        #region Infrastructure

        public static IStrings Instance { get; } = new Strings();


        private Strings()
        {
        }

        #endregion
    }
}
