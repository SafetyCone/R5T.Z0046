using System;


namespace R5T.Z0046
{
    public class Urls : IUrls
    {
        #region Infrastructure

        public static IUrls Instance { get; } = new Urls();


        private Urls()
        {
        }

        #endregion
    }
}
