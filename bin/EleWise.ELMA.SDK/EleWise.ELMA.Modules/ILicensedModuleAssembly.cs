namespace EleWise.ELMA.Modules;

public interface ILicensedModuleAssembly : IModuleAssembly, IApplicationUnit, ILicensedUnit
{
	ILicensedUnit LicenseUnit { get; }
}
