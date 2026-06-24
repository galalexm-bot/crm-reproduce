using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.QueryInFunctions;

[Component]
internal class CurrentUserGroupsFunction : IQueryInFunction, IEQLFunction
{
	private static CurrentUserGroupsFunction MIhtW4x6xQ7NLvVFM0v;

	public string FunctionName => (string)yqDsnRxZp7NZUy1fQrP(0x11C59687 ^ 0x11C5A94D);

	public ICriterion GetCriterion(string alias, EntityMetadata metadata, string propName, object[] parameters)
	{
		//Discarded unreachable code: IL_0118, IL_0127
		int num = 1;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (parameters.Length == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 3:
				return (ICriterion)nhoHHnxmZnbHyMCuw4y(J7gWTnxucBX2NCRlM3d(yqDsnRxZp7NZUy1fQrP(-1195916818 ^ -1195901410), new object[6]
				{
					propName,
					UxQ5FHxBHMDxKA1xMKQ(Jbjq3ExxGgndlKHm0wk(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B1D6430 ^ 0x3B1D7428)),
					UxQ5FHxBHMDxKA1xMKQ(Jbjq3ExxGgndlKHm0wk(serviceNotNull), yqDsnRxZp7NZUy1fQrP(-848444002 ^ -848460346)),
					UxQ5FHxBHMDxKA1xMKQ(Jbjq3ExxGgndlKHm0wk(serviceNotNull), yqDsnRxZp7NZUy1fQrP(-1973849202 ^ -1973849964)),
					AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>().Id,
					alias
				}));
			case 2:
				throw new ArgumentException();
			default:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public IEnumerable<EQLFunction> GetEqlFunctions()
	{
		return new EQLFunction[1]
		{
			new EQLFunction
			{
				DisplayName = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B056A9C ^ 0x3B052A18), FunctionName),
				Description = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x116C2699 ^ 0x116C660B)),
				Value = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-179348817 ^ -179365333), FunctionName),
				Types = new Guid[1] { InterfaceActivator.UID<IUserGroup>(loadImplementation: false) }
			}
		};
	}

	public CurrentUserGroupsFunction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ysfj9dxeKA9HkaBZQWP();
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

	internal static object yqDsnRxZp7NZUy1fQrP(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool mZ1mD2xltSJqeGnL86X()
	{
		return MIhtW4x6xQ7NLvVFM0v == null;
	}

	internal static CurrentUserGroupsFunction KWwNlyxNlVxIK9xvCug()
	{
		return MIhtW4x6xQ7NLvVFM0v;
	}

	internal static object Jbjq3ExxGgndlKHm0wk(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object UxQ5FHxBHMDxKA1xMKQ(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object J7gWTnxucBX2NCRlM3d(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object nhoHHnxmZnbHyMCuw4y(object P_0)
	{
		return NHQueryExtensions.Sql((string)P_0);
	}

	internal static void Ysfj9dxeKA9HkaBZQWP()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
