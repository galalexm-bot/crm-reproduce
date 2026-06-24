using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "QuestionPackage")]
public class QuestionPackage : TaskBasePackage
{
	[DataMember]
	public QuestionWCF Data { get; set; }

	public QuestionPackage(Guid typeUid)
		: base(typeUid)
	{
	}

	public override long GetId()
	{
		return Data.Id;
	}
}
