using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Views.Toolbar;

public class ButtonsLoadBuilder<TContext> where TContext : IEntity
{
	private readonly RootToolbarItem parent;

	internal static object S5eC5NowNQfo2HHfnEXb;

	internal ButtonsLoadBuilder(RootToolbarItem parent)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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
				this.parent = parent;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ButtonLoadBuilder<TContext> Button(string uid = null)
	{
		return new ButtonLoadBuilder<TContext>(parent, uid);
	}

	public SeparatorLoadBuilder<TContext> Separator(string uid = null)
	{
		return new SeparatorLoadBuilder<TContext>(parent, uid);
	}

	internal static bool jAMvy4ow3eiIfV3dn2ek()
	{
		return S5eC5NowNQfo2HHfnEXb == null;
	}

	internal static object DE6j5howpb5grT3ZSXa2()
	{
		return S5eC5NowNQfo2HHfnEXb;
	}
}
