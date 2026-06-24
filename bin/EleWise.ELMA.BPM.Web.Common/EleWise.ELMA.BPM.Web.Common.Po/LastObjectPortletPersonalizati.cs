using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Portlets;

[Serializable]
public class LastObjectPortletPersonalization : PortletPersonalization, ILastObjectSettings
{
	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual string Version { get; set; }

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual bool RestrictTypes { get; set; }

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	public virtual List<Guid> ObjectTypes { get; set; }

	[Personalization(PersonalizationScope.User)]
	[HiddenInput(DisplayValue = false)]
	[Int32Settings(MaxValue = 100)]
	public virtual int ObjectCount { get; set; }
}
