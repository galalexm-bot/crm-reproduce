using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.API.Models;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class WorkflowPublicServiceTaskDocumentHelp : IWorkflowPublicServiceTaskFormExtension
{
	public static readonly string DocumentHelp;

	internal static WorkflowPublicServiceTaskDocumentHelp HtMFRrOmMqFW3UBnNwmf;

	public void GetDescriptor(TypeSerializationDescriptorBuilder builder)
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
				builder.ItemWithDescriptor(DocumentHelp, delegate(TypeSerializationDescriptorBuilder i)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec.Hbv1NsvZ5NUj35Onmf3I(_003C_003Ec.taJJlWvZbnFIdhk772fs(_003C_003Ec.quNYSZvZmGCyXSYsnktT(i, SR.T((string)_003C_003Ec.Td51uAvZy0qa2TAlCmjR(-961162596 ^ -961084028))), _003C_003Ec.rKrGWQvZtmUoTCI0LEGq(typeof(WebData).TypeHandle)), true);
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ToWebData(IWorkflowTaskBase task, WebData webData)
	{
		//Discarded unreachable code: IL_0095, IL_0124, IL_0133
		int num = 7;
		List<WebDataItem> list = default(List<WebDataItem>);
		IDocument document = default(IDocument);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
				{
					List<WebDataItem> list2 = list;
					WebDataItem obj = new WebDataItem
					{
						Name = DocumentHelp
					};
					IDocument entity = document;
					EntitySerializationSettings entitySerializationSettings = new EntitySerializationSettings();
					YdJKPwOm2QVG0YG72T5o(entitySerializationSettings, WorkflowTaskWCF.ContextSerializationFunctions);
					ESUmj9OmoUqxgDheMpTo(obj, WebData.CreateFromEntity(entity, entitySerializationSettings));
					list2.Add(obj);
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				case 7:
					if (webData != null)
					{
						num2 = 6;
						continue;
					}
					return;
				case 2:
					webData.Items = (WebDataItem[])w3QZO4OmFIPRuJHYwRyU(list);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return;
				case 6:
					break;
				case 4:
					return;
				case 8:
					if (document != null)
					{
						num2 = 5;
						continue;
					}
					return;
				case 1:
					return;
				case 5:
					list = ((IEnumerable<WebDataItem>)qWF0vHOm7hkO18y0ayGS(webData)).ToList();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			document = (IDocument)IOyTrkOmGBbY1VIcq6Cr(((ComponentManager)n1C6eQOmVykSAiJSKcHB()).GetExtensionPointByType<TaskDocumentHelp>(), (ClassMetadata)mHm6E1OmAyMamhh7qagN(task.TypeUid, true, true), task);
			num = 8;
		}
	}

	public WorkflowPublicServiceTaskDocumentHelp()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		eBBJnfOmiTVnI3akctvT();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WorkflowPublicServiceTaskDocumentHelp()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				eBBJnfOmiTVnI3akctvT();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				DocumentHelp = (string)F0sSCROmIJhC3TsM2MbZ(0x8D5763A ^ 0x8D4CDB6);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool QqFMJKOmkoa2dFKxuXvX()
	{
		return HtMFRrOmMqFW3UBnNwmf == null;
	}

	internal static WorkflowPublicServiceTaskDocumentHelp EQU4d0OmU0PKKosnqLQt()
	{
		return HtMFRrOmMqFW3UBnNwmf;
	}

	internal static object n1C6eQOmVykSAiJSKcHB()
	{
		return ComponentManager.Current;
	}

	internal static object mHm6E1OmAyMamhh7qagN(Guid P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object IOyTrkOmGBbY1VIcq6Cr(object P_0, object P_1, object P_2)
	{
		return ((TaskDocumentHelp)P_0).ResolveDocument((ClassMetadata)P_1, (ITaskBase)P_2);
	}

	internal static object qWF0vHOm7hkO18y0ayGS(object P_0)
	{
		return ((WebData)P_0).Items;
	}

	internal static void YdJKPwOm2QVG0YG72T5o(object P_0, object P_1)
	{
		((EntitySerializationSettings)P_0).Functions = (EntitySerializationFunctions)P_1;
	}

	internal static void ESUmj9OmoUqxgDheMpTo(object P_0, object P_1)
	{
		((WebDataItem)P_0).Data = (WebData)P_1;
	}

	internal static object w3QZO4OmFIPRuJHYwRyU(object P_0)
	{
		return ((List<WebDataItem>)P_0).ToArray();
	}

	internal static void eBBJnfOmiTVnI3akctvT()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object F0sSCROmIJhC3TsM2MbZ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
