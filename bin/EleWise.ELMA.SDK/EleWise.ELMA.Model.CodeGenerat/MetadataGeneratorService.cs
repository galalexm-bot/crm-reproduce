using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

[Service]
internal sealed class MetadataGeneratorService : IMetadataGeneratorService
{
	private readonly IEnumerable<IMetadataTypeInfo> metadataTypeInfos;

	private static MetadataGeneratorService TxTEyWhkKTAxGOMW5phU;

	public MetadataGeneratorService(IEnumerable<IMetadataTypeInfo> metadataTypeInfos)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.metadataTypeInfos = metadataTypeInfos;
	}

	public ICodeGenerator GetCodeGenerator(IMetadata metadata)
	{
		//Discarded unreachable code: IL_0081, IL_0090
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		IMetadataTypeInfo metadataTypeInfo = default(IMetadataTypeInfo);
		while (true)
		{
			switch (num2)
			{
			case 3:
				throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A3337C4), _003C_003Ec__DisplayClass2_.metadata.GetType()));
			case 4:
				return (ICodeGenerator)Activator.CreateInstance(D2RF5yhkkybMjYimGC5Z(metadataTypeInfo));
			case 2:
				if (metadataTypeInfo != null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			default:
				_003C_003Ec__DisplayClass2_.metadata = metadata;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				metadataTypeInfo = metadataTypeInfos.FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetCodeGenerator_003Eb__0);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static Type D2RF5yhkkybMjYimGC5Z(object P_0)
	{
		return ((IMetadataTypeInfo)P_0).GeneratorType;
	}

	internal static bool iRI7xhhkXhjuHNGvmvSX()
	{
		return TxTEyWhkKTAxGOMW5phU == null;
	}

	internal static MetadataGeneratorService CUspcQhkTiY9yKNTmPBZ()
	{
		return TxTEyWhkKTAxGOMW5phU;
	}
}
