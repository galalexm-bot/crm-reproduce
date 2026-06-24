// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.ICodeItemPoint
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using System;
using System.Drawing;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  public interface ICodeItemPoint
  {
    /// <summary>Имя элемента</summary>
    string Name { get; set; }

    /// <summary>Тип элемента кода</summary>
    Type CodeItemType { get; }

    /// <summary>Uid группы элементов в панели инструментов</summary>
    Guid GroupUid { get; }

    /// <summary>
    /// Иконка для отображения элементов в панели инструментов
    /// </summary>
    Image Image { get; }

    /// <summary>Создать новый элемент представления</summary>
    /// <returns></returns>
    ICodeItem CreateCodeItem();

    /// <summary>Путь</summary>
    string Path { get; set; }

    /// <summary>Отображаемое имя</summary>
    string DisplayName { get; set; }

    /// <summary>Наименование переменной</summary>
    string VariableName { get; set; }

    /// <summary>Рантайм тип переменной(если есть)</summary>
    Type VariableType { get; set; }

    /// <summary>Описание</summary>
    string Description { get; set; }

    /// <summary>Локальная ли она</summary>
    bool IsLocal { get; set; }

    /// <summary>Доступен</summary>
    /// <param name="metadata"></param>
    /// <returns></returns>
    bool IsAvailable(IMetadata metadata);

    /// <summary>Уникальный идентификатор</summary>
    Guid Uid { get; set; }
  }
}
