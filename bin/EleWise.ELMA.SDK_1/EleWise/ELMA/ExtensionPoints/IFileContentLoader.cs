// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IFileContentLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System.Collections.Generic;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Загрузка содержимого файла</summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface IFileContentLoader
  {
    /// <summary>Расширения файлов</summary>
    List<string> Extensions { get; }

    /// <summary>Нужно ли чистить HTML после получения из файла</summary>
    bool NeedHtmlClear { get; }

    /// <summary>Получение текстового содержимого файла</summary>
    /// <param name="fileName">Имя файла</param>
    /// <returns>Текстовое содержимое файла</returns>
    string GetText(string fileName);
  }
}
