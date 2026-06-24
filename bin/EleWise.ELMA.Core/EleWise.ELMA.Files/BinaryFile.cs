using System;
using Newtonsoft.Json;

namespace EleWise.ELMA.Files;

public sealed class BinaryFile
{
	private string _003CName_003Ek__BackingField;

	private string _003CUidStr_003Ek__BackingField;

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	[JsonProperty("Uid")]
	public string UidStr
	{
		get
		{
			return _003CUidStr_003Ek__BackingField;
		}
		set
		{
			_003CUidStr_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	public Guid Uid
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			Guid result = default(Guid);
			if (Guid.TryParse(UidStr, ref result))
			{
				return result;
			}
			return Guid.Empty;
		}
		set
		{
			UidStr = ((object)(Guid)(ref value)).ToString();
		}
	}

	public BinaryFile()
		: this("", Guid.Empty)
	{
	}//IL_0006: Unknown result type (might be due to invalid IL or missing references)


	public BinaryFile(string name, Guid uid)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		Name = name;
		Uid = uid;
	}

	public override bool Equals(object o)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (o is BinaryFile binaryFile && Name == binaryFile.Name)
		{
			return Uid == binaryFile.Uid;
		}
		return false;
	}

	public override int GetHashCode()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return ((object)$"{Name}_{Uid}").GetHashCode();
	}
}
