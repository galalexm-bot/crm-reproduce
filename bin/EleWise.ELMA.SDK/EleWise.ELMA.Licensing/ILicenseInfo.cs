namespace EleWise.ELMA.Licensing;

public interface ILicenseInfo
{
	LicenseStatus Status { get; }

	string Description { get; }

	byte LicenseType { get; }
}
