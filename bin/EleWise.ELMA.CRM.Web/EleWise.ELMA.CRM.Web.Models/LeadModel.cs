using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Extensions;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Models;

public class LeadModel : DynamicEntityViewModel<ILead>, IDeleteCategoriesDialogModel
{
	public IEnumerable<ILeadType> LeadTypes { get; set; }

	public List<SelectListItem> AvailableLeadTypes => LeadTypes.Select((Func<ILeadType, SelectListItem>)delegate(ILeadType c)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		SelectListItem val = new SelectListItem();
		val.set_Text(c.Type);
		val.set_Value(c.Id.ToString());
		return val;
	}).ToList();

	public ILeadContact NewContact { get; set; }

	public bool? UnassignOldCategories { get; set; }

	public IEnumerable<ICategory> CategoriesToDelete { get; set; }

	public bool LockEditPermission { get; set; }

	public LeadModel(ILead lead)
		: this(lead, ViewType.Create)
	{
	}

	public LeadModel(ILead lead, ViewType viewType)
		: base(lead, viewType)
	{
		if (lead == null)
		{
			NewContact = InterfaceActivator.Create<ILeadContact>();
			base.Entity.Responsible = AuthenticationService.GetCurrentUser<IUser>();
		}
	}

	public LeadModel()
	{
		base.ViewType = ViewType.Create;
		NewContact = InterfaceActivator.Create<ILeadContact>();
		base.Entity.Responsible = AuthenticationService.GetCurrentUser<IUser>();
	}

	private void PrepareSave()
	{
		if (base.Entity.IsNew())
		{
			base.Entity.Status = LeadStatus.New;
			NewContact.Name = $"{NewContact.Firstname} {NewContact.Middlename} {NewContact.Surname}".Trim();
			if (!string.IsNullOrEmpty(NewContact.Name))
			{
				ClearEmailSetIfEmpty(NewContact.Email);
				ClearPhoneSetIfEmpty(NewContact.Phone);
				base.Entity.Contacts.Add(NewContact);
			}
		}
		ClearEmailSetIfEmpty(base.Entity.Email);
		ClearPhoneSetIfEmpty(base.Entity.Phone);
		if (base.Entity.Address != null && base.Entity.Address.Country != null)
		{
			ComponentManager.Current.GetExtensionPoints<ICountryInfo>().FirstOrDefault((ICountryInfo p) => p.NeedAdd(base.Entity.Address.Country.Name))?.Adding(base.Entity.Address);
		}
	}

	public void Save()
	{
		PrepareSave();
		base.Entity.Save();
	}

	public SaveWithCategoryRulesResult SaveWithCategoryRules(RuleDeletedCategoryAction ruleDeletedCategoryAction = RuleDeletedCategoryAction.Delete)
	{
		PrepareSave();
		return LeadManager.Instance.SaveWithCategoryRules(base.Entity, ruleDeletedCategoryAction);
	}

	private void ClearEmailSetIfEmpty(ISet<IEmail> emailSet)
	{
		bool flag = true;
		foreach (IEmail item in (IEnumerable<IEmail>)emailSet)
		{
			if (!string.IsNullOrWhiteSpace(item.EmailString))
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			((ICollection<IEmail>)emailSet).Clear();
		}
	}

	private void ClearPhoneSetIfEmpty(ISet<IPhone> phoneSet)
	{
		bool flag = true;
		foreach (IPhone item in (IEnumerable<IPhone>)phoneSet)
		{
			if (!string.IsNullOrWhiteSpace(item.PhoneString))
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			((ICollection<IPhone>)phoneSet).Clear();
		}
	}
}
