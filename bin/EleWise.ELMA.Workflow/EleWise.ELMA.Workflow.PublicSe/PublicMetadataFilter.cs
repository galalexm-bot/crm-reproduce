using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.PublicService;

[Component]
public class PublicMetadataFilter : IPublicMetadataFilter
{
	private static PublicMetadataFilter cDGoeIb10KEvgtsaTcI;

	public Func<IMetadata, bool> Filter => delegate(IMetadata metadata)
	{
		//Discarded unreachable code: IL_006b, IL_007a
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (metadata is ProcessMetricsContainer)
				{
					num2 = 3;
					continue;
				}
				goto case 2;
			case 1:
				if (!(metadata is ProcessContext))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				return !(metadata is ProcessInstanceMetricsContainer);
			case 3:
				break;
			}
			break;
		}
		return false;
	};

	public PublicMetadataFilter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool tNGFrAbhl4CHNmksEKk()
	{
		return cDGoeIb10KEvgtsaTcI == null;
	}

	internal static PublicMetadataFilter YlA3bRbE8qa54OlvTgo()
	{
		return cDGoeIb10KEvgtsaTcI;
	}
}
