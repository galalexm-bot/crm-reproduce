using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Audit;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class ContractorManager<T> : BaseCrmManager<T> where T : IContractor
{
	private static object contactSupportSyncLock = new object();

	private static volatile List<Guid> _contactSupportTypeUids;

	public new IAuthenticationService AuthenticationService { get; set; }

	public List<Guid> ContactSupportTypeUids
	{
		get
		{
			if (_contactSupportTypeUids == null)
			{
				lock (contactSupportSyncLock)
				{
					if (_contactSupportTypeUids == null)
					{
						List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IContractor>()));
						IMetadataRuntimeService runtimeService = Locator.GetServiceNotNull<IMetadataRuntimeService>();
						_contactSupportTypeUids = (from c in childClasses
							where runtimeService.GetTypeByUid(c.Uid).GetInterfaces().Contains(typeof(IContactSupport))
							select c.Uid).ToList();
					}
				}
			}
			return _contactSupportTypeUids;
		}
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		IContractorFilter contractorFilter = filter as IContractorFilter;
		IAddressFilter addressFilter = null;
		if (contractorFilter != null)
		{
			addressFilter = contractorFilter.LegalAddress;
			contractorFilter.LegalAddress = null;
		}
		base.SetupFilter(criteria, filter);
		if (contractorFilter == null)
		{
			return;
		}
		contractorFilter.LegalAddress = addressFilter;
		if (addressFilter != null && !addressFilter.IsEmpty())
		{
			string text = null;
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(base.ImplementationType);
			DisjunctionCriteria disjunctionCriteria = new DisjunctionCriteria(criteria);
			PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "LegalAddress");
			ITypeDescriptor typeDescriptor = base.MetadataRuntimeService.GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid);
			IFilterableType filterableType = (IFilterableType)base.MetadataRuntimeService.GetTypeDescriptor(typeDescriptor.GetFilterType(propertyMetadata, entityMetadata), propertyMetadata.SubTypeUid);
			foreach (EntityPropertyMetadata item in entityMetadata.Properties.Where((PropertyMetadata p) => p.SubTypeUid == InterfaceActivator.UID<IAddress>(loadImplementation: false)))
			{
				disjunctionCriteria.NewDisjunctionCriteria();
				filterableType.ApplyFilterValue((ICriteria)(object)disjunctionCriteria, entityMetadata, item, addressFilter, string.IsNullOrEmpty(text) ? DefaultCriteriaAlias : text);
			}
		}
		if (contractorFilter.ShowOnlyMy)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("Responsible", (object)AuthenticationService.GetCurrentUser()));
		}
		if (!string.IsNullOrEmpty(contractorFilter.Phone))
		{
			string alias = "PhoneAlias";
			DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<IContractor>()).Add((ICriterion)(object)ElmaRestrictions.Like("PhoneAlias.PhoneString", contractorFilter.Phone, MatchMode.Exact)).SetProjection((IProjection)(object)Projections.Property("Id"));
			criteria.GetOrCreateAlias("Phone", "Phone", (JoinType)0, ref alias).Add((ICriterion)(object)Subqueries.PropertyIn("Id", val));
		}
		if (!string.IsNullOrEmpty(contractorFilter.Email))
		{
			string alias2 = "EmailAlias";
			DetachedCriteria val2 = DetachedCriteria.For(InterfaceActivator.TypeOf<IContractor>()).Add((ICriterion)(object)ElmaRestrictions.InsensitiveLike("EmailAlias.EmailString", contractorFilter.Email, MatchMode.Anywhere)).SetProjection((IProjection)(object)Projections.Property("Id"));
			criteria.GetOrCreateAlias("Email", "Email", (JoinType)0, ref alias2).Add((ICriterion)(object)Subqueries.PropertyIn("Id", val2));
		}
		if (contractorFilter.IsContactSupportType.HasValue)
		{
			criteria.Add((ICriterion)(object)(contractorFilter.IsContactSupportType.Value ? Restrictions.In(GetTypeUidPropertyName(filter), (ICollection)ContactSupportTypeUids) : Restrictions.Not((ICriterion)(object)Restrictions.In(GetTypeUidPropertyName(filter), (ICollection)ContactSupportTypeUids))));
		}
		IMarketingGroup marketingGroup = (IMarketingGroup)contractorFilter.GetPropertyValue("MarketingGroup", null);
		if (marketingGroup != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("MarketingGroup", (object)marketingGroup));
		}
		IMarketingActivity marketingActivity = (IMarketingActivity)contractorFilter.GetPropertyValue("MarketingActivity", null);
		if (marketingActivity != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("MarketingActivity", (object)marketingActivity));
		}
		IMarketingEffect marketingEffect = (IMarketingEffect)contractorFilter.GetPropertyValue("MarketingEffect", null);
		if (marketingEffect != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq("MarketingEffect", (object)marketingEffect));
		}
		if (contractorFilter.MarketingObjects == null || !((IEnumerable<IMarketingBase>)contractorFilter.MarketingObjects).Any())
		{
			return;
		}
		List<IMarketingGroup> list = new List<IMarketingGroup>();
		List<IMarketingActivity> list2 = new List<IMarketingActivity>();
		List<IMarketingEffect> list3 = new List<IMarketingEffect>();
		foreach (IMarketingBase item2 in (IEnumerable<IMarketingBase>)contractorFilter.MarketingObjects)
		{
			if (item2 is IMarketingGroup)
			{
				list.Add((IMarketingGroup)item2);
				continue;
			}
			if (item2 is IMarketingActivity)
			{
				list2.Add((IMarketingActivity)item2);
				continue;
			}
			if (item2 is IMarketingEffect)
			{
				list3.Add((IMarketingEffect)item2);
				continue;
			}
			throw new NotSupportedException(SR.T("Неподдерживаемый тип объекта маркетинга: {0}", item2.GetType().FullName));
		}
		criteria.Add((ICriterion)(object)((Junction)new Disjunction()).Add((ICriterion)(object)Restrictions.In("MarketingGroup", (ICollection)list)).Add((ICriterion)(object)Restrictions.In("MarketingActivity", (ICollection)list2)).Add((ICriterion)(object)Restrictions.In("MarketingEffect", (ICollection)list3)));
	}
}
[DeveloperApi(DeveloperApiType.Manager)]
public class ContractorManager : ContractorManager<IContractor>
{
	public new IAuthenticationService AuthenticationService
	{
		get
		{
			return base.AuthenticationService;
		}
		set
		{
			base.AuthenticationService = value;
		}
	}

	protected override string DefaultCriteriaAlias => "contractorMn";

	public new static ContractorManager Instance => Locator.GetServiceNotNull<ContractorManager>();

	public new List<Guid> ContactSupportTypeUids => base.ContactSupportTypeUids;

	public bool IsSaved(IContractor contractor)
	{
		if (contractor == null)
		{
			return false;
		}
		return base.Session.Get(base.ImplementationType, (object)contractor.Id) != null;
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
	}

	public void LinkToMarketing(IContractor contractor, IMarketingBase marketingBase)
	{
		if (contractor == null)
		{
			throw new ArgumentException("Null argument: contractor");
		}
		IMarketingBase marketingBase2 = marketingBase.CastAsRealType();
		if (marketingBase2 is IMarketingGroup)
		{
			contractor.MarketingGroup = (IMarketingGroup)marketingBase2;
		}
		else if (marketingBase2 is IMarketingActivity)
		{
			contractor.MarketingActivity = (IMarketingActivity)marketingBase2;
		}
		else
		{
			if (!(marketingBase2 is IMarketingEffect))
			{
				throw new Exception(SR.T("Неизвестный тип объекта маркетинга"));
			}
			contractor.MarketingEffect = (IMarketingEffect)marketingBase2;
		}
		contractor.Save();
	}

	public SaveWithCategoryRulesResult SaveWithCategoryRules(IContractor contractor, RuleDeletedCategoryAction ruleDeletedCategoryAction = RuleDeletedCategoryAction.Delete)
	{
		return CategoryAssignMethodManager.Instance.SaveWithCategoryRules(contractor, contractor.Categories, CategoryRuleType.RuleForContractor, ruleDeletedCategoryAction);
	}

	public virtual void AddPermissionsFromParent(IContractor contractor)
	{
		List<IContractorPersonPermission> list = new List<IContractorPersonPermission>();
		foreach (ICategory item in (contractor.Categories != null && ((IEnumerable<ICategory>)contractor.Categories).Any()) ? ((IEnumerable<ICategory>)contractor.Categories).ToList() : new List<ICategory> { CategoryManager.Instance.LoadOrNull(CategoryManager.NoCategoryUid) })
		{
			if (item == null || item.ContainerContractorPermission == null || item.ContainerContractorPermission.TemplateContractorPermission == null)
			{
				continue;
			}
			foreach (ITemplateContractorPermission item2 in ((IEnumerable<ITemplateContractorPermission>)item.ContainerContractorPermission.TemplateContractorPermission).Where((ITemplateContractorPermission a) => !a.AddPermission && !a.DelPermission))
			{
				EleWise.ELMA.Security.Models.IUser user = item2.User;
				if (item2.PermissionRole == CommonRoleTypes.Author.UID)
				{
					user = contractor.CreationAuthor;
				}
				if (item2.PermissionRole == CommonRoleTypes.Responsible.UID)
				{
					user = contractor.Responsible;
				}
				list.Add(AddPermission(item2, user, contractor));
				if (item2.PermissionRole == CommonRoleTypes.ParticipantWork.UID)
				{
					foreach (EleWise.ELMA.Security.Models.IUser item3 in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)contractor.ParticipantWork)
					{
						list.Add(AddPermission(item2, item3, contractor));
					}
				}
				if (!(item2.PermissionRole == CommonRoleTypes.Informs.UID))
				{
					continue;
				}
				foreach (EleWise.ELMA.Security.Models.IUser item4 in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)contractor.Informs)
				{
					list.Add(AddPermission(item2, item4, contractor));
				}
			}
		}
		(from s in list
			group s by new { s.User, s.PermissionId, s.Group, s.OrganizationItemPosition, s.PermissionRole, s.OrganizationItemEmployee, s.TypeRoleId }).ForEach(g =>
		{
			InstanceOf<IContractorPersonPermission> instanceOf = new InstanceOf<IContractorPersonPermission>();
			instanceOf.New.Contractor = contractor;
			instanceOf.New.User = g.Key.User;
			instanceOf.New.Group = g.Key.Group;
			instanceOf.New.OrganizationItemEmployee = g.Key.OrganizationItemEmployee;
			instanceOf.New.OrganizationItemPosition = g.Key.OrganizationItemPosition;
			instanceOf.New.PermissionId = g.Key.PermissionId;
			instanceOf.New.TypeRoleId = g.Key.TypeRoleId;
			instanceOf.New.PermissionRole = g.Key.PermissionRole;
			instanceOf.New.InheritedFromNumber = g.Count();
			instanceOf.New.Save();
		});
	}

	[Transaction]
	public virtual void EnableInheritPermissions(IContractor contractor, bool enable)
	{
		if (enable)
		{
			contractor.InheritPermissions = true;
			AddPermissionsFromParent(contractor);
		}
		else
		{
			contractor.InheritPermissions = false;
			((IEnumerable<IContractorPersonPermission>)contractor.Permission).ForEach(delegate(IContractorPersonPermission p)
			{
				p.InheritedFromNumber = null;
			});
		}
		Save(contractor);
	}

	private IContractorPersonPermission AddPermission(ITemplateContractorPermission perm, EleWise.ELMA.Security.Models.IUser user, IContractor contractor)
	{
		IContractorPersonPermission contractorPersonPermission = InterfaceActivator.Create<IContractorPersonPermission>();
		contractorPersonPermission.Contractor = contractor;
		contractorPersonPermission.User = user;
		contractorPersonPermission.Group = perm.Group;
		contractorPersonPermission.OrganizationItemEmployee = perm.OrganizationItemEmployee;
		contractorPersonPermission.OrganizationItemPosition = perm.OrganizationItemPosition;
		contractorPersonPermission.PermissionId = perm.PermissionId;
		contractorPersonPermission.TypeRoleId = perm.TypeRoleId;
		contractorPersonPermission.PermissionRole = perm.PermissionRole;
		contractorPersonPermission.InheritedFromNumber = 1L;
		return contractorPersonPermission;
	}

	[PublicApiMember]
	public void DeletePermission(IContractor contractor, EleWise.ELMA.Security.Models.IUser user)
	{
		DeletePermission(contractor, user, CRMPermissionProvider.ViewContractorPermission);
	}

	[PublicApiMember]
	public void DeletePermission(IContractor contractor, IUserGroup userGroup)
	{
		DeletePermission(contractor, userGroup, CRMPermissionProvider.ViewContractorPermission);
	}

	[PublicApiMember]
	public void DeleteAuthorPermission(IContractor contractor, Permission permission)
	{
		if (contractor == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		DelAuthorPermission(permission, contractor);
		if (permission == CRMPermissionProvider.ViewContractorPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMContractorCreateElementPermission, contractor);
			DelAuthorPermission(CRMPermissionProvider.EditContractorPermission, contractor);
			DelAuthorPermission(CRMPermissionProvider.CRMContractorIssuanceElementPermission, contractor);
			DelAuthorPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor);
		}
		if (permission == CRMPermissionProvider.EditContractorPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor);
		}
		if (permission == CRMPermissionProvider.CRMContractorCreateElementPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.EditContractorPermission, contractor);
			DelAuthorPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor);
		}
		if (permission == CRMPermissionProvider.CRMContractorIssuanceElementPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor);
		}
		contractor.Save();
	}

	[PublicApiMember]
	public void AddAuthorPermission(IContractor contractor, Permission permission)
	{
		if (contractor == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (permission == CRMPermissionProvider.CRMContractorFullAccessPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.CRMContractorCreateElementPermission, contractor);
			AddAuthorOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor);
			AddAuthorOnePermission(CRMPermissionProvider.EditContractorPermission, contractor);
			AddAuthorOnePermission(CRMPermissionProvider.CRMContractorIssuanceElementPermission, contractor);
		}
		if (permission == CRMPermissionProvider.EditContractorPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.CRMContractorCreateElementPermission, contractor);
			AddAuthorOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor);
		}
		if (permission == CRMPermissionProvider.CRMContractorIssuanceElementPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor);
		}
		if (permission == CRMPermissionProvider.CRMContractorCreateElementPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor);
		}
		contractor.Save();
	}

	[PublicApiMember]
	public void DeletePermission(IContractor contractor, IOrganizationItem orgItem)
	{
		DeletePermission(contractor, orgItem, CRMPermissionProvider.ViewContractorPermission);
	}

	[PublicApiMember]
	public void EnableInheritPermissions(IContractor contractor)
	{
		if (contractor == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		EnableInheritPermissions(contractor, enable: true);
	}

	[PublicApiMember]
	public void DisableInheritPermissions(IContractor contractor)
	{
		if (contractor == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		EnableInheritPermissions(contractor, enable: false);
	}

	[PublicApiMember]
	public void AddPermission(IContractor contractor, EleWise.ELMA.Security.Models.IUser user, Permission permission)
	{
		if (contractor == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (user == null)
		{
			throw new ArgumentNullException(SR.T("Пользователь не может быть null"));
		}
		if (AddOnePermission(permission, contractor, user))
		{
			if (permission == CRMPermissionProvider.CRMContractorFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMContractorCreateElementPermission, contractor, user);
				AddOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor, user);
				AddOnePermission(CRMPermissionProvider.EditContractorPermission, contractor, user);
				AddOnePermission(CRMPermissionProvider.CRMContractorIssuanceElementPermission, contractor, user);
			}
			if (permission == CRMPermissionProvider.EditContractorPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMContractorCreateElementPermission, contractor, user);
				AddOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor, user);
			}
			if (permission == CRMPermissionProvider.CRMContractorIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor, user);
			}
			if (permission == CRMPermissionProvider.CRMContractorCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor, user);
			}
		}
		contractor.Save();
	}

	[PublicApiMember]
	public void AddPermission(IContractor contractor, IUserGroup userGroup, Permission permission)
	{
		if (contractor == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (userGroup == null)
		{
			throw new ArgumentNullException(SR.T("Группа пользователей не может быть null"));
		}
		if (AddOnePermission(permission, contractor, userGroup))
		{
			if (permission == CRMPermissionProvider.CRMContractorFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMContractorCreateElementPermission, contractor, userGroup);
				AddOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor, userGroup);
				AddOnePermission(CRMPermissionProvider.EditContractorPermission, contractor, userGroup);
				AddOnePermission(CRMPermissionProvider.CRMContractorIssuanceElementPermission, contractor, userGroup);
			}
			if (permission == CRMPermissionProvider.EditContractorPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMContractorCreateElementPermission, contractor, userGroup);
				AddOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor, userGroup);
			}
			if (permission == CRMPermissionProvider.CRMContractorIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor, userGroup);
			}
			if (permission == CRMPermissionProvider.CRMContractorCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor, userGroup);
			}
		}
		contractor.Save();
	}

	[PublicApiMember]
	public void AddPermission(IContractor contractor, IOrganizationItem orgItem, Permission permission)
	{
		if (contractor == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (orgItem == null)
		{
			throw new ArgumentNullException(SR.T("Должность не может быть null"));
		}
		if (AddOnePermission(permission, contractor, orgItem))
		{
			if (permission == CRMPermissionProvider.CRMContractorFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMContractorCreateElementPermission, contractor, orgItem);
				AddOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor, orgItem);
				AddOnePermission(CRMPermissionProvider.EditContractorPermission, contractor, orgItem);
				AddOnePermission(CRMPermissionProvider.CRMContractorIssuanceElementPermission, contractor, orgItem);
			}
			if (permission == CRMPermissionProvider.EditContractorPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMContractorCreateElementPermission, contractor, orgItem);
				AddOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor, orgItem);
			}
			if (permission == CRMPermissionProvider.CRMContractorIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor, orgItem);
			}
			if (permission == CRMPermissionProvider.CRMContractorCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewContractorPermission, contractor, orgItem);
			}
		}
		contractor.Save();
	}

	private bool AddOnePermission(Permission permission, IContractor contractor, EleWise.ELMA.Security.Models.IUser user)
	{
		if (!((IEnumerable<IContractorPersonPermission>)contractor.Permission).Any((IContractorPersonPermission r) => r.Assigned == user && r.PermissionId == permission.Id && !r.InheritedFromNumber.HasValue))
		{
			IContractorPersonPermission contractorPersonPermission = EntityManager<IContractorPersonPermission>.Instance.Create();
			contractorPersonPermission.Contractor = contractor;
			contractorPersonPermission.PermissionId = permission.Id;
			contractorPersonPermission.User = user;
			contractorPersonPermission.PermissionRole = CommonRoleTypes.User.Id;
			contractor.Permission.Add(contractorPersonPermission);
			return true;
		}
		return false;
	}

	private bool AddOnePermission(Permission permission, IContractor contractor, IUserGroup userGroup)
	{
		if (!((IEnumerable<IContractorPersonPermission>)contractor.Permission).Any((IContractorPersonPermission r) => r.Assigned == userGroup && r.PermissionId == permission.Id))
		{
			IContractorPersonPermission contractorPersonPermission = EntityManager<IContractorPersonPermission>.Instance.Create();
			contractorPersonPermission.Contractor = contractor;
			contractorPersonPermission.PermissionId = permission.Id;
			contractorPersonPermission.Group = userGroup;
			contractorPersonPermission.PermissionRole = CommonRoleTypes.Group.Id;
			contractor.Permission.Add(contractorPersonPermission);
		}
		return true;
	}

	private bool AddOnePermission(Permission permission, IContractor contractor, IOrganizationItem orgItem)
	{
		if (!((IEnumerable<IContractorPersonPermission>)contractor.Permission).Any((IContractorPersonPermission r) => r.Assigned == orgItem && r.PermissionId == permission.Id))
		{
			IContractorPersonPermission contractorPersonPermission = EntityManager<IContractorPersonPermission>.Instance.Create();
			contractorPersonPermission.Contractor = contractor;
			contractorPersonPermission.PermissionId = permission.Id;
			contractorPersonPermission.OrganizationItemPosition = orgItem;
			contractorPersonPermission.PermissionRole = CommonRoleTypes.Group.Id;
			contractor.Permission.Add(contractorPersonPermission);
		}
		return true;
	}

	private void AddAuthorOnePermission(Permission permission, IContractor contractor)
	{
		if (!((IEnumerable<IContractorPersonPermission>)contractor.Permission).Any(delegate(IContractorPersonPermission r)
		{
			if (r.Assigned == contractor.CreationAuthor && r.PermissionId == permission.Id)
			{
				Guid? permissionRole = r.PermissionRole;
				Guid id = CommonRoleTypes.Author.Id;
				if (!permissionRole.HasValue)
				{
					return false;
				}
				if (!permissionRole.HasValue)
				{
					return true;
				}
				return permissionRole.GetValueOrDefault() == id;
			}
			return false;
		}))
		{
			IContractorPersonPermission contractorPersonPermission = EntityManager<IContractorPersonPermission>.Instance.Create();
			contractorPersonPermission.Contractor = contractor;
			contractorPersonPermission.PermissionId = permission.Id;
			contractorPersonPermission.User = contractor.CreationAuthor;
			contractorPersonPermission.PermissionRole = CommonRoleTypes.Author.Id;
			contractor.Permission.Add(contractorPersonPermission);
		}
	}

	[PublicApiMember]
	public void DeletePermission(IContractor contractor, EleWise.ELMA.Security.Models.IUser user, Permission permission)
	{
		if (contractor == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (user == null)
		{
			throw new ArgumentNullException(SR.T("Пользователь не может быть null"));
		}
		bool hasPermission = false;
		base.SecurityService.RunWithUsualPrivilegies(delegate
		{
			hasPermission = base.SecurityService.HasPermission(user, permission, contractor);
		});
		if (hasPermission)
		{
			DelPermission(permission, contractor, user);
			if (permission == CRMPermissionProvider.ViewContractorPermission)
			{
				DelPermission(CRMPermissionProvider.CRMContractorCreateElementPermission, contractor, user);
				DelPermission(CRMPermissionProvider.EditContractorPermission, contractor, user);
				DelPermission(CRMPermissionProvider.CRMContractorIssuanceElementPermission, contractor, user);
				DelPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor, user);
			}
			if (permission == CRMPermissionProvider.EditContractorPermission)
			{
				DelPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor, user);
			}
			if (permission == CRMPermissionProvider.CRMContractorCreateElementPermission)
			{
				DelPermission(CRMPermissionProvider.EditContractorPermission, contractor, user);
				DelPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor, user);
			}
			if (permission == CRMPermissionProvider.CRMContractorIssuanceElementPermission)
			{
				DelPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor, user);
			}
			contractor.Save();
		}
	}

	[PublicApiMember]
	public void DeletePermission(IContractor contractor, IUserGroup userGroup, Permission permission)
	{
		if (contractor == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (userGroup == null)
		{
			throw new ArgumentNullException(SR.T("Группа пользователей не может быть null"));
		}
		DelPermission(permission, contractor, userGroup);
		if (permission == CRMPermissionProvider.ViewContractorPermission)
		{
			DelPermission(CRMPermissionProvider.CRMContractorCreateElementPermission, contractor, userGroup);
			DelPermission(CRMPermissionProvider.EditContractorPermission, contractor, userGroup);
			DelPermission(CRMPermissionProvider.CRMContractorIssuanceElementPermission, contractor, userGroup);
			DelPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor, userGroup);
		}
		if (permission == CRMPermissionProvider.EditContractorPermission)
		{
			DelPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor, userGroup);
		}
		if (permission == CRMPermissionProvider.CRMContractorCreateElementPermission)
		{
			DelPermission(CRMPermissionProvider.EditContractorPermission, contractor, userGroup);
			DelPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor, userGroup);
		}
		if (permission == CRMPermissionProvider.CRMContractorIssuanceElementPermission)
		{
			DelPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor, userGroup);
		}
		contractor.Save();
	}

	[PublicApiMember]
	public void DeletePermission(IContractor contractor, IOrganizationItem orgItem, Permission permission)
	{
		if (contractor == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (orgItem == null)
		{
			throw new ArgumentNullException(SR.T("Должность не может быть null"));
		}
		DelPermission(permission, contractor, orgItem);
		if (permission == CRMPermissionProvider.ViewContractorPermission)
		{
			DelPermission(CRMPermissionProvider.CRMContractorCreateElementPermission, contractor, orgItem);
			DelPermission(CRMPermissionProvider.EditContractorPermission, contractor, orgItem);
			DelPermission(CRMPermissionProvider.CRMContractorIssuanceElementPermission, contractor, orgItem);
			DelPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor, orgItem);
		}
		if (permission == CRMPermissionProvider.EditContractorPermission)
		{
			DelPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor, orgItem);
		}
		if (permission == CRMPermissionProvider.CRMContractorCreateElementPermission)
		{
			DelPermission(CRMPermissionProvider.EditContractorPermission, contractor, orgItem);
			DelPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor, orgItem);
		}
		if (permission == CRMPermissionProvider.CRMContractorIssuanceElementPermission)
		{
			DelPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, contractor, orgItem);
		}
		contractor.Save();
	}

	private void DelPermission(Permission permissions, IContractor contractor, IUserGroup userGroup)
	{
		((ICollection<IContractorPersonPermission>)contractor.Permission).Remove(((IEnumerable<IContractorPersonPermission>)contractor.Permission).FirstOrDefault((IContractorPersonPermission r) => r.Assigned == userGroup && r.PermissionId == permissions.Id));
	}

	private void DelAuthorPermission(Permission permissions, IContractor contractor)
	{
		((ICollection<IContractorPersonPermission>)contractor.Permission).Remove(((IEnumerable<IContractorPersonPermission>)contractor.Permission).FirstOrDefault((IContractorPersonPermission r) => r.PermissionRole == CommonRoleTypes.Author.Id && r.PermissionId == permissions.Id));
	}

	private void DelPermission(Permission permissions, IContractor contractor, EleWise.ELMA.Security.Models.IUser user)
	{
		bool hasPermission = false;
		base.SecurityService.RunWithUsualPrivilegies(delegate
		{
			hasPermission = base.SecurityService.HasPermission(user, permissions, contractor);
		});
		if (hasPermission)
		{
			((ICollection<IContractorPersonPermission>)contractor.Permission).Remove(((IEnumerable<IContractorPersonPermission>)contractor.Permission).FirstOrDefault((IContractorPersonPermission r) => r.Assigned == user && r.PermissionId == permissions.Id));
		}
	}

	private void DelPermission(Permission permissions, IContractor contractor, IOrganizationItem orgItem)
	{
		((ICollection<IContractorPersonPermission>)contractor.Permission).Remove(((IEnumerable<IContractorPersonPermission>)contractor.Permission).FirstOrDefault((IContractorPersonPermission r) => r.Assigned == orgItem && r.PermissionId == permissions.Id));
		((ICollection<IContractorPersonPermission>)contractor.Permission).Remove(((IEnumerable<IContractorPersonPermission>)contractor.Permission).FirstOrDefault((IContractorPersonPermission r) => r.PermissionRole == CommonRoleTypes.ParticipantWork.Id && r.PermissionId == permissions.Id));
	}

	[Transaction]
	[PublicApiMember]
	public virtual void AddComment(IContractor contractor, string comment)
	{
		if (contractor == null)
		{
			throw new NullReferenceException(SR.T("Контрагент не может быть null"));
		}
		IComment comment2 = InterfaceActivator.Create<IComment>();
		comment2.Text = comment;
		comment2.CreationDate = DateTime.Now;
		comment2.CreationAuthor = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		comment2.Save();
		ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		commentActionModel.Comment = comment2;
		ICommentActionHandler serviceNotNull = Locator.GetServiceNotNull<ICommentActionHandler>();
		serviceNotNull.Process(contractor, commentActionModel);
		contractor.Comments.Add(comment2);
		contractor.Save();
		IEntityActionHandler serviceNotNull2 = Locator.GetServiceNotNull<IEntityActionHandler>();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, contractor, ContractorActions.AddCommentGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ProcessEventArgs(entityActionEventArgs, commentActionModel);
			serviceNotNull2.ActionExecuted(entityActionEventArgs);
		}
	}

	[ActionMethod("c34e8c84-3977-42fe-8d1a-a6482ceb865c")]
	public virtual void HistoryActionToSlaveObject(IContractor contractor, Guid action = default(Guid), IContact contact = null, IRelationship relationship = null, ISale sale = null, ILead lead = null)
	{
		ContractorSlaveActionEventArgs contractorSlaveActionEventArgs = ContractorSlaveActionEventArgs.TryCreate(contractor, contractor, action);
		contractorSlaveActionEventArgs.ActionUid = action;
		if (contact != null)
		{
			IMetadata metadata = MetadataLoader.LoadMetadata(contact.GetType());
			contractorSlaveActionEventArgs.SlaveObject = new ReferenceOnEntity(contact.Id, metadata.Uid);
		}
		if (relationship != null)
		{
			IMetadata metadata2 = MetadataLoader.LoadMetadata(relationship.GetType());
			contractorSlaveActionEventArgs.SlaveObject = new ReferenceOnEntity(relationship.Id, metadata2.Uid);
		}
		if (sale != null)
		{
			IMetadata metadata3 = MetadataLoader.LoadMetadata(sale.GetType());
			contractorSlaveActionEventArgs.SlaveObject = new ReferenceOnEntity(sale.Id, metadata3.Uid);
		}
		contractorSlaveActionEventArgs.ExtendedProperties["SlaveObject"] = contractorSlaveActionEventArgs.SlaveObject.Object;
		base.ActionHandler.ActionExecuted(contractorSlaveActionEventArgs);
	}

	[PublicApiMember]
	public virtual void AddComment(IContractor contractor, string comment, EleWise.ELMA.Security.Models.IUser commentAuthor)
	{
		if (commentAuthor == null)
		{
			throw new NullReferenceException(SR.T("Автор комментария не может быть null"));
		}
		if (commentAuthor != AuthenticationService.GetCurrentUser())
		{
			base.SecurityService.RunByUser(commentAuthor, delegate
			{
				AddComment(contractor, comment);
			});
		}
		else
		{
			AddComment(contractor, comment);
		}
	}

	[PublicApiMember]
	public IContact CreateContact(IContractor contractor)
	{
		if (contractor == null)
		{
			throw new NullReferenceException(SR.T("Контрагент не может быть null"));
		}
		IContact contact = InterfaceActivator.Create<IContact>();
		contact.Contractor = contractor;
		return contact;
	}

	[PublicApiMember]
	public ISale CreateSale(IContractor contractor)
	{
		ISale sale = InterfaceActivator.Create<ISale>();
		sale.Contractor = contractor;
		return sale;
	}

	[Transaction]
	public virtual void SendChangeAccess(IContractor сontractorObject, List<IContractorPersonPermission> oldPermissions, List<IContractorPersonPermission> newPermissions)
	{
		Locator.GetServiceNotNull<IEntityActionHandler>();
		if (!ComparePermissions(newPermissions, oldPermissions))
		{
			ContractorChangeAccessActionEventArgs contractorChangeAccessActionEventArgs = new ContractorChangeAccessActionEventArgs(null, сontractorObject, ContractorActions.ChangeAccessGuid);
			contractorChangeAccessActionEventArgs.FillInfo(oldPermissions, newPermissions);
			base.ActionHandler.ActionExecuted(contractorChangeAccessActionEventArgs);
		}
	}

	private bool ComparePermissions(List<IContractorPersonPermission> left, List<IContractorPersonPermission> right)
	{
		if (left.Where((IContractorPersonPermission e) => !right.Any((IContractorPersonPermission re) => re.Contractor == e.Contractor && re.Group == e.Group && re.OrganizationItemEmployee == e.OrganizationItemEmployee && re.OrganizationItemPosition == e.OrganizationItemPosition && re.PermissionId == e.PermissionId && re.PermissionRole == e.PermissionRole && re.User == e.User)).ToList().Count > 0)
		{
			return false;
		}
		if (right.Where((IContractorPersonPermission e) => !left.Any((IContractorPersonPermission re) => re.Contractor == e.Contractor && re.Group == e.Group && re.OrganizationItemEmployee == e.OrganizationItemEmployee && re.OrganizationItemPosition == e.OrganizationItemPosition && re.PermissionId == e.PermissionId && re.PermissionRole == e.PermissionRole && re.User == e.User)).ToList().Count > 0)
		{
			return false;
		}
		return true;
	}
}
