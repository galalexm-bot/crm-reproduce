using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Telerik.Grids;

internal interface ITelerikGridBoundColumn
{
	string UniqueName { get; set; }

	ViewAttributes ViewAttributes { get; set; }

	bool CheckCellPermissions { get; set; }
}
