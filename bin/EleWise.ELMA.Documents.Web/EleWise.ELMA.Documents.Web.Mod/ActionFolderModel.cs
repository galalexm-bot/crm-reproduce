using System.ComponentModel.DataAnnotations;
using EleWise.ELMA.BPM.Web.Content.Models;
using EleWise.ELMA.Documents.Models.Folders;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Documents.Web.Models;

public class ActionFolderModel : EntityModel<IActionFolder>
{
	[System.ComponentModel.DataAnnotations.Required]
	[EleWise.ELMA.Model.Attributes.Required(true)]
	public LinkModel Link { get; set; }

	public string PopupId { get; set; }

	public ActionFolderModel()
	{
		Link = new LinkModel();
	}
}
