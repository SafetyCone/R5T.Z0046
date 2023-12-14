using System;

using R5T.T0172;
using R5T.T0172.Extensions;
using R5T.T0181;
using R5T.T0181.Extensions;


/// Samples are for output!


namespace R5T.Z0046
{
    public partial interface IFilePaths
    {
#pragma warning disable IDE1006 // Naming Styles
        public Platform.IFilePaths _Platform => Platform.FilePaths.Instance;
#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// C:\Temp\Sample.css
        /// </summary>
        public ICssFilePath Sample_CssFilePath => @"C:\Temp\Sample.css".ToCssFilePath();

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

        /// <inheritdoc cref="Platform.IFilePaths.Sample_ProjectFilePath"/>
        public IProjectFilePath Sample_ProjectFilePath => _Platform.Sample_ProjectFilePath.ToProjectFilePath();

        /// <summary>
        /// Sample project file path for outputing data to a project file unmodified. (output)
        /// <para>C:\Temp\Sample-Unmodified.csproj</para>
        /// </summary>
        public IProjectFilePath Sample_ProjectFilePath_Unmodified => @"C:\Temp\Sample-Unmodified.csproj".ToProjectFilePath();

        /// <summary>
        /// C:\Temp\Sample.razor
        /// </summary>
        public IRazorFilePath Sample_RazorFilePath => @"C:\Temp\Sample.razor".ToRazorFilePath();
    }
}
