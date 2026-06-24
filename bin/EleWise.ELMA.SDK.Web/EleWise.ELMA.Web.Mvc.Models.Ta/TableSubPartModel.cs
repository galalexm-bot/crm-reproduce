using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Web.Mvc.Models.TableParts;

public class TableSubPartModel
{
	public ITablePartMetadata Metadata { get; set; }

	public TablePartGridModel GridModel { get; set; }

	public object ParentItem { get; set; }

	public EleWise.ELMA.Model.Views.ViewItem ViewItem { get; set; }
}
