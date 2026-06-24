using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class MetadataFormsTransformations : IMetadataFormsTransformations
{
	internal static MetadataFormsTransformations vREl4cO5hk7WnUxGrAmO;

	public void Transformate(EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0049, IL_0058
		int num = 2;
		FormViewItemTransformation formViewItemTransformation = default(FormViewItemTransformation);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					if (formViewItemTransformation == null)
					{
						num2 = 5;
						continue;
					}
					break;
				case 1:
					if (Pno5uBO5zqXCg9yYOtl4(metadata) == EntityMetadataType.InterfaceExtension)
					{
						num2 = 4;
						continue;
					}
					return;
				case 3:
					return;
				default:
					goto end_IL_0012;
				case 2:
					if (yTvZtJO54l24NQ8V3n6H(metadata) == ClassFormsScheme.FormConstructor)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					return;
				case 4:
					if (bBItbbOgOprb1B67sqfT(DyfCc7OgKmWFM5XlBLbn(metadata), new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E8B845))))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
				case 6:
					metadata.FormsScheme = ClassFormsScheme.FormConstructor;
					num2 = 8;
					continue;
				case 7:
					break;
				}
				metadata.FormTransformations.Add(formViewItemTransformation);
				num2 = 6;
				continue;
				end_IL_0012:
				break;
			}
			formViewItemTransformation = (FormViewItemTransformation)ECRjhfOgZCjOYR1DsiIe(metadata, ViewType.Edit);
			num = 9;
		}
	}

	public MetadataFormsTransformations()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static ClassFormsScheme yTvZtJO54l24NQ8V3n6H(object P_0)
	{
		return ((ClassMetadata)P_0).FormsScheme;
	}

	internal static EntityMetadataType Pno5uBO5zqXCg9yYOtl4(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid DyfCc7OgKmWFM5XlBLbn(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool bBItbbOgOprb1B67sqfT(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object ECRjhfOgZCjOYR1DsiIe(object P_0, ViewType viewType)
	{
		return WorkflowTaskFormViewTransformate.GetTransformation((EntityMetadata)P_0, viewType);
	}

	internal static bool akDEOYO5EU8AiQ2BYEiA()
	{
		return vREl4cO5hk7WnUxGrAmO == null;
	}

	internal static MetadataFormsTransformations p6FSNcO5w687CvK614sl()
	{
		return vREl4cO5hk7WnUxGrAmO;
	}
}
