using System;

using R5T.T0180;
using R5T.T0180.Extensions;
using R5T.T0200;
using R5T.T0200.Extensions;


/// Examples are for input!


namespace R5T.Z0046
{
    public partial interface IDirectoryPaths
    {
        /// <summary>
        /// C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0046\
        /// </summary>
        public IRepositoryDirectoryPath Example_RepositoryDirectoryPath => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0046\".ToRepositoryDirectoryPath();

        /// <summary>
        /// C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0046\source\R5T.Z0046\Code\Values\
        /// </summary>
        /// <remarks>
        /// Useful for:
        /// * Testing getting the repository root directory path for a directory within the repository.
        /// </remarks>
        public IDirectoryPath Example_DirectoryWithinRepositoryDirectoryPath => @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.Z0046\source\R5T.Z0046\Code\Values\".ToDirectoryPath();
    }
}
