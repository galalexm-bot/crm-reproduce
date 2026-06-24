// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.ExtensionPoints.IExportDataExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using System.Collections.Generic;
using System.Xml;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints
{
  /// <summary>Точка расширения для экспорта данных объекта системы</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IExportDataExtension
  {
    /// <summary>Проверить возможно ли использование расширения</summary>
    /// <param name="metadata">Метеданные объекта</param>
    bool CheckMetadata(IMetadata metadata);

    /// <summary>Выполнить экспорт объектов</summary>
    /// <param name="writer">Экземпляр потоковой записи xml-данных</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="messages">Сообщения</param>
    /// <param name="wasExported">Список уже экспортированных объектов</param>
    /// <param name="fileUids">Идентификаторы файлов используемых в экземплярах объектов</param>
    List<ClassMetadata> ExportObjects(
      XmlWriter writer,
      ClassMetadata metadata,
      List<DeployLogMessage> messages,
      List<ClassMetadata> wasExported,
      List<string> fileUids);
  }
}
