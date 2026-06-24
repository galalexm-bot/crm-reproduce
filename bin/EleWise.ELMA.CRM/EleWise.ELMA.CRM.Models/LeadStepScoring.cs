using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Models;

[Serializable]
public class LeadStepScoring
{
	public static string LeadStepScoringString = "LeadStepScoring";

	public long Id { get; set; }

	[DisplayName(typeof(_Resource_StepScoring), "PercentValue")]
	public long PercentValue { get; set; }

	[DisplayName(typeof(_Resource_StepScoring), "ColorCode")]
	public long ColorId { get; set; }

	public void Save()
	{
		List<LeadStepScoring> listStepScoring = GetListStepScoring();
		LeadStepScoring leadStepScoring = listStepScoring.FirstOrDefault((LeadStepScoring m) => m.Id == Id);
		if (leadStepScoring != null)
		{
			listStepScoring.Remove(leadStepScoring);
		}
		if (Id == 0L)
		{
			Id = ((listStepScoring.Count > 0) ? (listStepScoring.Max((LeadStepScoring m) => m.Id) + 1) : 1);
		}
		listStepScoring.Add(this);
		Locator.GetServiceNotNull<IBLOBStore>().Save(LeadStepScoringString, Encoding.UTF8.GetBytes(ClassSerializationHelper.SerializeObjectByJson(listStepScoring)));
	}

	public static void CreateDefaultStep()
	{
		List<LeadStepScoring> obj = new List<LeadStepScoring>
		{
			new LeadStepScoring
			{
				Id = 1L,
				ColorId = EntityManager<IColor>.Instance.Load(CrmConstants.DefaultColorYellowUid).Id,
				PercentValue = 30L
			},
			new LeadStepScoring
			{
				Id = 2L,
				ColorId = EntityManager<IColor>.Instance.Load(CrmConstants.DefaultColorRedUid).Id,
				PercentValue = 70L
			}
		};
		Locator.GetServiceNotNull<IBLOBStore>().Save(LeadStepScoringString, Encoding.UTF8.GetBytes(ClassSerializationHelper.SerializeObjectByJson(obj)));
	}

	public static List<LeadStepScoring> GetListStepScoring()
	{
		byte[] array = Locator.GetServiceNotNull<IBLOBStore>().LoadOrNull(LeadStepScoringString);
		if (array == null)
		{
			return new List<LeadStepScoring>();
		}
		return ClassSerializationHelper.DeserializeObjectByJson<List<LeadStepScoring>>(Encoding.UTF8.GetString(array));
	}

	public static LeadStepScoring LoadStepScoring(long id)
	{
		return GetListStepScoring().FirstOrDefault((LeadStepScoring m) => m.Id == id);
	}
}
