// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.ContractorController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Binders;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using EleWise.ELMA.Web.Mvc.Models.Selectors;
using EleWise.ELMA.Web.Mvc.Security;
using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Web.Mvc;
using System.Web.Routing;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
    [RouteArea("EleWise.ELMA.CRM.Web")]
    public class ContractorController : FilterTreeBaseController<IContractor, long>
    {
        public IUnionComplexCacheService ComplexCacheService { get; set; }

        [ContentItem(Name = "SR.M('Контрагенты')", Image24 = "#contractors.svg")]
        [FilterMenuItem(Id = "crm-contractors", Type = typeof(IContractor), FilterEditAction = "EditFilters")]
        public ActionResult Index(long? FilterId = null) => this.BaseIndex(FilterId, nameof(FilterId), nameof(Index), new Guid?()) ?? View((object)this.CreateGridData((GridCommand)null, this.CreateFilter(FilterId, new Guid?(), (IEntityFilter)null, (EleWise.ELMA.Web.Mvc.Models.Grids.GridState)null, "Filter")));

        public ActionResult Search(long? FilterId = null)
        {
            if (base.Request.QueryString.Count == 0)
            {
                return RedirectToAction("Index");
            }
            FilterModel filter = CreateFilter(FilterId);
            GridDataFilter<IContractor> model = CreateGridData(null, filter);
            return View("Index", model);
        }

        [DetailsAction]
        [EntityLink]
        public ActionResult Details(long id)
        {
            IContractor contractor = ContractorManager.Instance.Load(id);
            ThrowExceptionIfDeleted(contractor);
            string text = base.Url.Entity(contractor);
            if (base.Request.RawUrl == text)
            {
                return RedirectToAction("ViewItem", "Catalogs", new
                {
                    area = "EleWise.ELMA.BPM.Web.Common",
                    uid = contractor.TypeUid,
                    id = id
                });
            }
            return Redirect(text);
        }

        [HttpGet]
        [Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
        public ActionResult Delete(long[] contractorsId, string popupId)
        {
            List<IContractor> list = ((IEnumerable<long>)contractorsId).Select<long, IContractor>((Func<long, IContractor>)(id => ContractorManager.Instance.Load(id))).ToList<IContractor>();
            if (contractorsId.Length == 0)
                return RedirectToAction("Index", "Contractor");
            return PartialView("DeleteGroup", (object)new GroupContractorInfo()
            {
                Contractors = (IList<IContractor>)list,
                PopupId = popupId
            });
        }

        [HttpPost]
        [Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
        [TransactionAction]
        public ActionResult Delete(GroupContractorInfo contactsInfo)
        {
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
            {
                // ISSUE: explicit non-virtual call
                Notifier.Information(EleWise.ELMA.SR.T("Производится перерасчет разрешений. Изменение заблокировано. Пожалуйста попробуйте позже."));
                return RedirectToAction("Index", "Contractor");
            }
            int count = contactsInfo.Contractors.Count;
            contactsInfo.Contractors.ForEach<IContractor>((Action<IContractor>)(m => ContractorManager.Instance.Load(m.Id).Delete()));
            // ISSUE: explicit non-virtual call
            Notifier.Information(EleWise.ELMA.SR.T("Удалено {0} контрагентов", (object)count));
            return RedirectToAction("Index", "Contractor");
        }

        public JsonResult Select(
          string text,
          int max = 100,
          string filterProviderUid = null,
          string filterProviderData = null)
        {
            IContractorFilter filter = InterfaceActivator.Create<IContractorFilter>();
            filter.SearchString = text;
            if (!string.IsNullOrEmpty(filterProviderUid))
            {
                Guid uid = new Guid(filterProviderUid);
                ComponentManager.Current.GetExtensionPoints<IEntityFilterProvider>().First<IEntityFilterProvider>((Func<IEntityFilterProvider, bool>)(p => p.ProviderUid == uid)).ApplyFilter((IEntityFilter)filter, filterProviderData);
            }
            AutoCompleteContractorItem[] items = AutoCompleteContractorItem.GetItems((IEnumerable<IContractor>)base.Manager.Find((IEntityFilter)filter, new FetchOptions(0, max, LinqUtils.NameOf<IContractor>((Expression<Func<IContractor, object>>)(u => u.Name)))));
            return new JsonResult()
            {
                Data = (object)items,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        public static object CreateEntitySelectRouteValues(ViewAttributes viewAttributes) => ContractorController.CreateEntitySelectRouteValues(viewAttributes.EntityFilterProvider != Guid.Empty ? viewAttributes.EntityFilterProvider.ToString() : (string)null, viewAttributes.EntityFilterData);

        public static dynamic CreateEntitySelectRouteValues(string filterProviderUid, string filterProviderData)
        {
            dynamic val = new ExpandoObject();
            val.area = "EleWise.ELMA.CRM.Web";
            if (!string.IsNullOrEmpty(filterProviderUid))
            {
                val.filterProviderUid = filterProviderUid;
                val.filterProviderData = filterProviderData;
            }
            return val;
        }
        public ActionResult PopupEntity(
        string inputId,
        [JsonBinder] ICollection<SelectListItem> selected,
        bool multiselect,
        string filterProviderUid = null,
        string filterProviderData = null)
        {
            if (string.IsNullOrEmpty(inputId))
                throw new ArgumentNullException(nameof(inputId));
            IContractorFilter filter = InterfaceActivator.Create<IContractorFilter>();
            if (!string.IsNullOrEmpty(filterProviderUid))
            {
                Guid uid = new Guid(filterProviderUid);
                ComponentManager.Current.GetExtensionPoints<IEntityFilterProvider>().First<IEntityFilterProvider>((Func<IEntityFilterProvider, bool>)(p => p.ProviderUid == uid)).ApplyFilter((IEntityFilter)filter, filterProviderData);
            }
            ICollection<IContractor> source = base.Manager.Find((IEntityFilter)filter, FetchOptions.All);
            EntityPopupSelectorModel model = new EntityPopupSelectorModel()
            {
                InputId = inputId,
                SelectedItems = selected != null ? (IList<SelectListItem>)selected.ToList<SelectListItem>() : (IList<SelectListItem>)new List<SelectListItem>(),
                MultiSelect = multiselect,
                AvalibleItems = (IList<SelectListItem>)source.Select<IContractor, SelectListItem>((Func<IContractor, SelectListItem>)(i => new SelectListItem()
                {
                    Value = i.GetId().ToString(),
                    Text = i.ToString()
                })).Where<SelectListItem>((Func<SelectListItem, bool>)(i => !string.IsNullOrEmpty(i.Text))).ToList<SelectListItem>()
            };
            if (model.SelectedItems.Any<SelectListItem>())
            {
                if (multiselect)
                    model.AvalibleItems = (IList<SelectListItem>)model.AvalibleItems.Where<SelectListItem>((Func<SelectListItem, bool>)(a => !model.SelectedItems.Any<SelectListItem>((Func<SelectListItem, bool>)(s => s.Value == a.Value)))).ToList<SelectListItem>();
                else
                    model.AvalibleItems.First<SelectListItem>((Func<SelectListItem, bool>)(a => a.Value == model.SelectedItems.First<SelectListItem>().Value)).Selected = true;
            }
            model.AvalibleItems = (IList<SelectListItem>)model.AvalibleItems.OrderBy<SelectListItem, string>((Func<SelectListItem, string>)(i => i.Text)).ToList<SelectListItem>();
            return PartialView("EditorTemplates/Entities/PopupEntity", (object)model);
        }

        protected virtual string GridIdPrefix => "ContractorsGrid";

        protected virtual bool EnableEqlQuery => true;

        private ActionResult SelectPermission(IContractor instance)
        {
            ISecurityService serviceNotNull = Locator.GetServiceNotNull<ISecurityService>();
            bool inheritAvailable = serviceNotNull.HasPermission(CRMPermissionProvider.CRMContractorIssuanceElementPermission, instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMContractorFullAccessPermission, instance) || serviceNotNull.HasPermission(CRMPermissionProvider.CRMFullAccessPermission);
            CRMPermissionModel cRMPermissionModel = new CRMPermissionModel();
            cRMPermissionModel.LockEditPermission = ComplexCacheService.GetOrAdd("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", () => new CachePermissionModel(blocking: false)).Blocking;
            Action<EntityPermissionRoleTypeSelectorModel> obj = delegate (EntityPermissionRoleTypeSelectorModel m)
            {
                m.Routes = new RouteValueDictionary(new
                {
                    action = "PermissionSettings",
                    controller = "Contractor",
                    area = "EleWise.ELMA.CRM.Web"
                });
            };
            cRMPermissionModel.Id = instance.Id;
            Dictionary<Guid, Guid> participantWorkOne = new Dictionary<Guid, Guid>();
            Dictionary<Guid, Guid> InformsOne = new Dictionary<Guid, Guid>();
            cRMPermissionModel.AdditionalPermissionsModel = base.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<IContractor>(), base.Url, delegate (IInstanceSettingsPermissionHolder h)
            {
                if (h is IContractorPersonPermission contractorPersonPermission2 && contractorPersonPermission2.User == null && contractorPersonPermission2.Group == null && contractorPersonPermission2.OrganizationItemPosition == null && contractorPersonPermission2.OrganizationItemEmployee == null)
                {
                    return false;
                }
                if (!(h is IContractorPersonPermission) || ((IContractorPersonPermission)h).Contractor != instance || ((IContractorPersonPermission)h).InheritedFromNumber.HasValue)
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
                    if (!InformsOne.ContainsKey(h.PermissionId))
                    {
                        InformsOne.Add(h.PermissionId, h.PermissionId);
                        return true;
                    }
                    return false;
                }
                return true;
            });
            cRMPermissionModel.AdditionalPermissionsModel.Instance = instance;
            if (cRMPermissionModel.LockEditPermission)
            {
                cRMPermissionModel.AdditionalPermissionsModel.Edit = false;
            }
            obj(cRMPermissionModel.AdditionalPermissionsModel);
            participantWorkOne = new Dictionary<Guid, Guid>();
            InformsOne = new Dictionary<Guid, Guid>();
            cRMPermissionModel.InheritAvailable = inheritAvailable;
            cRMPermissionModel.InheritPermissions = instance.InheritPermissions;
            cRMPermissionModel.InheritPermissionsModel = base.PermissionsModelService.GetEntityPermissionRoleTypeSelectorModel(instance, InterfaceActivator.TypeOf<IContractor>(), base.Url, delegate (IInstanceSettingsPermissionHolder h)
            {
                if (h is IContractorPersonPermission contractorPersonPermission && contractorPersonPermission.User == null && contractorPersonPermission.Group == null && contractorPersonPermission.OrganizationItemPosition == null && contractorPersonPermission.OrganizationItemEmployee == null)
                {
                    return false;
                }
                if (!(h is IContractorPersonPermission) || ((IContractorPersonPermission)h).Contractor != instance || !((IContractorPersonPermission)h).InheritedFromNumber.HasValue)
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
                    if (!InformsOne.ContainsKey(h.PermissionId))
                    {
                        InformsOne.Add(h.PermissionId, h.PermissionId);
                        return true;
                    }
                    return false;
                }
                return true;
            });
            cRMPermissionModel.InheritPermissionsModel.BindModelName = "InheritPermissions";
            cRMPermissionModel.InheritPermissionsModel.Instance = instance;
            cRMPermissionModel.InheritPermissionsModel.Edit = false;
            return PartialView("Contractor/ContractorPermissionSetting", cRMPermissionModel);
        }

        [HttpPost]
        public ActionResult EnableInheritPermission(IContractor instance, bool enable)
        {
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
                return RedirectToAction("Details", (object)new
                {
                    Id = instance.Id
                });
            ContractorManager.Instance.EnableInheritPermissions(instance, enable);
            return this.SelectPermission(instance);
        }

        public ActionResult GetPermissionSettings(IContractor instance) => this.PermissionSettings(instance);

        [HttpPost]
        [TransactionAction]
        public ActionResult PermissionSettings(long id, EditableListModel access)
        {
            IContractor instance = ContractorManager.Instance.Load(id);
            if (this.ComplexCacheService.GetOrAdd<CachePermissionModel>("A0EEA553-0D17-4a09-A1A3-8BD23C38FA8E", "LockNameReroutePermissionTimestamp", (Func<CachePermissionModel>)(() => new CachePermissionModel(false))).Blocking)
                return RedirectToAction("Details", (object)new
                {
                    Id = instance.Id
                });
            EleWise.ELMA.Security.Models.IUser systemUser = UserManager.Instance.Load(SecurityConstants.SystemUserUid);
            IContractor instanceContractor = instance;
            if (access != null && instanceContractor != null)
                this.PermissionsModelService.BindPermissionsFromModel((object)instanceContractor, access, (Action<ICollection<IInstanceSettingsPermissionHolder>, IEnumerable<IInstanceSettingsPermissionHolder>>)((holders, newHolders) =>
              {
                  List<IInstanceSettingsPermissionHolder> list = newHolders.Where<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(e => e.TypeRoleId != CommonRoleTypes.ParticipantWork.Id && e.TypeRoleId != CommonRoleTypes.Informs.Id)).ToList<IInstanceSettingsPermissionHolder>();
                  foreach (IInstanceSettingsPermissionHolder permissionHolder1 in newHolders.Where<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(e => e.TypeRoleId == CommonRoleTypes.ParticipantWork.Id)))
                  {
                      if (instance.ParticipantWork != null)
                      {
                          list.Add((IInstanceSettingsPermissionHolder)new InstanceSettingsPermissionHolder()
                          {
                              Assigned = (IEntity)systemUser,
                              PermissionId = permissionHolder1.PermissionId,
                              Target = permissionHolder1.Target,
                              TypeRoleId = permissionHolder1.TypeRoleId
                          });
                          if (instance.ParticipantWork.Count > 0)
                          {
                              foreach (EleWise.ELMA.Security.Models.IUser user in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)instance.ParticipantWork)
                              {
                                  InstanceSettingsPermissionHolder permissionHolder2 = new InstanceSettingsPermissionHolder()
                                  {
                                      Assigned = (IEntity)user,
                                      PermissionId = permissionHolder1.PermissionId,
                                      Target = permissionHolder1.Target,
                                      TypeRoleId = permissionHolder1.TypeRoleId
                                  };
                                  list.Add((IInstanceSettingsPermissionHolder)permissionHolder2);
                              }
                          }
                      }
                  }
                  foreach (IInstanceSettingsPermissionHolder permissionHolder3 in newHolders.Where<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(e => e.TypeRoleId == CommonRoleTypes.Informs.Id)))
                  {
                      if (permissionHolder3 != null && instance.Informs != null)
                      {
                          list.Add((IInstanceSettingsPermissionHolder)new InstanceSettingsPermissionHolder()
                          {
                              Assigned = (IEntity)systemUser,
                              PermissionId = permissionHolder3.PermissionId,
                              Target = permissionHolder3.Target,
                              TypeRoleId = permissionHolder3.TypeRoleId
                          });
                          foreach (EleWise.ELMA.Security.Models.IUser inform in (IEnumerable<EleWise.ELMA.Security.Models.IUser>)instance.Informs)
                          {
                              InstanceSettingsPermissionHolder permissionHolder4 = new InstanceSettingsPermissionHolder()
                              {
                                  Assigned = (IEntity)inform,
                                  PermissionId = permissionHolder3.PermissionId,
                                  Target = permissionHolder3.Target,
                                  TypeRoleId = permissionHolder3.TypeRoleId
                              };
                              list.Add((IInstanceSettingsPermissionHolder)permissionHolder4);
                          }
                      }
                  }
                  List<IInstanceSettingsPermissionHolder> permissionHolderList = new List<IInstanceSettingsPermissionHolder>();
                  if (instanceContractor.InheritPermissions)
                  {
                      permissionHolderList.AddRange(holders.Where<IInstanceSettingsPermissionHolder>((Func<IInstanceSettingsPermissionHolder, bool>)(h => ((IContractorPersonPermission)h).InheritedFromNumber.HasValue)));
                      foreach (IInstanceSettingsPermissionHolder permissionHolder in permissionHolderList)
                          holders.Remove(permissionHolder);
                  }
                  holders.SyncFrom<IInstanceSettingsPermissionHolder>((IEnumerable<IInstanceSettingsPermissionHolder>)list, (Func<IInstanceSettingsPermissionHolder, IInstanceSettingsPermissionHolder, bool>)((v1, v2) => v1.TypeRoleId == v2.TypeRoleId && v1.PermissionId == v2.PermissionId && object.Equals((object)v1.Assigned, (object)v2.Assigned)), onRemove: ((Action<IInstanceSettingsPermissionHolder>)(v =>
       {
           if (!(v is IEntity))
               return;
           ((IEntity)v).Delete();
       })));
                  if (!instanceContractor.InheritPermissions)
                      return;
                  foreach (IInstanceSettingsPermissionHolder permissionHolder in permissionHolderList)
                      holders.Add(permissionHolder);
              }));
            return Redirect(((Controller)this).Url.ReturnUrl());
        }

        public ActionResult PermissionSettings(IContractor instance) => this.SelectPermission(instance);
    }
}
