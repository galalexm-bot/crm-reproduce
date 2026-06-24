using System;

namespace EleWise.ELMA.Messages.Web.Models;

public sealed class MessageAttachmentModel
{
	public Guid TypeUid { get; set; }

	public string Id { get; set; }

	public string Name { get; set; }
}
