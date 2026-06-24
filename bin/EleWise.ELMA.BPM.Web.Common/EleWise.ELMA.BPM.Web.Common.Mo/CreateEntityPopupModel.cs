using System;
using System.Collections.Generic;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public sealed class CreateEntityPopupModel
{
	public Guid EntityTypeUid { get; set; }

	public Guid PopupUid { get; set; }

	public Guid ContainerUid { get; set; }

	public string InputId { get; set; }

	public bool SelectorForCreator { get; set; }

	public List<IFormCreator> FormCreator { get; set; }

	public string CreatePopupParams { get; set; }
}
