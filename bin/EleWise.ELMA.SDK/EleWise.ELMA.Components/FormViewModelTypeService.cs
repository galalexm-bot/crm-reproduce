using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Components;

internal sealed class FormViewModelTypeService : ViewModelTypeService
{
	public const string MetadataTypeCode = "Form";

	internal static FormViewModelTypeService QGNM3Dfhmf0fPau540BZ;

	public override bool Check(string metadataTypeCode)
	{
		return TEFZ5afh9TZemsnaDjrL(metadataTypeCode, zCYutnfhJNa2H8n5eQMA(0x17ADCCD8 ^ 0x17AD733C));
	}

	public override ViewModelTypeName GetViewPropertyModelType(IPropertyMetadata property, string metadataNamespace)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				if (!(property is ITablePartMetadata))
				{
					return base.GetViewPropertyModelType(property, metadataNamespace);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override ViewModelTypeName GetViewModelType(string metadataName, string metadataNamespace, bool useOriginalModel)
	{
		return null;
	}

	public FormViewModelTypeService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object zCYutnfhJNa2H8n5eQMA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool TEFZ5afh9TZemsnaDjrL(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool vrc4x6fhywFQMaG6E3sC()
	{
		return QGNM3Dfhmf0fPau540BZ == null;
	}

	internal static FormViewModelTypeService tKE2bqfhMbdRpbr27X1J()
	{
		return QGNM3Dfhmf0fPau540BZ;
	}
}
