using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class CreatePublicApplicationTokenModel : FormViewModel
{
	[Required(true)]
	[RequiredField]
	public DateTime ExpireDateTime { get; set; }

	public Guid ApplicationUid { get; set; }
}
