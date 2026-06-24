using System;
using System.Collections.Generic;
using System.Text;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Documents.Audit;

[Uid("{4FE5AD4E-48A2-43B3-B90A-968CF350B39E}")]
public class ConvertedActionEventArgs : EntityActionEventArgs
{
	[Serializable]
	private class InnerData
	{
		public Guid PrevType { get; set; }

		public string PrevTypeName { get; set; }

		public Guid NewType { get; set; }

		public string NewTypeName { get; set; }
	}

	private byte[] _additionalData;

	public Guid PrevType { get; set; }

	public string PrevTypeName { get; set; }

	public Guid NewType { get; set; }

	public string NewTypeName { get; set; }

	public override IDictionary<string, object> ExtendedProperties
	{
		get
		{
			IDictionary<string, object> extendedProperties = base.ExtendedProperties;
			extendedProperties["PrevType"] = PrevType;
			extendedProperties["PrevTypeName"] = PrevTypeName;
			extendedProperties["NewType"] = NewType;
			extendedProperties["NewTypeName"] = NewTypeName;
			return extendedProperties;
		}
	}

	public ConvertedActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
		: base(entity, objectUid, actionUid)
	{
	}

	public ConvertedActionEventArgs(IEntity old, IEntity @new, Guid actionUid)
		: base(old, @new, actionUid)
	{
	}

	public override byte[] GetAdditionalData()
	{
		string s = ClassSerializationHelper.SerializeObjectByJson(new InnerData
		{
			PrevType = PrevType,
			PrevTypeName = PrevTypeName,
			NewType = NewType,
			NewTypeName = NewTypeName
		});
		return Encoding.UTF8.GetBytes(s);
	}

	public override void SetAdditionalData(byte[] data)
	{
		string @string = Encoding.UTF8.GetString(data);
		InnerData innerData = (InnerData)ClassSerializationHelper.DeserializeObjectByJson(typeof(InnerData), @string);
		PrevType = innerData.PrevType;
		PrevTypeName = innerData.PrevTypeName;
		NewType = innerData.NewType;
		NewTypeName = innerData.NewTypeName;
	}
}
