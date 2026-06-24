using System;
using System.Collections.Generic;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.vCard.Vcard;
using EleWise.ELMA.vCard.Web.Components;
using EleWise.ELMA.Web.Mvc.Controllers;
using Iesi.Collections.Generic;
using Orchard.Themes;

namespace EleWise.ELMA.vCard.CRM.Web.Controllers;

[Themed]
public class VcardCRMController : BaseController
{
	private IEntityManager<IContractor> ContractorManager;

	private IEntityManager<ILead> LeadManager;

	private IEntityManager<IContact> ContactManager;

	private IEntityManager<IContractorIndividual> ContractorIndividualManager;

	public VcardCRMController(IEntityManager<IContractor> contractorManager, IEntityManager<ILead> leadManager, IEntityManager<IContact> contactManager, IEntityManager<IContractorIndividual> contractorIndividualManager)
	{
		ContractorManager = contractorManager;
		LeadManager = leadManager;
		ContactManager = contactManager;
		ContractorIndividualManager = contractorIndividualManager;
	}

	private void AddAdress(EleWise.ELMA.vCard.Vcard.Vcard vcard, IAddress adress)
	{
		if (adress != null)
		{
			vcard.Add(new VcardAdress
			{
				City = adress.City,
				Country = ((adress.Country == null) ? "" : adress.Country.Name),
				Locality = adress.Locality,
				Home = adress.Building,
				Postcode = adress.Zip,
				Street = adress.Street,
				Region = adress.Region
			});
		}
	}

	private void AddPhone(EleWise.ELMA.vCard.Vcard.Vcard vcard, ISet<IPhone> phone)
	{
		foreach (IPhone item in (IEnumerable<IPhone>)phone)
		{
			vcard.Add(new VcardTelephones(item.PhoneString, new VcardTelTypes[1]));
		}
	}

	private void AddEmail(EleWise.ELMA.vCard.Vcard.Vcard vcard, ISet<IEmail> email)
	{
		foreach (IEmail item in (IEnumerable<IEmail>)email)
		{
			vcard.Add(new VcardEmail(item.EmailString));
		}
	}

	public VCardResult GetForContractor(Guid id)
	{
		IContractor contractor = ContractorManager.LoadOrNull(id);
		if (contractor == null)
		{
			return null;
		}
		string name = contractor.Name;
		EleWise.ELMA.vCard.Vcard.Vcard vcard = new EleWise.ELMA.vCard.Vcard.Vcard();
		vcard.Add(new VcardName
		{
			FullName = name
		});
		vcard.Add(new VcardBirthday(contractor.CompanyDay));
		AddPhone(vcard, contractor.Phone);
		AddEmail(vcard, contractor.Email);
		vcard.Add(new VcardTelephones(contractor.Fax, new VcardTelTypes[2]
		{
			VcardTelTypes.Fax,
			VcardTelTypes.Work
		}));
		vcard.Add(new VcardPairitem("NOTE", contractor.Description));
		vcard.Add(new VcardPairitem("URL;TYPE=WORK", contractor.Site));
		vcard.Add(new VcardPairitem("ORG", contractor.Name));
		AddAdress(vcard, contractor.LegalAddress);
		return new VCardResult(vcard, name);
	}

	public VCardResult GetForLead(Guid id)
	{
		ILead lead = LeadManager.LoadOrNull(id);
		if (lead == null)
		{
			return null;
		}
		string name = lead.Name;
		EleWise.ELMA.vCard.Vcard.Vcard vcard = new EleWise.ELMA.vCard.Vcard.Vcard();
		vcard.Add(new VcardName
		{
			FullName = name
		});
		AddPhone(vcard, lead.Phone);
		AddEmail(vcard, lead.Email);
		vcard.Add(new VcardPairitem("NOTE", lead.Description));
		vcard.Add(new VcardPairitem("URL;TYPE=WORK", lead.Site));
		AddAdress(vcard, lead.Address);
		return new VCardResult(vcard, name);
	}

	public VCardResult GetForContact(Guid id)
	{
		IContact contact = ContactManager.LoadOrNull(id);
		if (contact == null)
		{
			return null;
		}
		string name = contact.Name;
		EleWise.ELMA.vCard.Vcard.Vcard vcard = new EleWise.ELMA.vCard.Vcard.Vcard();
		vcard.Add(new VcardName
		{
			FirstName = contact.Firstname,
			MiddleName = contact.Middlename,
			LastName = contact.Surname,
			FullName = name
		});
		vcard.Add(new VcardPairitem("NOTE", contact.Description));
		vcard.Add(new VcardPairitem("URL;TYPE=WORK", contact.Site));
		vcard.Add(new VcardPairitem("ORG", (contact.Contractor == null) ? "" : contact.Contractor.Name));
		vcard.Add(new VcardPairitem("TITLE", contact.Position));
		vcard.Add(new VcardPairitem("X-SKYPE-USERNAME", contact.Skype));
		vcard.Add(new VcardPairitem("X-ICQ", (!contact.Icq.HasValue) ? "" : contact.Icq.ToString()));
		AddPhone(vcard, contact.Phone);
		AddEmail(vcard, contact.Email);
		AddAdress(vcard, contact.RegistrationAddress);
		return new VCardResult(vcard, name);
	}

	public VCardResult GetForContractorIndividual(Guid id)
	{
		IContractorIndividual contractorIndividual = ContractorIndividualManager.LoadOrNull(id);
		if (contractorIndividual == null)
		{
			return null;
		}
		string name = contractorIndividual.Name;
		EleWise.ELMA.vCard.Vcard.Vcard vcard = new EleWise.ELMA.vCard.Vcard.Vcard();
		vcard.Add(new VcardName
		{
			FirstName = contractorIndividual.FirstName,
			MiddleName = contractorIndividual.MiddleName,
			LastName = contractorIndividual.SecondName,
			FullName = name
		});
		vcard.Add(new VcardBirthday(contractorIndividual.CompanyDay));
		vcard.Add(new VcardPairitem("URL;TYPE=WORK", contractorIndividual.Site));
		vcard.Add(new VcardPairitem("NOTE", contractorIndividual.Description));
		AddPhone(vcard, contractorIndividual.Phone);
		AddEmail(vcard, contractorIndividual.Email);
		vcard.Add(new VcardTelephones(contractorIndividual.Fax, new VcardTelTypes[2]
		{
			VcardTelTypes.Fax,
			VcardTelTypes.Work
		}));
		AddAdress(vcard, contractorIndividual.LegalAddress);
		return new VCardResult(vcard, name);
	}
}
