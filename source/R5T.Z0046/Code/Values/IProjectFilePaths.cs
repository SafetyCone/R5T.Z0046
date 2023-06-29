using System;

using R5T.T0131;
using R5T.T0172;
using R5T.T0172.Extensions;


namespace R5T.Z0046
{
    [ValuesMarker]
    public partial interface IProjectFilePaths : IValuesMarker
    {
        /// <summary>
        /// <para>C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0060\source\R5T.S0060.S001\R5T.S0060.S001.csproj</para>
        /// Contains a Program class, with Main() method, with a single statement calling into the R5T.F0000 library.
        /// This is perfect for determining how to iterate over all statements in all types of a target project, and then accumulate the project locations of referenced types.
        /// </summary>
        public IProjectFilePath Example_SimpleWithProjectReference => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0060\source\R5T.S0060.S001\R5T.S0060.S001.csproj".ToProjectFilePath();

        /// <summary>
        /// <para>C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0060\source\R5T.S0060.S002\R5T.S0060.S002.csproj</para>
        /// Contains a Program class, with Main() method, with two statements:
        ///     1. A simple statement calling into R5T.F0000 functionality.
        ///     2. A statement calling into the CliWrap NuGet package.
        /// </summary>
        public IProjectFilePath Example_SimpleWithNuGetPackageReference => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0060\source\R5T.S0060.S002\R5T.S0060.S002.csproj".ToProjectFilePath();

        /// <summary>
        /// <para>C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0060\source\R5T.S0060.S003\R5T.S0060.S003.csproj</para>
        /// Contains a Program class, with Main() method, with several statements.
        /// But, most importantly, contains a project reference to a NuGet package selector project.
        /// </summary>
        public IProjectFilePath Example_SimpleWithNuGetPackageProviderProjectReference => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.S0060\source\R5T.S0060.S003\R5T.S0060.S003.csproj".ToProjectFilePath();
    }
}
