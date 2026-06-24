// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.OmniSharp.Models.IScriptReference
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.OmniSharp.Models
{
  /// <summary>Ссылка на сборку для генерации исходников</summary>
  public interface IScriptReference
  {
    /// <summary>Имя сборки</summary>
    string Name { get; }

    /// <summary>
    /// Относительный путь до сборки (если это не глобальная сборка)
    /// </summary>
    string HintPath { get; }

    /// <summary>Raw сборки</summary>
    byte[] AssemblyRaw { get; }

    /// <summary>Raw файла XML-документации</summary>
    byte[] DocumentationRaw { get; }
  }
}
