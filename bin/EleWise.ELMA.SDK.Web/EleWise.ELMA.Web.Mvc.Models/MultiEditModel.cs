using System;

namespace EleWise.ELMA.Web.Mvc.Models;

public class MultiEditModel
{
	public Guid ExtPointUid { get; set; }

	public long CurrentUserId { get; set; }

	public string ObjectTypeName { get; set; }

	public long ObjectId { get; set; }

	public string ObjectIds { get; set; }

	public bool IsManyObjects { get; set; }

	public bool IsCustomHtmlMarkup { get; set; }
}
