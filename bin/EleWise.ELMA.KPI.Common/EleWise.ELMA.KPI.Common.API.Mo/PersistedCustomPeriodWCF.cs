using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.KPI.Common.API.Models;

[Serializable]
[DataContract(Name = "PersistedCustomPeriod")]
public class PersistedCustomPeriodWCF
{
	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public DateTime PeriodStart { get; set; }

	[DataMember]
	public DateTime PeriodEnd { get; set; }

	[DataMember]
	public string TextRepr { get; set; }

	[DataMember]
	public PeriodicityWCF Periodicity { get; set; }
}
