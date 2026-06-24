using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Tasks.Controllers;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component(Order = 1100)]
public class TasksFilterPortletExtensions : IFilterPortlet
{
	private readonly IMetadataRuntimeService metadataRuntimeService;

	private readonly IEnumerable<IUniqueFilterExtension> uniqueFilterExtensions;

	private readonly IEnumerable<IFilterPortletFilterModifier> filterPortletFilterModifier;

	private readonly IEnumerable<IFilterPortletAvailablePropertyUids> filterPortletAvailablePropertyUids;

	private readonly IEnumerable<IFilterPortletColumnModifier> filterPortletColumnModifier;

	public TasksFilterPortletExtensions(IMetadataRuntimeService metadataRuntimeService, IEnumerable<IUniqueFilterExtension> uniqueFilterExtensions, IEnumerable<IFilterPortletFilterModifier> filterPortletFilterModifier, IEnumerable<IFilterPortletAvailablePropertyUids> filterPortletAvailablePropertyUids, IEnumerable<IFilterPortletColumnModifier> filterPortletColumnModifier)
	{
		this.metadataRuntimeService = metadataRuntimeService;
		this.uniqueFilterExtensions = uniqueFilterExtensions;
		this.filterPortletFilterModifier = filterPortletFilterModifier;
		this.filterPortletAvailablePropertyUids = filterPortletAvailablePropertyUids;
		this.filterPortletColumnModifier = filterPortletColumnModifier;
	}

	public bool AvailableFilterType(Guid filterTypeUid)
	{
		return filterTypeUid == InterfaceActivator.UID<ITaskBase>();
	}

	public virtual string ViewName()
	{
		return "AllTasks/FilteredGrid";
	}

	public object GetModel(GridCommand command, FilterModel filterModel, string gridId, HtmlHelper html)
	{
		IEntityManager manager = GetManager(filterModel);
		ModifyFilter(filterModel);
		return new TasksGridDataFilterModel(command, filterModel, manager, AllTasksController.GetSearchTasksType(filterModel), PortletGridStateProvider.UID);
	}

	private IEntityManager GetManager(FilterModel filterModel)
	{
		Type filterType = ((filterModel != null && filterModel.Filter != null) ? filterModel.Filter.GetType() : null);
		IUniqueFilterExtension uniqueFilterExtension = ((filterType != null) ? uniqueFilterExtensions.FirstOrDefault((IUniqueFilterExtension e) => e.FilterType == filterType) : null);
		return ModelHelper.GetEntityManager((uniqueFilterExtension != null) ? uniqueFilterExtension.EntityType : ((filterType != null) ? metadataRuntimeService.GetTypeByUid(MetadataLoader.GetEntityMetadataByFilter(filterType).Uid) : InterfaceActivator.TypeOf<ITaskBase>()));
	}

	private void ModifyFilter(FilterModel filterModel)
	{
		filterPortletFilterModifier.Where((IFilterPortletFilterModifier p) => p.AvailableFilterType(filterModel.FilterTypeUid, filterModel.Entity.Code)).ForEach(delegate(IFilterPortletFilterModifier modifier)
		{
			filterModel.Filter = modifier.ModifyFilter(filterModel.Filter);
		});
	}
}
