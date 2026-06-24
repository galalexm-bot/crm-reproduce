using System;
using System.Configuration;
using System.Web.Configuration;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Configuration;

public class AssemblyBuilderSection : ConfigurationSection
{
	private static ConfigurationPropertyCollection _properties;

	private static readonly ConfigurationProperty _propAssemblies;

	private static readonly ConfigurationProperty _propModelAssemblies;

	internal static AssemblyBuilderSection PK3MJqfBxvYdM9PKVy8p;

	[ConfigurationProperty("assemblies")]
	public AssemblyCollection Assemblies => (AssemblyCollection)base[_propAssemblies];

	[ConfigurationProperty("modelAssemblies")]
	public AssemblyCollection ModelAssemblies => (AssemblyCollection)CoAS7mfB9BNFBUap2ijf(this, _propModelAssemblies);

	protected internal override ConfigurationPropertyCollection Properties
	{
		protected get
		{
			return _properties;
		}
	}

	static AssemblyBuilderSection()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				mq3dS1fBy5Nwu3ChxJAD();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			case 5:
				_propAssemblies = new ConfigurationProperty((string)OhSLmjfBMRWmrafJAg8d(0x53CACA3 ^ 0x53CD921), wRNOtefBJIlUIRQUOl9t(typeof(AssemblyCollection).TypeHandle), null, ConfigurationPropertyOptions.IsDefaultCollection);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				_propModelAssemblies = new ConfigurationProperty((string)OhSLmjfBMRWmrafJAg8d(0x3A5D5EF ^ 0x3A0C563), wRNOtefBJIlUIRQUOl9t(typeof(AssemblyCollection).TypeHandle), null, ConfigurationPropertyOptions.IsDefaultCollection);
				num2 = 3;
				break;
			case 3:
				_properties.Add(_propAssemblies);
				num2 = 4;
				break;
			default:
				_properties = new ConfigurationPropertyCollection();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public AssemblyBuilderSection()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mq3dS1fBy5Nwu3ChxJAD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void mq3dS1fBy5Nwu3ChxJAD()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object OhSLmjfBMRWmrafJAg8d(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type wRNOtefBJIlUIRQUOl9t(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool L9RHCifB0Iy6UOASWWHn()
	{
		return PK3MJqfBxvYdM9PKVy8p == null;
	}

	internal static AssemblyBuilderSection JB5mk3fBmG4FPVmLshpO()
	{
		return PK3MJqfBxvYdM9PKVy8p;
	}

	internal static object CoAS7mfB9BNFBUap2ijf(object P_0, object P_1)
	{
		return ((ConfigurationElement)P_0)[(ConfigurationProperty)P_1];
	}
}
