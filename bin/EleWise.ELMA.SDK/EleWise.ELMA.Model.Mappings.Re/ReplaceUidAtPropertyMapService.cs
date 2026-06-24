using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Mappings.ReplaceUidsAtPropertyMapService;

internal sealed class ReplaceUidAtPropertyMapServiceContext : IDisposable
{
	[ThreadStatic]
	private static IReplaceUidAtPropertyMapServiceExtension currentService;

	private readonly IReplaceUidAtPropertyMapServiceExtension previousService;

	private static IReplaceUidAtPropertyMapServiceExtension stub;

	internal static ReplaceUidAtPropertyMapServiceContext O98htChhaS3y6jBAqxyi;

	[NotNull]
	public static IReplaceUidAtPropertyMapServiceExtension Service => ServiceOrNull ?? throw new ServiceNotFoundException((string)UWkInJhh6UiHAEqjo9Iy(-281842504 ^ -282048256));

	[CanBeNull]
	private static IReplaceUidAtPropertyMapServiceExtension ServiceOrNull
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (currentService != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 0;
						}
						break;
					}
					if (a0hZurhh7FSWJYO2VlSf())
					{
						return (IReplaceUidAtPropertyMapServiceExtension)gUNnFmhhxa7fLvUUFJpx();
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return null;
				default:
					return currentService;
				}
			}
		}
	}

	private static IReplaceUidAtPropertyMapServiceExtension ReplaceUidServiceOrNull
	{
		get
		{
			int num = 1;
			int num2 = num;
			IReplaceUidAtPropertyMapServiceExtension service;
			while (true)
			{
				switch (num2)
				{
				case 1:
					service = Locator.GetService<IReplaceUidAtPropertyMapServiceExtension>();
					if (service == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					service = Stub;
					break;
				}
				break;
			}
			return service;
		}
	}

	private static IReplaceUidAtPropertyMapServiceExtension Stub
	{
		get
		{
			int num = 1;
			int num2 = num;
			IReplaceUidAtPropertyMapServiceExtension replaceUidAtPropertyMapServiceExtension;
			while (true)
			{
				switch (num2)
				{
				case 1:
					replaceUidAtPropertyMapServiceExtension = stub;
					if (replaceUidAtPropertyMapServiceExtension == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					replaceUidAtPropertyMapServiceExtension = (stub = new ReplaceUidAtPropertyMapServiceStub());
					break;
				}
				break;
			}
			return replaceUidAtPropertyMapServiceExtension;
		}
	}

	public ReplaceUidAtPropertyMapServiceContext(IReplaceUidAtPropertyMapServiceExtension service)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		R33LLshhw0T6ZgbKoKvg();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
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
				previousService = currentService;
				num = 2;
				break;
			case 2:
				currentService = service;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void Dispose()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				UpiLSChh4qH0YxIygRFB(currentService);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				currentService = previousService;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static ReplaceUidAtPropertyMapServiceContext Extend(object objLeft, object objRight)
	{
		ExtendedReplaceUidAtPropertyMapServiceExtension extendedReplaceUidAtPropertyMapServiceExtension = new ExtendedReplaceUidAtPropertyMapServiceExtension((IReplaceUidAtPropertyMapServiceExtension)qGqB9uhhHj5rman6jgXC());
		YGKymfhhAndOPGIrCpsb(extendedReplaceUidAtPropertyMapServiceExtension, objLeft, objRight);
		return new ReplaceUidAtPropertyMapServiceContext(extendedReplaceUidAtPropertyMapServiceExtension);
	}

	internal static void R33LLshhw0T6ZgbKoKvg()
	{
		SingletonReader.PushGlobal();
	}

	internal static bool ROQwjMhhDe7AELOEyHh7()
	{
		return O98htChhaS3y6jBAqxyi == null;
	}

	internal static ReplaceUidAtPropertyMapServiceContext w5VVfvhht3I0U940cgiQ()
	{
		return O98htChhaS3y6jBAqxyi;
	}

	internal static void UpiLSChh4qH0YxIygRFB(object P_0)
	{
		((IReplaceUidAtPropertyMapServiceExtension)P_0).EndWork();
	}

	internal static object UWkInJhh6UiHAEqjo9Iy(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object qGqB9uhhHj5rman6jgXC()
	{
		return Service;
	}

	internal static void YGKymfhhAndOPGIrCpsb(object P_0, object P_1, object P_2)
	{
		((ExtendedReplaceUidAtPropertyMapServiceExtension)P_0).Init(P_1, P_2);
	}

	internal static bool a0hZurhh7FSWJYO2VlSf()
	{
		return Locator.Initialized;
	}

	internal static object gUNnFmhhxa7fLvUUFJpx()
	{
		return ReplaceUidServiceOrNull;
	}
}
internal sealed class ReplaceUidAtPropertyMapServiceStub : IReplaceUidAtPropertyMapServiceExtension
{
	private static ReplaceUidAtPropertyMapServiceStub topV5Ahh0OHlLv4avOPk;

	public void Init(object objLeft, object objRight)
	{
	}

	public bool GetUidReplace(Guid uid, out Guid? newUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				newUid = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return false;
			}
		}
	}

	public void EndWork()
	{
	}

	public ReplaceUidAtPropertyMapServiceStub()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		V8WyIPhhM3XBD0bYfuce();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool CRJx5thhmkwwB4KZ9PiA()
	{
		return topV5Ahh0OHlLv4avOPk == null;
	}

	internal static ReplaceUidAtPropertyMapServiceStub CfH2T0hhyL7hRBwiYMOD()
	{
		return topV5Ahh0OHlLv4avOPk;
	}

	internal static void V8WyIPhhM3XBD0bYfuce()
	{
		SingletonReader.PushGlobal();
	}
}
