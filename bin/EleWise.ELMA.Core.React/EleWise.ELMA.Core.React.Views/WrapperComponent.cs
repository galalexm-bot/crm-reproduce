using System;
using System.Collections.Generic;
using System.Linq;
using Bridge;
using Bridge.React;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Core.Model;
using EleWise.ELMA.Core.React.Components;
using EleWise.ELMA.Core.React.ExtensionPoints;
using EleWise.ELMA.Core.React.Helpers;
using EleWise.ELMA.Core.React.Models;
using EleWise.ELMA.Core.React.Services;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.React.Views;

public class WrapperComponent : BaseReactComponent<WrapperComponent.WrapperComponentInputs, WrapperComponent.WrapperComponentContext, WrapperComponent.WrapperController>
{
	public class WrapperComponentInputs : Inputs
	{
		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

			public static Func<ReactElement[]> _003C_003E9__16_0;

			internal ReactElement[] _003C_002Ector_003Eb__16_0()
			{
				return null;
			}
		}

		private Func<IViewItem> _003CViewItem_003Ek__BackingField;

		private Func<ReactElement[]> _003CContent_003Ek__BackingField = () => null;

		private Func<string> _003CSlotName_003Ek__BackingField;

		private Func<string> _003CCaption_003Ek__BackingField;

		public Func<IViewItem> ViewItem
		{
			get
			{
				return _003CViewItem_003Ek__BackingField;
			}
			set
			{
				_003CViewItem_003Ek__BackingField = value;
			}
		}

		public Func<ReactElement[]> Content
		{
			get
			{
				return _003CContent_003Ek__BackingField;
			}
			set
			{
				_003CContent_003Ek__BackingField = value;
			}
		}

		public Func<string> SlotName
		{
			get
			{
				return _003CSlotName_003Ek__BackingField;
			}
			set
			{
				_003CSlotName_003Ek__BackingField = value;
			}
		}

		public Func<string> Caption
		{
			get
			{
				return _003CCaption_003Ek__BackingField;
			}
			set
			{
				_003CCaption_003Ek__BackingField = value;
			}
		}
	}

	public class WrapperComponentContext : WrapperComponentInputs, IContext
	{
	}

	public class WrapperController : Controller<WrapperComponentContext>, IRequireOwnerController
	{
		private sealed class _003C_003Ec__DisplayClass4_0
		{
			public IViewItem viewItem;

			public WrapperController _003C_003E4__this;

			public ElementWrapperType wrapperType;

			internal bool _003CGetElementWrapper_003Eb__0(IElementWrapper r)
			{
				return r.CanWrap(viewItem, _003C_003E4__this.currentViewModel, wrapperType);
			}
		}

		private readonly System.Collections.Generic.IEnumerable<IElementWrapper> elementWrappers;

		private IViewModel currentViewModel;

		public WrapperController(System.Collections.Generic.IEnumerable<IElementWrapper> elementWrappers)
		{
			this.elementWrappers = elementWrappers;
		}

		public void SetOwner(IViewModel owner)
		{
			currentViewModel = owner;
		}

		public System.Type GetElementWrapper(IViewItem viewItem, ElementWrapperType wrapperType)
		{
			_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
			CS_0024_003C_003E8__locals0.viewItem = viewItem;
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.wrapperType = wrapperType;
			return Enumerable.FirstOrDefault<IElementWrapper>(elementWrappers, (Func<IElementWrapper, bool>)((IElementWrapper r) => r.CanWrap(CS_0024_003C_003E8__locals0.viewItem, CS_0024_003C_003E8__locals0._003C_003E4__this.currentViewModel, CS_0024_003C_003E8__locals0.wrapperType)))?.Type;
		}

		internal IWrapModel CreateModel(IViewItem viewItem, string slotName, string caption = null)
		{
			WrapModel wrapModel = ((caption == null) ? new WrapModel(viewItem, slotName) : new WrapModel(viewItem, slotName, caption));
			if (string.IsNullOrWhiteSpace(caption) && viewItem is UnknownTypeViewItem unknownTypeViewItem)
			{
				wrapModel.Caption = unknownTypeViewItem.GetTypeName();
			}
			return wrapModel;
		}
	}

	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public WrapperComponent _003C_003E4__this;

		public string slotName;

		internal ReactElement _003CView_003Eb__0(ReactElement child)
		{
			return _003C_003E4__this.OuterWrap(child.GetViewItem(), slotName, child);
		}
	}

	private sealed class _003C_003Ec__DisplayClass4_0
	{
		public WrapperComponent _003C_003E4__this;

		public IViewItem viewItem;

		public string slotName;

		internal IWrapModel _003COuterWrap_003Eb__0()
		{
			return _003C_003E4__this.Controller.CreateModel(viewItem, slotName);
		}
	}

	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public WrapperComponent _003C_003E4__this;

		public IViewItem viewItem;

		public string slotName;

		public string caption;

		internal IWrapModel _003CInnerWrap_003Eb__0()
		{
			return _003C_003E4__this.Controller.CreateModel(viewItem, slotName, caption);
		}
	}

	public WrapperComponent(IReactInputModel<WrapperComponentInputs> model)
		: base(model)
	{
	}

	public override ReactElement View()
	{
		_003C_003Ec__DisplayClass3_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.slotName = Context.SlotName?.Invoke();
		string caption = Context.Caption?.Invoke();
		ReactElement[] elements = Enumerable.Select<ReactElement, ReactElement>((System.Collections.Generic.IEnumerable<ReactElement>)Context.Content.Invoke(), (Func<ReactElement, ReactElement>)((ReactElement child) => CS_0024_003C_003E8__locals0._003C_003E4__this.OuterWrap(child.GetViewItem(), CS_0024_003C_003E8__locals0.slotName, child))).ToArray();
		return InnerWrap(Context.ViewItem.Invoke(), CS_0024_003C_003E8__locals0.slotName, caption, elements);
	}

	protected ReactElement OuterWrap(IViewItem viewItem, string slotName, params ReactElement[] elements)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.viewItem = viewItem;
		CS_0024_003C_003E8__locals0.slotName = slotName;
		if (CS_0024_003C_003E8__locals0.viewItem == null)
		{
			Props val = new Props();
			val.set_Key(Union<int, string>.op_Implicit("WrapperComponent_OuterWrap"));
			return Fragment.op_Implicit(new Fragment(val, (System.Collections.Generic.IEnumerable<ReactElement>)elements));
		}
		System.Type elementWrapper = base.Controller.GetElementWrapper(CS_0024_003C_003E8__locals0.viewItem, ElementWrapperType.Outer);
		Guid uid;
		if (elementWrapper == null)
		{
			Props val2 = new Props();
			string key = base.InputModel.Key;
			uid = CS_0024_003C_003E8__locals0.viewItem.Uid;
			val2.set_Key(Union<int, string>.op_Implicit("WrapperComponent_OuterWrap" + key + ((object)(Guid)(ref uid)).ToString()));
			return Fragment.op_Implicit(new Fragment(val2, (System.Collections.Generic.IEnumerable<ReactElement>)elements));
		}
		IReactComponentCreatorService reactComponentCreatorService = base.ViewModel.ReactComponentCreatorService;
		WrapperInputs wrapperInputs = new WrapperInputs();
		string key2 = base.InputModel.Key;
		uid = CS_0024_003C_003E8__locals0.viewItem.Uid;
		wrapperInputs.Key = "WrapperComponent_OuterWrap" + key2 + ((object)(Guid)(ref uid)).ToString();
		wrapperInputs.WrapModel = () => CS_0024_003C_003E8__locals0._003C_003E4__this.Controller.CreateModel(CS_0024_003C_003E8__locals0.viewItem, CS_0024_003C_003E8__locals0.slotName);
		wrapperInputs.Children = elements;
		return reactComponentCreatorService.Create(elementWrapper, wrapperInputs, base.ViewModel.RenderOwner).ToReactElement();
	}

	protected ReactElement InnerWrap(IViewItem viewItem, string slotName, string caption, params ReactElement[] elements)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.viewItem = viewItem;
		CS_0024_003C_003E8__locals0.slotName = slotName;
		CS_0024_003C_003E8__locals0.caption = caption;
		System.Type elementWrapper = base.Controller.GetElementWrapper(CS_0024_003C_003E8__locals0.viewItem, ElementWrapperType.Inner);
		if (elementWrapper == null)
		{
			Props val = new Props();
			val.set_Key(Union<int, string>.op_Implicit("WrapperComponent_InnerWrap" + base.InputModel.Key));
			return Fragment.op_Implicit(new Fragment(val, (System.Collections.Generic.IEnumerable<ReactElement>)elements));
		}
		return base.ViewModel.ReactComponentCreatorService.Create(elementWrapper, new WrapperInputs
		{
			Key = "WrapperComponent_InnerWrap" + base.InputModel.Key,
			WrapModel = () => CS_0024_003C_003E8__locals0._003C_003E4__this.Controller.CreateModel(CS_0024_003C_003E8__locals0.viewItem, CS_0024_003C_003E8__locals0.slotName, CS_0024_003C_003E8__locals0.caption),
			Children = elements
		}, base.ViewModel.RenderOwner).ToReactElement();
	}
}
