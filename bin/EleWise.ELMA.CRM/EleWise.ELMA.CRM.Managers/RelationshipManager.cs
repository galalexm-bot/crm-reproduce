using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using Iesi.Collections;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.CRM.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class RelationshipManager : RelationshipBaseManager<IRelationship, long>
{
	public const long DEFAULT_CALL_DURATION = 10L;

	public const long DEFAULT_MEETING_DURATION = 15L;

	public const long DEFAULT_MAIL_DURATION = 10L;

	[NotNull]
	public IEntityActionHandler EntityActionHandler { get; set; }

	public IEntityManager<IRelationshipPersonPermission> RelationshipPersonPermissionManager { get; set; }

	public new static RelationshipManager Instance => Locator.GetServiceNotNull<RelationshipManager>();

	[NotNull]
	public ICommentActionHandler CommentActionHandler { get; set; }

	[NotNull]
	public new IEntityActionHandler ActionHandler { get; set; }

	public static long GetDefaultDurationByEntityTypeUid(Guid typeUid)
	{
		IMetadataRuntimeService service = Locator.GetService<IMetadataRuntimeService>();
		if (service != null)
		{
			Type typeByUid = service.GetTypeByUid(typeUid);
			if (typeByUid != null)
			{
				if (typeof(IRelationshipCall).IsAssignableFrom(typeByUid))
				{
					return 10L;
				}
				if (typeof(IRelationshipMeeting).IsAssignableFrom(typeByUid))
				{
					return 15L;
				}
				typeof(IRelationshipMail).IsAssignableFrom(typeByUid);
				return 10L;
			}
		}
		return 10L;
	}

	public bool IsSaved(IRelationship relationship)
	{
		if (relationship == null)
		{
			return false;
		}
		return base.Session.Get(base.ImplementationType, (object)relationship.Id) != null;
	}

	[ActionCheck("2d98aa5c-5f26-476a-9fe5-8b53e227f160")]
	public virtual bool CanDeleteRelationship(IRelationship item, out Guid currentParentEntityUid, out long currentParentEntityId)
	{
		currentParentEntityId = 0L;
		currentParentEntityUid = Guid.Empty;
		return base.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, item);
	}

	[ActionMethod("2d98aa5c-5f26-476a-9fe5-8b53e227f160")]
	public virtual void DeleteRelationship(IRelationship item, out Guid currentParentEntityUid, out long currentParentEntityId)
	{
		DeleteRelationship(item, out var currentParentEntity);
		if (currentParentEntity != null)
		{
			currentParentEntityUid = InterfaceActivator.UID(currentParentEntity.GetType());
			currentParentEntityId = currentParentEntity.Id;
		}
		else
		{
			currentParentEntityId = 0L;
			currentParentEntityUid = Guid.Empty;
		}
	}

	[Transaction]
	public virtual void DeleteRelationship(IRelationship item, out IEntity<long> currentParentEntity)
	{
		currentParentEntity = null;
		if (item.Contractor != null)
		{
			currentParentEntity = item.Contractor;
			((ICollection<IRelationship>)item.Contractor.Relationships).Remove(item);
			Instance.UpdateNextRelationship(item.Contractor);
			foreach (IContact item2 in (IEnumerable<IContact>)item.ContractorsContacts)
			{
				((ICollection<IRelationship>)item2.Relationships).Remove(item);
				Instance.UpdateNextRelationship(item2);
			}
		}
		else if (item.Contact != null)
		{
			currentParentEntity = item.Contact;
			((ICollection<IRelationship>)item.Contact.Relationships).Remove(item);
			Instance.UpdateNextRelationship(item.Contact);
		}
		else if (item.Lead != null)
		{
			currentParentEntity = item.Lead;
			((ICollection<IRelationship>)item.Lead.Relationships).Remove(item);
			Instance.UpdateNextRelationship(item.Lead);
		}
		else if (item.Sale != null)
		{
			currentParentEntity = item.Sale;
		}
		item.Delete();
		EntityActionHandler.ActionExecuted(new EntityActionEventArgs(null, item, "f5d56c0f-95af-48d5-89a0-ea4e9a336429"));
	}

	[Transaction]
	public virtual void AddDay(long entityId, string comment)
	{
		IRelationship relationship = LoadOrNull(entityId);
		if (relationship != null)
		{
			IComment comment2 = null;
			if (!string.IsNullOrEmpty(comment))
			{
				comment2 = InterfaceActivator.Create<IComment>();
				comment2.Text = comment;
				comment2.Save();
				relationship.Comments.Add(comment2);
			}
			relationship.StartDate = relationship.StartDate.AddDays(1.0);
			relationship.EndDate = relationship.EndDate.AddDays(1.0);
			Save(relationship);
			EntityActionHandler.ActionExecuted(new EntityActionEventArgs(null, relationship, "fa413130-d92d-41e4-9fba-b133c43fe02a"));
		}
	}

	[ActionCheck("fa413130-d92d-41e4-9fba-b133c43fe02a")]
	public virtual bool CanChangeTime(long entityId, DateTime startDate, DateTime? endDate, string comment)
	{
		IRelationship relationship = LoadOrNull(entityId);
		if (relationship == null)
		{
			return false;
		}
		if ((!endDate.HasValue || startDate < endDate.Value) && base.SecurityService.HasPermission(CRMPermissionProvider.EditRelationshipPermission, relationship))
		{
			return !relationship.Sale.SaleClosed();
		}
		return false;
	}

	[Transaction]
	[ActionMethod("fa413130-d92d-41e4-9fba-b133c43fe02a")]
	public virtual void ChangeTime(long entityId, DateTime startDate, DateTime? endDate, string comment)
	{
		IRelationship relationship = LoadOrNull(entityId);
		if (relationship != null)
		{
			IComment comment2 = null;
			if (!string.IsNullOrEmpty(comment))
			{
				comment2 = InterfaceActivator.Create<IComment>();
				comment2.Text = comment;
				comment2.Save();
				relationship.Comments.Add(comment2);
			}
			relationship.StartDate = startDate;
			relationship.EndDate = (endDate.HasValue ? endDate.Value : relationship.StartDate.AddMinutes(GetDefaultDurationByEntityTypeUid(relationship.TypeUid)));
			if (relationship is IRelationshipMeeting)
			{
				((IRelationshipMeeting)relationship).TimeNotSet = false;
			}
			Save(relationship);
			EntityActionHandler.ActionExecuted(new EntityActionEventArgs(null, relationship, "fa413130-d92d-41e4-9fba-b133c43fe02a"));
		}
	}

	[Transaction]
	public virtual void Complete(long entityId, string comment)
	{
		IRelationship entity = LoadOrNull(entityId);
		Complete(entity, comment);
	}

	[Transaction]
	public virtual void Complete(IRelationship entity, string comment)
	{
		if (entity != null)
		{
			ICommentActionModel commentActionModel = null;
			if (!string.IsNullOrEmpty(comment))
			{
				commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
				commentActionModel.Comment = InterfaceActivator.Create<IComment>();
				commentActionModel.Comment.Text = comment;
				ApplyCommentActionModel(entity, commentActionModel);
			}
			entity.Completed = true;
			entity.DoneDate = DateTime.Now;
			Save(entity);
			ActionHandler.ActionExecuted(new EntityActionEventArgs(null, entity, "786919b5-d160-426a-a578-f74b503cf966"));
		}
	}

	protected void RaiseCommentActionEvent(IRelationship old, IRelationship @new, string actionUidStr, ICommentActionModel actionModel)
	{
		ActionHandler.ActionExecuted(TryCreateCommentActionEventArgs(old, @new, actionUidStr, actionModel));
	}

	[Auditable]
	protected virtual EntityActionEventArgs TryCreateCommentActionEventArgs(IRelationship old, IRelationship @new, string actionUidStr, ICommentActionModel actionModel)
	{
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(old, @new, actionUidStr);
		if (entityActionEventArgs != null)
		{
			CommentActionHandler.ProcessEventArgs(entityActionEventArgs, actionModel);
		}
		return entityActionEventArgs;
	}

	[Auditable]
	protected virtual void ApplyCommentActionModel(IRelationship relationship, ICommentActionModel actionModel)
	{
		CommentActionHandler.Process(relationship, actionModel);
	}

	public void UpdateNextRelationship(INextRelationshipEntity entity, IRelationship nextRelationship = null)
	{
		object value = entity.CastAsRealType().GetType().GetReflectionProperty("Relationships")
			.GetValue(entity, null);
		ISet val = (ISet)((value is ISet) ? value : null);
		if (val == null)
		{
			return;
		}
		List<IRelationship> source = (from IRelationship r in (IEnumerable)val
			where !r.IsDeleted
			select r).ToList();
		List<IRelationship> list = source.Where((IRelationship r) => r.Completed != true).ToList();
		if (nextRelationship != null && nextRelationship.Completed != true && !nextRelationship.IsDeleted)
		{
			list.Add(nextRelationship);
		}
		if (list.Any())
		{
			DateTime minDate = list.Min((IRelationship r) => r.StartDate);
			entity.NextRelationship = list.FirstOrDefault((IRelationship r) => r.StartDate.Equals(minDate));
			return;
		}
		List<IRelationship> list2 = source.Where((IRelationship r) => r.Completed == true).ToList();
		if (nextRelationship != null && nextRelationship.Completed == true && !nextRelationship.IsDeleted)
		{
			list2.Add(nextRelationship);
		}
		if (list2.Any())
		{
			DateTime maxDate = list2.Max((IRelationship r) => r.StartDate);
			entity.NextRelationship = list2.FirstOrDefault((IRelationship r) => r.StartDate.Equals(maxDate));
		}
		else
		{
			entity.NextRelationship = ((nextRelationship == null || nextRelationship.IsDeleted) ? null : nextRelationship);
		}
	}

	protected virtual ICriteria CreateCriteriaNoPermissions()
	{
		return base.Session.CreateCriteria(InterfaceActivator.TypeOf<IRelationship>());
	}

	[Transaction]
	public virtual void CheckRelationshipExpiration(DateTime checkTime)
	{
		foreach (IRelationship item in CreateCriteriaNoPermissions().Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("Completed"), (ICriterion)(object)Restrictions.Eq("Completed", (object)false))).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("IsDeleted"), (ICriterion)(object)Restrictions.Eq("IsDeleted", (object)false))).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Le("EndDate", (object)checkTime), (ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("TimeNotSet"), (ICriterion)(object)Restrictions.Eq("TimeNotSet", (object)false))), (ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Le("EndDate", (object)checkTime.Date), (ICriterion)(object)Restrictions.Eq("TimeNotSet", (object)true))))
			.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.IsNull("ExpiredNotificationSent"), (ICriterion)(object)Restrictions.Eq("ExpiredNotificationSent", (object)false)))
			.List<IRelationship>()
			.ToList())
		{
			ActionHandler.ActionExecuted(new EntityActionEventArgs(item, item, "e6dded39-cd54-4e9e-a99c-e84ac3a1dd82"));
			item.ExpiredNotificationSent = true;
			item.Save();
		}
	}

	[Transaction]
	public virtual void EnableInheritPermissions(IRelationship relationship, bool enable)
	{
		if (enable)
		{
			relationship.InheritPermissions = true;
			AddPermissionsFromParent(relationship);
		}
		else
		{
			relationship.InheritPermissions = false;
			CopyPermissionsFromInherited(relationship);
		}
		Save(relationship);
	}

	public virtual void CopyPermissionsFromInherited(IRelationship relationship)
	{
		((IEnumerable<IRelationshipPersonPermission>)relationship.Permission).ForEach(delegate(IRelationshipPersonPermission p)
		{
			p.InheritedFromNumber = null;
			p.PermissionRole = ((p.PermissionRole == CommonRoleTypes.Responsible.UID) ? new Guid?(CommonRoleTypes.User.UID) : p.PermissionRole);
		});
	}

	public virtual void DeleteAllPermissionInRelationship(IRelationship relationship)
	{
		List<IRelationshipPersonPermission> list = new List<IRelationshipPersonPermission>();
		foreach (IRelationshipPersonPermission item in ((IEnumerable<IRelationshipPersonPermission>)relationship.Permission).Where((IRelationshipPersonPermission a) => a.InheritedFromNumber.HasValue))
		{
			item.Delete();
			list.Add(item);
		}
		relationship.Permission.RemoveAll((ICollection<IRelationshipPersonPermission>)list);
	}

	public virtual void AddPermissionsFromParent(IRelationship relationship)
	{
		EleWise.ELMA.Security.Models.IUser user = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
		if (relationship.Contractor != null)
		{
			foreach (IContractorPersonPermission item in (IEnumerable<IContractorPersonPermission>)relationship.Contractor.Permission)
			{
				if ((!(item.PermissionRole == CommonRoleTypes.ParticipantWork.Id) && !(item.PermissionRole == CommonRoleTypes.Informs.Id)) || item.User.Id == user.Id)
				{
					if (relationship.RelationshipUsers != null)
					{
						if (item.PermissionRole == CommonRoleTypes.Informs.Id)
						{
							foreach (IRelationshipUser item2 in ((IEnumerable<IRelationshipUser>)relationship.RelationshipUsers).Where((IRelationshipUser a) => a.Status == RelationshipUserStatus.InfromTo))
							{
								Guid guid = replasePermissionContractor(item);
								if (guid != Guid.Empty)
								{
									InstanceOf<IRelationshipPersonPermission> instanceOf = new InstanceOf<IRelationshipPersonPermission>();
									instanceOf.New.Relationship = relationship;
									instanceOf.New.User = item2.User;
									instanceOf.New.Group = item.Group;
									instanceOf.New.OrganizationItemEmployee = item.OrganizationItemEmployee;
									instanceOf.New.OrganizationItemPosition = item.OrganizationItemPosition;
									instanceOf.New.PermissionId = guid;
									instanceOf.New.TypeRoleId = item.TypeRoleId;
									instanceOf.New.PermissionRole = item.PermissionRole;
									instanceOf.New.InheritedFromNumber = 1L;
									IRelationshipPersonPermission @new = instanceOf.New;
									@new.Save();
									relationship.Permission.Add(@new);
								}
							}
						}
						if (item.PermissionRole == CommonRoleTypes.ParticipantWork.Id)
						{
							foreach (IRelationshipUser item3 in ((IEnumerable<IRelationshipUser>)relationship.RelationshipUsers).Where((IRelationshipUser a) => a.Status == RelationshipUserStatus.Participant))
							{
								Guid guid2 = replasePermissionContractor(item);
								if (guid2 != Guid.Empty)
								{
									InstanceOf<IRelationshipPersonPermission> instanceOf2 = new InstanceOf<IRelationshipPersonPermission>();
									instanceOf2.New.Relationship = relationship;
									instanceOf2.New.User = item3.User;
									instanceOf2.New.Group = item.Group;
									instanceOf2.New.OrganizationItemEmployee = item.OrganizationItemEmployee;
									instanceOf2.New.OrganizationItemPosition = item.OrganizationItemPosition;
									instanceOf2.New.PermissionId = guid2;
									instanceOf2.New.TypeRoleId = item.TypeRoleId;
									instanceOf2.New.PermissionRole = item.PermissionRole;
									instanceOf2.New.InheritedFromNumber = 1L;
									IRelationshipPersonPermission new2 = instanceOf2.New;
									new2.Save();
									relationship.Permission.Add(new2);
								}
							}
						}
					}
					Guid guid3 = replasePermissionContractor(item);
					EleWise.ELMA.Security.Models.IUser user2 = item.User;
					if (item.PermissionRole.HasValue && item.PermissionRole == CommonRoleTypes.Author.Id)
					{
						user2 = relationship.CreationAuthor;
					}
					if (guid3 != Guid.Empty)
					{
						InstanceOf<IRelationshipPersonPermission> instanceOf3 = new InstanceOf<IRelationshipPersonPermission>();
						instanceOf3.New.Relationship = relationship;
						instanceOf3.New.User = user2;
						instanceOf3.New.Group = item.Group;
						instanceOf3.New.OrganizationItemEmployee = item.OrganizationItemEmployee;
						instanceOf3.New.OrganizationItemPosition = item.OrganizationItemPosition;
						instanceOf3.New.PermissionId = guid3;
						instanceOf3.New.TypeRoleId = item.TypeRoleId;
						instanceOf3.New.PermissionRole = item.PermissionRole;
						instanceOf3.New.InheritedFromNumber = 1L;
						IRelationshipPersonPermission new3 = instanceOf3.New;
						new3.Save();
						relationship.Permission.Add(new3);
					}
				}
			}
			return;
		}
		if (relationship.Contact != null)
		{
			foreach (IContactPersonPermission item4 in (IEnumerable<IContactPersonPermission>)relationship.Contact.Permission)
			{
				if ((!(item4.PermissionRole == CommonRoleTypes.ParticipantWork.Id) && !(item4.PermissionRole == CommonRoleTypes.Informs.Id)) || item4.User.Id == user.Id)
				{
					Guid guid4 = Guid.Empty;
					if (item4.PermissionId == CRMPermissionProvider.CRMContactCreateElementPermission.Id)
					{
						guid4 = CRMPermissionProvider.CRMRelationshipCreateElementPermission.Id;
					}
					else if (item4.PermissionId == CRMPermissionProvider.ViewContactPermission.Id)
					{
						guid4 = CRMPermissionProvider.ViewRelationshipPermission.Id;
					}
					else if (item4.PermissionId == CRMPermissionProvider.EditContactPermission.Id)
					{
						guid4 = CRMPermissionProvider.EditRelationshipPermission.Id;
					}
					else if (item4.PermissionId == CRMPermissionProvider.CRMContactIssuanceElementPermission.Id)
					{
						guid4 = CRMPermissionProvider.CRMRelationshipIssuanceElementPermission.Id;
					}
					else if (item4.PermissionId == CRMPermissionProvider.CRMContactFullAccessPermission.Id)
					{
						guid4 = CRMPermissionProvider.CRMRelationshipFullAccessPermission.Id;
					}
					EleWise.ELMA.Security.Models.IUser user3 = item4.User;
					if (item4.PermissionRole.HasValue && item4.PermissionRole == CommonRoleTypes.Author.Id)
					{
						user3 = relationship.CreationAuthor;
					}
					if (guid4 != Guid.Empty)
					{
						InstanceOf<IRelationshipPersonPermission> instanceOf4 = new InstanceOf<IRelationshipPersonPermission>();
						instanceOf4.New.Relationship = relationship;
						instanceOf4.New.User = user3;
						instanceOf4.New.Group = item4.Group;
						instanceOf4.New.OrganizationItemEmployee = item4.OrganizationItemEmployee;
						instanceOf4.New.OrganizationItemPosition = item4.OrganizationItemPosition;
						instanceOf4.New.PermissionId = guid4;
						instanceOf4.New.TypeRoleId = item4.TypeRoleId;
						instanceOf4.New.PermissionRole = item4.PermissionRole;
						instanceOf4.New.InheritedFromNumber = 1L;
						IRelationshipPersonPermission new4 = instanceOf4.New;
						new4.Save();
						relationship.Permission.Add(new4);
					}
				}
			}
			return;
		}
		if (relationship.Sale != null)
		{
			foreach (ISalePersonPermission item5 in (IEnumerable<ISalePersonPermission>)relationship.Sale.Permission)
			{
				if ((!(item5.PermissionRole == CommonRoleTypes.ParticipantWork.Id) && !(item5.PermissionRole == CommonRoleTypes.Informs.Id)) || item5.User.Id == user.Id)
				{
					Guid guid5 = Guid.Empty;
					if (item5.PermissionId == CRMPermissionProvider.CRMSaleCreateElementPermission.Id)
					{
						guid5 = CRMPermissionProvider.CRMRelationshipCreateElementPermission.Id;
					}
					else if (item5.PermissionId == CRMPermissionProvider.ViewSalePermission.Id)
					{
						guid5 = CRMPermissionProvider.ViewRelationshipPermission.Id;
					}
					else if (item5.PermissionId == CRMPermissionProvider.EditSalePermission.Id)
					{
						guid5 = CRMPermissionProvider.EditRelationshipPermission.Id;
					}
					else if (item5.PermissionId == CRMPermissionProvider.CRMSaleIssuanceElementPermission.Id)
					{
						guid5 = CRMPermissionProvider.CRMRelationshipIssuanceElementPermission.Id;
					}
					else if (item5.PermissionId == CRMPermissionProvider.CRMSaleFullAccessPermission.Id)
					{
						guid5 = CRMPermissionProvider.CRMRelationshipFullAccessPermission.Id;
					}
					EleWise.ELMA.Security.Models.IUser user4 = item5.User;
					if (item5.PermissionRole.HasValue && item5.PermissionRole == CommonRoleTypes.Author.Id)
					{
						user4 = relationship.CreationAuthor;
					}
					if (guid5 != Guid.Empty)
					{
						InstanceOf<IRelationshipPersonPermission> instanceOf5 = new InstanceOf<IRelationshipPersonPermission>();
						instanceOf5.New.Relationship = relationship;
						instanceOf5.New.User = user4;
						instanceOf5.New.Group = item5.Group;
						instanceOf5.New.OrganizationItemEmployee = item5.OrganizationItemEmployee;
						instanceOf5.New.OrganizationItemPosition = item5.OrganizationItemPosition;
						instanceOf5.New.PermissionId = guid5;
						instanceOf5.New.TypeRoleId = item5.TypeRoleId;
						instanceOf5.New.PermissionRole = item5.PermissionRole;
						instanceOf5.New.InheritedFromNumber = 1L;
						IRelationshipPersonPermission new5 = instanceOf5.New;
						new5.Save();
						relationship.Permission.Add(new5);
					}
				}
			}
			return;
		}
		if (relationship.Lead == null)
		{
			return;
		}
		foreach (ILeadPersonPermission item6 in (IEnumerable<ILeadPersonPermission>)relationship.Lead.Permission)
		{
			if ((item6.PermissionRole == CommonRoleTypes.ParticipantWork.Id || item6.PermissionRole == CommonRoleTypes.Informs.Id) && item6.User.Id != user.Id)
			{
				continue;
			}
			if (relationship.RelationshipUsers != null)
			{
				if (item6.PermissionRole == CommonRoleTypes.Informs.Id)
				{
					foreach (IRelationshipUser item7 in ((IEnumerable<IRelationshipUser>)relationship.RelationshipUsers).Where((IRelationshipUser a) => a.Status == RelationshipUserStatus.InfromTo))
					{
						Guid guid6 = replasePermissionLead(item6);
						if (guid6 != Guid.Empty)
						{
							InstanceOf<IRelationshipPersonPermission> instanceOf6 = new InstanceOf<IRelationshipPersonPermission>();
							instanceOf6.New.Relationship = relationship;
							instanceOf6.New.User = item7.User;
							instanceOf6.New.Group = item6.Group;
							instanceOf6.New.OrganizationItemEmployee = item6.OrganizationItemEmployee;
							instanceOf6.New.OrganizationItemPosition = item6.OrganizationItemPosition;
							instanceOf6.New.PermissionId = guid6;
							instanceOf6.New.TypeRoleId = item6.TypeRoleId;
							instanceOf6.New.PermissionRole = item6.PermissionRole;
							instanceOf6.New.InheritedFromNumber = 1L;
							IRelationshipPersonPermission new6 = instanceOf6.New;
							new6.Save();
							relationship.Permission.Add(new6);
						}
					}
				}
				if (item6.PermissionRole == CommonRoleTypes.ParticipantWork.Id)
				{
					foreach (IRelationshipUser item8 in ((IEnumerable<IRelationshipUser>)relationship.RelationshipUsers).Where((IRelationshipUser a) => a.Status == RelationshipUserStatus.Participant))
					{
						Guid guid7 = replasePermissionLead(item6);
						if (guid7 != Guid.Empty)
						{
							InstanceOf<IRelationshipPersonPermission> instanceOf7 = new InstanceOf<IRelationshipPersonPermission>();
							instanceOf7.New.Relationship = relationship;
							instanceOf7.New.User = item8.User;
							instanceOf7.New.Group = item6.Group;
							instanceOf7.New.OrganizationItemEmployee = item6.OrganizationItemEmployee;
							instanceOf7.New.OrganizationItemPosition = item6.OrganizationItemPosition;
							instanceOf7.New.PermissionId = guid7;
							instanceOf7.New.TypeRoleId = item6.TypeRoleId;
							instanceOf7.New.PermissionRole = item6.PermissionRole;
							instanceOf7.New.InheritedFromNumber = 1L;
							IRelationshipPersonPermission new7 = instanceOf7.New;
							new7.Save();
							relationship.Permission.Add(new7);
						}
					}
				}
			}
			Guid guid8 = replasePermissionLead(item6);
			if (guid8 != Guid.Empty)
			{
				InstanceOf<IRelationshipPersonPermission> instanceOf8 = new InstanceOf<IRelationshipPersonPermission>();
				instanceOf8.New.Relationship = relationship;
				instanceOf8.New.User = item6.User;
				instanceOf8.New.Group = item6.Group;
				instanceOf8.New.OrganizationItemEmployee = item6.OrganizationItemEmployee;
				instanceOf8.New.OrganizationItemPosition = item6.OrganizationItemPosition;
				instanceOf8.New.PermissionId = guid8;
				instanceOf8.New.TypeRoleId = item6.TypeRoleId;
				instanceOf8.New.PermissionRole = item6.PermissionRole;
				instanceOf8.New.InheritedFromNumber = 1L;
				IRelationshipPersonPermission new8 = instanceOf8.New;
				new8.Save();
				relationship.Permission.Add(new8);
			}
		}
	}

	private Guid replasePermissionContractor(IContractorPersonPermission perm)
	{
		Guid result = Guid.Empty;
		if (perm.PermissionId == CRMPermissionProvider.CRMContractorCreateElementPermission.Id)
		{
			result = CRMPermissionProvider.CRMRelationshipCreateElementPermission.Id;
		}
		else if (perm.PermissionId == CRMPermissionProvider.ViewContractorPermission.Id)
		{
			result = CRMPermissionProvider.ViewRelationshipPermission.Id;
		}
		else if (perm.PermissionId == CRMPermissionProvider.EditContractorPermission.Id)
		{
			result = CRMPermissionProvider.EditRelationshipPermission.Id;
		}
		else if (perm.PermissionId == CRMPermissionProvider.CRMContractorIssuanceElementPermission.Id)
		{
			result = CRMPermissionProvider.CRMRelationshipIssuanceElementPermission.Id;
		}
		else if (perm.PermissionId == CRMPermissionProvider.CRMContractorFullAccessPermission.Id)
		{
			result = CRMPermissionProvider.CRMRelationshipFullAccessPermission.Id;
		}
		return result;
	}

	private Guid replasePermissionLead(ILeadPersonPermission perm)
	{
		Guid result = Guid.Empty;
		if (perm.PermissionId == CRMPermissionProvider.CRMLeadCreateElementPermission.Id)
		{
			result = CRMPermissionProvider.CRMRelationshipCreateElementPermission.Id;
		}
		else if (perm.PermissionId == CRMPermissionProvider.ViewLeadPermission.Id)
		{
			result = CRMPermissionProvider.ViewRelationshipPermission.Id;
		}
		else if (perm.PermissionId == CRMPermissionProvider.EditLeadPermission.Id)
		{
			result = CRMPermissionProvider.EditRelationshipPermission.Id;
		}
		else if (perm.PermissionId == CRMPermissionProvider.CRMLeadIssuanceElementPermission.Id)
		{
			result = CRMPermissionProvider.CRMRelationshipIssuanceElementPermission.Id;
		}
		else if (perm.PermissionId == CRMPermissionProvider.CRMLeadFullAccessPermission.Id)
		{
			result = CRMPermissionProvider.CRMRelationshipFullAccessPermission.Id;
		}
		return result;
	}

	[PublicApiMember]
	public virtual void CompleteRelationship(IRelationship relationship, string comment = null)
	{
		if (relationship == null)
		{
			throw new NullReferenceException(SR.T("Взаимоотношение не может быть null"));
		}
		Instance.Complete(relationship.Id, comment);
	}

	[PublicApiMember]
	public IRelationshipCall CreateCall()
	{
		return InterfaceActivator.Create<IRelationshipCall>();
	}

	[PublicApiMember]
	public IRelationshipCall CreateCall(IContact contact)
	{
		if (contact == null)
		{
			throw new NullReferenceException(SR.T("Контакт не может быть null"));
		}
		IRelationshipCall relationshipCall = InterfaceActivator.Create<IRelationshipCall>();
		relationshipCall.Contact = contact;
		return relationshipCall;
	}

	[PublicApiMember]
	public IRelationshipCall CreateCall(IContractor contractor)
	{
		if (contractor == null)
		{
			throw new NullReferenceException(SR.T("Контрагент не может быть null"));
		}
		IRelationshipCall relationshipCall = InterfaceActivator.Create<IRelationshipCall>();
		relationshipCall.Contractor = contractor;
		return relationshipCall;
	}

	[PublicApiMember]
	public IRelationshipCall CreateCall(ILead lead)
	{
		if (lead == null)
		{
			throw new NullReferenceException(SR.T("Возможность не может быть null"));
		}
		IRelationshipCall relationshipCall = InterfaceActivator.Create<IRelationshipCall>();
		relationshipCall.Lead = lead;
		return relationshipCall;
	}

	[PublicApiMember]
	public IRelationshipCall CreateCall(ISale sale)
	{
		if (sale == null)
		{
			throw new NullReferenceException(SR.T("Сделка не может быть null"));
		}
		IRelationshipCall relationshipCall = InterfaceActivator.Create<IRelationshipCall>();
		relationshipCall.Sale = sale;
		return relationshipCall;
	}

	[PublicApiMember]
	public IRelationshipMail CreateMail()
	{
		return InterfaceActivator.Create<IRelationshipMail>();
	}

	[PublicApiMember]
	public IRelationshipMail CreateMail(IContact contact)
	{
		if (contact == null)
		{
			throw new NullReferenceException(SR.T("Контакт не может быть null"));
		}
		IRelationshipMail relationshipMail = InterfaceActivator.Create<IRelationshipMail>();
		relationshipMail.Contact = contact;
		return relationshipMail;
	}

	[PublicApiMember]
	public IRelationshipMail CreateMail(IContractor contractor)
	{
		if (contractor == null)
		{
			throw new NullReferenceException(SR.T("Контрагент не может быть null"));
		}
		IRelationshipMail relationshipMail = InterfaceActivator.Create<IRelationshipMail>();
		relationshipMail.Contractor = contractor;
		return relationshipMail;
	}

	[PublicApiMember]
	public IRelationshipMail CreateMail(ILead lead)
	{
		if (lead == null)
		{
			throw new NullReferenceException(SR.T("Возможность не может быть null"));
		}
		IRelationshipMail relationshipMail = InterfaceActivator.Create<IRelationshipMail>();
		relationshipMail.Lead = lead;
		return relationshipMail;
	}

	[PublicApiMember]
	public IRelationshipMail CreateMail(ISale sale)
	{
		if (sale == null)
		{
			throw new NullReferenceException(SR.T("Сделка не может быть null"));
		}
		IRelationshipMail relationshipMail = InterfaceActivator.Create<IRelationshipMail>();
		relationshipMail.Sale = sale;
		return relationshipMail;
	}

	[PublicApiMember]
	public IRelationshipMeeting CreateMeeting()
	{
		return InterfaceActivator.Create<IRelationshipMeeting>();
	}

	[PublicApiMember]
	public IRelationshipMeeting CreateMeeting(IContact contact)
	{
		if (contact == null)
		{
			throw new NullReferenceException(SR.T("Контакт не может быть null"));
		}
		IRelationshipMeeting relationshipMeeting = InterfaceActivator.Create<IRelationshipMeeting>();
		relationshipMeeting.Contact = contact;
		return relationshipMeeting;
	}

	[PublicApiMember]
	public IRelationshipMeeting CreateMeeting(IContractor contractor)
	{
		if (contractor == null)
		{
			throw new NullReferenceException(SR.T("Контрагент не может быть null"));
		}
		IRelationshipMeeting relationshipMeeting = InterfaceActivator.Create<IRelationshipMeeting>();
		relationshipMeeting.Contractor = contractor;
		return relationshipMeeting;
	}

	[PublicApiMember]
	public IRelationshipMeeting CreateMeeting(ILead lead)
	{
		if (lead == null)
		{
			throw new NullReferenceException(SR.T("Возможность не может быть null"));
		}
		IRelationshipMeeting relationshipMeeting = InterfaceActivator.Create<IRelationshipMeeting>();
		relationshipMeeting.Lead = lead;
		return relationshipMeeting;
	}

	[PublicApiMember]
	public IRelationshipMeeting CreateMeeting(ISale sale)
	{
		if (sale == null)
		{
			throw new NullReferenceException(SR.T("Сделка не может быть null"));
		}
		IRelationshipMeeting relationshipMeeting = InterfaceActivator.Create<IRelationshipMeeting>();
		relationshipMeeting.Sale = sale;
		return relationshipMeeting;
	}

	[PublicApiMember]
	[Transaction]
	public virtual void AddComment(IRelationship relationship, string comment)
	{
		if (relationship == null)
		{
			throw new NullReferenceException(SR.T("Взаимоотношение не может быть null"));
		}
		IComment comment2 = InterfaceActivator.Create<IComment>();
		comment2.Text = comment;
		comment2.CreationDate = DateTime.Now;
		comment2.CreationAuthor = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		comment2.Save();
		ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		commentActionModel.Comment = comment2;
		ICommentActionHandler serviceNotNull = Locator.GetServiceNotNull<ICommentActionHandler>();
		serviceNotNull.Process(relationship, commentActionModel);
		relationship.Comments.Add(comment2);
		relationship.Save();
		IEntityActionHandler serviceNotNull2 = Locator.GetServiceNotNull<IEntityActionHandler>();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, relationship, RelationshipActions.AddCommentGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ProcessEventArgs(entityActionEventArgs, commentActionModel);
			serviceNotNull2.ActionExecuted(entityActionEventArgs);
		}
	}

	[PublicApiMember]
	public virtual void AddComment(IRelationship relationship, string comment, EleWise.ELMA.Security.Models.IUser commentAuthor)
	{
		if (commentAuthor == null)
		{
			throw new NullReferenceException(SR.T("Автор комментария не может быть null"));
		}
		if (commentAuthor != base.AuthenticationService.GetCurrentUser())
		{
			base.SecurityService.RunByUser(commentAuthor, delegate
			{
				AddComment(relationship, comment);
			});
		}
		else
		{
			AddComment(relationship, comment);
		}
	}

	[PublicApiMember]
	public void DeletePermission(IRelationship relationship, EleWise.ELMA.Security.Models.IUser user)
	{
		DeletePermission(relationship, user, CRMPermissionProvider.ViewRelationshipPermission);
	}

	[PublicApiMember]
	public void DeletePermission(IRelationship relationship, IUserGroup userGroup)
	{
		DeletePermission(relationship, userGroup, CRMPermissionProvider.ViewRelationshipPermission);
	}

	[PublicApiMember]
	public void DeleteAuthorPermission(IRelationship relationship, Permission permission)
	{
		if (relationship == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		DelAuthorPermission(permission, relationship);
		if (permission == CRMPermissionProvider.ViewRelationshipPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMRelationshipCreateElementPermission, relationship);
			DelAuthorPermission(CRMPermissionProvider.EditRelationshipPermission, relationship);
			DelAuthorPermission(CRMPermissionProvider.CRMRelationshipIssuanceElementPermission, relationship);
			DelAuthorPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship);
		}
		if (permission == CRMPermissionProvider.EditRelationshipPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship);
		}
		if (permission == CRMPermissionProvider.CRMRelationshipCreateElementPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.EditRelationshipPermission, relationship);
			DelAuthorPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship);
		}
		if (permission == CRMPermissionProvider.CRMRelationshipIssuanceElementPermission)
		{
			DelAuthorPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship);
		}
		relationship.Save();
	}

	[PublicApiMember]
	public void AddAuthorPermission(IRelationship relationship, Permission permission)
	{
		if (relationship == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (permission == CRMPermissionProvider.CRMRelationshipFullAccessPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.CRMRelationshipCreateElementPermission, relationship);
			AddAuthorOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship);
			AddAuthorOnePermission(CRMPermissionProvider.EditRelationshipPermission, relationship);
			AddAuthorOnePermission(CRMPermissionProvider.CRMRelationshipIssuanceElementPermission, relationship);
		}
		if (permission == CRMPermissionProvider.EditRelationshipPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.CRMRelationshipCreateElementPermission, relationship);
			AddAuthorOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship);
		}
		if (permission == CRMPermissionProvider.CRMRelationshipIssuanceElementPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship);
		}
		if (permission == CRMPermissionProvider.CRMRelationshipCreateElementPermission)
		{
			AddAuthorOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship);
		}
		relationship.Save();
	}

	[PublicApiMember]
	public void DeletePermission(IRelationship relationship, IOrganizationItem orgItem)
	{
		DeletePermission(relationship, orgItem, CRMPermissionProvider.ViewRelationshipPermission);
	}

	[PublicApiMember]
	public void EnableInheritPermissions(IRelationship relationship)
	{
		if (relationship == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		EnableInheritPermissions(relationship, enable: true);
	}

	[PublicApiMember]
	public void DisableInheritPermissions(IRelationship relationship)
	{
		if (relationship == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		EnableInheritPermissions(relationship, enable: false);
	}

	[PublicApiMember]
	public void AddPermission(IRelationship relationship, EleWise.ELMA.Security.Models.IUser user, Permission permission)
	{
		if (relationship == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (user == null)
		{
			throw new ArgumentNullException(SR.T("Пользователь не может быть null"));
		}
		if (AddOnePermission(permission, relationship, user))
		{
			if (permission == CRMPermissionProvider.CRMRelationshipFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMRelationshipCreateElementPermission, relationship, user);
				AddOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship, user);
				AddOnePermission(CRMPermissionProvider.EditRelationshipPermission, relationship, user);
				AddOnePermission(CRMPermissionProvider.CRMRelationshipIssuanceElementPermission, relationship, user);
			}
			if (permission == CRMPermissionProvider.EditRelationshipPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMRelationshipCreateElementPermission, relationship, user);
				AddOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship, user);
			}
			if (permission == CRMPermissionProvider.CRMRelationshipIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship, user);
			}
			if (permission == CRMPermissionProvider.CRMRelationshipCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship, user);
			}
		}
		relationship.Save();
	}

	[PublicApiMember]
	public void AddPermission(IRelationship relationship, IUserGroup userGroup, Permission permission)
	{
		if (relationship == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (userGroup == null)
		{
			throw new ArgumentNullException(SR.T("Группа пользователей не может быть null"));
		}
		if (AddOnePermission(permission, relationship, userGroup))
		{
			if (permission == CRMPermissionProvider.CRMRelationshipFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMRelationshipCreateElementPermission, relationship, userGroup);
				AddOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship, userGroup);
				AddOnePermission(CRMPermissionProvider.EditRelationshipPermission, relationship, userGroup);
				AddOnePermission(CRMPermissionProvider.CRMRelationshipIssuanceElementPermission, relationship, userGroup);
			}
			if (permission == CRMPermissionProvider.EditRelationshipPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMRelationshipCreateElementPermission, relationship, userGroup);
				AddOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship, userGroup);
			}
			if (permission == CRMPermissionProvider.CRMRelationshipIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship, userGroup);
			}
			if (permission == CRMPermissionProvider.CRMRelationshipCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship, userGroup);
			}
		}
		relationship.Save();
	}

	[PublicApiMember]
	public void AddPermission(IRelationship relationship, IOrganizationItem orgItem, Permission permission)
	{
		if (relationship == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (orgItem == null)
		{
			throw new ArgumentNullException(SR.T("Должность не может быть null"));
		}
		if (AddOnePermission(permission, relationship, orgItem))
		{
			if (permission == CRMPermissionProvider.CRMRelationshipFullAccessPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMRelationshipCreateElementPermission, relationship, orgItem);
				AddOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship, orgItem);
				AddOnePermission(CRMPermissionProvider.EditRelationshipPermission, relationship, orgItem);
				AddOnePermission(CRMPermissionProvider.CRMRelationshipIssuanceElementPermission, relationship, orgItem);
			}
			if (permission == CRMPermissionProvider.EditRelationshipPermission)
			{
				AddOnePermission(CRMPermissionProvider.CRMRelationshipCreateElementPermission, relationship, orgItem);
				AddOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship, orgItem);
			}
			if (permission == CRMPermissionProvider.CRMRelationshipIssuanceElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship, orgItem);
			}
			if (permission == CRMPermissionProvider.CRMRelationshipCreateElementPermission)
			{
				AddOnePermission(CRMPermissionProvider.ViewRelationshipPermission, relationship, orgItem);
			}
		}
		relationship.Save();
	}

	private bool AddOnePermission(Permission permission, IRelationship relationship, EleWise.ELMA.Security.Models.IUser user)
	{
		if (!((IEnumerable<IRelationshipPersonPermission>)relationship.Permission).Any((IRelationshipPersonPermission r) => r.Assigned == user && r.PermissionId == permission.Id && !r.InheritedFromNumber.HasValue))
		{
			IRelationshipPersonPermission relationshipPersonPermission = RelationshipPersonPermissionManager.Create();
			relationshipPersonPermission.Relationship = relationship;
			relationshipPersonPermission.PermissionId = permission.Id;
			relationshipPersonPermission.User = user;
			relationshipPersonPermission.PermissionRole = CommonRoleTypes.User.Id;
			relationship.Permission.Add(relationshipPersonPermission);
			return true;
		}
		return false;
	}

	private bool AddOnePermission(Permission permission, IRelationship relationship, IUserGroup userGroup)
	{
		if (!((IEnumerable<IRelationshipPersonPermission>)relationship.Permission).Any((IRelationshipPersonPermission r) => r.Assigned == userGroup && r.PermissionId == permission.Id))
		{
			IRelationshipPersonPermission relationshipPersonPermission = RelationshipPersonPermissionManager.Create();
			relationshipPersonPermission.Relationship = relationship;
			relationshipPersonPermission.PermissionId = permission.Id;
			relationshipPersonPermission.Group = userGroup;
			relationshipPersonPermission.PermissionRole = CommonRoleTypes.Group.Id;
			relationship.Permission.Add(relationshipPersonPermission);
		}
		return true;
	}

	private bool AddOnePermission(Permission permission, IRelationship relationship, IOrganizationItem orgItem)
	{
		if (!((IEnumerable<IRelationshipPersonPermission>)relationship.Permission).Any((IRelationshipPersonPermission r) => r.Assigned == orgItem && r.PermissionId == permission.Id))
		{
			IRelationshipPersonPermission relationshipPersonPermission = RelationshipPersonPermissionManager.Create();
			relationshipPersonPermission.Relationship = relationship;
			relationshipPersonPermission.PermissionId = permission.Id;
			relationshipPersonPermission.OrganizationItemPosition = orgItem;
			relationshipPersonPermission.PermissionRole = CommonRoleTypes.Group.Id;
			relationship.Permission.Add(relationshipPersonPermission);
		}
		return true;
	}

	private void AddAuthorOnePermission(Permission permission, IRelationship relationship)
	{
		if (!((IEnumerable<IRelationshipPersonPermission>)relationship.Permission).Any(delegate(IRelationshipPersonPermission r)
		{
			if (r.Assigned == relationship.CreationAuthor && r.PermissionId == permission.Id)
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
			IRelationshipPersonPermission relationshipPersonPermission = RelationshipPersonPermissionManager.Create();
			relationshipPersonPermission.Relationship = relationship;
			relationshipPersonPermission.PermissionId = permission.Id;
			relationshipPersonPermission.User = relationship.CreationAuthor;
			relationshipPersonPermission.PermissionRole = CommonRoleTypes.Author.Id;
			relationship.Permission.Add(relationshipPersonPermission);
		}
	}

	[PublicApiMember]
	public void DeletePermission(IRelationship relationship, EleWise.ELMA.Security.Models.IUser user, Permission permission)
	{
		if (relationship == null)
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
			hasPermission = base.SecurityService.HasPermission(user, permission, relationship);
		});
		if (hasPermission)
		{
			DelPermission(permission, relationship, user);
			if (permission == CRMPermissionProvider.ViewRelationshipPermission)
			{
				DelPermission(CRMPermissionProvider.CRMRelationshipCreateElementPermission, relationship, user);
				DelPermission(CRMPermissionProvider.EditRelationshipPermission, relationship, user);
				DelPermission(CRMPermissionProvider.CRMRelationshipIssuanceElementPermission, relationship, user);
				DelPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship, user);
			}
			if (permission == CRMPermissionProvider.EditRelationshipPermission)
			{
				DelPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship, user);
			}
			if (permission == CRMPermissionProvider.CRMRelationshipCreateElementPermission)
			{
				DelPermission(CRMPermissionProvider.EditRelationshipPermission, relationship, user);
				DelPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship, user);
			}
			if (permission == CRMPermissionProvider.CRMRelationshipIssuanceElementPermission)
			{
				DelPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship, user);
			}
		}
	}

	[PublicApiMember]
	public void DeletePermission(IRelationship relationship, IUserGroup userGroup, Permission permission)
	{
		if (relationship == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (userGroup == null)
		{
			throw new ArgumentNullException(SR.T("Группа пользователей не может быть null"));
		}
		DelPermission(permission, relationship, userGroup);
		if (permission == CRMPermissionProvider.ViewRelationshipPermission)
		{
			DelPermission(CRMPermissionProvider.CRMRelationshipCreateElementPermission, relationship, userGroup);
			DelPermission(CRMPermissionProvider.EditRelationshipPermission, relationship, userGroup);
			DelPermission(CRMPermissionProvider.CRMRelationshipIssuanceElementPermission, relationship, userGroup);
			DelPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship, userGroup);
		}
		if (permission == CRMPermissionProvider.EditRelationshipPermission)
		{
			DelPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship, userGroup);
		}
		if (permission == CRMPermissionProvider.CRMRelationshipCreateElementPermission)
		{
			DelPermission(CRMPermissionProvider.EditRelationshipPermission, relationship, userGroup);
			DelPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship, userGroup);
		}
		if (permission == CRMPermissionProvider.CRMRelationshipIssuanceElementPermission)
		{
			DelPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship, userGroup);
		}
		relationship.Save();
	}

	[PublicApiMember]
	public void DeletePermission(IRelationship relationship, IOrganizationItem orgItem, Permission permission)
	{
		if (relationship == null)
		{
			throw new ArgumentNullException(SR.T("Контрагент не может быть null"));
		}
		if (orgItem == null)
		{
			throw new ArgumentNullException(SR.T("Должность не может быть null"));
		}
		DelPermission(permission, relationship, orgItem);
		if (permission == CRMPermissionProvider.ViewRelationshipPermission)
		{
			DelPermission(CRMPermissionProvider.CRMRelationshipCreateElementPermission, relationship, orgItem);
			DelPermission(CRMPermissionProvider.EditRelationshipPermission, relationship, orgItem);
			DelPermission(CRMPermissionProvider.CRMRelationshipIssuanceElementPermission, relationship, orgItem);
			DelPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship, orgItem);
		}
		if (permission == CRMPermissionProvider.EditRelationshipPermission)
		{
			DelPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship, orgItem);
		}
		if (permission == CRMPermissionProvider.CRMRelationshipCreateElementPermission)
		{
			DelPermission(CRMPermissionProvider.EditRelationshipPermission, relationship, orgItem);
			DelPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship, orgItem);
		}
		if (permission == CRMPermissionProvider.CRMRelationshipIssuanceElementPermission)
		{
			DelPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, relationship, orgItem);
		}
		relationship.Save();
	}

	private void DelPermission(Permission permissions, IRelationship relationship, IUserGroup userGroup)
	{
		((ICollection<IRelationshipPersonPermission>)relationship.Permission).Remove(((IEnumerable<IRelationshipPersonPermission>)relationship.Permission).FirstOrDefault((IRelationshipPersonPermission r) => r.Assigned == userGroup && r.PermissionId == permissions.Id));
	}

	private void DelAuthorPermission(Permission permissions, IRelationship relationship)
	{
		((ICollection<IRelationshipPersonPermission>)relationship.Permission).Remove(((IEnumerable<IRelationshipPersonPermission>)relationship.Permission).FirstOrDefault((IRelationshipPersonPermission r) => r.PermissionRole == CommonRoleTypes.Author.Id && r.PermissionId == permissions.Id));
	}

	private void DelPermission(Permission permissions, IRelationship relationship, EleWise.ELMA.Security.Models.IUser user)
	{
		bool hasPermission = false;
		base.SecurityService.RunWithUsualPrivilegies(delegate
		{
			hasPermission = base.SecurityService.HasPermission(user, permissions, relationship);
		});
		if (hasPermission)
		{
			((ICollection<IRelationshipPersonPermission>)relationship.Permission).Remove(((IEnumerable<IRelationshipPersonPermission>)relationship.Permission).FirstOrDefault((IRelationshipPersonPermission r) => r.Assigned == user && r.PermissionId == permissions.Id));
		}
	}

	private void DelPermission(Permission permissions, IRelationship relationship, IOrganizationItem orgItem)
	{
		((ICollection<IRelationshipPersonPermission>)relationship.Permission).Remove(((IEnumerable<IRelationshipPersonPermission>)relationship.Permission).FirstOrDefault((IRelationshipPersonPermission r) => r.Assigned == orgItem && r.PermissionId == permissions.Id));
	}
}
