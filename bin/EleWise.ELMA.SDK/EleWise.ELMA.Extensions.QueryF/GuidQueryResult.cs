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
public class GuidQueryResult : IQueryFunctionResult, IEQLFunction
{
	internal static GuidQueryResult EAoucqGJvdh3WxNa2O0Q;

	public string FunctionName => (string)TRc3ntGJuoaSh4rJTQjs(-105199646 ^ -104937446);

	public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
	{
		//Discarded unreachable code: IL_0084, IL_0093, IL_019f, IL_01ae, IL_01bd
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (parameters.Length != 0)
				{
					num2 = 4;
					break;
				}
				goto case 12;
			case 12:
				return Yk3VBlGJVu3N6wgoRJ8V();
			default:
				return Guid.Empty;
			case 8:
			case 9:
				if (parameters.Length == 1)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 10;
			case 6:
				return new Guid((string)parameters[0]);
			case 10:
				throw new ArgumentException();
			case 1:
				if (parameters[0] is string)
				{
					num2 = 3;
					break;
				}
				goto IL_006c;
			case 11:
				if (!(parameters[0] is string))
				{
					num2 = 8;
					break;
				}
				goto case 2;
			case 3:
				if (jCHaVkGJIx5yfl8yuW6a((string)parameters[0], TRc3ntGJuoaSh4rJTQjs(0xE1229CF ^ 0xE1639CB), StringComparison.OrdinalIgnoreCase))
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 11;
					}
					break;
				}
				goto IL_006c;
			case 2:
				if (!jCHaVkGJIx5yfl8yuW6a((string)parameters[0], TRc3ntGJuoaSh4rJTQjs(0x3A5D5EF ^ 0x3A1C5F9), StringComparison.OrdinalIgnoreCase))
				{
					num2 = 9;
					break;
				}
				goto default;
			case 7:
				if (!(parameters[0] is string))
				{
					num2 = 10;
					break;
				}
				goto case 6;
			case 4:
				{
					if (parameters.Length == 1)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_006c;
				}
				IL_006c:
				if (parameters.Length == 1)
				{
					num2 = 11;
					break;
				}
				goto case 8;
			}
		}
	}

	public IEnumerable<EQLFunction> GetEqlFunctions()
	{
		return new EQLFunction[1]
		{
			new EQLFunction
			{
				DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099567063), FunctionName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787186367))),
				Description = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87313709)),
				Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307A8F89), FunctionName),
				Types = new Guid[1] { GuidDescriptor.UID }
			}
		};
	}

	public GuidQueryResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OR1iCaGJSU6agJOpU6FD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object TRc3ntGJuoaSh4rJTQjs(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool vynMLEGJ8LURp0wXmhDd()
	{
		return EAoucqGJvdh3WxNa2O0Q == null;
	}

	internal static GuidQueryResult xZD3xqGJZQGHBZKJ8R2g()
	{
		return EAoucqGJvdh3WxNa2O0Q;
	}

	internal static bool jCHaVkGJIx5yfl8yuW6a(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static Guid Yk3VBlGJVu3N6wgoRJ8V()
	{
		return Guid.NewGuid();
	}

	internal static void OR1iCaGJSU6agJOpU6FD()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
