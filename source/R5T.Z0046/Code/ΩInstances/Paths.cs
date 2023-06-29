using System;


namespace R5T.Z0046
{
    public class Paths : IPaths
    {
        #region Infrastructure

        public static IPaths Instance { get; } = new Paths();


        private Paths()
        {
        }

        #endregion
    }
}
