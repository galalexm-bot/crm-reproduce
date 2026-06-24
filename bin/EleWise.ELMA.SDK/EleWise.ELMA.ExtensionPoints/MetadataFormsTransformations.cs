using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ExtensionPoints;

[Component]
public class MetadataFormsTransformations : IMetadataFormsTransformations
{
	internal static MetadataFormsTransformations qToCiNGlBiOCNWPDTx4q;

	public void Transformate(EntityMetadata metadata)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				_003C_003Ec__DisplayClass0_.metadata = metadata;
				num2 = 3;
				break;
			case 3:
				((ComponentManager)xhCwbhGlb6Hou6h6qZTN()).GetExtensionPoints<IEntityMetadataFormTransformation>().ForEach(_003C_003Ec__DisplayClass0_._003CTransformate_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public MetadataFormsTransformations()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		uG4wCKGlhaW6M0iVIy0c();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object xhCwbhGlb6Hou6h6qZTN()
	{
		return ComponentManager.Current;
	}

	internal static bool TJAIDLGlWxyDEJ9RnMBJ()
	{
		return qToCiNGlBiOCNWPDTx4q == null;
	}

	internal static MetadataFormsTransformations P6EQjfGlodRR5PimbDst()
	{
		return qToCiNGlBiOCNWPDTx4q;
	}

	internal static void uG4wCKGlhaW6M0iVIy0c()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
