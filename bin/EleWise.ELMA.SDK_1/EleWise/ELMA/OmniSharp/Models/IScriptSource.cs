// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.Models.IScriptSource
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.OmniSharp.Models
{
  /// <summary>Данные скрипта</summary>
  public interface IScriptSource
  {
    /// <summary>Имя файла</summary>
    string Name { get; }

    /// <summary>Содержимое файла</summary>
    string Content { get; }

    /// <summary>Тип исходника</summary>
    ScriptSourceType Type { get; }
  }
}
