using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Templates;

[ExtensionPoint(ComponentType.WebServer)]
public interface ITemplateDataSource
{
	IEnumerable<TemplateFileInfo> GetFiles();
}
