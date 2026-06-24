using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Web.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 10)]
public class DocumentFunctionPermissionProvider : IFunctionPermissionProvider
{
	public const string UIDS = "{FC2268F7-56EC-4CCA-9D57-25D6F9A99531}";

	public static Guid UID = new Guid("{FC2268F7-56EC-4CCA-9D57-25D6F9A99531}");

	public Guid Uid => UID;

	public void CheckPermission(Type entityType, long id, Guid permisssionId)
	{
		if (id == 0L)
		{
			return;
		}
		IDocumentsPropertyResolver documentsPropertyResolver = ComponentManager.Current.GetExtensionPoints<IDocumentsPropertyResolver>().FirstOrDefault((IDocumentsPropertyResolver r) => r.CheckType(entityType));
		if (documentsPropertyResolver == null)
		{
			return;
		}
		object entity = ModelHelper.GetEntityManager(entityType).Load(id);
		List<IDocument> list = documentsPropertyResolver.Resolve(entity);
		if (list == null)
		{
			return;
		}
		ISecurityService securityService = Locator.GetServiceNotNull<ISecurityService>();
		IPermissionManagmentService serviceNotNull = Locator.GetServiceNotNull<IPermissionManagmentService>();
		Permission permission = serviceNotNull.GetPermission(permisssionId);
		list.ForEach(delegate(IDocument d)
		{
			string text = SR.T("Ошибка доступа к объекту \"{0}\" с идентификатором {1}", d.Name, d.Id);
			if (!securityService.HasPermission(permission, d))
			{
				throw DocumentManager.Instance.CreateSecurityException(text, d.Id);
			}
		});
	}
}
