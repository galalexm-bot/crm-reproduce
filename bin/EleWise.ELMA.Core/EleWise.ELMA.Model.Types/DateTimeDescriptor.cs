using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 600)]
public class DateTimeDescriptor : CLRTypeDescriptor<System.DateTime, DateTimeSettings>
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public PropertyInfo info;

		internal object _003CPropertyGetter_003Eb__2()
		{
			return info.InitValue;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_1
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

		public static Func<GetterInfo, PropertyInfo, object> _003C_003E9__6_0;

		public static Func<GetterInfo, PropertyInfo, object> _003C_003E9__6_1;

		public static Action<SetterInfo, PropertyInfo> _003C_003E9__7_0;

		public static Action<SetterInfo, PropertyInfo> _003C_003E9__7_1;

		internal object _003CPropertyGetter_003Eb__6_0(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetNullableDateTime(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}

		internal object _003CPropertyGetter_003Eb__6_1(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_1();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetDateTime(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}

		internal void _003CPropertySetter_003Eb__7_0(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
			CS_0024_003C_003E8__locals0.info = info;
			ConvertHelper.SetNullableDateTime(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (System.DateTime?)setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}

		internal void _003CPropertySetter_003Eb__7_1(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_1();
			CS_0024_003C_003E8__locals0.info = info;
			object obj = setterInfo.Value ?? ((object)System.DateTime.MinValue);
			ConvertHelper.SetDateTime(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (System.DateTime)obj, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public PropertyInfo info;

		internal object _003CPropertySetter_003Eb__2()
		{
			return info.InitValue;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_1
	{
		public PropertyInfo info;

		internal object _003CPropertySetter_003Eb__3()
		{
			return info.InitValue;
		}
	}

	public static readonly Guid UID = TypeConstants.DateTimeUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Дата / время");

	public DateTimeDescriptor(ILogger logger)
		: base(logger)
	{
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		if (propertyInfo.Nullable)
		{
			return delegate(GetterInfo getterInfo, PropertyInfo info)
			{
				_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
				CS_0024_003C_003E8__locals0.info = info;
				return ConvertHelper.GetNullableDateTime(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
			};
		}
		return delegate(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_1();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetDateTime(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		if (propertyInfo.Nullable)
		{
			return delegate(SetterInfo setterInfo, PropertyInfo info)
			{
				_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
				CS_0024_003C_003E8__locals0.info = info;
				ConvertHelper.SetNullableDateTime(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (System.DateTime?)setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
			};
		}
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_1();
			CS_0024_003C_003E8__locals0.info = info;
			object obj = setterInfo.Value ?? ((object)System.DateTime.MinValue);
			ConvertHelper.SetDateTime(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (System.DateTime)obj, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}

	public override TypeSettings CreateSettings()
	{
		DateTimeSettings obj = ObjectExtensions.As<DateTimeSettings>((object)base.CreateSettings());
		obj.set_ShowDate(true);
		obj.set_ShowTime(true);
		return (TypeSettings)(object)obj;
	}

	public override void InitSettingsFromSettings(TypeSettings typeSettings, TypeSettings newSettings)
	{
		DateTimeSettings obj = ObjectExtensions.As<DateTimeSettings>((object)typeSettings);
		DateTimeSettings val = ObjectExtensions.As<DateTimeSettings>((object)newSettings);
		obj.set_ShowDate(val.get_ShowDate());
		obj.set_ShowTime(val.get_ShowTime());
	}

	public override bool IsSupportSort()
	{
		return true;
	}
}
