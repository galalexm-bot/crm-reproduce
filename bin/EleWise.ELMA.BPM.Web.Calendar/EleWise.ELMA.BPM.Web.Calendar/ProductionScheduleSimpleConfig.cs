using EleWise.ELMA.Projects.Models.Resources;
using Newtonsoft.Json;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public sealed class ProductionScheduleSimpleConfigModel
{
	[JsonIgnore]
	public IResourceCalendar Entity { get; set; }

	[JsonProperty("Entity")]
	public ResourceCalendarSimpleModel EntityPart { get; set; }

	public bool IsGlobalProductionSchedule { get; private set; }

	public bool SimpleModeEnable { get; set; }

	public bool InJsonFormat { get; set; }

	public ProductionScheduleSimpleConfigModel()
	{
	}

	public ProductionScheduleSimpleConfigModel(ProductionScheduleConfigModel fullModel)
	{
		Contract.ArgumentNotNull(fullModel, "fullModel");
		Entity = fullModel.Entity;
		EntityPart = new ResourceCalendarSimpleModel(Entity);
		SimpleModeEnable = fullModel.SimpleModeEnable;
		InJsonFormat = fullModel.InJsonFormat;
		IsGlobalProductionSchedule = fullModel.IsGlobalProductionSchedule;
	}
}
