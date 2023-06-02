using System;

using R5T.T0131;
using R5T.T0172;
using R5T.T0172.Extensions;


namespace R5T.Z0046
{
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
        /// <summary>
        /// C:\Temp\Projects\Sample.Project\
        /// </summary>
        public IProjectDirectoryPath Sample_ProjectDirectoryPath => @"C:\Temp\Projects\Sample.Project\".ToProjectDirectoryPath();

        /// <summary>
        /// C:\Temp\Solutions\Sample.Solution\
        /// </summary>
        public ISolutionDirectoryPath Sample_SolutionDirectoryPath => @"C:\Temp\Solutions\Sample.Solution\".ToSolutionDirectoryPath();
    }
}
