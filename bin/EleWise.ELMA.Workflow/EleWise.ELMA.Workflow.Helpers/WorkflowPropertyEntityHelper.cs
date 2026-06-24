using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;

namespace EleWise.ELMA.Workflow.Helpers;

public static class WorkflowPropertyEntityHelper
{
	private static IWorkflowElementPropertiesService workflowElementPropertiesService;

	internal static WorkflowPropertyEntityHelper C8RhwnClhBsMeqSVAg1;

	private static IWorkflowElementPropertiesService WorkflowElementPropertiesService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IWorkflowElementPropertiesService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = workflowElementPropertiesService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = (workflowElementPropertiesService = Locator.GetServiceNotNull<IWorkflowElementPropertiesService>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	public static List<Tuple<string, IEnumerable<IEntity>>> GetEntityFromProperty(IEnumerable<Guid> typesGuid, IEntity entity, string propertyUid = null)
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		List<Tuple<string, IEnumerable<IEntity>>> list = new List<Tuple<string, IEnumerable<IEntity>>>();
		if (!(entity is IWorkflowTaskBase workflowTaskBase))
		{
			return list;
		}
		CS_0024_003C_003E8__locals0.workflowBookmark = workflowTaskBase.WorkflowBookmark;
		if (CS_0024_003C_003E8__locals0.workflowBookmark == null)
		{
			return list;
		}
		IWorkflowInstance instance = CS_0024_003C_003E8__locals0.workflowBookmark.Instance;
		if (instance == null)
		{
			return list;
		}
		Element element = instance.Process.Diagram.Elements.FirstOrDefault(delegate(Element e)
		{
			int num = 1;
			int num2 = num;
			Guid? elementUid = default(Guid?);
			Guid guid = default(Guid);
			while (true)
			{
				switch (num2)
				{
				default:
					elementUid = CS_0024_003C_003E8__locals0.workflowBookmark.ElementUid;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
					{
						num2 = 3;
					}
					break;
				case 3:
					if (elementUid.HasValue)
					{
						return _003C_003Ec__DisplayClass3_0.TuCH0rZGYGtmaKOAYGjP(guid, elementUid.GetValueOrDefault());
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return false;
				case 1:
					guid = _003C_003Ec__DisplayClass3_0.ym92NNZGvdAdORmJ15W5(e);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		if (element == null)
		{
			return list;
		}
		FormView formViewWorkflowTask = WorkflowElementPropertiesService.GetFormViewWorkflowTask(instance, element);
		IEnumerable<PropertyMetadata> propertyMetadataFromTask = WorkflowElementPropertiesService.GetPropertyMetadataFromTask(workflowTaskBase, formViewWorkflowTask, typesGuid);
		if (!propertyMetadataFromTask.Any() || formViewWorkflowTask == null)
		{
			return list;
		}
		foreach (PropertyMetadata item in propertyMetadataFromTask)
		{
			if (string.IsNullOrEmpty(propertyUid) || !(item.UidStr != propertyUid))
			{
				IEnumerable<IEntity> enumerable = WorkflowElementPropertiesService.GetAllAttachmentsFromTablePart(instance, formViewWorkflowTask, new List<Guid> { item.Uid }).ToList().Distinct();
				if (enumerable.Any())
				{
					list.Add(new Tuple<string, IEnumerable<IEntity>>(item.DisplayName, enumerable));
				}
			}
		}
		return list;
	}

	internal static bool Mc3D3uC0HDdogZ1eiWa()
	{
		return C8RhwnClhBsMeqSVAg1 == null;
	}

	internal static WorkflowPropertyEntityHelper fjNbFlCydhI1asO59kG()
	{
		return C8RhwnClhBsMeqSVAg1;
	}
}
