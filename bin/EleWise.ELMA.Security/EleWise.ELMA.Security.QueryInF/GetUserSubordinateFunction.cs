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
internal class GetUserSubordinateFunction : IQueryInFunction, IEQLFunction
{
	private static GetUserSubordinateFunction Ia9bc5xCAl6NHetWVN4;

	public string FunctionName => (string)PJJtGwxJWUhuwZAAyev(0xCD88DD8 ^ 0xCD8CFDE);

	public ICriterion GetCriterion(string alias, EntityMetadata metadata, string propName, object[] parameters)
	{
		int num = 1;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (parameters.Length != 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
					{
						num2 = 0;
					}
					break;
				}
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 != 0)
				{
					num2 = 2;
				}
				break;
			default:
				throw new ArgumentException();
			case 2:
				return (ICriterion)NIWFoxxOoM1qXgOw3IE(R1grvexhhcUxWblu3bj(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1027693337 ^ -1027676471), new object[6]
				{
					propName,
					oJOkkAxtyOcY6kIyGCl(Krj0OQxKOdXTvW88B8Y(serviceNotNull), PJJtGwxJWUhuwZAAyev(0x6A336151 ^ 0x6A332021)),
					oJOkkAxtyOcY6kIyGCl(Krj0OQxKOdXTvW88B8Y(serviceNotNull), PJJtGwxJWUhuwZAAyev(-230994601 ^ -231011057)),
					oJOkkAxtyOcY6kIyGCl(Krj0OQxKOdXTvW88B8Y(serviceNotNull), PJJtGwxJWUhuwZAAyev(-1943394692 ^ -1943394970)),
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
				DisplayName = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1826813434 ^ -1826796656), FunctionName, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x487E82CC ^ 0x487EC366))),
				Description = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x271B34E4 ^ 0x271B765C)),
				Value = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-566078848 ^ -566095356), FunctionName),
				Types = new Guid[1] { InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(loadImplementation: false) }
			}
		};
	}

	public GetUserSubordinateFunction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		a3sEedxqDxIvUM8SZ6W();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object PJJtGwxJWUhuwZAAyev(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool JcdhFKxUHqtsnPQoGPJ()
	{
		return Ia9bc5xCAl6NHetWVN4 == null;
	}

	internal static GetUserSubordinateFunction kJVTcaxoxa4BjWMSxNx()
	{
		return Ia9bc5xCAl6NHetWVN4;
	}

	internal static object Krj0OQxKOdXTvW88B8Y(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object oJOkkAxtyOcY6kIyGCl(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object R1grvexhhcUxWblu3bj(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object NIWFoxxOoM1qXgOw3IE(object P_0)
	{
		return NHQueryExtensions.Sql((string)P_0);
	}

	internal static void a3sEedxqDxIvUM8SZ6W()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
