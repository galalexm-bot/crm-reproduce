using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Common;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Linq.Expressions;
using System.Security;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
    [RouteArea("EleWise.ELMA.CRM.Web")]
    public class BankDetailsSWIFTController : BPMController<IBankDetailsSWIFT, long>
    {
        [EntityForm("Create", "EleWise.ELMA.CRM.Web")]
        public ActionResult CreatePopup([ParameterContainer] IBankDetailsSWIFT bankDetailsSwift, Guid? formUid = null, EleWise.ELMA.Model.Views.ViewType? viewType = null, bool formReadOnly = false, string parentFormId = "", string formId = "")
        {
            ICatalogProfile target = CatalogManager.Instance.LoadByCatalog(InterfaceActivator.UID<IBankDetailsSWIFT>(loadImplementation: false));
            if (!base.SecurityService.HasPermission(PermissionProvider.CatalogAddPermission, target))
            {
                throw new SecurityException(SR.T("Недостаточно прав для создания реквизита."));
            }
            BankDetailsSWIFTModel bankDetailsSWIFTModel = new BankDetailsSWIFTModel(bankDetailsSwift, viewType ?? EleWise.ELMA.Model.Views.ViewType.Create)
            {
                FormUid = formUid,
                FormReadOnly = formReadOnly,
                FormId = formId
            };
            bankDetailsSWIFTModel.DynamicFormSettings.ParentFormId = parentFormId;
            DynamicFormSettings dynamicFormSettings = bankDetailsSWIFTModel.DynamicFormSettings;
            dynamicFormSettings.ViewItemId = dynamicFormSettings.ViewItemId + ";" + bankDetailsSWIFTModel.View.Uid;
            return PartialView("BankDetailsSWIFTEditForm", bankDetailsSWIFTModel);
        }

        [HttpPost]
        public ActionResult Create(BankDetailsSWIFTModel model)
        {
            ICatalogProfile target = CatalogManager.Instance.LoadByCatalog(InterfaceActivator.UID<IBankDetailsSWIFT>(loadImplementation: false));
            if (!base.SecurityService.HasPermission(PermissionProvider.CatalogAddPermission, target))
            {
                throw new SecurityException(SR.T("Недостаточно прав для создания реквизита."));
            }
            base.Manager.Save(model.Entity);
            if (IsCustomViewRequest())
            {
                return HandleCustomViewJsonCallback(model.Entity);
            }
            return CreatorJson(model.Entity);
        }

        [AsyncViewItemAction]
        public ActionResult AsyncViewItem(Guid viewItemUid, long id, EleWise.ELMA.Model.Views.ViewType viewType, Guid? formUid)
        {
            BankDetailsSWIFTModel bankDetailsSWIFTModel = new BankDetailsSWIFTModel(base.Manager.LoadOrCreate(id), viewType);
            bankDetailsSWIFTModel.FormUid = formUid;
            return AsyncViewItemView(bankDetailsSWIFTModel.View, viewType, viewItemUid, bankDetailsSWIFTModel, (BankDetailsSWIFTModel m) => m.Entity);
        }
    }
}
