using System;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Tasks.Audit;

[Uid("E9777F15-4C01-42FC-9443-7374B92E707C")]
public class SubTaskCreateActionEventArgs : EntityActionEventArgs
{
	private byte[] _additionalData;

	private SubTaskCreateInfo _info;

	public SubTaskCreateInfo Info
	{
		get
		{
			if (_info == null)
			{
				GetAdditionalData();
			}
			return _info;
		}
	}

	protected SubTaskCreateActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
		: base(entity, objectUid, actionUid)
	{
	}

	public SubTaskCreateActionEventArgs(IEntity old, IEntity @new, Guid actionUid, SubTaskCreateInfo info)
		: base(old, @new, actionUid)
	{
		_info = info;
	}

	public SubTaskCreateActionEventArgs(IEntity old, IEntity @new, Guid actionUid)
		: base(old, @new, actionUid)
	{
	}

	public override byte[] GetAdditionalData()
	{
		if (_additionalData != null)
		{
			return _additionalData;
		}
		try
		{
			return _additionalData = ClassSerializationHelper.SerializeObject(_info);
		}
		catch (Exception message)
		{
			Logger.Log.Error(message);
			throw;
		}
	}

	public override void SetAdditionalData(byte[] data)
	{
		if (data != null)
		{
			try
			{
				_additionalData = data;
				_info = (SubTaskCreateInfo)ClassSerializationHelper.DeserializeObject(data);
			}
			catch (Exception message)
			{
				Logger.Log.Error(message);
			}
		}
	}
}
