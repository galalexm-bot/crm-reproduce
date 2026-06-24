// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.AssignCodeItem
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
  /// <summary>Элемент присвоения значения</summary>
  [DisplayName(typeof (ResourcesAssignVariableCodeItem), "DisplayName")]
  [Serializable]
  public class AssignCodeItem : TwoOperandCodeItem
  {
    private static AssignCodeItem o1Wdd7SMENUpaXPigM0;

    public AssignCodeItem()
    {
      AssignCodeItem.php3VCSdccSLoS3Gt2O();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public override List<Type> GetTypesByOperand(OperandDirection direction)
    {
      if (direction == OperandDirection.Left)
        return new List<Type>()
        {
          typeof (VariableCodeItem)
        };
      return new List<Type>()
      {
        typeof (VariableCodeItem),
        typeof (MathCodeItem),
        typeof (ExactValueCodeItem)
      };
    }

    public override CodeBinaryOperatorType GetOperatorType() => throw new NotImplementedException();

    public override bool IsValidParent(ICodeItem compositeCodeItem)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (!(compositeCodeItem is IfCodeItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 3:
            if (!(compositeCodeItem is RootCodeItem))
            {
              num = 2;
              continue;
            }
            goto label_7;
          default:
            if (!(compositeCodeItem is ElseCodeItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
              continue;
            }
            goto label_7;
        }
      }
label_6:
      return compositeCodeItem is IterationCodeItem;
label_7:
      return true;
    }

    public override CodeStatement ToCodeStatement()
    {
      int num = 4;
      CodeExpression right;
      CodeExpression left;
      while (true)
      {
        switch (num)
        {
          case 1:
            right = (CodeExpression) AssignCodeItem.qu7MJ1SloebnYPxh3Qr((object) this.OperandTwo);
            num = 6;
            continue;
          case 2:
            if (right != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 7 : 5;
              continue;
            }
            goto label_10;
          case 3:
          case 5:
            goto label_10;
          case 4:
            if (this.OperandOne == null)
            {
              num = 3;
              continue;
            }
            break;
          case 6:
            if (left == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 5 : 2;
              continue;
            }
            goto case 2;
          case 7:
            goto label_9;
          case 8:
            left = (CodeExpression) AssignCodeItem.qu7MJ1SloebnYPxh3Qr((object) this.OperandOne);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
            continue;
        }
        if (this.OperandTwo != null)
          num = 8;
        else
          goto label_10;
      }
label_9:
      return (CodeStatement) new CodeAssignStatement(left, right);
label_10:
      return (CodeStatement) null;
    }

    public override CodeExpression ToCodeExpression() => (CodeExpression) null;

    public override CodeStatement[] ToCodeStatementList() => (CodeStatement[]) null;

    public override List<Type> GetValidToInsert() => new List<Type>()
    {
      typeof (VariableCodeItem),
      typeof (MathCodeItem),
      typeof (ExactValueCodeItem)
    };

    public override bool IsValidChild(ICodeItem codeItem) => codeItem is VariableCodeItem;

    internal static void php3VCSdccSLoS3Gt2O() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool DYlv0BSJNNkdKVlScoF() => AssignCodeItem.o1Wdd7SMENUpaXPigM0 == null;

    internal static AssignCodeItem Jf1A0DS9b5kwJDT1ngt() => AssignCodeItem.o1Wdd7SMENUpaXPigM0;

    internal static object qu7MJ1SloebnYPxh3Qr([In] object obj0) => (object) ((CodeItem) obj0).ToCodeExpression();

    [Component(Order = 52)]
    private class ToolboxItem : AssignCodeItemToolBoxItem<AssignCodeItem>
    {
      internal static object AyUmfcfxRgPMsNkyrCZs;

      public ToolboxItem()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.ToolTipHeader = (string) AssignCodeItem.ToolboxItem.OMGYq0fxTiGlZyoVfFGk((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882147036));
              num = 2;
              continue;
            case 2:
              goto label_3;
            default:
              this.ToolTipBody = (string) AssignCodeItem.ToolboxItem.OMGYq0fxTiGlZyoVfFGk(AssignCodeItem.ToolboxItem.eyJygnfxXSn0f8cw6ach(1304605005 ^ 1304941203));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }

      internal static object eyJygnfxXSn0f8cw6ach(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object OMGYq0fxTiGlZyoVfFGk([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool AbWdZjfxqBXy0sTZDL8H() => AssignCodeItem.ToolboxItem.AyUmfcfxRgPMsNkyrCZs == null;

      internal static AssignCodeItem.ToolboxItem mHRhRIfxKp5hARi29NOB() => (AssignCodeItem.ToolboxItem) AssignCodeItem.ToolboxItem.AyUmfcfxRgPMsNkyrCZs;
    }
  }
}
