using System;
using System.Runtime.Serialization;
using System.Text;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Audit;

[Uid("{5CAD98AC-1EF3-4F1C-9B45-31B7BC9F2366}")]
public class ReplacementTaskActionEventArgs : EditEntityActionEventArgs
{
	[Serializable]
	private class InnerData
	{
		[OptionalField]
		private long taskExecutorId;

		[OptionalField]
		private long taskExecutorReplacedId;

		public long ReplacementTaskId { get; set; }

		public long TaskExecutorId
		{
			get
			{
				return taskExecutorId;
			}
			set
			{
				taskExecutorId = value;
			}
		}

		public long TaskExecutorReplacedId
		{
			get
			{
				return taskExecutorReplacedId;
			}
			set
			{
				taskExecutorReplacedId = value;
			}
		}
	}

	public long ReplacementTaskId { get; set; }

	public long TaskExecutorId { get; set; }

	public long TaskExecutorReplacedId { get; set; }

	protected ReplacementTaskActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
		: base(entity, objectUid, actionUid)
	{
	}

	public ReplacementTaskActionEventArgs(IEntity entity, IEntity newEntity, Guid actionUid)
		: base(entity, newEntity, actionUid)
	{
	}

	public static ReplacementTaskActionEventArgs TryCreate(IEntity entity, IEntity newEntity, long ReplacementTaskId)
	{
		return TryCreate(entity, newEntity, ReplacementTaskId, null, null);
	}

	public static ReplacementTaskActionEventArgs TryCreate(IEntity entity, IEntity newEntity, long ReplacementTaskId, long? taskExecutorId, long? taskExecutorReplacedId)
	{
		try
		{
			ReplacementTaskActionEventArgs replacementTaskActionEventArgs = new ReplacementTaskActionEventArgs(entity, newEntity, ReplacementTaskActions.ReplacementGuid);
			if (replacementTaskActionEventArgs.Action == null || replacementTaskActionEventArgs.Object == null)
			{
				return null;
			}
			replacementTaskActionEventArgs.ReplacementTaskId = ReplacementTaskId;
			if (taskExecutorId.HasValue)
			{
				replacementTaskActionEventArgs.TaskExecutorId = taskExecutorId.Value;
			}
			if (taskExecutorReplacedId.HasValue)
			{
				replacementTaskActionEventArgs.TaskExecutorReplacedId = taskExecutorReplacedId.Value;
			}
			return replacementTaskActionEventArgs;
		}
		catch
		{
			return null;
		}
	}

	public override void SetAdditionalData(byte[] data)
	{
		try
		{
			base.SetAdditionalData(data);
		}
		catch (Exception message)
		{
			try
			{
				InnerData innerData = ClassSerializationHelper.DeserializeObjectByJson<InnerData>(Encoding.UTF8.GetString(data));
				ReplacementTaskId = innerData.ReplacementTaskId;
				TaskExecutorId = innerData.TaskExecutorId;
				TaskExecutorReplacedId = innerData.TaskExecutorReplacedId;
			}
			catch (Exception message2)
			{
				Logger.Log.Error(message);
				Logger.Log.Error(message2);
			}
		}
	}
}
