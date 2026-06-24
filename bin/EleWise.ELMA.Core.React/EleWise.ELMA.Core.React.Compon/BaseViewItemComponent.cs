using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using Bridge.Html5;
using Bridge.React;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Core.Model;
using EleWise.ELMA.Core.React.Helpers;
using EleWise.ELMA.Core.React.Models;
using EleWise.ELMA.Core.React.Views;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.React.Components;

[Component]
public abstract class BaseViewItemComponent<TViewItem, TInputs, TContext, TController> : BaseReactComponent<TInputs, TContext, TController> where TViewItem : IViewItem where TInputs : IInputs where TContext : IContext where TController : IController
{
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public BaseViewItemComponent<TViewItem, TInputs, TContext, TController> _003C_003E4__this;

		public bool hasOnEscape;

		public bool hasOnEnter;

		internal void _003CGetOnKeyDown_003Eb__0(KeyboardEvent<HTMLElement> e)
		{
			_003C_003Ec__DisplayClass20_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = this;
			CS_0024_003C_003E8__locals0.e = e;
			_003C_003E4__this.Dispatcher.Dispatch((Func<TController, System.Threading.Tasks.Task>)(object)(Func<_003F, System.Threading.Tasks.Task>)delegate
			{
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				//IL_000f: Unknown result type (might be due to invalid IL or missing references)
				//IL_001d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0022: Unknown result type (might be due to invalid IL or missing references)
				_003C_003Ec__DisplayClass20_1._003C_003CGetOnKeyDown_003Eb__1_003Ed _003C_003CGetOnKeyDown_003Eb__1_003Ed = default(_003C_003Ec__DisplayClass20_1._003C_003CGetOnKeyDown_003Eb__1_003Ed);
				_003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
				_003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				_003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003E1__state = -1;
				AsyncTaskMethodBuilder _003C_003Et__builder = _003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003Et__builder;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003C_003Ec__DisplayClass20_1._003C_003CGetOnKeyDown_003Eb__1_003Ed>(ref _003C_003CGetOnKeyDown_003Eb__1_003Ed);
				return ((AsyncTaskMethodBuilder)(ref _003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003Et__builder)).get_Task();
			});
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_1
	{
		[StructLayout(3)]
		private struct _003C_003CGetOnKeyDown_003Eb__1_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public _003C_003Ec__DisplayClass20_1 _003C_003E4__this;

			private object _003C_003Eu__1;

			private void MoveNext()
			{
				//IL_009b: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Expected O, but got Unknown
				//IL_013c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0142: Expected O, but got Unknown
				int num = _003C_003E1__state;
				_003C_003Ec__DisplayClass20_1 _003C_003Ec__DisplayClass20_ = _003C_003E4__this;
				try
				{
					TaskAwaiter val;
					if (num != 0)
					{
						if (num == 1)
						{
							val = (TaskAwaiter)_003C_003Eu__1;
							_003C_003Eu__1 = null;
							num = (_003C_003E1__state = -1);
							goto IL_0152;
						}
						if (!((_003C_003Ec__DisplayClass20_.e.Key == "Escape") & _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.hasOnEscape))
						{
							goto IL_00c2;
						}
						val = _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.ViewItem.OnEscape.Call().GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003C_003CGetOnKeyDown_003Eb__1_003Ed>(ref val, ref this);
							return;
						}
					}
					else
					{
						val = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
					}
					val.GetResult();
					((SyntheticEvent<HTMLElement>)(object)_003C_003Ec__DisplayClass20_.e).StopPropagation();
					goto IL_00c2;
					IL_0152:
					val.GetResult();
					((SyntheticEvent<HTMLElement>)(object)_003C_003Ec__DisplayClass20_.e).StopPropagation();
					goto end_IL_000e;
					IL_00c2:
					if ((_003C_003Ec__DisplayClass20_.e.Key == "Enter") & _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1.hasOnEnter)
					{
						val = _003C_003Ec__DisplayClass20_.CS_0024_003C_003E8__locals1._003C_003E4__this.ViewItem.OnEnter.Call().GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003C_003CGetOnKeyDown_003Eb__1_003Ed>(ref val, ref this);
							return;
						}
						goto IL_0152;
					}
					end_IL_000e:;
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
			}
		}

		public KeyboardEvent<HTMLElement> e;

		public _003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals1;

		internal System.Threading.Tasks.Task _003CGetOnKeyDown_003Eb__1(TController c)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			_003C_003CGetOnKeyDown_003Eb__1_003Ed _003C_003CGetOnKeyDown_003Eb__1_003Ed = default(_003C_003CGetOnKeyDown_003Eb__1_003Ed);
			_003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003E4__this = this;
			_003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
			_003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003E1__state = -1;
			AsyncTaskMethodBuilder _003C_003Et__builder = _003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003Et__builder;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003C_003CGetOnKeyDown_003Eb__1_003Ed>(ref _003C_003CGetOnKeyDown_003Eb__1_003Ed);
			return ((AsyncTaskMethodBuilder)(ref _003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003Et__builder)).get_Task();
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public BaseViewItemComponent<TViewItem, TInputs, TContext, TController> _003C_003E4__this;

		public string caption;

		public Func<ReactElement, bool> condition;

		internal IViewItem _003CRenderWrappedChildren_003Eb__0()
		{
			return _003C_003E4__this.ViewItem;
		}

		internal string _003CRenderWrappedChildren_003Eb__1()
		{
			return caption;
		}

		internal ReactElement[] _003CRenderWrappedChildren_003Eb__2()
		{
			return _003C_003E4__this.GetChildren(condition);
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public BaseViewItemComponent<TViewItem, TInputs, TContext, TController> _003C_003E4__this;

		public DefaultAction action;

		public int timeout;

		public Action<TController> _003C_003E9__3;

		public Action _003C_003E9__2;

		internal void _003CInitDebounce_003Eb__1(MouseEvent<HTMLElement> value)
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			//IL_004e: Expected O, but got Unknown
			if (_003C_003E4__this.timeoutId != 0)
			{
				Window.ClearTimeout(_003C_003E4__this.timeoutId);
				_003C_003E4__this.timeoutId = 0;
				return;
			}
			BaseViewItemComponent<TViewItem, TInputs, TContext, TController> baseViewItemComponent = _003C_003E4__this;
			Action obj = _003C_003E9__2;
			if (obj == null)
			{
				Action val = delegate
				{
					_003C_003E4__this.timeoutId = 0;
					_003C_003E4__this.Dispatcher.Dispatch((Action<TController>)(object)(Action<_003F>)delegate
					{
						_003C_003E4__this.OnMouseEvent(action);
					});
				};
				Action val2 = val;
				_003C_003E9__2 = val;
				obj = val2;
			}
			baseViewItemComponent.timeoutId = Window.SetTimeout(obj, timeout);
		}

		internal void _003CInitDebounce_003Eb__2()
		{
			_003C_003E4__this.timeoutId = 0;
			_003C_003E4__this.Dispatcher.Dispatch((Action<TController>)(object)(Action<_003F>)delegate
			{
				_003C_003E4__this.OnMouseEvent(action);
			});
		}

		internal void _003CInitDebounce_003Eb__3(TController c)
		{
			_003C_003E4__this.OnMouseEvent(action);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Action<MouseEvent<HTMLElement>> _003C_003E9__24_0;

		internal void _003CInitDebounce_003Eb__24_0(MouseEvent<HTMLElement> ev)
		{
		}
	}

	protected HTMLElement ContentElement;

	private bool isActivated;

	private int timeoutId;

	private static string viewItemName = typeof(TViewItem).get_Name();

	public TViewItem ViewItem => (TViewItem)ViewModel.ViewItem;

	protected override System.Type TypeViewModel => typeof(ViewItemViewModel);

	protected new IReactViewItemViewModel ViewModel => (IReactViewItemViewModel)Model;

	protected IReactViewItemInputModel<TViewItem, TInputs> ViewItemInputModel => (IReactViewItemInputModel<TViewItem, TInputs>)((PureComponent<BaseReactProps<IReactInputModel<_003F>>>)(object)this).get_props().Model;

	protected virtual bool UseCustomContainer => false;

	protected BaseViewItemComponent(IReactViewItemInputModel<TViewItem, TInputs> model)
		: base((IReactInputModel<TInputs>)model)
	{
	}

	protected override void ComponentWillReact()
	{
		base.ComponentWillReact();
	}

	protected override System.Threading.Tasks.Task ComponentWillUnmount()
	{
		if (timeoutId != 0)
		{
			Window.ClearTimeout(timeoutId);
			timeoutId = 0;
		}
		return base.ComponentWillUnmount();
	}

	internal sealed override ReactElement RenderInternal()
	{
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0132: Expected O, but got Unknown
		if (UseCustomContainer)
		{
			return base.RenderInternal();
		}
		string text = "viewitem-content";
		bool flag = ViewModel.RenderOwner is IMetadataViewModel metadataViewModel && metadataViewModel.IsDesignMode;
		bool flag2 = false;
		if (ViewModel is IHideEmptyViewItemViewModel hideEmptyViewItemViewModel && hideEmptyViewItemViewModel.HideEmptyModel != null)
		{
			flag2 = hideEmptyViewItemViewModel.HideEmptyModel.IsEmpty;
		}
		if ((ViewItem != null && ViewItem.Hide) || flag2)
		{
			text += "--hide";
			if (!flag && (((object)ViewItem is IViewItemLoading viewItemLoading && (viewItemLoading.LoadingType == ViewItemLoadingType.SyncLoading || viewItemLoading.LoadingType == ViewItemLoadingType.LazyLoading)) || flag2))
			{
				isActivated = true;
			}
		}
		else
		{
			isActivated = true;
		}
		ReactElement val = null;
		if (isActivated)
		{
			val = (flag ? DesignTimeView() : base.RenderInternal());
		}
		Attributes val2 = new Attributes();
		((ReactDomElementAttributes<HTMLElement>)val2).set_Key(Union<string, int>.op_Implicit("viewitem-content"));
		((DomElementsAttributes)val2).set_ClassName(text + " form-element-wrap--" + viewItemName);
		((ReactDomElementAttributes<HTMLElement>)val2).set_Ref((Action<HTMLElement>)SetRef);
		Attributes val3 = val2;
		if (ViewModel.TestIdEnabled())
		{
			((DomElementsAttributes)val3).set_Data((object)new _003C_003Ef__AnonymousType0<string>(ViewItem.TestId));
		}
		if (ViewItem != null && ((ViewItem.OnMouseEnter != null && !ViewItem.OnMouseEnter.IsEmpty) || (ViewItem.OnMouseLeave != null && !ViewItem.OnMouseLeave.IsEmpty)))
		{
			((DomElementWithEventsAttributes<HTMLElement>)(object)val3).set_OnMouseEnter(GetOnMouseEnter());
			((DomElementWithEventsAttributes<HTMLElement>)(object)val3).set_OnMouseLeave(GetOnMouseLeave());
		}
		Action<KeyboardEvent<HTMLElement>> onKeyDown = GetOnKeyDown();
		if (onKeyDown != null)
		{
			((DomElementsAttributes)val3).set_TabIndex(-1);
			((DomElementWithEventsAttributes<HTMLElement>)(object)val3).set_OnKeyDown(onKeyDown);
		}
		return DOM.Div(val3, val);
	}

	protected Action<MouseEvent<HTMLElement>> GetOnMouseEnter()
	{
		return delegate(MouseEvent<HTMLElement> e)
		{
			InitDebounce(ViewItem.OnMouseEnter).Invoke(e);
		};
	}

	protected Action<MouseEvent<HTMLElement>> GetOnMouseLeave()
	{
		return delegate(MouseEvent<HTMLElement> e)
		{
			InitDebounce(ViewItem.OnMouseLeave).Invoke(e);
		};
	}

	protected virtual Action<KeyboardEvent<HTMLElement>> GetOnKeyDown()
	{
		_003C_003Ec__DisplayClass20_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.hasOnEscape = ViewItem.OnEscape != null && !ViewItem.OnEscape.IsEmpty;
		CS_0024_003C_003E8__locals0.hasOnEnter = ViewItem.OnEnter != null && !ViewItem.OnEnter.IsEmpty;
		if (CS_0024_003C_003E8__locals0.hasOnEscape | CS_0024_003C_003E8__locals0.hasOnEnter)
		{
			return delegate(KeyboardEvent<HTMLElement> e)
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_1();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
				CS_0024_003C_003E8__locals0.e = e;
				CS_0024_003C_003E8__locals0._003C_003E4__this.Dispatcher.Dispatch((Func<TController, System.Threading.Tasks.Task>)(object)(Func<_003F, System.Threading.Tasks.Task>)delegate
				{
					//IL_000a: Unknown result type (might be due to invalid IL or missing references)
					//IL_000f: Unknown result type (might be due to invalid IL or missing references)
					//IL_001d: Unknown result type (might be due to invalid IL or missing references)
					//IL_0022: Unknown result type (might be due to invalid IL or missing references)
					_003C_003Ec__DisplayClass20_1._003C_003CGetOnKeyDown_003Eb__1_003Ed _003C_003CGetOnKeyDown_003Eb__1_003Ed = default(_003C_003Ec__DisplayClass20_1._003C_003CGetOnKeyDown_003Eb__1_003Ed);
					_003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
					_003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					_003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003E1__state = -1;
					AsyncTaskMethodBuilder _003C_003Et__builder = _003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003Et__builder;
					((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003C_003Ec__DisplayClass20_1._003C_003CGetOnKeyDown_003Eb__1_003Ed>(ref _003C_003CGetOnKeyDown_003Eb__1_003Ed);
					return ((AsyncTaskMethodBuilder)(ref _003C_003CGetOnKeyDown_003Eb__1_003Ed._003C_003Et__builder)).get_Task();
				});
			};
		}
		return null;
	}

	protected virtual ReactElement DesignTimeView()
	{
		return base.RenderInternal();
	}

	protected ReactElement RenderWrappedChildren(Func<ReactElement, bool> condition = null, string caption = "")
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		_003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass22_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.caption = caption;
		CS_0024_003C_003E8__locals0.condition = condition;
		if (!(ViewModel.RenderOwner is IMetadataViewModel metadataViewModel) || !metadataViewModel.IsDesignMode)
		{
			return Fragment.op_Implicit(new Fragment((System.Collections.Generic.IEnumerable<ReactElement>)GetChildren(CS_0024_003C_003E8__locals0.condition)));
		}
		return ViewModel.ReactComponentCreatorService.Create<WrapperComponent>(new WrapperComponent.WrapperComponentInputs
		{
			ViewItem = () => CS_0024_003C_003E8__locals0._003C_003E4__this.ViewItem,
			Caption = () => CS_0024_003C_003E8__locals0.caption,
			Content = () => CS_0024_003C_003E8__locals0._003C_003E4__this.GetChildren(CS_0024_003C_003E8__locals0.condition)
		}, ViewModel.RenderOwner).ToReactElement();
	}

	protected ReactElement[] RenderChildren(Func<ReactElement, bool> condition = null)
	{
		return GetChildren(condition);
	}

	protected Action<MouseEvent<HTMLElement>> InitDebounce(DefaultAction action, int timeout = 300)
	{
		_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass24_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.action = action;
		CS_0024_003C_003E8__locals0.timeout = timeout;
		if (CS_0024_003C_003E8__locals0.action == null)
		{
			return delegate
			{
			};
		}
		return delegate
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			//IL_004e: Expected O, but got Unknown
			if (CS_0024_003C_003E8__locals0._003C_003E4__this.timeoutId != 0)
			{
				Window.ClearTimeout(CS_0024_003C_003E8__locals0._003C_003E4__this.timeoutId);
				CS_0024_003C_003E8__locals0._003C_003E4__this.timeoutId = 0;
			}
			else
			{
				BaseViewItemComponent<TViewItem, TInputs, TContext, TController> _003C_003E4__this = CS_0024_003C_003E8__locals0._003C_003E4__this;
				Action obj = CS_0024_003C_003E8__locals0._003C_003E9__2;
				if (obj == null)
				{
					Action val = delegate
					{
						CS_0024_003C_003E8__locals0._003C_003E4__this.timeoutId = 0;
						CS_0024_003C_003E8__locals0._003C_003E4__this.Dispatcher.Dispatch((Action<TController>)(object)(Action<_003F>)delegate
						{
							CS_0024_003C_003E8__locals0._003C_003E4__this.OnMouseEvent(CS_0024_003C_003E8__locals0.action);
						});
					};
					Action val2 = val;
					CS_0024_003C_003E8__locals0._003C_003E9__2 = val;
					obj = val2;
				}
				_003C_003E4__this.timeoutId = Window.SetTimeout(obj, CS_0024_003C_003E8__locals0.timeout);
			}
		};
	}

	private void OnMouseEvent(DefaultAction action)
	{
		if (action != null && !action.IsEmpty)
		{
			action.Call();
		}
	}

	private ReactElement[] GetChildren(Func<ReactElement, bool> condition = null)
	{
		if ((object)base.InputModel.Inputs is Inputs inputs)
		{
			return PrepareChildren(inputs.Children, condition);
		}
		if ((object)base.InputModel.Inputs is InputsChildrenFunc inputsChildrenFunc)
		{
			return PrepareChildren(inputsChildrenFunc.Children.Invoke((IData)null), condition);
		}
		if ((object)base.InputModel.Inputs is InputsChildren inputsChildren)
		{
			return PrepareChildren((ReactElement[])inputsChildren.Children, condition);
		}
		return (ReactElement[])(object)new ReactElement[0];
	}

	private ReactElement[] PrepareChildren(ReactElement[] children, Func<ReactElement, bool> condition)
	{
		if (condition == null)
		{
			return children;
		}
		ReactElement[] array = (ReactElement[])(object)new ReactElement[0];
		foreach (ReactElement val in children)
		{
			if (condition.Invoke(val))
			{
				ArrayExtensions.Push<ReactElement>(array, (ReactElement[])(object)new ReactElement[1] { val });
			}
		}
		return array;
	}

	private void SetRef(HTMLElement el)
	{
		ContentElement = el;
	}

	private void _003CGetOnMouseEnter_003Eb__18_0(MouseEvent<HTMLElement> e)
	{
		InitDebounce(ViewItem.OnMouseEnter).Invoke(e);
	}

	private void _003CGetOnMouseLeave_003Eb__19_0(MouseEvent<HTMLElement> e)
	{
		InitDebounce(ViewItem.OnMouseLeave).Invoke(e);
	}
}
public abstract class BaseViewItemComponent<TViewItem, TInputs, TContext> : BaseViewItemComponent<TViewItem, TInputs, TContext, BaseReactController> where TViewItem : IViewItem where TInputs : IInputs where TContext : IContext
{
	protected BaseViewItemComponent(IReactViewItemInputModel<TViewItem, TInputs> model)
		: base(model)
	{
	}
}
public abstract class BaseViewItemComponent<TViewItem, TController> : BaseViewItemComponent<TViewItem, Inputs, Context, TController> where TViewItem : IViewItem where TController : IController
{
	protected BaseViewItemComponent(IReactViewItemInputModel<TViewItem, Inputs> model)
		: base(model)
	{
	}
}
public abstract class BaseViewItemComponent<TViewItem> : BaseViewItemComponent<TViewItem, Inputs, Context> where TViewItem : IViewItem
{
	protected BaseViewItemComponent(IReactViewItemInputModel<TViewItem, Inputs> model)
		: base(model)
	{
	}
}
