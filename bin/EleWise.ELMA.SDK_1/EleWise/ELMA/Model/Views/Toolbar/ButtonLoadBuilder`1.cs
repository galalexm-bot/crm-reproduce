// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Toolbar.ButtonLoadBuilder`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Views.Toolbar
{
  public class ButtonLoadBuilder<TContext> where TContext : IEntity
  {
    private readonly Button button;
    internal static object JidOXPowa39rEH62K1VP;

    internal ButtonLoadBuilder(RootToolbarItem parent, string uid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_8;
          case 2:
            if (this.button != null)
            {
              num = 3;
              continue;
            }
            goto case 5;
          case 3:
            goto label_3;
          case 4:
            this.button = parent.Items.OfType<Button>().FirstOrDefault<Button>((Func<Button, bool>) (g => g.Name == uid));
            num = 2;
            continue;
          case 5:
            this.button = new Button();
            num = 6;
            continue;
          case 6:
            parent.Items.Add((ToolbarItem) this.button);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
            continue;
          default:
            if (!string.IsNullOrEmpty(uid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 2 : 4;
              continue;
            }
            goto case 2;
        }
      }
label_8:
      return;
label_3:;
    }

    /// <summary>Идентификатор кнопки</summary>
    /// <param name="uid">Идентификатор кнопки</param>
    /// <returns></returns>
    public ButtonLoadBuilder<TContext> Uid(string uid)
    {
      this.button.Name = uid;
      return this;
    }

    /// <summary>Текст кнопки</summary>
    /// <param name="text">Текст кнопки</param>
    /// <returns></returns>
    public ButtonLoadBuilder<TContext> Text(string text)
    {
      this.button.Text = text;
      return this;
    }

    /// <summary>Всплывающая подсказка кнопки</summary>
    /// <param name="toolTip">Всплывающая подсказка кнопки</param>
    /// <returns></returns>
    public ButtonLoadBuilder<TContext> ToolTip(string toolTip)
    {
      this.button.ToolTip = toolTip;
      return this;
    }

    /// <summary>Заголовок для всплывающей подсазки</summary>
    /// <param name="toolTipHeader">Заголовок для всплывающей подсазки</param>
    /// <returns></returns>
    public ButtonLoadBuilder<TContext> ToolTipHeader(string toolTipHeader)
    {
      this.button.ToolTipHeader = toolTipHeader;
      return this;
    }

    /// <summary>Url картинки для кнопки</summary>
    /// <param name="iconUrl">Url картинки для кнопки</param>
    /// <returns></returns>
    public ButtonLoadBuilder<TContext> IconUrl(string iconUrl)
    {
      this.button.IconUrl = iconUrl;
      return this;
    }

    /// <summary>Серверная обработка для кнопки</summary>
    /// <param name="script">Серверный метод</param>
    /// <returns></returns>
    public ButtonLoadBuilder<TContext> Script(Expression<System.Action<PageViewModel<TContext>>> script)
    {
      this.button.ScriptName = LinqUtils.MemberOf<PageViewModel<TContext>>(script).Name;
      return this;
    }

    /// <summary>Серверная обработка для кнопки</summary>
    /// <param name="scriptName">Серверная обработка для кнопки</param>
    /// <returns></returns>
    public ButtonLoadBuilder<TContext> Script(string scriptName)
    {
      this.button.ScriptName = scriptName;
      return this;
    }

    /// <summary>Url для кнопки</summary>
    /// <param name="url">Url для кнопки</param>
    /// <returns></returns>
    public ButtonLoadBuilder<TContext> Url(string url)
    {
      this.button.Url = url;
      return this;
    }

    /// <summary>Название клиентской функции для кнопки</summary>
    /// <param name="click">Название клиентской функции для кнопки</param>
    /// <returns></returns>
    public ButtonLoadBuilder<TContext> Click(string click)
    {
      this.button.Click = click;
      return this;
    }

    /// <summary>Действие из реестра действий</summary>
    /// <param name="actionId">Действие из реестра действий</param>
    /// <returns></returns>
    public ButtonLoadBuilder<TContext> Action(string actionId)
    {
      int startIndex = actionId.IndexOf(';');
      if (startIndex > 0)
      {
        this.button.ActionTypeProviderId = actionId.Remove(startIndex);
        this.button.ActionId = actionId.Substring(startIndex + 1);
      }
      return this;
    }

    /// <summary>Выделена кнопка</summary>
    /// <param name="checked">true, если надо выделить кнопку, или false, если выделять не нужно</param>
    /// <returns></returns>
    public ButtonLoadBuilder<TContext> Checked(bool @checked = true)
    {
      this.button.Checked = @checked;
      return this;
    }

    /// <summary>Дочерние кнопки</summary>
    /// <param name="action">Builder для кнопок</param>
    /// <returns></returns>
    public ButtonLoadBuilder<TContext> Buttons(System.Action<ButtonsLoadBuilder<TContext>> action)
    {
      ButtonsLoadBuilder<TContext> buttonsLoadBuilder = this.Buttons();
      if (action != null)
        action(buttonsLoadBuilder);
      return this;
    }

    /// <summary>Дочерние кнопки</summary>
    /// <returns>Builder для кнопок</returns>
    public ButtonsLoadBuilder<TContext> Buttons() => new ButtonsLoadBuilder<TContext>((RootToolbarItem) this.button);

    /// <summary>Видимость кнопки со всеми дочерними кнопками</summary>
    /// <param name="visible">true, если кнопка видима, или false, если не видима</param>
    /// <returns></returns>
    public ButtonLoadBuilder<TContext> Visible(bool visible = true)
    {
      this.button.Visible = visible;
      return this;
    }

    internal static bool w9QH0YowDqawM8rAKE3o() => ButtonLoadBuilder<TContext>.JidOXPowa39rEH62K1VP == null;

    internal static object IKOdmjowtBBdWYtExQPT() => ButtonLoadBuilder<TContext>.JidOXPowa39rEH62K1VP;
  }
}
