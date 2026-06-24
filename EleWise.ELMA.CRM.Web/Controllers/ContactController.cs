using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.CRM.Components;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security;
using System.Web.Mvc;
using System.Web.Routing;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
    [RouteArea("EleWise.ELMA.CRM.Web")]
    public class ContactController : FilterTreeBaseController<IContact, long>
    {
        public const string DataFilterPrefix = "DataFilter";
        private ICountry defaultCountry = Locator.GetService<CrmSettingsModule>().Settings.DefaultCountry;

        public IUnionComplexCacheService ComplexCacheService { get; set; }

        [ContentItem(Name = "SR.M('Контакты')", Image24 = "#contact.svg")]
        [FilterMenuItem(Id = "crm-contacts", Type = typeof(IContact), FilterEditAction = "EditFilters")]
        public ActionResult Index(long? FilterId = null) => this.BaseIndex(FilterId, nameof(FilterId), nameof(Index), new Guid?()) ?? View((object)this.CreateGridData((GridCommand)null, this.CreateFilter(FilterId, new Guid?(), (IEntityFilter)null, (EleWise.ELMA.Web.Mvc.Models.Grids.GridState)null, "Filter")));

        public ActionResult Search(long? FilterId = null)
        {
            if (base.Request.QueryString.Count == 0)
            {
                return RedirectToAction("Index");
            }
            FilterModel filter = CreateFilter(FilterId);
            GridDataFilter<IContact> model = CreateGridData(null, filter);
            return View("Index", model);
        }

        [CustomGridAction]
        public ActionResult GridTable(
          GridCommand command,
          CustomGridCommand customCommand,
          ContactGrid grid)
        {
            IContactFilter filter = InterfaceActivator.Create<IContactFilter>();
            if (grid.ContractorId > 0L)
            {
                IContractor contractor = ContractorManager.Instance.Load(grid.ContractorId);
                filter.Contractor = contractor;
            }
            // ISSUE: explicit non-virtual call
            grid.Data = base.Manager.CreateGridData<IContact, IContactFilter>(command, filter);
            return PartialView((object)grid);
        }

        public static void InitNewModel(ContactModel model) => ContactController.InitNewModel(model, true);

        private static void InitNewModel(ContactModel model, bool contactWasNull)
        {
            if (!contactWasNull)
                return;
            model.Entity.Email.Add(InterfaceActivator.Create<IEmail>());
            model.Entity.Phone.Add(InterfaceActivator.Create<IPhone>());
        }

        [EntityForm("Create", "EleWise.ELMA.CRM.Web")]
        [Permission("{6ED5408C-9BB5-4EA5-950A-D6047957D8DE}")]
        public ActionResult CreatePopup(
          [ParameterContainer] IContact contact,
          Guid? formUid = null,
          EleWise.ELMA.Model.Views.ViewType? viewType = null,
          bool formReadOnly = false,
          string parentFormId = "",
          string formId = "")
        {
            ContactModel contactModel = new ContactModel(contact, viewType.HasValue ? viewType.Value : EleWise.ELMA.Model.Views.ViewType.Create);
            contactModel.FormUid = formUid;
            contactModel.FormId = formId;
            contactModel.FormReadOnly = formReadOnly;
            ContactModel model = contactModel;
            model.DynamicFormSettings.ParentFormId = parentFormId;
            DynamicFormSettings dynamicFormSettings = model.DynamicFormSettings;
            dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + (object)model.View.Uid;
            ContactController.InitNewModel(model, contact == null);
            return PartialView("Contact/ContactEditForm", (object)model);
        }

        [ContactCreate]
        [ContentItem(Name = "SR.M('Создать контакт')", Image24 = "#add.svg")]
        [Permission("{6ED5408C-9BB5-4EA5-950A-D6047957D8DE}")]
        public ActionResult Create(long ContractorId = 0)
        {
            ContactModel model = new ContactModel();
            ContactController.InitNewModel(model);
            model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            if (model.LockEditPermission)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(EleWise.ELMA.SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
                return RedirectToAction("Index", "Contact", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }
            if (this.defaultCountry != null)
            {
                IAddress address1 = EntityManager<IAddress>.Instance.Create();
                address1.Country = this.defaultCountry;
                model.Entity.RegistrationAddress = address1;
                IAddress address2 = EntityManager<IAddress>.Instance.Create();
                address2.Country = this.defaultCountry;
                model.Entity.ResidenceAddress = address2;
            }
            if (ContractorId > 0L)
                model.Entity.Contractor = ContractorManager.Instance.Load(ContractorId);
            return View((object)model);
        }

        [HttpPost]
        [Permission("{6ED5408C-9BB5-4EA5-950A-D6047957D8DE}")]
        public ActionResult Create(ContactModel model)
        {
            try
            {
                model.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
                if (model.LockEditPermission)
                {
                    return RedirectToAction("Details", new { model.Entity.Id });
                }
                model.Save();
                string text = base.Url.Entity(model.Entity);
                base.Notifier.Information(MvcHtmlString.Create(SR.T("Контакт <a href=\"{1}\">{0}</a> сохранен успешно", model.Entity.Name.HtmlEncode(), text)));
                if (IsCustomViewRequest())
                {
                    return HandleCustomViewJsonCallback(model.Entity);
                }
                return (!IsCreatorRequest()) ? RedirectToAction("Details", new
                {
                    id = model.Entity.Id
                }) : CreatorJson(model.Entity);
            }
            catch (Exception ex)
            {
                base.Notifier.Error(ex);
                return (!IsCreatorRequest()) ? View(model) : CreatorJson(null, ex.Message);
            }
        }

        [DetailsAction]
        [EntityLink]
        public ActionResult Details(long id, int? tabIndex = 0)
        {
            try
            {
                if (tabIndex.HasValue)
                {
                    if (DirectoryMapVirtualPathProvider.AnyConfigFile("~/Modules/EleWise.ELMA.CRM.Web/Views/Contact/TasksTab.cshtml", "~/Modules/EleWise.ELMA.CRM.Web/Views/Contact/TasksTab.cshtml"))
                        ((ControllerBase)this).ViewData["SelectedTab"] = (object)tabIndex.Value;
                }
                // ISSUE: explicit non-virtual call
                IContact contact = base.Manager.Load(id);
                ThrowExceptionIfDeleted((ISoftDeletable)contact);
                return View((object)new ContactModel(contact, EleWise.ELMA.Model.Views.ViewType.Display)
                {
                    LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking
                });
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return RedirectToAction("Index", "Contact");
            }
        }

        public ActionResult Edit(long id)
        {
            try
            {
                IContact contact = base.Manager.Load(id);
                ThrowExceptionIfDeleted(contact);
                ContactModel contactModel = new ContactModel(contact, EleWise.ELMA.Model.Views.ViewType.Edit);
                if (!base.SecurityService.HasPermission(CRMPermissionProvider.EditContactPermission, contact))
                {
                    throw new SecurityException(SR.T("Недостаточно прав для редактирования контакта \"{0}\" с идентификатором {1}", contact.Name, contact.Id));
                }
                contactModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
                if (contactModel.LockEditPermission)
                {
                    return RedirectToAction("Details", new { id });
                }
                return View(contactModel);
            }
            catch (Exception exception)
            {
                base.Notifier.Error(exception);
                return RedirectToAction("Index", "Contact");
            }
        }

        [HttpPost]
        public ActionResult Edit(ContactModel model)
        {
            try
            {
                model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
                if (model.LockEditPermission)
                    return RedirectToAction("Details", (object)new
                    {
                        Id = model.Entity.Id
                    });
                model.Save();
                string str = ((Controller)this).Url.Entity((IEntity)model.Entity);
                // ISSUE: explicit non-virtual call
                Notifier.Information(MvcHtmlString.Create(EleWise.ELMA.SR.T("Контакт <a href=\"{3}\">{0} {1} {2}</a> сохранен успешно", (object)model.Entity.Firstname.HtmlEncode(), (object)model.Entity.Surname.HtmlEncode(), (object)model.Entity.Middlename.HtmlEncode(), (object)str)));
                return RedirectToAction("Details", (object)new
                {
                    id = model.Entity.Id
                });
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return View((object)model);
            }
        }

        [AsyncViewItemAction]
        public ActionResult AsyncViewItem(Guid viewItemUid, long id, EleWise.ELMA.Model.Views.ViewType viewType, Guid? formUid)
        {
            // ISSUE: explicit non-virtual call
            ContactModel originalModel = new ContactModel(base.Manager.LoadOrCreate(id), viewType);
            originalModel.FormUid = formUid;
            return AsyncViewItemView<ContactModel>(originalModel.View, viewType, viewItemUid, originalModel, (Expression<Func<ContactModel, object>>)(m => m.Entity));
        }

        [HttpGet]
        [Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
        public ActionResult Delete(long id)
        {
            try
            {
                // ISSUE: explicit non-virtual call
                IContact contact = base.Manager.Load(id);
                // ISSUE: explicit non-virtual call
                base.Manager.Delete(contact);
                // ISSUE: explicit non-virtual call
                Notifier.Information(EleWise.ELMA.SR.T("Контакт \"{0} {1} {2}\" удален", (object)contact.Firstname, (object)contact.Surname, (object)contact.Middlename));
                return RedirectToAction("Index", "Contact", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }
            catch (Exception ex)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Error(ex);
                return RedirectToAction("Index", "Contact", (object)new
                {
                    area = "EleWise.ELMA.CRM.Web"
                });
            }
        }

        [HttpGet]
        [Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
        public ActionResult DeleteGroup(long[] contactsId, string popupId)
        {
            List<IContact> list = ((IEnumerable<long>)contactsId).Select<long, IContact>((Func<long, IContact>)(id => ContactManager.Instance.Load(id))).ToList<IContact>();
            if (contactsId.Length == 0)
                return RedirectToAction("Index", "Contact");
            return PartialView((object)new GroupContactInfo()
            {
                Contacts = (IList<IContact>)list,
                PopupId = popupId
            });
        }

        [HttpPost]
        [Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
        public ActionResult DeleteGroup(GroupContactInfo contactsInfo)
        {
            contactsInfo.Contacts.ForEach<IContact>((Action<IContact>)(m => ContactManager.Instance.Load(m.Id).Delete()));
            return RedirectToAction("Index", "Contact", (object)new
            {
                area = "EleWise.ELMA.CRM.Web"
            });
        }

        protected virtual string GridIdPrefix => "Contacts";

        protected virtual bool EnableEqlQuery => true;

        public ActionResult DetailsForm(long id) => PartialView((object)ContactManager.Instance.Load(id));

        private ActionResult SelectPermission(IContact instance)
        {
            ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
            bool flag = serviceNotNull.HasPermission(CRMPermissionProvider.CRMContactIssuanceElementPermission, (object)instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMContactFullAccessPermission, (object)instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
            CRMPermissionModel model = new CRMPermissionModel();
            model.LockEditPermission = this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking;
            model.Id = instance.Id;
            Dictionary<Guid, Guid> participantWorkOne = new Dictionary<Guid, Guid>();
            Dictionary<Guid, Guid> InformsOne = new Dictionary<Guid, Guid>();
            model.AdditionalPermissionsModel = this.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel((object)instance, InterfaceActivator.TypeOf<IContact>(), ((Controller)this).Url, (Func<IInstanceSettingsPermissionHolder, bool>)(h =>
         {
             if ((!(h is IContactPersonPermission) || ((IContactPersonPermission)h).Contact != instance ? 0 : (!((IContactPersonPermission)h).InheritedFromNumber.HasValue ? 1 : 0)) == 0)
                 return false;
             if (h.TypeRoleId == CommonRoleTypes.ParticipantWork.Id)
             {
                 if (participantWorkOne.ContainsKey(h.PermissionId))
                     return false;
                 participantWorkOne.Add(h.PermissionId, h.PermissionId);
                 return true;
             }
             if (!(h.TypeRoleId == CommonRoleTypes.Informs.Id))
                 return true;
             if (InformsOne.ContainsKey(h.PermissionId))
                 return false;
             InformsOne.Add(h.PermissionId, h.PermissionId);
             return true;
         }), true, (string)null);
            if (model.LockEditPermission)
                model.AdditionalPermissionsModel.Edit = false;
            model.AdditionalPermissionsModel.Instance = (object)instance;
            model.AdditionalPermissionsModel.BindModelName = "additionalPermissions";
            model.AdditionalPermissionsModel.NoForm = false;
            ((Action<EntityPermissionRoleTypeSelectorModel>)(m => m.Routes = new RouteValueDictionary((object)new
            {
                action = "PermissionSettings",
                controller = "Contact",
                area = "EleWise.ELMA.CRM.Web"
            })))(model.AdditionalPermissionsModel);
            model.InheritAvailable = true;
            model.InheritAvailable = flag;
            participantWorkOne = new Dictionary<Guid, Guid>();
            InformsOne = new Dictionary<Guid, Guid>();
            model.InheritPermissions = instance.InheritPermissions;
            model.InheritPermissionsModel = this.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel((object)instance, InterfaceActivator.TypeOf<IContact>(), ((Controller)this).Url, (Func<IInstanceSettingsPermissionHolder, bool>)(h =>
         {
             if ((!(h is IContactPersonPermission) || ((IContactPersonPermission)h).Contact != instance ? 0 : (((IContactPersonPermission)h).InheritedFromNumber.HasValue ? 1 : 0)) == 0)
                 return false;
             if (h.TypeRoleId == CommonRoleTypes.ParticipantWork.Id)
             {
                 if (participantWorkOne.ContainsKey(h.PermissionId))
                     return false;
                 participantWorkOne.Add(h.PermissionId, h.PermissionId);
                 return true;
             }
             if (!(h.TypeRoleId == CommonRoleTypes.Informs.Id))
                 return true;
             if (InformsOne.ContainsKey(h.PermissionId))
                 return false;
             InformsOne.Add(h.PermissionId, h.PermissionId);
             return true;
         }), true, (string)null);
            model.InheritPermissionsModel.BindModelName = "InheritPermissions";
            model.InheritPermissionsModel.Instance = (object)instance;
            model.InheritPermissionsModel.Edit = false;
            return PartialView("Contact/ContactPermissionSetting", (object)model);
        }

        [HttpPost]
        public ActionResult EnableInheritPermission(IContact instance, bool enable)
        {
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
                return RedirectToAction("Details", (object)new
                {
                    Id = instance.Id
                });
            ContactManager.Instance.EnableInheritPermissions(instance, enable);
            return this.SelectPermission(instance);
        }

        public ActionResult GetPermissionSettings(IContact instance) => this.PermissionSettings(instance);

        [HttpPost]
        [TransactionAction]
        public ActionResult PermissionSettings(long id, EditableListModel additionalPermissions)
        {
            IContact ContactInstance = ContactManager.Instance.Load(id);
            if (additionalPermissions != null && ContactInstance != null)
                this.PermissionsModelService.BindPermissionsFromModel((object)ContactInstance, additionalPermissions, (Action<ICollection<IInstanceSettingsPermissionHolder>, IEnumerable<IInstanceSettingsPermissionHolder>>)((holders, newHolders) =>
              {
                  List<IInstanceSettingsPermissionHolder> permissionHolderList = new List<IInstanceSettingsPermissionHolder>();
                  if (ContactInstance.InheritPermissions)
                  {
                      permissionHolderList.AddRange(holders.Where<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(h => ((IContactPersonPermission)h).InheritedFromNumber.HasValue)));
                      foreach (IInstanceSettingsPermissionHolder permissionHolder in permissionHolderList)
                          holders.Remove(permissionHolder);
                  }
                  holders.SyncFrom<IInstanceSettingsPermissionHolder>(newHolders, (Func<IInstanceSettingsPermissionHolder, IInstanceSettingsPermissionHolder, bool>)((v1, v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals((object)v1.Assigned, (object)v2.Assigned)), onRemove: ((Action<IInstanceSettingsPermissionHolder>)(v =>
        {
                    if (!(v is IEntity))
                        return;
                    ((IEntity)v).Delete();
                })));
                  if (!ContactInstance.InheritPermissions)
                      return;
                  foreach (IInstanceSettingsPermissionHolder permissionHolder in permissionHolderList)
                      holders.Add(permissionHolder);
              }));
            return Redirect(((Controller)this).Url.ReturnUrl());
        }

        public ActionResult PermissionSettings(IContact instance) => this.SelectPermission(instance);
    }
}
