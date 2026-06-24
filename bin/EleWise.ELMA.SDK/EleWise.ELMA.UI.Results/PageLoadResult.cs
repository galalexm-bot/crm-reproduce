using System.Runtime.CompilerServices;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Results;

public class PageLoadResult : FormResult
{
	internal static PageLoadResult xa71HUym2dWBU3XIjlB;

	public IPageLoadViewModel ViewModel
	{
		[CompilerGenerated]
		get
		{
			return _003CViewModel_003Ek__BackingField;
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
					_003CViewModel_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public PageLoadResult(IPageLoadViewModel viewModel)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NhrgfCyJ5pbMEuJkcHI();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				ViewModel = viewModel;
				num = 2;
				continue;
			case 2:
				return;
			}
			j2qT5yydvHD6nsqxDeE(viewModel, sNhXRTy95OdO8CkBNu5(0x4DC2B14D ^ 0x4DC21B75));
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
			{
				num = 0;
			}
		}
	}

	internal static void NhrgfCyJ5pbMEuJkcHI()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object sNhXRTy95OdO8CkBNu5(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void j2qT5yydvHD6nsqxDeE(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool leyfhKyyM2GGJhWbCWF()
	{
		return xa71HUym2dWBU3XIjlB == null;
	}

	internal static PageLoadResult VGAy4lyMWOUEKp9dIaq()
	{
		return xa71HUym2dWBU3XIjlB;
	}
}
