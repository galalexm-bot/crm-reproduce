using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

public class XmlSerializerAttribute : Attribute
{
	private string typeName;

	internal static XmlSerializerAttribute dlaI2UBrK2yTwSChgAi4;

	public Type SerializerType
	{
		get
		{
			Type type = CVG0kCBrnV7PTDdJp3Y2(typeName);
			if (jFnerjBrOfkwdyrvTgqo(type, null))
			{
				throw new TypeLoadException(string.Format((string)pMXgnaBr2CCJwFMBmBC5(-1123633026 ^ -1123561896), typeName));
			}
			return type;
		}
	}

	public XmlSerializerAttribute(string typeName)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		oeRjoiBrk1dfDEg8JvWb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
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
			this.typeName = typeName;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
			{
				num = 1;
			}
		}
	}

	internal static void oeRjoiBrk1dfDEg8JvWb()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool XEVO85BrXm9I4J3oMXNp()
	{
		return dlaI2UBrK2yTwSChgAi4 == null;
	}

	internal static XmlSerializerAttribute nQ1afnBrT6CqcEQQkrwC()
	{
		return dlaI2UBrK2yTwSChgAi4;
	}

	internal static Type CVG0kCBrnV7PTDdJp3Y2(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static bool jFnerjBrOfkwdyrvTgqo(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object pMXgnaBr2CCJwFMBmBC5(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
