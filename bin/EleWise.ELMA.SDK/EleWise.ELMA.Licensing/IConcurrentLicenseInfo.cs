namespace EleWise.ELMA.Licensing;

public interface IConcurrentLicenseInfo : IWorkplaceLicenseInfo, ILicenseInfo
{
	bool IsConcurrent { get; }

	uint? PrivilegeCount { get; }

	uint UsedPrivilegeCount { get; }
}
