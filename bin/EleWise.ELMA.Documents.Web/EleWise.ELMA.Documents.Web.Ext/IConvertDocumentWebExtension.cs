using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Documents.Web.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IConvertDocumentWebExtension
{
	object CreateModel();

	void SetValue(Dictionary<string, object> dict, object model);
}
