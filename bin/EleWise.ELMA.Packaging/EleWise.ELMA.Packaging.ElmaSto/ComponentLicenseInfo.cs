using System;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

public class ComponentLicenseInfo
{
	public ComponentLicenseStatus Status { get; set; }

	public DateTime? TrialExpiration { get; set; }

	public byte LicenseType { get; set; }

	public uint? WorkplaceCount { get; set; }
}
