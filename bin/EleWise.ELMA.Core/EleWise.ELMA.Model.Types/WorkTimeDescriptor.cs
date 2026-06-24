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
public class WorkTimeDescriptor : CLRTypeDescriptor<WorkTime, WorkTimeSettings>
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public long? defaultWorkTime;

		internal object _003CPropertyGetter_003Eb__2()
		{
			return defaultWorkTime;
		}
	}

	private sealed class _003C_003Ec__DisplayClass6_1
	{
		public long? defaultWorkTime;

		internal object _003CPropertyGetter_003Eb__3()
		{
			return defaultWorkTime;
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
			CS_0024_003C_003E8__locals0.defaultWorkTime = ((WorkTime?)info.InitValue)?.Value;
			long? nullableInt = ConvertHelper.GetNullableInt64(getterInfo.Target, info.Expression, info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.defaultWorkTime);
			if (nullableInt.get_HasValue())
			{
				return new WorkTime(nullableInt);
			}
			return null;
		}

		internal object _003CPropertyGetter_003Eb__6_1(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_1();
			CS_0024_003C_003E8__locals0.defaultWorkTime = ((WorkTime?)info.InitValue)?.Value;
			return new WorkTime(ConvertHelper.GetInt64(getterInfo.Target, info.Expression, info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.defaultWorkTime));
		}

		internal void _003CPropertySetter_003Eb__7_0(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
			CS_0024_003C_003E8__locals0.defaultWorkTime = ((WorkTime?)info.InitValue)?.Value;
			WorkTime? workTime = (WorkTime?)setterInfo.Value;
			ConvertHelper.SetNullableInt64(setterInfo.Target, info.Expression, workTime?.Value, info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.defaultWorkTime);
		}

		internal void _003CPropertySetter_003Eb__7_1(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_1();
			CS_0024_003C_003E8__locals0.defaultWorkTime = ((WorkTime?)info.InitValue)?.Value;
			ConvertHelper.SetInt64(value: ((WorkTime)setterInfo.Value).Value, target: setterInfo.Target, expression: info.Expression, shouldSerialize: info.ShouldSerialize, initValue: () => CS_0024_003C_003E8__locals0.defaultWorkTime);
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public long? defaultWorkTime;

		internal object _003CPropertySetter_003Eb__2()
		{
			return defaultWorkTime;
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_1
	{
		public long? defaultWorkTime;

		internal object _003CPropertySetter_003Eb__3()
		{
			return defaultWorkTime;
		}
	}

	public static readonly Guid UID = TypeConstants.WorkTimeUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Интервал рабочего времени");

	public WorkTimeDescriptor(ILogger logger)
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
				CS_0024_003C_003E8__locals0.defaultWorkTime = ((WorkTime?)info.InitValue)?.Value;
				long? nullableInt = ConvertHelper.GetNullableInt64(getterInfo.Target, info.Expression, info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.defaultWorkTime);
				return nullableInt.get_HasValue() ? ((object)new WorkTime(nullableInt)) : null;
			};
		}
		return delegate(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_1();
			CS_0024_003C_003E8__locals0.defaultWorkTime = ((WorkTime?)info.InitValue)?.Value;
			return new WorkTime(ConvertHelper.GetInt64(getterInfo.Target, info.Expression, info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.defaultWorkTime));
		};
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		if (propertyInfo.Nullable)
		{
			return delegate(SetterInfo setterInfo, PropertyInfo info)
			{
				_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
				CS_0024_003C_003E8__locals0.defaultWorkTime = ((WorkTime?)info.InitValue)?.Value;
				WorkTime? workTime = (WorkTime?)setterInfo.Value;
				ConvertHelper.SetNullableInt64(setterInfo.Target, info.Expression, workTime?.Value, info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.defaultWorkTime);
			};
		}
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass7_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_1();
			CS_0024_003C_003E8__locals0.defaultWorkTime = ((WorkTime?)info.InitValue)?.Value;
			ConvertHelper.SetInt64(value: ((WorkTime)setterInfo.Value).Value, target: setterInfo.Target, expression: info.Expression, shouldSerialize: info.ShouldSerialize, initValue: () => CS_0024_003C_003E8__locals0.defaultWorkTime);
		};
	}
}
