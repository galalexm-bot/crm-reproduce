// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.ICompositeCodeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  /// <summary>Интерфейс составного элемента кода</summary>
  public interface ICompositeCodeItem : ICodeItem
  {
    /// <summary>Внутренние элементы</summary>
    List<CodeItem> Items { get; set; }

    /// <summary>Получить все элементы</summary>
    /// <returns></returns>
    IEnumerable<ICodeItem> GetAllItems();

    /// <summary>Можно ли вставить элемент в данный составной элемент</summary>
    /// <param name="codeItem"></param>
    /// <returns></returns>
    bool IsValidChild(ICodeItem codeItem);
  }
}
