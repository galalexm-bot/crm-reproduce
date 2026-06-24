using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

internal sealed class FormViewItemDescriptor : CLRTypeDescriptor<FormViewItem>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<GetterInfo, PropertyInfo, object> _003C_003E9__10_0;

		public static Action<SetterInfo, PropertyInfo> _003C_003E9__11_0;

		internal object _003CPropertyGetter_003Eb__10_0(GetterInfo getterInfo, PropertyInfo info)
		{
			return ConvertHelper.GetViewItem(getterInfo.Target, info.Expression, info.ShouldSerialize);
		}

		internal void _003CPropertySetter_003Eb__11_0(SetterInfo setterInfo, PropertyInfo info)
		{
			FormViewItem formViewItem = null;
			object value = setterInfo.Value;
			if (value != null)
			{
				formViewItem = value as FormViewItem;
				if (formViewItem == null)
				{
					return;
				}
			}
			ConvertHelper.SetViewItem(setterInfo.Target, info.Expression, formViewItem, info.ShouldSerialize);
		}
	}

	public static readonly Guid UID = TypeConstants.FormViewItemUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Форма");

	public override bool Visible => false;

	public override Guid ParentUid => SystemTypesDescriptor.UID;

	public FormViewItemDescriptor(ILogger logger)
		: base(logger)
	{
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		return (GetterInfo getterInfo, PropertyInfo info) => ConvertHelper.GetViewItem(getterInfo.Target, info.Expression, info.ShouldSerialize);
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			FormViewItem formViewItem = null;
			object value = setterInfo.Value;
			if (value != null)
			{
				formViewItem = value as FormViewItem;
				if (formViewItem == null)
				{
					return;
				}
			}
			ConvertHelper.SetViewItem(setterInfo.Target, info.Expression, formViewItem, info.ShouldSerialize);
		};
	}
}
