// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbar.SeparatorLoadBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;

namespace EleWise.ELMA.Model.Views.Toolbar
{
  public class SeparatorLoadBuilder<TContext> where TContext : IEntity
  {
    private readonly Separator separator;
    private static object e9F8TBowwOGWtHx6AtBZ;

    internal SeparatorLoadBuilder(RootToolbarItem parent, string uid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            this.separator = new Separator();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 3:
          case 7:
            if (this.separator != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 0;
              continue;
            }
            goto case 2;
          case 4:
            goto label_4;
          case 5:
            if (string.IsNullOrEmpty(uid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 2 : 3;
              continue;
            }
            goto case 6;
          case 6:
            this.separator = parent.Items.OfType<Separator>().FirstOrDefault<Separator>((Func<Separator, bool>) (g => g.Name == uid));
            num = 7;
            continue;
          default:
            parent.Items.Add((ToolbarItem) this.separator);
            num = 4;
            continue;
        }
      }
label_9:
      return;
label_4:;
    }

    /// <summary>Идентификатор разделителя</summary>
    /// <param name="uid">Идентификатор разделителя</param>
    /// <returns></returns>
    public SeparatorLoadBuilder<TContext> Uid(string uid)
    {
      this.separator.Name = uid;
      return this;
    }

    /// <summary>Видимость разделителя</summary>
    /// <param name="visible">true, если разделитель видим, или false, если не видим</param>
    /// <returns></returns>
    public SeparatorLoadBuilder<TContext> Visible(bool visible = true)
    {
      this.separator.Visible = visible;
      return this;
    }

    internal static bool fwsmBNow4eYF3guiBb0e() => SeparatorLoadBuilder<TContext>.e9F8TBowwOGWtHx6AtBZ == null;

    internal static object EByCe4ow6GLSmwESldhu() => SeparatorLoadBuilder<TContext>.e9F8TBowwOGWtHx6AtBZ;
  }
}
