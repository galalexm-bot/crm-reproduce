// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.IEntityImportSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.Model.Entities;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// 
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IEntityImportSaveActions
  {
    /// <summary>Поддерживается ли тип сущности</summary>
    bool IsSupported(Guid typeGuid);

    /// <summary>Может быть сохранена</summary>
    /// <param name="propValues"></param>
    /// <param name="data"></param>
    /// <returns></returns>
    bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data);

    /// <summary>
    /// Выполняет дополнительные действия перед сохранением сущности определенного типа
    /// </summary>
    /// <param name="entity">Экземпляр сущности</param>
    /// <param name="data">Дополнительные служебные данные</param>
    /// <returns></returns>
    List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data);

    /// <summary>
    /// Выполняет дополнительные действия после сохранения сущности определенного типа
    /// </summary>
    /// <param name="entity">Экземпляр сущности</param>
    /// <param name="type"></param>
    /// <param name="values"></param>
    void ExecPostSaveActions(
      IEntity entity,
      Type type,
      Dictionary<string, object> values,
      Dictionary<string, string> serviceData,
      LinksDictionary links);

    /// <summary>Выполняет сохранение сущности определенного типа</summary>
    /// <param name="entity">Экземпляр сущности</param>
    void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData);

    /// <summary>Проверка сущности перед импортом</summary>
    void TestRead(ImportTestReadData data, ImportTestReadResult result);

    /// <summary>Восстановить ссылки на сущность</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="entityUid">Уникальный идентификатор сущности</param>
    /// <param name="linksDictionary">Список ссылок</param>
    /// <returns>Список ссылок для удаления</returns>
    IEnumerable<ILinksDictionaryItem> RecoveryLinks(
      IEntity entity,
      Guid entityUid,
      LinksDictionary linksDictionary);
  }
}
