using EleWise.ELMA.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class GridDataFilter<T> : GridData<T>
{
	private string gridId;

	public FilterModel DataFilter { get; set; }

	public string GridId
	{
		get
		{
			string text = gridId;
			if (text == null)
			{
				if (DataFilter.Entity == null || DataFilter.Entity.Id <= 0)
				{
					return DataFilter.GridIdPrefix;
				}
				text = $"{DataFilter.GridIdPrefix}_{DataFilter.Entity.Uid}";
			}
			return text;
		}
		set
		{
			gridId = value.HtmlEncode();
		}
	}
}
