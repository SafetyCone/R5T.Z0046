using System;

using R5T.T0131;
using R5T.T0172;
using R5T.T0172.Extensions;
using R5T.T0180;
using R5T.T0180.Extensions;
using R5T.T0181;
using R5T.T0181.Extensions;


namespace R5T.Z0046
{
    [ValuesMarker]
    public partial interface IFilePaths : IValuesMarker
    {
        /// <summary>
        /// C:\Temp\Sample.css
        /// </summary>
        public ICssFilePath Sample_CssFilePath => @"C:\Temp\Sample.css".ToCssFilePath();

        /// <summary>
        /// Example project file path for use as a reference. (input)
        /// <para>C:\Temp\Projects\Example\Example.csproj</para>
        /// </summary>
        public IProjectFilePath Example_ProjectFilePath => @"C:\Temp\Projects\Example\Example.csproj".ToProjectFilePath();

        /// <summary>
        /// C:\Temp\Sample.cs
        /// </summary>
        public ICSharpFilePath Sample_CSharpFilePath => @"C:\Temp\Sample.cs".ToCSharpFilePath();

        /// <summary>
        /// C:\Temp\Sample.html
        /// </summary>
        public IHtmlFilePath Sample_HtmlFilePath => @"C:\Temp\Sample.html".ToHtmlFilePath();

        /// <summary>
        /// C:\Temp\Sample.js
        /// </summary>
        public IJsFilePath Sample_JsFilePath => @"C:\Temp\Sample.js".ToJsFilePath();

        /// <summary>
        /// C:\Temp\Sample.json
        /// </summary>
        public IJsonFilePath Sample_JsonFilePath => @"C:\Temp\Sample.json".ToJsonFilePath();

        /// <summary>
        /// C:\Temp\Sample.md
        /// </summary>
        public IMarkdownFilePath Sample_MarkdownFilePath => @"C:\Temp\Sample.md".ToMarkdownFilePath();

        /// <summary>
        /// Sample project file path for generating project files. (output)
        /// <para>C:\Temp\Sample.csproj</para>
        /// </summary>
        public IProjectFilePath Sample_ProjectFilePath => @"C:\Temp\Sample.csproj".ToProjectFilePath();

        /// <summary>
        /// C:\Temp\Sample.razor
        /// </summary>
        public IRazorFilePath Sample_RazorFilePath => @"C:\Temp\Sample.razor".ToRazorFilePath();
    }
}
