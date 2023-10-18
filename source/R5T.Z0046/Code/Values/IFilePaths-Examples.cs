using System;

using R5T.T0172;
using R5T.T0172.Extensions;
using R5T.T0180;
using R5T.T0180.Extensions;
using R5T.T0181;


/// Examples are for input!


namespace R5T.Z0046
{
    public partial interface IFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles
        private static L0057.IFilePaths _Foundation => L0057.FilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para>[the path of the currently executing executable file]</para>
        /// The file path for the currently executing executable file is a perfect example file path:
        /// <list type="number">
        /// <item>It is guaranteed to exist if code is running.</item>
        /// <item>It is almost always a complex path, with multiple diretory levesl.</item>
        /// <item>Its filename almost always has an extension.</item>
        /// </list>
        /// </summary>
        public IFilePath Example => _Foundation.Executable;

        /// <summary>
        /// An example DLL file path (that is guaranteed to exist).
        /// </summary>
        public IDllFilePath Example_Dll => _Foundation.Executable;

        /// <summary>
        /// An example assembly file path (that is guaranteed to exist).
        /// (This returns the path of the currently executing executable assembly.)
        /// </summary>
        public IAssemblyFilePath Example_Assembly => _Foundation.Executable;

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
        /// Example real, actually existing, project file path for use as a reference. (input)
        /// <para>C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0046\source\R5T.Z0046\R5T.Z0046.csproj</para>
        /// </summary>
        public IProjectFilePath Example_RealProjectFilePath => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0046\source\R5T.Z0046\R5T.Z0046.csproj".ToProjectFilePath();

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
