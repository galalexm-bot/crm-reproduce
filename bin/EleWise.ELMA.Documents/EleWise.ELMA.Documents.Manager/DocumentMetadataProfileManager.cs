using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;

namespace EleWise.ELMA.Documents.Managers;

public class DocumentMetadataProfileManager : EntityManager<IDocumentMetadataProfile, long>
{
	private Func<long, IEnumerable<DocumentMetadata>> getCreateableDocumentTypesCached;

	private Action clearCacheMethod;

	[NotNull]
	public ITransformationProvider TransformationProvider { get; set; }

	public new static DocumentMetadataProfileManager Instance => Locator.GetServiceNotNull<DocumentMetadataProfileManager>();

	protected override void InitInternal()
	{
		base.InitInternal();
		getCreateableDocumentTypesCached = MetadataLoader.UseCachingForFunc((long usedId) => GetCreateableDocumentTypes(usedId), out clearCacheMethod);
	}

	[ContextCache]
	public virtual IDocumentMetadataProfile LoadByDocumentTypeFromImplementation(Guid typeUid)
	{
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(typeUid);
		return LoadByDocumentType(entityMetadata.ImplementationUid);
	}

	[ContextCache]
	public virtual IDocumentMetadataProfile LoadByDocumentType(Guid uid)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("DocumentType", (object)new ReferenceOnEntityType
		{
			TypeUid = uid
		})).SetMaxResults(1).SetCacheable(false)
			.UniqueResult<IDocumentMetadataProfile>();
	}

	public virtual IEnumerable<IDocumentMetadataProfile> LoadByDocumentTypes(IEnumerable<Guid> uids)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.In("DocumentType", (ICollection)uids.Select((Guid u) => new ReferenceOnEntityType
		{
			TypeUid = u
		}).ToList())).SetCacheable(false).List<IDocumentMetadataProfile>();
	}

	protected SqlSubQuery CreatePermissionQuery(EleWise.ELMA.Security.Models.IUser user, Permission permission)
	{
		return base.Session.CreateSQLSubQuery("select p.DOCUMENTMETADATAPROFILE from DMSOBJECTDEFAULTPERMISSIONS p\r\n                                    inner join UserSecuritySetCache c on p.UserSecuritySetCacheId = c.SetId\r\n                                    where c.UserId = :userId and p.PermissionId = :permissionId").SetParameter("userId", user.Id).SetParameter("permissionId", permission.Id);
	}

	public virtual void ClearCreateableDocumentTypesCache()
	{
		clearCacheMethod();
	}

	[ContextCache]
	public virtual IEnumerable<DocumentMetadata> CreateableDocumentTypes(string text = "", EleWise.ELMA.Security.Models.IUser user = null, bool disabledInWeb = true)
	{
		if (user == null)
		{
			user = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		}
		bool isTextNullOrEmpty = string.IsNullOrEmpty(text);
		if (!isTextNullOrEmpty)
		{
			text = text.ToUpper();
		}
		IEnumerable<DocumentMetadata> enumerable = from p in getCreateableDocumentTypesCached(user.Id)
			where isTextNullOrEmpty || p.DisplayName.ToUpper().Contains(text)
			select p;
		if (!disabledInWeb)
		{
			return enumerable.Where((DocumentMetadata p) => !p.DisableCreate);
		}
		return enumerable;
	}

	private IEnumerable<DocumentMetadata> GetCreateableDocumentTypes(long userId)
	{
		EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.Load(userId);
		ICriteria val = CreateCriteria();
		if (!base.SecurityService.HasPermission(PermissionProvider.DocumentsFullAccessToAllObjectsPermission))
		{
			SqlSubQuery sqlSubQuery = CreatePermissionQuery(user, PermissionProvider.DocumentMetadataCreateInstance);
			string text = string.Format("{{alias}}.{0} in ({1})", TransformationProvider.Dialect.QuoteIfNeeded("Id"), sqlSubQuery.Sql);
			val.Add((ICriterion)(object)Expression.Sql(text, sqlSubQuery.ParametersValues, sqlSubQuery.ParametersTypes));
		}
		SqlSubQuery sqlSubQuery2 = base.Session.CreateSQLSubQuery("select DocumentTypeUid from DocumentMetadataHead where IsDeleted = :isDeleted").SetParameter("isDeleted", false, (IType)(object)NHibernateUtil.Boolean);
		string text2 = string.Format("{{alias}}.{0} in ({1})", TransformationProvider.Dialect.QuoteIfNeeded("DocumentType"), sqlSubQuery2.Sql);
		val.Add((ICriterion)(object)Expression.Sql(text2, sqlSubQuery2.ParametersValues, sqlSubQuery2.ParametersTypes));
		return (from r in val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Property("DocumentType") }).List<ReferenceOnEntityType>()
			select MetadataLoader.LoadMetadataOrNull(r.TypeUid)).OfType<DocumentMetadata>();
	}

	public override ExportRuleList ExportRules()
	{
		Type parentType = InterfaceActivator.TypeOf<IDocumentMetadataProfile>();
		return new ExportRuleList
		{
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "DocumentType",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Folder",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "RestrictChangeFolder",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Permissions",
				ExportRuleType = ExportRuleType.ExportDeep
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "Templates",
				ExportRuleType = ExportRuleType.ExportDeep
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "CreationAuthor",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "DefaultPermissionType",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "UseCustomHistorySettings",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "HistoryViewSettings",
				ExportRuleType = ExportRuleType.ExportDeep
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "AuthorDefaultPermissionId",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "AuthorAddAccessDefaulPermission",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "UseCustomActionsSettings",
				ExportRuleType = ExportRuleType.Export
			},
			new ExportRule
			{
				ParentType = parentType,
				PropertyName = "ActionVisibility",
				ExportRuleType = ExportRuleType.Export
			}
		};
	}
}
