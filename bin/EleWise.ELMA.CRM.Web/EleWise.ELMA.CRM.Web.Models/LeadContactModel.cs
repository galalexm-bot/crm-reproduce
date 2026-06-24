using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM.Web.Models;

public class LeadContactModel : EntityModel<ILeadContact>
{
	public LeadContactModel(ILeadContact leadContact)
	{
		base.Entity = leadContact;
	}

	public LeadContactModel()
	{
		base.Entity = InterfaceActivator.Create<ILeadContact>();
	}

	public void Save()
	{
		base.Entity.Name = $"{base.Entity.Firstname} {base.Entity.Middlename} {base.Entity.Surname}".Trim();
		ClearEmailSetIfEmpty(base.Entity.Email);
		ClearPhoneSetIfEmpty(base.Entity.Phone);
		base.Entity.Save();
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
