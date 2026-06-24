using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.ServiceModel;
using System.ServiceModel.Activation;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.UIBuilder.Web.Models;
using EleWise.ELMA.Web.Service;

namespace EleWise.ELMA.UIBuilder.Web.Service;

[ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, MaxItemsInObjectGraph = int.MaxValue)]
[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
[ServiceKnownType("GetGlobalKnownTypes", typeof(ServiceKnownTypeHelper))]
[CustomContentTypeMapper(typeof(WebContentRawMapper))]
[Component]
[Uid("{B4A41201-0381-4DFE-94C2-C04CBAE80BAE}")]
internal sealed class FormViewItemService : IFormViewItemService, IInternalAPIWebService
{
	private const string GuidS = "{B4A41201-0381-4DFE-94C2-C04CBAE80BAE}";

	private static IMetadataRuntimeService MetadataRuntimeService => Locator.GetServiceNotNull<IMetadataRuntimeService>();

	private static void LogServiceError(Expression<Func<FormViewItemService, object>> method, string message)
	{
		Logger.Log.Error(SR.T("В сервисе \"{0}\" в методе \"{1}\" произошла ошибка: {message}", typeof(FormViewItemService), method, message));
	}

	public IEnumerable<FormViewItemHeader> GetMetadataForms(Guid metadataUid)
	{
		EntityMetadata entityMetadata = MetadataRuntimeService.GetMetadata(metadataUid, loadImplementation: false) as EntityMetadata;
		if (entityMetadata == null)
		{
			string message = SR.T("Не найдены метаданные сущности для типа \"{0}\"", metadataUid);
			LogServiceError((FormViewItemService q) => q.GetMetadataForms(metadataUid), message);
			throw PublicServiceException.CreateWebFault(message, 404);
		}
		List<FormViewItemHeader> list = new List<FormViewItemHeader>();
		do
		{
			AddForms(entityMetadata, list);
			if (MetadataRuntimeService.GetMetadata(entityMetadata.ImplementationUid) is EntityMetadata entityMetadata2 && entityMetadata2.ImplementedExtensionUids != null)
			{
				foreach (Guid implementedExtensionUid in entityMetadata2.ImplementedExtensionUids)
				{
					if (MetadataRuntimeService.GetMetadata(implementedExtensionUid, loadImplementation: false) is EntityMetadata metadata)
					{
						AddForms(metadata, list);
					}
				}
			}
			if (entityMetadata.BaseClassUid == Guid.Empty)
			{
				break;
			}
			entityMetadata = MetadataRuntimeService.GetMetadata(entityMetadata.BaseClassUid, loadImplementation: false) as EntityMetadata;
		}
		while (entityMetadata != null);
		return list;
	}

	private static void AddForms(ClassMetadata metadata, List<FormViewItemHeader> forms)
	{
		forms.AddRange(metadata.Forms.Select((FormViewItem form) => new FormViewItemHeader
		{
			Uid = form.Uid,
			DisplayName = form.DisplayName,
			GroupUid = form.GroupUid,
			RuntimeVersion = (int)form.RuntimeVersion,
			TargetUid = form.TargetUid
		}));
		forms.AddRange(from t in metadata.FormTransformations
			where t.NewFormUid != Guid.Empty
			select t into transformation
			select new FormViewItemHeader
			{
				Uid = transformation.NewFormUid,
				DisplayName = transformation.NewFormDisplayName
			});
	}
}
