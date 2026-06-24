// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbar.GroupLoadBuilder`1
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
  public class GroupLoadBuilder<TContext> where TContext : IEntity
  {
    private readonly Group group;
    internal static object QRuV4wowefrSrwMrHnHd;

    internal GroupLoadBuilder(EleWise.ELMA.Model.Views.Toolbar.Toolbar toolbar, string uid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 7;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.group = new Group();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 6 : 0;
            continue;
          case 2:
            goto label_10;
          case 3:
          case 5:
            if (this.group != null)
            {
              num = 4;
              continue;
            }
            goto case 1;
          case 4:
            goto label_6;
          case 6:
            toolbar.Items.Add((ToolbarItem) this.group);
            num = 2;
            continue;
          case 7:
            if (string.IsNullOrEmpty(uid))
            {
              num = 5;
              continue;
            }
            break;
        }
        this.group = toolbar.Items.OfType<Group>().FirstOrDefault<Group>((Func<Group, bool>) (g => g.Name == uid));
        num = 3;
      }
label_10:
      return;
label_6:;
    }

    /// <summary>Кнопки группы</summary>
    /// <param name="action">Builder для кнопок</param>
    /// <returns></returns>
    public GroupLoadBuilder<TContext> Buttons(Action<ButtonsLoadBuilder<TContext>> action)
    {
      ButtonsLoadBuilder<TContext> buttonsLoadBuilder = this.Buttons();
      if (action != null)
        action(buttonsLoadBuilder);
      return this;
    }

    /// <summary>Кнопки группы</summary>
    /// <returns>Builder для кнопок</returns>
    public ButtonsLoadBuilder<TContext> Buttons() => new ButtonsLoadBuilder<TContext>((RootToolbarItem) this.group);

    /// <summary>Идентификатор группы</summary>
    /// <param name="uid">Идентификатор группы</param>
    /// <returns></returns>
    public GroupLoadBuilder<TContext> Uid(string uid)
    {
      this.group.Name = uid;
      return this;
    }

    /// <summary>Видимость группы со всеми кнопками</summary>
    /// <param name="visible">true, если группа видима, или false, если не видима</param>
    /// <returns></returns>
    public GroupLoadBuilder<TContext> Visible(bool visible = true)
    {
      this.group.Visible = visible;
      return this;
    }

    internal static bool Njhp25owPgkO7tctDSHn() => GroupLoadBuilder<TContext>.QRuV4wowefrSrwMrHnHd == null;

    internal static object Da4IgVow1Z2FxHERqSWy() => GroupLoadBuilder<TContext>.QRuV4wowefrSrwMrHnHd;
  }
}
