﻿#region Using directives

using System.Reflection;
using System.Runtime.CompilerServices;
using System;

#endregion

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Microsoft.Practices.RecipeFramework.VisualStudio")]
[assembly: AssemblyDescription("Microsoft.Practices.RecipeFramework.VisualStudio")]
[assembly: InternalsVisibleTo("Microsoft.Practices.RecipeFramework.VisualStudio.Test, PublicKey=002400000480000094000000060200000024000052534131000400000100010063956249a476a4c68606114d55c6ec09263c7b74474cb79cabfe85024fc38ca88dbcd6e9bf2755998aa7913f75f216399cb8389c95bb9ad38c406d2bee5b9f21441be00b4bc015907ee9503175c4cc6b25f1c809ca58d5330dbcd4365bfe218199896d75241846fc8ecd623361158c5e7cb2d8cf6692246994b6005523dd3dad")]
[assembly: InternalsVisibleTo("Microsoft.Practices.RecipeFramework.Library, PublicKey=002400000480000094000000060200000024000052534131000400000100010063956249a476a4c68606114d55c6ec09263c7b74474cb79cabfe85024fc38ca88dbcd6e9bf2755998aa7913f75f216399cb8389c95bb9ad38c406d2bee5b9f21441be00b4bc015907ee9503175c4cc6b25f1c809ca58d5330dbcd4365bfe218199896d75241846fc8ecd623361158c5e7cb2d8cf6692246994b6005523dd3dad")]
[assembly: CLSCompliant(false)]

/// <summary>
/// Provides easy access to assembly-level attributes.
/// </summary>
internal sealed class ThisAssembly
{
    public const string Title = "RecipeFramework.VisualStudio";
    public const string Product = "Microsoft® Guidance Automation Runtime";
    public const string Description = "Guidance Automation Visual Studio Integration";
}