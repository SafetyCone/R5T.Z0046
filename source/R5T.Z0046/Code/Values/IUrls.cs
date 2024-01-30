using System;

using R5T.T0131;
using R5T.T0198;
using R5T.T0198.Extensions;


namespace R5T.Z0046
{
    /// <summary>
    /// OBSOLETE - See R5T.Z0066.
    /// </summary>
    [ValuesMarker]
    public partial interface IUrls : IValuesMarker
    {
        public IRepositoryUrl Example_GitHubRepositoryUrl => @"https://github.com/SafetyCone/R5T.Z0046.git".ToRepositoryUrl();
    }
}
