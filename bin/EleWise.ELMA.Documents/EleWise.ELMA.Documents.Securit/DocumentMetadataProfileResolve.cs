using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Security;

[Component]
internal class DocumentMetadataProfileResolver : IProfileResolver
{
	private const string Key = "EleWise.ELMA.Documents.Security.DocumentMetadataProfileResolver";

	public Type ResolveProfileType(Type type)
	{
		if (!type.IsInheritOrSame<IDocument>())
		{
			return null;
		}
		return InterfaceActivator.TypeOf<IDocumentMetadataProfile>();
	}

	public object ResolveProfile(Type type)
	{
		if (!type.IsInheritOrSame<IDocument>())
		{
			return null;
		}
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(type, inherit: false);
		if (!ContextVars.TryGetValue<Dictionary<Guid, IDocumentMetadataProfile>>("EleWise.ELMA.Documents.Security.DocumentMetadataProfileResolver", out var value))
		{
			if (ContextVars.TryGetValue<List<Guid>>("EleWise.ELMA.Web.Mvc.Html.UiExtensions.GetInheritedCreatorsAndChild", out var value2))
			{
				value = DocumentMetadataProfileManager.Instance.LoadByDocumentTypes(value2).ToDictionary((IDocumentMetadataProfile k) => k.DocumentType.TypeUid, (IDocumentMetadataProfile v) => v);
				ContextVars.Set("EleWise.ELMA.Documents.Security.DocumentMetadataProfileResolver", value);
			}
			ContextVars.Remove("EleWise.ELMA.Web.Mvc.Html.UiExtensions.GetInheritedCreatorsAndChild");
		}
		if (value != null && value.TryGetValue(entityMetadata.ImplementationUid, out var value3) && value3 != null)
		{
			return value3;
		}
		return DocumentMetadataProfileManager.Instance.LoadByDocumentType(entityMetadata.ImplementationUid);
	}
}
