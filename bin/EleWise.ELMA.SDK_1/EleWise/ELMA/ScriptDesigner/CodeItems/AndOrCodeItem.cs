// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.AndOrCodeItem
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
  /// <summary>Логический оператор "И" и "ИЛИ"</summary>
  [DisplayName(typeof (ResourcesOrCodeItem), "DisplayName")]
  [Serializable]
  public class AndOrCodeItem : TwoOperandCodeItem
  {
    private static AndOrCodeItem FELYc2qugi2Gmv0N91h;

    public AndOrCodeItem()
    {
      AndOrCodeItem.HI5dfiqSBieKNPj2B54();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override bool IsValidParent(ICodeItem codeItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(codeItem is IfConditionCodeItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_6;
          case 3:
            goto label_7;
          default:
            if (codeItem is AndOrCodeItem)
            {
              num = 3;
              continue;
            }
            goto label_6;
        }
      }
label_6:
      return codeItem is ConditionCodeItem;
label_7:
      return true;
    }

    public override CodeStatement ToCodeStatement() => (CodeStatement) null;

    public override CodeBinaryOperatorType GetOperatorType()
    {
      int num = 2;
      CodeBinaryOperatorType operatorType;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            str = this.Operator;
            num = 4;
            continue;
          case 2:
            operatorType = CodeBinaryOperatorType.Add;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 1;
            continue;
          case 3:
            operatorType = CodeBinaryOperatorType.BooleanAnd;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          case 4:
            if (!(str == (string) AndOrCodeItem.XCm2Teqiax634IUTKBj(-1824388195 ^ -1824373511)))
            {
              num = 5;
              continue;
            }
            goto case 6;
          case 5:
            if (!AndOrCodeItem.NYiOoZqRQBTEVIb87pM((object) str, AndOrCodeItem.XCm2Teqiax634IUTKBj(-138018305 ^ -137998687)))
            {
              num = 7;
              continue;
            }
            goto case 3;
          case 6:
            operatorType = CodeBinaryOperatorType.BooleanOr;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 4 : 8;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return operatorType;
    }

    public override CodeExpression ToCodeExpression()
    {
      int num = 6;
      CodeExpression right;
      CodeExpression left;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.OperandTwo != null)
            {
              num = 3;
              continue;
            }
            goto label_10;
          case 2:
            if (left != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          case 3:
            left = (CodeExpression) AndOrCodeItem.mmCYs6qq53hgbTcbTRX((object) this.OperandOne);
            num = 7;
            continue;
          case 4:
            goto label_9;
          case 5:
            goto label_10;
          case 6:
            if (this.OperandOne == null)
            {
              num = 5;
              continue;
            }
            goto case 1;
          case 7:
            right = (CodeExpression) AndOrCodeItem.mmCYs6qq53hgbTcbTRX((object) this.OperandTwo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 2;
            continue;
          default:
            if (right != null)
            {
              num = 4;
              continue;
            }
            goto label_10;
        }
      }
label_9:
      return (CodeExpression) new CodeBinaryOperatorExpression(left, AndOrCodeItem.oNly2OqKpQfKr3JfD22((object) this), right);
label_10:
      return (CodeExpression) null;
    }

    public override CodeStatement[] ToCodeStatementList() => (CodeStatement[]) null;

    public override List<Type> GetValidToInsert() => throw new NotImplementedException();

    public override bool IsValidChild(ICodeItem codeItem) => throw new NotImplementedException();

    public override List<Type> GetTypesByOperand(OperandDirection direction) => new List<Type>()
    {
      typeof (ConditionCodeItem),
      typeof (AndOrCodeItem)
    };

    internal static void HI5dfiqSBieKNPj2B54() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool hkFiYWqIXPnuiOvkblW() => AndOrCodeItem.FELYc2qugi2Gmv0N91h == null;

    internal static AndOrCodeItem bQQ6qdqV3Axp5DV5WHS() => AndOrCodeItem.FELYc2qugi2Gmv0N91h;

    internal static object XCm2Teqiax634IUTKBj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool NYiOoZqRQBTEVIb87pM([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object mmCYs6qq53hgbTcbTRX([In] object obj0) => (object) ((CodeItem) obj0).ToCodeExpression();

    internal static CodeBinaryOperatorType oNly2OqKpQfKr3JfD22([In] object obj0) => ((TwoOperandCodeItem) obj0).GetOperatorType();

    [Component(Order = 56)]
    private class ToolboxItem : LogicalCodeItemToolBoxItem<AndOrCodeItem>
    {
      private static object VcJMxXf0vta1tVbdXlAs;

      public ToolboxItem()
      {
        AndOrCodeItem.ToolboxItem.brnbOef0uO8rG17IYrpu();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.ToolTipBody = (string) AndOrCodeItem.ToolboxItem.RLJZy6f0VZ2yR4vni2jN(AndOrCodeItem.ToolboxItem.YgOl4Wf0If9Ojt1oeUIR(1012087039 ^ 1012293037));
              num = 2;
              continue;
            case 2:
              goto label_3;
            default:
              this.ToolTipHeader = (string) AndOrCodeItem.ToolboxItem.RLJZy6f0VZ2yR4vni2jN(AndOrCodeItem.ToolboxItem.YgOl4Wf0If9Ojt1oeUIR(964881585 - -1459193222 ^ -1871112329));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }

      internal static void brnbOef0uO8rG17IYrpu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object YgOl4Wf0If9Ojt1oeUIR(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object RLJZy6f0VZ2yR4vni2jN([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool q7myxOf08jJPObXqieJa() => AndOrCodeItem.ToolboxItem.VcJMxXf0vta1tVbdXlAs == null;

      internal static AndOrCodeItem.ToolboxItem tM3T0Zf0ZDH1rQFKNbIe() => (AndOrCodeItem.ToolboxItem) AndOrCodeItem.ToolboxItem.VcJMxXf0vta1tVbdXlAs;
    }
  }
}
