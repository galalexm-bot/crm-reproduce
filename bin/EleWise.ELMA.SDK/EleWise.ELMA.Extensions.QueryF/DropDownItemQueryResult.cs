using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.QueryFunctionResults;

[Component]
public class DropDownItemQueryResult : IQueryFunctionResult, IEQLFunction
{
	private static DropDownItemQueryResult aFfl3LGmM2qA7xr7Zw2P;

	public string FunctionName => (string)PcH5IwGmdpf9XZBf0O6L(0x34A6D230 ^ 0x34A4FE3E);

	public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (parameters.Length == 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0059;
			case 2:
				return new DropDownItem((string)parameters[0]);
			default:
				{
					if (parameters[0] is string)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto IL_0059;
				}
				IL_0059:
				throw new ArgumentException();
			}
		}
	}

	public IEnumerable<EQLFunction> GetEqlFunctions()
	{
		return new EQLFunction[1]
		{
			new EQLFunction
			{
				DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875968559), FunctionName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571AAEAF))),
				Description = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70172145)),
				Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548FA2B6), FunctionName),
				Types = new Guid[1] { DropDownListDescriptor.UID }
			}
		};
	}

	public DropDownItemQueryResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object PcH5IwGmdpf9XZBf0O6L(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool sQ7YR2GmJnTZM8FcgMNm()
	{
		return aFfl3LGmM2qA7xr7Zw2P == null;
	}

	internal static DropDownItemQueryResult zPNMAgGm9QNr3mrMbUWf()
	{
		return aFfl3LGmM2qA7xr7Zw2P;
	}
}
