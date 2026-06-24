using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

internal sealed class AnyTypeDescriptor : TypeDescriptor
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<GetterInfo, PropertyInfo, object> _003C_003E9__17_0;

		public static Action<SetterInfo, PropertyInfo> _003C_003E9__18_0;

		internal object _003CPropertyGetter_003Eb__17_0(GetterInfo getterInfo, PropertyInfo info)
		{
			return ConvertHelper.GetObject(getterInfo.Target, info.Expression, info.ShouldSerialize);
		}

		internal void _003CPropertySetter_003Eb__18_0(SetterInfo setterInfo, PropertyInfo info)
		{
			ConvertHelper.SetObject(setterInfo.Target, info.Expression, setterInfo.Value, info.ShouldSerialize);
		}
	}

	private readonly IApplicationData applicationData;

	public static readonly Guid UID = TypeConstants.AnyTypeUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Произвольный тип");

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

	public override bool CanBeNullable => false;

	public override bool? DefaultNullableValue => null;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public override bool UseForEntity => false;

	public AnyTypeDescriptor(IApplicationData applicationData, ILogger logger)
		: base(logger)
	{
		this.applicationData = applicationData;
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		return (GetterInfo getterInfo, PropertyInfo info) => ConvertHelper.GetObject(getterInfo.Target, info.Expression, info.ShouldSerialize);
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			ConvertHelper.SetObject(setterInfo.Target, info.Expression, setterInfo.Value, info.ShouldSerialize);
		};
	}

	public override TypeSettings CreateSettings()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		return (TypeSettings)InterfaceCreator.Create(typeof(AnyTypeSettings));
	}

	public override void InitSettingsFromSettings(TypeSettings typeSettings, TypeSettings newSettings)
	{
		AnyTypeSettings obj = ObjectExtensions.As<AnyTypeSettings>((object)typeSettings);
		AnyTypeSettings val = ObjectExtensions.As<AnyTypeSettings>((object)newSettings);
		obj.set_FullTypeName(val.get_FullTypeName());
	}
}
