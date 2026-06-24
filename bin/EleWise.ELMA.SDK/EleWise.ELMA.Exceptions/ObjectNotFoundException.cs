using System;
using System.Runtime.Serialization;
using System.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class ObjectNotFoundException : SecurityException
{
	private string objectName;

	private object objectId;

	private static ObjectNotFoundException DRDICOGjHujDg8N0AMm9;

	public string ObjectName => objectName;

	public object ObjectId => objectId;

	protected static string MessageNamedObjectNotFound => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309371772));

	protected static string MessageObjectNotFound => (string)wIJd0vGj95K19kmHfwDF(Qq0NHbGjJuC0752ONfwp(-1751176224 ^ -1751437176));

	public ObjectNotFoundException()
	{
		//Discarded unreachable code: IL_002f, IL_0034
		vQksfLGjxEHhBUXDnlmp();
		base._002Ector((string)I6l0OJGj0M4wFwEnTFUG());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ObjectNotFoundException(string objectName)
	{
		//Discarded unreachable code: IL_0035, IL_003a
		SingletonReader.JJCZtPuTvSt();
		base._002Ector((string)UYmLw1GjyVYWJuDWyNXU(aeLumlGjmfnKeX4OU9St(), objectName));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.objectName = objectName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ObjectNotFoundException(string objectName, string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		vQksfLGjxEHhBUXDnlmp();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.objectName = objectName;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
			{
				num = 1;
			}
		}
	}

	public ObjectNotFoundException(string objectName, object objectId)
	{
		//Discarded unreachable code: IL_004b, IL_0050
		vQksfLGjxEHhBUXDnlmp();
		base._002Ector((string)UYmLw1GjyVYWJuDWyNXU(aeLumlGjmfnKeX4OU9St(), dontXcGjMJiK8LvGTTld(objectName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787399641), objectId)));
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 1:
				this.objectName = objectName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num = 0;
				}
				break;
			default:
				this.objectId = objectId;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public ObjectNotFoundException(string objectName, object objectId, string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.objectId = objectId;
				num = 2;
				break;
			case 2:
				return;
			case 1:
				this.objectName = objectName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected ObjectNotFoundException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		vQksfLGjxEHhBUXDnlmp();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void vQksfLGjxEHhBUXDnlmp()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object I6l0OJGj0M4wFwEnTFUG()
	{
		return MessageObjectNotFound;
	}

	internal static bool iLSnliGjALZlLjnRuDYK()
	{
		return DRDICOGjHujDg8N0AMm9 == null;
	}

	internal static ObjectNotFoundException xQbS05Gj7kMUkP7iryhF()
	{
		return DRDICOGjHujDg8N0AMm9;
	}

	internal static object aeLumlGjmfnKeX4OU9St()
	{
		return MessageNamedObjectNotFound;
	}

	internal static object UYmLw1GjyVYWJuDWyNXU(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object dontXcGjMJiK8LvGTTld(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static object Qq0NHbGjJuC0752ONfwp(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object wIJd0vGj95K19kmHfwDF(object P_0)
	{
		return SR.T((string)P_0);
	}
}
