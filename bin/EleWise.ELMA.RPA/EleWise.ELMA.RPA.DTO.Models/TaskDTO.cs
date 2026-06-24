using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.RPA.DTO.Models;

[Serializable]
[DataContract]
public class TaskDTO
{
	[DataMember(Name = "id")]
	public int Id { get; set; }

	[DataMember(Name = "process")]
	public Guid Process { get; set; }

	[DataMember(Name = "ctx")]
	public string Context { get; set; }

	[DataMember(Name = "system")]
	public string System { get; set; }

	public TaskPriority Priority { get; set; }

	[DataMember(Name = "priority")]
	public string TaskPriorityString
	{
		get
		{
			return Enum.GetName(typeof(TaskPriority), Priority);
		}
		set
		{
			Priority = (TaskPriority)Enum.Parse(typeof(TaskPriority), value);
		}
	}

	[DataMember(Name = "groups")]
	public string[] Groups { get; set; }

	public TaskStatus Status { get; set; }

	[DataMember(Name = "status")]
	public string TaskStatusString
	{
		get
		{
			return Enum.GetName(typeof(TaskStatus), Status);
		}
		set
		{
			Status = (TaskStatus)Enum.Parse(typeof(TaskStatus), value);
		}
	}

	[DataMember(Name = "bot")]
	public string Bot { get; set; }

	[DataMember(Name = "outputCtx")]
	public string OutputContext { get; set; }

	[DataMember(Name = "version")]
	public int Version { get; set; }

	[DataMember(Name = "log")]
	public string Log { get; set; }

	[DataMember(Name = "created")]
	public DateTime CreationDate { get; set; }

	[DataMember(Name = "updated")]
	public DateTime UpdateDate { get; set; }
}
