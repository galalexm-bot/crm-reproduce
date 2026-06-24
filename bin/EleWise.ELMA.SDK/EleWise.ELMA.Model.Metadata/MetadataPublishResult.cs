using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
public class MetadataPublishResult : MetadataAssemblyPublishResult
{
	internal static MetadataPublishResult bHgpSeb6hC2kq49dZm1V;

	public bool NeedRestart
	{
		[CompilerGenerated]
		get
		{
			return _003CNeedRestart_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CNeedRestart_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public MetadataPublishResult()
	{
		//Discarded unreachable code: IL_002c, IL_0031
		qtoSPgb6fChYbFrXyCTY();
		this._002Ector(null, null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MetadataPublishResult(AssemblyModelsMetadata configurationAssembly, AssemblyModelsMetadata dynamicAssembly)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		qtoSPgb6fChYbFrXyCTY();
		base._002Ector(configurationAssembly, dynamicAssembly);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MetadataPublishResult(AssemblyModelsMetadata configurationAssembly, AssemblyModelsMetadata scriptsAssembly, AssemblyModelsMetadata dynamicAssembly)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		qtoSPgb6fChYbFrXyCTY();
		base._002Ector(configurationAssembly, scriptsAssembly, dynamicAssembly);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public MetadataPublishResult([NotNull] MetadataAssemblyPublishResult metadataAssemblePublishResult, bool needRestart)
	{
		//Discarded unreachable code: IL_003c, IL_0041
		qtoSPgb6fChYbFrXyCTY();
		this._002Ector(metadataAssemblePublishResult.ConfigurationAssembly, metadataAssemblePublishResult.ScriptsAssembly, metadataAssemblePublishResult.DynamicAssembly);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
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
				NeedRestart = needRestart;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void qtoSPgb6fChYbFrXyCTY()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool OMfZ3Gb6GrsMjGp4Ohno()
	{
		return bHgpSeb6hC2kq49dZm1V == null;
	}

	internal static MetadataPublishResult GhKsxfb6EjmYBnSyCEjN()
	{
		return bHgpSeb6hC2kq49dZm1V;
	}
}
