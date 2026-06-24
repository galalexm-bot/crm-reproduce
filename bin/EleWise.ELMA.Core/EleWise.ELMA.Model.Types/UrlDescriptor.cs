using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 1100)]
public class UrlDescriptor : CLRTypeDescriptor<Uri, UrlSettings>
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
			return ConvertHelper.GetUri(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}

		internal void _003CPropertySetter_003Eb__7_0(SetterInfo setterInfo, PropertyInfo info)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
			CS_0024_003C_003E8__locals0.info = info;
			ConvertHelper.SetUri(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (Uri)setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
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

	public static readonly Guid UID = TypeConstants.UrlUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("URL");

	public UrlDescriptor(ILogger logger)
		: base(logger)
	{
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		return delegate(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetUri(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
			CS_0024_003C_003E8__locals0.info = info;
			ConvertHelper.SetUri(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (Uri)setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}
}
