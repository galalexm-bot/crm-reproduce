using System;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogItemIndexModel
{
	public string PopupId;

	public string KeyPage { get; set; }

	public WorkLogSummaryTableGroup Group { get; set; }

	public GridDataFilter<IWorkLogItem> GridData { get; set; }

	public FilterModel DataFilter
	{
		get
		{
			if (GridData == null)
			{
				return null;
			}
			return GridData.DataFilter;
		}
	}

	public WorkLogItemFormParams FormParams { get; set; }

	public WorkLogItemGridParams Parameters { get; set; }

	public bool HideSearchResult { get; set; }

	public Guid? PrefixLevel { get; set; }

	public WorkLogItemIndexModel()
	{
		FormParams = new WorkLogItemFormParams
		{
			CanChange = true,
			ShowDisplayName = true,
			ShowSummaryTable = true
		};
		Group = WorkLogSummaryTableGroup.Activity;
	}
}
