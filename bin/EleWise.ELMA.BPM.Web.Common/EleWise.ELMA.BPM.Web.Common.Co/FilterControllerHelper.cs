using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public static class FilterControllerHelper
{
	public static void FastFilterSave(FilterModel model, bool enableEqlQuery)
	{
		model.EnableEqlQuery = enableEqlQuery;
		model.ReInit();
		if (model.Entity.IsNew())
		{
			GridState gridState = GridPersonalizationAdministration.LoadState(model.GridIdPrefix, Guid.Empty);
			if (gridState != null)
			{
				gridState.Refresh(model.GridState.TypeGridState);
				model.GridState = gridState;
			}
		}
	}

	public static void FilterFields(FilterModel filterModel)
	{
		filterModel.ReInit();
	}

	public static void FilterColumnSettings(FilterModel filterModel)
	{
		filterModel.ReInit();
	}

	public static void Save(string FilterName, FilterModel filter)
	{
		filter.Save(FilterName);
	}

	public static FilterFolderModel AddFilterFolderModel(Guid TypeUid, long ParentFilterFolderId, Guid? code)
	{
		IFilterFolder filterFolder = FilterFolderManager.Instance.Load(ParentFilterFolderId);
		InstanceOf<IFilterFolder> instanceOf = new InstanceOf<IFilterFolder>();
		instanceOf.New.ObjectsType = new ReferenceOnEntityType
		{
			TypeUid = TypeUid
		};
		instanceOf.New.ParentFolder = filterFolder;
		instanceOf.New.FilterType = filterFolder.FilterType;
		instanceOf.New.Code = code;
		IFilterFolder @new = instanceOf.New;
		return new FilterFolderModel
		{
			Entity = @new
		};
	}

	public static void AddFilterFolder(FilterFolderModel model)
	{
		model.Entity.Save();
	}

	public static FilterFolderModel CreateFilterFolderModel(long? FilterId = null)
	{
		IFilterFolder entity = AbstractNHEntityManager<IFilterFolder, long>.Instance.Load(FilterId.Value);
		return new FilterFolderModel
		{
			Entity = entity
		};
	}

	public static void EditFilterFolder(FilterFolderModel model)
	{
		model.Entity.Save();
	}

	public static Pair<string, object> NodeDroped(Guid TypeUid, string target, string destination, string position, Guid? code)
	{
		IEnumerable<IFilterFolder> enumerable = Locator.GetServiceNotNull<FilterMenuProvider>().Folders(TypeUid, code);
		IFilterFolder targetFolder = enumerable.Find(target);
		if (targetFolder == null)
		{
			return new Pair<string, object>(SR.T("Не найдена папка фильтров target {0}", target), null);
		}
		IFilterFolder destinationFolder = enumerable.Find(destination);
		if (destinationFolder == null)
		{
			return new Pair<string, object>(SR.T("Не найдена папка фильтров destination {0}", destination), null);
		}
		Dictionary<IFilterFolder, string> dictionary = new Dictionary<IFilterFolder, string>();
		FilterFolderManager.Instance.CheckMoveAvaliable(targetFolder, destinationFolder, dictionary);
		if (dictionary.Count > 0)
		{
			return new Pair<string, object>(dictionary.First().Value, null);
		}
		switch (position)
		{
		case "over":
		{
			List<IFilterFolder> list = enumerable.Where((IFilterFolder folder) => folder.ParentFolder == destinationFolder).ToList();
			targetFolder.ParentFolder = destinationFolder;
			targetFolder.Weight = ((list.Count > 0) ? (list.Max((IFilterFolder folder) => folder.Weight ?? folder.Id) + 1) : 0);
			FilterFolderManager.Instance.ChangeFolderType(targetFolder, destinationFolder.FilterType);
			targetFolder.Save();
			break;
		}
		case "before":
		{
			List<IFilterFolder> list = enumerable.Where((IFilterFolder folder) => folder != targetFolder && folder.ParentFolder == destinationFolder.ParentFolder && (folder.Weight ?? folder.Id) >= (destinationFolder.Weight ?? destinationFolder.Id)).ToList();
			targetFolder.ParentFolder = destinationFolder.ParentFolder;
			targetFolder.Weight = destinationFolder.Weight ?? destinationFolder.Id;
			FilterFolderManager.Instance.ChangeFolderType(targetFolder, destinationFolder.FilterType);
			targetFolder.Save();
			long num = targetFolder.Weight.Value + 1;
			foreach (IFilterFolder item in list)
			{
				item.Weight = num;
				item.Save();
				num++;
			}
			break;
		}
		case "after":
		{
			List<IFilterFolder> list = enumerable.Where((IFilterFolder folder) => folder != targetFolder && folder.ParentFolder == destinationFolder.ParentFolder && (folder.Weight ?? folder.Id) > (destinationFolder.Weight ?? destinationFolder.Id)).ToList();
			targetFolder.ParentFolder = destinationFolder.ParentFolder;
			targetFolder.Weight = destinationFolder.Weight ?? (destinationFolder.Id + 1);
			FilterFolderManager.Instance.ChangeFolderType(targetFolder, destinationFolder.FilterType);
			targetFolder.Save();
			long num = targetFolder.Weight.Value + 1;
			foreach (IFilterFolder item2 in list)
			{
				item2.Weight = num;
				item2.Save();
				num++;
			}
			break;
		}
		default:
			return new Pair<string, object>(SR.T("Неизвестное действие"), null);
		}
		IList<TreeViewItem> second = Locator.GetServiceNotNull<FilterMenuProvider>().BuildJson(TypeUid, code);
		return new Pair<string, object>(SR.T("Положение сохранено"), second);
	}

	public static Tuple<string, string, object> Delete(Guid TypeUid, long Id, Guid? code)
	{
		string item = string.Empty;
		string item2 = string.Empty;
		object item3 = new object();
		IEnumerable<IFilterFolder> source = Locator.GetServiceNotNull<FilterMenuProvider>().Folders(TypeUid, code);
		if (source.Count((IFilterFolder folder) => folder.ParentFolder != null && folder.ParentFolder.Id == Id) > 0)
		{
			item2 = SR.T("Нельзя удалять папку фильтров, если у неё есть вложенные папки или фильтры");
		}
		else
		{
			try
			{
				FilterFolderManager.Instance.Delete(source.FirstOrDefault((IFilterFolder folder) => folder.Id == Id));
				item = SR.T("Ссылка удалена");
				item3 = Locator.GetServiceNotNull<FilterMenuProvider>().BuildJson(TypeUid, code);
			}
			catch (Exception ex)
			{
				item2 = SR.T("Ошибка удаления: ") + ex.Message;
			}
		}
		return new Tuple<string, string, object>(item, item2, item3);
	}

	public static Tuple<string, string, object> SetFilterDefault(Guid TypeUid, long Id, Guid? code)
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		object obj = new object();
		if (Locator.GetServiceNotNull<FilterMenuProvider>().Folders(TypeUid, code).FirstOrDefault((IFilterFolder f) => f.Id == Id) is IFilter filter)
		{
			FilterDefaultManager.Instance.SaveDefaultFilter(filter);
		}
		obj = Locator.GetServiceNotNull<FilterMenuProvider>().BuildJson(TypeUid, code);
		return new Tuple<string, string, object>(empty, empty2, obj);
	}

	public static Tuple<string, string, object> SetFilterSystemDefault(Guid TypeUid, long Id, Guid? code)
	{
		string empty = string.Empty;
		string empty2 = string.Empty;
		object obj = new object();
		if (Locator.GetServiceNotNull<FilterMenuProvider>().Folders(TypeUid, code).FirstOrDefault((IFilterFolder f) => f.Id == Id) is IFilter filter)
		{
			FilterDefaultManager.Instance.SaveSystemDefaultFilter(filter);
		}
		obj = Locator.GetServiceNotNull<FilterMenuProvider>().BuildJson(TypeUid, code);
		return new Tuple<string, string, object>(empty, empty2, obj);
	}
}
