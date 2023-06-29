using System;

using R5T.T0172;
using R5T.T0172.Extensions;
using R5T.T0180;
using R5T.T0180.Extensions;

/// Samples are for output!


namespace R5T.Z0046
{
    public partial interface IDirectoryPaths
    {
        /// <summary>
        /// C:\Temp\Projects\
        /// </summary>
        public IDirectoryPath Sample_ProjectsDirectoryPath => @"C:\Temp\Projects\".ToDirectoryPath();

        /// <summary>
        /// C:\Temp\Projects\Sample.Project\
        /// </summary>
        public IProjectDirectoryPath Sample_ProjectDirectoryPath => @"C:\Temp\Projects\Sample.Project\".ToProjectDirectoryPath();

        /// <summary>
        /// C:\Temp\Solutions\
        /// </summary>
        public IDirectoryPath Sample_SolutionsDirectoryPath => @"C:\Temp\Solutions\".ToDirectoryPath();

        /// <summary>
        /// C:\Temp\Solutions\Sample.Solution\
        /// </summary>
        public ISolutionDirectoryPath Sample_SolutionDirectoryPath => @"C:\Temp\Solutions\Sample.Solution\".ToSolutionDirectoryPath();
    }
}
