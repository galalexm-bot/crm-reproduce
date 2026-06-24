using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class ContactManager : BaseCrmManager<IContact>
{
	public IEntityManager<IContactPersonPermission> ContactPersonPermissionManager { get; set; }

	public new static ContactManager Instance => Locator.GetServiceNotNull<ContactManager>();

	protected override string DefaultCriteriaAlias => "contactMn";

	public bool IsSaved(IContact contact)
	{
		if (contact == null)
		{
			return false;
		}
		return base.Session.Get(base.ImplementationType, (object)contact.Id) != null;
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		IContactFilter contactFilter = filter as IContactFilter;
		IAddressFilter addressFilter = null;
		if (contactFilter != null)
		{
			addressFilter = contactFilter.RegistrationAddress;
			contactFilter.RegistrationAddress = null;
		}
		base.SetupFilter(criteria, filter);
		if (contactFilter == null)
		{
			return;
		}
		contactFilter.RegistrationAddress = addressFilter;
		if (addressFilter != null && !addressFilter.IsEmpty())
		{
			string text = null;
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(base.ImplementationType);
			DisjunctionCriteria disjunctionCriteria = new DisjunctionCriteria(criteria);
			PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name == "RegistrationAddress");
			ITypeDescriptor typeDescriptor = base.MetadataRuntimeService.GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid);
			IFilterableType filterableType = (IFilterableType)base.MetadataRuntimeService.GetTypeDescriptor(typeDescriptor.GetFilterType(propertyMetadata, entityMetadata), propertyMetadata.SubTypeUid);
			foreach (EntityPropertyMetadata item in entityMetadata.Properties.Where((PropertyMetadata p) => p.SubTypeUid == InterfaceActivator.UID<IAddress>(loadImplementation: false)))
			{
				disjunctionCriteria.NewDisjunctionCriteria();
				filterableType.ApplyFilterValue((ICriteria)(object)disjunctionCriteria, entityMetadata, item, addressFilter, string.IsNullOrEmpty(text) ? DefaultCriteriaAlias : text);
			}
		}
		if (contactFilter.ShowOnlyMy)
		{
			criteria.CreateAlias("Contractor", "cc");
			criteria.Add((ICriterion)(object)Restrictions.Eq("cc.Responsible", (object)base.AuthenticationService.GetCurrentUser()));
		}
		if (!string.IsNullOrEmpty(contactFilter.Phones))
		{
			string alias = "PhoneAlias";
			DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<IContact>()).Add((ICriterion)(object)ElmaRestrictions.Like("PhoneAlias.PhoneString", contactFilter.Phones, MatchMode.Exact)).SetProjection((IProjection)(object)Projections.Property("Id"));
			criteria.GetOrCreateAlias("Phone", "Phone", (JoinType)0, ref alias).Add((ICriterion)(object)Subqueries.PropertyIn("Id", val));
		}
		if (!string.IsNullOrEmpty(contactFilter.Email))
		{
			string alias2 = "EmailAlias";
			DetachedCriteria val2 = DetachedCriteria.For(InterfaceActivator.TypeOf<IContact>()).Add((ICriterion)(object)ElmaRestrictions.InsensitiveLike("EmailAlias.EmailString", contactFilter.Email, MatchMode.Anywhere)).SetProjection((IProjection)(object)Projections.Property("Id"));
			criteria.GetOrCreateAlias("Email", "Email", (JoinType)0, ref alias2).Add((ICriterion)(object)Subqueries.PropertyIn("Id", val2));
		}
	}

	[Transaction]
	public virtual void EnableInheritPermissions(IContact contact, bool enable)
	{
		if (enable)
		{
			contact.InheritPermissions = true;
			AddPermissionsFromParent(contact);
		}
		else
		{
			contact.InheritPermissions = false;
			CopyPermissionsFromInherited(contact);
		}
		Save(contact);
	}

	public virtual void CopyPermissionsFromInherited(IContact contact)
	{
		((IEnumerable<IContactPersonPermission>)contact.Permission).ForEach(delegate(IContactPersonPermission p)
		{
			p.InheritedFromNumber = null;
			p.PermissionRole = ((p.PermissionRole == CommonRoleTypes.Informs.UID || p.PermissionRole == CommonRoleTypes.ParticipantWork.UID || p.PermissionRole == CommonRoleTypes.Responsible.UID) ? new Guid?(CommonRoleTypes.User.UID) : p.PermissionRole);
		});
	}

	public virtual void AddPermissionsFromParent(IContact contact)
	{
		if (contact.Contractor == null)
		{
			return;
		}
		foreach (IContractorPersonPermission item in (IEnumerable<IContractorPersonPermission>)contact.Contractor.Permission)
		{
			if (item != null)
			{
				Guid empty = Guid.Empty;
				empty = ((item.PermissionId == CRMPermissionProvider.CRMContractorCreateElementPermission.Id) ? CRMPermissionProvider.CRMContactCreateElementPermission.Id : ((item.PermissionId == CRMPermissionProvider.ViewContractorPermission.Id) ? CRMPermissionProvider.ViewContactPermission.Id : ((item.PermissionId == CRMPermissionProvider.EditContractorPermission.Id) ? CRMPermissionProvider.EditContactPermission.Id : ((item.PermissionId == CRMPermissionProvider.CRMContractorIssuanceElementPermission.Id) ? CRMPermissionProvider.CRMContactIssuanceElementPermission.Id : ((!(item.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id)) ? item.PermissionId : CRMPermissionProvider.CRMContactFullAccessPermission.Id)))));
				EleWise.ELMA.Security.Models.IUser user = item.User;
				if (item.PermissionRole.HasValue && item.PermissionRole == CommonRoleTypes.Author.Id)
				{
					user = contact.CreationAuthor;
				}
				if (empty != Guid.Empty)
				{
					InstanceOf<IContactPersonPermission> instanceOf = new InstanceOf<IContactPersonPermission>();
					instanceOf.New.Contact = contact;
					instanceOf.New.User = user;
					instanceOf.New.Group = item.Group;
					instanceOf.New.OrganizationItemEmployee = item.OrganizationItemEmployee;
					instanceOf.New.OrganizationItemPosition = item.OrganizationItemPosition;
					instanceOf.New.PermissionId = empty;
					instanceOf.New.TypeRoleId = item.TypeRoleId;
					instanceOf.New.PermissionRole = item.PermissionRole;
					instanceOf.New.InheritedFromNumber = 1L;
					instanceOf.New.Save();
				}
			}
		}
	}

	[Transaction]
	[PublicApiMember]
	public virtual void AddComment(IContact contact, string comment)
	{
		if (contact == null)
		{
			throw new NullReferenceException(SR.T("Контакт не может быть null"));
		}
		IComment comment2 = InterfaceActivator.Create<IComment>();
		comment2.Text = comment;
		comment2.CreationDate = DateTime.Now;
		comment2.CreationAuthor = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		comment2.Save();
		ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		commentActionModel.Comment = comment2;
		ICommentActionHandler serviceNotNull = Locator.GetServiceNotNull<ICommentActionHandler>();
		serviceNotNull.Process(contact, commentActionModel);
		contact.Comments.Add(comment2);
		contact.Save();
		IEntityActionHandler serviceNotNull2 = Locator.GetServiceNotNull<IEntityActionHandler>();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, contact, ContactActions.AddCommentGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ProcessEventArgs(entityActionEventArgs, commentActionModel);
			serviceNotNull2.ActionExecuted(entityActionEventArgs);
		}
	}

	[PublicApiMember]
	public virtual void AddComment(IContact contact, string comment, EleWise.ELMA.Security.Models.IUser commentAuthor)
	{
		if (commentAuthor == null)
		{
			throw new NullReferenceException(SR.T("Автор комментария не может быть null"));
		}
		if (commentAuthor != base.AuthenticationService.GetCurrentUser())
		{
			base.SecurityService.RunByUser(commentAuthor, delegate
			{
				AddComment(contact, comment);
			});
		}
		else
		{
			AddComment(contact, comment);
		}
	}

	[PublicApiMember]
	public virtual IContact Create(IContractor contractor)
	{
		IContact contact = InterfaceActivator.Create<IContact>();
		contact.Contractor = contractor;
		return contact;
	}

	[PublicApiMember]
	public void DeletePermission(IContact contact, EleWise.ELMA.Security.Models.IUser user)
	{
		DeletePermission(contact, user, CRMPermissionProvider.ViewContactPermission);
	}

	[PublicApiMember]
	public void DeletePermission(IContact contact, IUserGroup userGroup)
	{
		DeletePermission(contact, userGroup, CRMPermissionProvider.ViewContactPermission);
	}

	[PublicApiMember]
	public void DeleteAuthorPermission(IContact contact, Permission permission)
	{
		if (contact == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		DelAuthorPermission(permission, contact);
		if (permission == CRMPermissionProvider.ViewContactPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMContactCreateElementPermission, contact);
			DelAuthorPermission(CRMPermissionProvider.EditContactPermission, contact);
			DelAuthorPermission(CRMPermissionProvider.CRMContactIssuanceElementPermission, contact);
			DelAuthorPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact);
		}
		if (permission == CRMPermissionProvider.EditContactPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact);
		}
		if (permission == CRMPermissionProvider.CRMContactCreateElementPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.EditContactPermission, contact);
			DelAuthorPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact);
		}
		if (permission == CRMPermissionProvider.CRMContactIssuanceElementPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact);
		}
		contact.Save();
	}

	[PublicApiMember]
	public void AddAuthorPermission(IContact contact, Permission permission)
	{
		if (contact == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (permission == CRMPermissionProvider.CRMContactFullAccessPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.CRMContactCreateElementPermission, contact);
			AddAuthorOnePermission(CRMPermissionProvider.ViewContactPermission, contact);
			AddAuthorOnePermission(CRMPermissionProvider.EditContactPermission, contact);
			AddAuthorOnePermission(CRMPermissionProvider.CRMContactIssuanceElementPermission, contact);
		}
		if (permission == CRMPermissionProvider.EditContactPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.CRMContactCreateElementPermission, contact);
			AddAuthorOnePermission(CRMPermissionProvider.ViewContactPermission, contact);
		}
		if (permission == CRMPermissionProvider.CRMContactIssuanceElementPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.ViewContactPermission, contact);
		}
		if (permission == CRMPermissionProvider.CRMContactCreateElementPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.ViewContactPermission, contact);
		}
		contact.Save();
	}

	[PublicApiMember]
	public void DeletePermission(IContact contact, IOrganizationItem orgItem)
	{
		DeletePermission(contact, orgItem, CRMPermissionProvider.ViewContactPermission);
	}

	[PublicApiMember]
	public void EnableInheritPermissions(IContact contact)
	{
		if (contact == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		EnableInheritPermissions(contact, enable: true);
	}

	[PublicApiMember]
	public void DisableInheritPermissions(IContact contact)
	{
		if (contact == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		EnableInheritPermissions(contact, enable: false);
	}

	[PublicApiMember]
	public void AddPermission(IContact contact, EleWise.ELMA.Security.Models.IUser user, Permission permission)
	{
		if (contact == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (user == null)
		{
			throw new ArgumentNullException(SR.T("Пользователь не может быть null"));
		}
		if (AddOnePermission(permission, contact, user))
		{
			if (permission == CRMPermissionProvider.CRMContactFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMContactCreateElementPermission, contact, user);
				AddOnePermission(CRMPermissionProvider.ViewContactPermission, contact, user);
				AddOnePermission(CRMPermissionProvider.EditContactPermission, contact, user);
				AddOnePermission(CRMPermissionProvider.CRMContactIssuanceElementPermission, contact, user);
			}
			if (permission == CRMPermissionProvider.EditContactPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMContactCreateElementPermission, contact, user);
				AddOnePermission(CRMPermissionProvider.ViewContactPermission, contact, user);
			}
			if (permission == CRMPermissionProvider.CRMContactIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewContactPermission, contact, user);
			}
			if (permission == CRMPermissionProvider.CRMContactCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewContactPermission, contact, user);
			}
		}
		contact.Save();
	}

	[PublicApiMember]
	public void AddPermission(IContact contact, IUserGroup userGroup, Permission permission)
	{
		if (contact == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (userGroup == null)
		{
			throw new ArgumentNullException(SR.T("Группа пользователей не может быть null"));
		}
		if (AddOnePermission(permission, contact, userGroup))
		{
			if (permission == CRMPermissionProvider.CRMContactFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMContactCreateElementPermission, contact, userGroup);
				AddOnePermission(CRMPermissionProvider.ViewContactPermission, contact, userGroup);
				AddOnePermission(CRMPermissionProvider.EditContactPermission, contact, userGroup);
				AddOnePermission(CRMPermissionProvider.CRMContactIssuanceElementPermission, contact, userGroup);
			}
			if (permission == CRMPermissionProvider.EditContactPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMContactCreateElementPermission, contact, userGroup);
				AddOnePermission(CRMPermissionProvider.ViewContactPermission, contact, userGroup);
			}
			if (permission == CRMPermissionProvider.CRMContactIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewContactPermission, contact, userGroup);
			}
			if (permission == CRMPermissionProvider.CRMContactCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewContactPermission, contact, userGroup);
			}
		}
		contact.Save();
	}

	[PublicApiMember]
	public void AddPermission(IContact contact, IOrganizationItem orgItem, Permission permission)
	{
		if (contact == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (orgItem == null)
		{
			throw new ArgumentNullException(SR.T("Должность не может быть null"));
		}
		if (AddOnePermission(permission, contact, orgItem))
		{
			if (permission == CRMPermissionProvider.CRMContactFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMContactCreateElementPermission, contact, orgItem);
				AddOnePermission(CRMPermissionProvider.ViewContactPermission, contact, orgItem);
				AddOnePermission(CRMPermissionProvider.EditContactPermission, contact, orgItem);
				AddOnePermission(CRMPermissionProvider.CRMContactIssuanceElementPermission, contact, orgItem);
			}
			if (permission == CRMPermissionProvider.EditContactPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMContactCreateElementPermission, contact, orgItem);
				AddOnePermission(CRMPermissionProvider.ViewContactPermission, contact, orgItem);
			}
			if (permission == CRMPermissionProvider.CRMContactIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewContactPermission, contact, orgItem);
			}
			if (permission == CRMPermissionProvider.CRMContactCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewContactPermission, contact, orgItem);
			}
		}
		contact.Save();
	}

	private bool AddOnePermission(Permission permission, IContact contact, EleWise.ELMA.Security.Models.IUser user)
	{
		if (!((IEnumerable<IContactPersonPermission>)contact.Permission).Any((IContactPersonPermission r) => r.Assigned == user && r.PermissionId == permission.Id && !r.InheritedFromNumber.HasValue))
		{
			IContactPersonPermission contactPersonPermission = ContactPersonPermissionManager.Create();
			contactPersonPermission.Contact = contact;
			contactPersonPermission.PermissionId = permission.Id;
			contactPersonPermission.User = user;
			contactPersonPermission.PermissionRole = CommonRoleTypes.User.Id;
			contact.Permission.Add(contactPersonPermission);
			return true;
		}
		return false;
	}

	private bool AddOnePermission(Permission permission, IContact contact, IUserGroup userGroup)
	{
		if (!((IEnumerable<IContactPersonPermission>)contact.Permission).Any((IContactPersonPermission r) => r.Assigned == userGroup && r.PermissionId == permission.Id))
		{
			IContactPersonPermission contactPersonPermission = ContactPersonPermissionManager.Create();
			contactPersonPermission.Contact = contact;
			contactPersonPermission.PermissionId = permission.Id;
			contactPersonPermission.Group = userGroup;
			contactPersonPermission.PermissionRole = CommonRoleTypes.Group.Id;
			contact.Permission.Add(contactPersonPermission);
		}
		return true;
	}

	private bool AddOnePermission(Permission permission, IContact contact, IOrganizationItem orgItem)
	{
		if (!((IEnumerable<IContactPersonPermission>)contact.Permission).Any((IContactPersonPermission r) => r.Assigned == orgItem && r.PermissionId == permission.Id))
		{
			IContactPersonPermission contactPersonPermission = ContactPersonPermissionManager.Create();
			contactPersonPermission.Contact = contact;
			contactPersonPermission.PermissionId = permission.Id;
			contactPersonPermission.OrganizationItemPosition = orgItem;
			contactPersonPermission.PermissionRole = CommonRoleTypes.Group.Id;
			contact.Permission.Add(contactPersonPermission);
		}
		return true;
	}

	private void AddAuthorOnePermission(Permission permission, IContact contact)
	{
		if (!((IEnumerable<IContactPersonPermission>)contact.Permission).Any((IContactPersonPermission r) => r.Assigned == contact.CreationAuthor && r.PermissionId == permission.Id && r.PermissionRole == CommonRoleTypes.Author.Id && !r.InheritedFromNumber.HasValue))
		{
			IContactPersonPermission contactPersonPermission = ContactPersonPermissionManager.Create();
			contactPersonPermission.Contact = contact;
			contactPersonPermission.PermissionId = permission.Id;
			contactPersonPermission.User = contact.CreationAuthor;
			contactPersonPermission.PermissionRole = CommonRoleTypes.Author.Id;
			contact.Permission.Add(contactPersonPermission);
		}
	}

	[PublicApiMember]
	public void DeletePermission(IContact contact, EleWise.ELMA.Security.Models.IUser user, Permission permission)
	{
		if (contact == null)
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
			hasPermission = base.SecurityService.HasPermission(user, permission, contact);
		});
		if (hasPermission)
		{
			DelPermission(permission, contact, user);
			if (permission == CRMPermissionProvider.ViewContactPermission)
			{
				DelPermission(CRMPermissionProvider.CRMContactCreateElementPermission, contact, user);
				DelPermission(CRMPermissionProvider.EditContactPermission, contact, user);
				DelPermission(CRMPermissionProvider.CRMContactIssuanceElementPermission, contact, user);
				DelPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact, user);
			}
			if (permission == CRMPermissionProvider.EditContactPermission)
			{
				DelPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact, user);
			}
			if (permission == CRMPermissionProvider.CRMContactCreateElementPermission)
			{
				DelPermission(CRMPermissionProvider.EditContactPermission, contact, user);
				DelPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact, user);
			}
			if (permission == CRMPermissionProvider.CRMContactIssuanceElementPermission)
			{
				DelPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact, user);
			}
			contact.Save();
		}
	}

	[PublicApiMember]
	public void DeletePermission(IContact contact, IUserGroup userGroup, Permission permission)
	{
		if (contact == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (userGroup == null)
		{
			throw new ArgumentNullException(SR.T("Группа пользователей не может быть null"));
		}
		DelPermission(permission, contact, userGroup);
		if (permission == CRMPermissionProvider.ViewContactPermission)
		{
			DelPermission(CRMPermissionProvider.CRMContactCreateElementPermission, contact, userGroup);
			DelPermission(CRMPermissionProvider.EditContactPermission, contact, userGroup);
			DelPermission(CRMPermissionProvider.CRMContactIssuanceElementPermission, contact, userGroup);
			DelPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact, userGroup);
		}
		if (permission == CRMPermissionProvider.EditContactPermission)
		{
			DelPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact, userGroup);
		}
		if (permission == CRMPermissionProvider.CRMContactCreateElementPermission)
		{
			DelPermission(CRMPermissionProvider.EditContactPermission, contact, userGroup);
			DelPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact, userGroup);
		}
		if (permission == CRMPermissionProvider.CRMContactIssuanceElementPermission)
		{
			DelPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact, userGroup);
		}
		contact.Save();
	}

	[PublicApiMember]
	public void DeletePermission(IContact contact, IOrganizationItem orgItem, Permission permission)
	{
		if (contact == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (orgItem == null)
		{
			throw new ArgumentNullException(SR.T("Должность не может быть null"));
		}
		DelPermission(permission, contact, orgItem);
		if (permission == CRMPermissionProvider.ViewContactPermission)
		{
			DelPermission(CRMPermissionProvider.CRMContactCreateElementPermission, contact, orgItem);
			DelPermission(CRMPermissionProvider.EditContactPermission, contact, orgItem);
			DelPermission(CRMPermissionProvider.CRMContactIssuanceElementPermission, contact, orgItem);
			DelPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact, orgItem);
		}
		if (permission == CRMPermissionProvider.EditContactPermission)
		{
			DelPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact, orgItem);
		}
		if (permission == CRMPermissionProvider.CRMContactCreateElementPermission)
		{
			DelPermission(CRMPermissionProvider.EditContactPermission, contact, orgItem);
			DelPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact, orgItem);
		}
		if (permission == CRMPermissionProvider.CRMContactIssuanceElementPermission)
		{
			DelPermission(CRMPermissionProvider.CRMContactFullAccessPermission, contact, orgItem);
		}
		contact.Save();
	}

	private void DelPermission(Permission permissions, IContact contact, IUserGroup userGroup)
	{
		((ICollection<IContactPersonPermission>)contact.Permission).Remove(((IEnumerable<IContactPersonPermission>)contact.Permission).FirstOrDefault((IContactPersonPermission r) => r.Assigned == userGroup && r.PermissionId == permissions.Id));
	}

	private void DelAuthorPermission(Permission permissions, IContact contact)
	{
		((ICollection<IContactPersonPermission>)contact.Permission).Remove(((IEnumerable<IContactPersonPermission>)contact.Permission).FirstOrDefault((IContactPersonPermission r) => r.PermissionRole == CommonRoleTypes.Author.Id && r.PermissionId == permissions.Id));
	}

	private void DelPermission(Permission permissions, IContact contact, EleWise.ELMA.Security.Models.IUser user)
	{
		bool hasPermission = false;
		base.SecurityService.RunWithUsualPrivilegies(delegate
		{
			hasPermission = base.SecurityService.HasPermission(user, permissions, contact);
		});
		if (hasPermission)
		{
			((ICollection<IContactPersonPermission>)contact.Permission).Remove(((IEnumerable<IContactPersonPermission>)contact.Permission).FirstOrDefault((IContactPersonPermission r) => r.Assigned == user && r.PermissionId == permissions.Id));
		}
	}

	private void DelPermission(Permission permissions, IContact contact, IOrganizationItem orgItem)
	{
		((ICollection<IContactPersonPermission>)contact.Permission).Remove(((IEnumerable<IContactPersonPermission>)contact.Permission).FirstOrDefault((IContactPersonPermission r) => r.Assigned == orgItem && r.PermissionId == permissions.Id));
	}
}
