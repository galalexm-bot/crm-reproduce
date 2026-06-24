using System;
using System.Collections.Generic;
using System.Linq;
using Bridge;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Serialization;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.Models;

public class EnumWrapper : System.IFormattable, IBridgeClass
{
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public Guid uid;

		internal bool _003CCreateBase_003Eb__0(EnumValueMetadata a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)a).get_Uid() == uid;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public int intValue;

		internal bool _003CCreateBase_003Eb__0(EnumValueMetadata a)
		{
			return a.get_IntValue() == intValue;
		}
	}

	private static readonly System.Type enumWrapperType = typeof(EnumWrapper);

	private static Dictionary<ValueTuple<string, string>, EnumWrapper> wrappers = new Dictionary<ValueTuple<string, string>, EnumWrapper>();

	private int? _003CIntValue_003Ek__BackingField;

	private Guid _003CUid_003Ek__BackingField;

	private EnumMetadataType _003CEnumMetadataType_003Ek__BackingField;

	public int? IntValue
	{
		get
		{
			return _003CIntValue_003Ek__BackingField;
		}
		private set
		{
			_003CIntValue_003Ek__BackingField = value;
		}
	}

	public Guid Uid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CUid_003Ek__BackingField;
		}
		private set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CUid_003Ek__BackingField = value;
		}
	}

	internal EnumMetadataType EnumMetadataType
	{
		get
		{
			return _003CEnumMetadataType_003Ek__BackingField;
		}
		private set
		{
			_003CEnumMetadataType_003Ek__BackingField = value;
		}
	}

	public static implicit operator int(EnumWrapper enumWrapper)
	{
		return enumWrapper.IntValue ?? 0;
	}

	public static implicit operator EnumWrapper(int value)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (Script.Write<bool>("Bridge.is(value, {0})", new object[1] { enumWrapperType }))
		{
			return ObjectExtensions.As<EnumWrapper>((object)value);
		}
		return CreateBase(Guid.Empty, value, EnumMetadataType.Enum);
	}

	public static implicit operator EnumWrapper(System.Enum value)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Script.Write<bool>("Bridge.is(value, {0})", new object[1] { enumWrapperType }))
		{
			return ObjectExtensions.As<EnumWrapper>((object)value);
		}
		int num = Convert.ToInt32((object)value);
		return CreateBase(Guid.Empty, num, EnumMetadataType.Enum);
	}

	public static T GetEnum<T>(T value) where T : struct
	{
		System.Type typeFromHandle = typeof(T);
		EnumWrapper enumWrapper = Script.Write<EnumWrapper>("Bridge.as(value, {0})", new object[1] { enumWrapperType });
		if (enumWrapper != null)
		{
			return (T)System.Enum.Parse(typeFromHandle, ((object)enumWrapper).ToString());
		}
		return value;
	}

	[Obsolete]
	public EnumWrapper()
	{
	}

	internal static EnumWrapper CreateBase(Guid uid, EnumMetadata enumMetadata)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals0.uid = uid;
		if (enumMetadata != null)
		{
			EnumValueMetadata val = Enumerable.First<EnumValueMetadata>((System.Collections.Generic.IEnumerable<EnumValueMetadata>)enumMetadata.get_Values(), (Func<EnumValueMetadata, bool>)((EnumValueMetadata a) => ((IMetadata)a).get_Uid() == CS_0024_003C_003E8__locals0.uid));
			return CreateBase(((IMetadata)val).get_Uid(), val.get_IntValue(), (EnumMetadataType)enumMetadata.get_Type());
		}
		return CreateBase(CS_0024_003C_003E8__locals0.uid, null, EnumMetadataType.ExtendableEnum);
	}

	internal static EnumWrapper CreateBase(int intValue, EnumMetadata enumMetadata)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.intValue = intValue;
		if (enumMetadata != null)
		{
			EnumValueMetadata val = Enumerable.First<EnumValueMetadata>((System.Collections.Generic.IEnumerable<EnumValueMetadata>)enumMetadata.get_Values(), (Func<EnumValueMetadata, bool>)((EnumValueMetadata a) => a.get_IntValue() == CS_0024_003C_003E8__locals0.intValue));
			return CreateBase(((IMetadata)val).get_Uid(), val.get_IntValue(), (EnumMetadataType)enumMetadata.get_Type());
		}
		return CreateBase(Guid.Empty, CS_0024_003C_003E8__locals0.intValue, EnumMetadataType.Enum);
	}

	internal static EnumWrapper CreateBase(Guid uid, int? intValue, EnumMetadataType enumMetadataType)
	{
		string uidString = ((object)(Guid)(ref uid)).ToString();
		string intValueString = ((object)intValue).ToString();
		int num = (int)enumMetadataType;
		return Create(uidString, intValueString, ((object)num).ToString());
	}

	internal static EnumWrapper CreateFromString(string enumWrapperString)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		EnumWrapper enumWrapper = SerializationHelper.DeserializeObjectFromJson<EnumWrapper>(enumWrapperString);
		return CreateBase(enumWrapper.Uid, enumWrapper.IntValue, enumWrapper.EnumMetadataType);
	}

	internal static EnumWrapper Create(string uidString, string intValueString, string enumMetadataTypeString)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		ValueTuple<string, string> val = default(ValueTuple<string, string>);
		val._002Ector(uidString, intValueString);
		EnumWrapper result = default(EnumWrapper);
		if (wrappers.TryGetValue(val, ref result))
		{
			return result;
		}
		EnumWrapper enumWrapper = new EnumWrapper();
		Guid uid = default(Guid);
		bool flag = Guid.TryParse(uidString, ref uid);
		if (flag)
		{
			enumWrapper.Uid = uid;
		}
		int num = default(int);
		bool flag2 = int.TryParse(intValueString, ref num);
		if (flag2)
		{
			enumWrapper.IntValue = num;
		}
		EnumMetadataType enumMetadataType = default(EnumMetadataType);
		if (System.Enum.TryParse<EnumMetadataType>(enumMetadataTypeString, ref enumMetadataType))
		{
			enumWrapper.EnumMetadataType = enumMetadataType;
		}
		else if (flag && !flag2)
		{
			enumWrapper.EnumMetadataType = EnumMetadataType.ExtendableEnum;
		}
		wrappers.set_Item(val, enumWrapper);
		return enumWrapper;
	}

	public override string ToString()
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EnumMetadataType != 0)
		{
			Guid uid = Uid;
			return ((object)(Guid)(ref uid)).ToString();
		}
		return ((object)IntValue).ToString();
	}

	public override bool Equals(object o)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		if (!(o is EnumWrapper enumWrapper))
		{
			if (o is int num)
			{
				return num == IntValue;
			}
			return false;
		}
		if (Uid == Guid.Empty)
		{
			return IntValue == enumWrapper.IntValue;
		}
		if (!IntValue.get_HasValue())
		{
			return Uid == enumWrapper.Uid;
		}
		if (IntValue == enumWrapper.IntValue)
		{
			return Uid == enumWrapper.Uid;
		}
		return false;
	}

	public override int GetHashCode()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		if (Uid == Guid.Empty)
		{
			return ((object)$"{IntValue}").GetHashCode();
		}
		if (!IntValue.get_HasValue())
		{
			return ((object)$"{Uid}").GetHashCode();
		}
		return ((object)$"{IntValue}_{Uid}").GetHashCode();
	}

	[Name("compareTo")]
	private int CompareTo(object target)
	{
		EnumWrapper enumWrapper = ObjectExtensions.As<EnumWrapper>(target);
		if (IntValue.get_HasValue() && enumWrapper.IntValue.get_HasValue())
		{
			if (IntValue.get_Value() == enumWrapper.IntValue.get_Value())
			{
				return 0;
			}
			if (IntValue.get_Value() < enumWrapper.IntValue.get_Value())
			{
				return -1;
			}
			if (IntValue.get_Value() > enumWrapper.IntValue.get_Value())
			{
				return 1;
			}
		}
		return -1;
	}

	public string ToString(string format, IFormatProvider formatProvider)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (EnumMetadataType != 0)
		{
			Guid uid = Uid;
			return ((object)(Guid)(ref uid)).ToString();
		}
		return ((object)IntValue).ToString();
	}
}
