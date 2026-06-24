using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Notifications;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Notifications.Impl.RecipientTypeHandlers;

[Component]
internal class UserRecipientHandler : INotificationRecipientTypeHandler
{
	private static UserRecipientHandler gm3fu5JJUjY81ECB9VC;

	public string Name => (string)goZiKJJhjDMxWJs4vGf(0x416A5E3C ^ 0x416A51E0);

	public IEnumerable<object> GetRecipients(object value)
	{
		if (value == null)
		{
			return new object[0];
		}
		if (value is IEnumerable enumerable)
		{
			List<object> list = new List<object>();
			{
				foreach (object item in enumerable)
				{
					if (item is IUser)
					{
						list.Add((IUser)item);
					}
				}
				return list;
			}
		}
		if (!(value is IUser))
		{
			throw new ArgumentException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31274285 ^ 0x31273601), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1429357207 ^ -1429354107));
		}
		if (!(value is IUser))
		{
			return new object[0];
		}
		return new object[1] { value };
	}

	public UserRecipientHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EZTtdJJOT4MC7oWl3kR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object goZiKJJhjDMxWJs4vGf(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool TvRVa6JKUrdQZ5UKvMq()
	{
		return gm3fu5JJUjY81ECB9VC == null;
	}

	internal static UserRecipientHandler jnDPAfJtlB6wwKNmKp3()
	{
		return gm3fu5JJUjY81ECB9VC;
	}

	internal static void EZTtdJJOT4MC7oWl3kR()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
