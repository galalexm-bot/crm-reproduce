using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

[Component]
internal sealed class PasswordDescriptor : CLRTypeDescriptor<PasswordInfo, PasswordSettings>
{
	private sealed class _003C_003Ec__DisplayClass8_0
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

		public static Func<GetterInfo, PropertyInfo, object> _003C_003E9__8_0;

		public static Action<SetterInfo, PropertyInfo> _003C_003E9__9_0;

		internal object _003CPropertyGetter_003Eb__8_0(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetPassword(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}

		internal void _003CPropertySetter_003Eb__9_0(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
			CS_0024_003C_003E8__locals0.info = info;
			if (setterInfo.Value is PasswordInfo value)
			{
				ConvertHelper.SetPassword(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
			}
			else
			{
				ConvertHelper.SetString(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (string)setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
			}
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public PropertyInfo info;

		internal object _003CPropertySetter_003Eb__1()
		{
			return info.InitValue;
		}

		internal object _003CPropertySetter_003Eb__2()
		{
			return info.InitValue;
		}
	}

	internal readonly ConvertContext context;

	public override Guid Uid => TypeConstants.PasswordTypeUid;

	public override string Name => SR.T("Пароль");

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public PasswordDescriptor(IProxyGeneratorService proxyGeneratorService, IExtendEntityService extendEntityService, ILogger logger)
		: base(logger)
	{
		context = new ConvertContext
		{
			ProxyGeneratorService = proxyGeneratorService,
			ExtendEntityService = extendEntityService
		};
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		return delegate(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetPassword(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
			CS_0024_003C_003E8__locals0.info = info;
			if (setterInfo.Value is PasswordInfo value)
			{
				ConvertHelper.SetPassword(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
			}
			else
			{
				ConvertHelper.SetString(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, (string)setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, () => CS_0024_003C_003E8__locals0.info.InitValue);
			}
		};
	}
}
