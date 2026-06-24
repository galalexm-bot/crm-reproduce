using System;
using j3AmrhgkCleVTGdEwA;
using NHibernate.SqlTypes;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.CustomTypes;

[Serializable]
public class FixedBinaryType : FixedAbstractBinaryType
{
	internal static FixedBinaryType C1eXjGWm8eahCxJXM7M8;

	public override Type ReturnedClass => mXNKPnWmVXkpGe0oAkAy(typeof(byte[]).TypeHandle);

	public override string Name => (string)Nlhh6yWmSLIdT9fSgAsB(-882126494 ^ -882246764);

	internal FixedBinaryType()
	{
		//Discarded unreachable code: IL_002f, IL_0034
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(new BinarySqlType());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal FixedBinaryType(BinarySqlType sqlType)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		ObFl1UWmIZPc511eRJcC();
		base._002Ector(sqlType);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected internal override object ToExternalFormat(byte[] bytes)
	{
		return bytes;
	}

	protected internal override byte[] ToInternalFormat(object bytes)
	{
		return (byte[])bytes;
	}

	public override int Compare(object x, object y)
	{
		return 0;
	}

	internal static bool haio6CWmZFTpYAYH0kOo()
	{
		return C1eXjGWm8eahCxJXM7M8 == null;
	}

	internal static FixedBinaryType rLabywWmuBXoWEijNUXm()
	{
		return C1eXjGWm8eahCxJXM7M8;
	}

	internal static void ObFl1UWmIZPc511eRJcC()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type mXNKPnWmVXkpGe0oAkAy(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Nlhh6yWmSLIdT9fSgAsB(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
