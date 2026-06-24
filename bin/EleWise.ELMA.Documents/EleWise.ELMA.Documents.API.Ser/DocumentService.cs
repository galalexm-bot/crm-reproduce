using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.API.Models;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.Documents.API.Service.v1;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[Component]
[Uid("{E508AF3C-DB23-43ED-9FA0-BD2C2194A386}")]
public class DocumentService : IDocumentService, IPublicAPIWebService
{
	public const string GuidS = "{E508AF3C-DB23-43ED-9FA0-BD2C2194A386}";

	public static Guid Guid = new Guid("{E508AF3C-DB23-43ED-9FA0-BD2C2194A386}");

	public bool DocumentVersionLock(string versionId)
	{
		if (!long.TryParse(versionId, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не удалось привести идентификатор версии к целому числу"), 400);
		}
		try
		{
			DocumentVersionManager.Instance.LockWithLock(result);
			return true;
		}
		catch (Exception innerException)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не удалось блокировать версию документа"), innerException, 500);
		}
	}

	public bool DocumentVersionUnLock(string versionId)
	{
		if (!long.TryParse(versionId, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не удалось привести идентификатор версии к целому числу"), 400);
		}
		try
		{
			IDocumentVersion version = DocumentVersionManager.Instance.Load(result);
			DocumentVersionManager.Instance.UnLock(version);
			return true;
		}
		catch (Exception innerException)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не удалось разблокировать версию документа"), innerException, 500);
		}
	}

	public DocumentVersionModel[] GetCurrentVersions(string documentId)
	{
		if (!long.TryParse(documentId, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не удалось привести идентификатор документа к целому числу"), 400);
		}
		try
		{
			IDocument document = DocumentManager.Instance.Load(result);
			return DocumentVersionManager.Instance.GetCurrentVersion(document).Select((Func<IDocumentVersion, DocumentVersionModel>)Mapper.Map<IDocumentVersion, DocumentVersionModel>).ToArray();
		}
		catch (Exception innerException)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Ошибка получения текущих версий документа"), innerException, 500);
		}
	}

	public bool CanEditDocument(string documentId)
	{
		if (!long.TryParse(documentId, out var result))
		{
			throw PublicServiceException.CreateWebFault(SR.T("Не удалось привести идентификатор документа к целому числу"), 400);
		}
		try
		{
			return Locator.GetServiceNotNull<ISecurityService>().HasPermission(target: DocumentManager.Instance.Load(result), permission: PermissionProvider.DocumentEditPermission);
		}
		catch (Exception innerException)
		{
			throw PublicServiceException.CreateWebFault(SR.T("Ошибка проверки прав доступа на документ"), innerException, 500);
		}
	}
}
