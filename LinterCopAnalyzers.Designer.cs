﻿using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace BusinessCentral.LinterCop
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class LinterCopAnalyzers
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal LinterCopAnalyzers()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (LinterCopAnalyzers.resourceMan == null)
          LinterCopAnalyzers.resourceMan = new ResourceManager("BusinessCentral.LinterCop.LinterCopAnalyzers", typeof (LinterCopAnalyzers).Assembly);
        return LinterCopAnalyzers.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => LinterCopAnalyzers.resourceCulture;
      set => LinterCopAnalyzers.resourceCulture = value;
    }

    internal static string AnalyzerPrefix => LinterCopAnalyzers.ResourceManager.GetString(nameof (AnalyzerPrefix), LinterCopAnalyzers.resourceCulture);
    internal static string Rule0470PlaceholderShouldHaveCommentExplainingContentTitle => LinterCopAnalyzers.ResourceManager.GetString(nameof (Rule0470PlaceholderShouldHaveCommentExplainingContentTitle), LinterCopAnalyzers.resourceCulture);
  }
}
