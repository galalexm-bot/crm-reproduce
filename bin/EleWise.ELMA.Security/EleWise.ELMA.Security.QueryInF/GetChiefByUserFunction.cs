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
internal class GetChiefByUserFunction : IQueryInFunction, IEQLFunction
{
	private static GetChiefByUserFunction WxFBCdxLlAYIn7ygtgG;

	public string FunctionName => (string)mXWCuWxavG3v9HmeKot(0x71BC7C31 ^ 0x71BC3CFF);

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
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
					{
						num2 = 1;
					}
				}
				break;
			default:
				return (ICriterion)pnT3TyxPSYkKURDJbfd(waFkhKx2kwi6bNAhL5c(mXWCuWxavG3v9HmeKot(0x4BBFF2C6 ^ 0x4BBFB228), new object[6]
				{
					propName,
					gkdvOFxRJKXSaSIjrPN(serviceNotNull.Dialect, mXWCuWxavG3v9HmeKot(-714706387 ^ -714706633)),
					gkdvOFxRJKXSaSIjrPN(rCH1r4xwNT4E3wW2g7c(serviceNotNull), mXWCuWxavG3v9HmeKot(0xAEB118D ^ 0xAEB51D5)),
					((Dialect)rCH1r4xwNT4E3wW2g7c(serviceNotNull)).QuoteIfNeeded((string)mXWCuWxavG3v9HmeKot(0x31C71464 ^ 0x31C75514)),
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
				DisplayName = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4BBFF2C6 ^ 0x4BBFB350), FunctionName, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x23D92C6F ^ 0x23D96DC5))),
				Description = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFD0849E ^ 0xFD0C552)),
				Value = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x23D92C6F ^ 0x23D96CEB), FunctionName),
				Types = new Guid[1] { InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(loadImplementation: false) }
			}
		};
	}

	public GetChiefByUserFunction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kVjb8hxv9cJlWD1Sh7T();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object mXWCuWxavG3v9HmeKot(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool d1eJ7HxjA2hkuNKa2B9()
	{
		return WxFBCdxLlAYIn7ygtgG == null;
	}

	internal static GetChiefByUserFunction ioTJiixHdC2yq4tqv4c()
	{
		return WxFBCdxLlAYIn7ygtgG;
	}

	internal static object gkdvOFxRJKXSaSIjrPN(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object rCH1r4xwNT4E3wW2g7c(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object waFkhKx2kwi6bNAhL5c(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object pnT3TyxPSYkKURDJbfd(object P_0)
	{
		return NHQueryExtensions.Sql((string)P_0);
	}

	internal static void kVjb8hxv9cJlWD1Sh7T()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
