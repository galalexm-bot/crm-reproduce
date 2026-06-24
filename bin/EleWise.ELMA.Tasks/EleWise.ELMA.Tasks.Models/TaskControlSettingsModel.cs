using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Tasks.Models;

[Serializable]
public class TaskControlSettingsModel
{
	[DisplayName(typeof(TaskControlSettingsModel_SR), "UseSystemSettings_SR")]
	public bool UseSystemSettings { get; set; }

	[DisplayName(typeof(TaskControlSettingsModel_SR), "SetControl_SR")]
	public bool SetControl { get; set; }

	[DisplayName("SR.M('Использовать автоматическую отправку трудозатрат')")]
	[Description("SR.M('Автоматическая отправка трудозатрат на согласование осуществляется с учетом настроек ограничений подачи')")]
	public bool AutomaticSendingOfWorkLog { get; set; }

	[DisplayName(typeof(TaskControlSettingsModel_SR), "DefaultControlType_SR")]
	public TaskControlType DefaultControlType { get; set; }

	public long? WorkLogHarmonizatorId { get; set; }

	[DisplayName(typeof(TaskControlSettingsModel_SR), "WorkLogHarmonizator_SR")]
	public IUser WorkLogHarmonizator
	{
		get
		{
			if (!WorkLogHarmonizatorId.HasValue)
			{
				return null;
			}
			return UserManager.Instance.LoadOrNull(WorkLogHarmonizatorId.Value);
		}
		set
		{
			WorkLogHarmonizatorId = value?.Id;
		}
	}
}
