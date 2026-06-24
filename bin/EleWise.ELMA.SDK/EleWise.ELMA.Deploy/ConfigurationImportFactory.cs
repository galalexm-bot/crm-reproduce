using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy;

[Service]
internal sealed class ConfigurationImportFactory : IConfigurationImportFactory
{
	private readonly IConfigurationImportInternalFactory internalFactory;

	private static ConfigurationImportFactory N8Z5KKEOA63usFKcoT4f;

	public ConfigurationImportFactory(IConfigurationImportInternalFactory internalFactory)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OULAGYEO0ToRwGNBjA2i();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
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
			this.internalFactory = internalFactory;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
			{
				num = 1;
			}
		}
	}

	public IConfigurationTester CreateTester(IImportSettings importSettings)
	{
		return internalFactory.CreateTester(importSettings);
	}

	public IConfigurationImporter CreateImporter(IImportSettings importSettings)
	{
		return (IConfigurationImporter)y3PjDHEOmb4mVh1Jlk5t(internalFactory, importSettings);
	}

	internal static void OULAGYEO0ToRwGNBjA2i()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool QyR7L9EO7u0lWJt5JJju()
	{
		return N8Z5KKEOA63usFKcoT4f == null;
	}

	internal static ConfigurationImportFactory uyMmwuEOxaEYhHYeVdXX()
	{
		return N8Z5KKEOA63usFKcoT4f;
	}

	internal static object y3PjDHEOmb4mVh1Jlk5t(object P_0, object P_1)
	{
		return ((IConfigurationImportInternalFactory)P_0).CreateImporter((IImportSettings)P_1);
	}
}
