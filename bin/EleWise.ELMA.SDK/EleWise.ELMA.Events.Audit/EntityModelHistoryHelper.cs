using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Events.Audit;

public static class EntityModelHistoryHelper
{
	private static EntityModelHistoryHelper U62o6WGUFGeiDgXQe4Ld;

	public static IEntity ToEntity(this IEntityModelHistoryItem self)
	{
		//Discarded unreachable code: IL_0056, IL_0065
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				return yIjVP3GUheK6x24BdQgV(ModelHelper.GetEntityManager(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(CgeIMhGUoFsfYEgkEvh5(self))), dxYThIGUbHLdFH8S2N8o(self)) as IEntity;
			case 2:
				if (self != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	[Obsolete("Метод устарел", true)]
	public static IEnumerable<WebData> ReturnWebData(IEnumerable<IEntityModelHistoryItem> entityModelHistoryItems, Func<PropertyMetadata, bool> propertyFilter, Func<TablePartMetadata, bool> tablePartFilter)
	{
		_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
		CS_0024_003C_003E8__locals0.tablePartFilter = tablePartFilter;
		return ReturnWebData(entityModelHistoryItems, propertyFilter, (ITablePartMetadata m) => CS_0024_003C_003E8__locals0.tablePartFilter((TablePartMetadata)m));
	}

	[IteratorStateMachine(typeof(_003CReturnWebData_003Ed__2))]
	public static IEnumerable<WebData> ReturnWebData(IEnumerable<IEntityModelHistoryItem> entityModelHistoryItems, Func<PropertyMetadata, bool> propertyFilter = null, Func<ITablePartMetadata, bool> tablePartFilter = null)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CReturnWebData_003Ed__2(-2)
		{
			_003C_003E3__entityModelHistoryItems = entityModelHistoryItems,
			_003C_003E3__propertyFilter = propertyFilter,
			_003C_003E3__tablePartFilter = tablePartFilter
		};
	}

	private static WebData GetEntityWebData(IEnumerable<IEntityModelHistoryItem> historyItem, Func<PropertyMetadata, bool> propertyFilter = null, Func<ITablePartMetadata, bool> tablePartFilter = null)
	{
		IEntityModelHistoryItem entityModelHistoryItem = historyItem.First();
		IEntity entity = ModelHelper.GetEntity(entityModelHistoryItem.ObjectTypeUid, entityModelHistoryItem.ObjectUid);
		if (entity == null)
		{
			return null;
		}
		return WebData.CreateFromEntity(entity, propertyFilter, tablePartFilter);
	}

	private static WebData GetDeletedWebData(IEnumerable<IEntityModelHistoryItem> historyItem)
	{
		IEntityModelHistoryItem entityModelHistoryItem = historyItem.First();
		return WebData.CreateForDeleted(entityModelHistoryItem.ObjectTypeUid, entityModelHistoryItem.ObjectUid, entityModelHistoryItem.ObjectId);
	}

	internal static Guid CgeIMhGUoFsfYEgkEvh5(object P_0)
	{
		return ((IEntityModelHistoryItem)P_0).ObjectTypeUid;
	}

	internal static Guid dxYThIGUbHLdFH8S2N8o(object P_0)
	{
		return ((IEntityModelHistoryItem)P_0).ObjectUid;
	}

	internal static object yIjVP3GUheK6x24BdQgV(object P_0, Guid uid)
	{
		return ((IEntityManager)P_0).LoadOrNull(uid);
	}

	internal static bool GdGExFGUBwiaaqGuAbqb()
	{
		return U62o6WGUFGeiDgXQe4Ld == null;
	}

	internal static EntityModelHistoryHelper MMpC8KGUWYcL4MpG4PvB()
	{
		return U62o6WGUFGeiDgXQe4Ld;
	}
}
