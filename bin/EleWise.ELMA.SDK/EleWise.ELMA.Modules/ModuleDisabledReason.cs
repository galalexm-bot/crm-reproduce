namespace EleWise.ELMA.Modules;

public enum ModuleDisabledReason
{
	Unknown,
	DisabledOnServer,
	DisabledManually,
	Activation,
	ActivationInDb,
	Dependency,
	PackageNotInstalled,
	NotUsedInDb,
	Deprecated
}
