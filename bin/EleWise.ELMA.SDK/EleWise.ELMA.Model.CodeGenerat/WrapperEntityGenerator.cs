using System;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

internal class WrapperEntityGenerator : ICodeGenerator
{
	private ICodeGenerator generator;

	private EntityMetadata metadata;

	private GenerationParams generationParams;

	internal static WrapperEntityGenerator RjGmMch2QC5wGh47iu42;

	public IMetadata Metadata
	{
		get
		{
			//Discarded unreachable code: IL_0087, IL_0096
			int num = 2;
			int num2 = num;
			IMetadata result = default(IMetadata);
			while (true)
			{
				switch (num2)
				{
				default:
					return result;
				case 2:
					if (generator == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 3;
				case 3:
					return generator.Metadata;
				case 1:
					result = metadata;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_0122, IL_0131, IL_01e4
			int num = 7;
			EntityMetadata entityMetadata = default(EntityMetadata);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 13:
						return;
					case 3:
						metadata = entityMetadata;
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 1;
						}
						continue;
					case 8:
					case 14:
						goto end_IL_0012;
					default:
						oXt8YUh2IeGxPZJBBef5(generator, generationParams);
						num2 = 8;
						continue;
					case 11:
						if (metadata != null)
						{
							num2 = 9;
							continue;
						}
						goto case 4;
					case 9:
						if (FA0NTSh287FGcYIfs4x7(metadata) == EntityMetadataType.Entity)
						{
							num2 = 10;
							continue;
						}
						goto case 4;
					case 6:
						if (entityMetadata.Type == EntityMetadataType.Entity)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 5;
					case 1:
						if (metadata != null)
						{
							num2 = 2;
							continue;
						}
						goto case 5;
					case 2:
						if (FA0NTSh287FGcYIfs4x7(metadata) == EntityMetadataType.Entity)
						{
							num2 = 5;
							continue;
						}
						goto case 10;
					case 10:
						throw new Exception((string)hTxfr9h2uRLOSdWTxx76(USqdphh2ZSKBEUMERrSU(-1123633026 ^ -1123685706)));
					case 4:
						if (generator != null)
						{
							num2 = 14;
							continue;
						}
						break;
					case 5:
						if (FA0NTSh287FGcYIfs4x7(entityMetadata) == EntityMetadataType.Entity)
						{
							num2 = 4;
							continue;
						}
						goto case 11;
					case 7:
						if ((entityMetadata = value as EntityMetadata) == null)
						{
							throw new Exception((string)USqdphh2ZSKBEUMERrSU(-538519530 ^ -538604722));
						}
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 6;
						}
						continue;
					case 12:
						break;
					}
					generator = ((FA0NTSh287FGcYIfs4x7(entityMetadata) == EntityMetadataType.Entity) ? new EntityGenerator() : new EntityDynamicGenerator());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 0;
					}
					continue;
					end_IL_0012:
					break;
				}
				GmrET9h2VAwXIV0wM8tN(generator, entityMetadata);
				num = 3;
			}
		}
	}

	public GenerationParams GenerationParams
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (GenerationParams)tjnxaMh2SPIX9ugn0RlC(generator);
				case 1:
					if (generator == null)
					{
						return generationParams;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
		set
		{
			//Discarded unreachable code: IL_0086, IL_0095
			int num = 3;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						return;
					case 3:
						if (generator != null)
						{
							break;
						}
						goto end_IL_0012;
					case 1:
					case 2:
						generationParams = value;
						num2 = 4;
						continue;
					}
					oXt8YUh2IeGxPZJBBef5(generator, value);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 1;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 2;
			}
		}
	}

	public GeneratedFileInfo[] Generate()
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new Exception((string)hTxfr9h2uRLOSdWTxx76(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837879825)));
			default:
				return generator.Generate();
			case 1:
				if (generator != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public GeneratedFileInfo[] GenerateAdditionalFiles()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638619771)));
			case 1:
				if (generator != null)
				{
					return (GeneratedFileInfo[])g4hymrh2iF6pLvJZshsF(generator);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public GeneratedFileInfo GenerateMainFile()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (generator == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (GeneratedFileInfo)nI02tGh2RjASQua48Xkr(generator);
			default:
				throw new Exception((string)hTxfr9h2uRLOSdWTxx76(USqdphh2ZSKBEUMERrSU(-1146510045 ^ -1146423625)));
			}
		}
	}

	public WrapperEntityGenerator()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		EsGLgxh2qvGkwjWdTv5R();
		generationParams = new GenerationParams();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool IHJYxEh2CXh4nL7lxDAj()
	{
		return RjGmMch2QC5wGh47iu42 == null;
	}

	internal static WrapperEntityGenerator SOJ18Kh2vxpsqDlIXw6h()
	{
		return RjGmMch2QC5wGh47iu42;
	}

	internal static EntityMetadataType FA0NTSh287FGcYIfs4x7(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static object USqdphh2ZSKBEUMERrSU(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object hTxfr9h2uRLOSdWTxx76(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void oXt8YUh2IeGxPZJBBef5(object P_0, object P_1)
	{
		((ICodeGenerator)P_0).GenerationParams = (GenerationParams)P_1;
	}

	internal static void GmrET9h2VAwXIV0wM8tN(object P_0, object P_1)
	{
		((ICodeGenerator)P_0).Metadata = (IMetadata)P_1;
	}

	internal static object tjnxaMh2SPIX9ugn0RlC(object P_0)
	{
		return ((ICodeGenerator)P_0).GenerationParams;
	}

	internal static object g4hymrh2iF6pLvJZshsF(object P_0)
	{
		return ((ICodeGenerator)P_0).GenerateAdditionalFiles();
	}

	internal static object nI02tGh2RjASQua48Xkr(object P_0)
	{
		return ((ICodeGenerator)P_0).GenerateMainFile();
	}

	internal static void EsGLgxh2qvGkwjWdTv5R()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
