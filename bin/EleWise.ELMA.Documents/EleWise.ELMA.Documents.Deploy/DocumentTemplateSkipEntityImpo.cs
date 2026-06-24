using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Documents.Deploy.Import;

[Component]
public class DocumentTemplateSkipEntityImportResolver : BaseSkipEntityImportResolver
{
	public ISecurityService SecurityService { get; set; }

	public override bool IsSkip(Dictionary<string, object> propValues, Dictionary<string, string> serviceData)
	{
		IDocument document = null;
		Guid documentId = GetId(propValues, "Document");
		if (documentId != Guid.Empty)
		{
			SecurityService.RunWithElevatedPrivilegies(delegate
			{
				document = DocumentManager.Instance.LoadOrNull(documentId);
			});
		}
		if (document != null)
		{
			return false;
		}
		if (GetId(propValues, "File") != Guid.Empty)
		{
			return false;
		}
		Guid uid = GetId(propValues, "Uid");
		return !serviceData.Any((KeyValuePair<string, string> s) => DocumentTemplateImportSaveActions.IsKeyMatch(s.Key, uid));
	}

	public override bool IsSupported(Guid typeGuid)
	{
		if (!(typeGuid == InterfaceActivator.UID<IDocumentTemplate>()))
		{
			return typeGuid == InterfaceActivator.UID<IDocumentTemplate>(loadImplementation: false);
		}
		return true;
	}
}
