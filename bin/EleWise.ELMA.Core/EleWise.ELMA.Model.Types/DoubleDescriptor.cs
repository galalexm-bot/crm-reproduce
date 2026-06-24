using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 500)]
public class DoubleDescriptor : CLRTypeDescriptor<double, DoubleSettings>
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public PropertyInfo info;

		internal object _003CPropertyGetter_003Eb__2()
		{
			return info.InitValue;
		}
	}

	private sealed class _003C_003Ec__DisplayClass8_1
	{
		public PropertyInfo info;

		internal object _003CPropertyGetter_003Eb__3()
		{
			return info.InitValue;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<GetterInfo, PropertyInfo, object> _003C_003E9__8_0;

		public static Func<GetterInfo, PropertyInfo, object> _003C_003E9__8_1;

		public static Action<SetterInfo, PropertyInfo> _003C_003E9__9_0;

		public static Action<SetterInfo, PropertyInfo> _003C_003E9__9_1;

		internal object _003CPropertyGetter_003Eb__8_0(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetNullableDouble(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}

		internal object _003CPropertyGetter_003Eb__8_1(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass8_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_1();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetDouble(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}

		internal void _003CPropertySetter_003Eb__9_0(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
			CS_0024_003C_003E8__locals0.info = info;
			ConvertHelper.SetNullableDouble(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (double?)setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}

		internal void _003CPropertySetter_003Eb__9_1(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass9_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_1();
			CS_0024_003C_003E8__locals0.info = info;
			object obj = setterInfo.Value ?? ((object)0.0);
			ConvertHelper.SetDouble(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (double)obj, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public PropertyInfo info;

		internal object _003CPropertySetter_003Eb__2()
		{
			return info.InitValue;
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_1
	{
		public PropertyInfo info;

		internal object _003CPropertySetter_003Eb__3()
		{
			return info.InitValue;
		}
	}

	public const double DoubleMaxValue = 1E+300;

	public const double DoubleMinValue = -1E+300;

	public static readonly Guid UID = TypeConstants.DoubleUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Дробное число");

	public DoubleDescriptor(ILogger logger)
		: base(logger)
	{
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		if (propertyInfo.Nullable)
		{
			return delegate(GetterInfo getterInfo, PropertyInfo info)
			{
				_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
				CS_0024_003C_003E8__locals0.info = info;
				return ConvertHelper.GetNullableDouble(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
			};
		}
		return delegate(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass8_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_1();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetDouble(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		if (propertyInfo.Nullable)
		{
			return delegate(SetterInfo setterInfo, PropertyInfo info)
			{
				_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
				CS_0024_003C_003E8__locals0.info = info;
				ConvertHelper.SetNullableDouble(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (double?)setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
			};
		}
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass9_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_1();
			CS_0024_003C_003E8__locals0.info = info;
			object obj = setterInfo.Value ?? ((object)0.0);
			ConvertHelper.SetDouble(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (double)obj, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}

	public override TypeSettings CreateSettings()
	{
		DoubleSettings obj = ObjectExtensions.As<DoubleSettings>((object)base.CreateSettings());
		obj.set_MaxValue(1E+300);
		obj.set_MinValue(-1E+300);
		return (TypeSettings)(object)obj;
	}

	public override void InitSettingsFromSettings(TypeSettings typeSettings, TypeSettings newSettings)
	{
		DoubleSettings obj = ObjectExtensions.As<DoubleSettings>((object)typeSettings);
		DoubleSettings val = ObjectExtensions.As<DoubleSettings>((object)newSettings);
		obj.set_MaxValue(val.get_MaxValue());
		obj.set_MinValue(val.get_MinValue());
		obj.set_RangeInFilter(val.get_RangeInFilter());
	}
}
