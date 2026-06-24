using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Diagnostics;

namespace EleWise.ELMA.Model.Entities.EntityReferences;

public sealed class ReferenceOnEntity
{
	private const string Delimiter = ";";

	private readonly long _003CObjectId_003Ek__BackingField;

	private readonly Guid _003CObjectTypeUid_003Ek__BackingField;

	public long ObjectId => _003CObjectId_003Ek__BackingField;

	public Guid ObjectTypeUid => _003CObjectTypeUid_003Ek__BackingField;

	internal ReferenceOnEntity(string stringValue)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		Contract.ArgumentNotNullOrEmpty(stringValue, "stringValue");
		string[] array = stringValue.Split(new string[1] { ";" }, (StringSplitOptions)1);
		if (array.Length < 2 || string.IsNullOrWhiteSpace(array[0]) || string.IsNullOrWhiteSpace(array[1]))
		{
			throw new ArgumentOutOfRangeException("stringValue");
		}
		Guid val = default(Guid);
		long num = default(long);
		if (Guid.TryParse(array[0], ref val) && long.TryParse(array[1], ref num))
		{
			_003CObjectTypeUid_003Ek__BackingField = val;
			_003CObjectId_003Ek__BackingField = num;
			return;
		}
		throw new ArgumentException(SR.T("Неверная строка данных передана в конструктор"), "stringValue");
	}

	public ReferenceOnEntity(long objectId, Guid objectTypeUid)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		_003CObjectId_003Ek__BackingField = objectId;
		_003CObjectTypeUid_003Ek__BackingField = objectTypeUid;
	}

	public override string ToString()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return string.Format("{0}{1}{2}", (object)ObjectTypeUid, (object)";", (object)ObjectId);
	}

	public override bool Equals(object o)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		if (o is ReferenceOnEntity referenceOnEntity && ObjectId == referenceOnEntity.ObjectId)
		{
			return ObjectTypeUid == referenceOnEntity.ObjectTypeUid;
		}
		return false;
	}

	public override int GetHashCode()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return ((object)$"{ObjectId}_{ObjectTypeUid}").GetHashCode();
	}
}
