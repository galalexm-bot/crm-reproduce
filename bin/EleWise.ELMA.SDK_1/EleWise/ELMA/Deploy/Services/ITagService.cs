// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.ITagService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Интерфейс сервиса работы с ограничениями bpmApp</summary>
  public interface ITagService
  {
    /// <summary>Получить список доступных ограничений языка</summary>
    List<string> TagLanguage { get; }

    /// <summary>Получить список доступных ограничений бд</summary>
    List<string> TagDataBase { get; }

    /// <summary>Получить список доступных ограничений редакций</summary>
    List<string> TagEdition { get; }

    /// <summary>
    /// Проверить совместимость ограничений манифеста с текущей версией сервера
    /// </summary>
    bool ValidateTags(ElmaStoreComponentManifest manifest);

    /// <summary>
    /// Проверить совместимость ограничений манифеста с текущей версией сервера
    /// </summary>
    bool ValidateTags(ElmaStoreComponentManifest manifest, out List<TestImportMessages> messages);
  }
}
