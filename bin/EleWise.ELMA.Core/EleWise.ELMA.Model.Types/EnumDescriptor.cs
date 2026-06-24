using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 600)]
public class EnumDescriptor : SimpleTypeDescriptor<System.Enum, EnumSettings>
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public EnumConvertContext context;

		public EnumDescriptor _003C_003E4__this;

		public PropertyInfo propertyInfo;

		internal object _003CPropertyGetter_003Eb__0(GetterInfo getterInfo, PropertyInfo info)
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			_003C_003Ec__DisplayClass14_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_1();
			CS_0024_003C_003E8__locals0.info = info;
			if (context.Metadata == null)
			{
				context.Metadata = ObjectExtensions.As<EnumMetadata>((object)_003C_003E4__this.metadataServiceContext.GetMetadata(propertyInfo.PropertyMetadata.get_SubTypeUid()));
			}
			return ConvertHelper.GetEnum(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, CS_0024_003C_003E8__locals0.info.Nullable, context, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_1
	{
		public PropertyInfo info;

		internal object _003CPropertyGetter_003Eb__1()
		{
			return info.InitValue;
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public EnumConvertContext context;

		public EnumDescriptor _003C_003E4__this;

		public PropertyInfo propertyInfo;

		internal void _003CPropertySetter_003Eb__0(SetterInfo setterInfo, PropertyInfo info)
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			_003C_003Ec__DisplayClass15_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_1();
			CS_0024_003C_003E8__locals0.info = info;
			object value = setterInfo.Value;
			EnumWrapper value2;
			if (value is int num)
			{
				EnumMetadata val = context.Metadata;
				if (val == null)
				{
					val = (context.Metadata = ObjectExtensions.As<EnumMetadata>((object)_003C_003E4__this.metadataServiceContext.GetMetadata(propertyInfo.PropertyMetadata.get_SubTypeUid())));
				}
				value2 = ((val != null) ? EnumWrapper.CreateBase(num, val) : EnumWrapper.CreateBase(Guid.Empty, num, EnumMetadataType.Enum));
			}
			else
			{
				value2 = (EnumWrapper)value;
			}
			ConvertHelper.SetEnum(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, value2, CS_0024_003C_003E8__locals0.info.ShouldSerialize, CS_0024_003C_003E8__locals0.info.Nullable, context, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}
	}

	private sealed class _003C_003Ec__DisplayClass15_1
	{
		public PropertyInfo info;

		internal object _003CPropertySetter_003Eb__1()
		{
			return info.InitValue;
		}
	}

	internal readonly IMetadataServiceContext metadataServiceContext;

	private readonly IProxyGeneratorService proxyGeneratorService;

	public static readonly Guid UID = TypeConstants.EnumUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Перечисления");

	public override Guid ParentUid => Guid.Empty;

	public override bool CanBeNullable => true;

	public override bool? DefaultNullableValue => false;

	public EnumDescriptor(IMetadataServiceContext metadataServiceContext, IProxyGeneratorService proxyGeneratorService, ILogger logger)
		: base(logger)
	{
		this.metadataServiceContext = metadataServiceContext;
		this.proxyGeneratorService = proxyGeneratorService;
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass14_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.propertyInfo = propertyInfo;
		CS_0024_003C_003E8__locals0.context = new EnumConvertContext
		{
			Metadata = ObjectExtensions.As<EnumMetadata>((object)metadataServiceContext.GetMetadata(CS_0024_003C_003E8__locals0.propertyInfo.PropertyMetadata.get_SubTypeUid())),
			ProxyGeneratorService = proxyGeneratorService
		};
		return delegate(GetterInfo getterInfo, PropertyInfo info)
		{
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_1();
			CS_0024_003C_003E8__locals0.info = info;
			if (CS_0024_003C_003E8__locals0.context.Metadata == null)
			{
				CS_0024_003C_003E8__locals0.context.Metadata = ObjectExtensions.As<EnumMetadata>((object)CS_0024_003C_003E8__locals0._003C_003E4__this.metadataServiceContext.GetMetadata(CS_0024_003C_003E8__locals0.propertyInfo.PropertyMetadata.get_SubTypeUid()));
			}
			return ConvertHelper.GetEnum(getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, CS_0024_003C_003E8__locals0.info.Nullable, CS_0024_003C_003E8__locals0.context, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass15_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.propertyInfo = propertyInfo;
		CS_0024_003C_003E8__locals0.context = new EnumConvertContext
		{
			Metadata = ObjectExtensions.As<EnumMetadata>((object)metadataServiceContext.GetMetadata(CS_0024_003C_003E8__locals0.propertyInfo.PropertyMetadata.get_SubTypeUid())),
			ProxyGeneratorService = proxyGeneratorService
		};
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_1();
			CS_0024_003C_003E8__locals0.info = info;
			object value = setterInfo.Value;
			EnumWrapper value2;
			if (value is int num)
			{
				EnumMetadata val = CS_0024_003C_003E8__locals0.context.Metadata;
				if (val == null)
				{
					val = (CS_0024_003C_003E8__locals0.context.Metadata = ObjectExtensions.As<EnumMetadata>((object)CS_0024_003C_003E8__locals0._003C_003E4__this.metadataServiceContext.GetMetadata(CS_0024_003C_003E8__locals0.propertyInfo.PropertyMetadata.get_SubTypeUid())));
				}
				value2 = ((val != null) ? EnumWrapper.CreateBase(num, val) : EnumWrapper.CreateBase(Guid.Empty, num, EnumMetadataType.Enum));
			}
			else
			{
				value2 = (EnumWrapper)value;
			}
			ConvertHelper.SetEnum(setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, value2, CS_0024_003C_003E8__locals0.info.ShouldSerialize, CS_0024_003C_003E8__locals0.info.Nullable, CS_0024_003C_003E8__locals0.context, () => CS_0024_003C_003E8__locals0.info.InitValue);
		};
	}

	public override TypeSettings CreateSettings()
	{
		EnumSettings obj = ObjectExtensions.As<EnumSettings>((object)base.CreateSettings());
		obj.set_MaxCount(100);
		return (TypeSettings)(object)obj;
	}

	public override void InitSettingsFromSettings(TypeSettings typeSettings, TypeSettings newSettings)
	{
		EnumSettings obj = ObjectExtensions.As<EnumSettings>((object)typeSettings);
		EnumSettings val = ObjectExtensions.As<EnumSettings>((object)newSettings);
		obj.set_MaxCount(val.get_MaxCount());
	}
}
