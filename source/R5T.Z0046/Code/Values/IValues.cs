using System;

using R5T.F0000;
using R5T.L0032.T000;
using R5T.T0131;
using R5T.T0161;
using R5T.T0161.Extensions;
using R5T.T0184;
using R5T.T0184.Extensions;
using R5T.T0186;
using R5T.T0186.Extensions;
using R5T.T0187;
using R5T.T0187.Extensions;
using R5T.T0196;
using R5T.T0196.Extensions;
using R5T.T0197;
using R5T.T0197.Extensions;
using R5T.T0198;


namespace R5T.Z0046
{
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        public IsSet<IRepositoryUrl> NoRepositoryUrl => new IsSet<IRepositoryUrl>();

        public ILibraryDescription Sample_LibraryDescription => "Sample library description.".ToLibraryDescription();

        /// <summary>
        /// "Sample.Library"
        /// </summary>
        public ILibraryName Sample_LibraryName => "Sample.Library".ToLibraryName();

        public INamespaceName Sample_NamespaceName => "Sample.NamespaceName".ToNamespaceName();

        /// <summary>
        /// "Sample Page"
        /// <para>Useful for creating sample HTML web pages.</para>
        /// </summary>
        public string Sample_PageTitle => "Sample Page";

        /// <summary>
        /// <para><value>Sample project description.</value></para>
        /// </summary>
        public IProjectDescription Sample_ProjectDescription => "Sample project description.".ToProjectDescription();

        /// <summary>
        /// "Sample.Project"
        /// </summary>
        public IProjectName Sample_ProjectName => "Sample.Project".ToProjectName();

        public IRepositoryDescription Sample_RepositoryDescription => "Sample repository description".ToRepositoryDescription();

        /// <summary>
        /// "Sample.Repository"
        /// </summary>
        public T0184.IRepositoryName Sample_RepositoryName => T0184.Extensions.StringExtensions.ToRepositoryName("Sample.Repository");

        /// <summary>
        /// "Sample.GitHubRepository"
        /// </summary>
        public IGitHubRepositoryName Sample_GitHubRepositoryName => "Sample.GitHubRepository".ToGitHubRepositoryName();

        /// <summary>
        /// "Sample.Solution"
        /// </summary>
        public ISolutionName Sample_SolutionName => "Sample.Solution".ToSolutionName();

        public IWindowsFormName Sample_WindowsFormName => "SampleWinForm".ToWindowsFormName();
    }
}
