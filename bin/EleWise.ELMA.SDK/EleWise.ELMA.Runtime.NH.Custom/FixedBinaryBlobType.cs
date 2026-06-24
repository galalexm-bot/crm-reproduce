using System;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.SqlTypes;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public class FixedBinaryBlobType : FixedBinaryType
{
	private static FixedBinaryBlobType omopddWmffda4PVmkoFi;

	public override string Name => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138281818);

	internal FixedBinaryBlobType()
	{
		//Discarded unreachable code: IL_002f, IL_0034
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		gpvpqSWmvp6dcCmyTxH4();
		base._002Ector((BinarySqlType)new BinaryBlobSqlType());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal FixedBinaryBlobType(BinarySqlType sqlType)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		gpvpqSWmvp6dcCmyTxH4();
		base._002Ector(sqlType);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public static void RegisterInTypeFactory()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				TypeFactoryExtensions.ReRegisterType((IType)(object)NHibernateUtil.BinaryBlob, new string[0], (int l) => TypeFactoryExtensions.GetType((NullableType)(object)NHibernateUtil.BinaryBlob, l, (int len) => (NullableType)(object)new FixedBinaryBlobType((BinarySqlType)_003C_003Ec.S6kAy8QYakDYneUIKkB6(len))));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void gpvpqSWmvp6dcCmyTxH4()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool Mp2KJeWmQPO56vG5mTCi()
	{
		return omopddWmffda4PVmkoFi == null;
	}

	internal static FixedBinaryBlobType BWobynWmCi4sZoVFZuts()
	{
		return omopddWmffda4PVmkoFi;
	}
}
