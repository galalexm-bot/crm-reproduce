// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.ICodeItemToolBoxGroup
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  /// <summary>Группа элементов представления в панели инструментов</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface ICodeItemToolBoxGroup
  {
    /// <summary>Uid группы</summary>
    Guid GroupUid { get; }

    /// <summary>Uid родительской группы</summary>
    Guid ParentGroupUid { get; }

    /// <summary>Имя группы</summary>
    string Name { get; }
  }
}
