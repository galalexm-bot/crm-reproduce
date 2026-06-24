// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CodeAnalyzers.IAnalyzerWithResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.CodeAnalyzers.Model;

namespace EleWise.ELMA.CodeAnalyzers
{
  /// <summary>Интерфейс анализатора, возвращающего результат</summary>
  public interface IAnalyzerWithResult
  {
    /// <summary>Результат анализа</summary>
    ICodeAnalyzerResult CodeAnalyzerResult { get; }
  }
}
