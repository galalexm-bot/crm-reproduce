using System;
using System.Linq;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Toolbar;

public class GroupLoadBuilder<TContext> where TContext : IEntity
{
	private readonly Group group;

	internal static object QRuV4wowefrSrwMrHnHd;

	internal GroupLoadBuilder(Toolbar toolbar, string uid)
	{
		//Discarded unreachable code: IL_0033, IL_0038, IL_00c9, IL_00d8, IL_0128, IL_0137
		SingletonReader.JJCZtPuTvSt();
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.uid = uid;
		base._002Ector();
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 4:
				return;
			case 6:
				toolbar.Items.Add(group);
				num = 2;
				break;
			default:
				group = toolbar.Items.OfType<Group>().FirstOrDefault((Group g) => g.Name == CS_0024_003C_003E8__locals0.uid);
				num = 3;
				break;
			case 3:
			case 5:
				if (group != null)
				{
					num = 4;
					break;
				}
				goto case 1;
			case 1:
				group = new Group();
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num = 0;
				}
				break;
			case 7:
				if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.uid))
				{
					num = 5;
					break;
				}
				goto default;
			}
		}
	}

	public GroupLoadBuilder<TContext> Buttons(Action<ButtonsLoadBuilder<TContext>> action)
	{
		ButtonsLoadBuilder<TContext> obj = Buttons();
		action?.Invoke(obj);
		return this;
	}

	public ButtonsLoadBuilder<TContext> Buttons()
	{
		return new ButtonsLoadBuilder<TContext>(group);
	}

	public GroupLoadBuilder<TContext> Uid(string uid)
	{
		group.Name = uid;
		return this;
	}

	public GroupLoadBuilder<TContext> Visible(bool visible = true)
	{
		group.Visible = visible;
		return this;
	}

	internal static bool Njhp25owPgkO7tctDSHn()
	{
		return QRuV4wowefrSrwMrHnHd == null;
	}

	internal static object Da4IgVow1Z2FxHERqSWy()
	{
		return QRuV4wowefrSrwMrHnHd;
	}
}
