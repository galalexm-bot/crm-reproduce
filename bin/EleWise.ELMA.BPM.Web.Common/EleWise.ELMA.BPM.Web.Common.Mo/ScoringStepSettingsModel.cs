using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class ScoringStepSettingsModel
{
	[DisplayName("SR.M('Название сущности')")]
	public string DisplayName { get; set; }

	[DisplayName("SR.M('Тип сущности')")]
	public Guid EntityType { get; set; }

	public GridData<IScoringStepSettings> SettingsList { get; set; }
}
