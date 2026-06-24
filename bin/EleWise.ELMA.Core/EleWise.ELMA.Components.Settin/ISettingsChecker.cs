using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Components.SettingsChecker;

[ExtensionPoint]
public interface ISettingsChecker
{
	string[] Check(TypeSettings settings);
}
