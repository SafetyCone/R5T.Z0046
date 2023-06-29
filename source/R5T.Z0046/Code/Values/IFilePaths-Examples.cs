using System;

using R5T.T0172;
using R5T.T0172.Extensions;
using R5T.T0180;
using R5T.T0180.Extensions;


/// Examples are for input!


namespace R5T.Z0046
{
    public partial interface IFilePaths
    {
        /// <summary>
        /// C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0046\source\R5T.Z0046\Code\Values\IFilePaths.cs
        /// </summary>
        /// <remarks>
        /// Useful for:
        /// * Testing getting the repository root directory path for a directory within the repository.
        /// </remarks>
        public IFilePath Example_FileWithinRepositoryDirectoryPath => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0046\source\R5T.Z0046\Code\Values\IFilePaths.cs".ToFilePath();

        /// <summary>
        /// Example project file path for use as a reference. (input)
        /// <para>C:\Temp\Projects\Example\Example.csproj</para>
        /// </summary>
        public IProjectFilePath Example_ProjectFilePath => @"C:\Temp\Projects\Example\Example.csproj".ToProjectFilePath();

        /// <summary>
        /// Example project file path for use as a reference. (input)
        /// <para>C:\Code\DEV\Git\GitHub\SafetyCone\R5T.E0001.Private\source\R5T.E0001\R5T.E0001.csproj</para>
        /// </summary>
        public IProjectFilePath Example_ProjectFilePath_InPrivateRepository => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.E0001.Private\source\R5T.E0001\R5T.E0001.csproj".ToProjectFilePath();

        /// <summary>
        /// Example project file path for use as a reference. (input)
        /// <para>C:\Code\DEV\Git\GitHub\SafetyCone\R5T.E0001.Private\source\R5T.E0001\R5T.E0001.csproj</para>
        /// </summary>
        public IProjectFilePath Example_ProjectFilePath_InPublicRepository => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.E0001.Private\source\R5T.E0001\R5T.E0001.csproj".ToProjectFilePath();
    }
}
