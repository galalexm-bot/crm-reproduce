// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.CodeItems.IfCodeItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ScriptDesigner.CodeItems
{
  /// <summary>Оператор IF</summary>
  [DisplayName(typeof (ResourcesIfCodeItem), "DisplayName")]
  [Serializable]
  public class IfCodeItem : CompositeCodeItem
  {
    internal static IfCodeItem r0gQWeRd2e3frMJmxD3;

    public IfCodeItem()
    {
      IfCodeItem.glLpZuRgTvGtE26ndtt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ElseCodeItem Else
    {
      get => this.\u003CElse\u003Ek__BackingField;
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
              this.\u003CElse\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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
            if (!(compositeCodeItem is IfCodeItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 2:
            if (!(compositeCodeItem is RootCodeItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
              continue;
            }
            goto label_9;
          case 3:
            goto label_8;
          case 4:
            goto label_9;
          default:
            if (compositeCodeItem is ElseCodeItem)
            {
              num = 4;
              continue;
            }
            goto label_8;
        }
      }
label_8:
      return compositeCodeItem is IterationCodeItem;
label_9:
      return true;
    }

    public override CodeStatement ToCodeStatement()
    {
      int num1 = 18;
      List<CodeItem>.Enumerator enumerator1;
      List<CodeStatement> codeStatementList1;
      IEnumerator<CodeItem> enumerator2;
      List<CodeStatement> codeStatementList2;
      CodeItem conditionItem;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
label_23:
              if (IfCodeItem.YBHw2QRL2aJ8UV3HaB6((object) enumerator2))
                goto label_26;
              else
                goto label_24;
label_20:
              CodeStatement[] collection;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_23;
                  case 2:
                    goto label_46;
                  case 3:
                    codeStatementList2.AddRange((IEnumerable<CodeStatement>) collection);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
                    continue;
                  case 4:
                    if (collection != null)
                    {
                      num2 = 3;
                      continue;
                    }
                    goto label_23;
                  default:
                    goto label_26;
                }
              }
label_24:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 2 : 0;
              goto label_20;
label_26:
              CodeItem current = enumerator2.Current;
              CodeStatement codeStatement = (CodeStatement) IfCodeItem.PGiHZhRjqEeuMDCmKf7((object) current);
              if (codeStatement != null)
                codeStatementList2.Add(codeStatement);
              collection = (CodeStatement[]) IfCodeItem.W5ArfIRYHe3lTZgGgjT((object) current);
              num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
              {
                num2 = 4;
                goto label_20;
              }
              else
                goto label_20;
            }
            finally
            {
              if (enumerator2 != null)
              {
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
                  num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      IfCodeItem.RcNHkDRU9Sd70mJsfyq((object) enumerator2);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_35;
                  }
                }
              }
label_35:;
            }
          case 2:
            if (IfCodeItem.JClpVmRsLMyRCR3yKPp((object) codeStatementList1) == 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 3 : 5;
              continue;
            }
            goto label_49;
          case 3:
            codeStatementList2.Add((CodeStatement) new CodeSnippetStatement(""));
            num1 = 4;
            continue;
          case 4:
            if (this.Else == null)
            {
              num1 = 7;
              continue;
            }
            goto case 2;
          case 5:
            codeStatementList1.Add((CodeStatement) new CodeSnippetStatement(""));
            num1 = 6;
            continue;
          case 6:
          case 7:
            goto label_49;
          case 8:
            if (this.Else.Items.Any<CodeItem>())
            {
              num1 = 9;
              continue;
            }
            goto case 12;
          case 9:
            enumerator1 = this.Else.Items.GetEnumerator();
            num1 = 11;
            continue;
          case 10:
            enumerator2 = this.Items.Where<CodeItem>((Func<CodeItem, bool>) (a => a != conditionItem)).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
            continue;
          case 11:
            try
            {
label_4:
              if (enumerator1.MoveNext())
                goto label_9;
              else
                goto label_5;
label_3:
              CodeStatement[] collection;
              int num4;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_4;
                  case 2:
                    goto label_9;
                  case 3:
                    codeStatementList1.AddRange((IEnumerable<CodeStatement>) collection);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
                    continue;
                  case 4:
                    goto label_38;
                  default:
                    if (collection != null)
                    {
                      num4 = 3;
                      continue;
                    }
                    goto label_4;
                }
              }
label_5:
              num4 = 4;
              goto label_3;
label_9:
              CodeItem current = enumerator1.Current;
              CodeStatement codeStatement = (CodeStatement) IfCodeItem.PGiHZhRjqEeuMDCmKf7((object) current);
              if (codeStatement != null)
                codeStatementList1.Add(codeStatement);
              collection = (CodeStatement[]) IfCodeItem.W5ArfIRYHe3lTZgGgjT((object) current);
              num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
              {
                num4 = 0;
                goto label_3;
              }
              else
                goto label_3;
            }
            finally
            {
              enumerator1.Dispose();
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
          case 12:
          case 19:
label_38:
            if (IfCodeItem.JClpVmRsLMyRCR3yKPp((object) codeStatementList2) == 0)
            {
              num1 = 3;
              continue;
            }
            goto case 4;
          case 13:
            if (IfCodeItem.jA4G0xR5NRR80D9yNtx((object) conditionItem) == null)
            {
              num1 = 15;
              continue;
            }
            goto case 10;
          case 14:
            codeStatementList2 = new List<CodeStatement>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 15 : 16;
            continue;
          case 15:
            goto label_50;
          case 16:
            codeStatementList1 = new List<CodeStatement>();
            num1 = 13;
            continue;
          case 17:
            List<CodeItem> items = this.Items;
            // ISSUE: reference to a compiler-generated field
            Func<CodeItem, bool> func = IfCodeItem.\u003C\u003Ec.\u003C\u003E9__7_0;
            Func<CodeItem, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              IfCodeItem.\u003C\u003Ec.\u003C\u003E9__7_0 = predicate = (Func<CodeItem, bool>) (a => a is IfConditionCodeItem);
            }
            else
              goto label_58;
label_56:
            conditionItem = items.FirstOrDefault<CodeItem>(predicate);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 14 : 0;
            continue;
label_58:
            predicate = func;
            goto label_56;
          case 18:
            num1 = 17;
            continue;
          default:
label_46:
            if (this.Else == null)
            {
              num1 = 12;
              continue;
            }
            goto case 8;
        }
      }
label_49:
      return (CodeStatement) new CodeConditionStatement(conditionItem.ToCodeExpression(), (CodeStatement[]) IfCodeItem.ojSnUCRcjZdGKgq89Pr((object) codeStatementList2), (CodeStatement[]) IfCodeItem.ojSnUCRcjZdGKgq89Pr((object) codeStatementList1));
label_50:
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
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 3:
            if (codeItem is IfCodeItem)
            {
              num = 2;
              continue;
            }
            goto case 4;
          case 4:
            if (codeItem is AssignCodeItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return codeItem is IterationCodeItem;
label_5:
      return true;
    }

    public override void InitNew(ICodeItem parent)
    {
      int num = 1;
      IfConditionCodeItem conditionCodeItem;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.InitNew(parent);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            this.Items.Add((CodeItem) conditionCodeItem);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 4 : 4;
            continue;
          case 3:
            conditionCodeItem = new IfConditionCodeItem();
            num = 5;
            continue;
          case 4:
            goto label_8;
          case 5:
            IfCodeItem.yx9pPDRz4KEv9wUwpLO((object) conditionCodeItem, (object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 2;
            continue;
          default:
            List<CodeItem> items = this.Items;
            // ISSUE: reference to a compiler-generated field
            Func<CodeItem, bool> func = IfCodeItem.\u003C\u003Ec.\u003C\u003E9__12_0;
            Func<CodeItem, bool> predicate;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              IfCodeItem.\u003C\u003Ec.\u003C\u003E9__12_0 = predicate = (Func<CodeItem, bool>) (a => a is IfConditionCodeItem);
            }
            else
              goto label_12;
label_10:
            if (!items.Any<CodeItem>(predicate))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 3;
              continue;
            }
            goto label_2;
label_12:
            predicate = func;
            goto label_10;
        }
      }
label_8:
      return;
label_2:;
    }

    internal static void glLpZuRgTvGtE26ndtt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Dus3CLRlcD95HPbJxub() => IfCodeItem.r0gQWeRd2e3frMJmxD3 == null;

    internal static IfCodeItem NvhlerRriHWBmBlfL9i() => IfCodeItem.r0gQWeRd2e3frMJmxD3;

    internal static object jA4G0xR5NRR80D9yNtx([In] object obj0) => (object) ((CodeItem) obj0).ToCodeExpression();

    internal static object PGiHZhRjqEeuMDCmKf7([In] object obj0) => (object) ((CodeItem) obj0).ToCodeStatement();

    internal static object W5ArfIRYHe3lTZgGgjT([In] object obj0) => (object) ((CodeItem) obj0).ToCodeStatementList();

    internal static bool YBHw2QRL2aJ8UV3HaB6([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void RcNHkDRU9Sd70mJsfyq([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static int JClpVmRsLMyRCR3yKPp([In] object obj0) => ((List<CodeStatement>) obj0).Count;

    internal static object ojSnUCRcjZdGKgq89Pr([In] object obj0) => (object) ((List<CodeStatement>) obj0).ToArray();

    internal static void yx9pPDRz4KEv9wUwpLO([In] object obj0, [In] object obj1) => ((CodeItem) obj0).InitNew((ICodeItem) obj1);

    [Component(Order = 53)]
    private class ToolboxItem : LogicalCodeItemToolBoxItem<IfCodeItem>
    {
      internal static object u4mPOtfxshuZk8a5aZVQ;

      public ToolboxItem()
      {
        IfCodeItem.ToolboxItem.BK9DgWf0FJFgV9s7pdgy();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              this.ToolTipBody = (string) IfCodeItem.ToolboxItem.B3lMlHf0WCVUE05PPKrD(IfCodeItem.ToolboxItem.GIG9ahf0B4UfF0UKl0aj(-1710575414 ^ -1710238256));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            default:
              this.ToolTipHeader = (string) IfCodeItem.ToolboxItem.B3lMlHf0WCVUE05PPKrD(IfCodeItem.ToolboxItem.GIG9ahf0B4UfF0UKl0aj(1819636893 << 3 ^ 1672214464));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
              continue;
          }
        }
label_2:;
      }

      internal static void BK9DgWf0FJFgV9s7pdgy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object GIG9ahf0B4UfF0UKl0aj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object B3lMlHf0WCVUE05PPKrD([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool PYgJAdfxcasiVleYHSom() => IfCodeItem.ToolboxItem.u4mPOtfxshuZk8a5aZVQ == null;

      internal static IfCodeItem.ToolboxItem zPuLP8fxzMiSYBOPdq29() => (IfCodeItem.ToolboxItem) IfCodeItem.ToolboxItem.u4mPOtfxshuZk8a5aZVQ;
    }
  }
}
