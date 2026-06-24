using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Services;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

[Component]
public sealed class FunctionMetadataItemManager : UpdateMetadataHandler<FunctionMetadata>
{
	[StructLayout(3)]
	private struct _003CCreateHeader_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<FunctionMetadataItemHeader> _003C_003Et__builder;

		public FunctionMetadataItemManager _003C_003E4__this;

		public CreateModel createModel;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FunctionMetadataItemManager functionMetadataItemManager = _003C_003E4__this;
			FunctionMetadataItemHeader result2;
			try
			{
				TaskAwaiter<FunctionMetadataItemHeader> val;
				if (num != 0)
				{
					val = functionMetadataItemManager.functionMetadataService.Create(createModel).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<FunctionMetadataItemHeader>, _003CCreateHeader_003Ed__12>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<FunctionMetadataItemHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				FunctionMetadataItemHeader result = val.GetResult();
				((IDictionary<Guid, FunctionMetadataItemHeader>)functionMetadataItemManager.headers).set_Item(result.get_Uid(), result);
				result2 = result;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CEditHeader_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<FunctionMetadataItemHeader> _003C_003Et__builder;

		public FunctionMetadataItemManager _003C_003E4__this;

		public CreateModel editModel;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FunctionMetadataItemManager functionMetadataItemManager = _003C_003E4__this;
			FunctionMetadataItemHeader result2;
			try
			{
				TaskAwaiter<FunctionMetadataItemHeader> val;
				if (num != 0)
				{
					val = functionMetadataItemManager.functionMetadataService.EditHeader(editModel).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<FunctionMetadataItemHeader>, _003CEditHeader_003Ed__13>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<FunctionMetadataItemHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				FunctionMetadataItemHeader result = val.GetResult();
				((IDictionary<Guid, FunctionMetadataItemHeader>)functionMetadataItemManager.headers).set_Item(result.get_Uid(), result);
				result2 = result;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<KeyValuePair<Guid, FunctionMetadataItemHeader>, FunctionMetadataItemHeader> _003C_003E9__16_0;

		public static Func<FunctionMetadata, bool> _003C_003E9__25_1;

		public static Func<ModuleMetadataItem, System.Collections.Generic.IEnumerable<FunctionMetadata>> _003C_003E9__25_0;

		public static Func<FunctionMetadata, bool> _003C_003E9__25_2;

		public static Func<FunctionMetadata, bool> _003C_003E9__25_5;

		internal FunctionMetadataItemHeader _003CGetAllHeaders_003Eb__16_0(KeyValuePair<Guid, FunctionMetadataItemHeader> el)
		{
			return el.get_Value();
		}

		internal System.Collections.Generic.IEnumerable<FunctionMetadata> _003CGetMetadataList_003Eb__25_0(ModuleMetadataItem a)
		{
			return (System.Collections.Generic.IEnumerable<FunctionMetadata>)Enumerable.Where<FunctionMetadata>((System.Collections.Generic.IEnumerable<FunctionMetadata>)a.get_Metadata().get_Functions(), (Func<FunctionMetadata, bool>)((FunctionMetadata b) => !((IMetadata)b).get_Internal()));
		}

		internal bool _003CGetMetadataList_003Eb__25_1(FunctionMetadata b)
		{
			return !((IMetadata)b).get_Internal();
		}

		internal bool _003CGetMetadataList_003Eb__25_2(FunctionMetadata d)
		{
			return !((IMetadata)d).get_Internal();
		}

		internal bool _003CGetMetadataList_003Eb__25_5(FunctionMetadata d)
		{
			return !((IMetadata)d).get_Internal();
		}
	}

	[StructLayout(3)]
	private struct _003CGetAllHeaders_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader>> _003C_003Et__builder;

		public FunctionMetadataItemManager _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FunctionMetadataItemManager functionMetadataItemManager = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader> result;
			try
			{
				TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadataItemHeader>> val;
				if (num == 0)
				{
					val = (TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadataItemHeader>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00ab;
				}
				if (((System.Collections.Generic.ICollection<KeyValuePair<Guid, FunctionMetadataItemHeader>>)functionMetadataItemManager.headers).get_Count() <= 0)
				{
					val = functionMetadataItemManager.functionMetadataService.LoadAll().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadataItemHeader>>, _003CGetAllHeaders_003Ed__16>(ref val, ref this);
						return;
					}
					goto IL_00ab;
				}
				result = (System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader>)Enumerable.Select<KeyValuePair<Guid, FunctionMetadataItemHeader>, FunctionMetadataItemHeader>((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, FunctionMetadataItemHeader>>)functionMetadataItemManager.headers, (Func<KeyValuePair<Guid, FunctionMetadataItemHeader>, FunctionMetadataItemHeader>)((KeyValuePair<Guid, FunctionMetadataItemHeader> el) => el.get_Value()));
				goto end_IL_000e;
				IL_00ab:
				System.Collections.Generic.ICollection<FunctionMetadataItemHeader> result2 = val.GetResult();
				System.Collections.Generic.IEnumerator<FunctionMetadataItemHeader> enumerator = ((System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader>)result2).GetEnumerator();
				try
				{
					FunctionMetadataItemHeader val2 = default(FunctionMetadataItemHeader);
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						FunctionMetadataItemHeader current = enumerator.get_Current();
						if (((IDictionary<Guid, FunctionMetadataItemHeader>)functionMetadataItemManager.headers).TryGetValue(current.get_Uid(), ref val2))
						{
							Guid? published_Uid = current.get_Published_Uid();
							Guid empty = Guid.Empty;
							if (!published_Uid.get_HasValue() || (published_Uid.get_HasValue() && published_Uid.GetValueOrDefault() != empty))
							{
								val2.set_Published_Uid(current.get_Published_Uid());
							}
							if (current.get_Draft_Uid() != Guid.Empty)
							{
								val2.set_Draft_Uid(current.get_Draft_Uid());
							}
						}
						else
						{
							((IDictionary<Guid, FunctionMetadataItemHeader>)functionMetadataItemManager.headers).set_Item(current.get_Uid(), current);
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
				}
				result = (System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader>)result2;
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CDelete_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public FunctionMetadataItemHeader header;

		public FunctionMetadataItemManager _003C_003E4__this;

		private Guid _003CheaderUid_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected O, but got Unknown
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FunctionMetadataItemManager functionMetadataItemManager = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				if (num != 0)
				{
					_003CheaderUid_003E5__2 = header.get_Uid();
					val = functionMetadataItemManager.functionMetadataService.Delete(_003CheaderUid_003E5__2).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CDelete_003Ed__17>(ref val, ref this);
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
				((IDictionary<Guid, FunctionMetadataItemHeader>)functionMetadataItemManager.headers).Remove(_003CheaderUid_003E5__2);
				((IDictionary<Guid, Guid>)functionMetadataItemManager.functions).Remove(_003CheaderUid_003E5__2);
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

	[StructLayout(3)]
	private struct _003CCopy_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<FunctionMetadataItemHeader> _003C_003Et__builder;

		public FunctionMetadataItemManager _003C_003E4__this;

		public Guid headerUid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FunctionMetadataItemManager functionMetadataItemManager = _003C_003E4__this;
			FunctionMetadataItemHeader result2;
			try
			{
				TaskAwaiter<FunctionMetadataItemHeader> val;
				if (num != 0)
				{
					val = functionMetadataItemManager.functionMetadataService.Copy(headerUid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<FunctionMetadataItemHeader>, _003CCopy_003Ed__18>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<FunctionMetadataItemHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				FunctionMetadataItemHeader result = val.GetResult();
				((IDictionary<Guid, FunctionMetadataItemHeader>)functionMetadataItemManager.headers).set_Item(result.get_Uid(), result);
				result2 = result;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CPublish_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<FunctionMetadataItem> _003C_003Et__builder;

		public FunctionMetadataItemManager _003C_003E4__this;

		public Guid uid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FunctionMetadataItemManager functionMetadataItemManager = _003C_003E4__this;
			FunctionMetadataItem result2;
			try
			{
				TaskAwaiter<FunctionMetadataPublishResult> val;
				if (num != 0)
				{
					val = functionMetadataItemManager.functionMetadataService.Publish(uid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<FunctionMetadataPublishResult>, _003CPublish_003Ed__19>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<FunctionMetadataPublishResult>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				FunctionMetadataPublishResult result = val.GetResult();
				if (((BaseResult)result).get_Warnings().get_Count() != 0)
				{
					throw new System.Exception(string.Join("\n", (System.Collections.Generic.IEnumerable<string>)((BaseResult)result).get_Warnings()));
				}
				FunctionMetadataItem item = result.get_Item();
				if (item != null)
				{
					((IDictionary<Guid, FunctionMetadataItemHeader>)functionMetadataItemManager.headers).get_Item(uid).set_Published_Uid((Guid?)item.get_Uid());
					((IDictionary<Guid, FunctionMetadataItemHeader>)functionMetadataItemManager.headers).get_Item(uid).set_IsDirtyItem(false);
					functionMetadataItemManager.LocalSaveMetadataItem(item);
				}
				result2 = item;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CLoadOrNull_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<FunctionMetadataItem> _003C_003Et__builder;

		public FunctionMetadataItemManager _003C_003E4__this;

		public Guid uid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FunctionMetadataItemManager functionMetadataItemManager = _003C_003E4__this;
			FunctionMetadataItem result2;
			try
			{
				TaskAwaiter<FunctionMetadataItem> val;
				if (num != 0)
				{
					val = functionMetadataItemManager.functionMetadataService.Load(uid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<FunctionMetadataItem>, _003CLoadOrNull_003Ed__20>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<FunctionMetadataItem>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				FunctionMetadataItem result = val.GetResult();
				functionMetadataItemManager.LocalSaveMetadataItem(result);
				result2 = result;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CLoadByUids_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.ICollection<FunctionMetadataItem>> _003C_003Et__builder;

		public FunctionMetadataItemManager _003C_003E4__this;

		public Guid[] uids;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			FunctionMetadataItemManager functionMetadataItemManager = _003C_003E4__this;
			System.Collections.Generic.ICollection<FunctionMetadataItem> result2;
			try
			{
				TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadataItem>> val;
				if (num != 0)
				{
					val = functionMetadataItemManager.functionMetadataService.LoadByUids(uids).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadataItem>>, _003CLoadByUids_003Ed__21>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadataItem>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				System.Collections.Generic.ICollection<FunctionMetadataItem> result = val.GetResult();
				System.Collections.Generic.IEnumerator<FunctionMetadataItem> enumerator = ((System.Collections.Generic.IEnumerable<FunctionMetadataItem>)result).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						FunctionMetadataItem current = enumerator.get_Current();
						functionMetadataItemManager.LocalSaveMetadataItem(current);
					}
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
				}
				result2 = result;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CSaveAndUpdate_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IUpdateModel> _003C_003Et__builder;

		public IUpdateModel updateModel;

		public FunctionMetadataItemManager _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FunctionMetadataItemManager functionMetadataItemManager = _003C_003E4__this;
			IUpdateModel result;
			try
			{
				TaskAwaiter<FunctionMetadataItem> val;
				if (num == 0)
				{
					val = (TaskAwaiter<FunctionMetadataItem>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00bf;
				}
				IMetadata obj = updateModel?.Metadata;
				FunctionMetadata val2;
				if ((val2 = (FunctionMetadata)(object)((obj is FunctionMetadata) ? obj : null)) == null)
				{
					result = null;
				}
				else
				{
					FunctionMetadataItem val3 = functionMetadataItemManager.LoadItemByMetadataUid(((IMetadata)val2).get_Uid());
					if (val3 != null)
					{
						val3.set_Metadata(val2);
						val3.set_ScriptModule(updateModel.ServerScriptModule);
						val = functionMetadataItemManager.Save(val3).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<FunctionMetadataItem>, _003CSaveAndUpdate_003Ed__23>(ref val, ref this);
							return;
						}
						goto IL_00bf;
					}
					result = null;
				}
				goto end_IL_000e;
				IL_00bf:
				FunctionMetadataItem result2 = val.GetResult();
				result = new UpdateModel((IMetadata)(object)result2.get_Metadata())
				{
					ServerScriptModule = result2.get_ScriptModule()
				};
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CSaveAndPublish_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IUpdateModel> _003C_003Et__builder;

		public IUpdateModel updateModel;

		public FunctionMetadataItemManager _003C_003E4__this;

		private FunctionMetadataItem _003Citem_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FunctionMetadataItemManager functionMetadataItemManager = _003C_003E4__this;
			IUpdateModel result;
			try
			{
				TaskAwaiter<FunctionMetadataItem> val;
				if (num == 0)
				{
					val = (TaskAwaiter<FunctionMetadataItem>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00dd;
				}
				if (num == 1)
				{
					val = (TaskAwaiter<FunctionMetadataItem>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0144;
				}
				IMetadata obj = updateModel?.Metadata;
				FunctionMetadata val2;
				if ((val2 = (FunctionMetadata)(object)((obj is FunctionMetadata) ? obj : null)) == null)
				{
					result = null;
				}
				else
				{
					_003Citem_003E5__2 = functionMetadataItemManager.LoadItemByMetadataUid(((IMetadata)val2).get_Uid());
					if (_003Citem_003E5__2 != null)
					{
						_003Citem_003E5__2.set_Metadata(val2);
						_003Citem_003E5__2.set_ScriptModule(updateModel.ServerScriptModule);
						val = functionMetadataItemManager.Save(_003Citem_003E5__2).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<FunctionMetadataItem>, _003CSaveAndPublish_003Ed__24>(ref val, ref this);
							return;
						}
						goto IL_00dd;
					}
					result = null;
				}
				goto end_IL_000e;
				IL_00dd:
				val.GetResult();
				val = functionMetadataItemManager.Publish(_003Citem_003E5__2.get_Header_Uid()).GetAwaiter();
				if (!val.get_IsCompleted())
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = val;
					_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<FunctionMetadataItem>, _003CSaveAndPublish_003Ed__24>(ref val, ref this);
					return;
				}
				goto IL_0144;
				IL_0144:
				FunctionMetadataItem result2 = val.GetResult();
				result = new UpdateModel((IMetadata)(object)result2.get_Metadata())
				{
					ServerScriptModule = result2.get_ScriptModule()
				};
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public FunctionMetadataItemHeader[] allHeaders;

		public Func<FunctionMetadata, bool> _003C_003E9__3;

		public Func<FunctionMetadata, bool> _003C_003E9__6;

		internal bool _003CGetMetadataList_003Eb__3(FunctionMetadata function)
		{
			_003C_003Ec__DisplayClass25_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass25_1();
			CS_0024_003C_003E8__locals0.function = function;
			return Enumerable.Any<FunctionMetadataItemHeader>((System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader>)allHeaders, (Func<FunctionMetadataItemHeader, bool>)((FunctionMetadataItemHeader header) => header.get_Uid() == ((IMetadata)CS_0024_003C_003E8__locals0.function).get_Uid()));
		}

		internal bool _003CGetMetadataList_003Eb__6(FunctionMetadata function)
		{
			_003C_003Ec__DisplayClass25_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass25_2();
			CS_0024_003C_003E8__locals0.function = function;
			return Enumerable.Any<FunctionMetadataItemHeader>((System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader>)allHeaders, (Func<FunctionMetadataItemHeader, bool>)((FunctionMetadataItemHeader header) => header.get_Uid() == ((IMetadata)CS_0024_003C_003E8__locals0.function).get_Uid()));
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_1
	{
		public FunctionMetadata function;

		internal bool _003CGetMetadataList_003Eb__4(FunctionMetadataItemHeader header)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return header.get_Uid() == ((IMetadata)function).get_Uid();
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_2
	{
		public FunctionMetadata function;

		internal bool _003CGetMetadataList_003Eb__7(FunctionMetadataItemHeader header)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return header.get_Uid() == ((IMetadata)function).get_Uid();
		}
	}

	[StructLayout(3)]
	private struct _003CGetMetadataList_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.ICollection<FunctionMetadata>> _003C_003Et__builder;

		public FunctionMetadataItemManager _003C_003E4__this;

		private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

		public Guid moduleUid;

		private ModuleInfoMetadata _003CmoduleMetadata_003E5__2;

		private object _003C_003Eu__1;

		private EnumerableInstance<FunctionMetadata> _003CpublicFunctions_003E5__3;

		private List<FunctionMetadata> _003Cresult_003E5__4;

		private List<FunctionMetadata> _003C_003E7__wrap4;

		private bool _003CisElma_003E5__6;

		private System.Collections.Generic.IEnumerator<LinkToModule> _003C_003E7__wrap6;

		private LinkToModule _003Clink_003E5__8;

		private void MoveNext()
		{
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_0372: Unknown result type (might be due to invalid IL or missing references)
			//IL_0437: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0543: Unknown result type (might be due to invalid IL or missing references)
			//IL_0618: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FunctionMetadataItemManager functionMetadataItemManager = _003C_003E4__this;
			System.Collections.Generic.ICollection<FunctionMetadata> result2;
			try
			{
				TaskAwaiter<System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader>> val4;
				TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItem>> val3;
				TaskAwaiter<ModuleMetadataItem> val2;
				TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadata>> val;
				System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader> result3;
				ModuleMetadataItem result4;
				System.Collections.Generic.IEnumerable<ModuleMetadataItem> result5;
				System.Collections.Generic.ICollection<FunctionMetadata> result;
				switch (num)
				{
				default:
					_003C_003E8__1 = new _003C_003Ec__DisplayClass25_0();
					val4 = functionMetadataItemManager.GetAllHeaders().GetAwaiter();
					if (!val4.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val4;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader>>, _003CGetMetadataList_003Ed__25>(ref val4, ref this);
						return;
					}
					goto IL_0096;
				case 0:
					val4 = (TaskAwaiter<System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0096;
				case 1:
					val3 = (TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItem>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0122;
				case 2:
					val = (TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadata>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_01d7;
				case 3:
					val2 = (TaskAwaiter<ModuleMetadataItem>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0273;
				case 4:
					val = (TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadata>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0337;
				case 5:
					val = (TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadata>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_03cf;
				case 6:
					try
					{
						if (num != 6)
						{
							goto IL_05ce;
						}
						val2 = (TaskAwaiter<ModuleMetadataItem>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_052a;
						IL_05c7:
						_003Clink_003E5__8 = null;
						goto IL_05ce;
						IL_052a:
						ModuleMetadataItem val5 = val2.GetResult();
						if (val5 == null)
						{
							val5 = functionMetadataItemManager.moduleMetadataItemManager.LoadPublish(_003Clink_003E5__8.get_ModuleUid());
							if (val5 == null)
							{
								goto IL_05ce;
							}
						}
						EnumerableInstance<FunctionMetadata> val6 = Enumerable.Where<FunctionMetadata>((System.Collections.Generic.IEnumerable<FunctionMetadata>)val5.get_Metadata().get_Functions(), (Func<FunctionMetadata, bool>)((FunctionMetadata d) => !((IMetadata)d).get_Internal()));
						_003Cresult_003E5__4.AddRange((System.Collections.Generic.IEnumerable<FunctionMetadata>)val6.Where((Func<FunctionMetadata, bool>)delegate(FunctionMetadata function)
						{
							_003C_003Ec__DisplayClass25_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass25_2();
							CS_0024_003C_003E8__locals0.function = function;
							return Enumerable.Any<FunctionMetadataItemHeader>((System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader>)_003C_003E8__1.allHeaders, (Func<FunctionMetadataItemHeader, bool>)((FunctionMetadataItemHeader header) => header.get_Uid() == ((IMetadata)CS_0024_003C_003E8__locals0.function).get_Uid()));
						}));
						goto IL_05c7;
						IL_044a:
						ModuleMetadataItem val7;
						EnumerableInstance<FunctionMetadata> val8 = Enumerable.Where<FunctionMetadata>((System.Collections.Generic.IEnumerable<FunctionMetadata>)val7.get_Metadata().get_Functions(), (Func<FunctionMetadata, bool>)((FunctionMetadata d) => !((IMetadata)d).get_Internal()));
						_003Cresult_003E5__4.AddRange((System.Collections.Generic.IEnumerable<FunctionMetadata>)val8.Where((Func<FunctionMetadata, bool>)delegate(FunctionMetadata function)
						{
							_003C_003Ec__DisplayClass25_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass25_1();
							CS_0024_003C_003E8__locals0.function = function;
							return Enumerable.Any<FunctionMetadataItemHeader>((System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader>)_003C_003E8__1.allHeaders, (Func<FunctionMetadataItemHeader, bool>)((FunctionMetadataItemHeader header) => header.get_Uid() == ((IMetadata)CS_0024_003C_003E8__locals0.function).get_Uid()));
						}));
						goto IL_05c7;
						IL_04c3:
						val2 = functionMetadataItemManager.moduleMetadataItemManager.LoadOrNullByHeaderAsync(_003Clink_003E5__8.get_ModuleUid()).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 6);
							_003C_003Eu__1 = val2;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ModuleMetadataItem>, _003CGetMetadataList_003Ed__25>(ref val2, ref this);
							return;
						}
						goto IL_052a;
						IL_05ce:
						while (((System.Collections.IEnumerator)_003C_003E7__wrap6).MoveNext())
						{
							_003Clink_003E5__8 = _003C_003E7__wrap6.get_Current();
							if (_003CisElma_003E5__6)
							{
								val7 = functionMetadataItemManager.moduleMetadataItemManager.LoadPublish(_003Clink_003E5__8.get_ModuleUid());
								if (val7 == null)
								{
									continue;
								}
								goto IL_044a;
							}
							goto IL_04c3;
						}
					}
					finally
					{
						if (num < 0 && _003C_003E7__wrap6 != null)
						{
							((System.IDisposable)_003C_003E7__wrap6).Dispose();
						}
					}
					_003C_003E7__wrap6 = null;
					result2 = (System.Collections.Generic.ICollection<FunctionMetadata>)_003Cresult_003E5__4;
					goto end_IL_000e;
				case 7:
					{
						val = (TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadata>>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_01d7:
					result = val.GetResult();
					_003C_003E7__wrap4.AddRange((System.Collections.Generic.IEnumerable<FunctionMetadata>)result);
					_003C_003E7__wrap4 = null;
					_003Cresult_003E5__4.AddRange((System.Collections.Generic.IEnumerable<FunctionMetadata>)_003CpublicFunctions_003E5__3);
					result2 = (System.Collections.Generic.ICollection<FunctionMetadata>)_003Cresult_003E5__4;
					goto end_IL_000e;
					IL_0096:
					result3 = val4.GetResult();
					_003C_003E8__1.allHeaders = Enumerable.ToArray<FunctionMetadataItemHeader>(result3);
					if (moduleUid == Guid.Empty)
					{
						val3 = functionMetadataItemManager.moduleMetadataItemManager.GetAll().GetAwaiter();
						if (!val3.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val3;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItem>>, _003CGetMetadataList_003Ed__25>(ref val3, ref this);
							return;
						}
						goto IL_0122;
					}
					val2 = functionMetadataItemManager.moduleMetadataItemManager.LoadOrNullByHeaderAsync(moduleUid).GetAwaiter();
					if (!val2.get_IsCompleted())
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__1 = val2;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ModuleMetadataItem>, _003CGetMetadataList_003Ed__25>(ref val2, ref this);
						return;
					}
					goto IL_0273;
					IL_0273:
					result4 = val2.GetResult();
					if ((_003CmoduleMetadata_003E5__2 = ((result4 != null) ? result4.get_Metadata() : null)) != null)
					{
						_003CisElma_003E5__6 = functionMetadataItemManager.applicationData.InterfaceBuilderMode == InterfaceBuilderMode.Elma;
						_003Cresult_003E5__4 = new List<FunctionMetadata>();
						if (_003CisElma_003E5__6)
						{
							_003C_003E7__wrap4 = _003Cresult_003E5__4;
							val = functionMetadataItemManager.GetFunctionMetadataForModule(_003C_003E8__1.allHeaders, moduleUid, loadDraft: false, checkInternal: false).GetAwaiter();
							if (!val.get_IsCompleted())
							{
								num = (_003C_003E1__state = 4);
								_003C_003Eu__1 = val;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadata>>, _003CGetMetadataList_003Ed__25>(ref val, ref this);
								return;
							}
							goto IL_0337;
						}
						_003C_003E7__wrap4 = _003Cresult_003E5__4;
						val = functionMetadataItemManager.GetFunctionMetadataForModule(_003C_003E8__1.allHeaders, moduleUid, loadDraft: true, checkInternal: false).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 5);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadata>>, _003CGetMetadataList_003Ed__25>(ref val, ref this);
							return;
						}
						goto IL_03cf;
					}
					val = functionMetadataItemManager.GetFunctionMetadataForModule(_003C_003E8__1.allHeaders, moduleUid, loadDraft: false, checkInternal: false).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 7);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadata>>, _003CGetMetadataList_003Ed__25>(ref val, ref this);
						return;
					}
					break;
					IL_0122:
					result5 = val3.GetResult();
					_003CpublicFunctions_003E5__3 = Enumerable.SelectMany<ModuleMetadataItem, FunctionMetadata>(result5, (Func<ModuleMetadataItem, System.Collections.Generic.IEnumerable<FunctionMetadata>>)((ModuleMetadataItem a) => (System.Collections.Generic.IEnumerable<FunctionMetadata>)Enumerable.Where<FunctionMetadata>((System.Collections.Generic.IEnumerable<FunctionMetadata>)a.get_Metadata().get_Functions(), (Func<FunctionMetadata, bool>)((FunctionMetadata b) => !((IMetadata)b).get_Internal()))));
					_003Cresult_003E5__4 = new List<FunctionMetadata>();
					_003C_003E7__wrap4 = _003Cresult_003E5__4;
					val = functionMetadataItemManager.GetFunctionMetadataForModule(_003C_003E8__1.allHeaders, Guid.Empty, loadDraft: false, checkInternal: true).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadata>>, _003CGetMetadataList_003Ed__25>(ref val, ref this);
						return;
					}
					goto IL_01d7;
					IL_03cf:
					result = val.GetResult();
					_003C_003E7__wrap4.AddRange((System.Collections.Generic.IEnumerable<FunctionMetadata>)result);
					_003C_003E7__wrap4 = null;
					goto IL_03ec;
					IL_0337:
					result = val.GetResult();
					_003C_003E7__wrap4.AddRange((System.Collections.Generic.IEnumerable<FunctionMetadata>)result);
					_003C_003E7__wrap4 = null;
					goto IL_03ec;
					IL_03ec:
					_003C_003E7__wrap6 = ((System.Collections.Generic.IEnumerable<LinkToModule>)_003CmoduleMetadata_003E5__2.get_DependencyModules()).GetEnumerator();
					goto case 6;
				}
				result2 = val.GetResult();
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CGetMethods_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper>>> _003C_003Et__builder;

		public FunctionMetadataItemManager _003C_003E4__this;

		public Guid moduleUid;

		private ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper>[] _003Cresult_003E5__2;

		private object _003C_003Eu__1;

		private System.Collections.Generic.IEnumerator<FunctionMetadata> _003C_003E7__wrap2;

		private FunctionMetadata _003CfunctionMetadata_003E5__4;

		private Guid _003CheaderUid_003E5__5;

		private string _003CheaderUidString_003E5__6;

		private ScriptMethodDeclaration _003Cmethod_003E5__7;

		private ScriptMethodParameter _003Cparameter_003E5__8;

		private ScriptMethodParameter _003C_003E7__wrap8;

		private void MoveNext()
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FunctionMetadataItemManager functionMetadataItemManager = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper>> result3;
			try
			{
				TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadata>> val;
				if (num != 0)
				{
					if ((uint)(num - 1) <= 1u)
					{
						goto IL_0094;
					}
					val = functionMetadataItemManager.GetMetadataList(moduleUid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadata>>, _003CGetMethods_003Ed__26>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadata>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				System.Collections.Generic.ICollection<FunctionMetadata> result = val.GetResult();
				_003Cresult_003E5__2 = new ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper>[0];
				_003C_003E7__wrap2 = ((System.Collections.Generic.IEnumerable<FunctionMetadata>)result).GetEnumerator();
				goto IL_0094;
				IL_0094:
				try
				{
					TaskAwaiter<string> val2;
					if (num != 1)
					{
						if (num != 2)
						{
							goto IL_02e2;
						}
						val2 = (TaskAwaiter<string>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0247;
					}
					val2 = (TaskAwaiter<string>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0124;
					IL_0247:
					string result2 = val2.GetResult();
					_003C_003E7__wrap8.set_Type(result2);
					_003C_003E7__wrap8 = null;
					_003Cmethod_003E5__7.get_Parameters().Add(_003Cparameter_003E5__8);
					_003Cparameter_003E5__8 = null;
					goto IL_0281;
					IL_0281:
					ArrayExtensions.Push<ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper>>(_003Cresult_003E5__2, new ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper>[1]
					{
						new ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper>(_003Cmethod_003E5__7, new ScriptMethodInfoWrapper(_003CheaderUidString_003E5__6, ((INamedMetadata)_003CfunctionMetadata_003E5__4).get_DisplayName(), CodeType.GlobalFunction, _003CheaderUid_003E5__5))
					});
					_003CheaderUid_003E5__5 = default(Guid);
					_003CheaderUidString_003E5__6 = null;
					_003Cmethod_003E5__7 = null;
					_003CfunctionMetadata_003E5__4 = null;
					goto IL_02e2;
					IL_02e2:
					if (((System.Collections.IEnumerator)_003C_003E7__wrap2).MoveNext())
					{
						_003CfunctionMetadata_003E5__4 = _003C_003E7__wrap2.get_Current();
						val2 = functionMetadataItemManager.convertService.ToString(DynamicPropertyHelper.TypeSignatureMapToObject(_003CfunctionMetadata_003E5__4.get_ReturnType()), CodeType.GlobalFunction).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val2;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<string>, _003CGetMethods_003Ed__26>(ref val2, ref this);
							return;
						}
						goto IL_0124;
					}
					goto end_IL_0095;
					IL_0124:
					string text = val2.GetResult();
					if (string.IsNullOrWhiteSpace(text))
					{
						text = "void";
					}
					_003CheaderUid_003E5__5 = ((IMetadata)_003CfunctionMetadata_003E5__4).get_Uid();
					_003CheaderUidString_003E5__6 = ((Guid)(ref _003CheaderUid_003E5__5)).ToString("N");
					_003Cmethod_003E5__7 = InterfaceCreator.Create<ScriptMethodDeclaration>();
					_003Cmethod_003E5__7.set_Name(_003CheaderUidString_003E5__6);
					_003Cmethod_003E5__7.set_DisplayInfo(((INamedMetadata)_003CfunctionMetadata_003E5__4).get_DisplayName());
					_003Cmethod_003E5__7.set_ReturnType(text);
					if (_003CfunctionMetadata_003E5__4.get_ParameterType().get_TypeUid() != Guid.Empty)
					{
						_003Cparameter_003E5__8 = InterfaceCreator.Create<ScriptMethodParameter>();
						_003C_003E7__wrap8 = _003Cparameter_003E5__8;
						val2 = functionMetadataItemManager.convertService.ToString(DynamicPropertyHelper.TypeSignatureMapToObject(_003CfunctionMetadata_003E5__4.get_ParameterType()), CodeType.GlobalFunction).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__1 = val2;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<string>, _003CGetMethods_003Ed__26>(ref val2, ref this);
							return;
						}
						goto IL_0247;
					}
					goto IL_0281;
					end_IL_0095:;
				}
				finally
				{
					if (num < 0 && _003C_003E7__wrap2 != null)
					{
						((System.IDisposable)_003C_003E7__wrap2).Dispose();
					}
				}
				_003C_003E7__wrap2 = null;
				result3 = _003Cresult_003E5__2;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result3);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CSave_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<FunctionMetadataItem> _003C_003Et__builder;

		public FunctionMetadataItemManager _003C_003E4__this;

		public FunctionMetadataItem formMetadataItem;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FunctionMetadataItemManager functionMetadataItemManager = _003C_003E4__this;
			FunctionMetadataItem result2;
			try
			{
				TaskAwaiter<FunctionSaveResult> val;
				if (num != 0)
				{
					val = functionMetadataItemManager.functionMetadataService.Save(formMetadataItem).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<FunctionSaveResult>, _003CSave_003Ed__27>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<FunctionSaveResult>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				FunctionSaveResult result = val.GetResult();
				if (((BaseResult)result).get_Warnings().get_Count() > 0)
				{
					System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)((BaseResult)result).get_Warnings()).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							string current = enumerator.get_Current();
							functionMetadataItemManager.notificationService.Warning(SR.T("Внимание"), current);
							functionMetadataItemManager.logger.Warn(current);
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator)?.Dispose();
						}
					}
				}
				FunctionMetadataItem function = result.get_Function();
				FunctionMetadataItemHeader val2 = default(FunctionMetadataItemHeader);
				if (((IDictionary<Guid, FunctionMetadataItemHeader>)functionMetadataItemManager.headers).TryGetValue(function.get_Header_Uid(), ref val2))
				{
					val2.set_IsDirtyItem(true);
				}
				functionMetadataItemManager.LocalSaveMetadataItem(function);
				result2 = function;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CGetFunctionMetadataForModule_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.ICollection<FunctionMetadata>> _003C_003Et__builder;

		public FunctionMetadataItemHeader[] allHeaders;

		public Guid moduleUid;

		public bool loadDraft;

		public FunctionMetadataItemManager _003C_003E4__this;

		public bool checkInternal;

		private List<FunctionMetadata> _003Cresult_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FunctionMetadataItemManager functionMetadataItemManager = _003C_003E4__this;
			System.Collections.Generic.ICollection<FunctionMetadata> result;
			try
			{
				TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadataItem>> val3;
				if (num != 0)
				{
					_003Cresult_003E5__2 = new List<FunctionMetadata>();
					Guid[] array = (Guid[])(object)new Guid[0];
					FunctionMetadataItemHeader[] array2 = allHeaders;
					foreach (FunctionMetadataItemHeader val in array2)
					{
						if (!(val.get_ModuleUid() != moduleUid))
						{
							Guid val2 = (Guid)(loadDraft ? val.get_Draft_Uid() : (((_003F?)val.get_Published_Uid()) ?? Guid.Empty));
							if (val2 != Guid.Empty)
							{
								ArrayExtensions.Push<Guid>(array, (Guid[])(object)new Guid[1] { val2 });
							}
						}
					}
					val3 = functionMetadataItemManager.LoadByUids(array).GetAwaiter();
					if (!val3.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val3;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadataItem>>, _003CGetFunctionMetadataForModule_003Ed__28>(ref val3, ref this);
						return;
					}
				}
				else
				{
					val3 = (TaskAwaiter<System.Collections.Generic.ICollection<FunctionMetadataItem>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				System.Collections.Generic.IEnumerator<FunctionMetadataItem> enumerator = ((System.Collections.Generic.IEnumerable<FunctionMetadataItem>)val3.GetResult()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						FunctionMetadataItem current = enumerator.get_Current();
						if (!checkInternal || !((IMetadata)current.get_Metadata()).get_Internal())
						{
							_003Cresult_003E5__2.Add(current.get_Metadata());
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
				}
				result = (System.Collections.Generic.ICollection<FunctionMetadata>)_003Cresult_003E5__2;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private readonly IFunctionMetadataService functionMetadataService;

	private readonly ModuleMetadataItemManager moduleMetadataItemManager;

	private readonly INotificationService notificationService;

	private readonly ILogger logger;

	private readonly IApplicationData applicationData;

	private readonly ILazy<IConvertService> convertServicelazy;

	private readonly IReactiveDictionary<Guid, Guid> functions;

	private readonly IReactiveDictionary<Guid, FunctionMetadataItem> items;

	private readonly IReactiveDictionary<Guid, FunctionMetadataItemHeader> headers;

	private IConvertService convertService => convertServicelazy.Value();

	public FunctionMetadataItemManager(IFunctionMetadataService functionMetadataService, ModuleMetadataItemManager moduleMetadataItemManager, INotificationService notificationService, ILogger logger, IApplicationData applicationData, ILazy<IConvertService> convertServicelazy)
	{
		this.functionMetadataService = functionMetadataService;
		this.moduleMetadataItemManager = moduleMetadataItemManager;
		this.notificationService = notificationService;
		this.logger = logger;
		this.applicationData = applicationData;
		this.convertServicelazy = convertServicelazy;
		functions = new ReactiveDictionary<Guid, Guid>();
		items = new ReactiveDictionary<Guid, FunctionMetadataItem>();
		headers = new ReactiveDictionary<Guid, FunctionMetadataItemHeader>();
	}

	public System.Threading.Tasks.Task<FunctionMetadataItemHeader> CreateHeader(CreateModel createModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CCreateHeader_003Ed__12 _003CCreateHeader_003Ed__ = default(_003CCreateHeader_003Ed__12);
		_003CCreateHeader_003Ed__._003C_003E4__this = this;
		_003CCreateHeader_003Ed__.createModel = createModel;
		_003CCreateHeader_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<FunctionMetadataItemHeader>.Create();
		_003CCreateHeader_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<FunctionMetadataItemHeader> _003C_003Et__builder = _003CCreateHeader_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CCreateHeader_003Ed__12>(ref _003CCreateHeader_003Ed__);
		return _003CCreateHeader_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<FunctionMetadataItemHeader> EditHeader(CreateModel editModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CEditHeader_003Ed__13 _003CEditHeader_003Ed__ = default(_003CEditHeader_003Ed__13);
		_003CEditHeader_003Ed__._003C_003E4__this = this;
		_003CEditHeader_003Ed__.editModel = editModel;
		_003CEditHeader_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<FunctionMetadataItemHeader>.Create();
		_003CEditHeader_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<FunctionMetadataItemHeader> _003C_003Et__builder = _003CEditHeader_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CEditHeader_003Ed__13>(ref _003CEditHeader_003Ed__);
		return _003CEditHeader_003Ed__._003C_003Et__builder.get_Task();
	}

	public FunctionMetadataItemHeader LoadHeader(Guid headerId)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		FunctionMetadataItemHeader result = default(FunctionMetadataItemHeader);
		if (!((IDictionary<Guid, FunctionMetadataItemHeader>)headers).TryGetValue(headerId, ref result))
		{
			return null;
		}
		return result;
	}

	public string LoadHeaderName(Guid headerId)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		FunctionMetadataItemHeader val = default(FunctionMetadataItemHeader);
		if (((IDictionary<Guid, FunctionMetadataItemHeader>)headers).TryGetValue(headerId, ref val))
		{
			return val.get_Name();
		}
		if (moduleMetadataItemManager.TryLoadFunctionByHeaderId(headerId, out var functionMetadata))
		{
			return ((INamedMetadata)functionMetadata).get_Name();
		}
		return null;
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader>> GetAllHeaders()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CGetAllHeaders_003Ed__16 _003CGetAllHeaders_003Ed__ = default(_003CGetAllHeaders_003Ed__16);
		_003CGetAllHeaders_003Ed__._003C_003E4__this = this;
		_003CGetAllHeaders_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader>>.Create();
		_003CGetAllHeaders_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<FunctionMetadataItemHeader>> _003C_003Et__builder = _003CGetAllHeaders_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetAllHeaders_003Ed__16>(ref _003CGetAllHeaders_003Ed__);
		return _003CGetAllHeaders_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task Delete(FunctionMetadataItemHeader header)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CDelete_003Ed__17 _003CDelete_003Ed__ = default(_003CDelete_003Ed__17);
		_003CDelete_003Ed__._003C_003E4__this = this;
		_003CDelete_003Ed__.header = header;
		_003CDelete_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CDelete_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CDelete_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CDelete_003Ed__17>(ref _003CDelete_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CDelete_003Ed__._003C_003Et__builder)).get_Task();
	}

	public System.Threading.Tasks.Task<FunctionMetadataItemHeader> Copy(Guid headerUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CCopy_003Ed__18 _003CCopy_003Ed__ = default(_003CCopy_003Ed__18);
		_003CCopy_003Ed__._003C_003E4__this = this;
		_003CCopy_003Ed__.headerUid = headerUid;
		_003CCopy_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<FunctionMetadataItemHeader>.Create();
		_003CCopy_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<FunctionMetadataItemHeader> _003C_003Et__builder = _003CCopy_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CCopy_003Ed__18>(ref _003CCopy_003Ed__);
		return _003CCopy_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<FunctionMetadataItem> Publish(Guid uid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CPublish_003Ed__19 _003CPublish_003Ed__ = default(_003CPublish_003Ed__19);
		_003CPublish_003Ed__._003C_003E4__this = this;
		_003CPublish_003Ed__.uid = uid;
		_003CPublish_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<FunctionMetadataItem>.Create();
		_003CPublish_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<FunctionMetadataItem> _003C_003Et__builder = _003CPublish_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CPublish_003Ed__19>(ref _003CPublish_003Ed__);
		return _003CPublish_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<FunctionMetadataItem> LoadOrNull(Guid uid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadOrNull_003Ed__20 _003CLoadOrNull_003Ed__ = default(_003CLoadOrNull_003Ed__20);
		_003CLoadOrNull_003Ed__._003C_003E4__this = this;
		_003CLoadOrNull_003Ed__.uid = uid;
		_003CLoadOrNull_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<FunctionMetadataItem>.Create();
		_003CLoadOrNull_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<FunctionMetadataItem> _003C_003Et__builder = _003CLoadOrNull_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadOrNull_003Ed__20>(ref _003CLoadOrNull_003Ed__);
		return _003CLoadOrNull_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<FunctionMetadataItem>> LoadByUids(Guid[] uids)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadByUids_003Ed__21 _003CLoadByUids_003Ed__ = default(_003CLoadByUids_003Ed__21);
		_003CLoadByUids_003Ed__._003C_003E4__this = this;
		_003CLoadByUids_003Ed__.uids = uids;
		_003CLoadByUids_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.ICollection<FunctionMetadataItem>>.Create();
		_003CLoadByUids_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.ICollection<FunctionMetadataItem>> _003C_003Et__builder = _003CLoadByUids_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadByUids_003Ed__21>(ref _003CLoadByUids_003Ed__);
		return _003CLoadByUids_003Ed__._003C_003Et__builder.get_Task();
	}

	public FunctionMetadataItem LoadItemByMetadataUid(Guid uid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		Guid val = default(Guid);
		if (!((IDictionary<Guid, Guid>)functions).TryGetValue(uid, ref val))
		{
			return null;
		}
		FunctionMetadataItem result = default(FunctionMetadataItem);
		if (((IDictionary<Guid, FunctionMetadataItem>)items).TryGetValue(val, ref result))
		{
			return result;
		}
		return null;
	}

	public override System.Threading.Tasks.Task<IUpdateModel> SaveAndUpdate(IUpdateModel updateModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CSaveAndUpdate_003Ed__23 _003CSaveAndUpdate_003Ed__ = default(_003CSaveAndUpdate_003Ed__23);
		_003CSaveAndUpdate_003Ed__._003C_003E4__this = this;
		_003CSaveAndUpdate_003Ed__.updateModel = updateModel;
		_003CSaveAndUpdate_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<IUpdateModel>.Create();
		_003CSaveAndUpdate_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IUpdateModel> _003C_003Et__builder = _003CSaveAndUpdate_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CSaveAndUpdate_003Ed__23>(ref _003CSaveAndUpdate_003Ed__);
		return _003CSaveAndUpdate_003Ed__._003C_003Et__builder.get_Task();
	}

	public override System.Threading.Tasks.Task<IUpdateModel> SaveAndPublish(IUpdateModel updateModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CSaveAndPublish_003Ed__24 _003CSaveAndPublish_003Ed__ = default(_003CSaveAndPublish_003Ed__24);
		_003CSaveAndPublish_003Ed__._003C_003E4__this = this;
		_003CSaveAndPublish_003Ed__.updateModel = updateModel;
		_003CSaveAndPublish_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<IUpdateModel>.Create();
		_003CSaveAndPublish_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IUpdateModel> _003C_003Et__builder = _003CSaveAndPublish_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CSaveAndPublish_003Ed__24>(ref _003CSaveAndPublish_003Ed__);
		return _003CSaveAndPublish_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.ICollection<FunctionMetadata>> GetMetadataList(Guid moduleUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CGetMetadataList_003Ed__25 _003CGetMetadataList_003Ed__ = default(_003CGetMetadataList_003Ed__25);
		_003CGetMetadataList_003Ed__._003C_003E4__this = this;
		_003CGetMetadataList_003Ed__.moduleUid = moduleUid;
		_003CGetMetadataList_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.ICollection<FunctionMetadata>>.Create();
		_003CGetMetadataList_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.ICollection<FunctionMetadata>> _003C_003Et__builder = _003CGetMetadataList_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetMetadataList_003Ed__25>(ref _003CGetMetadataList_003Ed__);
		return _003CGetMetadataList_003Ed__._003C_003Et__builder.get_Task();
	}

	internal System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper>>> GetMethods(Guid moduleUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CGetMethods_003Ed__26 _003CGetMethods_003Ed__ = default(_003CGetMethods_003Ed__26);
		_003CGetMethods_003Ed__._003C_003E4__this = this;
		_003CGetMethods_003Ed__.moduleUid = moduleUid;
		_003CGetMethods_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper>>>.Create();
		_003CGetMethods_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ValueTuple<ScriptMethodDeclaration, ScriptMethodInfoWrapper>>> _003C_003Et__builder = _003CGetMethods_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetMethods_003Ed__26>(ref _003CGetMethods_003Ed__);
		return _003CGetMethods_003Ed__._003C_003Et__builder.get_Task();
	}

	private System.Threading.Tasks.Task<FunctionMetadataItem> Save(FunctionMetadataItem formMetadataItem)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CSave_003Ed__27 _003CSave_003Ed__ = default(_003CSave_003Ed__27);
		_003CSave_003Ed__._003C_003E4__this = this;
		_003CSave_003Ed__.formMetadataItem = formMetadataItem;
		_003CSave_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<FunctionMetadataItem>.Create();
		_003CSave_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<FunctionMetadataItem> _003C_003Et__builder = _003CSave_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CSave_003Ed__27>(ref _003CSave_003Ed__);
		return _003CSave_003Ed__._003C_003Et__builder.get_Task();
	}

	private System.Threading.Tasks.Task<System.Collections.Generic.ICollection<FunctionMetadata>> GetFunctionMetadataForModule(FunctionMetadataItemHeader[] allHeaders, Guid moduleUid, bool loadDraft, bool checkInternal)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		_003CGetFunctionMetadataForModule_003Ed__28 _003CGetFunctionMetadataForModule_003Ed__ = default(_003CGetFunctionMetadataForModule_003Ed__28);
		_003CGetFunctionMetadataForModule_003Ed__._003C_003E4__this = this;
		_003CGetFunctionMetadataForModule_003Ed__.allHeaders = allHeaders;
		_003CGetFunctionMetadataForModule_003Ed__.moduleUid = moduleUid;
		_003CGetFunctionMetadataForModule_003Ed__.loadDraft = loadDraft;
		_003CGetFunctionMetadataForModule_003Ed__.checkInternal = checkInternal;
		_003CGetFunctionMetadataForModule_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.ICollection<FunctionMetadata>>.Create();
		_003CGetFunctionMetadataForModule_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.ICollection<FunctionMetadata>> _003C_003Et__builder = _003CGetFunctionMetadataForModule_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetFunctionMetadataForModule_003Ed__28>(ref _003CGetFunctionMetadataForModule_003Ed__);
		return _003CGetFunctionMetadataForModule_003Ed__._003C_003Et__builder.get_Task();
	}

	private void LocalSaveMetadataItem(FunctionMetadataItem item)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		if (item != null)
		{
			Guid uid = item.get_Uid();
			((IDictionary<Guid, FunctionMetadataItem>)items).set_Item(uid, item);
			FunctionMetadataItemHeader val = default(FunctionMetadataItemHeader);
			if (((IDictionary<Guid, FunctionMetadataItemHeader>)headers).TryGetValue(item.get_Header_Uid(), ref val) && val.get_Draft_Uid() == uid)
			{
				((IDictionary<Guid, Guid>)functions).set_Item(((IMetadata)item.get_Metadata()).get_Uid(), uid);
			}
		}
	}
}
