using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Models.BillingInformation;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Security;

namespace EleWise.ELMA.CRM.Web.Controllers;

[Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
public class BankAccountController : BPMController<IBankAccount, long>
{
	public ActionResult PopupCreateBankAccount(string popupId, string prefix, string callbackFunc)
	{
		BankAccountModel bankAccountModel = new BankAccountModel
		{
			DefaultFormId = "Form" + prefix,
			Prefix = prefix,
			PostAction = "ItemRow",
			PostController = "BankAccount",
			ButtonText = SR.T("Добавить"),
			CallbackFunc = callbackFunc,
			PopupId = popupId
		};
		return (ActionResult)(object)((Controller)this).PartialView("PopupBankAccount", (object)bankAccountModel);
	}

	public ActionResult PopupEditBankAccount(IBankAccount postModel, string popupId, string prefix, string index, string callbackFunc)
	{
		BankAccountModel bankAccountModel = new BankAccountModel(postModel, ViewType.Edit)
		{
			DefaultFormId = "Form" + prefix,
			Prefix = prefix,
			PostAction = "ItemRow",
			PostController = "BankAccount",
			ButtonText = SR.T("Изменить"),
			CallbackFunc = callbackFunc,
			PopupId = popupId,
			RowId = index
		};
		return (ActionResult)(object)((Controller)this).PartialView("PopupBankAccount", (object)bankAccountModel);
	}

	public ActionResult ItemRow(BankAccountModel model)
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
		BankAccountModel bankAccountModel = new BankAccountModel(base.Manager.LoadOrCreate(id), viewType);
		return AsyncViewItemView(bankAccountModel.View, viewType, viewItemUid, bankAccountModel, (BankAccountModel m) => m.Entity);
	}

	public ActionResult Details(long id, bool inPopup = true)
	{
		BankAccountModel bankAccountModel = new BankAccountModel(base.Manager.Load(id), ViewType.Display);
		bankAccountModel.Prefix = string.Format("Bind{0}", Guid.NewGuid().ToString("N"));
		bankAccountModel.PostController = "BankAccount";
		if (bankAccountModel.Entity != null && bankAccountModel.Entity.BankDetails != null)
		{
			bankAccountModel.Entity.BankDetails = bankAccountModel.Entity.BankDetails.CastAsRealType();
		}
		if (!inPopup)
		{
			return (ActionResult)(object)((Controller)this).View((object)bankAccountModel);
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)bankAccountModel);
	}
}
