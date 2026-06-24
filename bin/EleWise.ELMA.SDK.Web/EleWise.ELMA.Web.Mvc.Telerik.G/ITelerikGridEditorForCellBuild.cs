using EleWise.ELMA.Model.Views;
using Telerik.Web.Mvc.UI.Html;

namespace EleWise.ELMA.Web.Mvc.Telerik.Grids;

public interface ITelerikGridEditorForCellBuilder : IGridDataCellBuilder, IGridDecoratableCellBuilder
{
	ViewAttributes ViewAttributes { get; set; }
}
