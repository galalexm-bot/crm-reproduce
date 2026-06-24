using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "Question")]
public class QuestionWCF : TaskBaseWCF
{
	[DataMember]
	public Guid ReferenceObjectTypeUId { get; set; }

	[DataMember]
	public long ReferenceObjectId { get; set; }

	[DataMember]
	public string ReferenceObjectDisplayName { get; set; }

	public QuestionWCF()
	{
	}

	public QuestionWCF(IQuestion task)
		: base(task)
	{
		ReferenceObjectTypeUId = task.RefObject.ObjectTypeUId;
		ReferenceObjectId = task.RefObject.ObjectId;
		ReferenceObjectDisplayName = ((task.RefObject.Object != null) ? task.RefObject.Object.ToString() : "");
	}
}
