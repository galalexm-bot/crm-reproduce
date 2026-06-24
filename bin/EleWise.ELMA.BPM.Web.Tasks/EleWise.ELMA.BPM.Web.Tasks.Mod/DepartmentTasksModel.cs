using System.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class DepartmentTasksModel
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
				SearchTasksType.ForDepartmentCurrent => SR.T("Задачи отдела - текущие"), 
				SearchTasksType.ForDepartmentExpired => SR.T("Задачи отдела - просроченные"), 
				SearchTasksType.ForDepartmentControl => SR.T("Задачи отдела - контроль выполнения"), 
				SearchTasksType.FromDepartmentCurrent => SR.T("Задачи от отдела - текущие"), 
				SearchTasksType.FromDepartmentExpired => SR.T("Задачи от отдела - просроченные"), 
				SearchTasksType.FromDepartmentCompleted => SR.T("Задачи от отдела - выполненные"), 
				SearchTasksType.DepartmentCoExecutorCurrent => SR.T("Соисполнитель - Текущие"), 
				SearchTasksType.DepartmentCoExecutorExpired => SR.T("Соисполнитель - Просроченные"), 
				SearchTasksType.ForDepartmentClosed => SR.T("Завершенные задачи отдела"), 
				SearchTasksType.FromDepartmentClosed => SR.T("Завершенные задачи от отдела"), 
				_ => SR.T("Задачи"), 
			};
		}
		set
		{
			_header = value;
		}
	}

	public List<DepartmentTaskExecutorInfo> ExecutorsInfo { get; set; }
}
