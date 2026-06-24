using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
[XmlRoot("ProcessContextTypeDescriptor")]
public class ProcessContextTypeDescriptor : IXsiType
{
	internal static ProcessContextTypeDescriptor ijvXlaOgvfonlOqU21O8;

	[XmlElement("ProcessHeaderId")]
	public long ProcessHeaderId
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeaderId_003Ek__BackingField;
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
					_003CProcessHeaderId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ProcessContextTypeDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool Jhfky2OgYUmW3Nq1wQA2()
	{
		return ijvXlaOgvfonlOqU21O8 == null;
	}

	internal static ProcessContextTypeDescriptor yhXWrZOg8CpEfvrJ6fow()
	{
		return ijvXlaOgvfonlOqU21O8;
	}
}
