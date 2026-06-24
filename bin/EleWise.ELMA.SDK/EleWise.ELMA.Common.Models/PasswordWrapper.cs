using System;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Common.Models;

public class PasswordWrapper
{
	private PasswordInfo info;

	private static PasswordWrapper vQPqaSfSn55Q6je3p0D4;

	internal PasswordWrapper(PasswordInfo info, PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_0036, IL_003b
		xpt07gfSeihco9diZIRh();
		this._002Ector(info, dxns67fSPaTEkwaBqVM8(propertyMetadata) as PasswordSettings);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal PasswordWrapper(PasswordInfo info, PasswordSettings settings)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		xpt07gfSeihco9diZIRh();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 2:
				this.info = info;
				num = 3;
				break;
			default:
				info.InitPasswordResolver(r9Dq9efS10dOf6IWC9DE(settings));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num = 1;
				}
				break;
			case 3:
				if (settings != null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num = 0;
					}
					break;
				}
				return;
			case 1:
				return;
			}
		}
	}

	public bool Check(string password)
	{
		return DfULDefSNydr1QvvDX42(info, password);
	}

	public string GetPassword()
	{
		return info.GetPassword();
	}

	internal static void xpt07gfSeihco9diZIRh()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object dxns67fSPaTEkwaBqVM8(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static bool YvcJeJfSORgWy0GGuQTF()
	{
		return vQPqaSfSn55Q6je3p0D4 == null;
	}

	internal static PasswordWrapper Jbc5dffS21nRc8Q2xWVw()
	{
		return vQPqaSfSn55Q6je3p0D4;
	}

	internal static Guid r9Dq9efS10dOf6IWC9DE(object P_0)
	{
		return ((PasswordSettings)P_0).PasswordType;
	}

	internal static bool DfULDefSNydr1QvvDX42(object P_0, object P_1)
	{
		return ((PasswordInfo)P_0).Check((string)P_1);
	}
}
