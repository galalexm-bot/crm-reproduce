using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class ConvertDocumentProcessReferencesExtension : IConvertDocumentReferencesExtension
{
	private readonly IWorkflowMetadataLoaderService workflowMetadataLoaderService;

	internal static ConvertDocumentProcessReferencesExtension eSYot3Osu9WPAAlA0g9H;

	public ConvertDocumentProcessReferencesExtension(IWorkflowMetadataLoaderService workflowMetadataLoaderService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QG59JxOsHOXWFwcsa18x();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.workflowMetadataLoaderService = workflowMetadataLoaderService;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
			{
				num = 1;
			}
		}
	}

	public List<EntityMetadata> GetAllEntitiesWithPossibleReferences()
	{
		_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
		InterfaceActivator.Create<IProcessHeaderFilter>().HasPublished = true;
		List<EntityMetadata> list = workflowMetadataLoaderService.GetFullInstanceContextTypes().Values.Select((Type t) => (EntityMetadata)_003C_003Ec.t2PpUhZzA9QkrDnxfoma(t, true, true)).ToList();
		CS_0024_003C_003E8__locals0.allBlocks = new List<EntityMetadata>();
		list.ForEach(delegate(EntityMetadata a)
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
					CS_0024_003C_003E8__locals0.allBlocks.AddRange(DocumentManager.Instance.GetChildBlocks(a));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		return list.Concat(CS_0024_003C_003E8__locals0.allBlocks).ToList();
	}

	internal static void QG59JxOsHOXWFwcsa18x()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool QucCaHOsDaeFZeyK4bqs()
	{
		return eSYot3Osu9WPAAlA0g9H == null;
	}

	internal static ConvertDocumentProcessReferencesExtension cljutPOsns6owCnHW4BW()
	{
		return eSYot3Osu9WPAAlA0g9H;
	}
}
