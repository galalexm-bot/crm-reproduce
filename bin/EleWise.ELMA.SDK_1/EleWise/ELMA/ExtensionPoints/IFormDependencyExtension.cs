// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IFormDependencyExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Точка расширения для работы с зависимостями форм</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IFormDependencyExtension
  {
    /// <summary>Проверка типа</summary>
    /// <param name="uid">Уид метаданных</param>
    /// <returns></returns>
    bool CheckType(Guid uid);

    /// <summary>Проверить, существует ли форма</summary>
    /// <param name="objectUid">Уид метаданных</param>
    /// <param name="formUid">Уид формы</param>
    /// <returns></returns>
    bool ExistForm(Guid objectUid, Guid formUid);

    /// <summary>
    /// Получить идентификаторы всех форм объекта. Используется при экспорте-импорте
    /// </summary>
    /// <param name="uid"></param>
    /// <returns></returns>
    IEnumerable<Guid> GetFormUids(Guid uid);

    /// <summary>Сгенерировать зависимости для базовых классов</summary>
    /// <param name="dependObjectUid">Уид метаданных зависимого объекта</param>
    /// <param name="dependObjectFormUid">Уид формы зависимого объекта</param>
    /// <param name="usesObjectMetadata">Метаданные используемого объекта</param>
    /// <param name="usesObjectFormUid">Уид формы используемого объекта</param>
    /// <param name="type">Тип зависимости</param>
    /// <returns></returns>
    IEnumerable<IFormDependencyData> GetDependenciesForBaseClasses(
      Guid dependObjectUid,
      Guid dependObjectFormUid,
      IMetadata usesObjectMetadata,
      Guid usesObjectFormUid,
      FormDependencyDataType type);

    /// <summary>Сгенерировать зависимости для базовых классов</summary>
    /// <param name="dependObjectUid">Уид метаданных зависимого объекта</param>
    /// <param name="dependObjectFormUid">Уид формы зависимого объекта</param>
    /// <param name="usesObjectUid">Уид метаданных используемого объекта</param>
    /// <param name="usesObjectFormUid">Уид формы используемого объекта</param>
    /// <param name="type">Тип зависимости</param>
    /// <returns></returns>
    IEnumerable<IFormDependencyData> GetDependenciesForBaseClasses(
      Guid dependObjectUid,
      Guid dependObjectFormUid,
      Guid usesObjectUid,
      Guid usesObjectFormUid,
      FormDependencyDataType type);

    /// <summary>Сгенерировать новые зависимости</summary>
    /// <param name="dependObjectMetadata">Метаданные зависимого объекта</param>
    void GenerateNewDependencies(IMetadata dependObjectMetadata);

    /// <summary>Сгенерировать новые зависимости</summary>
    /// <param name="dependObjectUid">Уид метаданных зависимого объекта</param>
    void GenerateNewDependencies(Guid dependObjectUid);
  }
}
