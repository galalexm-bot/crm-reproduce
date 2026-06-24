using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 1000)]
public class MoneyDescriptor : CLRTypeDescriptor<Money, MoneySettings>
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public PropertyInfo info;

		internal object _003CPropertyGetter_003Eb__1()
		{
			Money money = (Money)info.InitValue;
			if (money.HasValue)
			{
				return money.Value;
			}
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<GetterInfo, PropertyInfo, object> _003C_003E9__8_0;

		public static Action<SetterInfo, PropertyInfo> _003C_003E9__9_0;

		internal object _003CPropertyGetter_003Eb__8_0(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
			CS_0024_003C_003E8__locals0.info = info;
			return new Money(ConvertHelper.GetNullableDouble(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, delegate
			{
				Money money = (Money)CS_0024_003C_003E8__locals0.info.InitValue;
				return money.HasValue ? ((object)money.Value) : null;
			}));
		}

		internal void _003CPropertySetter_003Eb__9_0(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
			CS_0024_003C_003E8__locals0.info = info;
			Money money = (Money)setterInfo.Value;
			ConvertHelper.SetNullableDouble(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, money.HasValue ? new double?(money.Value) : null, CS_0024_003C_003E8__locals0.info.ShouldSerialize, delegate
			{
				Money money2 = (Money)CS_0024_003C_003E8__locals0.info.InitValue;
				return money2.HasValue ? ((object)money2.Value) : null;
			});
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public PropertyInfo info;

		internal object _003CPropertySetter_003Eb__1()
		{
			Money money = (Money)info.InitValue;
			if (money.HasValue)
			{
				return money.Value;
			}
			return null;
		}
	}

	public static readonly Guid UID = TypeConstants.MoneyUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Деньги");

	public override bool CanBeNullable => false;

	public MoneyDescriptor(ILogger logger)
		: base(logger)
	{
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		return delegate(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
			CS_0024_003C_003E8__locals0.info = info;
			return new Money(ConvertHelper.GetNullableDouble(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, delegate
			{
				Money money = (Money)CS_0024_003C_003E8__locals0.info.InitValue;
				return money.HasValue ? ((object)money.Value) : null;
			}));
		};
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
			CS_0024_003C_003E8__locals0.info = info;
			Money money = (Money)setterInfo.Value;
			ConvertHelper.SetNullableDouble(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, money.HasValue ? new double?(money.Value) : null, CS_0024_003C_003E8__locals0.info.ShouldSerialize, delegate
			{
				Money money2 = (Money)CS_0024_003C_003E8__locals0.info.InitValue;
				return money2.HasValue ? ((object)money2.Value) : null;
			});
		};
	}

	public override TypeSettings CreateSettings()
	{
		MoneySettings obj = ObjectExtensions.As<MoneySettings>((object)base.CreateSettings());
		obj.set_MaxValue(1E+300);
		obj.set_MinValue(-1E+300);
		return (TypeSettings)(object)obj;
	}

	public override void InitSettingsFromSettings(TypeSettings typeSettings, TypeSettings newSettings)
	{
		Int32Settings obj = ObjectExtensions.As<Int32Settings>((object)typeSettings);
		Int32Settings val = ObjectExtensions.As<Int32Settings>((object)newSettings);
		obj.set_MaxValue(val.get_MaxValue());
		obj.set_MinValue(val.get_MinValue());
		obj.set_RangeInFilter(val.get_RangeInFilter());
	}
}
