using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Bridge;
using Bridge.React;
using EleWise.ELMA.Core.Model;
using EleWise.ELMA.Core.React.ExtensionPoints;
using EleWise.ELMA.Core.React.Models;
using EleWise.ELMA.Core.UI.Model;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Core.React.Helpers;

public static class ConvertReactElementHelper
{
	private sealed class _003CToEnumerableReactElement_003Ed__1 : System.Collections.Generic.IEnumerable<ReactElement>, System.Collections.IEnumerable, IBridgeClass, System.Collections.Generic.IEnumerator<ReactElement>, System.IDisposable, System.Collections.IEnumerator
	{
		private int _003C_003E1__state;

		private ReactElement _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private System.Collections.Generic.IEnumerable<IRenderContent> content;

		public System.Collections.Generic.IEnumerable<IRenderContent> _003C_003E3__content;

		private System.Collections.Generic.IEnumerator<IRenderContent> _003C_003E7__wrap1;

		ReactElement Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CToEnumerableReactElement_003Ed__1(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.get_CurrentManagedThreadId();
		}

		[DebuggerHidden]
		void System.IDisposable.Dispose()
		{
			int num = _003C_003E1__state;
			if (num == -3 || num == 1)
			{
				try
				{
				}
				finally
				{
					_003C_003Em__Finally1();
				}
			}
		}

		private bool MoveNext()
		{
			try
			{
				int num = _003C_003E1__state;
				if (num != 0)
				{
					if (num != 1)
					{
						return false;
					}
					_003C_003E1__state = -3;
				}
				else
				{
					_003C_003E1__state = -1;
					if (content == null)
					{
						goto IL_0086;
					}
					_003C_003E7__wrap1 = content.GetEnumerator();
					_003C_003E1__state = -3;
				}
				if (((System.Collections.IEnumerator)_003C_003E7__wrap1).MoveNext())
				{
					IRenderContent current = _003C_003E7__wrap1.get_Current();
					_003C_003E2__current = ObjectExtensions.Cast<IReactComponent>((object)current).ReactElement;
					_003C_003E1__state = 1;
					return true;
				}
				_003C_003Em__Finally1();
				_003C_003E7__wrap1 = null;
				goto IL_0086;
				IL_0086:
				return false;
			}
			catch
			{
				//try-fault
				((System.IDisposable)this).Dispose();
				throw;
			}
		}

		bool System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		private void _003C_003Em__Finally1()
		{
			_003C_003E1__state = -1;
			if (_003C_003E7__wrap1 != null)
			{
				((System.IDisposable)_003C_003E7__wrap1).Dispose();
			}
		}

		[DebuggerHidden]
		void System.Collections.IEnumerator.Reset()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		System.Collections.Generic.IEnumerator<ReactElement> System.Collections.Generic.IEnumerable<ReactElement>.GetEnumerator()
		{
			_003CToEnumerableReactElement_003Ed__1 _003CToEnumerableReactElement_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.get_CurrentManagedThreadId())
			{
				_003C_003E1__state = 0;
				_003CToEnumerableReactElement_003Ed__ = this;
			}
			else
			{
				_003CToEnumerableReactElement_003Ed__ = new _003CToEnumerableReactElement_003Ed__1(0);
			}
			_003CToEnumerableReactElement_003Ed__.content = _003C_003E3__content;
			return _003CToEnumerableReactElement_003Ed__;
		}

		[DebuggerHidden]
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return (System.Collections.IEnumerator)((System.Collections.Generic.IEnumerable<ReactElement>)this).GetEnumerator();
		}
	}

	private sealed class _003CToEnumerableReactElement_003Ed__2 : System.Collections.Generic.IEnumerable<ReactElement>, System.Collections.IEnumerable, IBridgeClass, System.Collections.Generic.IEnumerator<ReactElement>, System.IDisposable, System.Collections.IEnumerator
	{
		private int _003C_003E1__state;

		private ReactElement _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IRenderContent[] content;

		public IRenderContent[] _003C_003E3__content;

		private IRenderContent[] _003C_003E7__wrap1;

		private int _003C_003E7__wrap2;

		ReactElement Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		object Current
		{
			[DebuggerHidden]
			get
			{
				return _003C_003E2__current;
			}
		}

		[DebuggerHidden]
		public _003CToEnumerableReactElement_003Ed__2(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
			_003C_003El__initialThreadId = Environment.get_CurrentManagedThreadId();
		}

		[DebuggerHidden]
		void System.IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			if (num != 0)
			{
				if (num != 1)
				{
					return false;
				}
				_003C_003E1__state = -1;
				_003C_003E7__wrap2++;
			}
			else
			{
				_003C_003E1__state = -1;
				if (content == null)
				{
					return false;
				}
				if (content.Length == 0)
				{
					goto IL_008e;
				}
				_003C_003E7__wrap1 = content;
				_003C_003E7__wrap2 = 0;
			}
			if (_003C_003E7__wrap2 < _003C_003E7__wrap1.Length)
			{
				IRenderContent val = _003C_003E7__wrap1[_003C_003E7__wrap2];
				_003C_003E2__current = val.ToReactElement();
				_003C_003E1__state = 1;
				return true;
			}
			_003C_003E7__wrap1 = null;
			goto IL_008e;
			IL_008e:
			return false;
		}

		bool System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void System.Collections.IEnumerator.Reset()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		[DebuggerHidden]
		System.Collections.Generic.IEnumerator<ReactElement> System.Collections.Generic.IEnumerable<ReactElement>.GetEnumerator()
		{
			_003CToEnumerableReactElement_003Ed__2 _003CToEnumerableReactElement_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.get_CurrentManagedThreadId())
			{
				_003C_003E1__state = 0;
				_003CToEnumerableReactElement_003Ed__ = this;
			}
			else
			{
				_003CToEnumerableReactElement_003Ed__ = new _003CToEnumerableReactElement_003Ed__2(0);
			}
			_003CToEnumerableReactElement_003Ed__.content = _003C_003E3__content;
			return _003CToEnumerableReactElement_003Ed__;
		}

		[DebuggerHidden]
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return (System.Collections.IEnumerator)((System.Collections.Generic.IEnumerable<ReactElement>)this).GetEnumerator();
		}
	}

	public static ReactElement ToReactElement(this IRenderContent content)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		if (content == null)
		{
			return null;
		}
		return (ReactElement)(((object)(content as IReactComponent)?.ReactElement) ?? ((object)(ReactElement)((object)content).get_Item("_reactElement")));
	}

	public static System.Collections.Generic.IEnumerable<ReactElement> ToEnumerableReactElement(this System.Collections.Generic.IEnumerable<IRenderContent> content)
	{
		return new _003CToEnumerableReactElement_003Ed__1(-2)
		{
			_003C_003E3__content = content
		};
	}

	public static System.Collections.Generic.IEnumerable<ReactElement> ToEnumerableReactElement(this IRenderContent[] content)
	{
		return new _003CToEnumerableReactElement_003Ed__2(-2)
		{
			_003C_003E3__content = content
		};
	}

	public static ReactElement[] ToArrayReactElement(this IRenderContent[] content)
	{
		return Enumerable.ToArray<ReactElement>(content.ToEnumerableReactElement());
	}

	public static string GetKey(this ReactElement reactElement)
	{
		return (string)((object)reactElement).get_Item("key");
	}

	public static ReactElement[] GetChildrenArray(this ReactElement reactElement)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = ((object)reactElement).get_Item("props").get_Item("children");
		if (obj == null)
		{
			return (ReactElement[])(object)new ReactElement[0];
		}
		if (!(obj is System.Array array))
		{
			return (ReactElement[])(object)new ReactElement[1] { (ReactElement)obj };
		}
		return Enumerable.Cast<ReactElement>((System.Collections.IEnumerable)array).ToArray();
	}

	public static Func<IData, ReactElement[]> GetChildrenFunc(this ReactElement reactElement)
	{
		object obj = ((object)reactElement).get_Item("props").get_Item("children");
		if (obj is Action)
		{
			return (Func<IData, ReactElement[]>)obj;
		}
		throw new System.Exception(SR.T("Дочерние элементы не являются функцией"));
	}

	public static IViewItem GetViewItem(this ReactElement reactElement)
	{
		return (((object)reactElement).get_Item("props").get_Item("value").get_Item("Model") as IViewItemInputModel)?.ViewItem;
	}

	public static T GetViewItem<T>(this ReactElement reactElement) where T : IViewItem
	{
		return (T)reactElement.GetViewItem();
	}

	public static IWrapModel GetWrapModel(this ReactElement reactElement)
	{
		return (((object)reactElement).get_Item("props").get_Item("value").get_Item("Model") as IReactInputModel<WrapperInputs>)?.Inputs.WrapModel.Invoke();
	}
}
