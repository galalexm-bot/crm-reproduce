// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.IActionCodeItemPoint
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;
using System.Drawing;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  public interface IActionCodeItemPoint
  {
    /// <summary>Наименование</summary>
    string Name { get; set; }

    /// <summary>Порядковый номер действия</summary>
    int Order { get; set; }

    /// <summary>Отображаемое имя</summary>
    string DisplayName { get; set; }

    /// <summary>Описание действия</summary>
    string Description { get; set; }

    /// <summary>Параметры метода</summary>
    List<DesignerParameterInfo> Parameters { get; set; }

    /// <summary>Возвращаемый параметр</summary>
    DesignerParameterInfo ReturnType { get; set; }

    /// <summary>Путь вызова метода</summary>
    string CallPath { get; set; }

    Image Image { get; set; }
  }
}
