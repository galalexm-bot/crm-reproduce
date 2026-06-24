using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Tasks.Components;

[Component]
internal sealed class WorkLogItemExportExcelCustomColumnsProvider : IExportExcelCustomColumnsProvider, IExportExcelValueProvider
{
	private static readonly long MaxTotalMinutes = (long)TimeSpan.MaxValue.TotalMinutes;

	private static readonly Guid NameUid = new Guid("26401CA9-3D5A-4231-9E8C-2EA0DD04D121");

	private static readonly Guid PlanWorkTimeUid = new Guid("99334918-3FE6-465E-87C3-35363073B5AE");

	private static readonly Guid StatusUid = new Guid("d671f637-3a5a-4c08-8b55-a1f3cb622027");

	private static readonly Guid ActivityUid = new Guid("50417934-90c5-46b9-91be-d2935eceeabc");

	private readonly ExportColumnDescription nameColumn = new ExportColumnDescription
	{
		ColumnName = SR.T("Название"),
		TableColumnWidth = 200,
		PropertyUid = NameUid
	};

	private readonly ExportColumnDescription planWorkTimeColumn = new ExportColumnDescription
	{
		ColumnName = SR.T("Плановые трудозатраты"),
		TableColumnWidth = 200,
		PropertyUid = PlanWorkTimeUid
	};

	public IEnumerable<ExportColumnDescription> GetColumns(Type type, IEnumerable<ExportColumnDescription> baseColumns)
	{
		List<ExportColumnDescription> list = null;
		if (type.IsInheritOrSame<IWorkLogItem>())
		{
			list = baseColumns.ToList();
			int index = list.FindIndex((ExportColumnDescription col) => col.PropertyUid == StatusUid) + 1;
			list.Insert(index, nameColumn);
			index = list.FindIndex((ExportColumnDescription col) => col.PropertyUid == ActivityUid) + 1;
			if (index == 0)
			{
				list.Add(planWorkTimeColumn);
			}
			else
			{
				list.Insert(index, planWorkTimeColumn);
			}
		}
		return list;
	}

	public object GetValue(IEntity entity, Guid propertyUid)
	{
		object result = null;
		IWorkLogItem workLogItem = (IWorkLogItem)entity;
		if (propertyUid == NameUid)
		{
			result = workLogItem.Name;
		}
		else if (propertyUid == PlanWorkTimeUid)
		{
			result = ConvertWorkTime(workLogItem.PlanWorkTime);
		}
		return result;
	}

	public bool Resolve(IEntity entity, Guid propertyUid)
	{
		if (entity is IWorkLogItem)
		{
			return propertyUid.In(NameUid, PlanWorkTimeUid);
		}
		return false;
	}

	private object ConvertWorkTime(WorkTime? value)
	{
		if (value.HasValue)
		{
			WorkTime value2 = value.Value;
			long totalMinutes = value2.TotalMinutes;
			if (totalMinutes <= MaxTotalMinutes)
			{
				return TimeSpan.FromMinutes(totalMinutes);
			}
			return value2.TotalHours + ":" + value2.Minutes;
		}
		return TimeSpan.Zero;
	}
}
