using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public interface IFilterController
{
	ActionResult FilterSave(string FilterName, FilterModel filter);

	ActionResult FastFilterSave(string prefix, FilterModel filterModel);

	ActionResult FilterFields(string HtmlFieldPrefix, FilterModel filterModel = null, Guid? zoneId = null, string filterGridId = "");

	ActionResult FilterColumnSettings(FilterModel filterModel);

	ActionResult FilterTreeAddFilterFolder(Guid TypeUid, long ParentFilterFolderId, Guid? code);

	ActionResult FilterTreeAddFilterFolder(FilterFolderModel model);

	ActionResult FilterTreeEditFilterFolder(long? FilterId = null, string q = null);

	ActionResult FilterTreeEditFilterFolder(FilterFolderModel model);

	ActionResult FilterTreeNodeDroped(Guid TypeUid, string target, string destination, string position, Guid? code);

	ActionResult FilterTreeDelete(Guid TypeUid, long Id, Guid? code);

	ActionResult FilterTreeOpenFolder(string url);

	ActionResult FilterTreeSetFilterDefault(Guid TypeUid, long Id, Guid? code);

	ActionResult FilterTreeSetFilterSystemDefault(Guid TypeUid, long Id, Guid? code);
}
