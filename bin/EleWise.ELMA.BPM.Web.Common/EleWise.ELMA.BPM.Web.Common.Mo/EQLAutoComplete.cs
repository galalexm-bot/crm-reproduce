using System;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class EQLAutoComplete
{
	public string QueryField { get; set; }

	public string TypeNameField { get; set; }

	public string QueryFieldValue { get; set; }

	public Guid FilterTypeUid { get; set; }

	public string FilterTypeUidId { get; set; }
}
