// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.ExactValueCodeItem
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
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  /// <summary>Точное значение</summary>
  [DisplayName(typeof (ResourcesExactValueCodeItem), "DisplayName")]
  [Serializable]
  public class ExactValueCodeItem : CodeItem
  {
    internal static ExactValueCodeItem PW1M7ERTIedSmjiT238;

    public ExactValueCodeItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Value = (object) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public object Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
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
              this.\u003CValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
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

    public MathConstantDesignerType DesignerType
    {
      get => this.\u003CDesignerType\u003Ek__BackingField;
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
              this.\u003CDesignerType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
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

    [XmlIgnore]
    public Type LeftOperatorType
    {
      get => this.\u003CLeftOperatorType\u003Ek__BackingField;
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
              this.\u003CLeftOperatorType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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

    public string LeftOperatorTypeName
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (ExactValueCodeItem.OpfwO6ROq3bFx5VlRoU(this.LeftOperatorType, (Type) null))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
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
        return (string) null;
label_5:
        return this.LeftOperatorType.AssemblyQualifiedName;
      }
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
              this.LeftOperatorType = value != null ? ExactValueCodeItem.DvoxJcR2AA2q1JZkdNb((object) value) : (Type) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
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
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (codeItem is AssignCodeItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            if (codeItem is ConditionCodeItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 3 : 1;
              continue;
            }
            goto label_6;
          case 4:
            goto label_6;
          default:
            goto label_7;
        }
      }
label_6:
      return codeItem is MathCodeItem;
label_7:
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
            expression = (CodeExpression) ExactValueCodeItem.VvduyXReZquaObtcMIU((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (expression != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 2;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      return (CodeStatement) new CodeExpressionStatement(expression);
label_6:
      return (CodeStatement) null;
    }

    public override CodeExpression ToCodeExpression()
    {
      int num1 = 7;
      DateTime dateTime;
      double result1;
      long result2;
      long num2;
      while (true)
      {
        int num3 = num1;
        string s1;
        while (true)
        {
          string decimalSeparator;
          object s2;
          object s3;
          switch (num3)
          {
            case 1:
              goto label_9;
            case 2:
              s2 = ExactValueCodeItem.hn7SynRPgVQjv8PDSJl(1642859704 ^ 1642861364);
              goto label_51;
            case 3:
              if (!ExactValueCodeItem.UWhu2oR3gUoodEVMLr3((object) s1, ExactValueCodeItem.hn7SynRPgVQjv8PDSJl(1470440286 ^ 1470445978)))
              {
                num3 = 21;
                continue;
              }
              goto case 26;
            case 4:
            case 16:
              goto label_36;
            case 5:
              s3 = ExactValueCodeItem.hn7SynRPgVQjv8PDSJl(-2107978722 ^ -2107976814);
              break;
            case 6:
              if (this.Value == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 5;
                continue;
              }
              goto case 25;
            case 7:
              if (this.DesignerType != MathConstantDesignerType.DateTime)
              {
                if (this.DesignerType == MathConstantDesignerType.LoadOrNull)
                {
                  num3 = 17;
                  continue;
                }
                if (this.DesignerType != MathConstantDesignerType.String)
                {
                  if (this.DesignerType == MathConstantDesignerType.Digit)
                  {
                    num3 = 18;
                    continue;
                  }
                  if (this.DesignerType == MathConstantDesignerType.Bool)
                  {
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 20;
                    continue;
                  }
                  goto label_43;
                }
                else
                  goto label_46;
              }
              else
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 3 : 6;
                continue;
              }
            case 8:
              s2 = (object) this.Value.ToString();
              goto label_51;
            case 9:
              goto label_33;
            case 10:
              double.TryParse((string) ExactValueCodeItem.HGowrBRDVdjim1dZ0e8(ExactValueCodeItem.HGowrBRDVdjim1dZ0e8((object) s1, ExactValueCodeItem.hn7SynRPgVQjv8PDSJl(1113862659 ^ 1113874675), (object) decimalSeparator), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978480074), (object) decimalSeparator), out result1);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
              continue;
            case 11:
              goto label_42;
            case 12:
              goto label_17;
            case 13:
              goto label_52;
            case 14:
              if (this.Value == null)
              {
                num3 = 12;
                continue;
              }
              goto label_18;
            case 15:
              if (this.Value.ToString() == EleWise.ELMA.SR.T((string) ExactValueCodeItem.hn7SynRPgVQjv8PDSJl(1021410165 ^ 1021389187)))
              {
                num3 = 16;
                continue;
              }
              goto case 19;
            case 17:
              if (this.Value == null)
              {
                num3 = 2;
                continue;
              }
              goto case 8;
            case 18:
              if (this.Value == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 6 : 13;
                continue;
              }
              goto label_6;
            case 19:
              if (ExactValueCodeItem.Pt80PwRwWVMXH69Rp0Q((object) this.Value.ToString(), ExactValueCodeItem.LYPPjpRt9Q1aedlQkGS(ExactValueCodeItem.hn7SynRPgVQjv8PDSJl(1819636893 << 3 ^ 1672187244))))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 4;
                continue;
              }
              if (ExactValueCodeItem.Pt80PwRwWVMXH69Rp0Q((object) this.Value.ToString(), ExactValueCodeItem.LYPPjpRt9Q1aedlQkGS(ExactValueCodeItem.hn7SynRPgVQjv8PDSJl(132912447 ^ 132922435))))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 7 : 11;
                continue;
              }
              goto label_43;
            case 20:
              goto label_4;
            case 21:
              long.TryParse(s1, out result2);
              num3 = 9;
              continue;
            case 22:
              if (!ExactValueCodeItem.UWhu2oR3gUoodEVMLr3((object) s1, ExactValueCodeItem.hn7SynRPgVQjv8PDSJl(323422137 << 2 ^ 1293700116)))
              {
                num3 = 3;
                continue;
              }
              goto case 26;
            case 23:
              goto label_44;
            case 24:
              goto label_6;
            case 25:
              s3 = (object) this.Value.ToString();
              break;
            case 26:
              decimalSeparator = ((NumberFormatInfo) ExactValueCodeItem.aL2dlERa3xEL9GvpgNK(ExactValueCodeItem.sldbqURp9ksv5vp7fmT())).CurrencyDecimalSeparator;
              num3 = 10;
              continue;
            default:
              goto label_14;
          }
          ref DateTime local1 = ref dateTime;
          DateTime.TryParse((string) s3, out local1);
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 1 : 1;
          continue;
label_51:
          ref long local2 = ref num2;
          long.TryParse((string) s2, out local2);
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 23 : 15;
        }
label_4:
        if (this.Value != null)
        {
          num1 = 15;
          continue;
        }
        goto label_36;
label_6:
        object obj = (object) this.Value.ToString();
        goto label_53;
label_46:
        num1 = 14;
        continue;
label_52:
        obj = ExactValueCodeItem.hn7SynRPgVQjv8PDSJl(516838154 ^ 516836486);
label_53:
        s1 = (string) obj;
        num1 = 22;
      }
label_9:
      // ISSUE: type reference
      return (CodeExpression) new CodeObjectCreateExpression(ExactValueCodeItem.tdXdSUR1xhAPn81kToL(__typeref (DateTime)), new CodeExpression[7]
      {
        (CodeExpression) new CodePrimitiveExpression((object) dateTime.Year),
        (CodeExpression) new CodePrimitiveExpression((object) dateTime.Month),
        (CodeExpression) new CodePrimitiveExpression((object) dateTime.Day),
        (CodeExpression) new CodePrimitiveExpression((object) dateTime.Hour),
        (CodeExpression) new CodePrimitiveExpression((object) dateTime.Minute),
        (CodeExpression) new CodePrimitiveExpression((object) dateTime.Second),
        (CodeExpression) new CodePrimitiveExpression((object) dateTime.Millisecond)
      });
label_14:
      return (CodeExpression) new CodePrimitiveExpression((object) result1);
label_17:
      return (CodeExpression) new CodePrimitiveExpression((object) "");
label_18:
      return (CodeExpression) new CodePrimitiveExpression((object) this.Value.ToString());
label_33:
      return (CodeExpression) new CodePrimitiveExpression((object) result2);
label_36:
      return (CodeExpression) new CodePrimitiveExpression((object) false);
label_42:
      return (CodeExpression) new CodePrimitiveExpression((object) true);
label_43:
      return (CodeExpression) null;
label_44:
      return (CodeExpression) new CodeSnippetExpression((string) ExactValueCodeItem.dH1Ps0RN0reHEn1Bicl(ExactValueCodeItem.hn7SynRPgVQjv8PDSJl(~541731958 ^ -541753085), (object) this.LeftOperatorType.ToString(), (object) num2));
    }

    public override CodeStatement[] ToCodeStatementList() => (CodeStatement[]) null;

    public override List<Type> GetValidToInsert() => (List<Type>) null;

    internal static bool wfcrvcRkShtvCxpKcdU() => ExactValueCodeItem.PW1M7ERTIedSmjiT238 == null;

    internal static ExactValueCodeItem C4mVyiRnQn6n1DxK38t() => ExactValueCodeItem.PW1M7ERTIedSmjiT238;

    internal static bool OpfwO6ROq3bFx5VlRoU([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static Type DvoxJcR2AA2q1JZkdNb([In] object obj0) => Type.GetType((string) obj0);

    internal static object VvduyXReZquaObtcMIU([In] object obj0) => (object) ((CodeItem) obj0).ToCodeExpression();

    internal static object hn7SynRPgVQjv8PDSJl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type tdXdSUR1xhAPn81kToL([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object dH1Ps0RN0reHEn1Bicl([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static bool UWhu2oR3gUoodEVMLr3([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static object sldbqURp9ksv5vp7fmT() => (object) CultureInfo.CurrentCulture;

    internal static object aL2dlERa3xEL9GvpgNK([In] object obj0) => (object) ((CultureInfo) obj0).NumberFormat;

    internal static object HGowrBRDVdjim1dZ0e8([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object LYPPjpRt9Q1aedlQkGS([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool Pt80PwRwWVMXH69Rp0Q([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    [Component(Order = 58)]
    private class ToolboxItem : MathCodeItemToolBoxItem<ExactValueCodeItem>
    {
      private static object gw2DXEfxjxRFoYniasn6;

      public ToolboxItem()
      {
        ExactValueCodeItem.ToolboxItem.meofNIfxUhEZ99w5J8Q5();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void meofNIfxUhEZ99w5J8Q5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool HY4ouDfxYVaWUuE8ZnFR() => ExactValueCodeItem.ToolboxItem.gw2DXEfxjxRFoYniasn6 == null;

      internal static ExactValueCodeItem.ToolboxItem Df7DS3fxLltQ1xNH0peH() => (ExactValueCodeItem.ToolboxItem) ExactValueCodeItem.ToolboxItem.gw2DXEfxjxRFoYniasn6;
    }
  }
}
