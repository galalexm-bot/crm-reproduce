using System.ComponentModel.DataAnnotations;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class FilterActionLinkModel
{
	public IFilterActionLink ActionLink { get; set; }

	[System.ComponentModel.DataAnnotations.Required]
	[EleWise.ELMA.Model.Attributes.Required(true)]
	public LinkModel Link { get; set; }

	public FilterActionLinkModel()
	{
		Link = new LinkModel();
	}
}
