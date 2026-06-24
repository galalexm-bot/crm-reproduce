// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.IterationCodeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.ScriptDesigner.Enums;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using EleWise.ELMA.ScriptDesigner.TranslateData;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  [DisplayName(typeof (ResourcesForeachCodeItem), "DisplayName")]
  [Serializable]
  public class IterationCodeItem : CompositeCodeItem
  {
    private static IterationCodeItem MFUINhi9HHZ8On8yrVJ;

    public IterationCodeItem()
    {
      IterationCodeItem.pTjrPOir8VrkZDxgnhZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.CycleType = CycleType.NotSelected;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public VariableCodeItem LocalVariableCodeItem
    {
      get => this.\u003CLocalVariableCodeItem\u003Ek__BackingField;
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
              this.\u003CLocalVariableCodeItem\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

    public CycleType CycleType
    {
      get => this.\u003CCycleType\u003Ek__BackingField;
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
              this.\u003CCycleType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
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

    public CodeItem CollectionVariableCodeItem
    {
      get => this.\u003CCollectionVariableCodeItem\u003Ek__BackingField;
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
              this.\u003CCollectionVariableCodeItem\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
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

    public VariableCodeItemToolBoxItem LocalVariableCodeItemPoint
    {
      get => this.\u003CLocalVariableCodeItemPoint\u003Ek__BackingField;
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
              this.\u003CLocalVariableCodeItemPoint\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
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
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (compositeCodeItem is IfCodeItem)
            {
              num = 4;
              continue;
            }
            goto case 3;
          case 2:
            if (!(compositeCodeItem is RootCodeItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          case 3:
            if (!(compositeCodeItem is ElseCodeItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 4:
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return compositeCodeItem is IterationCodeItem;
label_5:
      return true;
    }

    public override CodeStatement ToCodeStatement()
    {
      int num1 = 8;
      CodeIterationStatement codeStatement1;
      while (true)
      {
        int num2 = num1;
        string str;
        while (true)
        {
          VariableCodeItem variableCodeItem1;
          VariableCodeItem variableCodeItem2;
          List<CodeItem>.Enumerator enumerator;
          string randomName;
          CodeExpressionStatement expressionStatement;
          switch (num2)
          {
            case 1:
              if (this.LocalVariableCodeItem != null)
              {
                num2 = 19;
                continue;
              }
              goto label_78;
            case 2:
              IterationCodeItem.X0jVjPij3VwiwFp4ib8(IterationCodeItem.sjaAMwi5ROLFd55nPnR((object) codeStatement1), (object) expressionStatement);
              num2 = 14;
              continue;
            case 3:
              if (this.CycleType == CycleType.Foreach)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 9 : 17;
                continue;
              }
              break;
            case 4:
label_82:
              IterationCodeItem.Y4eG4iiUwvyj39dNJ1Q((object) codeStatement1, (object) new CodeExpressionStatement((CodeExpression) new CodeSnippetExpression()));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 25 : 7;
              continue;
            case 5:
              if (variableCodeItem1 != null)
              {
                num2 = 29;
                continue;
              }
              break;
            case 6:
              IterationCodeItem.iqQ7MlizDsOJ6BAe3tx((object) codeStatement1, (object) this.CollectionVariableCodeItem.ToCodeExpression());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 23 : 4;
              continue;
            case 7:
              if (this.CycleType == CycleType.For)
              {
                num2 = 9;
                continue;
              }
              goto case 3;
            case 8:
              goto label_49;
            case 9:
              if (this.CollectionVariableCodeItem != null)
              {
                num2 = 33;
                continue;
              }
              goto label_8;
            case 10:
              IterationCodeItem.iqQ7MlizDsOJ6BAe3tx((object) codeStatement1, (object) new CodeSnippetExpression((string) IterationCodeItem.rwTLV1icg9ToeLSFghw(IterationCodeItem.cAbZ4DiYYwxX0QVO00B(132912447 ^ 132924583), (object) randomName, (object) variableCodeItem2.VariableName)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 10 : 12;
              continue;
            case 11:
              goto label_31;
            case 12:
              goto label_7;
            case 13:
              IterationCodeItem.vddaGcisuMtGHY4xfiD((object) codeStatement1, (object) new CodeExpressionStatement((CodeExpression) new CodeSnippetExpression((string) IterationCodeItem.FR5txLiLwEDCUVvhCvn(IterationCodeItem.cAbZ4DiYYwxX0QVO00B(-1872275253 >> 6 ^ -29242339), (object) randomName))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 4 : 10;
              continue;
            case 14:
              enumerator = this.Items.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 21 : 11;
              continue;
            case 15:
              goto label_68;
            case 16:
              goto label_77;
            case 17:
              if (this.CollectionVariableCodeItem != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 1;
                continue;
              }
              goto label_78;
            case 18:
label_65:
              if (this.CollectionVariableCodeItem != null)
              {
                num2 = 20;
                continue;
              }
              goto label_30;
            case 19:
              str = (string) IterationCodeItem.yPcU5QRFvXJcMUFPqGV();
              num2 = 30;
              continue;
            case 20:
              enumerator = this.Items.GetEnumerator();
              num2 = 28;
              continue;
            case 21:
              try
              {
label_13:
                if (enumerator.MoveNext())
                  goto label_15;
                else
                  goto label_14;
label_12:
                CodeStatement codeStatement2;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      IterationCodeItem.X0jVjPij3VwiwFp4ib8(IterationCodeItem.sjaAMwi5ROLFd55nPnR((object) codeStatement1), (object) codeStatement2);
                      num3 = 2;
                      continue;
                    case 2:
                    case 4:
                      goto label_13;
                    case 3:
                      if (codeStatement2 == null)
                      {
                        num3 = 4;
                        continue;
                      }
                      goto case 1;
                    case 5:
                      goto label_15;
                    default:
                      goto label_82;
                  }
                }
label_14:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                goto label_12;
label_15:
                codeStatement2 = (CodeStatement) IterationCodeItem.j3VtiDigHLMi7xuKbFl((object) enumerator.Current);
                num3 = 3;
                goto label_12;
              }
              finally
              {
                enumerator.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 22:
              IterationCodeItem.vddaGcisuMtGHY4xfiD((object) codeStatement1, (object) new CodeExpressionStatement((CodeExpression) new CodeSnippetExpression()));
              num2 = 6;
              continue;
            case 23:
              goto label_29;
            case 24:
              if (variableCodeItem2 == null)
              {
                num2 = 3;
                continue;
              }
              goto case 26;
            case 25:
              IterationCodeItem.vddaGcisuMtGHY4xfiD((object) codeStatement1, (object) new CodeExpressionStatement((CodeExpression) new CodeSnippetExpression((string) IterationCodeItem.rwTLV1icg9ToeLSFghw((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309651872), (object) str, IterationCodeItem.OLe1sRRWBrTpvJiQ8OU((object) variableCodeItem1)))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 15 : 5;
              continue;
            case 26:
              enumerator = this.Items.GetEnumerator();
              num2 = 32;
              continue;
            case 27:
label_84:
              IterationCodeItem.Y4eG4iiUwvyj39dNJ1Q((object) codeStatement1, (object) new CodeExpressionStatement((CodeExpression) new CodeSnippetExpression((string) IterationCodeItem.FR5txLiLwEDCUVvhCvn(IterationCodeItem.cAbZ4DiYYwxX0QVO00B(712480695 ^ 712492743), (object) randomName))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 13 : 11;
              continue;
            case 28:
              try
              {
label_54:
                if (enumerator.MoveNext())
                  goto label_57;
                else
                  goto label_55;
label_51:
                CodeStatement codeStatement3;
                int num5;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      if (codeStatement3 != null)
                      {
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 2 : 0;
                        continue;
                      }
                      goto label_54;
                    case 2:
                      IterationCodeItem.X0jVjPij3VwiwFp4ib8(IterationCodeItem.sjaAMwi5ROLFd55nPnR((object) codeStatement1), (object) codeStatement3);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 4 : 4;
                      continue;
                    case 3:
                      goto label_76;
                    case 4:
                      goto label_54;
                    default:
                      goto label_57;
                  }
                }
label_55:
                num5 = 3;
                goto label_51;
label_57:
                codeStatement3 = enumerator.Current.ToCodeStatement();
                num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
                {
                  num5 = 1;
                  goto label_51;
                }
                else
                  goto label_51;
              }
              finally
              {
                enumerator.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 29:
              expressionStatement = new CodeExpressionStatement((CodeExpression) new CodeSnippetExpression(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477152140), (object) IterationCodeItem.GRSocfRBuR4QcuvCO9w((object) this.LocalVariableCodeItem).FullName, (object) this.LocalVariableCodeItem.VariableName, (object) str)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 2;
              continue;
            case 30:
              variableCodeItem1 = this.CollectionVariableCodeItem as VariableCodeItem;
              num2 = 5;
              continue;
            case 31:
label_76:
              codeStatement1.IncrementStatement = (CodeStatement) new CodeExpressionStatement((CodeExpression) new CodeSnippetExpression());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 22 : 13;
              continue;
            case 32:
              try
              {
label_41:
                if (enumerator.MoveNext())
                  goto label_39;
                else
                  goto label_42;
label_36:
                CodeStatement codeStatement4;
                int num7;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      goto label_84;
                    case 2:
                      goto label_39;
                    case 3:
                      IterationCodeItem.X0jVjPij3VwiwFp4ib8(IterationCodeItem.sjaAMwi5ROLFd55nPnR((object) codeStatement1), (object) codeStatement4);
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                      continue;
                    case 4:
                      if (codeStatement4 != null)
                      {
                        num7 = 3;
                        continue;
                      }
                      goto label_41;
                    default:
                      goto label_41;
                  }
                }
label_39:
                codeStatement4 = (CodeStatement) IterationCodeItem.j3VtiDigHLMi7xuKbFl((object) enumerator.Current);
                num7 = 4;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                {
                  num7 = 3;
                  goto label_36;
                }
                else
                  goto label_36;
label_42:
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                goto label_36;
              }
              finally
              {
                enumerator.Dispose();
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
                  num8 = 0;
                switch (num8)
                {
                  default:
                }
              }
            case 33:
              randomName = CodeItemCodeGenerator.GetRandomName();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
              continue;
            default:
              variableCodeItem2 = this.CollectionVariableCodeItem as VariableCodeItem;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 24;
              continue;
          }
          if (this.CycleType == CycleType.While)
            goto label_65;
          else
            goto label_80;
        }
label_49:
        codeStatement1 = new CodeIterationStatement();
        num1 = 7;
        continue;
label_68:
        IterationCodeItem.iqQ7MlizDsOJ6BAe3tx((object) codeStatement1, (object) new CodeSnippetExpression(string.Format((string) IterationCodeItem.cAbZ4DiYYwxX0QVO00B(-244066886 - -48452443 ^ -195593457), (object) str)));
        num1 = 16;
        continue;
label_80:
        num1 = 11;
      }
label_7:
      return (CodeStatement) codeStatement1;
label_8:
      return (CodeStatement) null;
label_29:
      return (CodeStatement) codeStatement1;
label_30:
      return (CodeStatement) null;
label_31:
      return (CodeStatement) null;
label_77:
      return (CodeStatement) codeStatement1;
label_78:
      return (CodeStatement) null;
    }

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
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!(codeItem is IfCodeItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_6;
          default:
            if (!(codeItem is AssignCodeItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 0;
              continue;
            }
            goto label_7;
        }
      }
label_6:
      return codeItem is IterationCodeItem;
label_7:
      return true;
    }

    internal static void pTjrPOir8VrkZDxgnhZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool H72nRGidN6Ml4BrS2ek() => IterationCodeItem.MFUINhi9HHZ8On8yrVJ == null;

    internal static IterationCodeItem AlOlcnil6ybXnw7QLhi() => IterationCodeItem.MFUINhi9HHZ8On8yrVJ;

    internal static object j3VtiDigHLMi7xuKbFl([In] object obj0) => (object) ((CodeItem) obj0).ToCodeStatement();

    internal static object sjaAMwi5ROLFd55nPnR([In] object obj0) => (object) ((CodeIterationStatement) obj0).Statements;

    internal static int X0jVjPij3VwiwFp4ib8([In] object obj0, [In] object obj1) => ((CodeStatementCollection) obj0).Add((CodeStatement) obj1);

    internal static object cAbZ4DiYYwxX0QVO00B(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object FR5txLiLwEDCUVvhCvn([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void Y4eG4iiUwvyj39dNJ1Q([In] object obj0, [In] object obj1) => ((CodeIterationStatement) obj0).IncrementStatement = (CodeStatement) obj1;

    internal static void vddaGcisuMtGHY4xfiD([In] object obj0, [In] object obj1) => ((CodeIterationStatement) obj0).InitStatement = (CodeStatement) obj1;

    internal static object rwTLV1icg9ToeLSFghw([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static void iqQ7MlizDsOJ6BAe3tx([In] object obj0, [In] object obj1) => ((CodeIterationStatement) obj0).TestExpression = (CodeExpression) obj1;

    internal static object yPcU5QRFvXJcMUFPqGV() => (object) CodeItemCodeGenerator.GetRandomName();

    internal static Type GRSocfRBuR4QcuvCO9w([In] object obj0) => ((VariableCodeItem) obj0).VariableType;

    internal static object OLe1sRRWBrTpvJiQ8OU([In] object obj0) => (object) ((VariableCodeItem) obj0).VariableName;

    [Component(Order = 54)]
    private class ToolboxItem : CyclesCodeItemToolBoxItem<IterationCodeItem>
    {
      internal static object FTy9JIfxmgCkyq0SlbVw;

      public ToolboxItem()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.ToolTipBody = (string) IterationCodeItem.ToolboxItem.GJU96ofx9dxe92k75NkF(IterationCodeItem.ToolboxItem.G3SVDsfxJiumDysDn2eN(-1426456882 ^ 2009939514 ^ -583949198));
              num = 2;
              continue;
            case 2:
              this.ToolTipHeader = EleWise.ELMA.SR.T((string) IterationCodeItem.ToolboxItem.G3SVDsfxJiumDysDn2eN(-70007027 ^ -70019785));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:;
      }

      internal static object G3SVDsfxJiumDysDn2eN(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object GJU96ofx9dxe92k75NkF([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool oVC70Efxy2ek4ufS75y5() => IterationCodeItem.ToolboxItem.FTy9JIfxmgCkyq0SlbVw == null;

      internal static IterationCodeItem.ToolboxItem vHStnFfxMXdvZ8O34lSl() => (IterationCodeItem.ToolboxItem) IterationCodeItem.ToolboxItem.FTy9JIfxmgCkyq0SlbVw;
    }
  }
}
