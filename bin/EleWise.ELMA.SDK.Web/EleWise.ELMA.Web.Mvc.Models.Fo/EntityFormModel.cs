namespace EleWise.ELMA.Web.Mvc.Models.Forms;

public class EntityFormModel
{
	public EntityFormInfo EntityFormInfo { get; private set; }

	public bool CanEdit { get; set; }

	public string UniqueId { get; set; }

	public bool HideEdit { get; set; }

	public bool HideDelete { get; set; }

	public EntityFormModel(EntityFormInfo entityFormInfo)
	{
		EntityFormInfo = entityFormInfo;
	}

	public EntityFormModel(EntityFormInfo entityFormInfo, bool canEdit, string uniqueId)
	{
		EntityFormInfo = entityFormInfo;
		CanEdit = canEdit;
		UniqueId = uniqueId;
	}
}
