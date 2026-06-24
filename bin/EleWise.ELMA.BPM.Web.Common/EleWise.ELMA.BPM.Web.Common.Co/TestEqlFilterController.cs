using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using NHibernate;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Common")]
[Permission("D440D5AB-EF3B-4E5F-99D3-26B9279EA95C")]
public class TestEqlFilterController : EntityBaseController
{
	private const string EntityGridId = "EntityGridId";

	protected override bool EnableEqlQuery => true;

	[ContentItem(Name = "SR.M('Фильтрация объектов')", Image24 = "#faq.svg")]
	public ActionResult Index(Guid? uid = null)
	{
		if (!uid.HasValue)
		{
			return (ActionResult)(object)((Controller)this).View((object)new TestEqlFilterModel
			{
				GridId = "EntityGridId"
			});
		}
		Guid typeUid = uid.Value;
		EntityMetadata entityMetadata = (from p in ComponentManager.Current.GetExtensionPoints<IEntityMetadataSearcher>()
			select p.FindEntityMetadata(typeUid)).FirstOrDefault((EntityMetadata m) => m != null);
		if (entityMetadata == null)
		{
			return (ActionResult)(object)((Controller)this).HttpNotFound();
		}
		Guid uid2 = entityMetadata.Uid;
		Guid? guid = uid;
		if (uid2 != guid)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
			{
				uid = entityMetadata.Uid
			});
		}
		TestEqlFilterModel testEqlFilterModel = new TestEqlFilterModel
		{
			Filter = CreateFilter(entityMetadata.Uid),
			GridId = "EntityGridId"
		};
		testEqlFilterModel.Filter.EnableSave = false;
		return (ActionResult)(object)((Controller)this).View((object)testEqlFilterModel);
	}

	protected virtual FilterModel CreateFilter(Guid typeUid)
	{
		Guid.TryParse(((Controller)this).get_Request()["FilterTypeSelector"], out var result);
		IFilter filter = InterfaceActivator.Create<IFilter>();
		if (filter.FilterFields == null && result != Guid.Empty)
		{
			object obj = InterfaceActivator.Create(MetadataLoader.GetFilterType(result));
			filter.FilterFields = UniversalFilterSaver.Pack((IEntityFilter)obj);
		}
		FilterModel filterModel = new FilterModel(filter, typeUid, null, null, "Filter", null, null, EnableEqlQuery);
		filterModel.FilterTypeUid = typeUid;
		((Controller)this).TryUpdateModel<IEntityFilter>(filterModel.Filter, "Filter");
		filterModel.Filter.DisableSecurity = true;
		return filterModel;
	}

	[CustomGridAction]
	public ActionResult Grid(Guid uid, GridCommand command, string parentId, string searchQuery = null, [Bind(Prefix = "DataFilter")] FilterModel filter = null)
	{
		Guid uid2 = ((filter != null && filter.FilterTypeUid != Guid.Empty) ? filter.FilterTypeUid : uid);
		Type typeByUid = base.IMetadataRuntimeService.GetTypeByUid(uid2);
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid);
		bool flag = ((Controller)this).get_Request().QueryString.Count <= 1;
		filter = filter ?? CreateFilter(classMetadata.Uid);
		IEntityFilter entityFilter = filter.Filter ?? ((IEntityFilter)Activator.CreateInstance(ModelHelper.GetEntityFilterType(typeByUid)));
		entityFilter.DisableSecurity = true;
		string text = EntityBaseController.GenerateGridId(uid2, "", filter.Entity);
		IGridData gridData = GetGridData(command, typeByUid, entityFilter, !flag);
		TableView tableView = ((classMetadata != null && classMetadata.TableViews != null) ? classMetadata.TableViews.FirstOrDefault((TableView v) => v.ViewType == ViewType.List) : null);
		DynamicGrid dynamicGrid = new DynamicGrid(text, text, gridData, typeByUid);
		dynamicGrid.Columns = new List<GridColumn>();
		dynamicGrid.StateProviderUid = ((filter.Entity == null || filter.Entity.Id == 0L) ? Guid.Empty : FilterGridStateProvider.UID);
		dynamicGrid.Customizable = tableView?.Customizable ?? true;
		dynamicGrid.EnableCustomize = filter.Entity == null || filter.Entity.Id == 0;
		dynamicGrid.HeaderVisible = tableView?.ShowHeader ?? true;
		dynamicGrid.Resizeable = tableView?.Resizeable ?? false;
		dynamicGrid.Sortable = tableView?.Sortable ?? true;
		dynamicGrid.Reorderable = tableView?.Reorderable ?? false;
		dynamicGrid.ExportExcel = false;
		dynamicGrid.UniqueName = "EntityGridId";
		return ExportExcel(gridData, typeByUid, () => (ActionResult)(object)((Controller)this).PartialView("Templates/DynamicGrid", (object)dynamicGrid));
	}

	public ActionResult Search(Guid? uid, [Bind(Prefix = "DataFilter")] FilterModel filter)
	{
		if (!uid.HasValue)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new TestEqlFilterModel());
		}
		Guid value = uid.Value;
		if (!((Controller)this).get_Request().QueryString.AllKeys.Any())
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
			{
				uid = value
			});
		}
		filter = filter ?? CreateFilter(value);
		if (((Controller)this).get_Request().QueryString.Count == 1)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Index", (object)new
			{
				uid = value
			});
		}
		filter.EnableSave = false;
		TestEqlFilterModel testEqlFilterModel = new TestEqlFilterModel
		{
			Filter = filter,
			GridId = "EntityGridId"
		};
		return (ActionResult)(object)((Controller)this).View("Index", (object)testEqlFilterModel);
	}

	private IGridData GetGridData(GridCommand command, Type type, IEntityFilter filter, bool isData)
	{
		if (type == null)
		{
			return null;
		}
		return (IGridData)typeof(TestEqlFilterController).GetMethod("GetGridDataGeneric", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy).MakeGenericMethod(type).Invoke(this, new object[3] { command, filter, isData });
	}

	[UsedImplicitly]
	private IGridData GetGridDataGeneric<T>(GridCommand command, IEntityFilter filter, bool isData) where T : class, IEntity
	{
		GridData<T> gridData = (isData ? ((GridData<T>)GetFilteredGridData<T, IEntityFilter>(command, filter)) : ((GridData<T>)GridBuilderExtensions.GetFilteredGridNoData<T, IEntityFilter>(command, filter)));
		if (EnableEqlQuery && filter != null)
		{
			try
			{
				GridBuilderExtensions.GetEntityManagerByFilter<T>(filter).CheckFilter(filter);
			}
			catch (NullReferenceException)
			{
				base.Notifier.Error(SR.T("Неправильно составлен запрос"));
			}
			catch (ADOException)
			{
				base.Notifier.Error(SR.T("Неправильно составлен запрос"));
			}
			catch (Exception exception)
			{
				FormNotifierExtensions.Error(base.Notifier, exception);
			}
		}
		if (gridData != null && filter != null && filter.HierarchyParent != null)
		{
			gridData.AddDataSourceExecuted(delegate(GridData<T> data)
			{
				List<T> list = new List<T>();
				IEnumerable<T> enumerable = (IEnumerable<T>)data.DataSource;
				if (!enumerable.Any() || enumerable.First() != null)
				{
					list.Add(null);
				}
				list.AddRange(enumerable);
				data.DataSource = list;
			});
		}
		return gridData;
	}

	public static IGridData GetFilteredGridData<T, TF>(GridCommand command, TF filter) where T : IEntity where TF : IEntityFilter
	{
		GridData<T, TF> obj = new GridData<T, TF>
		{
			Command = command,
			DataFilter = filter
		};
		IEntityManager manager = GridBuilderExtensions.GetEntityManagerByFilter<T>(filter);
		obj.SetCount((GridData<T, TF> d, FetchOptions f) => (filter == null) ? manager.Count() : manager.Count(filter));
		obj.SetDataSource(delegate(GridData<T, TF> d, FetchOptions f)
		{
			if (d.Count <= 0)
			{
				return new List<T>();
			}
			return (filter == null) ? manager.Find(f) : manager.Find(filter, f).Cast<T>();
		});
		return obj;
	}

	public JsonResult EqlParametersParse(string prefix, [Bind(Prefix = "DataFilter")] FilterModel filter)
	{
		string error = "";
		string queryParameters = "";
		try
		{
			((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(prefix);
			queryParameters = RenderRazorViewToString("Filter/QueryParameters", new QueryParametersModel(filter));
		}
		catch (EQLException ex)
		{
			error = ex.Message;
			base.Logger.Info("EQL query parse error", ex);
		}
		catch (Exception exception)
		{
			error = SR.T("Ошибка вычисления параметров");
			base.Logger.Error("EQL query parse error", exception);
		}
		return ((Controller)this).Json((object)new { queryParameters, error });
	}
}
