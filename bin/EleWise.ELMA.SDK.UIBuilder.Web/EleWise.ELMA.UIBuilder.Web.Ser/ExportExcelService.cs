using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text.RegularExpressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UIBuilder.Web.Models;
using EleWise.ELMA.Web.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Util;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.UIBuilder.Web.Service;

[Component]
[Uid("{7CB89C6C-D1FB-4D04-8B57-F0CE1CB47B65}")]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
internal sealed class ExportExcelService : IExportExcelService, IInternalAPIWebService
{
	public const string UidS = "{7CB89C6C-D1FB-4D04-8B57-F0CE1CB47B65}";

	public static Guid Uid = new Guid("{7CB89C6C-D1FB-4D04-8B57-F0CE1CB47B65}");

	private static IMetadataRuntimeService metadataRuntimeService;

	private static ICacheFilesService cacheFilesService;

	private static IAuthenticationService authenticationService;

	private static IHttpContextAccessor httpContextAccessor;

	private static IEnumerable<ITablePartGridStateSaveModeProvider> gridStateSaveModeProviders;

	private static IMetadataRuntimeService MetadataRuntimeService => metadataRuntimeService ?? (metadataRuntimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>());

	private static ICacheFilesService CacheFilesService => cacheFilesService ?? (cacheFilesService = Locator.GetServiceNotNull<ICacheFilesService>());

	private static IAuthenticationService AuthenticationService => authenticationService ?? (authenticationService = Locator.GetServiceNotNull<IAuthenticationService>());

	private static IHttpContextAccessor HttpContextAccessor => httpContextAccessor ?? (httpContextAccessor = Locator.GetServiceNotNull<IHttpContextAccessor>());

	private static IEnumerable<ITablePartGridStateSaveModeProvider> GridStateSaveModeProviders => gridStateSaveModeProviders ?? (gridStateSaveModeProviders = ComponentManager.Current.GetExtensionPoints<ITablePartGridStateSaveModeProvider>());

	public ExportExcelResultDto ExportFromGrid(ExportExcelDataFromGridDto data)
	{
		GridExportExcelOptions options = new GridExportExcelOptions
		{
			Title = data.Title,
			TitleUrl = data.TitleUrl
		};
		Type typeByUid = MetadataRuntimeService.GetTypeByUid(data.EntityTypeUid);
		IGridData filteredGridData = GridBuilderExtensions.GetFilteredGridData<IEntity, IEntityFilter>(data.EntityTypeUid, data.Page, data.PageSize, data.SortDescriptors, data.GroupDescriptors, data.Filter, new Filter
		{
			Query = data.Query
		});
		return ExportExcel(filteredGridData, typeByUid, data.GridId, data.ProviderUid, data.Count, data.ExportExcelFileName, options);
	}

	public ExportExcelResultDto ExportFromBlock(ExportExcelDataFromBlockDto data)
	{
		Type typeByUid = MetadataRuntimeService.GetTypeByUid(data.EntityTypeUid);
		ITablePartMetadata tablePartMetadata = (ITablePartMetadata)MetadataLoader.LoadMetadata(typeByUid, inherit: false);
		ClassMetadata classMetadata = (ClassMetadata)tablePartMetadata;
		PropertyMetadata propertyMetadata = tablePartMetadata.Properties.First((PropertyMetadata p) => p.Uid == tablePartMetadata.ParentPropertyUid);
		Type typeByUid2 = MetadataRuntimeService.GetTypeByUid(propertyMetadata.SubTypeUid);
		IEntityManager entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(typeByUid2);
		IEntity entity = (IEntity)entityManagerOrNull.LoadOrCreate(data.ParentId);
		IEnumerable enumerable = entity.GetPropertyValue(tablePartMetadata.TablePartPropertyUid) as IEnumerable;
		TableView tableView = classMetadata?.TableViews?.FirstOrDefault((TableView v) => v.ViewType == ViewType.List);
		if (data.TablePartChangesModelSerialized != null)
		{
			TablePartChangesModel tablePartChangesModel = new JsonSerializer().Deserialize<TablePartChangesModel>(data.TablePartChangesModelSerialized);
			enumerable = tablePartChangesModel.ApplyImmutable(enumerable, typeByUid);
		}
		MethodInfo methodInfo = typeof(GridBuilderExtensions).GetMethod("GetBlockData", BindingFlags.Static | BindingFlags.NonPublic).MakeGenericMethod(typeByUid);
		IGridData gridData = (IGridData)methodInfo.Invoke(null, new object[10] { data.EntityTypeUid, enumerable, classMetadata, data.GridId, data.Page, data.PageSize, data.Pageable, data.Count, data.SortDescriptors, data.GroupDescriptors });
		GridState gridState = null;
		bool flag = false;
		if (IsSubTablePart(tablePartMetadata))
		{
			gridState = CreateDefaultState(data.GridId, typeByUid, gridData, data.ProviderUid, GridStateSaveMode.None);
			flag = true;
		}
		else
		{
			gridState = GridPersonalizationAdministration.LoadState(data.GridId);
			if (gridState != null)
			{
				gridState.Refresh(typeByUid, isNew: false, forceRefresh: false, addEntityName: false);
			}
			else
			{
				GridStateSaveMode value = GridStateSaveModeProviders.Select((ITablePartGridStateSaveModeProvider x) => x.GetGridStateSaveMode(data.EntityTypeUid)).First((GridStateSaveMode? x) => x.HasValue).Value;
				gridState = CreateDefaultState(data.GridId, typeByUid, gridData, data.ProviderUid, value);
				flag = true;
			}
		}
		gridState.ReloadFromMetadata(typeByUid);
		IList<GridColumn> defaultColumns = GridBuilderExtensions.GetDefaultColumns(typeByUid, classMetadata, gridState, childs: false, null, null);
		int i;
		for (i = 0; i < data.ColumnsOrder.Count; i++)
		{
			GridColumn gridColumn = defaultColumns.FirstOrDefault((GridColumn c) => c.UniqueName == data.ColumnsOrder[i]);
			if (gridColumn != null)
			{
				gridColumn.Order = i;
			}
		}
		IOrderedEnumerable<GridColumn> columns = defaultColumns.OrderBy((GridColumn c) => c.Order);
		if (gridState != null)
		{
			IOrderedEnumerable<ColumnState> source = gridState.ColumnStates.OrderBy((ColumnState a) => a.Order);
			ColumnState[] array = source.ToArray();
			foreach (ColumnState c2 in array)
			{
				Guid.TryParse(c2.UniqueName, out var _);
				GridColumn gridColumn2 = columns.OrderBy((GridColumn a) => a.Order).FirstOrDefault((GridColumn c1) => c1.UniqueName == c2.UniqueName);
				if (gridColumn2 == null)
				{
					continue;
				}
				gridColumn2.Visible = !c2.Hidden;
				if (gridColumn2.Visible && tableView != null && tableView.Reorderable)
				{
					if (!flag)
					{
						gridColumn2.Order = c2.Order;
					}
					else
					{
						c2.Order = gridColumn2.Order;
					}
				}
			}
		}
		if (!string.IsNullOrEmpty(gridState.SortExpression))
		{
			gridData.SortExpression = gridState.SortExpression;
			gridData.SortDirection = gridState.SortDirection;
		}
		else
		{
			gridData.SortExpression = null;
		}
		gridData.PageSize = gridState.PageSize;
		gridData.GroupDescriptors = gridState.GroupDescriptors;
		GridExportExcelOptions options = new GridExportExcelOptions
		{
			GridState = gridState,
			ColumnOrderOverride = columns.ToDictionary((GridColumn key) => key.UniqueName, (GridColumn column) => columns.IndexOf(column))
		};
		return ExportExcel(gridData, typeByUid, data.GridId, data.ProviderUid, data.Count, data.ExportExcelFileName, options);
	}

	private GridState CreateDefaultState(string gridId, Type type, IGridData gridData, Guid stateProviderUid, GridStateSaveMode gridStateSaveMode)
	{
		GridState gridState = GridState.CreateNew(gridId, type);
		if (!string.IsNullOrEmpty(gridData.SortExpression))
		{
			gridState.SortDirection = gridData.SortDirection;
			gridState.SortExpression = gridData.SortExpression;
		}
		if (gridData.GroupDescriptors != null)
		{
			gridState.GroupDescriptors = gridData.GroupDescriptors;
		}
		gridState.PageSize = gridData.PageSize;
		gridState.SaveOnlyInSession = gridStateSaveMode == GridStateSaveMode.SaveInSession;
		if (gridStateSaveMode != 0)
		{
			GridPersonalizationAdministration.SaveState(gridId, gridState, stateProviderUid, true);
		}
		if (gridStateSaveMode == GridStateSaveMode.SaveInSessionAndDb)
		{
			GridPersonalizationAdministration.SaveState(gridId, gridState, stateProviderUid, false);
		}
		gridState.Refresh(type, isNew: false, forceRefresh: false, addEntityName: false);
		return gridState;
	}

	private bool IsSubTablePart(ITablePartMetadata metadata)
	{
		PropertyMetadata propertyMetadata = metadata.Properties.FirstOrDefault((PropertyMetadata a) => a.Uid == metadata.ParentPropertyUid);
		return propertyMetadata != null && MetadataLoader.LoadMetadata(propertyMetadata.SubTypeUid) is ITablePartMetadata;
	}

	private ExportExcelResultDto ExportExcel(IGridData gridData, Type entityType, string gridId, Guid provider, int size, string exportExcelFileName, GridExportExcelOptions options)
	{
		exportExcelFileName = GetExportExcelFileName(exportExcelFileName, entityType);
		Guid guid = CacheFilesService.CreateCacheFile(exportExcelFileName);
		string filePath = CacheFilesService.GetFilePath(guid);
		object id = AuthenticationService.GetCurrentUser().GetId();
		string sessionID = HttpContextAccessor.Current().Session.SessionID;
		string fileHref = "/SDK.Action/BinaryFiles/Download/" + guid;
		bool flag = GridExportExcelUtility.ExportExcel(gridData, entityType, size == 0, gridId, provider, guid, filePath, sessionID, id, TimeSpan.FromSeconds(5.0), options);
		string error = (flag ? GridExportExcelUtility.GetExportExcelStatus(sessionID, id, gridId).Error : null);
		return new ExportExcelResultDto
		{
			FileHref = fileHref,
			Ready = flag,
			Error = error
		};
	}

	private string GetExportExcelFileName(string exportExcelFileName, Type entityType)
	{
		if (exportExcelFileName.IsNullOrWhiteSpace())
		{
			exportExcelFileName = ((!(MetadataLoader.LoadMetadata(entityType) is EntityMetadata entityMetadata) || entityMetadata.DisplayName.IsNullOrWhiteSpace()) ? "Grid" : entityMetadata.DisplayName);
		}
		exportExcelFileName = Regex.Replace(exportExcelFileName, "[\\/\\\\:*?\"<>|\\s]", "") + ".xlsx";
		return exportExcelFileName;
	}
}
