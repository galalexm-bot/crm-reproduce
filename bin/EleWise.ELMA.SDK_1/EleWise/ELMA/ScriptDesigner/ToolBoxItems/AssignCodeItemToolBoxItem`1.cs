// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.ToolBoxItems.AssignCodeItemToolBoxItem`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ScriptDesigner.CodeItems;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.ScriptDesigner.ToolBoxItems
{
  public abstract class AssignCodeItemToolBoxItem<TCodeItem> : CodeItemToolBoxItem<TCodeItem> where TCodeItem : ICodeItem
  {
    private static object WsgaqlIi9rjN588RMIe;

    public override Guid GroupUid => AssignCodeItemToolBoxGroup.UID;

    protected AssignCodeItemToolBoxItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool yVydDmIRTf83OcieIoO() => AssignCodeItemToolBoxItem<TCodeItem>.WsgaqlIi9rjN588RMIe == null;

    internal static object CsZrdlIq0Es4tDDHeNB() => AssignCodeItemToolBoxItem<TCodeItem>.WsgaqlIi9rjN588RMIe;
  }
}
