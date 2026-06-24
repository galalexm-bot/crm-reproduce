using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Extensions;

[Component]
internal class WorkflowPropertyAttachmentExtension : IObjectAttachmentWithPropertyExtension, IObjectAttachmentExtension
{
	private readonly IWorkflowElementPropertiesService workflowElementPropertiesService;

	private static WorkflowPropertyAttachmentExtension pyPSrcIOgryhCrWcQJO;

	public WorkflowPropertyAttachmentExtension(IWorkflowElementPropertiesService workflowElementPropertiesService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
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
			this.workflowElementPropertiesService = workflowElementPropertiesService;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
			{
				num = 0;
			}
		}
	}

	public void Copy(IEntity fromEntity, IEntity toEntity)
	{
	}

	public bool EntityType(Guid typeUid)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (MetadataLoader.IsBaseOrChildClass<IWorkflowTaskBase>(typeUid))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return OcotacIYxxXuMpHOPhS(InterfaceActivator.UID<IWorkflowTask>(loadImplementation: false), typeUid);
			default:
				return true;
			}
		}
	}

	public IEnumerable<AttachmentFileModel> GetAttachments(IEntity entity, string propertyUid)
	{
		List<Guid> typesGuid = new List<Guid> { InterfaceActivator.UID<IAttachment>(loadImplementation: false) };
		List<AttachmentFileModel> list = new List<AttachmentFileModel>();
		foreach (Tuple<string, IEnumerable<IEntity>> item in WorkflowPropertyEntityHelper.GetEntityFromProperty(typesGuid, entity, propertyUid))
		{
			foreach (IAttachment item2 in item.Item2.Cast<IAttachment>())
			{
				if (item2.File != null)
				{
					list.Add(new AttachmentFileModel
					{
						Name = item2.File.Name + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6C2BCE) + item.Item1 + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1303601216 ^ -1303590734),
						Uid = item2.File.Uid
					});
				}
			}
		}
		return list;
	}

	public IEnumerable<AttachmentFileModel> GetAttachments(IEntity entity)
	{
		return GetAttachments(entity, null);
	}

	public bool IsAnyAttachments(IEntity entity)
	{
		//Discarded unreachable code: IL_00b3, IL_014f, IL_021e, IL_022d
		int num = 2;
		int num2 = num;
		List<Guid> typeGuids = default(List<Guid>);
		Element element = default(Element);
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		FormView form = default(FormView);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		IEnumerable<PropertyMetadata> propertyMetadataFromTask = default(IEnumerable<PropertyMetadata>);
		while (true)
		{
			switch (num2)
			{
			default:
				return false;
			case 9:
				typeGuids = new List<Guid> { InterfaceActivator.UID<IAttachment>(loadImplementation: false) };
				num2 = 14;
				break;
			case 6:
				if (element != null)
				{
					num2 = 4;
					break;
				}
				goto case 5;
			case 1:
				workflowTaskBase = entity as IWorkflowTaskBase;
				num2 = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
				{
					num2 = 10;
				}
				break;
			case 14:
				_003C_003Ec__DisplayClass6_.workflowBookmark = workflowTaskBase.WorkflowBookmark;
				num2 = 7;
				break;
			case 2:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return false;
			case 4:
				form = (FormView)mGYK0aI0ByltoAfNLGG(workflowElementPropertiesService, workflowInstance, element);
				num2 = 10;
				break;
			case 13:
				return false;
			case 8:
				workflowInstance = (IWorkflowInstance)S5URqsI8dJ4YpGteYLR(_003C_003Ec__DisplayClass6_.workflowBookmark);
				num2 = 12;
				break;
			case 10:
				propertyMetadataFromTask = workflowElementPropertiesService.GetPropertyMetadataFromTask(workflowTaskBase, form, typeGuids);
				num2 = 3;
				break;
			case 12:
				if (workflowInstance == null)
				{
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
					{
						num2 = 1;
					}
					break;
				}
				element = ((IEnumerable<Element>)CZoHRMIlbBvHQVTs1u7(To5xlPIJDoddZcTwhG2(JYmVGNIsUT16AHcC0hF(workflowInstance)))).FirstOrDefault(_003C_003Ec__DisplayClass6_._003CIsAnyAttachments_003Eb__0);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
				{
					num2 = 6;
				}
				break;
			case 11:
				if (workflowTaskBase != null)
				{
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
					{
						num2 = 9;
					}
					break;
				}
				goto default;
			case 15:
				return false;
			case 7:
				if (_003C_003Ec__DisplayClass6_.workflowBookmark != null)
				{
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 13;
			case 3:
				return workflowElementPropertiesService.CheckAnyAttachmentsFromProperties((WorkflowInstanceContext)Pj1ehhIyyr8XJLreKKf(workflowInstance), form, propertyMetadataFromTask);
			}
		}
	}

	internal static bool vvSsjvIZBO5hHV0qKCc()
	{
		return pyPSrcIOgryhCrWcQJO == null;
	}

	internal static WorkflowPropertyAttachmentExtension nFXy5VIvJ2dgjUDjXkU()
	{
		return pyPSrcIOgryhCrWcQJO;
	}

	internal static bool OcotacIYxxXuMpHOPhS(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object S5URqsI8dJ4YpGteYLR(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object JYmVGNIsUT16AHcC0hF(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object To5xlPIJDoddZcTwhG2(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static object CZoHRMIlbBvHQVTs1u7(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object mGYK0aI0ByltoAfNLGG(object P_0, object P_1, object P_2)
	{
		return ((IWorkflowElementPropertiesService)P_0).GetFormViewWorkflowTask((IWorkflowInstance)P_1, (Element)P_2);
	}

	internal static object Pj1ehhIyyr8XJLreKKf(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}
}
