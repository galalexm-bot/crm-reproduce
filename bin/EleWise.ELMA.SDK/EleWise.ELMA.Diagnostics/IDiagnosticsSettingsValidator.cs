namespace EleWise.ELMA.Diagnostics;

public interface IDiagnosticsSettingsValidator
{
	void ValidateSettings(EventProcessorsInfo settings);
}
