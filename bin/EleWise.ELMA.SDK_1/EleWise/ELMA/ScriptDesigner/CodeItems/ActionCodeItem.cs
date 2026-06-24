// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.ActionCodeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  /// <summary>Действие</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (ResourcesActionCodeItem), "DisplayName")]
  [Serializable]
  public class ActionCodeItem : CompositeCodeItem
  {
    internal static ActionCodeItem j82IChSa0VZIPrJGD9D;

    public ActionCodeItem()
    {
      ActionCodeItem.JIqSLGSwoKGGEEITBGM();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Parameters = new List<DesignerParameterInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public string ActionName
    {
      get => this.\u003CActionName\u003Ek__BackingField;
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
              this.\u003CActionName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
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

    public string DisplayName
    {
      get => this.\u003CDisplayName\u003Ek__BackingField;
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
              this.\u003CDisplayName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
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

    public string Description
    {
      get => this.\u003CDescription\u003Ek__BackingField;
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
              this.\u003CDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
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

    public List<DesignerParameterInfo> Parameters { get; set; }

    public ActionOverridesCodeItemPoint ActionsGroup
    {
      get => this.\u003CActionsGroup\u003Ek__BackingField;
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
              this.\u003CActionsGroup\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
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

    public ActionCodeItemPoint Action
    {
      get => this.\u003CAction\u003Ek__BackingField;
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
              this.\u003CAction\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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

    public DesignerParameterInfo ReturnType
    {
      get => this.\u003CReturnType\u003Ek__BackingField;
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
              this.\u003CReturnType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
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

    public NewCodeItemToolBoxItem ReturnTypeItem
    {
      get => this.\u003CReturnTypeItem\u003Ek__BackingField;
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
              this.\u003CReturnTypeItem\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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

    public string CallPath
    {
      get => this.\u003CCallPath\u003Ek__BackingField;
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
              this.\u003CCallPath\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
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
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            if (compositeCodeItem is IfCodeItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
              continue;
            }
            goto case 4;
          case 3:
            if (!(compositeCodeItem is RootCodeItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 2;
              continue;
            }
            goto label_9;
          case 4:
            if (!(compositeCodeItem is ElseCodeItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          default:
            goto label_8;
        }
      }
label_8:
      return compositeCodeItem is IterationCodeItem;
label_9:
      return true;
    }

    public override CodeStatement ToCodeStatement() => (CodeStatement) null;

    public override CodeExpression ToCodeExpression() => (CodeExpression) null;

    public override CodeStatement[] ToCodeStatementList()
    {
      int num = 8;
      List<CodeStatement> codeStatementList;
      CodeMethodInvokeExpression expression;
      CodeCommentStatement commentStatement;
      CodeExpression[] parametersExpressions;
      while (true)
      {
        switch (num)
        {
          case 1:
            expression = new CodeMethodInvokeExpression(new CodeMethodReferenceExpression((CodeExpression) new CodeTypeReferenceExpression(this.CallPath), this.ActionName), parametersExpressions);
            num = 5;
            continue;
          case 2:
            if (ActionCodeItem.F0qO1qS6Shil5fMDiZH((object) this.Action) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
              continue;
            }
            goto case 6;
          case 3:
            codeStatementList.Add((CodeStatement) new CodeExpressionStatement((CodeExpression) new CodeMethodInvokeExpression((CodeExpression) new CodeTypeReferenceExpression((string) ActionCodeItem.sCivHkSHaBcYmFacwTm((object) this.ReturnTypeItem)), (string) ActionCodeItem.dYmG5RS4f5ld30kVjlX(~1767720452 ^ -1767708189), new CodeExpression[1]
            {
              (CodeExpression) expression
            })));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 11 : 11;
            continue;
          case 4:
            parametersExpressions = ActionCodeItem.GetParametersExpressions(this.Action.Parameters);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
            continue;
          case 5:
            commentStatement = new CodeCommentStatement(EleWise.ELMA.SR.T((string) ActionCodeItem.dYmG5RS4f5ld30kVjlX(-1822890472 ^ -1822905880), (object) this.DisplayName));
            num = 10;
            continue;
          case 6:
            if (this.ReturnTypeItem == null)
            {
              num = 9;
              continue;
            }
            goto case 3;
          case 7:
            List<DesignerParameterInfo> parameters = this.Action.Parameters;
            // ISSUE: reference to a compiler-generated field
            Predicate<DesignerParameterInfo> predicate = ActionCodeItem.\u003C\u003Ec.\u003C\u003E9__40_0;
            Predicate<DesignerParameterInfo> match;
            if (predicate == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              ActionCodeItem.\u003C\u003Ec.\u003C\u003E9__40_0 = match = (Predicate<DesignerParameterInfo>) (a => ActionCodeItem.\u003C\u003Ec.phqH3pfxiYwnd79kkKRK((object) a));
            }
            else
              goto label_19;
label_17:
            if (!parameters.TrueForAll(match))
            {
              num = 12;
              continue;
            }
            goto case 4;
label_19:
            match = predicate;
            goto label_17;
          case 8:
            codeStatementList = new List<CodeStatement>();
            num = 7;
            continue;
          case 10:
            codeStatementList.Add((CodeStatement) commentStatement);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 2;
            continue;
          case 11:
          case 13:
            goto label_3;
          case 12:
            goto label_4;
          default:
            codeStatementList.Add((CodeStatement) new CodeExpressionStatement((CodeExpression) expression));
            num = 13;
            continue;
        }
      }
label_3:
      return (CodeStatement[]) ActionCodeItem.cpMthySA7gKN3Cd428s((object) codeStatementList);
label_4:
      return (CodeStatement[]) null;
    }

    public override List<Type> GetValidToInsert() => new List<Type>()
    {
      typeof (VariableCodeItem),
      typeof (MathCodeItem),
      typeof (ExactValueCodeItem)
    };

    /// <summary>Получить выражения параметров</summary>
    /// <param name="parameters">Параметры</param>
    /// <returns>Параметры</returns>
    public static CodeExpression[] GetParametersExpressions(List<DesignerParameterInfo> parameters)
    {
      List<CodeExpression> codeExpressionList = new List<CodeExpression>();
      foreach (DesignerParameterInfo designerParameterInfo in parameters.OrderBy<DesignerParameterInfo, int>((Func<DesignerParameterInfo, int>) (a => a.Order)).ToList<DesignerParameterInfo>())
      {
        CodeVariableReferenceExpression referenceExpression = new CodeVariableReferenceExpression(designerParameterInfo.SelectedValueName);
        codeExpressionList.Add((CodeExpression) referenceExpression);
      }
      return codeExpressionList.ToArray();
    }

    public override bool IsValidChild(ICodeItem codeItem) => codeItem is VariableCodeItem;

    internal static void JIqSLGSwoKGGEEITBGM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool XrhiA8SDYeiGJOZVCa9() => ActionCodeItem.j82IChSa0VZIPrJGD9D == null;

    internal static ActionCodeItem dEegoNSt4aNt6NC68C7() => ActionCodeItem.j82IChSa0VZIPrJGD9D;

    internal static object dYmG5RS4f5ld30kVjlX(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object F0qO1qS6Shil5fMDiZH([In] object obj0) => (object) ((ActionCodeItemPoint) obj0).ReturnType;

    internal static object sCivHkSHaBcYmFacwTm([In] object obj0) => (object) ((NewCodeItemToolBoxItem) obj0).VariableName;

    internal static object cpMthySA7gKN3Cd428s([In] object obj0) => (object) ((List<CodeStatement>) obj0).ToArray();
  }
}
