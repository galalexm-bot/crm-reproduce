using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;

namespace EleWise.ELMA.Runtime.Db;

public abstract class MapIdentityProvider : IMapIdentityProvider
{
	protected const string MaxLoParamValue = "100";

	private static MapIdentityProvider OQ0FXtWity8LDUTAsOkY;

	public static IMapIdentityProvider CurrentThreadProvider { get; set; }

	public abstract void SetGenerator(IIdMapper mapping, string tableName, string idColumnName);

	protected MapIdentityProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NikbboWi67kXbT9GM4rW();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void NikbboWi67kXbT9GM4rW()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool JoRok7WiwZZUsBE5Qlgu()
	{
		return OQ0FXtWity8LDUTAsOkY == null;
	}

	internal static MapIdentityProvider YpWkBUWi4auI4diNFfJc()
	{
		return OQ0FXtWity8LDUTAsOkY;
	}
}
