// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.MathCodeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.ScriptDesigner.Enums;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  /// <summary>Блок для математических действий</summary>
  [DisplayName(typeof (ResourcesMathCodeItem), "DisplayName")]
  [Serializable]
  public class MathCodeItem : TwoOperandCodeItem
  {
    internal static MathCodeItem XSu0ZGRvDa6QIBnHOYB;

    public MathCodeItem()
    {
      MathCodeItem.WwF1mfRu9LrSbiAa61D();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.OperandTwo = (CodeItem) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
            continue;
          default:
            this.OperandOne = (CodeItem) null;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    public override List<Type> GetTypesByOperand(OperandDirection direction) => new List<Type>()
    {
      typeof (VariableCodeItem),
      typeof (MathCodeItem),
      typeof (ExactValueCodeItem)
    };

    public override bool IsValidParent(ICodeItem compositeCodeItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (compositeCodeItem is AssignCodeItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return compositeCodeItem is MathCodeItem;
label_5:
      return true;
    }

    public override CodeStatement ToCodeStatement()
    {
      int num = 1;
      CodeExpression expression;
      while (true)
      {
        switch (num)
        {
          case 1:
            expression = (CodeExpression) MathCodeItem.JZAw5SRI4AmsktqpXjJ((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            if (expression != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 2;
              continue;
            }
            goto label_5;
        }
      }
label_4:
      return (CodeStatement) new CodeExpressionStatement(expression);
label_5:
      return (CodeStatement) null;
    }

    public override CodeExpression ToCodeExpression()
    {
      int num = 3;
      CodeExpression codeExpression;
      CodeExpression right;
      while (true)
      {
        switch (num)
        {
          case 2:
            if (this.OperandTwo == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 3:
            if (this.OperandOne != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 2;
              continue;
            }
            goto label_13;
          case 4:
            if (right == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
              continue;
            }
            goto label_12;
          case 5:
            if (codeExpression != null)
            {
              num = 4;
              continue;
            }
            goto label_13;
          case 6:
            codeExpression = this.OperandOne.ToCodeExpression();
            num = 8;
            continue;
          case 7:
            goto label_12;
          case 8:
            right = (CodeExpression) MathCodeItem.JZAw5SRI4AmsktqpXjJ((object) this.OperandTwo);
            num = 5;
            continue;
          default:
            goto label_13;
        }
      }
label_12:
      return (CodeExpression) new CodeBinaryOperatorExpression(codeExpression, MathCodeItem.C33byYRVjBePAbpLYK3((object) this), right);
label_13:
      return (CodeExpression) null;
    }

    public override CodeStatement[] ToCodeStatementList() => (CodeStatement[]) null;

    public override List<Type> GetValidToInsert() => throw new NotImplementedException();

    public override bool IsValidChild(ICodeItem codeItem) => codeItem is VariableCodeItem;

    public override CodeBinaryOperatorType GetOperatorType()
    {
      int num1 = 14;
      CodeBinaryOperatorType operatorType;
      while (true)
      {
        int num2 = num1;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              operatorType = CodeBinaryOperatorType.Subtract;
              num2 = 12;
              continue;
            case 4:
              if (!MathCodeItem.gQWCW5RinZRtyOHWZim((object) str, MathCodeItem.YcpAiMRSUWS1mVDl3aO(~-122002947 ^ 122016230)))
              {
                num2 = 3;
                continue;
              }
              goto case 10;
            case 5:
              operatorType = CodeBinaryOperatorType.Add;
              num2 = 2;
              continue;
            case 7:
              if (!MathCodeItem.gQWCW5RinZRtyOHWZim((object) str, MathCodeItem.YcpAiMRSUWS1mVDl3aO(322893104 - -1992822529 ^ -1979230623)))
              {
                num2 = 11;
                continue;
              }
              goto case 8;
            case 8:
              operatorType = CodeBinaryOperatorType.Multiply;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            case 9:
              if (!MathCodeItem.gQWCW5RinZRtyOHWZim((object) str, MathCodeItem.YcpAiMRSUWS1mVDl3aO(1925118608 << 2 ^ -889477730)))
              {
                num2 = 7;
                continue;
              }
              goto case 5;
            case 10:
              operatorType = CodeBinaryOperatorType.Divide;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 6;
              continue;
            case 11:
              if (!MathCodeItem.gQWCW5RinZRtyOHWZim((object) str, MathCodeItem.YcpAiMRSUWS1mVDl3aO(-1939377524 ^ -1939374880)))
              {
                num2 = 4;
                continue;
              }
              goto case 1;
            case 13:
              goto label_7;
            case 14:
              operatorType = CodeBinaryOperatorType.Add;
              num2 = 13;
              continue;
            default:
              goto label_5;
          }
        }
label_7:
        str = this.Operator;
        num1 = 9;
      }
label_5:
      return operatorType;
    }

    internal static void WwF1mfRu9LrSbiAa61D() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool ErFWm1R8uj2gH6rOGYx() => MathCodeItem.XSu0ZGRvDa6QIBnHOYB == null;

    internal static MathCodeItem fEOHBtRZtVsWRYBWCbJ() => MathCodeItem.XSu0ZGRvDa6QIBnHOYB;

    internal static object JZAw5SRI4AmsktqpXjJ([In] object obj0) => (object) ((CodeItem) obj0).ToCodeExpression();

    internal static CodeBinaryOperatorType C33byYRVjBePAbpLYK3([In] object obj0) => ((TwoOperandCodeItem) obj0).GetOperatorType();

    internal static object YcpAiMRSUWS1mVDl3aO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool gQWCW5RinZRtyOHWZim([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    [Component(Order = 56)]
    private class ToolboxItem : MathCodeItemToolBoxItem<MathCodeItem>
    {
      internal static object k1HSfwfxdsYcfJJIZWo8;

      public ToolboxItem()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.ToolTipBody = EleWise.ELMA.SR.T((string) MathCodeItem.ToolboxItem.xlvJTCfxgY07b5oyp9xK(381945751 ^ 1158627804 ^ 1406018295));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
              continue;
            case 2:
              this.ToolTipHeader = (string) MathCodeItem.ToolboxItem.iMmX4Cfx5hd9eFqXb5DW(MathCodeItem.ToolboxItem.xlvJTCfxgY07b5oyp9xK(1917256330 ^ 1917276380));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static object xlvJTCfxgY07b5oyp9xK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object iMmX4Cfx5hd9eFqXb5DW([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool DtIUWHfxl2Rh3LHqI9LW() => MathCodeItem.ToolboxItem.k1HSfwfxdsYcfJJIZWo8 == null;

      internal static MathCodeItem.ToolboxItem yeAWrPfxrl9UuSLR7Vmr() => (MathCodeItem.ToolboxItem) MathCodeItem.ToolboxItem.k1HSfwfxdsYcfJJIZWo8;
    }
  }
}
