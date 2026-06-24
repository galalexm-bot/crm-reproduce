// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Nullifier.INullifierActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Drawing;

namespace EleWise.ELMA.Nullifier
{
  /// <summary>
  /// Подключение модулей к системе управления конфигурациями. Работа с очисткой БД.
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface INullifierActions
  {
    /// <summary>Дополнить дерево очищаемых объектов</summary>
    /// <param name="addNode">
    /// Добавить ноду в дерево объектов
    /// string nodeName- текст
    /// nodeName - текст
    /// Uid -uid добавляемой сущности
    /// object tag - Метаданные очищаемой сущности,
    /// int level уровень дерева в который добавить ноду
    /// string CellText - текст в колонке удаления
    /// Guid TypeUid - guid типа удаляемого объекта,
    /// bool СlearParentAll - пометит для очистки все зависимые объекты
    /// bool NoDeleteRootEntity - не удалять корневую сущность
    /// Image image - иконка на ноде
    /// </param>
    void CreateTree(
      Func<string, Guid, object, int, string, Guid, bool, bool, Image, bool> addNode);

    /// <summary>Очистка объектов</summary>
    void ClearObject(ClearObjectParameters clearObjectParameters);

    /// <summary>Удалить папки</summary>
    DeleteFoldersOutput DeleteFolders(DeleteFoldersInput deleteFoldersInput);

    /// <summary>действия после всех обнулений</summary>
    void PostNullifier(PostNullifierParameters postNullifierParameters);

    /// <summary>поиск использования файлов в системе</summary>
    void SearchSystemFile();
  }
}
