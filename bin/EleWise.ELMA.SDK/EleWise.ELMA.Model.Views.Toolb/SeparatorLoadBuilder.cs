using System.Linq;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Toolbar;

public class SeparatorLoadBuilder<TContext> where TContext : IEntity
{
	private readonly Separator separator;

	private static object e9F8TBowwOGWtHx6AtBZ;

	internal SeparatorLoadBuilder(RootToolbarItem parent, string uid)
	{
		//Discarded unreachable code: IL_0037, IL_0095, IL_00a4, IL_0127
		SingletonReader.JJCZtPuTvSt();
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.uid = uid;
		base._002Ector();
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 4:
				return;
			case 3:
			case 7:
				if (separator != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 5:
				if (string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.uid))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 6;
			case 6:
				separator = parent.Items.OfType<Separator>().FirstOrDefault((Separator g) => g.Name == CS_0024_003C_003E8__locals0.uid);
				num2 = 7;
				continue;
			default:
				parent.Items.Add(separator);
				num2 = 4;
				continue;
			case 2:
				break;
			}
			separator = new Separator();
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
			{
				num2 = 0;
			}
		}
	}

	public SeparatorLoadBuilder<TContext> Uid(string uid)
	{
		separator.Name = uid;
		return this;
	}

	public SeparatorLoadBuilder<TContext> Visible(bool visible = true)
	{
		separator.Visible = visible;
		return this;
	}

	internal static bool fwsmBNow4eYF3guiBb0e()
	{
		return e9F8TBowwOGWtHx6AtBZ == null;
	}

	internal static object EByCe4ow6GLSmwESldhu()
	{
		return e9F8TBowwOGWtHx6AtBZ;
	}
}
