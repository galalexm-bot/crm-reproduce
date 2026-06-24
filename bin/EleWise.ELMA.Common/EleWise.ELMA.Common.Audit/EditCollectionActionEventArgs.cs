using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Common.Audit;

[Uid("{8D40A205-BE2A-4B6B-9B24-95AC77352820}")]
public sealed class EditCollectionActionEventArgs : EntityActionEventArgs
{
	[Serializable]
	[DataContract]
	private class InnerData
	{
		[DataMember]
		public IEnumerable<ShortCollectionItemInfo> OldState { get; set; }

		[DataMember]
		public IEnumerable<ShortCollectionItemInfo> NewState { get; set; }

		[DataMember(IsRequired = false)]
		public Guid PropertyUid { get; set; }
	}

	public sealed class ShortCollectionItemInfo
	{
		public object Id { get; set; }

		public string Name { get; set; }

		public Guid TypeUid { get; set; }

		public ShortCollectionItemInfo()
		{
		}

		public ShortCollectionItemInfo(IEntity entity)
		{
			IMetadata metadata = MetadataLoader.LoadMetadata(entity.GetType());
			Id = entity.GetId();
			Name = entity.ToString();
			TypeUid = metadata.Uid;
		}
	}

	public IEnumerable<ShortCollectionItemInfo> OldState { get; set; }

	public IEnumerable<ShortCollectionItemInfo> NewState { get; set; }

	public Guid PropertyUid { get; set; }

	public bool Temporary { get; set; }

	public EditCollectionActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
		: base(entity, objectUid, actionUid)
	{
	}

	public EditCollectionActionEventArgs(IEntity old, IEntity @new, Guid actionUid)
		: base(old, @new, actionUid)
	{
	}

	public EditCollectionActionEventArgs(IEntity old, IEntity @new, Guid actionUid, IEnumerable<IEntity> newState, IEnumerable<IEntity> oldState)
		: base(old, @new, actionUid)
	{
		OldState = oldState.Select((IEntity a) => new ShortCollectionItemInfo(a));
		NewState = newState.Select((IEntity a) => new ShortCollectionItemInfo
		{
			Id = (long)a.GetId(),
			Name = a.ToString()
		});
	}

	public EditCollectionActionEventArgs(IEntity old, IEntity @new, Guid propertyUid, Guid actionUid)
		: this(old, @new, actionUid)
	{
		PropertyUid = propertyUid;
	}

	public override byte[] GetAdditionalData()
	{
		string s = ClassSerializationHelper.SerializeObjectByJson(new InnerData
		{
			OldState = OldState,
			NewState = NewState,
			PropertyUid = PropertyUid
		});
		return Encoding.UTF8.GetBytes(s);
	}

	public override void SetAdditionalData(byte[] data)
	{
		InnerData innerData = ClassSerializationHelper.DeserializeObjectByJson<InnerData>(Encoding.UTF8.GetString(data));
		if (innerData != null)
		{
			OldState = innerData.OldState;
			NewState = innerData.NewState;
			PropertyUid = innerData.PropertyUid;
		}
	}
}
