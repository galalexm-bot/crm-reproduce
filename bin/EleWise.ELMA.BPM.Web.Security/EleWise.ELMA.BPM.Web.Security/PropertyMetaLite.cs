using System;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

public class PropertyMetaLite
{
	public bool IsTitle { get; set; }

	public string DisplayName { get; set; }

	public Guid Uid { get; set; }

	public bool IsRequired { get; set; }
}
