using System;

namespace EleWise.ELMA.BPM.Web.Security.Code;

public class CrmPermissionData
{
	public Guid ObjectType { get; set; }

	public long Id { get; set; }

	public bool CanRead { get; set; }

	public bool CanEdit { get; set; }

	public bool FullAccess { get; set; }
}
