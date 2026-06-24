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
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.QueryInFunctions;

[Component]
internal class GroupUsersFunction : IQueryInFunction, IEQLFunction
{
	internal static GroupUsersFunction KlhDCYxcooE9NGweVrC;

	public string FunctionName => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1429357207 ^ -1429340259);

	public ICriterion GetCriterion(string alias, EntityMetadata metadata, string propName, object[] parameters)
	{
		int num = 2;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			case 1:
				throw new ArgumentException();
			case 2:
				if (parameters.Length == 1)
				{
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
					{
						num2 = 1;
					}
				}
				break;
			default:
				return (ICriterion)Y7qwv9xMwLln7UpPPbU(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x416A5E3C ^ 0x416A61CC), propName, GPd6wjxDwnwOKohe7jB(AKOOblx0hIJyhMqxxMF(serviceNotNull), S3nFxMxELTiiswkGmC4(0x67DFA65E ^ 0x67DFA544)), GPd6wjxDwnwOKohe7jB(AKOOblx0hIJyhMqxxMF(serviceNotNull), S3nFxMxELTiiswkGmC4(0xC66FB14 ^ 0xC66BB4C)), GPd6wjxDwnwOKohe7jB(serviceNotNull.Dialect, S3nFxMxELTiiswkGmC4(0x1B3723C5 ^ 0x1B3733DD)), parameters[0], alias));
			}
		}
	}

	public IEnumerable<EQLFunction> GetEqlFunctions()
	{
		return new EQLFunction[1]
		{
			new EQLFunction
			{
				DisplayName = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E5BC59F ^ 0x3E5B8409), FunctionName, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1365352774 ^ -1365369418))),
				Description = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74C28149 ^ 0x74C2C26B)),
				Value = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1076846736 ^ -1076830220), FunctionName),
				Types = new Guid[1] { InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(loadImplementation: false) }
			}
		};
	}

	public GroupUsersFunction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ATeHmSxsAKNj70UOu8P();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool tZ0l97xGwiCbcfWByCF()
	{
		return KlhDCYxcooE9NGweVrC == null;
	}

	internal static GroupUsersFunction dKpco1xF4fXex3IZNml()
	{
		return KlhDCYxcooE9NGweVrC;
	}

	internal static object AKOOblx0hIJyhMqxxMF(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object S3nFxMxELTiiswkGmC4(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object GPd6wjxDwnwOKohe7jB(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object Y7qwv9xMwLln7UpPPbU(object P_0)
	{
		return NHQueryExtensions.Sql((string)P_0);
	}

	internal static void ATeHmSxsAKNj70UOu8P()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
