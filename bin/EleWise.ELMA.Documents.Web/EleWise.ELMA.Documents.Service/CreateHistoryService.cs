using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Documents.Services;

[Service(Type = ComponentType.WebServer, InjectProperties = true, Scope = ServiceScope.Shell, EnableInterceptors = false)]
public class CreateHistoryService : ICreateHistoryService
{
	public const string Path = "CreateDocumentHistory";

	public IAuthenticationService AuthenticationService { get; set; }

	protected CreateDocumentHistory LoadHistory()
	{
		CreateDocumentHistory result = null;
		try
		{
			result = PersonalizationAdministration.Provider.LoadState<CreateDocumentHistory>(AuthenticationService.GetCurrentUser().UserName, "CreateDocumentHistory");
			return result;
		}
		catch (Exception ex)
		{
			Logger.Log.Error(ex.Message, ex);
			return result;
		}
	}

	public List<ClassMetadata> Get()
	{
		Contract.ArgumentNotNull(PersonalizationAdministration.Provider, "PersonalizationAdministration.Provider");
		CreateDocumentHistory createDocumentHistory = LoadHistory();
		if (createDocumentHistory == null)
		{
			return new List<ClassMetadata>();
		}
		IEnumerable<DocumentMetadata> creatableDocumentTypes = DocumentMetadataProfileManager.Instance.CreateableDocumentTypes();
		if (createDocumentHistory.TypeList.Any((Guid t) => !creatableDocumentTypes.Any((DocumentMetadata ct) => ct.Uid == t)))
		{
			createDocumentHistory.TypeList.RemoveAll((Guid t) => !creatableDocumentTypes.Any((DocumentMetadata ct) => ct.Uid == t));
			PersonalizationAdministration.Provider.SaveState(AuthenticationService.GetCurrentUser().UserName, "CreateDocumentHistory", createDocumentHistory);
		}
		return createDocumentHistory.TypeList.Select((Guid t) => (ClassMetadata)MetadataLoader.LoadMetadata(t)).ToList();
	}

	public void Add(ClassMetadata metadata)
	{
		Contract.ArgumentNotNull(PersonalizationAdministration.Provider, "PersonalizationAdministration.Provider");
		CreateDocumentHistory createDocumentHistory = LoadHistory() ?? new CreateDocumentHistory();
		createDocumentHistory.Add(metadata.Uid);
		PersonalizationAdministration.Provider.SaveState(AuthenticationService.GetCurrentUser().UserName, "CreateDocumentHistory", createDocumentHistory);
	}

	public void SetStatus(DocumentVersionStatus status)
	{
		CreateDocumentHistory createDocumentHistory = LoadHistory() ?? new CreateDocumentHistory();
		createDocumentHistory.DocumentVersionStatus = status;
		PersonalizationAdministration.Provider.SaveState(AuthenticationService.GetCurrentUser().UserName, "CreateDocumentHistory", createDocumentHistory);
	}

	public DocumentVersionStatus GetStatus()
	{
		return (LoadHistory() ?? new CreateDocumentHistory()).DocumentVersionStatus;
	}
}
