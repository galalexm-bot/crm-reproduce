using System;

namespace EleWise.ELMA.Web.Mvc.Models.ViewItem;

[Serializable]
public sealed class ViewItemContentRequest : ViewItemRequest
{
	public Guid FormUid { get; set; }

	public Guid ViewItemUid { get; set; }
}
