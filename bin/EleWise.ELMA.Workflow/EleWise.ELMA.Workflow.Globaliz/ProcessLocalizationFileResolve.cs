using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Globalization;

[Component]
public class ProcessLocalizationFileResolver : BaseLocalizationFileResolver
{
	public static string File;

	internal static ProcessLocalizationFileResolver k5MI3eCdqSXJyII4dD8;

	public override string FileName => File;

	public override IEnumerable<PoLineDescriptor> CollectResources(LocalizationLoadSettings settings)
	{
		List<PoLineDescriptor> list = new List<PoLineDescriptor>();
		if (settings.CustomSettings[ProcessesLocalizationLoadCustomSettings.ExtensionUid] is ProcessGlobalizationSettings processGlobalizationSettings && processGlobalizationSettings.HeaderIds != null && processGlobalizationSettings.HeaderIds.Length != 0)
		{
			ICollection<IProcessHeader> collection = ProcessHeaderManager.Instance.FindByIdArray(processGlobalizationSettings.HeaderIds);
			foreach (IProcessHeader item in collection)
			{
				AddWithCheck(list, item.Name);
				GetFromMetadata(item.Context, list);
			}
			GetFromDiagram(collection, list);
		}
		return list;
	}

	protected virtual void GetFromDiagram(IEnumerable<IProcessHeader> headers, List<PoLineDescriptor> res)
	{
		foreach (IProcessHeader header in headers)
		{
			IWorkflowProcess published = header.Published;
			if (published == null)
			{
				continue;
			}
			foreach (Element element in published.Diagram.Elements)
			{
				AddWithCheck(res, element.Name);
				AddWithCheck(res, element.Description);
				if (element is IElementWithView elementWithView && elementWithView.View != null)
				{
					string[] keys = elementWithView.View.GetLocalizableStrings().ToArray();
					AddWithCheck(res, keys);
				}
			}
			foreach (WorkflowForm item in published.Forms.Items)
			{
				string[] keys2 = item.CreateFormViewItem(published).GetLocalizableStrings().ToArray();
				AddWithCheck(res, keys2);
			}
		}
	}

	public ProcessLocalizationFileResolver()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		CG4vJfCnugDZqrQ1v3T();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessLocalizationFileResolver()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				CG4vJfCnugDZqrQ1v3T();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				File = (string)mTqrpQCHJ0t3NmvO2g5(0x37F755F5 ^ 0x37F7A39B);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void CG4vJfCnugDZqrQ1v3T()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool zGURZ2Cua4BuNQcmMnB()
	{
		return k5MI3eCdqSXJyII4dD8 == null;
	}

	internal static ProcessLocalizationFileResolver jgm5vNCDsWyiENXvn9K()
	{
		return k5MI3eCdqSXJyII4dD8;
	}

	internal static object mTqrpQCHJ0t3NmvO2g5(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
