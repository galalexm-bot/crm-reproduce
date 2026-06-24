using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Models;

[Serializable]
public class LeadScoringSettings
{
	public static string LeadScoringSettingsString = "LeadScoringSettings";

	public long Id { get; set; }

	[Required(true)]
	[DisplayName(typeof(__Resources_ILeadScoringSettings), "P_Property_DisplayName")]
	public Guid Property { get; set; }

	[DisplayName(typeof(__Resources_ILeadScoringSettings), "P_UseLeadContactProperty_DisplayName")]
	public bool UseLeadContactProperty { get; set; }

	[DisplayName(typeof(__Resources_ILeadScoringSettings), "P_LeadContactProperty_DisplayName")]
	public Guid LeadContactProperty { get; set; }

	[DisplayName(typeof(__Resources_ILeadScoringSettings), "P_LeadPercentValue_DisplayName")]
	public long LeadPercentValue { get; set; }

	[Required(true)]
	[DisplayName(typeof(__Resources_ILeadScoringSettings), "P_Operator_DisplayName")]
	public LeadCompareType Operator { get; set; }

	[DisplayName(typeof(__Resources_ILeadScoringSettings), "P_ContractorProperty_DisplayName")]
	public Guid ContractorProperty { get; set; }

	[DisplayName(typeof(__Resources_ILeadScoringSettings), "P_UseContractorContactProperty_DisplayName")]
	public bool UseContractorContactProperty { get; set; }

	[DisplayName(typeof(__Resources_ILeadScoringSettings), "P_ContractorContactProperty_DisplayName")]
	public Guid ContractorContactProperty { get; set; }

	[DisplayName(typeof(__Resources_ILeadScoringSettings), "P_ContractorPercentValue_DisplayName")]
	public long ContractorPercentValue { get; set; }

	public void Save()
	{
		List<LeadScoringSettings> leadScoringSettings = GetLeadScoringSettings();
		LeadScoringSettings leadScoringSettings2 = leadScoringSettings.FirstOrDefault((LeadScoringSettings m) => m.Id == Id);
		if (leadScoringSettings2 != null)
		{
			leadScoringSettings.Remove(leadScoringSettings2);
		}
		Id = ((leadScoringSettings.Count > 0) ? (leadScoringSettings.Max((LeadScoringSettings m) => m.Id) + 1) : 1);
		leadScoringSettings.Add(this);
		Locator.GetServiceNotNull<IBLOBStore>().Save(LeadScoringSettingsString, Encoding.UTF8.GetBytes(ClassSerializationHelper.SerializeObjectByJson(leadScoringSettings)));
	}

	public void Delete()
	{
		List<LeadScoringSettings> leadScoringSettings = GetLeadScoringSettings();
		LeadScoringSettings leadScoringSettings2 = leadScoringSettings.FirstOrDefault((LeadScoringSettings m) => m.Id == Id);
		if (leadScoringSettings2 != null)
		{
			leadScoringSettings.Remove(leadScoringSettings2);
		}
		Locator.GetServiceNotNull<IBLOBStore>().Save(LeadScoringSettingsString, Encoding.UTF8.GetBytes(ClassSerializationHelper.SerializeObjectByJson(leadScoringSettings)));
	}

	public bool IsNew()
	{
		return LoadScoringSetting(Id) == null;
	}

	public static List<LeadScoringSettings> GetLeadScoringSettings()
	{
		byte[] array = Locator.GetServiceNotNull<IBLOBStore>().LoadOrNull(LeadScoringSettingsString);
		if (array == null)
		{
			return new List<LeadScoringSettings>();
		}
		return ClassSerializationHelper.DeserializeObjectByJson<List<LeadScoringSettings>>(Encoding.UTF8.GetString(array));
	}

	public static LeadScoringSettings LoadScoringSetting(long id)
	{
		return GetLeadScoringSettings().FirstOrDefault((LeadScoringSettings m) => m.Id == id);
	}
}
