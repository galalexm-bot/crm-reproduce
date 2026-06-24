using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Notifications.Impl.RecipientTypeHandlers;

[Component]
internal class UserIdRecipientHandler : INotificationRecipientTypeHandler
{
	private static UserIdRecipientHandler HOqGWeJPZvOoREBG2e1;

	public UserManager UserManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUserManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CUserManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string Name => (string)cQdhseJUOca4dLtDvV1(0x51BB29A6 ^ 0x51BB2ABC);

	public IEnumerable<object> GetRecipients(object value)
	{
		Contract.ServiceNotNull(UserManager, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xC66FB14 ^ 0xC668F00));
		if (value == null)
		{
			return new object[0];
		}
		if (value is long[])
		{
			long[] idArray = value as long[];
			return UserManager.FindByIdArray(idArray);
		}
		long id;
		try
		{
			id = Convert.ToInt64(value);
		}
		catch (Exception innerException)
		{
			throw new Exception(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-95913524 ^ -95941150), value, value.GetType().FullName), innerException);
		}
		EleWise.ELMA.Security.Models.IUser user = UserManager.Load(id);
		if (user == null)
		{
			return new object[0];
		}
		return new object[1] { user };
	}

	public UserIdRecipientHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Xrfp3oJohRMUPWw4F9V();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ztktsCJvVX7Cs46HFT3()
	{
		return HOqGWeJPZvOoREBG2e1 == null;
	}

	internal static UserIdRecipientHandler JgIuhyJC0e6cWQl4P9y()
	{
		return HOqGWeJPZvOoREBG2e1;
	}

	internal static object cQdhseJUOca4dLtDvV1(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Xrfp3oJohRMUPWw4F9V()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
