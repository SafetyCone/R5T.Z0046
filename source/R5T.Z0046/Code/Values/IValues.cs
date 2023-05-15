using System;

using R5T.T0131;
using R5T.T0161;
using R5T.T0161.Extensions;
using R5T.T0187;
using R5T.T0187.Extensions;
using R5T.T0196;
using R5T.T0196.Extensions;


namespace R5T.Z0046
{
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        public INamespaceName Sample_NamespaceName => "Sample.NamespaceName".ToNamespaceName();
        public IProjectDescription Sample_ProjectDescription => "Sample project description.".ToProjectDescription();
        public IProjectName Sample_ProjectName => "Sample.Project".ToProjectName();
        public IWindowsFormName Sample_WindowsFormName => "SampleWinForm".ToWindowsFormName();
    }
}
