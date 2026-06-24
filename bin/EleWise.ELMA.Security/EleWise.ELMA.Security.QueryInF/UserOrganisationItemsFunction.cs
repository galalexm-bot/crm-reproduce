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
internal class UserOrganisationItemsFunction : IQueryInFunction, IEQLFunction
{
	private static UserOrganisationItemsFunction HTPVfbxrk1gal0WEmWR;

	public string FunctionName => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4E6718AE ^ 0x4E675CB0);

	public ICriterion GetCriterion(string alias, EntityMetadata metadata, string propName, object[] parameters)
	{
		//Discarded unreachable code: IL_01db, IL_01ea
		int num = 2;
		int num2 = num;
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (!sG5AS5x9gu7xtuCeP1h(r5Oh4exSNJ7R0uq4VX2(parameters[1].ToString()), F49TdaxbL5KUvvTVI4k(-2030777218 ^ -2030794740)))
				{
					num2 = 3;
					continue;
				}
				goto case 4;
			default:
				if (parameters.Length == 2)
				{
					num2 = 7;
					continue;
				}
				goto case 3;
			case 5:
				return (ICriterion)umTo2tBkMYRTCV22nGI(Tg94t3xz0QuAw71LWwE(F49TdaxbL5KUvvTVI4k(-1965109395 ^ -1965126893), new object[7]
				{
					propName,
					aViClmx1pFSa2HIsS2Y(PWUP66xfRSV7fN1fbFG(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5EE4A7B ^ 0x5EE0F7D)),
					((Dialect)PWUP66xfRSV7fN1fbFG(serviceNotNull)).QuoteIfNeeded((string)F49TdaxbL5KUvvTVI4k(-1429357207 ^ -1429340879)),
					aViClmx1pFSa2HIsS2Y(PWUP66xfRSV7fN1fbFG(serviceNotNull), F49TdaxbL5KUvvTVI4k(-566078848 ^ -566079078)),
					parameters[0],
					text,
					alias
				}));
			case 2:
				if (parameters.Length != 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 4:
				text = "";
				num2 = 6;
				continue;
			case 3:
			case 6:
				serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
				{
					num2 = 5;
				}
				continue;
			case 1:
				if (parameters.Length != 2)
				{
					throw new ArgumentException();
				}
				num2 = 8;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 == 0)
				{
					num2 = 1;
				}
				continue;
			case 8:
				break;
			}
			text = (string)F49TdaxbL5KUvvTVI4k(0x22A54A05 ^ 0x22A50E49);
			num2 = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d == 0)
			{
				num2 = 0;
			}
		}
	}

	public IEnumerable<EQLFunction> GetEqlFunctions()
	{
		return new EQLFunction[1]
		{
			new EQLFunction
			{
				DisplayName = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xCDF201B ^ 0xCDF6507), FunctionName, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D765E72 ^ 0x4D761FD8)), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1687496463 ^ -1687511605))),
				Description = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--561310391 ^ 0x2174AFE5)),
				Value = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1365352774 ^ -1365369282), FunctionName),
				Types = new Guid[1] { InterfaceActivator.UID<IOrganizationItem>(loadImplementation: false) }
			}
		};
	}

	public UserOrganisationItemsFunction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nlHGKMBpA2InA0mkwQp();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool mCSMssx3hSiGgDTp36g()
	{
		return HTPVfbxrk1gal0WEmWR == null;
	}

	internal static UserOrganisationItemsFunction msDO84xyplJXQdiyOP9()
	{
		return HTPVfbxrk1gal0WEmWR;
	}

	internal static object F49TdaxbL5KUvvTVI4k(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object r5Oh4exSNJ7R0uq4VX2(object P_0)
	{
		return ((string)P_0).ToLowerInvariant();
	}

	internal static bool sG5AS5x9gu7xtuCeP1h(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object PWUP66xfRSV7fN1fbFG(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object aViClmx1pFSa2HIsS2Y(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object Tg94t3xz0QuAw71LWwE(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object umTo2tBkMYRTCV22nGI(object P_0)
	{
		return NHQueryExtensions.Sql((string)P_0);
	}

	internal static void nlHGKMBpA2InA0mkwQp()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
