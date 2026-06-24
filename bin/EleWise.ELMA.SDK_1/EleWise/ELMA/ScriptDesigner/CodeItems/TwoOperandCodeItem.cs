// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.TwoOperandCodeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ScriptDesigner.Enums;
using j3AmrhgkCleVTGdEwA;
using System;
using System.CodeDom;
using System.Collections.Generic;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  [Serializable]
  public abstract class TwoOperandCodeItem : 
    CompositeCodeItem,
    ITwoOperandCodeItem,
    ICompositeCodeItem,
    ICodeItem
  {
    internal static TwoOperandCodeItem juDfjfiQFx3qquUMjpm;

    public CodeItem OperandOne
    {
      get => this.\u003COperandOne\u003Ek__BackingField;
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
              this.\u003COperandOne\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
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

    public CodeItem OperandTwo
    {
      get => this.\u003COperandTwo\u003Ek__BackingField;
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
              this.\u003COperandTwo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
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

    public string Operator
    {
      get => this.\u003COperator\u003Ek__BackingField;
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
              this.\u003COperator\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
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

    public abstract List<Type> GetTypesByOperand(OperandDirection direction);

    public abstract CodeBinaryOperatorType GetOperatorType();

    protected TwoOperandCodeItem()
    {
      TwoOperandCodeItem.dw6bFBi8hqYmmjyMRgd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool TX284biCIdQTIfHB60Q() => TwoOperandCodeItem.juDfjfiQFx3qquUMjpm == null;

    internal static TwoOperandCodeItem VmZvT5ivcyvl0I8X8gQ() => TwoOperandCodeItem.juDfjfiQFx3qquUMjpm;

    internal static void dw6bFBi8hqYmmjyMRgd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
