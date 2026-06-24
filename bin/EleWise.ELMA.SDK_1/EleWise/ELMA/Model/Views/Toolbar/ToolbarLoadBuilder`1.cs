// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbar.ToolbarLoadBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views.Toolbar
{
  public class ToolbarLoadBuilder<TContext> where TContext : IEntity
  {
    internal static object XXiU9vownjFNQyAsKDw1;

    internal ToolbarLoadBuilder(EleWise.ELMA.Model.Views.Toolbar.Toolbar toolbar)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            EleWise.ELMA.Model.Views.Toolbar.Toolbar toolbar1 = toolbar;
            this.Toolbar = toolbar1 == null ? new EleWise.ELMA.Model.Views.Toolbar.Toolbar() : toolbar1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_5:
      return;
label_3:;
    }

    internal EleWise.ELMA.Model.Views.Toolbar.Toolbar Toolbar
    {
      get => this.\u003CToolbar\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CToolbar\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    /// <summary>Группа</summary>
    /// <param name="action">Builder для группы</param>
    /// <param name="uid">Идентификатор групы (найти группу с указанным идентификатором, или создать новую)</param>
    /// <returns></returns>
    public ToolbarLoadBuilder<TContext> Group(Action<GroupLoadBuilder<TContext>> action, string uid = null)
    {
      GroupLoadBuilder<TContext> groupLoadBuilder = this.Group(uid);
      if (action != null)
        action(groupLoadBuilder);
      return this;
    }

    /// <summary>Группа</summary>
    /// <param name="uid">Идентификатор группы (найти группу с указанным идентификатором, или создать новую)</param>
    /// <returns>Builder для группы</returns>
    public GroupLoadBuilder<TContext> Group(string uid = null) => new GroupLoadBuilder<TContext>(this.Toolbar, uid);

    internal static bool WhQrI0owOurErskD4hjo() => ToolbarLoadBuilder<TContext>.XXiU9vownjFNQyAsKDw1 == null;

    internal static object Tcdinjow2n7yGtbP9bBf() => ToolbarLoadBuilder<TContext>.XXiU9vownjFNQyAsKDw1;
  }
}
