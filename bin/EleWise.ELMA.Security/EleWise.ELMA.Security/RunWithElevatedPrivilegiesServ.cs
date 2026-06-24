using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Service]
public class RunWithElevatedPrivilegiesService
{
	private readonly IContextBoundVariableService contextBoundVariableService;

	private static RunWithElevatedPrivilegiesService BKyFLYlcj5qSaNx1ZlP;

	public bool Turned
	{
		get
		{
			bool value;
			return contextBoundVariableService.TryGetValue<bool>((string)I1iAojl0ScdpHabcC96(0x738E3073 ^ 0x738E06B7), out value) && value;
		}
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
					rv8FVwlEfvd1bbfY2hR(contextBoundVariableService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x190F47B7 ^ 0x190F7173), value);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 != 0)
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

	public RunWithElevatedPrivilegiesService(IContextBoundVariableService contextBoundVariableService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_98c0ec8bd6124c50b29441c60f6a53bf == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.contextBoundVariableService = contextBoundVariableService;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool hLiyRglGudOHBUcyi5D()
	{
		return BKyFLYlcj5qSaNx1ZlP == null;
	}

	internal static RunWithElevatedPrivilegiesService q2NivDlF53XRiyFDXic()
	{
		return BKyFLYlcj5qSaNx1ZlP;
	}

	internal static object I1iAojl0ScdpHabcC96(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void rv8FVwlEfvd1bbfY2hR(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}
}
[Component]
public class RunWithElevatedPrivilegiesServiceCacheKeyFormatter : ICacheKeyFormatter
{
	private readonly RunWithElevatedPrivilegiesService service;

	private static RunWithElevatedPrivilegiesServiceCacheKeyFormatter E000nXlDte4q5o1mbrc;

	public RunWithElevatedPrivilegiesServiceCacheKeyFormatter(RunWithElevatedPrivilegiesService service)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Nlsak8lYBRemr7AexfB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
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
			this.service = service;
			num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 != 0)
			{
				num = 1;
			}
		}
	}

	public string Format(string cacheKey, InvocationParameters invocation)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (string)YWvXN6l4kUj3kbaPYPv(cacheKey, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71CDF2F ^ 0x71CE87F));
			default:
				return cacheKey;
			case 1:
				if (!HoiffFlI05iKctgV0Lk(service))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	internal static void Nlsak8lYBRemr7AexfB()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool wpOhaYlMEeuOU11D2Pg()
	{
		return E000nXlDte4q5o1mbrc == null;
	}

	internal static RunWithElevatedPrivilegiesServiceCacheKeyFormatter FfnV4dls0wJs77Kllww()
	{
		return E000nXlDte4q5o1mbrc;
	}

	internal static bool HoiffFlI05iKctgV0Lk(object P_0)
	{
		return ((RunWithElevatedPrivilegiesService)P_0).Turned;
	}

	internal static object YWvXN6l4kUj3kbaPYPv(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
