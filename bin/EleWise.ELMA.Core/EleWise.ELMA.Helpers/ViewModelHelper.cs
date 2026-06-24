using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Bridge;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Controllers;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Helpers;

public static class ViewModelHelper
{
	private sealed class _003C_003Ec__DisplayClass4_0<T>
	{
		public IViewModel viewModel;

		public Func<T> func;

		internal T _003CWrap_003Eb__0()
		{
			GlobalScopeHelper.Push(viewModel);
			try
			{
				return func.Invoke();
			}
			finally
			{
				GlobalScopeHelper.Pop(viewModel);
			}
		}
	}

	private sealed class _003CUnwrapDataArray_003Ed__5 : System.Collections.Generic.IEnumerable<object>, System.Collections.IEnumerable, IBridgeClass, System.Collections.Generic.IEnumerator<object>, System.IDisposable, System.Collections.IEnumerator
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private int _003C_003El__initialThreadId;

		private IDataStack data;

		public IDataStack _003C_003E3__data;

		private System.Collections.Generic.IEnumerator<DataStackItem> _003C_003E7__wrap1;

		object Current
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
		public _003CUnwrapDataArray_003Ed__5(int _003C_003E1__state)
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
				switch (_003C_003E1__state)
				{
				default:
					return false;
				case 0:
					_003C_003E1__state = -1;
					if (data == null)
					{
						return false;
					}
					_003C_003E7__wrap1 = Enumerable.Reverse<DataStackItem>((System.Collections.Generic.IEnumerable<DataStackItem>)data).GetEnumerator();
					_003C_003E1__state = -3;
					break;
				case 1:
					_003C_003E1__state = -3;
					break;
				}
				while (((System.Collections.IEnumerator)_003C_003E7__wrap1).MoveNext())
				{
					DataStackItem current = _003C_003E7__wrap1.get_Current();
					if (current?.Data != null)
					{
						_003C_003E2__current = current.Data.Item;
						_003C_003E1__state = 1;
						return true;
					}
				}
				_003C_003Em__Finally1();
				_003C_003E7__wrap1 = null;
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
		System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<object>.GetEnumerator()
		{
			_003CUnwrapDataArray_003Ed__5 _003CUnwrapDataArray_003Ed__;
			if (_003C_003E1__state == -2 && _003C_003El__initialThreadId == Environment.get_CurrentManagedThreadId())
			{
				_003C_003E1__state = 0;
				_003CUnwrapDataArray_003Ed__ = this;
			}
			else
			{
				_003CUnwrapDataArray_003Ed__ = new _003CUnwrapDataArray_003Ed__5(0);
			}
			_003CUnwrapDataArray_003Ed__.data = _003C_003E3__data;
			return _003CUnwrapDataArray_003Ed__;
		}

		[DebuggerHidden]
		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return (System.Collections.IEnumerator)((System.Collections.Generic.IEnumerable<object>)this).GetEnumerator();
		}
	}

	public static object CallControllerMethod(IController thisController, string methodName, IDataStack data)
	{
		if (thisController == null)
		{
			throw new ScriptExecuteException(SR.T("Не найден контроллер для выполнения метода {0}", methodName));
		}
		ScriptMethodInfo scriptMethodInfo = ScriptMethodInfoHelper.Deserialize(methodName);
		if (string.IsNullOrWhiteSpace(scriptMethodInfo.Name))
		{
			return null;
		}
		if (!(((object)thisController).get_Item(scriptMethodInfo.Name) is Func<object> val))
		{
			throw new ScriptExecuteException(SR.T("Не найден метод {0} в контроллере {1}", scriptMethodInfo.Name, ((object)thisController).GetType().get_FullName()));
		}
		try
		{
			object[] array = Enumerable.ToArray<object>(UnwrapDataArray(data));
			return ((System.Delegate)(object)val).Apply((object)thisController, (System.Array)array);
		}
		catch (System.Exception innerException)
		{
			throw new ScriptExecuteException(SR.T("Ошибка выполнения метода {0} контроллера", scriptMethodInfo.Name), innerException);
		}
	}

	public static object CallControllerMethod(IDictionary<Guid, IController> controllers, string methodName, IDataStack data)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		if (controllers == null || ((System.Collections.Generic.ICollection<KeyValuePair<Guid, IController>>)controllers).get_Count() == 0)
		{
			throw new ScriptExecuteException(SR.T("Не найден ни один контроллер для выполнения метода {0}", methodName));
		}
		Func<object> val = null;
		IController controller = null;
		ScriptMethodInfo scriptMethodInfo = ScriptMethodInfoHelper.Deserialize(methodName);
		if (scriptMethodInfo.MetadataUid == Guid.Empty)
		{
			System.Collections.Generic.IEnumerator<KeyValuePair<Guid, IController>> enumerator = ((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, IController>>)controllers).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					IController value = enumerator.get_Current().get_Value();
					if (((object)value).get_Item(scriptMethodInfo.Name) is Func<object> val2)
					{
						controller = value;
						val = val2;
						break;
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		else if (controllers.TryGetValue(scriptMethodInfo.MetadataUid, ref controller) && ((object)controller).get_Item(scriptMethodInfo.Name) is Func<object> val3)
		{
			val = val3;
		}
		if (controller == null)
		{
			throw new ScriptExecuteException(SR.T("Не найден контроллер для выполнения метода {0}", methodName));
		}
		if (val == null)
		{
			throw new ScriptExecuteException(SR.T("Не найден метод {0} в контроллере {1}", scriptMethodInfo.Name, ((object)controller).GetType().get_FullName()));
		}
		try
		{
			object[] array = Enumerable.ToArray<object>(UnwrapDataArray(data));
			return ((System.Delegate)(object)val).Apply((object)controller, (System.Array)array);
		}
		catch (System.Exception innerException)
		{
			throw new ScriptExecuteException(SR.T("Ошибка выполнения метода {0} контроллера", scriptMethodInfo.Name), innerException);
		}
	}

	public static void SetData(IViewModel viewModel)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		DataStack plainPropertyValue = viewModel.InputModel.GetPlainPropertyValue<DataStack>("DataStack");
		if (plainPropertyValue == null || viewModel.RenderOwner == null || !(viewModel.RenderOwner.GetDynamicData() is DataStack dataStack))
		{
			return;
		}
		Enumerator<DataStackItem> enumerator = ((HashSet<DataStackItem>)plainPropertyValue).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				DataStackItem current = enumerator.get_Current();
				((HashSet<DataStackItem>)dataStack).Add(current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
	}

	public static void RestoreData(IViewModel viewModel)
	{
		((HashSet<DataStackItem>)(viewModel.RenderOwner?.GetDynamicData() as DataStack))?.Clear();
	}

	public static Func<T> Wrap<T>(IViewModel viewModel, Func<T> func)
	{
		return new _003C_003Ec__DisplayClass4_0<T>
		{
			viewModel = viewModel,
			func = func
		}._003CWrap_003Eb__0;
	}

	private static System.Collections.Generic.IEnumerable<object> UnwrapDataArray(IDataStack data)
	{
		return new _003CUnwrapDataArray_003Ed__5(-2)
		{
			_003C_003E3__data = data
		};
	}
}
