using System.Collections.Generic;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class PeriodTasksModel
{
	private string _header;

	public SearchTasksType SearchTasksType { get; set; }

	public string Header
	{
		get
		{
			if (!string.IsNullOrEmpty(_header))
			{
				return _header;
			}
			return SearchTasksType switch
			{
				SearchTasksType.PeriodCurrent => SR.T("Периодические задачи - Текущие"), 
				SearchTasksType.PeriodClosed => SR.T("Периодические задачи - Завершенные"), 
				_ => SR.T("Задачи"), 
			};
		}
		set
		{
			_header = value;
		}
	}

	public List<ITask> TaskTemplates { get; set; }
}
