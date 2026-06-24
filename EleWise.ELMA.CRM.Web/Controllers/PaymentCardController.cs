// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Controllers.PaymentCardController
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.CRM.Web.Models;
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
    public class PaymentCardController : BPMController<IPaymentCard, long>
    {
        public ActionResult PopupCreatePaymentCard(string popupId, string prefix, string callbackFunc) => PartialView("PopupPaymentCard", (object)new PaymentCardModel()
        {
            DefaultFormId = ("Form" + prefix),
            Prefix = prefix,
            PostAction = "ItemRow",
            PostController = "PaymentCard",
            ButtonText = EleWise.ELMA.SR.T("Добавить"),
            CallbackFunc = callbackFunc,
            PopupId = popupId
        });

        public ActionResult PopupEditPaymentCard(
          IPaymentCard postModel,
          string popupId,
          string prefix,
          string index,
          string callbackFunc)
        {
            return PartialView("PopupPaymentCard", (object)new PaymentCardModel(postModel, EleWise.ELMA.Model.Views.ViewType.Edit)
            {
                DefaultFormId = ("Form" + prefix),
                Prefix = prefix,
                PostAction = "ItemRow",
                PostController = "PaymentCard",
                ButtonText = EleWise.ELMA.SR.T("Изменить"),
                CallbackFunc = callbackFunc,
                PopupId = popupId,
                RowId = index
            });
        }

        public ActionResult ItemRow(PaymentCardModel model) => model != null ? Json((object)new JsonSerializer().Serialize((object)new
        {
            Entity = model.Entity,
            RowId = model.RowId
        }), JsonRequestBehavior.AllowGet) : Json((object)null, JsonRequestBehavior.AllowGet);

        [AsyncViewItemAction]
        public ActionResult AsyncViewItem(Guid viewItemUid, long id, EleWise.ELMA.Model.Views.ViewType viewType)
        {
            PaymentCardModel originalModel = new PaymentCardModel(base.Manager.LoadOrCreate(id), viewType);
            return AsyncViewItemView<PaymentCardModel>(originalModel.View, viewType, viewItemUid, originalModel, (Expression<Func<PaymentCardModel, object>>)(m => m.Entity));
        }

        public ActionResult Details(long id, bool inPopup = true)
        {
            PaymentCardModel model = new PaymentCardModel(base.Manager.Load(id), EleWise.ELMA.Model.Views.ViewType.Display);
            model.Prefix = string.Format("Bind{0}", (object)Guid.NewGuid().ToString("N"));
            model.PostController = "PaymentCard";
            if (!inPopup)
            {
                return View(model);
            }
            return PartialView(model);
        }
    }
}
