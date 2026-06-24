using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.QueryFunctionResults;

[Component]
public class CurrentUserQueryResult : IQueryFunctionResult, IEQLFunction
{
	internal static CurrentUserQueryResult OUcHeoB5Yt9UcmC0lMq;

	public string FunctionName => (string)AN5UtFBXAwjKUWFPlXR(-1084772212 ^ -1084754608);

	public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>().Id;
			case 1:
				if (parameters.Length != 0)
				{
					throw new ArgumentException();
				}
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
				{
					num2 = 0;
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
				DisplayName = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1687496463 ^ -1687512971), FunctionName),
				Description = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-959661060 ^ -959644150)),
				Value = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x28EBA022 ^ 0x28EBE0A6), FunctionName),
				Types = new Guid[1] { InterfaceActivator.UID<EleWise.ELMA.Security.Models.IUser>(loadImplementation: false) }
			}
		};
	}

	public CurrentUserQueryResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dWGv6gBn0nAsxsleMu3();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object AN5UtFBXAwjKUWFPlXR(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool OY8wTQBAOkV3JEC46yK()
	{
		return OUcHeoB5Yt9UcmC0lMq == null;
	}

	internal static CurrentUserQueryResult xUdtbtBWYgmDhS4yXML()
	{
		return OUcHeoB5Yt9UcmC0lMq;
	}

	internal static void dWGv6gBn0nAsxsleMu3()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
