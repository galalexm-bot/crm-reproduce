using System.Collections.Generic;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Mvc.Util;

public class GridExportExcelOptions
{
	public string Title { get; set; }

	public string TitleUrl { get; set; }

	public GridState GridState { get; set; }

	public IDictionary<string, int> ColumnOrderOverride { get; set; }
}
