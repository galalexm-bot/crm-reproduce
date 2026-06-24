// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.CreateEntityCodeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using EleWise.ELMA.ScriptDesigner.TranslateData;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  /// <summary>Элемент создания объекта</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (ResourcesActionCodeItem), "DisplayName")]
  [Serializable]
  public class CreateEntityCodeItem : CompositeCodeItem
  {
    internal static CreateEntityCodeItem op6QvWSYx6QFOSOqhmJ;

    public CreateEntityCodeItem()
    {
      CreateEntityCodeItem.YDLe35Ss468pbj54hB1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Parameters = new List<DesignerParameterInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    public NewCodeItemToolBoxItem VariableCodeItemToolBoxItem
    {
      get => this.\u003CVariableCodeItemToolBoxItem\u003Ek__BackingField;
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
              this.\u003CVariableCodeItemToolBoxItem\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
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

    public override bool IsValidParent(ICodeItem codeItem)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(codeItem is ElseCodeItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 1;
              continue;
            }
            goto label_7;
          case 2:
            goto label_6;
          case 3:
            goto label_7;
          case 4:
            if (codeItem is RootCodeItem)
            {
              num = 3;
              continue;
            }
            break;
        }
        if (!(codeItem is IfCodeItem))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
        else
          goto label_7;
      }
label_6:
      return codeItem is IterationCodeItem;
label_7:
      return true;
    }

    public override CodeStatement ToCodeStatement() => (CodeStatement) null;

    public CodeStatement[] GetPropertiesStatements(string variableName)
    {
      int num1 = 5;
      List<DesignerParameterInfo>.Enumerator enumerator;
      List<CodeStatement> codeStatementList;
      CodeCommentStatement commentStatement;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            enumerator = this.Parameters.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_3;
          case 4:
            List<DesignerParameterInfo> parameters = this.Parameters;
            // ISSUE: reference to a compiler-generated field
            Func<DesignerParameterInfo, bool> func = CreateEntityCodeItem.\u003C\u003Ec.\u003C\u003E9__15_0;
            Func<DesignerParameterInfo, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              CreateEntityCodeItem.\u003C\u003Ec.\u003C\u003E9__15_0 = predicate = (Func<DesignerParameterInfo, bool>) (a => CreateEntityCodeItem.\u003C\u003Ec.LxbOMqfxaeLr7tshAAhW((object) a));
            }
            else
              goto label_25;
label_23:
            if (parameters.Any<DesignerParameterInfo>(predicate))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
label_25:
            predicate = func;
            goto label_23;
          case 5:
            codeStatementList = new List<CodeStatement>();
            num1 = 4;
            continue;
          case 6:
            codeStatementList.Add((CodeStatement) commentStatement);
            num1 = 2;
            continue;
          default:
            commentStatement = new CodeCommentStatement(EleWise.ELMA.SR.T((string) CreateEntityCodeItem.v44IBiScQ0PBqFpaTBZ(-812025778 ^ -812046304), (object) this.VariableCodeItemToolBoxItem.DisplayName));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 6;
            continue;
        }
      }
label_3:
      return (CodeStatement[]) CreateEntityCodeItem.Qbn079iofF2QlHBvT5P((object) codeStatementList);
label_5:
      try
      {
label_12:
        if (enumerator.MoveNext())
          goto label_7;
        else
          goto label_13;
label_6:
        DesignerParameterInfo current;
        int num2;
        while (true)
        {
          CodeAssignStatement codeAssignStatement;
          switch (num2)
          {
            case 1:
              if (!CreateEntityCodeItem.RnIVInSzQhlWWHtshdS((object) current))
              {
                num2 = 6;
                continue;
              }
              break;
            case 2:
              codeStatementList.Add((CodeStatement) codeAssignStatement);
              num2 = 3;
              continue;
            case 3:
            case 6:
              goto label_12;
            case 4:
              goto label_7;
            case 5:
              goto label_3;
          }
          codeAssignStatement = new CodeAssignStatement((CodeExpression) new CodeSnippetExpression((string) CreateEntityCodeItem.El8njXiBwWXW9EExWTV(CreateEntityCodeItem.v44IBiScQ0PBqFpaTBZ(-787452571 ^ -787468441), (object) variableName, CreateEntityCodeItem.kwqoAQiFQOA09HwTXGb((object) current))), (CodeExpression) new CodeSnippetExpression((string) CreateEntityCodeItem.RSZogLiW2v8UrcPbaG3(CreateEntityCodeItem.v44IBiScQ0PBqFpaTBZ(-1998538950 ^ -1998523216), (object) current.SelectedValueName)));
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 2;
        }
label_7:
        current = enumerator.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
        {
          num2 = 1;
          goto label_6;
        }
        else
          goto label_6;
label_13:
        num2 = 5;
        goto label_6;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    public override CodeExpression ToCodeExpression() => (CodeExpression) null;

    public override CodeStatement[] ToCodeStatementList()
    {
      int num1 = 20;
      List<CodeStatement> codeStatementList;
      while (true)
      {
        int num2 = num1;
        CodeCommentStatement commentStatement;
        string str;
        CodeExpression initExpression;
        CodeMethodInvokeExpression expression;
        string variableName;
        while (true)
        {
          switch (num2)
          {
            case 1:
              codeStatementList.AddRange((IEnumerable<CodeStatement>) this.GetPropertiesStatements(str));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 15 : 13;
              continue;
            case 2:
              codeStatementList.Add((CodeStatement) commentStatement);
              num2 = 5;
              continue;
            case 3:
            case 11:
              variableName = (string) CreateEntityCodeItem.qRN7VpibJIsJnFpdo6T((object) this.VariableCodeItemToolBoxItem);
              num2 = 8;
              continue;
            case 4:
              initExpression = (CodeExpression) CreateEntityCodeItem.LvcmkViEIoDo4jreHLU((object) this.VariableCodeItemToolBoxItem);
              num2 = 9;
              continue;
            case 5:
              expression = new CodeMethodInvokeExpression((CodeExpression) new CodeVariableReferenceExpression(variableName), (string) CreateEntityCodeItem.v44IBiScQ0PBqFpaTBZ(-2107978722 ^ -2107994424), Array.Empty<CodeExpression>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 17 : 8;
              continue;
            case 6:
              codeStatementList.Add((CodeStatement) new CodeSnippetStatement());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 7;
              continue;
            case 7:
            case 10:
              goto label_15;
            case 8:
              codeStatementList.Add((CodeStatement) new CodeSnippetStatement());
              num2 = 22;
              continue;
            case 9:
              codeStatementList.Add((CodeStatement) new CodeSnippetStatement());
              num2 = 13;
              continue;
            case 12:
              codeStatementList.Add((CodeStatement) new CodeVariableDeclarationStatement(new CodeTypeReference((string) CreateEntityCodeItem.v44IBiScQ0PBqFpaTBZ(-882126494 ^ -882141898)), str, initExpression));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 0;
              continue;
            case 13:
              codeStatementList.Add((CodeStatement) new CodeCommentStatement(EleWise.ELMA.SR.T((string) CreateEntityCodeItem.v44IBiScQ0PBqFpaTBZ(-1921202237 ^ -1921214703), (object) str)));
              num2 = 12;
              continue;
            case 14:
              str = (string) CreateEntityCodeItem.RSZogLiW2v8UrcPbaG3(CreateEntityCodeItem.v44IBiScQ0PBqFpaTBZ(-1822890472 ^ -1822902614), CreateEntityCodeItem.Ae9LhkiG5U55ppSw3AD(CreateEntityCodeItem.ver0mGihWaYNOiAvN4i(CreateEntityCodeItem.qRN7VpibJIsJnFpdo6T((object) this.VariableCodeItemToolBoxItem), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173636351), (object) "")));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 4 : 0;
              continue;
            case 15:
              codeStatementList.Add((CodeStatement) new CodeCommentStatement(EleWise.ELMA.SR.T((string) CreateEntityCodeItem.v44IBiScQ0PBqFpaTBZ(-420743386 ^ -420764102), (object) this.VariableCodeItemToolBoxItem.DisplayName)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
              continue;
            case 16:
              goto label_4;
            case 17:
              codeStatementList.Add((CodeStatement) new CodeExpressionStatement((CodeExpression) expression));
              num2 = 21;
              continue;
            case 18:
              codeStatementList.Add((CodeStatement) new CodeAssignStatement((CodeExpression) new CodeVariableReferenceExpression(this.VariableCodeItemToolBoxItem.VariableName), (CodeExpression) new CodeVariableReferenceExpression(str)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 6 : 3;
              continue;
            case 19:
              if (!(this.VariableCodeItemToolBoxItem is ContextVariableCodeItemToolBoxItem))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 10 : 11;
                continue;
              }
              goto case 14;
            case 20:
              codeStatementList = new List<CodeStatement>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 19 : 14;
              continue;
            case 21:
              codeStatementList.Add((CodeStatement) new CodeSnippetStatement());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 3 : 10;
              continue;
            case 22:
              codeStatementList.AddRange((IEnumerable<CodeStatement>) this.GetPropertiesStatements(variableName));
              num2 = 16;
              continue;
            default:
              codeStatementList.Add((CodeStatement) new CodeExpressionStatement((CodeExpression) new CodeMethodInvokeExpression((CodeExpression) new CodeVariableReferenceExpression(str), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173631639), Array.Empty<CodeExpression>())));
              num2 = 18;
              continue;
          }
        }
label_4:
        commentStatement = new CodeCommentStatement(EleWise.ELMA.SR.T((string) CreateEntityCodeItem.v44IBiScQ0PBqFpaTBZ(~289714581 ^ -289726602), CreateEntityCodeItem.rsNjeNifI66GvmRLs8H((object) this.VariableCodeItemToolBoxItem)));
        num1 = 2;
      }
label_15:
      return (CodeStatement[]) CreateEntityCodeItem.Qbn079iofF2QlHBvT5P((object) codeStatementList);
    }

    public override List<Type> GetValidToInsert() => new List<Type>()
    {
      typeof (VariableCodeItem),
      typeof (MathCodeItem),
      typeof (ExactValueCodeItem)
    };

    public override bool IsValidChild(ICodeItem codeItem) => codeItem is VariableCodeItem;

    internal static void YDLe35Ss468pbj54hB1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool cohd6oSLbEnm6AVcMeJ() => CreateEntityCodeItem.op6QvWSYx6QFOSOqhmJ == null;

    internal static CreateEntityCodeItem wQJ4NQSUiWMeXx8g3yI() => CreateEntityCodeItem.op6QvWSYx6QFOSOqhmJ;

    internal static object v44IBiScQ0PBqFpaTBZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool RnIVInSzQhlWWHtshdS([In] object obj0) => ((DesignerParameterInfo) obj0).IsSelected;

    internal static object kwqoAQiFQOA09HwTXGb([In] object obj0) => (object) ((DesignerParameterInfo) obj0).ParameterName;

    internal static object El8njXiBwWXW9EExWTV([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object RSZogLiW2v8UrcPbaG3([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object Qbn079iofF2QlHBvT5P([In] object obj0) => (object) ((List<CodeStatement>) obj0).ToArray();

    internal static object qRN7VpibJIsJnFpdo6T([In] object obj0) => (object) ((NewCodeItemToolBoxItem) obj0).VariableName;

    internal static object ver0mGihWaYNOiAvN4i([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object Ae9LhkiG5U55ppSw3AD([In] object obj0) => (object) ((string) obj0).ToLowerFirstChar();

    internal static object LvcmkViEIoDo4jreHLU([In] object obj0) => (object) CodeItemCodeGenerator.GetInitExpressionByType((NewCodeItemToolBoxItem) obj0);

    internal static object rsNjeNifI66GvmRLs8H([In] object obj0) => (object) ((NewCodeItemToolBoxItem) obj0).DisplayName;

    internal class ResourcesCreateEntityCodeItem
    {
      internal static CreateEntityCodeItem.ResourcesCreateEntityCodeItem ovMxLafxkihdkyu38qxo;

      public static string DisplayName => (string) CreateEntityCodeItem.ResourcesCreateEntityCodeItem.lWBUcmfxeEN9bb0Ccg0j(CreateEntityCodeItem.ResourcesCreateEntityCodeItem.vXFThGfx27RBbCoYBZym(-1380439818 << 3 ^ 1841570722));

      public ResourcesCreateEntityCodeItem()
      {
        CreateEntityCodeItem.ResourcesCreateEntityCodeItem.b6Sg2CfxPKMl048APY6u();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object vXFThGfx27RBbCoYBZym(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object lWBUcmfxeEN9bb0Ccg0j([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool vOeNElfxnvqxFx50hLUk() => CreateEntityCodeItem.ResourcesCreateEntityCodeItem.ovMxLafxkihdkyu38qxo == null;

      internal static CreateEntityCodeItem.ResourcesCreateEntityCodeItem s6CusFfxOEHnRhqWGCBN() => CreateEntityCodeItem.ResourcesCreateEntityCodeItem.ovMxLafxkihdkyu38qxo;

      internal static void b6Sg2CfxPKMl048APY6u() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
