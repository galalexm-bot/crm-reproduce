using System;
using System.Collections.Generic;
using System.Diagnostics;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Context;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services.Impl;

[Service(EnableInterceptors = false, Type = (ComponentType.Server | ComponentType.WebServer | ComponentType.Web | ComponentType.DesignServer | ComponentType.Test))]
public class TLSContextBoundVariableService : SimpleBoundVariableServiceBase
{
	[Obsolete("Not used", true)]
	protected const string key = "EleWise.ELMA.Web.Mvc.Services.TLSContextBoundVariableService.table";

	private static TLSContextBoundVariableService wmjChvBMLVgDoaMsWy2J;

	protected override IDictionary<string, object> Dictionary => ELMAContext.Items;

	public override bool Contains(string name)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return base.Contains(name);
			case 1:
				if (!DtG6dbBMcJq8teqguU4K())
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override bool TryGetValue<T>(string name, out T value)
	{
		if (!ELMAContext.Initialized)
		{
			value = default(T);
			return false;
		}
		return base.TryGetValue<T>(name, out value);
	}

	protected override void ClearContext()
	{
		//Discarded unreachable code: IL_0039, IL_0048
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (!mJ67SuBMzj4skNkAoWwG(PublishCacheContext.logger))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 1:
			case 2:
				base.ClearContext();
				num2 = 3;
				break;
			case 3:
				return;
			default:
				PublishCacheContext.logger.WarnFormat((string)dXT95WBJFxTEWCNF3uac(-629844702 ^ -629915754), Ks3oYpBJBVGf43ZCJ2W8(), new StackTrace(fNeedFileInfo: true));
				num2 = 2;
				break;
			case 5:
				if (!DtG6dbBMcJq8teqguU4K())
				{
					return;
				}
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override void Remove(string key)
	{
		//Discarded unreachable code: IL_0031
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 2:
				if (!ELMAContext.Initialized)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 3:
				break;
			case 0:
				return;
			}
			base.Remove(key);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
			{
				num2 = 0;
			}
		}
	}

	public TLSContextBoundVariableService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tvGjqABJWSL1ADQPVu05();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool DtG6dbBMcJq8teqguU4K()
	{
		return ELMAContext.Initialized;
	}

	internal static bool nvSBgpBMUQ67RdLBAKx5()
	{
		return wmjChvBMLVgDoaMsWy2J == null;
	}

	internal static TLSContextBoundVariableService rreRr8BMso02flT7lMNy()
	{
		return wmjChvBMLVgDoaMsWy2J;
	}

	internal static bool mJ67SuBMzj4skNkAoWwG(object P_0)
	{
		return ((ILogger)P_0).IsWarnEnabled();
	}

	internal static object dXT95WBJFxTEWCNF3uac(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Ks3oYpBJBVGf43ZCJ2W8()
	{
		return Environment.NewLine;
	}

	internal static void tvGjqABJWSL1ADQPVu05()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
