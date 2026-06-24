using System;
using System.ComponentModel;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.CRM.Web.Portlets;

[Serializable]
public class InpaymentPortletPersonalization : PortletPersonalization
{
	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual long? FilterId { get; set; }

	[HiddenInput(DisplayValue = false)]
	public virtual IFilter Filter
	{
		get
		{
			if (FilterId.HasValue)
			{
				return EntityManager<IFilter>.Instance.LoadOrNull(FilterId.Value);
			}
			return null;
		}
		set
		{
			if (value != null)
			{
				FilterId = value.Id;
			}
			else
			{
				FilterId = null;
			}
		}
	}

	[Personalization(PersonalizationScope.User)]
	[DefaultValue(false)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool ShowOnlyMy { get; set; }

	[Personalization(PersonalizationScope.User)]
	[DefaultValue(true)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool SplitByPeriods { get; set; }
}
