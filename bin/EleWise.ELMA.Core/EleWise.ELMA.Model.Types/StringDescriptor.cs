using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 100)]
public class StringDescriptor : StringDescriptor<StringSettings>
{
	public static readonly Guid UID = TypeConstants.StringUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Строка");

	public StringDescriptor(ILogger logger)
		: base(logger)
	{
	}
}
public abstract class StringDescriptor<TSettings> : CLRTypeDescriptor<string, TSettings> where TSettings : StringSettings
{
	private sealed class _003C_003Ec__DisplayClass1_0
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

		public static Func<GetterInfo, PropertyInfo, object> _003C_003E9__1_0;

		public static Action<SetterInfo, PropertyInfo> _003C_003E9__2_0;

		internal object _003CPropertyGetter_003Eb__1_0(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetString(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}

		internal void _003CPropertySetter_003Eb__2_0(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
			CS_0024_003C_003E8__locals0.info = info;
			ConvertHelper.SetString(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (string)setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}
	}

	private sealed class _003C_003Ec__DisplayClass2_0
	{
		public PropertyInfo info;

		internal object _003CPropertySetter_003Eb__1()
		{
			return info.InitValue;
		}
	}

	public StringDescriptor(ILogger logger)
		: base(logger)
	{
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		return delegate(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass1_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass1_0();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetString(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
			CS_0024_003C_003E8__locals0.info = info;
			ConvertHelper.SetString(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (string)setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}

	public override void InitSettingsFromSettings(TypeSettings typeSettings, TypeSettings newSettings)
	{
		StringSettings obj = ObjectExtensions.As<StringSettings>((object)typeSettings);
		StringSettings val = ObjectExtensions.As<StringSettings>((object)newSettings);
		obj.set_MultiLine(val.get_MultiLine());
		obj.set_MinValue(val.get_MinValue());
		obj.set_MaxValue(val.get_MaxValue());
		obj.set_RegularExpression(val.get_RegularExpression());
		obj.set_RegularExpressionMessage(val.get_RegularExpressionMessage());
	}
}
