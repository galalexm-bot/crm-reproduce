using System;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

public abstract class RangeTypeDescriptor<T, TSettings> : CLRTypeDescriptor<T, TSettings>
{
	public override bool UseForEntity => false;

	public override Guid ParentUid => RangeTypesDescriptor.UID;

	public override bool CanBeNullable => false;

	public RangeTypeDescriptor(ILogger logger)
		: base(logger)
	{
	}

	protected abstract object GetFromValue(T value);

	protected abstract object GetToValue(T value);
}
public abstract class RangeTypeDescriptor<T, TRangeProperty, TSettings> : RangeTypeDescriptor<T, TSettings> where T : IRange<TRangeProperty> where TRangeProperty : struct
{
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public PropertyInfo info;

		internal object _003CPropertyGetter_003Eb__1()
		{
			return info.InitValue;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<GetterInfo, PropertyInfo, object> _003C_003E9__3_0;

		public static Action<SetterInfo, PropertyInfo> _003C_003E9__4_0;

		internal object _003CPropertyGetter_003Eb__3_0(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetRange<T, TRangeProperty>(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}

		internal void _003CPropertySetter_003Eb__4_0(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
			CS_0024_003C_003E8__locals0.info = info;
			ConvertHelper.SetRange<T, TRangeProperty>(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (T)setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public PropertyInfo info;

		internal object _003CPropertySetter_003Eb__1()
		{
			return info.InitValue;
		}
	}

	public RangeTypeDescriptor(ILogger logger)
		: base(logger)
	{
	}

	protected override object GetFromValue(T value)
	{
		return value.From;
	}

	protected override object GetToValue(T value)
	{
		return value.To;
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		return delegate(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetRange<T, TRangeProperty>(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
			CS_0024_003C_003E8__locals0.info = info;
			ConvertHelper.SetRange<T, TRangeProperty>(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (T)setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}
}
