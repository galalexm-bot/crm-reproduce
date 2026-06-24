using System;
using System.Collections.Generic;

namespace EleWise.ELMA.CRM.Models;

public sealed class UpdateLeadsModel
{
	public IList<string> LeadsWithoutEditPermission { get; set; }

	public IList<string> LeadsIncorrectStatus { get; set; }

	public bool AnySuccess { get; set; }

	public Exception Error { get; set; }

	public UpdateLeadsModel()
	{
		LeadsWithoutEditPermission = new List<string>();
		LeadsIncorrectStatus = new List<string>();
	}
}
