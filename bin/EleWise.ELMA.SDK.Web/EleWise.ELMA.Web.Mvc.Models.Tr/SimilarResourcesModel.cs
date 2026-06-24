using System.Collections.Generic;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.Web.Mvc.Models.Translate;

public class SimilarResourcesModel
{
	public LocalizationHolder Local { get; set; }

	public string TextAreaId { get; set; }

	public string[] Words { get; set; }

	public string[] ExtendedWords { get; set; }

	public List<Pair<PoLineDescriptor, PoLineDescriptor>> Resources { get; set; }

	public SimilarResourcesModel()
	{
		Resources = new List<Pair<PoLineDescriptor, PoLineDescriptor>>();
	}
}
