using System;
using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class SubTaskTypeSelectorModel
{
	public class SelectorItem
	{
		public Guid KeyValue { get; set; }

		public string Text { get; set; }
	}

	public string SelectorId { get; set; }

	public string SelectorCaption { get; set; }

	public string DisplayDivId { get; set; }

	public IList<SelectorItem> SelectorValues { get; set; }

	public string ActionUrlBase { get; set; }

	public int SelectedIndex { get; set; }

	public bool IsAjax { get; set; }

	public SubTaskTypeSelectorModel()
	{
		SelectorId = "SubTaskTypeSelector";
		SelectorCaption = SR.T("Выберите тип подзадачи");
		DisplayDivId = "SubTaskPopupPartialDiv";
		SelectorValues = new List<SelectorItem>();
	}
}
