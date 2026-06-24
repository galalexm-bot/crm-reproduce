using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Components;

[Component(Order = 10)]
public class UserEntityUserTypeSelector : BaseEntityUserTypeSelector
{
	public const string PREFIX = "User";

	internal static UserEntityUserTypeSelector D2YbOezA8IyXrv4euVF;

	public override Type EntityType => InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>();

	public override string Prefix => (string)pBPYxnznye1pyLtaGXE(0x2121ECF9 ^ 0x2121E325);

	public override string DisplayName => SR.T((string)pBPYxnznye1pyLtaGXE(-225736894 ^ -225728520));

	public override List<EleWise.ELMA.Security.Models.IUser> ExtractUsers(string value)
	{
		EleWise.ELMA.Security.Models.IUser item = (EleWise.ELMA.Security.Models.IUser)GetEntity(value);
		return new List<EleWise.ELMA.Security.Models.IUser> { item };
	}

	public UserEntityUserTypeSelector()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QjplLiziVQdj6PA8lJ0();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object pBPYxnznye1pyLtaGXE(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool VhaxmCzWp2mcN62bfPo()
	{
		return D2YbOezA8IyXrv4euVF == null;
	}

	internal static UserEntityUserTypeSelector Eq4DbVzXuoRNxWRH1h5()
	{
		return D2YbOezA8IyXrv4euVF;
	}

	internal static void QjplLiziVQdj6PA8lJ0()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
