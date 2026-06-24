using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.BPM.Web.Security.Services;
using EleWise.ELMA.Cache;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

[Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
public class RelationshipController : BPMController<IRelationship, long>
{
	public const string DataFilterPrefix = "DataFilter";

	public IUnionComplexCacheService ComplexCacheService { get; set; }

	[CustomGridAction]
	public ActionResult Grid(GridCommand command, CustomGridCommand customCommand, RelationshipGrid grid)
	{
		IRelationshipFilter relationshipFilter = InterfaceActivator.Create<IRelationshipFilter>();
		if (grid.ContractorId > 0)
		{
			IContractor contractor2 = (relationshipFilter.Contractor = ContractorManager.Instance.Load(grid.ContractorId));
		}
		if (grid.ContactId > 0)
		{
			IContact contact2 = (relationshipFilter.Contact = ContactManager.Instance.Load(grid.ContactId));
		}
		if (grid.LeadId > 0)
		{
			ILead lead2 = (relationshipFilter.Lead = LeadManager.Instance.Load(grid.LeadId));
		}
		if (grid.SaleId > 0)
		{
			ISale sale2 = (relationshipFilter.Sale = SaleManager.Instance.Load(grid.SaleId));
		}
		relationshipFilter.DisableSecurity = true;
		grid.Data = base.Manager.CreateGridData(command, relationshipFilter);
		return (ActionResult)(object)((Controller)this).PartialView((object)grid);
	}

	public ActionResult GetContractorContacts(long contractorId = 0L, long relationId = 0L)
	{
		if (contractorId == 0L)
		{
			return null;
		}
		Filter filter = new Filter
		{
			Query = "Contractor=" + contractorId
		};
		if (!ContactManager.Instance.Exists(filter))
		{
			return null;
		}
		IRelationship relationship = ((relationId != 0L) ? RelationshipManager.Instance.Load(relationId) : null);
		return (ActionResult)(object)((Controller)this).PartialView("EditorTemplates/ContractorContactList", (object)new ContractorContactListModel
		{
			ContractorContacts = ((relationship != null) ? ((IEnumerable<IContact>)relationship.ContractorsContacts).ToList() : new List<IContact>()),
			FilterQuery = filter.Query
		});
	}

	public ActionResult GetLeadContacts(long leadId = 0L, long relationId = 0L)
	{
		if (leadId == 0L)
		{
			return null;
		}
		Filter filter = new Filter
		{
			Query = "Lead=" + leadId
		};
		if (!ContactManager.Instance.Exists(filter))
		{
			return null;
		}
		IRelationship relationship = ((relationId != 0L) ? RelationshipManager.Instance.Load(relationId) : null);
		return (ActionResult)(object)((Controller)this).PartialView("EditorTemplates/LeadContactList", (object)new LeadContactListModel
		{
			LeadContacts = ((relationship != null) ? ((IEnumerable<ILeadContact>)relationship.LeadContacts).ToList() : new List<ILeadContact>()),
			FilterQuery = filter.Query
		});
	}

	public ActionResult GetContractorSales(long contractorId = 0L, long relationId = 0L, string htmlPrefix = null)
	{
		if (contractorId == 0L)
		{
			return null;
		}
		IContractor contractor = ContractorManager.Instance.Load(contractorId);
		IRelationship relationship = ((relationId != 0L) ? RelationshipManager.Instance.Load(relationId) : null);
		((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(htmlPrefix);
		return (ActionResult)(object)((Controller)this).PartialView("EditorTemplates/ContractorSale", (object)new ContractorSaleModel
		{
			Contractor = contractor,
			Sale = relationship?.Sale
		});
	}

	private ActionResult SelectPermission(IRelationship instance)
	{
		ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
		bool inheritAvailable = serviceNotNull.HasPermission(CRMPermissionProvider.CRMRelationshipIssuanceElementPermission, instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMRelationshipFullAccessPermission, instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
		Dictionary<Guid, Guid> participantWorkOne = new Dictionary<Guid, Guid>();
		Dictionary<Guid, Guid> informsOne = new Dictionary<Guid, Guid>();
		PermissionsModelService serviceNotNull2 = Locator.GetServiceNotNull<PermissionsModelService>();
		CRMPermissionModel cRMPermissionModel = new CRMPermissionModel();
		cRMPermissionModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
		Action<EntityPermissionRoleTypeSelectorModel> obj = delegate(EntityPermissionRoleTypeSelectorModel m)
		{
			m.Routes = new RouteValueDictionary(new
			{
				action = "PermissionSettings",
				controller = "Relationship",
				area = "EleWise.ELMA.CRM.Web"
			});
		};
		cRMPermissionModel.Id = instance.Id;
		cRMPermissionModel.AdditionalPermissionsModel = serviceNotNull2.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<IRelationship>(), ((Controller)this).get_Url(), delegate(IInstanceSettingsPermissionHolder h)
		{
			if (h is IRelationshipPersonPermission relationshipPersonPermission2 && relationshipPersonPermission2.User == null && relationshipPersonPermission2.Group == null && relationshipPersonPermission2.OrganizationItemPosition == null && relationshipPersonPermission2.OrganizationItemEmployee == null)
			{
				return false;
			}
			if (!(h is IRelationshipPersonPermission) || ((IRelationshipPersonPermission)h).Relationship != instance || ((IRelationshipPersonPermission)h).InheritedFromNumber.HasValue)
			{
				return false;
			}
			if (h.TypeRoleId == CommonRoleTypes.ParticipantWork.Id)
			{
				if (!participantWorkOne.ContainsKey(h.PermissionId))
				{
					participantWorkOne.Add(h.PermissionId, h.PermissionId);
					return true;
				}
				return false;
			}
			if (h.TypeRoleId == CommonRoleTypes.Informs.Id)
			{
				if (!informsOne.ContainsKey(h.PermissionId))
				{
					informsOne.Add(h.PermissionId, h.PermissionId);
					return true;
				}
				return false;
			}
			return true;
		});
		if (cRMPermissionModel.LockEditPermission)
		{
			cRMPermissionModel.AdditionalPermissionsModel.Edit = false;
		}
		cRMPermissionModel.AdditionalPermissionsModel.Instance = instance;
		cRMPermissionModel.AdditionalPermissionsModel.BindModelName = "additionalPermissions";
		cRMPermissionModel.AdditionalPermissionsModel.NoForm = false;
		obj(cRMPermissionModel.AdditionalPermissionsModel);
		cRMPermissionModel.InheritAvailable = inheritAvailable;
		participantWorkOne = new Dictionary<Guid, Guid>();
		informsOne = new Dictionary<Guid, Guid>();
		cRMPermissionModel.InheritPermissions = instance.InheritPermissions;
		cRMPermissionModel.InheritPermissionsModel = serviceNotNull2.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<IRelationship>(), ((Controller)this).get_Url(), delegate(IInstanceSettingsPermissionHolder h)
		{
			if (h is IRelationshipPersonPermission relationshipPersonPermission && relationshipPersonPermission.User == null && relationshipPersonPermission.Group == null && relationshipPersonPermission.OrganizationItemPosition == null && relationshipPersonPermission.OrganizationItemEmployee == null)
			{
				return false;
			}
			if (!(h is IRelationshipPersonPermission) || ((IRelationshipPersonPermission)h).Relationship != instance || !((IRelationshipPersonPermission)h).InheritedFromNumber.HasValue)
			{
				return false;
			}
			if (h.TypeRoleId == CommonRoleTypes.ParticipantWork.Id)
			{
				if (!participantWorkOne.ContainsKey(h.PermissionId))
				{
					participantWorkOne.Add(h.PermissionId, h.PermissionId);
					return true;
				}
				return false;
			}
			if (h.TypeRoleId == CommonRoleTypes.Informs.Id)
			{
				if (!informsOne.ContainsKey(h.PermissionId))
				{
					informsOne.Add(h.PermissionId, h.PermissionId);
					return true;
				}
				return false;
			}
			return true;
		});
		cRMPermissionModel.InheritPermissionsModel.BindModelName = "InheritPermissions";
		cRMPermissionModel.InheritPermissionsModel.Instance = instance;
		cRMPermissionModel.InheritPermissionsModel.Edit = false;
		return (ActionResult)(object)((Controller)this).PartialView("Relationship/RelationshipPermissionSetting", (object)cRMPermissionModel);
	}

	[HttpPost]
	public ActionResult EnableInheritPermission(IRelationship instance, bool enable)
	{
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { instance.Id });
		}
		RelationshipManager.Instance.EnableInheritPermissions(instance, enable);
		return SelectPermission(instance);
	}

	public ActionResult GetPermissionSettings(IRelationship instance)
	{
		return PermissionSettings(instance);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult PermissionSettings(long id, EditableListModel additionalPermissions)
	{
		IRelationship instance = RelationshipManager.Instance.Load(id);
		if (ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("Details", (object)new { instance.Id });
		}
		EleWise.ELMA.Security.Models.IUser systemUser = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
		if (additionalPermissions != null)
		{
			Locator.GetServiceNotNull<PermissionsModelService>().BindPermissionsFromModel(instance, additionalPermissions, delegate(ICollection<IInstanceSettingsPermissionHolder> holders, IEnumerable<IInstanceSettingsPermissionHolder> newHolders)
			{
				List<IInstanceSettingsPermissionHolder> list = newHolders.Where((IInstanceSettingsPermissionHolder e) => e.TypeRoleId != CommonRoleTypes.ParticipantWork.Id && e.TypeRoleId != CommonRoleTypes.Informs.Id).ToList();
				foreach (IInstanceSettingsPermissionHolder item3 in newHolders.Where((IInstanceSettingsPermissionHolder e) => e.TypeRoleId == CommonRoleTypes.ParticipantWork.Id))
				{
					if (instance.RelationshipUsers != null)
					{
						list.Add(new InstanceSettingsPermissionHolder
						{
							Assigned = systemUser,
							PermissionId = item3.PermissionId,
							Target = item3.Target,
							TypeRoleId = item3.TypeRoleId
						});
						foreach (IRelationshipUser item4 in ((IEnumerable<IRelationshipUser>)instance.RelationshipUsers).Where((IRelationshipUser a) => a.Status == RelationshipUserStatus.Participant))
						{
							InstanceSettingsPermissionHolder item = new InstanceSettingsPermissionHolder
							{
								Assigned = item4.User,
								PermissionId = item3.PermissionId,
								Target = item3.Target,
								TypeRoleId = item3.TypeRoleId
							};
							list.Add(item);
						}
					}
				}
				foreach (IInstanceSettingsPermissionHolder item5 in newHolders.Where((IInstanceSettingsPermissionHolder e) => e.TypeRoleId == CommonRoleTypes.Informs.Id))
				{
					if (item5 != null && instance.RelationshipUsers != null)
					{
						list.Add(new InstanceSettingsPermissionHolder
						{
							Assigned = systemUser,
							PermissionId = item5.PermissionId,
							Target = item5.Target,
							TypeRoleId = item5.TypeRoleId
						});
						foreach (IRelationshipUser item6 in ((IEnumerable<IRelationshipUser>)instance.RelationshipUsers).Where((IRelationshipUser a) => a.Status == RelationshipUserStatus.InfromTo))
						{
							InstanceSettingsPermissionHolder item2 = new InstanceSettingsPermissionHolder
							{
								Assigned = item6.User,
								PermissionId = item5.PermissionId,
								Target = item5.Target,
								TypeRoleId = item5.TypeRoleId
							};
							list.Add(item2);
						}
					}
				}
				List<IInstanceSettingsPermissionHolder> list2 = new List<IInstanceSettingsPermissionHolder>();
				if (instance.InheritPermissions)
				{
					list2.AddRange(holders.Where((IInstanceSettingsPermissionHolder h) => ((IRelationshipPersonPermission)h).InheritedFromNumber.HasValue));
					foreach (IInstanceSettingsPermissionHolder item7 in list2)
					{
						holders.Remove(item7);
					}
				}
				holders.SyncFrom(list, (IInstanceSettingsPermissionHolder v1, IInstanceSettingsPermissionHolder v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals(v1.Assigned, v2.Assigned), null, delegate(IInstanceSettingsPermissionHolder v)
				{
					if (v is IEntity)
					{
						((IEntity)v).Delete();
					}
				});
				if (instance.InheritPermissions)
				{
					foreach (IInstanceSettingsPermissionHolder item8 in list2)
					{
						holders.Add(item8);
					}
				}
			});
		}
		string text = ((Controller)this).get_Url().ReturnUrl();
		if (instance.CastAsRealType() != null)
		{
			text = ((Controller)this).get_Url().ReturnUrl(redirectHomeIfNull: false, "Access");
		}
		return (ActionResult)(object)((Controller)this).Redirect(text);
	}

	public ActionResult PermissionSettings(IRelationship instance)
	{
		return SelectPermission(instance);
	}
}
