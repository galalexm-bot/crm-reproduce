using System;
using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Managers;

internal class ListDublicate
{
	public long Id { get; set; }

	public long Weight { get; set; }

	public List<Guid> PropertyList { get; set; }
}
