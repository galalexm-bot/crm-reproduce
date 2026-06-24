using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.QueryFunctionResults;

[Component]
public class WorkTimeQueryResult : IQueryFunctionResult, IEQLFunction
{
	private static WorkTimeQueryResult lMxcJrGMvk4hkkiGDBDG;

	public string FunctionName => (string)DBUEJgGMuENJ1DVGCq0d(-541731959 ^ -541991417);

	public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
	{
		//Discarded unreachable code: IL_005c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (parameters.Length == 2)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_0085;
			case 4:
				return new WorkTime((long)parameters[0], (long)parameters[1]);
			case 3:
				return new WorkTime((long)parameters[0], (long)parameters[1], (long)parameters[2]);
			case 5:
				throw new ArgumentException();
			case 1:
				if (parameters.All((object p) => p is long))
				{
					num2 = 4;
					break;
				}
				goto IL_0085;
			default:
				{
					if (!parameters.All((object p) => p is long))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 3;
				}
				IL_0085:
				if (parameters.Length == 3)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			}
		}
	}

	public IEnumerable<EQLFunction> GetEqlFunctions()
	{
		return new EQLFunction[1]
		{
			new EQLFunction
			{
				DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -28995391), FunctionName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459296543)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571AAE57))),
				Description = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63A92550)),
				Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CF4BE9), FunctionName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886912433)), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4781B1C3))),
				Types = new Guid[1] { WorkTimeDescriptor.UID }
			}
		};
	}

	public WorkTimeQueryResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vFGTgUGMIEWJhIolEm6Q();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object DBUEJgGMuENJ1DVGCq0d(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool Dh2vK5GM8Hp3DG0RWpjO()
	{
		return lMxcJrGMvk4hkkiGDBDG == null;
	}

	internal static WorkTimeQueryResult ENhMT6GMZwATHkdKtHI7()
	{
		return lMxcJrGMvk4hkkiGDBDG;
	}

	internal static void vFGTgUGMIEWJhIolEm6Q()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
