using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.QueryFunctionResults;

[Component]
public class DateTimeQueryResult : IQueryFunctionResult, IEQLFunction
{
	internal static DateTimeQueryResult RaIyx9GM4wjYEOQKOAhm;

	public string FunctionName => (string)rC3tdEGMAg8pf6sZFfPX(--1418440330 ^ 0x548FA0CC);

	public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
	{
		//Discarded unreachable code: IL_00ed, IL_0174, IL_0183, IL_0208, IL_0217, IL_0227, IL_03fd, IL_045a, IL_0469, IL_0497, IL_04a6
		int num = 17;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 14:
				if (Th5qTOGM7iRvXsOo4dcx((string)parameters[0], rC3tdEGMAg8pf6sZFfPX(-477139494 ^ -477404288), StringComparison.OrdinalIgnoreCase))
				{
					num2 = 6;
					break;
				}
				goto IL_010c;
			case 23:
				if (parameters.Length == 1)
				{
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 16;
					}
					break;
				}
				goto case 27;
			case 6:
				return WF6aBKGMy9InPgjcV3t7(CemoOgGMmaNv0Swlq1lI(Locator.GetServiceNotNull<ITransformationProvider>()));
			case 26:
				return new DateTime(wkxRE6GMMQvHoD1lZHJf(parameters[0]), wkxRE6GMMQvHoD1lZHJf(parameters[1]), wkxRE6GMMQvHoD1lZHJf(parameters[2]), wkxRE6GMMQvHoD1lZHJf(parameters[3]), 0, 0);
			case 28:
				if (parameters.Length == 5)
				{
					num2 = 3;
					break;
				}
				goto case 1;
			case 19:
				if (parameters[0] is string)
				{
					num2 = 15;
					break;
				}
				goto case 25;
			case 11:
				return new DateTime(wkxRE6GMMQvHoD1lZHJf(parameters[0]), wkxRE6GMMQvHoD1lZHJf(parameters[1]), Convert.ToInt32(parameters[2]), Convert.ToInt32(parameters[3]), wkxRE6GMMQvHoD1lZHJf(parameters[4]), wkxRE6GMMQvHoD1lZHJf(parameters[5]));
			case 4:
				if (!((string)parameters[0]).Equals((string)rC3tdEGMAg8pf6sZFfPX(0x76DD48E ^ 0x769DAE0), StringComparison.OrdinalIgnoreCase))
				{
					num2 = 12;
					break;
				}
				goto case 9;
			case 20:
				if (parameters[0] is string)
				{
					num2 = 14;
					break;
				}
				goto IL_010c;
			case 5:
				return new DateTime(wkxRE6GMMQvHoD1lZHJf(parameters[0]), Convert.ToInt32(parameters[1]), wkxRE6GMMQvHoD1lZHJf(parameters[2]));
			case 30:
				return ivNR5CGM0r0msQA4B1O9();
			case 25:
				if (parameters.Length == 1)
				{
					num2 = 20;
					break;
				}
				goto IL_010c;
			case 13:
				return new DateTime(wkxRE6GMMQvHoD1lZHJf(parameters[0]), wkxRE6GMMQvHoD1lZHJf(parameters[1]), wkxRE6GMMQvHoD1lZHJf(parameters[2]), wkxRE6GMMQvHoD1lZHJf(parameters[3]), wkxRE6GMMQvHoD1lZHJf(parameters[4]), wkxRE6GMMQvHoD1lZHJf(parameters[5]), wkxRE6GMMQvHoD1lZHJf(parameters[6]));
			case 21:
				if (parameters[0] is string)
				{
					num2 = 29;
					break;
				}
				goto case 27;
			case 8:
				return new DateTime(wkxRE6GMMQvHoD1lZHJf(parameters[0]), wkxRE6GMMQvHoD1lZHJf(parameters[1]), wkxRE6GMMQvHoD1lZHJf(parameters[2]), wkxRE6GMMQvHoD1lZHJf(parameters[3]), Convert.ToInt32(parameters[4]), 0);
			case 1:
				if (parameters.Length == 6)
				{
					num2 = 2;
					break;
				}
				goto IL_01e0;
			default:
				if (!(parameters[0] is string))
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 4;
			case 9:
				return ((Dialect)CemoOgGMmaNv0Swlq1lI(Locator.GetServiceNotNull<ITransformationProvider>())).MaxDateTime;
			case 7:
			case 12:
				if (parameters.Length == 3)
				{
					num2 = 22;
					break;
				}
				goto IL_029e;
			case 15:
				if (!((string)parameters[0]).Equals((string)rC3tdEGMAg8pf6sZFfPX(-1459557599 ^ -1459461989), StringComparison.OrdinalIgnoreCase))
				{
					num2 = 25;
					break;
				}
				goto case 30;
			case 17:
				if (parameters.Length == 0)
				{
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 15;
					}
					break;
				}
				goto case 23;
			case 29:
				if (!Th5qTOGM7iRvXsOo4dcx((string)parameters[0], rC3tdEGMAg8pf6sZFfPX(-1858887263 ^ -1859048855), StringComparison.OrdinalIgnoreCase))
				{
					num2 = 27;
					break;
				}
				goto case 16;
			case 16:
			case 24:
				return LTCOxBGMxfpbJlVQu4Dc();
			case 27:
				if (parameters.Length == 1)
				{
					num2 = 19;
					break;
				}
				goto case 25;
			case 22:
				if (parameters.All((object p) => p is long))
				{
					num2 = 5;
					break;
				}
				goto IL_029e;
			case 10:
				if (!parameters.All((object p) => p is long))
				{
					num2 = 28;
					break;
				}
				goto case 26;
			case 3:
				if (!parameters.All((object p) => p is long))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 8;
			case 2:
				if (parameters.All((object p) => p is long))
				{
					num2 = 11;
					break;
				}
				goto IL_01e0;
			case 18:
				{
					if (parameters.All((object p) => p is long))
					{
						num2 = 13;
						break;
					}
					goto IL_0312;
				}
				IL_0312:
				throw new ArgumentException();
				IL_010c:
				if (parameters.Length == 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
				IL_01e0:
				if (parameters.Length == 7)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 18;
					}
					break;
				}
				goto IL_0312;
				IL_029e:
				if (parameters.Length == 4)
				{
					num2 = 10;
					break;
				}
				goto case 28;
			}
		}
	}

	public IEnumerable<EQLFunction> GetEqlFunctions()
	{
		Guid[] types = new Guid[1] { DateTimeDescriptor.UID };
		return new EQLFunction[6]
		{
			new EQLFunction
			{
				DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138419974), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289455992)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858621619)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867464337)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307A90D7)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3634FC71)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541991767)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751440174)), FunctionName),
				Description = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307C1575)),
				Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A653B3C), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C44899)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AFAA04)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CF48B1)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998276548)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939636836)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886911825)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69744577)), FunctionName),
				Types = types
			},
			new EQLFunction
			{
				DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269A5084), FunctionName),
				Description = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3634FC3D)),
				Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x769DBC0), FunctionName),
				Types = types
			},
			new EQLFunction
			{
				DisplayName = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951253318)),
				Description = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -489141097)),
				Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459297203), FunctionName),
				Types = types
			},
			new EQLFunction
			{
				DisplayName = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A6E70C)),
				Description = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x3132543A)),
				Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106255296), FunctionName),
				Types = types
			},
			new EQLFunction
			{
				DisplayName = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463A26B2)),
				Description = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A65F91)),
				Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710309526), FunctionName),
				Types = types
			},
			new EQLFunction
			{
				DisplayName = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4DD849)),
				Description = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C94BC0E)),
				Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -28994911), FunctionName),
				Types = types
			}
		};
	}

	public DateTimeQueryResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object rC3tdEGMAg8pf6sZFfPX(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool oC05GHGM6S6oZtIjbvl3()
	{
		return RaIyx9GM4wjYEOQKOAhm == null;
	}

	internal static DateTimeQueryResult CBh0jBGMHTw3IDormExh()
	{
		return RaIyx9GM4wjYEOQKOAhm;
	}

	internal static bool Th5qTOGM7iRvXsOo4dcx(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static DateTime LTCOxBGMxfpbJlVQu4Dc()
	{
		return DateTime.Now;
	}

	internal static DateTime ivNR5CGM0r0msQA4B1O9()
	{
		return DateTime.Today;
	}

	internal static object CemoOgGMmaNv0Swlq1lI(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static DateTime WF6aBKGMy9InPgjcV3t7(object P_0)
	{
		return ((Dialect)P_0).MinDateTime;
	}

	internal static int wkxRE6GMMQvHoD1lZHJf(object P_0)
	{
		return Convert.ToInt32(P_0);
	}
}
