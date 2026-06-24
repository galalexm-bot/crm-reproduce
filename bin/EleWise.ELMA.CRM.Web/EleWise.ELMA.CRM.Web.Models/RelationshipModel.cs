using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Calendar;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Extensions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Models;

public abstract class RelationshipModel<T> : RelationshipModel where T : class, IRelationship
{
	public new T Entity
	{
		get
		{
			return (T)base.Entity;
		}
		set
		{
			base.Entity = value;
		}
	}

	public new IEnumerable<T> Entities => base.Entities.OfType<T>();

	public override Guid RelationshipTypeUid => InterfaceActivator.UID(typeof(T));

	public ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	public bool CanDelete
	{
		get
		{
			if (!SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, Entity) || !SecurityService.HasPermission(CRMPermissionProvider.CRMDeletePermission))
			{
				return SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
			}
			return true;
		}
	}

	public bool CanEdit
	{
		get
		{
			if (Entity.Sale != null)
			{
				if (!Entity.Sale.SaleClosed())
				{
					if (!SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, Entity) && !SecurityService.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, Entity))
					{
						return SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
					}
					return true;
				}
				return false;
			}
			if (!SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, Entity) && !SecurityService.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, Entity))
			{
				return SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
			}
			return true;
		}
	}

	public bool CreateElement
	{
		get
		{
			if (Entity.Sale != null)
			{
				if (!Entity.Sale.SaleClosed())
				{
					if (!SecurityService.HasPermission(CRMPermissionProvider.CRMSaleCreateElementPermission, Entity.Sale) && !SecurityService.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, Entity))
					{
						return SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
					}
					return true;
				}
				return false;
			}
			if (Entity.Contractor != null)
			{
				if (!SecurityService.HasPermission(CRMPermissionProvider.CRMContractorCreateElementPermission, Entity.Contractor) && !SecurityService.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, Entity))
				{
					return SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
				}
				return true;
			}
			if (Entity.Contact != null)
			{
				if (!SecurityService.HasPermission(CRMPermissionProvider.CRMContactCreateElementPermission, Entity.Contact) && !SecurityService.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, Entity))
				{
					return SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
				}
				return true;
			}
			if (Entity.Lead != null)
			{
				if (!SecurityService.HasPermission(CRMPermissionProvider.CRMLeadCreateElementPermission, Entity.Lead) && !SecurityService.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, Entity))
				{
					return SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
				}
				return true;
			}
			if (!SecurityService.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, Entity))
			{
				return SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
			}
			return true;
		}
	}

	public bool CanExecute => SecurityService.HasPermission(CRMPermissionProvider.ExecuteRelationshipPermission, Entity);

	public bool CanComment
	{
		get
		{
			if (!CanEdit)
			{
				return ((IEnumerable<IRelationshipUser>)Entity.RelationshipUsers).Any((IRelationshipUser r) => r.User == Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
			}
			return true;
		}
	}

	protected RelationshipModel(T relationship)
		: base(relationship)
	{
	}

	protected RelationshipModel()
	{
		Entity = InterfaceActivator.Create<T>();
		IRelationshipUser relationshipUser = InterfaceActivator.Create<IRelationshipUser>();
		relationshipUser.User = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		relationshipUser.Status = RelationshipUserStatus.Participant;
		Entity.RelationshipUsers.Add(relationshipUser);
	}

	protected RelationshipModel(ViewType viewType)
		: this()
	{
		base.ViewType = viewType;
	}

	protected RelationshipModel(T relationship, ViewType viewType)
		: this(relationship)
	{
		base.ViewType = viewType;
		if (relationship == null)
		{
			Entity = InterfaceActivator.Create<T>();
			IRelationshipUser relationshipUser = InterfaceActivator.Create<IRelationshipUser>();
			relationshipUser.User = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			relationshipUser.Status = RelationshipUserStatus.Participant;
			Entity.RelationshipUsers.Add(relationshipUser);
		}
	}

	public sealed override IRelationshipBaseModel CreateFromRelationship(IRelationship relationship)
	{
		return CreateModel(relationship, ViewType.Create, null);
	}

	public sealed override IRelationshipBaseModel CreateFromRelationship(IRelationship relationship, Guid customFormUid)
	{
		return CreateModel(relationship, ViewType.Custom, customFormUid);
	}

	protected IRelationshipBaseModel CreateModel(IRelationship relationship, ViewType viewType, Guid? customFormUid)
	{
		if (!(relationship.CastAsRealType() is T entity))
		{
			return null;
		}
		if (customFormUid.HasValue)
		{
			viewType = ViewType.Custom;
		}
		return CreateConcreteModel(entity, viewType, customFormUid);
	}

	protected abstract IRelationshipBaseModel CreateConcreteModel(T entity, ViewType viewType, Guid? customFormUid);
}
public abstract class RelationshipModel : DynamicEntityViewModel<IRelationship>, IRelationshipBaseModel2, IRelationshipBaseModel
{
	public new IRelationship Entity
	{
		get
		{
			return base.Entity;
		}
		set
		{
			base.Entity = value;
		}
	}

	[DisplayName(typeof(RelationshipModel_SR), "Inform")]
	public CustomSet<EleWise.ELMA.Security.Models.IUser, IRelationshipUser> InformUsers
	{
		get
		{
			Dictionary<string, object> properties = new Dictionary<string, object> { 
			{
				"Status",
				RelationshipUserStatus.InfromTo
			} };
			return new CustomSet<EleWise.ELMA.Security.Models.IUser, IRelationshipUser>(Entity.RelationshipUsers, (from s in (IEnumerable<IRelationshipUser>)Entity.RelationshipUsers
				where s.Status == RelationshipUserStatus.InfromTo
				select s into u
				select u.User).ToList(), properties);
		}
		set
		{
			if (value == null)
			{
				return;
			}
			((IEnumerable<IRelationshipUser>)Entity.RelationshipUsers).Where((IRelationshipUser s) => s.Status == RelationshipUserStatus.InfromTo).ToArray().Each(delegate(IRelationshipUser i)
			{
				((ICollection<IRelationshipUser>)Entity.RelationshipUsers).Remove(i);
			});
			foreach (EleWise.ELMA.Security.Models.IUser item in (Set<EleWise.ELMA.Security.Models.IUser>)(object)value)
			{
				IRelationshipUser relationshipUser = InterfaceActivator.Create<IRelationshipUser>();
				relationshipUser.User = item;
				relationshipUser.Status = RelationshipUserStatus.InfromTo;
				Entity.RelationshipUsers.Add(relationshipUser);
			}
		}
	}

	[DisplayName(typeof(RelationshipModel_SR), "Members")]
	[Required(true)]
	[RequiredField]
	public CustomSet<EleWise.ELMA.Security.Models.IUser, IRelationshipUser> PartyUsers
	{
		get
		{
			Dictionary<string, object> properties = new Dictionary<string, object> { 
			{
				"Status",
				RelationshipUserStatus.Participant
			} };
			return new CustomSet<EleWise.ELMA.Security.Models.IUser, IRelationshipUser>(Entity.RelationshipUsers, (from s in (IEnumerable<IRelationshipUser>)Entity.RelationshipUsers
				where s.Status == RelationshipUserStatus.Participant
				select s into u
				select u.User).ToList(), properties);
		}
		set
		{
			if (value == null)
			{
				return;
			}
			((IEnumerable<IRelationshipUser>)Entity.RelationshipUsers).Where((IRelationshipUser s) => s.Status == RelationshipUserStatus.Participant).ToArray().Each(delegate(IRelationshipUser i)
			{
				((ICollection<IRelationshipUser>)Entity.RelationshipUsers).Remove(i);
			});
			foreach (EleWise.ELMA.Security.Models.IUser item in (Set<EleWise.ELMA.Security.Models.IUser>)(object)value)
			{
				IRelationshipUser relationshipUser = InterfaceActivator.Create<IRelationshipUser>();
				relationshipUser.User = item;
				relationshipUser.Status = RelationshipUserStatus.Participant;
				Entity.RelationshipUsers.Add(relationshipUser);
			}
		}
	}

	public EleWise.ELMA.Security.Models.IUser CurrentUser => AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();

	public bool PrivateAccess
	{
		get
		{
			if (Entity.IsPrivate)
			{
				if (!((IEnumerable<IRelationshipUser>)Entity.RelationshipUsers).Any((IRelationshipUser s) => s.User != null && s.User.Id == CurrentUser.Id))
				{
					return Entity.CreationAuthor.Id != CurrentUser.Id;
				}
				return false;
			}
			return false;
		}
	}

	public bool IsPrivateActivate
	{
		get
		{
			CalendarSettings settings = Locator.GetServiceNotNull<CalendarSettingsModule>().Settings;
			if (settings != null && settings.EnablePrivateMode)
			{
				return true;
			}
			return false;
		}
	}

	[DisplayName(typeof(RelationshipModel_SR), "ActionState")]
	public string Completed
	{
		get
		{
			if (!Entity.Completed.HasValue)
			{
				return SR.T("Запланировано");
			}
			if (!Entity.Completed.Value)
			{
				return SR.T("Запланировано");
			}
			return SR.T("Выполнено");
		}
	}

	[DisplayName(typeof(RelationshipModel_SR), "To")]
	public RelationshipLink Link { get; set; }

	public long? PrevRelationshipId { get; set; }

	public bool LinkReadOnly { get; set; }

	public bool IsMultiCreation { get; set; }

	[DisplayName(typeof(RelationshipModel_SR), "Contacts")]
	public IList<IContact> ContractorContacts { get; set; }

	[DisplayName(typeof(RelationshipModel_SR), "To")]
	public IList<IContact> Contacts { get; set; }

	[DisplayName(typeof(RelationshipModel_SR), "To")]
	public IList<ILeadContact> LeadContacts { get; set; }

	[DisplayName(typeof(RelationshipModel_SR), "To")]
	public IList<IContractor> Contractors { get; set; }

	[DisplayName(typeof(RelationshipModel_SR), "To")]
	public IList<ILead> Leads { get; set; }

	[DisplayName(typeof(RelationshipModel_SR), "To")]
	public IList<ISale> Sales { get; set; }

	[DisplayName(typeof(RelationshipModel_SR), "Period")]
	public DateTime Interval { get; set; }

	public long? PrevContractorId { get; set; }

	public IList<long> PrevContractorContactsIds { get; set; }

	public long? PrevContactId { get; set; }

	public long? PrevLeadId { get; set; }

	public long? PrevSaleId { get; set; }

	public IList<IRelationship> Entities { get; protected set; }

	public bool IsAvailableCommentAdding
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	public bool IsAvailableDelete
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	public bool IsAvailableEdit
	{
		get
		{
			return true;
		}
		set
		{
		}
	}

	public bool IsAvailableCompleting
	{
		get
		{
			return !(Entity.Completed ?? false);
		}
		set
		{
		}
	}

	public bool IsAvailableDayAdding
	{
		get
		{
			return !(Entity.Completed ?? false);
		}
		set
		{
		}
	}

	public bool IsAvailableTimeChanging
	{
		get
		{
			return !(Entity.Completed ?? false);
		}
		set
		{
		}
	}

	public IRelationship Relationship => Entity;

	public virtual Guid RelationshipTypeUid => InterfaceActivator.UID(Entity.GetType().CastAsRealType());

	public abstract string EditorViewName { get; }

	protected RelationshipModel(IRelationship relationship)
	{
		Entity = relationship;
		Interval = new DateTime(2000, 1, 1, 0, 15, 0);
		PrevContractorContactsIds = new List<long>();
	}

	protected RelationshipModel()
	{
		Interval = new DateTime(2000, 1, 1, 0, 15, 0);
		PrevContractorContactsIds = new List<long>();
	}

	public virtual void Save()
	{
		if (IsMultiCreation)
		{
			Entities = new List<IRelationship>();
			if (Contractors != null)
			{
				foreach (IContractor contractor in Contractors)
				{
					Entity.Contractor = contractor;
					Entities.Add(Entity);
					SaveEntityAndCreateNew();
				}
			}
			if (Contacts != null)
			{
				foreach (IContact contact in Contacts)
				{
					Entity.Contact = contact;
					Entities.Add(Entity);
					SaveEntityAndCreateNew();
				}
			}
			if (Leads != null)
			{
				foreach (ILead lead in Leads)
				{
					if (lead.Responsible == null)
					{
						lead.Responsible = Locator.GetService<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
					}
					Entity.Lead = lead;
					Entities.Add(Entity);
					SaveEntityAndCreateNew();
				}
			}
			if (Sales == null)
			{
				return;
			}
			{
				foreach (ISale sale in Sales)
				{
					if (sale.Responsible == null)
					{
						sale.Responsible = Locator.GetService<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
					}
					Entity.Sale = sale;
					Entities.Add(Entity);
					SaveEntityAndCreateNew();
				}
				return;
			}
		}
		SaveEntity();
	}

	protected abstract void SaveEntityAndCreateNew();

	protected T BaseCreateNew<T>() where T : IRelationship
	{
		T result = InterfaceActivator.Create<T>();
		result.StartDate = Entity.StartDate.AddMinutes(Interval.Minute);
		result.StartDate = result.StartDate.AddHours(Interval.Hour);
		result.Theme = Entity.Theme;
		result.Priority = Entity.Priority;
		result.Description = Entity.Description;
		result.IsPrivate = Entity.IsPrivate;
		foreach (IRelationshipUser item in (IEnumerable<IRelationshipUser>)Entity.RelationshipUsers)
		{
			IRelationshipUser relationshipUser = InterfaceActivator.Create<IRelationshipUser>();
			relationshipUser.User = item.User;
			relationshipUser.Status = item.Status;
			result.RelationshipUsers.Add(relationshipUser);
		}
		return result;
	}

	protected virtual void SaveEntity()
	{
		if (!LinkReadOnly)
		{
			switch (Link)
			{
			case RelationshipLink.Contractor:
				Entity.Contact = null;
				Entity.Lead = null;
				break;
			case RelationshipLink.Contact:
				Entity.Contractor = null;
				Entity.Lead = null;
				Entity.Sale = null;
				((ICollection<IContact>)Entity.ContractorsContacts).Clear();
				((ICollection<ILeadContact>)Entity.LeadContacts).Clear();
				break;
			case RelationshipLink.Lead:
				Entity.Contractor = null;
				Entity.Contact = null;
				Entity.Sale = null;
				((ICollection<IContact>)Entity.ContractorsContacts).Clear();
				((ICollection<ILeadContact>)Entity.LeadContacts).Clear();
				break;
			}
		}
		Entity.Save();
	}

	private IRelationshipUser CreateCopy(IRelationshipUser relationshipUser)
	{
		IRelationshipUser relationshipUser2 = InterfaceActivator.Create<IRelationshipUser>();
		relationshipUser2.Relationship = relationshipUser.Relationship;
		relationshipUser2.Status = relationshipUser.Status;
		relationshipUser2.User = relationshipUser.User;
		return relationshipUser2;
	}

	public abstract IRelationshipBaseModel CreateFromRelationship(IRelationship relationship);

	public abstract IRelationshipBaseModel CreateFromRelationship(IRelationship relationship, Guid customFormUid);

	public virtual FormViewItem FormViewItem(ViewType viewType)
	{
		FormViewItem form = Metadata<EntityMetadata>().DefaultForms.GetForm(viewType);
		return (FormViewItem)((viewType == ViewType.Display) ? form.CloneAsReadOnly() : form.Clone());
	}
}
