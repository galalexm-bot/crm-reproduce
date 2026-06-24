using System.Runtime.CompilerServices;
using System.Web.Routing;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Results;

public class RedirectToUrlResult : FormResult
{
	private static RedirectToUrlResult CIBo3OyjLTTbrVkIV31;

	public string Url
	{
		[CompilerGenerated]
		get
		{
			return _003CUrl_003Ek__BackingField;
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
				case 1:
					_003CUrl_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public RouteValueDictionary Values
	{
		[CompilerGenerated]
		get
		{
			return _003CValues_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CValues_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public RedirectToUrlResult(string url)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PqM0CwyU4nxY20v55dA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				xM6IMbyclwA6DHh31C8(url, XfQKV4ysqwiN7l6ICkP(-2107978722 ^ -2108004784));
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				Url = url;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num = 1;
				}
				break;
			case 1:
				Values = new RouteValueDictionary();
				num = 3;
				break;
			case 3:
				return;
			}
		}
	}

	public RedirectToUrlResult(string url, RouteValueDictionary values)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		PqM0CwyU4nxY20v55dA();
		this._002Ector(url);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Values = values;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
			{
				num = 1;
			}
		}
	}

	internal static void PqM0CwyU4nxY20v55dA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object XfQKV4ysqwiN7l6ICkP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void xM6IMbyclwA6DHh31C8(object P_0, object P_1)
	{
		Contract.ArgumentNotNullOrEmpty((string)P_0, (string)P_1);
	}

	internal static bool JxNh2KyYPgBUutSCi7u()
	{
		return CIBo3OyjLTTbrVkIV31 == null;
	}

	internal static RedirectToUrlResult Fft2bGyL1I5U4j8LYfF()
	{
		return CIBo3OyjLTTbrVkIV31;
	}
}
