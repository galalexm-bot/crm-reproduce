// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.Previews.IFolderPreviewService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Files.Previews
{
  /// <summary>Работа с папкой предпросмотра файлов</summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IFolderPreviewService
  {
    /// <summary>Путь к корневой папке с предпросмотрами</summary>
    string PreviewsPath { get; }

    /// <summary>Собрать путь к папке с предпросмотром для документа</summary>
    /// <param name="id">Uid документа</param>
    string GetPreviewDirectory(Guid id);
  }
}
