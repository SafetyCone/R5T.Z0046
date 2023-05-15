using System;

using R5T.T0131;
using R5T.T0172;
using R5T.T0172.Extensions;


namespace R5T.Z0046
{
    [ValuesMarker]
    public partial interface IDirectoryPaths : IValuesMarker
    {
        public IProjectDirectoryPath Sample_ProjectDirectoryPath => @"C:\Temp\Projects\Sample.Project\".ToProjectDirectoryPath();
    }
}
