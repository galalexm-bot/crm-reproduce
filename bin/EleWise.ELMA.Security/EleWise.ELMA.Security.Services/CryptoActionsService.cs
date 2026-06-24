using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Services;

[Service]
public class CryptoActionsService : ICryptoActionsService
{
	private static CryptoActionsService kDskJJwDllYMWyXmEUI;

	public IEnumerable<ICryptoAction> CryptoActions { get; set; }

	public Guid[] ActionUids => CryptoActions.Select((ICryptoAction c) => c.ActionUid).ToArray();

	public bool IsProvidersEquals(EleWise.ELMA.Security.Models.IUser user)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass6_.user = user;
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return (from a in CryptoActions
					select a.CryptoService into s
					where s != null
					select s).Select(_003C_003Ec__DisplayClass6_._003CIsProvidersEquals_003Eb__2).Distinct().Count() == 1;
			}
		}
	}

	public CryptoActionsService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LjPYm5wYc7DhHcskxP0();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool t3WApWwM9vfDSIwmCfc()
	{
		return kDskJJwDllYMWyXmEUI == null;
	}

	internal static CryptoActionsService SXbmHWwsyF3i7Pq9E5L()
	{
		return kDskJJwDllYMWyXmEUI;
	}

	internal static void LjPYm5wYc7DhHcskxP0()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
