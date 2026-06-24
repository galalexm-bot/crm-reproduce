using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.ExtensionPoints;

public interface IUpdateModel
{
	IMetadata Metadata { get; }

	ScriptModule ClientScriptModule { get; set; }

	ScriptModule ViewScriptModule { get; set; }

	ScriptModule ServerScriptModule { get; set; }

	ScriptModule TestScriptModule { get; set; }

	InterfaceBuilderViewMode ViewMode { get; set; }
}
