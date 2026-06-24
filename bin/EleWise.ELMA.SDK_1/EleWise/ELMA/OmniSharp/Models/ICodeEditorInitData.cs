// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.Models.ICodeEditorInitData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.OmniSharp.Models
{
  /// <summary>Данные для инициализации редактора кода</summary>
  public interface ICodeEditorInitData
  {
    /// <summary>Имя редактируемого файла</summary>
    string FileName { get; }

    /// <summary>Имя открываемого метода</summary>
    string MethodName { get; }

    /// <summary>Имя класса, где лежит открываемый метод</summary>
    string ClassName { get; }

    /// <summary>Исходный код</summary>
    string SourceCode { get; }

    /// <summary>Имя проекта</summary>
    string ProjectName { get; }
  }
}
