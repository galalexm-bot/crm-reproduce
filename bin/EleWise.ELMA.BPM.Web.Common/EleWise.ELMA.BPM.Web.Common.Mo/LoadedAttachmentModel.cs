using System;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class LoadedAttachmentModel : BaseAttachmentModel
{
	public string ContainerClassName { get; set; }

	public string Prefix { get; set; }

	public string Suffix { get; set; }

	public string Content { get; set; }

	public object Id { get; set; }

	public Guid TypeUid { get; set; }
}
