using System;
using System.Web;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 300)]
internal sealed class HtmlStringDescriptor : CLRTypeDescriptor<HtmlString, HtmlStringSettings>
{
	private sealed class _003C_003Ec__DisplayClass6_0
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

		public static Func<GetterInfo, PropertyInfo, object> _003C_003E9__6_0;

		public static Action<SetterInfo, PropertyInfo> _003C_003E9__7_0;

		internal object _003CPropertyGetter_003Eb__6_0(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetHtmlString(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}

		internal void _003CPropertySetter_003Eb__7_0(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
			CS_0024_003C_003E8__locals0.info = info;
			ConvertHelper.SetHtmlString(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (HtmlString)setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}
	}

	private sealed class _003C_003Ec__DisplayClass7_0
	{
		public PropertyInfo info;

		internal object _003CPropertySetter_003Eb__1()
		{
			return info.InitValue;
		}
	}

	public static readonly Guid UID = TypeConstants.HtmlStringUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("HTML разметка");

	public HtmlStringDescriptor(ILogger logger)
		: base(logger)
	{
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		return delegate(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetHtmlString(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
			CS_0024_003C_003E8__locals0.info = info;
			ConvertHelper.SetHtmlString(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (HtmlString)setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}

	public override TypeSettings CreateSettings()
	{
		HtmlStringSettings obj = ObjectExtensions.As<HtmlStringSettings>((object)base.CreateSettings());
		obj.set_NeedButtonELMA(true);
		obj.set_NeedButtonSource(true);
		return (TypeSettings)(object)obj;
	}

	public override void InitSettingsFromSettings(TypeSettings typeSettings, TypeSettings newSettings)
	{
		HtmlStringSettings obj = ObjectExtensions.As<HtmlStringSettings>((object)typeSettings);
		HtmlStringSettings val = ObjectExtensions.As<HtmlStringSettings>((object)newSettings);
		obj.set_NeedButtonELMA(val.get_NeedButtonELMA());
		obj.set_NeedButtonSource(val.get_NeedButtonSource());
	}
}
