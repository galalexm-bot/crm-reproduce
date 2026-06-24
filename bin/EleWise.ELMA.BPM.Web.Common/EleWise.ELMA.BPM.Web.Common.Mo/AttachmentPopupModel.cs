using System;
using System.Collections.Generic;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class AttachmentPopupModel
{
	[Obsolete("Не используется")]
	public IEnumerable<AttachmentFileModel> Attachments { get; set; }

	public string PopupId { get; set; }

	public string EntityName { get; set; }

	public Guid TypeUid { get; set; }

	public long Id { get; set; }

	public string NameProperty { get; set; }

	public bool WithNameProperty { get; set; }

	public GridData<AttachmentFileModel> GridData { get; set; }
}
