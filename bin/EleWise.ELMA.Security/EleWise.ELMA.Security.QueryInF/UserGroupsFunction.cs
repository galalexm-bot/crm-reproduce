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
internal class UserGroupsFunction : IQueryInFunction, IEQLFunction
{
	private static UserGroupsFunction cjHQ7PxYykn4qUHGcnS;

	public string FunctionName => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46347DA6 ^ 0x46343EFA);

	public ICriterion GetCriterion(string alias, EntityMetadata metadata, string propName, object[] parameters)
	{
		int num = 1;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentException();
			case 1:
				if (parameters.Length == 1)
				{
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1a646659a464f3fa5c9aedc64725d72 == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 2:
				return (ICriterion)TaXuDKxgfj36hp6DFPw(J5hNLtxT8kBe2Y84w3A(qqnv6VxVu6gR2eHuRYf(0x74C28149 ^ 0x74C2C23D), new object[6]
				{
					propName,
					((Dialect)h7GPfJxQEKJKSu4nhmn(serviceNotNull)).QuoteIfNeeded((string)qqnv6VxVu6gR2eHuRYf(0x6A336151 ^ 0x6A337149)),
					serviceNotNull.Dialect.QuoteIfNeeded((string)qqnv6VxVu6gR2eHuRYf(0x65F93013 ^ 0x65F9704B)),
					stIh8Bxd0uehX6jxc8I(h7GPfJxQEKJKSu4nhmn(serviceNotNull), qqnv6VxVu6gR2eHuRYf(0x37FE8EDE ^ 0x37FE8DC4)),
					parameters[0],
					alias
				}));
			}
		}
	}

	public IEnumerable<EQLFunction> GetEqlFunctions()
	{
		return new EQLFunction[1]
		{
			new EQLFunction
			{
				DisplayName = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D765E72 ^ 0x4D761FE4), FunctionName, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1365352774 ^ -1365369072))),
				Description = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1076846736 ^ -1076831100)),
				Value = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2C648300 ^ 0x2C64C384), FunctionName),
				Types = new Guid[1] { InterfaceActivator.UID<IUserGroup>(loadImplementation: false) }
			}
		};
	}

	public UserGroupsFunction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		VMJvL8x8kDJRBWidnv7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool C7j6q5xIF02tVvlouwD()
	{
		return cjHQ7PxYykn4qUHGcnS == null;
	}

	internal static UserGroupsFunction hpaYEux40u1LCMGnMDO()
	{
		return cjHQ7PxYykn4qUHGcnS;
	}

	internal static object qqnv6VxVu6gR2eHuRYf(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object h7GPfJxQEKJKSu4nhmn(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object stIh8Bxd0uehX6jxc8I(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object J5hNLtxT8kBe2Y84w3A(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object TaXuDKxgfj36hp6DFPw(object P_0)
	{
		return NHQueryExtensions.Sql((string)P_0);
	}

	internal static void VMJvL8x8kDJRBWidnv7()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
