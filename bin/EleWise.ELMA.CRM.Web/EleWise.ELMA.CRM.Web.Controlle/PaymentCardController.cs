using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.CRM.Web.Controllers;

[Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
public class PaymentCardController : BPMController<IPaymentCard, long>
{
	public ActionResult PopupCreatePaymentCard(string popupId, string prefix, string callbackFunc)
	{
		PaymentCardModel paymentCardModel = new PaymentCardModel
		{
			DefaultFormId = "Form" + prefix,
			Prefix = prefix,
			PostAction = "ItemRow",
			PostController = "PaymentCard",
			ButtonText = SR.T("Добавить"),
			CallbackFunc = callbackFunc,
			PopupId = popupId
		};
		return (ActionResult)(object)((Controller)this).PartialView("PopupPaymentCard", (object)paymentCardModel);
	}

	public ActionResult PopupEditPaymentCard(IPaymentCard postModel, string popupId, string prefix, string index, string callbackFunc)
	{
		PaymentCardModel paymentCardModel = new PaymentCardModel(postModel, ViewType.Edit)
		{
			DefaultFormId = "Form" + prefix,
			Prefix = prefix,
			PostAction = "ItemRow",
			PostController = "PaymentCard",
			ButtonText = SR.T("Изменить"),
			CallbackFunc = callbackFunc,
			PopupId = popupId,
			RowId = index
		};
		return (ActionResult)(object)((Controller)this).PartialView("PopupPaymentCard", (object)paymentCardModel);
	}

	public ActionResult ItemRow(PaymentCardModel model)
	{
		if (model != null)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new JsonSerializer().Serialize(new { model.Entity, model.RowId }), (JsonRequestBehavior)0);
		}
		return (ActionResult)(object)((Controller)this).Json((object)null, (JsonRequestBehavior)0);
	}

	[AsyncViewItemAction]
	public ActionResult AsyncViewItem(Guid viewItemUid, long id, ViewType viewType)
	{
		PaymentCardModel paymentCardModel = new PaymentCardModel(base.Manager.LoadOrCreate(id), viewType);
		return AsyncViewItemView(paymentCardModel.View, viewType, viewItemUid, paymentCardModel, (PaymentCardModel m) => m.Entity);
	}

	public ActionResult Details(long id, bool inPopup = true)
	{
		PaymentCardModel paymentCardModel = new PaymentCardModel(base.Manager.Load(id), ViewType.Display);
		paymentCardModel.Prefix = string.Format("Bind{0}", Guid.NewGuid().ToString("N"));
		paymentCardModel.PostController = "PaymentCard";
		if (!inPopup)
		{
			return (ActionResult)(object)((Controller)this).View((object)paymentCardModel);
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)paymentCardModel);
	}
}
