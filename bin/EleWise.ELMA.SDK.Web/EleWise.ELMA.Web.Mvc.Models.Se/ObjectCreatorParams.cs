using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Web.Mvc.Models.Selectors;

[XmlRoot("CreatorParams")]
public class ObjectCreatorParams
{
	[XmlArray]
	public List<ObjectCreatorParam> Params { get; set; }

	[XmlArray]
	public Guid CreatorGuid { get; set; }

	public ObjectCreatorParams()
	{
		Params = new List<ObjectCreatorParam>();
	}
}
