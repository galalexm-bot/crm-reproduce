using System;
using System.Linq;
using System.Text;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Scripts;

public class FormCodeCompiler : ScriptCompiler
{
	internal static FormCodeCompiler fcQknPj0Wh10wyERKVv;

	public static ICodeGenerator CreateGenerator(FormMetadata metadata)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass0_.metadata = metadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				ICodeGenerator obj = (ICodeGenerator)T3Id46jrkIV5bqcxEGL(Q52McfjlK8KtcdV6kPU(((ComponentManager)nBvY9ZjMxkGrQbHgT66()).GetExtensionPoints<IMetadataTypeInfo>().FirstOrDefault(_003C_003Ec__DisplayClass0_._003CCreateGenerator_003Eb__0) ?? throw new Exception((string)V3fmOZjddEbUaBi5Zia(X7vOLaj9Xr58s6uFC85(DQfB0sjJNmfD32VSX3W(0x3A5D5EF ^ 0x3A51C1D)), _003C_003Ec__DisplayClass0_.metadata.GetType()))));
				DZToE8jgwAy6kedxmJA(obj, _003C_003Ec__DisplayClass0_.metadata);
				((GenerationParams)EAMT8mj56UnYPDx1adM(obj)).FileName = (string)InWFDRjjHxdGwSpuLLg(_003C_003Ec__DisplayClass0_.metadata) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A7291A);
				UQQNjpjLkXiGJe2SRP9(EAMT8mj56UnYPDx1adM(obj), UAEnsDjYxjgw8UCXnu2(_003C_003Ec__DisplayClass0_.metadata));
				return obj;
			}
			}
		}
	}

	public FormCodeCompiler(string assemblyName, FormMetadata metadata, ScriptModule module)
	{
		//Discarded unreachable code: IL_0036, IL_00de, IL_01de, IL_021b, IL_022a
		tIc82ajU9Ay2nOLxHKZ();
		base._002Ector(assemblyName, (module == null) ? new IScriptModule[0] : new IScriptModule[1] { module });
		int num = 12;
		string text2 = default(string);
		string text = default(string);
		GeneratedFileInfo generatedFileInfo = default(GeneratedFileInfo);
		int num2 = default(int);
		GeneratedFileType generatedFileType = default(GeneratedFileType);
		GeneratedFileInfo[] array = default(GeneratedFileInfo[]);
		while (true)
		{
			switch (num)
			{
			case 14:
				text2 = (string)mBtGIaYo3bcIhpBX4mL(text, generatedFileInfo.Extension);
				num = 9;
				break;
			case 6:
			case 13:
			case 15:
				num2++;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num = 1;
				}
				break;
			case 4:
				if (generatedFileType != GeneratedFileType.CS)
				{
					num = 16;
					break;
				}
				goto case 3;
			case 3:
				AddSourceCode((string)boeBgCYWG9yZRPJLAVa(oYex6wYB6Hhe57Q64kQ(), generatedFileInfo.Data));
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num = 1;
				}
				break;
			case 12:
				MQmg4UjsSDjOPDiapKP(metadata, DQfB0sjJNmfD32VSX3W(--1418440330 ^ 0x548BE7B4));
				num = 7;
				break;
			case 11:
				xleQw2YbrUk8YyBbSSx(this, mBtGIaYo3bcIhpBX4mL(text, DQfB0sjJNmfD32VSX3W(0x1FFEF86A ^ 0x1FFE323A)), ClassSerializationHelper.SerializeObjectByXmlToBytes(metadata));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num = 2;
				}
				break;
			default:
				if (num2 >= array.Length)
				{
					num = 11;
					break;
				}
				goto case 5;
			case 16:
				if (generatedFileType != GeneratedFileType.EmbeddedResource)
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num = 13;
					}
					break;
				}
				goto case 14;
			case 10:
				generatedFileType = SBFmLqYFEPpNWEdg76G(generatedFileInfo);
				num = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num = 4;
				}
				break;
			case 2:
				return;
			case 5:
			{
				generatedFileInfo = array[num2];
				int num3 = 10;
				num = num3;
				break;
			}
			case 9:
				xleQw2YbrUk8YyBbSSx(this, text2, generatedFileInfo.Data);
				num = 15;
				break;
			case 8:
				num2 = 0;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num = 0;
				}
				break;
			case 7:
			{
				object obj = W43B5NjzhdFhl42KQcg(dr31kXjc5mmiwcxFXLq(metadata));
				text = metadata.Namespace + (string)DQfB0sjJNmfD32VSX3W(0x42643203 ^ 0x426428C7) + (string)InWFDRjjHxdGwSpuLLg(metadata);
				array = (GeneratedFileInfo[])obj;
				num = 8;
				break;
			}
			}
		}
	}

	public override void AddDefaultReferences()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.AddDefaultReferences();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 3:
				AddDefaultReferencesFromElmaConfig((string)DQfB0sjJNmfD32VSX3W(-398663332 ^ -398710010));
				num2 = 5;
				break;
			case 6:
				nrGJURYh1aGFQ2LOQyB(this, DQfB0sjJNmfD32VSX3W(0x1A33FE36 ^ 0x1A3334B0));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				nrGJURYh1aGFQ2LOQyB(this, DQfB0sjJNmfD32VSX3W(-218496594 ^ -218494080));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				AddReferenceByName((string)DQfB0sjJNmfD32VSX3W(-1426094279 ^ -1426092707));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 4;
				}
				break;
			default:
				AddDefaultReferencesFromConfig((string)DQfB0sjJNmfD32VSX3W(0x48A7E34A ^ 0x48A72910));
				num2 = 3;
				break;
			}
		}
	}

	internal static object nBvY9ZjMxkGrQbHgT66()
	{
		return ComponentManager.Current;
	}

	internal static object DQfB0sjJNmfD32VSX3W(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object X7vOLaj9Xr58s6uFC85(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object V3fmOZjddEbUaBi5Zia(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static Type Q52McfjlK8KtcdV6kPU(object P_0)
	{
		return ((IMetadataTypeInfo)P_0).GeneratorType;
	}

	internal static object T3Id46jrkIV5bqcxEGL(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static void DZToE8jgwAy6kedxmJA(object P_0, object P_1)
	{
		((ICodeGenerator)P_0).Metadata = (IMetadata)P_1;
	}

	internal static object EAMT8mj56UnYPDx1adM(object P_0)
	{
		return ((ICodeGenerator)P_0).GenerationParams;
	}

	internal static object InWFDRjjHxdGwSpuLLg(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object UAEnsDjYxjgw8UCXnu2(object P_0)
	{
		return ((FormMetadata)P_0).Namespace;
	}

	internal static void UQQNjpjLkXiGJe2SRP9(object P_0, object P_1)
	{
		((GenerationParams)P_0).Namespace = (string)P_1;
	}

	internal static bool niFcvUjmxi61B4fwvZ9()
	{
		return fcQknPj0Wh10wyERKVv == null;
	}

	internal static FormCodeCompiler fHQR0ujyrAWAavV1sCp()
	{
		return fcQknPj0Wh10wyERKVv;
	}

	internal static void tIc82ajU9Ay2nOLxHKZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void MQmg4UjsSDjOPDiapKP(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object dr31kXjc5mmiwcxFXLq(object P_0)
	{
		return CreateGenerator((FormMetadata)P_0);
	}

	internal static object W43B5NjzhdFhl42KQcg(object P_0)
	{
		return ((ICodeGenerator)P_0).Generate();
	}

	internal static GeneratedFileType SBFmLqYFEPpNWEdg76G(object P_0)
	{
		return ((GeneratedFileInfo)P_0).Type;
	}

	internal static object oYex6wYB6Hhe57Q64kQ()
	{
		return Encoding.UTF8;
	}

	internal static object boeBgCYWG9yZRPJLAVa(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetString((byte[])P_1);
	}

	internal static object mBtGIaYo3bcIhpBX4mL(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void xleQw2YbrUk8YyBbSSx(object P_0, object P_1, object P_2)
	{
		((AssemblyBuilder)P_0).AddEmbeddedResource((string)P_1, (byte[])P_2);
	}

	internal static bool nrGJURYh1aGFQ2LOQyB(object P_0, object P_1)
	{
		return ((AssemblyBuilder)P_0).AddReferenceByName((string)P_1);
	}
}
