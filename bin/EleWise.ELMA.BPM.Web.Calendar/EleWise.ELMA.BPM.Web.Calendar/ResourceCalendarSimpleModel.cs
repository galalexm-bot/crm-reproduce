using EleWise.ELMA.Projects.Models.Resources;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public sealed class ResourceCalendarSimpleModel
{
	public long Id { get; set; }

	public bool? IsCatalog { get; set; }

	public string Name { get; set; }

	public ResourceCalendarSimpleModel()
	{
	}

	public ResourceCalendarSimpleModel(IResourceCalendar entity)
	{
		Contract.ArgumentNotNull(entity, "entity");
		Id = entity.Id;
		IsCatalog = entity.IsCatalog;
		Name = entity.Name;
	}
}
