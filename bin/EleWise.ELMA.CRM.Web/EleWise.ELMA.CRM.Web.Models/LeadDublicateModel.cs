using System;
using System.Linq;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;

namespace EleWise.ELMA.CRM.Web.Models;

public class LeadDublicateModel
{
	public ILead Lead { get; set; }

	public LeadDublicateStatus Status { get; set; }

	public LeadStepScoring StylePanel { get; set; }

	public long MaxPercent { get; set; }

	public long DublicateContractorCount { get; set; }

	public long DublicateLeadCount { get; set; }

	public LeadDublicateModel()
	{
	}

	public LeadDublicateModel(ILead lead)
	{
		Lead = lead;
		Status = LeadDublicateStateManager.Instance.GetLeadDublicateState(lead)?.Status ?? LeadDublicateStatus.New;
		DublicateContractorCount = LeadManager.Instance.DublicateContractorsCount(lead);
		DublicateLeadCount = LeadManager.Instance.DublicateLeadsCount(lead);
		MaxPercent = Math.Max(LeadManager.Instance.GetMaxPercentPossibleDublicateContractors(lead), LeadManager.Instance.GetMaxPercentPossibleDublicateLeads(lead));
		StylePanel = (from m in LeadStepScoring.GetListStepScoring()
			orderby m.PercentValue
			select m).LastOrDefault((LeadStepScoring item) => item.PercentValue <= MaxPercent);
	}
}
