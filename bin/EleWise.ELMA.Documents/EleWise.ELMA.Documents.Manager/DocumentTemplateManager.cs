using System;
using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Managers;

public class DocumentTemplateManager : EntityManager<IDocumentTemplate, long>
{
	public new static DocumentTemplateManager Instance => Locator.GetServiceNotNull<DocumentTemplateManager>();

	public DocumentMetadataProfileManager DocumentMetadataProfileManager { get; set; }

	[PublicApiMember]
	public virtual IEnumerable<IDocumentTemplate> GetDocumentTemplates(IDocument document)
	{
		Contract.ArgumentNotNull(document, "document");
		Guid typeUid = InterfaceActivator.UID(document.CastAsRealType().GetType());
		return (IEnumerable<IDocumentTemplate>)(DocumentMetadataProfileManager.LoadByDocumentTypeFromImplementation(typeUid) ?? throw new Exception(SR.T("Не найден профиль типа документа"))).Templates;
	}
}
