using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Linq.Expressions;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
    public class BankAccountController : BPMController<IBankAccount, long>
    {
        public ActionResult PopupCreateBankAccount(string popupId, string prefix, string callbackFunc) => PartialView("PopupBankAccount", (object)new BankAccountModel()
        {
            DefaultFormId = ("Form" + prefix),
            Prefix = prefix,
            PostAction = "ItemRow",
            PostController = "BankAccount",
            ButtonText = EleWise.ELMA.SR.T("Добавить"),
            CallbackFunc = callbackFunc,
            PopupId = popupId
        });

        public ActionResult PopupEditBankAccount(
          IBankAccount postModel,
          string popupId,
          string prefix,
          string index,
          string callbackFunc)
        {
            return PartialView("PopupBankAccount", (object)new BankAccountModel(postModel, EleWise.ELMA.Model.Views.ViewType.Edit)
            {
                DefaultFormId = ("Form" + prefix),
                Prefix = prefix,
                PostAction = "ItemRow",
                PostController = "BankAccount",
                ButtonText = EleWise.ELMA.SR.T("Изменить"),
                CallbackFunc = callbackFunc,
                PopupId = popupId,
                RowId = index
            });
        }

        public ActionResult ItemRow(BankAccountModel model) => model != null ? Json((object)new JsonSerializer().Serialize((object)new
        {
            Entity = model.Entity,
            RowId = model.RowId
        }), JsonRequestBehavior.AllowGet) : Json((object)null, JsonRequestBehavior.AllowGet);

        [AsyncViewItemAction]
        public ActionResult AsyncViewItem(Guid viewItemUid, long id, EleWise.ELMA.Model.Views.ViewType viewType)
        {
            BankAccountModel originalModel = new BankAccountModel(base.Manager.LoadOrCreate(id), viewType);
            return AsyncViewItemView<BankAccountModel>(originalModel.View, viewType, viewItemUid, originalModel, (Expression<Func<BankAccountModel, object>>)(m => m.Entity));
        }

        public ActionResult Details(long id, bool inPopup = true)
        {
            BankAccountModel bankAccountModel = new BankAccountModel(base.Manager.Load(id), EleWise.ELMA.Model.Views.ViewType.Display);
            bankAccountModel.Prefix = string.Format("Bind{0}", Guid.NewGuid().ToString("N"));
            bankAccountModel.PostController = "BankAccount";
            if (bankAccountModel.Entity != null && bankAccountModel.Entity.BankDetails != null)
            {
                bankAccountModel.Entity.BankDetails = bankAccountModel.Entity.BankDetails.CastAsRealType();
            }
            if (!inPopup)
            {
                return View(bankAccountModel);
            }
            return PartialView(bankAccountModel);
        }
    }
}
