using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Web.Models;

public class LeadStepScoringModel
{
	public LeadStepScoring Entity { get; set; }

	[DisplayName(typeof(LeadStepScoringModel_SR), "PercentValue")]
	public long PercentValue { get; set; }

	[DisplayName(typeof(LeadStepScoringModel_SR), "ColorCode")]
	public IColor Color { get; set; }

	public LeadStepScoringModel()
	{
		Entity = new LeadStepScoring();
	}

	public LeadStepScoringModel(long id)
	{
		Entity = LeadStepScoring.LoadStepScoring(id);
		PercentValue = Entity.PercentValue;
		Color = EntityManager<IColor>.Instance.Load(Entity.ColorId);
	}

	public void Save()
	{
		Entity.PercentValue = PercentValue;
		IColor color = EntityManager<IColor>.Instance.LoadOrNull(Color.Id);
		if (color == null)
		{
			color = InterfaceActivator.Create<IColor>();
			color.ColorCode = Color.ColorCode;
			color.Save();
		}
		Entity.ColorId = color.Id;
		Entity.Save();
	}
}
