using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Models;
using Iesi.Collections;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowInstanceContextManager<T> : WorkflowBaseManager<T> where T : WorkflowInstanceContext
{
	internal static object Bgv65CLkIOmE5SktZiJ;

	public WorkflowInstanceContextService WorkflowInstanceContextService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowInstanceContextService_003Ek__BackingField;
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
				case 1:
					_003CWorkflowInstanceContextService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public override T Create()
	{
		Contract.ServiceNotNull(WorkflowInstanceContextService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x548A7778));
		return (T)WorkflowInstanceContextService.LoadWorkflowInstanceContext(typeof(T), 0L);
	}

	public override void Save(T obj)
	{
		foreach (TablePartMetadata tablePart in ((EntityMetadata)MetadataLoader.LoadMetadata(typeof(T))).TableParts)
		{
			object propertyValue = obj.GetPropertyValue(tablePart.TablePartPropertyUid);
			ISet val = (ISet)((propertyValue is ISet) ? propertyValue : null);
			if (val == null)
			{
				continue;
			}
			foreach (IEntity item in (IEnumerable)val)
			{
				if ((long)item.GetId() < 0)
				{
					item.SetId(0L);
				}
			}
		}
		Entity<long> entity2 = null;
		foreach (Entity<long> compositeEntity in obj.GetCompositeEntities())
		{
			if (entity2 == null)
			{
				entity2 = compositeEntity;
			}
			else if (compositeEntity.Id <= 0 && entity2 != null)
			{
				compositeEntity.Id = entity2.Id;
			}
			GetPartialManager(compositeEntity).Save(compositeEntity);
		}
		ParentContextAction(obj, delegate(IEntity parentContext)
		{
			parentContext.Save();
		});
	}

	public override Guid[] GetDirtyPropertyUids(T obj)
	{
		return GetDirtyPropertyUids(obj, null);
	}

	public override Guid[] GetDirtyPropertyUids(T obj, object originalState)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals0.result = new List<Guid>(base.GetDirtyPropertyUids(obj, originalState));
		if (originalState == null)
		{
			ParentContextAction(obj, delegate(IEntity parentContext)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						CS_0024_003C_003E8__locals0.result.AddRange(parentContext.GetDirtyPropertyUids());
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
		}
		return CS_0024_003C_003E8__locals0.result.ToArray();
	}

	public override bool IsDirty(T obj)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.result = base.IsDirty(obj);
		if (!CS_0024_003C_003E8__locals0.result)
		{
			ParentContextAction(obj, delegate(IEntity parentContext)
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
						CS_0024_003C_003E8__locals0.result = parentContext.IsDirty();
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
		}
		return CS_0024_003C_003E8__locals0.result;
	}

	private static void ParentContextAction(T obj, Action<IEntity> action)
	{
		PropertyInfo reflectionProperty = obj.GetType().GetReflectionProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574582569));
		if (reflectionProperty != null && reflectionProperty.GetValue(obj, null) is IEntity obj2)
		{
			action(obj2);
		}
	}

	public override T LoadOrNull(long id)
	{
		Contract.ServiceNotNull(WorkflowInstanceContextService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980558692));
		return (T)WorkflowInstanceContextService.LoadWorkflowInstanceContext(typeof(T), id);
	}

	public WorkflowInstanceContextManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool MJbO3LLUf8kJnoEjBNl()
	{
		return Bgv65CLkIOmE5SktZiJ == null;
	}

	internal static object IAPdK4LVfscODPqrh6x()
	{
		return Bgv65CLkIOmE5SktZiJ;
	}
}
public class WorkflowInstanceContextManagerMaker : IManagerMaker
{
	internal static WorkflowInstanceContextManagerMaker EPJrX7LA0WLvkytUW0Y;

	public Type MakeManager(Type objectType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return typeof(WorkflowInstanceContextManager<>).MakeGenericType(objectType);
			case 1:
				Contract.ArgumentNotNull(objectType, (string)jSe2IvL2n44AjuVtLgL(0x70EBB9F3 ^ 0x70EB1A31));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public WorkflowInstanceContextManagerMaker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kVZPirLob4T8jdy845v();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object jSe2IvL2n44AjuVtLgL(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool CxKL1WLGkL03uHpA8qU()
	{
		return EPJrX7LA0WLvkytUW0Y == null;
	}

	internal static WorkflowInstanceContextManagerMaker WxTplxL7rKwd326QmK9()
	{
		return EPJrX7LA0WLvkytUW0Y;
	}

	internal static void kVZPirLob4T8jdy845v()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
