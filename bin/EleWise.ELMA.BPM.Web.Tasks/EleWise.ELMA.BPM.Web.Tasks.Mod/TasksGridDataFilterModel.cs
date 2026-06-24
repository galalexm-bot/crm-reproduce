using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public sealed class TasksGridDataFilterModel : GridDataFilter<ITaskBase>
{
	public SearchTasksType SearchTasksType { get; }

	public Guid GridStateProviderUid { get; }

	public string UniquePrefix { get; }

	internal TasksGridDataFilterModel(GridCommand command, FilterModel filterModel, IEntityManager manager, SearchTasksType searchTasksType, Guid gridStateProviderUid, bool withNoData = false, string uniquePrefix = null)
	{
		InitGridDataFilter(command, filterModel, manager, withNoData);
		SearchTasksType = searchTasksType;
		GridStateProviderUid = gridStateProviderUid;
		UniquePrefix = (string.IsNullOrWhiteSpace(uniquePrefix) ? uniquePrefix : Guid.NewGuid().ToStringId());
	}

	private void InitGridDataFilter(GridCommand command, FilterModel filter, IEntityManager manager, bool withNoData)
	{
		base.Command = command;
		base.DataFilter = filter;
		if (withNoData)
		{
			return;
		}
		IEntityFilter entityFilter = filter.Filter;
		SetCount((GridData<ITaskBase> d, FetchOptions f) => (entityFilter == null) ? manager.Count() : manager.Count(entityFilter));
		if (command != null && command.get_GroupDescriptors().Any())
		{
			base.GroupDescriptors = (from gd in command.get_GroupDescriptors()
				select new GridGroupDescriptor
				{
					Member = ((SortDescriptor)gd).get_Member(),
					SortDirection = ((SortDescriptor)gd).get_SortDirection()
				}).ToList();
			SetDataSource(delegate(GridData<ITaskBase> d, FetchOptions f)
			{
				GridCommand command2 = command;
				object items;
				if (d.Count > 0)
				{
					items = ((entityFilter != null) ? manager.Find(entityFilter, f).Cast<ITaskBase>() : manager.Find(f).Cast<ITaskBase>());
				}
				else
				{
					IEnumerable<ITaskBase> enumerable = new List<ITaskBase>();
					items = enumerable;
				}
				return command2.ApplyGrouping((IEnumerable<ITaskBase>)items);
			});
			return;
		}
		SetDataSource(delegate(GridData<ITaskBase> d, FetchOptions f)
		{
			if (d.Count <= 0)
			{
				return new List<ITaskBase>();
			}
			return (entityFilter == null) ? manager.Find(f) : manager.Find(entityFilter, f).Cast<ITaskBase>();
		});
	}
}
