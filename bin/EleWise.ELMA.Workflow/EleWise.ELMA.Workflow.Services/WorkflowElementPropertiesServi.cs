using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Services;

[Service]
internal class WorkflowElementPropertiesService : IWorkflowElementPropertiesService
{
	private readonly WorkflowInstanceContextService workflowInstanceContextService;

	private static WorkflowElementPropertiesService crheWZMIEtEuvc0DSIB;

	public WorkflowElementPropertiesService(WorkflowInstanceContextService workflowInstanceContextService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zHYOPtMesugq1MvJ1rM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
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
			this.workflowInstanceContextService = workflowInstanceContextService;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
			{
				num = 1;
			}
		}
	}

	public IEnumerable<IEntity> GetAttachmentsFromProperty(IEntity entity, RootViewItem form, IPropertyMetadata property)
	{
		return GetAttachmentsFromProperties(entity, form, new List<IPropertyMetadata> { property });
	}

	public IEnumerable<IEntity> GetAttachmentsFromProperties(IEntity entity, RootViewItem form, IEnumerable<IPropertyMetadata> properties)
	{
		List<IEntity> list = new List<IEntity>();
		if (form == null || entity == null || properties == null)
		{
			return list;
		}
		using IEnumerator<IPropertyMetadata> enumerator = properties.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
			CS_0024_003C_003E8__locals0.property = enumerator.Current;
			if (form.FindItem((PropertyViewItem p) => _003C_003Ec__DisplayClass3_0.OIEl8AZ78RIouHrbCB5k(_003C_003Ec__DisplayClass3_0.HUmrPiZ7vDEd0n8W5t7N(p), _003C_003Ec__DisplayClass3_0.IXvpbgZ7YkiOnQIVQRx9(CS_0024_003C_003E8__locals0.property))) != null)
			{
				IEnumerable<IEntity> attachmentFromVar = GetAttachmentFromVar(entity, CS_0024_003C_003E8__locals0.property.Uid);
				list.AddRange(attachmentFromVar);
			}
		}
		return list;
	}

	public IEnumerable<PropertyMetadata> GetPropertyMetadataFromTask(IWorkflowTaskBase workflowTaskBase, RootViewItem form, IEnumerable<Guid> typeGuids)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0.typeGuids = typeGuids;
		IWorkflowInstance instance = workflowTaskBase.WorkflowBookmark.Instance;
		EntityMetadata instanceContextMetadata = workflowInstanceContextService.GetInstanceContextMetadata(instance.Process);
		List<PropertyMetadata> list = instanceContextMetadata.GetAllProperties().Distinct().ToList();
		if (instanceContextMetadata == null || list == null)
		{
			return Enumerable.Empty<PropertyMetadata>();
		}
		return list.Where(delegate(PropertyMetadata p)
		{
			int num = 1;
			int num2 = num;
			_003C_003Ec__DisplayClass4_1 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_1);
			while (true)
			{
				switch (num2)
				{
				default:
					_003C_003Ec__DisplayClass4_.p = p;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return CS_0024_003C_003E8__locals0.typeGuids.Any(_003C_003Ec__DisplayClass4_._003CGetPropertyMetadataFromTask_003Eb__1);
				case 1:
					_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_1();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}).ToList();
	}

	public FormView GetFormViewWorkflowTask(IWorkflowInstance instance, Element element)
	{
		//Discarded unreachable code: IL_008f, IL_009e, IL_00ae
		int num = 1;
		IElementWithFormConstructorView elementWithFormConstructorView = default(IElementWithFormConstructorView);
		IElementWithView elementWithView = default(IElementWithView);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if ((elementWithFormConstructorView = element as IElementWithFormConstructorView) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
						{
							num2 = 0;
						}
						continue;
					}
					if ((elementWithView = element as IElementWithView) == null)
					{
						num2 = 3;
						continue;
					}
					goto case 2;
				default:
					if (e4ahGRMNI197IfcV3q6(elementWithFormConstructorView) != Guid.Empty)
					{
						break;
					}
					goto case 4;
				case 2:
					return (FormView)V0XhUUMhWXe85kW6iyd(elementWithView);
				case 3:
					return null;
				case 4:
					return elementWithFormConstructorView.View;
				case 5:
					return (FormView)Ow9dB6M1YrTcdWiCPgY(pLsRWAMSYWUPSBj7CDX(mPNA8SMxlxJELlUYP88(instance)), e4ahGRMNI197IfcV3q6(elementWithFormConstructorView), mPNA8SMxlxJELlUYP88(instance), false);
				}
				break;
			}
			num = 5;
		}
	}

	public IEnumerable<IEntity> GetAttachmentFromVar(IEntity entity, Guid propertyGuid)
	{
		List<IEntity> list = new List<IEntity>();
		try
		{
			object propertyValue = entity.GetPropertyValue(propertyGuid);
			if (propertyValue == null)
			{
				return list;
			}
			if (propertyValue is IEnumerable<IEntity> collection)
			{
				list.AddRange(collection);
				return list;
			}
			if (propertyValue is IEntity item)
			{
				list.Add(item);
				return list;
			}
			return list;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message, ex);
			return list;
		}
	}

	public IEnumerable<IEntity> GetAllAttachmentsFromTablePart(IEntity entity, RootViewItem form, IEnumerable<Guid> guidsProperties)
	{
		List<IEntity> list = new List<IEntity>();
		if (!(entity is IWorkflowInstance workflowInstance))
		{
			return list;
		}
		EntityMetadata instanceContextMetadata = workflowInstanceContextService.GetInstanceContextMetadata(workflowInstance.Process);
		list.AddRange(GetEntityFromTablePart(instanceContextMetadata.TableParts, workflowInstance.Context, form, guidsProperties, instanceContextMetadata.Properties));
		return list;
	}

	private IEnumerable<IEntity> GetAttachmentsFromTablePart(IEntity entity, TablePartMetadata table, RootViewItem form, IEnumerable<Guid> guidsProperties)
	{
		return GetEntityFromTablePart(table.TableParts, entity, form, guidsProperties, table.Properties);
	}

	private IEnumerable<IEntity> GetEntityFromTablePart(List<TablePartMetadata> tableParts, IEntity entity, RootViewItem form, IEnumerable<Guid> guidsProperties, List<PropertyMetadata> propertiesMetadata)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals0.guidsProperties = guidsProperties;
		List<IEntity> list = new List<IEntity>();
		List<PropertyMetadata> properties = propertiesMetadata.Where(delegate(PropertyMetadata p)
		{
			int num = 2;
			int num2 = num;
			_003C_003Ec__DisplayClass9_1 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_1);
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass9_.p = p;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_1();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
					{
						num2 = 1;
					}
					break;
				default:
					return CS_0024_003C_003E8__locals0.guidsProperties.Any(_003C_003Ec__DisplayClass9_._003CGetEntityFromTablePart_003Eb__1);
				}
			}
		}).ToList();
		List<IEntity> collection = GetAttachmentsFromProperties(entity, form, properties).ToList();
		list.AddRange(collection);
		foreach (TablePartMetadata tablePart in tableParts)
		{
			PropertyInfo reflectionProperty = entity.GetType().GetReflectionProperty(tablePart.TablePartPropertyName);
			if (reflectionProperty == null)
			{
				continue;
			}
			IEnumerable enumerable = (IEnumerable)reflectionProperty.GetValue(entity, null);
			if (enumerable == null)
			{
				continue;
			}
			foreach (IEntity item in enumerable)
			{
				IEnumerable<IEntity> attachmentsFromTablePart = GetAttachmentsFromTablePart(item, tablePart, form, CS_0024_003C_003E8__locals0.guidsProperties);
				list.AddRange(attachmentsFromTablePart);
			}
		}
		return list;
	}

	public bool CheckAnyAttachmentsFromProperties(WorkflowInstanceContext workflowInstanceContext, RootViewItem form, IEnumerable<IPropertyMetadata> properties)
	{
		if (form == null)
		{
			return false;
		}
		using (IEnumerator<IPropertyMetadata> enumerator = properties.GetEnumerator())
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
				CS_0024_003C_003E8__locals0.property = enumerator.Current;
				if (form.FindItem((PropertyViewItem p) => _003C_003Ec__DisplayClass10_0.gF99vMZ7RKPYAMGj3IxH(p) == _003C_003Ec__DisplayClass10_0.mK3id6Z76D61MRkPowjE(CS_0024_003C_003E8__locals0.property)) != null && GetAttachmentFromVar(workflowInstanceContext, CS_0024_003C_003E8__locals0.property.Uid).Any())
				{
					return true;
				}
			}
		}
		return false;
	}

	internal static void zHYOPtMesugq1MvJ1rM()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool n27vayMa1URWJYK5QHo()
	{
		return crheWZMIEtEuvc0DSIB == null;
	}

	internal static WorkflowElementPropertiesService caIOf9MrS9lDoXix0eK()
	{
		return crheWZMIEtEuvc0DSIB;
	}

	internal static Guid e4ahGRMNI197IfcV3q6(object P_0)
	{
		return ((IElementWithFormConstructorView)P_0).FormUid;
	}

	internal static object mPNA8SMxlxJELlUYP88(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object pLsRWAMSYWUPSBj7CDX(object P_0)
	{
		return ((IWorkflowProcess)P_0).Forms;
	}

	internal static object Ow9dB6M1YrTcdWiCPgY(object P_0, Guid formUid, object P_2, bool checkExists)
	{
		return ((WorkflowFormsContainer)P_0).CreateFormViewItem(formUid, (IWorkflowProcess)P_2, checkExists);
	}

	internal static object V0XhUUMhWXe85kW6iyd(object P_0)
	{
		return ((IElementWithView)P_0).View;
	}
}
