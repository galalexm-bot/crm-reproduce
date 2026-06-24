using System;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class ObjectFilterModel
{
	public object Filter { get; set; }

	public Guid EntityTypeUid { get; set; }
}
