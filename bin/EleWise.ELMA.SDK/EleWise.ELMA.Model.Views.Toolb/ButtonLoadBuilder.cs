using System;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Toolbar;

public class ButtonLoadBuilder<TContext> where TContext : IEntity
{
	private readonly Button button;

	internal static object JidOXPowa39rEH62K1VP;

	internal ButtonLoadBuilder(RootToolbarItem parent, string uid)
	{
		//Discarded unreachable code: IL_0043, IL_0048, IL_00b7
		SingletonReader.JJCZtPuTvSt();
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.uid = uid;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				if (button != null)
				{
					num = 3;
					continue;
				}
				break;
			default:
				if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.uid))
				{
					num = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num = 4;
					}
					continue;
				}
				goto case 2;
			case 3:
				return;
			case 1:
				return;
			case 6:
				parent.Items.Add(button);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num = 1;
				}
				continue;
			case 4:
				button = parent.Items.OfType<Button>().FirstOrDefault((Button g) => g.Name == CS_0024_003C_003E8__locals0.uid);
				num = 2;
				continue;
			case 5:
				break;
			}
			button = new Button();
			num = 6;
		}
	}

	public ButtonLoadBuilder<TContext> Uid(string uid)
	{
		button.Name = uid;
		return this;
	}

	public ButtonLoadBuilder<TContext> Text(string text)
	{
		button.Text = text;
		return this;
	}

	public ButtonLoadBuilder<TContext> ToolTip(string toolTip)
	{
		button.ToolTip = toolTip;
		return this;
	}

	public ButtonLoadBuilder<TContext> ToolTipHeader(string toolTipHeader)
	{
		button.ToolTipHeader = toolTipHeader;
		return this;
	}

	public ButtonLoadBuilder<TContext> IconUrl(string iconUrl)
	{
		button.IconUrl = iconUrl;
		return this;
	}

	public ButtonLoadBuilder<TContext> Script(Expression<Action<PageViewModel<TContext>>> script)
	{
		button.ScriptName = LinqUtils.MemberOf(script).Name;
		return this;
	}

	public ButtonLoadBuilder<TContext> Script(string scriptName)
	{
		button.ScriptName = scriptName;
		return this;
	}

	public ButtonLoadBuilder<TContext> Url(string url)
	{
		button.Url = url;
		return this;
	}

	public ButtonLoadBuilder<TContext> Click(string click)
	{
		button.Click = click;
		return this;
	}

	public ButtonLoadBuilder<TContext> Action(string actionId)
	{
		int num = actionId.IndexOf(';');
		if (num > 0)
		{
			button.ActionTypeProviderId = actionId.Remove(num);
			button.ActionId = actionId.Substring(num + 1);
		}
		return this;
	}

	public ButtonLoadBuilder<TContext> Checked(bool @checked = true)
	{
		button.Checked = @checked;
		return this;
	}

	public ButtonLoadBuilder<TContext> Buttons(Action<ButtonsLoadBuilder<TContext>> action)
	{
		ButtonsLoadBuilder<TContext> obj = Buttons();
		action?.Invoke(obj);
		return this;
	}

	public ButtonsLoadBuilder<TContext> Buttons()
	{
		return new ButtonsLoadBuilder<TContext>(button);
	}

	public ButtonLoadBuilder<TContext> Visible(bool visible = true)
	{
		button.Visible = visible;
		return this;
	}

	internal static bool w9QH0YowDqawM8rAKE3o()
	{
		return JidOXPowa39rEH62K1VP == null;
	}

	internal static object IKOdmjowtBBdWYtExQPT()
	{
		return JidOXPowa39rEH62K1VP;
	}
}
