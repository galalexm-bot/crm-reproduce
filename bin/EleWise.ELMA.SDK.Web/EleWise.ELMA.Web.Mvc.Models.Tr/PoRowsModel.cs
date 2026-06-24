using System.Collections.Generic;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.Web.Mvc.Models.Translate;

public class PoRowsModel
{
	public List<PoRowModel> Rows { get; set; }

	public GridData<PoRowModel, PoLineFilter> Data { get; set; }

	public string FileName { get; set; }

	public PoRowsModel()
	{
		Rows = new List<PoRowModel>();
	}
}
