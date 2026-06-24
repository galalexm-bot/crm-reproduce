// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.ICodeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.CodeDom;
using System.Collections.Generic;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  /// <summary>Интерфейс элемента кода</summary>
  public interface ICodeItem
  {
    /// <summary>Имя</summary>
    string Name { get; set; }

    /// <summary>Уникальный идентификатор элемента представления</summary>
    Guid Uid { get; set; }

    /// <summary>Инициализация нового элемента</summary>
    /// <param name="parent"></param>
    void InitNew(ICodeItem parent);

    /// <summary>
    /// Можно ли вставить данный элемент кода в составной элемент
    /// </summary>
    /// <param name="codeItem">Составной элемент кода</param>
    /// <returns></returns>
    bool IsValidParent(ICodeItem codeItem);

    /// <summary>Перевод элемента в CodeStatement</summary>
    /// <returns>Обьект CodeDOM</returns>
    CodeStatement ToCodeStatement();

    /// <summary>Перевод элемента в CodeExpression</summary>
    /// <returns>Объект CodeDOM</returns>
    CodeExpression ToCodeExpression();

    /// <summary>Перевод элемента в список CodeStatement</summary>
    /// <returns>Список CodeStatement</returns>
    CodeStatement[] ToCodeStatementList();

    /// <summary>Список типов элементов которые можно вставить</summary>
    /// <returns></returns>
    List<Type> GetValidToInsert();
  }
}
