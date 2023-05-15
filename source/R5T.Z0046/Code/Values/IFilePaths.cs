using System;

using R5T.T0131;
using R5T.T0172;
using R5T.T0172.Extensions;


namespace R5T.Z0046
{
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
        public ICodeFilePath Sample_CSharpFilePath => @"C:\Temp\Sample.cs".ToCodeFilePath();
        public IProjectFilePath Sample_ProjectFilePath => @"C:\Temp\Sample.csproj".ToProjectFilePath();
    }
}
