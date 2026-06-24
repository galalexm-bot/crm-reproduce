using System;

namespace EleWise.ELMA.BPM.Web.Security.Controllers;

internal class PropertySettings
{
	public long id { get; set; }

	public Type type { get; set; }

	public Guid prop_guid { get; set; }

	public string access_value { get; set; }
}
