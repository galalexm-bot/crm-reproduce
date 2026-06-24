// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.BaseCodeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.CodeDom;
using System.Collections.Generic;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  /// <summary>Базовый элемент. Используется как универсальный</summary>
  public class BaseCodeItem : CodeItem
  {
    internal static BaseCodeItem qaExJ4q31XEkfNLCOr4;

    public BaseCodeItem()
    {
      BaseCodeItem.WTbrfAqDxBosfDbtRtB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public string VariableName
    {
      get => this.\u003CVariableName\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CVariableName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public Type VariableType
    {
      get => this.\u003CVariableType\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CVariableType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public override bool IsValidParent(ICodeItem compositeCodeItem)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (compositeCodeItem is AssignCodeItem)
              {
                num2 = 5;
                continue;
              }
              break;
            case 2:
            case 5:
            case 7:
            case 10:
            case 11:
              goto label_18;
            case 3:
              if (compositeCodeItem is IfCodeItem)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 10 : 10;
                continue;
              }
              goto case 1;
            case 4:
              if (!(compositeCodeItem is AndOrCodeItem))
              {
                num2 = 6;
                continue;
              }
              goto label_18;
            case 6:
              if (compositeCodeItem is IfConditionCodeItem)
              {
                num2 = 11;
                continue;
              }
              goto label_17;
            case 8:
              if (!(compositeCodeItem is RootCodeItem))
                goto case 3;
              else
                goto label_6;
            case 9:
              if (compositeCodeItem is ElseCodeItem)
              {
                num2 = 2;
                continue;
              }
              goto case 13;
            case 12:
              goto label_17;
            case 13:
              if (!(compositeCodeItem is MathCodeItem))
              {
                num2 = 4;
                continue;
              }
              goto label_18;
          }
          if (!(compositeCodeItem is ConditionCodeItem))
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 9 : 5;
          else
            goto label_18;
        }
label_6:
        num1 = 7;
      }
label_17:
      return compositeCodeItem is IterationCodeItem;
label_18:
      return true;
    }

    public override CodeStatement ToCodeStatement() => (CodeStatement) null;

    public override CodeExpression ToCodeExpression() => (CodeExpression) null;

    public override CodeStatement[] ToCodeStatementList() => (CodeStatement[]) null;

    public override List<Type> GetValidToInsert() => throw new NotImplementedException();

    internal static void WTbrfAqDxBosfDbtRtB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool fKHmoFqp87LVQisvTpd() => BaseCodeItem.qaExJ4q31XEkfNLCOr4 == null;

    internal static BaseCodeItem Hup8ptqa9C5EKsQnsik() => BaseCodeItem.qaExJ4q31XEkfNLCOr4;
  }
}
