using System;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Types.Models;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Model.Types;

[Component(Order = 900)]
public sealed class ActionDescriptor : CLRTypeDescriptor<object, ActionSettings>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<GetterInfo, PropertyInfo, object> _003C_003E9__9_0;

		public static Action<SetterInfo, PropertyInfo> _003C_003E9__10_0;

		internal object _003CPropertyGetter_003Eb__9_0(GetterInfo getterInfo, PropertyInfo info)
		{
			if (!(getterInfo.Target is ReactiveProxy reactiveProxy))
			{
				return null;
			}
			object result = default(object);
			if (!reactiveProxy.Actions.TryGetValue(info.Expression.ObjectExpression, ref result))
			{
				return null;
			}
			return result;
		}

		internal void _003CPropertySetter_003Eb__10_0(SetterInfo setterInfo, PropertyInfo info)
		{
			if (setterInfo.Target is ReactiveProxy reactiveProxy)
			{
				_ = setterInfo.Value;
				GlobalScopeHelper.GetScope();
				object obj = null;
				reactiveProxy.Actions.set_Item(info.Expression.ObjectExpression, obj);
			}
		}
	}

	private readonly ICurrentPageService currentPageService;

	public static readonly Guid UID = TypeConstants.ActionUid;

	public override Guid Uid => UID;

	public override string Name => SR.T("Действие");

	public override bool Visible => currentPageService.CurrentPageViewModel.RuntimeVersion == RuntimeVersion.Version2;

	public ActionDescriptor(ICurrentPageService currentPageService, ILogger logger)
		: base(logger)
	{
		this.currentPageService = currentPageService;
	}

	public override Func<GetterInfo, PropertyInfo, object> PropertyGetter(PropertyInfo propertyInfo)
	{
		return delegate(GetterInfo getterInfo, PropertyInfo info)
		{
			if (!(getterInfo.Target is ReactiveProxy reactiveProxy))
			{
				return null;
			}
			object obj = default(object);
			return (!reactiveProxy.Actions.TryGetValue(info.Expression.ObjectExpression, ref obj)) ? null : obj;
		};
	}

	public override Action<SetterInfo, PropertyInfo> PropertySetter(PropertyInfo propertyInfo)
	{
		return delegate(SetterInfo setterInfo, PropertyInfo info)
		{
			if (setterInfo.Target is ReactiveProxy reactiveProxy)
			{
				_ = setterInfo.Value;
				GlobalScopeHelper.GetScope();
				object obj = null;
				reactiveProxy.Actions.set_Item(info.Expression.ObjectExpression, obj);
			}
		};
	}

	public override void InitSettingsFromSettings(TypeSettings typeSettings, TypeSettings newSettings)
	{
	}
}
