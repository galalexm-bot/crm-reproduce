using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogReportModel
{
	private WorkLogSettings settingsModule;

	public static int? InputDescriptionMaxLength
	{
		get
		{
			PropertyMetadata propertyMetadata = InterfaceActivator.LoadPropertyMetadata((WorkLogReportItem prop) => prop.Description);
			StringSettings stringSettings = ((propertyMetadata != null) ? (propertyMetadata.Settings as StringSettings) : null);
			if (stringSettings == null)
			{
				return 2000;
			}
			return stringSettings.MaxValue;
		}
	}

	public static string InputDescriptionText => SR.T("Введите описание (не более {0} символов)", InputDescriptionMaxLength);

	public static string InputDescriptionOverflowMessage => SR.T("Превышен размер описания. Максимальная длина - {0} символов. Черновик не будет сохранен.", InputDescriptionMaxLength);

	public static string InputDescriptionCommentText => SR.T("Нажмите Enter для перехода на новую строку.");

	public static string InputHarmonizatorValidateText => SR.T("Укажите согласующего");

	public static string InputActivitiValidateText => SR.T("Укажите вид деятельности");

	public static string InputWorkTimeValidateText => SR.T("Введите трудозатраты");

	public static string InputObjectValidateText => SR.T("Укажите объект трудозатрат");

	public static string ButtonAddedWorklogText => SR.T("Поданные трудозатраты");

	public static string ButtonSelectObjectText => SR.T("Выбрать объект трудозатрат");

	public static string CopyWeekTitle => SR.T("Копировать из недели");

	public static string ButtonClearRowText => SR.T("Очистить строку");

	public static string ButtonCreateTaskText => SR.T("Создать и выбрать задачу");

	public WorkLogSettings Settings => settingsModule ?? (settingsModule = WorkLogSettingsHelper.GetSettings());

	public bool CanCreateTask { get; private set; }

	public bool OnlySelected { get; set; }

	public List<WorkLogReportDay> Days { get; set; }

	public DateTime? DayForWeek { get; set; }

	public bool AllWeeks { get; set; }

	public WorkLogReportModel()
	{
		Days = new List<WorkLogReportDay>();
		for (int i = 0; i < 7; i++)
		{
			FillEmptyItems(i, Settings.EmptyLineCount);
		}
		if (Days.Count == 0)
		{
			FillEmptyItems(1, Settings.EmptyLineCount);
		}
		CanCreateTask = WorkLogItemManager.Instance.CanCreateWorkLogForObjectType(InterfaceActivator.UID<ITask>());
	}

	public void FillEmptyItems(int weekDay, int count)
	{
		if (Days.Count((WorkLogReportDay i) => i.DayOfWeek == weekDay) == 0)
		{
			WorkLogReportDay item = new WorkLogReportDay
			{
				DayOfWeek = weekDay
			};
			Days.Add(item);
		}
		for (int j = 0; j < count; j++)
		{
			AddEmptyItem(weekDay);
		}
	}

	public DateTime StartDateOfWeek()
	{
		if (AllWeeks)
		{
			return WorkLogHelper.StartDateOfWeek(DateTime.Now);
		}
		DateTime dateTime = DayForWeek ?? DateTime.Now;
		if (dateTime == DateTime.MinValue)
		{
			dateTime = DateTime.Now;
		}
		return WorkLogHelper.StartDateOfWeek(dateTime);
	}

	public WorkLogReportDay Day(int weekDay)
	{
		return Days.FirstOrDefault((WorkLogReportDay i) => i.DayOfWeek == weekDay);
	}

	public List<int> WeekDays()
	{
		if (Days != null)
		{
			return Days.Select((WorkLogReportDay i) => i.DayOfWeek).ToList();
		}
		return new List<int>();
	}

	public WorkLogReportItem AddEmptyItem(int weekDay)
	{
		WorkLogReportItem workLogReportItem = new WorkLogReportItem();
		(from i in Days
			where i.DayOfWeek == weekDay
			select i.Items).FirstOrDefault().Add(workLogReportItem);
		return workLogReportItem;
	}
}
