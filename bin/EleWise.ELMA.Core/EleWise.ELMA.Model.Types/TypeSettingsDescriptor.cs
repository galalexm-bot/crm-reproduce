using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

public class TypeSettingsDescriptor : CLRTypeDescriptor<TypeSettings, TypeSettingsSettings>
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public ProxyType typeSettingsProxyType;

		public TypeSettingsDescriptor _003C_003E4__this;

		internal object _003CPropertyGetter_003Eb__0(GetterInfo getterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass12_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_1();
			CS_0024_003C_003E8__locals0.info = info;
			return ConvertHelper.GetContract(typeSettingsProxyType, getterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, CS_0024_003C_003E8__locals0.info.ShouldSerialize, _003C_003E4__this.context, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_1
	{
		public PropertyInfo info;

		internal object _003CPropertyGetter_003Eb__1()
		{
			return info.InitValue;
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_0
	{
		public ProxyType typeSettingsProxyType;

		public TypeSettingsDescriptor _003C_003E4__this;

		internal void _003CPropertySetter_003Eb__0(SetterInfo setterInfo, PropertyInfo info)
		{
			_003C_003Ec__DisplayClass13_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_1();
			CS_0024_003C_003E8__locals0.info = info;
			ConvertHelper.SetContract(typeSettingsProxyType, setterInfo.Target, CS_0024_003C_003E8__locals0.info.Expression, setterInfo.Value, CS_0024_003C_003E8__locals0.info.ShouldSerialize, _003C_003E4__this.context, () => CS_0024_003C_003E8__locals0.info.InitValue);
		}
	}

	private sealed class _003C_003Ec__DisplayClass13_1
	{
		public PropertyInfo info;

		internal object _003CPropertySetter_003Eb__1()
		{
			return info.InitValue;
		}
	}

	private readonly IApplicationData applicationData;

	private readonly ConvertContext context;

	public static readonly Guid UID = TypeConstants.TypeSettingsUid;

	public override Guid Uid => UID;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override string Name => SR.T("Настройки типа данных");

	public override bool Visible
	{
		get
		{
			if (base.Visible)
			{
				return applicationData.InterfaceBuilderMode == InterfaceBuilderMode.DevServer;
			}
			return false;
		}
	}

	public TypeSettingsDescriptor(IProxyGeneratorService proxyGeneratorService, IApplicationData applicationData, ILogger logger)
		: base(logger)
	{
		this.applicationData = applicationData;
		context = new ConvertContext
		{
			ProxyGeneratorService = proxyGeneratorService
		};
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		return new _003C_003Ec__DisplayClass12_0
		{
			_003C_003E4__this = this,
			typeSettingsProxyType = DTOHelper.ProxyType("b4b6d6ec-d534-49b5-a962-9afe59fd33f7")
		}._003CPropertyGetter_003Eb__0;
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		return new _003C_003Ec__DisplayClass13_0
		{
			_003C_003E4__this = this,
			typeSettingsProxyType = DTOHelper.ProxyType("b4b6d6ec-d534-49b5-a962-9afe59fd33f7")
		}._003CPropertySetter_003Eb__0;
	}
}
