// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.DiagnosticSeverity
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Describes how severe a diagnostic is.</summary>
  public enum DiagnosticSeverity
  {
    /// <summary>
    /// Something that is an issue, as determined by some authority, but is not surfaced through normal means. There may be different mechanisms that act on these issues.
    /// </summary>
    Hidden,
    /// <summary>
    /// Information that does not indicate a problem (i.e. not prescriptive).
    /// </summary>
    Info,
    /// <summary>Something suspicious but allowed.</summary>
    Warning,
    /// <summary>
    /// Something not allowed by the rules of the language or other authority.
    /// </summary>
    Error,
  }
}
