// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.IfConditionCodeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  /// <summary>Составное условие оператора условия</summary>
  [DisplayName(typeof (ResourcesIfConditionCodeItem), "DisplayName")]
  [Serializable]
  public class IfConditionCodeItem : CompositeCodeItem
  {
    internal static IfConditionCodeItem jg9oh0qhHWIH1ZBE2pF;

    public IfConditionCodeItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override bool IsValidParent(ICodeItem compositeCodeItem) => compositeCodeItem is IfCodeItem;

    public override CodeStatement ToCodeStatement()
    {
      int num = 1;
      CodeExpression codeExpression;
      while (true)
      {
        switch (num)
        {
          case 1:
            codeExpression = this.ToCodeExpression();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (codeExpression != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 1;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return (CodeStatement) new CodeExpressionStatement(codeExpression);
label_6:
      return (CodeStatement) null;
    }

    public override CodeExpression ToCodeExpression()
    {
      int num1 = 3;
      CodeItem codeItem;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              if (codeItem == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 0;
                continue;
              }
              goto label_3;
            case 3:
              goto label_7;
            default:
              goto label_3;
          }
        }
label_7:
        codeItem = this.Items.FirstOrDefault<CodeItem>();
        num1 = 2;
      }
label_3:
      return (CodeExpression) IfConditionCodeItem.MtnqWmqf7MWIsPR0dZ9((object) codeItem);
label_4:
      return (CodeExpression) null;
    }

    public override CodeStatement[] ToCodeStatementList() => (CodeStatement[]) null;

    public override List<Type> GetValidToInsert() => new List<Type>()
    {
      typeof (ConditionCodeItem),
      typeof (AndOrCodeItem)
    };

    public override bool IsValidChild(ICodeItem codeItem) => codeItem is ConditionCodeItem;

    public override void InitNew(ICodeItem parent)
    {
      int num = 3;
      ConditionCodeItem conditionCodeItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            conditionCodeItem = new ConditionCodeItem();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 3:
            base.InitNew(parent);
            num = 2;
            continue;
          case 4:
            this.Items.Add((CodeItem) conditionCodeItem);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
            continue;
          default:
            IfConditionCodeItem.xpQ9pxqQDKsmUhHhxMx((object) conditionCodeItem, (object) this);
            num = 4;
            continue;
        }
      }
label_2:;
    }

    internal static bool dS8M6VqGP1vF8oNarLk() => IfConditionCodeItem.jg9oh0qhHWIH1ZBE2pF == null;

    internal static IfConditionCodeItem NwCkKmqE9Av7r2KQnUV() => IfConditionCodeItem.jg9oh0qhHWIH1ZBE2pF;

    internal static object MtnqWmqf7MWIsPR0dZ9([In] object obj0) => (object) ((CodeItem) obj0).ToCodeExpression();

    internal static void xpQ9pxqQDKsmUhHhxMx([In] object obj0, [In] object obj1) => ((CodeItem) obj0).InitNew((ICodeItem) obj1);
  }
}
