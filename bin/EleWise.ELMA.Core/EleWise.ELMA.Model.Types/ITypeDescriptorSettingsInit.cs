using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;

namespace EleWise.ELMA.Model.Types;

public interface ITypeDescriptorSettingsInit
{
	TypeSettings CreateSettings();

	void InitSettingsFromSettings(TypeSettings typeSettings, TypeSettings newSettings);
}
