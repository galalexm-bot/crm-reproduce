using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogControlSettingsModel
{
	[DisplayName("SR.M('Использовать автоматическую отправку трудозатрат')")]
	[Description("SR.M('Автоматическая отправка трудозатрат на согласование осуществляется с учетом настроек ограничений подачи')")]
	public bool AutomaticSendingOfWorkLog { get; set; }

	[DisplayName("SR.M('Согласующий трудозатрат по умолчанию')")]
	public IUser WorkLogHarmonizator { get; set; }

	public string Popup { get; set; }

	public WorkLogControlSettingsModel()
	{
	}

	public WorkLogControlSettingsModel(TaskControlSettingsModel taskControlSettingsModel)
	{
		taskControlSettingsModel = GetDefaultTaskControlSettingModel(taskControlSettingsModel);
		AutomaticSendingOfWorkLog = taskControlSettingsModel.AutomaticSendingOfWorkLog;
		WorkLogHarmonizator = taskControlSettingsModel.WorkLogHarmonizator;
	}

	public TaskControlSettingsModel MergeSettings(TaskControlSettingsModel taskControlSettingsModel)
	{
		taskControlSettingsModel = GetDefaultTaskControlSettingModel(taskControlSettingsModel);
		taskControlSettingsModel.AutomaticSendingOfWorkLog = AutomaticSendingOfWorkLog;
		taskControlSettingsModel.WorkLogHarmonizator = WorkLogHarmonizator;
		return taskControlSettingsModel;
	}

	private TaskControlSettingsModel GetDefaultTaskControlSettingModel(TaskControlSettingsModel model)
	{
		return model ?? new TaskControlSettingsModel
		{
			UseSystemSettings = true
		};
	}
}
