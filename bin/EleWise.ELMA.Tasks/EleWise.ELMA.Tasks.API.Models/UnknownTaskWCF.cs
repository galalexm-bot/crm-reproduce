using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "UnknownTask")]
public class UnknownTaskWCF : TaskBaseWCF
{
	public UnknownTaskWCF()
	{
	}

	public UnknownTaskWCF(ITaskBase task)
		: base(task)
	{
	}
}
