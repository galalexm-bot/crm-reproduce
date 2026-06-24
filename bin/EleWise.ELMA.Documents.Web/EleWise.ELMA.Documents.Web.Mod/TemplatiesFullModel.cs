using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Documents.Web.Models;

[Serializable]
public class TemplatiesFullModel
{
	public List<SimpleTemplateModel> Templates { get; set; }

	public TemplatiesFullModel()
	{
		Templates = new List<SimpleTemplateModel>();
	}
}
