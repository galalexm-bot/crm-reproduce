using System.Collections.Generic;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Deploy.Export.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IExportDataExtension
{
	bool CheckMetadata(IMetadata metadata);

	List<ClassMetadata> ExportObjects(XmlWriter writer, ClassMetadata metadata, List<DeployLogMessage> messages, List<ClassMetadata> wasExported, List<string> fileUids);
}
