using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Tasks.Audit;

[Uid("{ECFBB01D-F2E1-4C52-9006-36BCEBFBE803}")]
public class TaskActionEventArgs : EntityActionEventArgs
{
	[Serializable]
	private class InnerData
	{
		public string _caption { get; set; }
	}

	public static string HideAttachAndComments = "HideAttachAndComments";

	public string Caption { get; set; }

	protected TaskActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
		: base(entity, objectUid, actionUid)
	{
	}

	public TaskActionEventArgs(IEntity entity, IEntity newEntity, Guid actionUid)
		: base(entity, newEntity, actionUid)
	{
	}

	public new static TaskActionEventArgs TryCreate(IEntity old, IEntity @new, Guid actionUid)
	{
		try
		{
			TaskActionEventArgs taskActionEventArgs = new TaskActionEventArgs(old, @new, actionUid);
			if (taskActionEventArgs.Action == null || taskActionEventArgs.Object == null)
			{
				return null;
			}
			return taskActionEventArgs;
		}
		catch
		{
			return null;
		}
	}

	public override byte[] GetAdditionalData()
	{
		InnerData graph = new InnerData
		{
			_caption = Caption
		};
		BinaryFormatter binaryFormatter = new BinaryFormatter();
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		binaryFormatter.Serialize(memoryStream, graph);
		return memoryStream.ToArray();
	}

	public override void SetAdditionalData(byte[] data)
	{
		using MemoryStream serializationStream = MemoryHelper.GetMemoryStream(data, writable: false);
		InnerData innerData = (InnerData)new BinaryFormatter().Deserialize(serializationStream);
		Caption = innerData._caption;
	}
}
