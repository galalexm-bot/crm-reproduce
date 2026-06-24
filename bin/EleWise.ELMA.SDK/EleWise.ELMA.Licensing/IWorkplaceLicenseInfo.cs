namespace EleWise.ELMA.Licensing;

public interface IWorkplaceLicenseInfo : ILicenseInfo
{
	uint? WorkplaceCount { get; }

	uint UsedLicenseCount { get; }
}
