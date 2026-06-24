// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.ConditionCodeItem
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
  /// <summary>Условие</summary>
  [DisplayName(typeof (ResourcesConditionCodeItem), "DisplayName")]
  [Serializable]
  public class ConditionCodeItem : TwoOperandCodeItem
  {
    internal static ConditionCodeItem cOpBL4ini2bi1x4P53x;

    public ConditionCodeItem()
    {
      ConditionCodeItem.nC8oYEieUrwi8WhaTve();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Operator = (string) ConditionCodeItem.P4rMCxiPNQ2ejpm3S68(1304605005 ^ 1304608071);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public override bool IsValidParent(ICodeItem compositeCodeItem)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(compositeCodeItem is ConditionCodeItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            if (!(compositeCodeItem is IfConditionCodeItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
              continue;
            }
            goto label_7;
          default:
            goto label_6;
        }
      }
label_6:
      return compositeCodeItem is AndOrCodeItem;
label_7:
      return true;
    }

    public override CodeStatement ToCodeStatement() => (CodeStatement) null;

    public override CodeExpression ToCodeExpression()
    {
      int num = 4;
      CodeExpression left;
      CodeExpression right;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (left == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 1;
              continue;
            }
            goto case 5;
          case 3:
            goto label_6;
          case 4:
            if (this.OperandOne == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 3;
              continue;
            }
            goto case 8;
          case 5:
            if (right != null)
            {
              num = 6;
              continue;
            }
            goto label_5;
          case 6:
            goto label_4;
          case 7:
            left = (CodeExpression) ConditionCodeItem.oDRMfPi1VAqvKxUXk0N((object) this.OperandOne);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
            continue;
          case 8:
            if (this.OperandTwo != null)
            {
              num = 7;
              continue;
            }
            goto label_6;
          default:
            right = (CodeExpression) ConditionCodeItem.oDRMfPi1VAqvKxUXk0N((object) this.OperandTwo);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 2;
            continue;
        }
      }
label_4:
      return (CodeExpression) new CodeBinaryOperatorExpression(left, ConditionCodeItem.EJWt7YiNeNDxPmMwunA((object) this), right);
label_5:
      return (CodeExpression) null;
label_6:
      return (CodeExpression) null;
    }

    public override CodeStatement[] ToCodeStatementList() => (CodeStatement[]) null;

    public override List<Type> GetValidToInsert() => throw new NotImplementedException();

    public override CodeBinaryOperatorType GetOperatorType()
    {
      int num1 = 44;
      CodeBinaryOperatorType operatorType;
      while (true)
      {
        int num2 = num1;
        uint num3;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 8:
            case 9:
            case 10:
            case 15:
            case 16:
            case 23:
            case 24:
            case 25:
            case 30:
            case 31:
            case 32:
            case 33:
            case 34:
            case 35:
            case 38:
            case 40:
            case 41:
            case 45:
            case 52:
              goto label_48;
            case 2:
              if (num3 > 3762399456U)
              {
                num2 = 22;
                continue;
              }
              goto case 37;
            case 3:
              operatorType = CodeBinaryOperatorType.BooleanAnd;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 16 : 9;
              continue;
            case 4:
            case 53:
              operatorType = CodeBinaryOperatorType.LessThanOrEqual;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 24 : 17;
              continue;
            case 5:
              if (ConditionCodeItem.V1Wilvip3SZbOcrMH6D((object) str, ConditionCodeItem.P4rMCxiPNQ2ejpm3S68(1819636893 << 3 ^ 1672211240)))
              {
                num2 = 18;
                continue;
              }
              goto label_48;
            case 6:
              if (!ConditionCodeItem.V1Wilvip3SZbOcrMH6D((object) str, ConditionCodeItem.P4rMCxiPNQ2ejpm3S68(~-122002947 ^ 122016092)))
              {
                num2 = 52;
                continue;
              }
              goto case 3;
            case 7:
              if (num3 > 940354920U)
              {
                num2 = 27;
                continue;
              }
              goto case 11;
            case 11:
              if (num3 != 486946535U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
                continue;
              }
              goto case 6;
            case 12:
            case 28:
              goto label_46;
            case 13:
            case 18:
              operatorType = CodeBinaryOperatorType.GreaterThan;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
              continue;
            case 14:
              if (num3 <= 990687777U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 7 : 0;
                continue;
              }
              goto case 2;
            case 17:
            case 55:
              operatorType = CodeBinaryOperatorType.GreaterThanOrEqual;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 25 : 10;
              continue;
            case 19:
              if (!ConditionCodeItem.V1Wilvip3SZbOcrMH6D((object) str, ConditionCodeItem.P4rMCxiPNQ2ejpm3S68(1033719030 - 2012070891 ^ -978336051)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 35 : 17;
                continue;
              }
              goto case 20;
            case 20:
              operatorType = CodeBinaryOperatorType.LessThan;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 8 : 8;
              continue;
            case 21:
              if (num3 != 990687777U)
              {
                num2 = 30;
                continue;
              }
              goto case 5;
            case 22:
            case 48:
              if (num3 != 3779177075U)
              {
                num2 = 47;
                continue;
              }
              goto case 49;
            case 26:
              if (!ConditionCodeItem.V1Wilvip3SZbOcrMH6D((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123616858)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 34 : 13;
                continue;
              }
              goto case 29;
            case 27:
            case 36:
              if (num3 != 957132539U)
              {
                num2 = 21;
                continue;
              }
              goto case 19;
            case 29:
              operatorType = CodeBinaryOperatorType.IdentityInequality;
              num2 = 23;
              continue;
            case 37:
              if (num3 != 2715107524U)
              {
                num2 = 39;
                continue;
              }
              goto case 42;
            case 39:
              if (num3 != 3762399456U)
              {
                num2 = 31;
                continue;
              }
              goto case 51;
            case 42:
              if (ConditionCodeItem.V1Wilvip3SZbOcrMH6D((object) str, ConditionCodeItem.P4rMCxiPNQ2ejpm3S68(1033719030 - 2012070891 ^ -978336145)))
                goto case 54;
              else
                goto label_31;
            case 43:
              str = this.Operator;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 42 : 50;
              continue;
            case 44:
              operatorType = CodeBinaryOperatorType.Add;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 43 : 5;
              continue;
            case 46:
              if (str == (string) ConditionCodeItem.P4rMCxiPNQ2ejpm3S68(-16752921 ^ -16755987))
              {
                num2 = 28;
                continue;
              }
              goto label_48;
            case 47:
              if (num3 != 3846287551U)
              {
                num2 = 33;
                continue;
              }
              goto case 26;
            case 49:
              if (ConditionCodeItem.V1Wilvip3SZbOcrMH6D((object) str, ConditionCodeItem.P4rMCxiPNQ2ejpm3S68(-2099751081 ^ -2099767163)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 4 : 4;
                continue;
              }
              goto label_48;
            case 50:
              num3 = ConditionCodeItem.jVFmWPi3NNhh7SpEcqY((object) str);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 5 : 14;
              continue;
            case 51:
              if (str == (string) ConditionCodeItem.P4rMCxiPNQ2ejpm3S68(694673736 ^ -23604109 ^ -672105737))
              {
                num2 = 55;
                continue;
              }
              goto label_48;
            case 54:
              operatorType = CodeBinaryOperatorType.BooleanOr;
              num2 = 40;
              continue;
            default:
              if (num3 != 940354920U)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 4 : 41;
                continue;
              }
              goto case 46;
          }
        }
label_31:
        num1 = 32;
        continue;
label_46:
        operatorType = CodeBinaryOperatorType.ValueEquality;
        num1 = 9;
      }
label_48:
      return operatorType;
    }

    public override bool IsValidChild(ICodeItem codeItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (codeItem is VariableCodeItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
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
      return codeItem is ConditionCodeItem;
label_5:
      return true;
    }

    public override List<Type> GetTypesByOperand(OperandDirection direction) => new List<Type>()
    {
      typeof (VariableCodeItem),
      typeof (MathCodeItem),
      typeof (ExactValueCodeItem),
      typeof (ConditionCodeItem)
    };

    internal static void nC8oYEieUrwi8WhaTve() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object P4rMCxiPNQ2ejpm3S68(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool kbKAYGiOAyikLvQd8KF() => ConditionCodeItem.cOpBL4ini2bi1x4P53x == null;

    internal static ConditionCodeItem jyewQVi2Z4k8se9BgyR() => ConditionCodeItem.cOpBL4ini2bi1x4P53x;

    internal static object oDRMfPi1VAqvKxUXk0N([In] object obj0) => (object) ((CodeItem) obj0).ToCodeExpression();

    internal static CodeBinaryOperatorType EJWt7YiNeNDxPmMwunA([In] object obj0) => ((TwoOperandCodeItem) obj0).GetOperatorType();

    internal static uint jVFmWPi3NNhh7SpEcqY([In] object obj0) => \u003CPrivateImplementationDetails\u003E.ComputeStringHash((string) obj0);

    internal static bool V1Wilvip3SZbOcrMH6D([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    [Component(Order = 54)]
    private class ToolboxItem : LogicalCodeItemToolBoxItem<ConditionCodeItem>
    {
      internal static object Fd9krZfx64AG9R093ek3;

      public ToolboxItem()
      {
        ConditionCodeItem.ToolboxItem.aYajWhfx7Klkk6BYNEYS();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              this.ToolTipBody = (string) ConditionCodeItem.ToolboxItem.LKVPmyfx0hKYCSyNfgW7((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217694453));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 1;
              continue;
            default:
              this.ToolTipHeader = EleWise.ELMA.SR.T((string) ConditionCodeItem.ToolboxItem.VMtvs3fxxudQ3VlnicSp(1232639661 >> 3 ^ 154092421));
              num = 2;
              continue;
          }
        }
label_3:;
      }

      internal static void aYajWhfx7Klkk6BYNEYS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object VMtvs3fxxudQ3VlnicSp(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object LKVPmyfx0hKYCSyNfgW7([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool ATMxrFfxHNBVr54HI3t6() => ConditionCodeItem.ToolboxItem.Fd9krZfx64AG9R093ek3 == null;

      internal static ConditionCodeItem.ToolboxItem OjJ8t9fxAId5lvNUSeYR() => (ConditionCodeItem.ToolboxItem) ConditionCodeItem.ToolboxItem.Fd9krZfx64AG9R093ek3;
    }
  }
}
