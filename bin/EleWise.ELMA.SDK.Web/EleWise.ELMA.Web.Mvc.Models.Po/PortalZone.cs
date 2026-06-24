using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Web.Mvc.Models.Portal;

public class PortalZone
{
	public string Name { get; set; }

	public ICollection<Guid> Instnaces { get; set; }
}
