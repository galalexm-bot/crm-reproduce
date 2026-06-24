using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Mvc.Models.TableParts;

public class TablePartGridModel
{
	public DynamicGrid Grid { get; set; }

	public ITablePartMetadata Metadata { get; set; }

	public RootViewItem EditingItemView { get; set; }
}
