// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.ElseCodeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;
using System.CodeDom;
using System.Collections.Generic;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  /// <summary>Элемент ELSE</summary>
  [DisplayName(typeof (ResourcesElseCodeItem), "DisplayName")]
  [Serializable]
  public class ElseCodeItem : CompositeCodeItem
  {
    private static ElseCodeItem lL1NXHi6QI0MN26V4fA;

    public ElseCodeItem()
    {
      ElseCodeItem.EWT8Rci7sTSAshZDaly();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override bool IsValidParent(ICodeItem compositeCodeItem) => throw new NotImplementedException();

    public override CodeStatement ToCodeStatement() => (CodeStatement) null;

    public override CodeExpression ToCodeExpression() => (CodeExpression) null;

    public override CodeStatement[] ToCodeStatementList() => (CodeStatement[]) null;

    public override List<Type> GetValidToInsert() => new List<Type>()
    {
      typeof (AssignCodeItem),
      typeof (IfCodeItem),
      typeof (IterationCodeItem)
    };

    public override bool IsValidChild(ICodeItem codeItem)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_5;
          case 2:
            if (codeItem is AssignCodeItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          case 4:
            if (codeItem is IfCodeItem)
            {
              num = 3;
              continue;
            }
            goto case 2;
          default:
            goto label_4;
        }
      }
label_4:
      return codeItem is IterationCodeItem;
label_5:
      return true;
    }

    internal static void EWT8Rci7sTSAshZDaly() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool IcUwioiHkNpvGLs9I7x() => ElseCodeItem.lL1NXHi6QI0MN26V4fA == null;

    internal static ElseCodeItem tEOiUjiAXVPdDfenO30() => ElseCodeItem.lL1NXHi6QI0MN26V4fA;
  }
}
