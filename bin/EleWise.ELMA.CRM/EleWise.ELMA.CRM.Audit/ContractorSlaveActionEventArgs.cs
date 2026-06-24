using System;
using System.Text;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.CRM.Audit;

[Uid("{BB943E0B-6262-47DB-AEC9-3B5D416462F3}")]
public class ContractorSlaveActionEventArgs : EntityActionEventArgs
{
	[Serializable]
	private class SlaveInnerData
	{
		public Guid ActionUid { get; set; }

		public ReferenceOnEntity SlaveObject { get; set; }
	}

	private ReferenceOnEntity _slaveObject;

	public Guid ActionUid { get; set; }

	public ReferenceOnEntity SlaveObject
	{
		get
		{
			return _slaveObject;
		}
		set
		{
			_slaveObject = value;
		}
	}

	protected ContractorSlaveActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
		: base(entity, objectUid, actionUid)
	{
	}

	public ContractorSlaveActionEventArgs(IEntity entity, IEntity newEntity, Guid actionUid)
		: base(entity, newEntity, actionUid)
	{
	}

	public new static ContractorSlaveActionEventArgs TryCreate(IEntity entity, IEntity newEntity, Guid ActionGuid)
	{
		try
		{
			ContractorSlaveActionEventArgs contractorSlaveActionEventArgs = new ContractorSlaveActionEventArgs(entity, newEntity, ActionGuid);
			if (contractorSlaveActionEventArgs.Action == null || contractorSlaveActionEventArgs.Object == null)
			{
				return null;
			}
			return contractorSlaveActionEventArgs;
		}
		catch
		{
			return null;
		}
	}

	public override byte[] GetAdditionalData()
	{
		string s = ClassSerializationHelper.SerializeObjectByJson(new SlaveInnerData
		{
			SlaveObject = _slaveObject,
			ActionUid = ActionUid
		});
		return Encoding.UTF8.GetBytes(s);
	}

	public override void SetAdditionalData(byte[] data)
	{
		try
		{
			string @string = Encoding.UTF8.GetString(data);
			SlaveInnerData slaveInnerData = (SlaveInnerData)ClassSerializationHelper.DeserializeObjectByJson(typeof(SlaveInnerData), @string);
			_slaveObject = slaveInnerData.SlaveObject;
			ActionUid = slaveInnerData.ActionUid;
		}
		catch (Exception)
		{
		}
	}
}
