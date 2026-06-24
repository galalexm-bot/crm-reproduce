using System;
using System.Collections.Generic;
using System.Security;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Managers;

public class ActionFolderManager<T, TId> : EntityManager<T, TId> where T : IActionFolder, IEntity<TId>
{
	public override SecurityException CreateSecurityException(string text, object id)
	{
		IMetadata metadata = MetadataLoader.LoadMetadata(typeof(T));
		return new EntitySecurityException(text)
		{
			TypeUid = metadata.Uid,
			EntityId = Convert.ToInt64(id),
			Permissions = new List<Guid>
			{
				PermissionProvider.DocumentFullAccessPermission.Id,
				PermissionProvider.DocumentManagerAccessPermission.Id
			}
		};
	}

	public override ExportRuleList ExportRules()
	{
		Type parentType = InterfaceActivator.TypeOf<IActionFolder>();
		return new ExportRuleList
		{
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "ActionId",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "ActionTypeProviderId",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Description",
				ExportRuleType = ExportRuleType.Export
			}
		};
	}
}
[DeveloperApi(DeveloperApiType.Manager)]
public class ActionFolderManager : FolderManager<IActionFolder, long>
{
	public ICacheService CacheService => Locator.GetServiceNotNull<ICacheService>();

	[NotNull]
	public new static ActionFolderManager Instance => Locator.GetServiceNotNull<ActionFolderManager>();
}
