using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Toolbar;

public class ToolbarLoadBuilder<TContext> where TContext : IEntity
{
	internal static object XXiU9vownjFNQyAsKDw1;

	internal Toolbar Toolbar
	{
		[CompilerGenerated]
		get
		{
			return _003CToolbar_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CToolbar_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal ToolbarLoadBuilder(Toolbar toolbar)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				Toolbar = toolbar ?? new Toolbar();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ToolbarLoadBuilder<TContext> Group(Action<GroupLoadBuilder<TContext>> action, string uid = null)
	{
		GroupLoadBuilder<TContext> obj = Group(uid);
		action?.Invoke(obj);
		return this;
	}

	public GroupLoadBuilder<TContext> Group(string uid = null)
	{
		return new GroupLoadBuilder<TContext>(Toolbar, uid);
	}

	internal static bool WhQrI0owOurErskD4hjo()
	{
		return XXiU9vownjFNQyAsKDw1 == null;
	}

	internal static object Tcdinjow2n7yGtbP9bBf()
	{
		return XXiU9vownjFNQyAsKDw1;
	}
}
