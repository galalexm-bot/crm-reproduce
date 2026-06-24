using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Api.Services;
using EleWise.ELMA.Api.Services.Internal;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Types.Storage;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

[Component]
public sealed class DataClassMetadataItemManager : UpdateMetadataHandler<DataClassMetadata>
{
	[StructLayout(3)]
	private struct _003CCreateHeader_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DataClassMetadataItemHeader> _003C_003Et__builder;

		public DataClassMetadataItemManager _003C_003E4__this;

		public CreateModel createModel;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DataClassMetadataItemManager dataClassMetadataItemManager = _003C_003E4__this;
			DataClassMetadataItemHeader result2;
			try
			{
				TaskAwaiter<DataClassMetadataItemHeader> val;
				if (num != 0)
				{
					val = dataClassMetadataItemManager.dataClassMetadataService.Create(createModel).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<DataClassMetadataItemHeader>, _003CCreateHeader_003Ed__10>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<DataClassMetadataItemHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				DataClassMetadataItemHeader result = val.GetResult();
				((IDictionary<Guid, DataClassMetadataItemHeader>)dataClassMetadataItemManager.headers).set_Item(result.get_Uid(), result);
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
	private struct _003CEditHeader_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DataClassMetadataItemHeader> _003C_003Et__builder;

		public DataClassMetadataItemManager _003C_003E4__this;

		public CreateModel editModel;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DataClassMetadataItemManager dataClassMetadataItemManager = _003C_003E4__this;
			DataClassMetadataItemHeader result2;
			try
			{
				TaskAwaiter<DataClassMetadataItemHeader> val;
				if (num != 0)
				{
					val = dataClassMetadataItemManager.dataClassMetadataService.EditHeader(editModel).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<DataClassMetadataItemHeader>, _003CEditHeader_003Ed__11>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<DataClassMetadataItemHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				DataClassMetadataItemHeader result = val.GetResult();
				((IDictionary<Guid, DataClassMetadataItemHeader>)dataClassMetadataItemManager.headers).set_Item(result.get_Uid(), result);
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

		public static Func<KeyValuePair<Guid, DataClassMetadataItemHeader>, DataClassMetadataItemHeader> _003C_003E9__13_0;

		internal DataClassMetadataItemHeader _003CGetAllHeaders_003Eb__13_0(KeyValuePair<Guid, DataClassMetadataItemHeader> el)
		{
			return el.get_Value();
		}
	}

	[StructLayout(3)]
	private struct _003CGetAllHeaders_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<DataClassMetadataItemHeader>> _003C_003Et__builder;

		public DataClassMetadataItemManager _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DataClassMetadataItemManager dataClassMetadataItemManager = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<DataClassMetadataItemHeader> result;
			try
			{
				TaskAwaiter<System.Collections.Generic.ICollection<DataClassMetadataItemHeader>> val;
				if (num == 0)
				{
					val = (TaskAwaiter<System.Collections.Generic.ICollection<DataClassMetadataItemHeader>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00ab;
				}
				if (((System.Collections.Generic.ICollection<KeyValuePair<Guid, DataClassMetadataItemHeader>>)dataClassMetadataItemManager.headers).get_Count() <= 0)
				{
					val = dataClassMetadataItemManager.dataClassMetadataService.LoadAll().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<DataClassMetadataItemHeader>>, _003CGetAllHeaders_003Ed__13>(ref val, ref this);
						return;
					}
					goto IL_00ab;
				}
				result = (System.Collections.Generic.IEnumerable<DataClassMetadataItemHeader>)Enumerable.Select<KeyValuePair<Guid, DataClassMetadataItemHeader>, DataClassMetadataItemHeader>((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, DataClassMetadataItemHeader>>)dataClassMetadataItemManager.headers, (Func<KeyValuePair<Guid, DataClassMetadataItemHeader>, DataClassMetadataItemHeader>)((KeyValuePair<Guid, DataClassMetadataItemHeader> el) => el.get_Value()));
				goto end_IL_000e;
				IL_00ab:
				System.Collections.Generic.ICollection<DataClassMetadataItemHeader> result2 = val.GetResult();
				System.Collections.Generic.IEnumerator<DataClassMetadataItemHeader> enumerator = ((System.Collections.Generic.IEnumerable<DataClassMetadataItemHeader>)result2).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						DataClassMetadataItemHeader current = enumerator.get_Current();
						((IDictionary<Guid, DataClassMetadataItemHeader>)dataClassMetadataItemManager.headers).set_Item(current.get_Uid(), current);
					}
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
				}
				result = (System.Collections.Generic.IEnumerable<DataClassMetadataItemHeader>)result2;
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
	private struct _003CDelete_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DataClassMetadataItemHeader header;

		public DataClassMetadataItemManager _003C_003E4__this;

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
			int num = _003C_003E1__state;
			DataClassMetadataItemManager dataClassMetadataItemManager = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				if (num != 0)
				{
					_003CheaderUid_003E5__2 = header.get_Uid();
					val = dataClassMetadataItemManager.dataClassMetadataService.Delete(_003CheaderUid_003E5__2).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CDelete_003Ed__14>(ref val, ref this);
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
				((IDictionary<Guid, DataClassMetadataItemHeader>)dataClassMetadataItemManager.headers).Remove(_003CheaderUid_003E5__2);
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
	private struct _003CCopy_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DataClassMetadataItemHeader> _003C_003Et__builder;

		public DataClassMetadataItemManager _003C_003E4__this;

		public Guid headerUid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DataClassMetadataItemManager dataClassMetadataItemManager = _003C_003E4__this;
			DataClassMetadataItemHeader result2;
			try
			{
				TaskAwaiter<DataClassMetadataItemHeader> val;
				if (num != 0)
				{
					val = dataClassMetadataItemManager.dataClassMetadataService.Copy(headerUid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<DataClassMetadataItemHeader>, _003CCopy_003Ed__15>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<DataClassMetadataItemHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				DataClassMetadataItemHeader result = val.GetResult();
				((IDictionary<Guid, DataClassMetadataItemHeader>)dataClassMetadataItemManager.headers).set_Item(result.get_Uid(), result);
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
	private struct _003CPublish_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DataClassMetadataItem> _003C_003Et__builder;

		public DataClassMetadataItemManager _003C_003E4__this;

		public Guid uid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DataClassMetadataItemManager dataClassMetadataItemManager = _003C_003E4__this;
			DataClassMetadataItem result2;
			try
			{
				TaskAwaiter<DataClassMetadataPublishResult> val;
				if (num != 0)
				{
					val = dataClassMetadataItemManager.dataClassMetadataService.Publish(uid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<DataClassMetadataPublishResult>, _003CPublish_003Ed__16>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<DataClassMetadataPublishResult>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				DataClassMetadataPublishResult result = val.GetResult();
				if (((BaseResult)result).get_Warnings().get_Count() != 0)
				{
					throw new System.Exception(string.Join("\n", (System.Collections.Generic.IEnumerable<string>)((BaseResult)result).get_Warnings()));
				}
				DataClassMetadataItem item = result.get_Item();
				if (item != null)
				{
					((IDictionary<Guid, DataClassMetadataItemHeader>)dataClassMetadataItemManager.headers).get_Item(item.get_Header_Uid()).set_Published_Uid((Guid?)item.get_Uid());
					((IDictionary<Guid, DataClassMetadataItemHeader>)dataClassMetadataItemManager.headers).get_Item(item.get_Header_Uid()).set_IsDirtyItem(false);
					((IDictionary<Guid, DataClassMetadataItem>)dataClassMetadataItemManager.items).set_Item(item.get_Uid(), item);
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
	private struct _003CLoadOrNull_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DataClassMetadataItem> _003C_003Et__builder;

		public DataClassMetadataItemManager _003C_003E4__this;

		public Guid uid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DataClassMetadataItemManager dataClassMetadataItemManager = _003C_003E4__this;
			DataClassMetadataItem result2;
			try
			{
				TaskAwaiter<DataClassMetadataItem> val;
				if (num != 0)
				{
					val = dataClassMetadataItemManager.Load(uid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<DataClassMetadataItem>, _003CLoadOrNull_003Ed__17>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<DataClassMetadataItem>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				DataClassMetadataItem result = val.GetResult();
				dataClassMetadataItemManager.LocalSaveMetadataItem(result);
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
	private struct _003CLoad_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DataClassMetadataItem> _003C_003Et__builder;

		public DataClassMetadataItemManager _003C_003E4__this;

		public Guid uid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DataClassMetadataItemManager dataClassMetadataItemManager = _003C_003E4__this;
			DataClassMetadataItem result;
			try
			{
				TaskAwaiter<DataClassMetadataItem> val;
				if (num == 0)
				{
					val = (TaskAwaiter<DataClassMetadataItem>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_008c;
				}
				DataClassMetadataItem val2 = default(DataClassMetadataItem);
				if (!((IDictionary<Guid, DataClassMetadataItem>)dataClassMetadataItemManager.items).TryGetValue(uid, ref val2))
				{
					val = dataClassMetadataItemManager.dataClassMetadataService.Load(uid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<DataClassMetadataItem>, _003CLoad_003Ed__18>(ref val, ref this);
						return;
					}
					goto IL_008c;
				}
				result = val2;
				goto end_IL_000e;
				IL_008c:
				DataClassMetadataItem result2 = val.GetResult();
				dataClassMetadataItemManager.LocalSaveMetadataItem(result2, saveMetadata: false);
				result = result2;
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
	private struct _003CSave_003Ed__26 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public DataClassMetadataItemManager _003C_003E4__this;

		public DataClassMetadataItem metadataItem;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DataClassMetadataItemManager dataClassMetadataItemManager = _003C_003E4__this;
			try
			{
				TaskAwaiter<DataClassSaveResult> val;
				if (num != 0)
				{
					val = dataClassMetadataItemManager.dataClassMetadataService.Save(metadataItem).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<DataClassSaveResult>, _003CSave_003Ed__26>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<DataClassSaveResult>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				DataClassSaveResult result = val.GetResult();
				if (((BaseResult)result).get_Warnings().get_Count() > 0)
				{
					System.Collections.Generic.IEnumerator<string> enumerator = ((System.Collections.Generic.IEnumerable<string>)((BaseResult)result).get_Warnings()).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							string current = enumerator.get_Current();
							dataClassMetadataItemManager.notificationService.Warning(SR.T("Внимание"), current);
							dataClassMetadataItemManager.logger.Warn(current);
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
				DataClassMetadataItemHeader val2 = ((IDictionary<Guid, DataClassMetadataItemHeader>)dataClassMetadataItemManager.headers).get_Item(metadataItem.get_Header_Uid());
				if (val2 != null)
				{
					DataClassMetadata metadata = metadataItem.get_Metadata();
					val2.set_DisplayName(((INamedMetadata)metadata).get_DisplayName());
					val2.set_Name(((INamedMetadata)metadata).get_Name());
					val2.set_IsDirtyItem(true);
				}
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
	private struct _003CSaveAndUpdate_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IUpdateModel> _003C_003Et__builder;

		public IUpdateModel updateModel;

		public DataClassMetadataItemManager _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Expected O, but got Unknown
			int num = _003C_003E1__state;
			DataClassMetadataItemManager dataClassMetadataItemManager = _003C_003E4__this;
			IUpdateModel result;
			try
			{
				TaskAwaiter val;
				if (num == 0)
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00aa;
				}
				IMetadata obj = updateModel?.Metadata;
				DataClassMetadata val2;
				if ((val2 = (DataClassMetadata)(object)((obj is DataClassMetadata) ? obj : null)) == null)
				{
					result = null;
				}
				else
				{
					DataClassMetadataItem val3 = dataClassMetadataItemManager.LoadItemByMetadataUid(((IMetadata)val2).get_Uid());
					if (val3 != null)
					{
						val3.set_Metadata(val2);
						val = dataClassMetadataItemManager.Save(val3).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter, _003CSaveAndUpdate_003Ed__28>(ref val, ref this);
							return;
						}
						goto IL_00aa;
					}
					result = null;
				}
				goto end_IL_000e;
				IL_00aa:
				val.GetResult();
				result = updateModel;
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
	private struct _003CSaveAndPublish_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IUpdateModel> _003C_003Et__builder;

		public IUpdateModel updateModel;

		public DataClassMetadataItemManager _003C_003E4__this;

		private DataClassMetadataItem _003Citem_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			DataClassMetadataItemManager dataClassMetadataItemManager = _003C_003E4__this;
			IUpdateModel result;
			try
			{
				TaskAwaiter val;
				if (num == 0)
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00c7;
				}
				TaskAwaiter<DataClassMetadataItem> val2;
				if (num == 1)
				{
					val2 = (TaskAwaiter<DataClassMetadataItem>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_012d;
				}
				IMetadata obj = updateModel?.Metadata;
				DataClassMetadata val3;
				if ((val3 = (DataClassMetadata)(object)((obj is DataClassMetadata) ? obj : null)) == null)
				{
					result = null;
				}
				else
				{
					_003Citem_003E5__2 = dataClassMetadataItemManager.LoadItemByMetadataUid(((IMetadata)val3).get_Uid());
					if (_003Citem_003E5__2 != null)
					{
						_003Citem_003E5__2.set_Metadata(val3);
						val = dataClassMetadataItemManager.Save(_003Citem_003E5__2).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter, _003CSaveAndPublish_003Ed__29>(ref val, ref this);
							return;
						}
						goto IL_00c7;
					}
					result = null;
				}
				goto end_IL_000e;
				IL_00c7:
				val.GetResult();
				val2 = dataClassMetadataItemManager.Publish(_003Citem_003E5__2.get_Header_Uid()).GetAwaiter();
				if (!val2.get_IsCompleted())
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = val2;
					_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<DataClassMetadataItem>, _003CSaveAndPublish_003Ed__29>(ref val2, ref this);
					return;
				}
				goto IL_012d;
				IL_012d:
				result = new UpdateModel((IMetadata)(object)val2.GetResult().get_Metadata());
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

	private readonly IDataClassMetadataService dataClassMetadataService;

	private readonly IDataClassSearchService dataClassSearchService;

	private readonly INotificationService notificationService;

	private readonly ILogger logger;

	private readonly IReactiveDictionary<Guid, Guid> dataClasses;

	private readonly IReactiveDictionary<Guid, DataClassMetadataItem> items;

	private readonly IReactiveDictionary<Guid, DataClassMetadataItem> drafts;

	private readonly IReactiveDictionary<Guid, DataClassMetadataItemHeader> headers;

	private TypedMap<string, ComponentMetadata> dataClassForms = new TypedMap<string, ComponentMetadata>();

	public DataClassMetadataItemManager(IDataClassMetadataService dataClassMetadataService, IDataClassSearchService dataClassSearchService, INotificationService notificationService, ILogger logger)
	{
		this.dataClassMetadataService = dataClassMetadataService;
		this.dataClassSearchService = dataClassSearchService;
		this.notificationService = notificationService;
		this.logger = logger;
		dataClasses = new ReactiveDictionary<Guid, Guid>();
		items = new ReactiveDictionary<Guid, DataClassMetadataItem>();
		drafts = new ReactiveDictionary<Guid, DataClassMetadataItem>();
		headers = new ReactiveDictionary<Guid, DataClassMetadataItemHeader>();
	}

	public System.Threading.Tasks.Task<DataClassMetadataItemHeader> CreateHeader(CreateModel createModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CCreateHeader_003Ed__10 _003CCreateHeader_003Ed__ = default(_003CCreateHeader_003Ed__10);
		_003CCreateHeader_003Ed__._003C_003E4__this = this;
		_003CCreateHeader_003Ed__.createModel = createModel;
		_003CCreateHeader_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<DataClassMetadataItemHeader>.Create();
		_003CCreateHeader_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<DataClassMetadataItemHeader> _003C_003Et__builder = _003CCreateHeader_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CCreateHeader_003Ed__10>(ref _003CCreateHeader_003Ed__);
		return _003CCreateHeader_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<DataClassMetadataItemHeader> EditHeader(CreateModel editModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CEditHeader_003Ed__11 _003CEditHeader_003Ed__ = default(_003CEditHeader_003Ed__11);
		_003CEditHeader_003Ed__._003C_003E4__this = this;
		_003CEditHeader_003Ed__.editModel = editModel;
		_003CEditHeader_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<DataClassMetadataItemHeader>.Create();
		_003CEditHeader_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<DataClassMetadataItemHeader> _003C_003Et__builder = _003CEditHeader_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CEditHeader_003Ed__11>(ref _003CEditHeader_003Ed__);
		return _003CEditHeader_003Ed__._003C_003Et__builder.get_Task();
	}

	public DataClassMetadataItemHeader LoadHeader(Guid headerId)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		DataClassMetadataItemHeader result = default(DataClassMetadataItemHeader);
		if (!((IDictionary<Guid, DataClassMetadataItemHeader>)headers).TryGetValue(headerId, ref result))
		{
			return null;
		}
		return result;
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<DataClassMetadataItemHeader>> GetAllHeaders()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CGetAllHeaders_003Ed__13 _003CGetAllHeaders_003Ed__ = default(_003CGetAllHeaders_003Ed__13);
		_003CGetAllHeaders_003Ed__._003C_003E4__this = this;
		_003CGetAllHeaders_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<DataClassMetadataItemHeader>>.Create();
		_003CGetAllHeaders_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<DataClassMetadataItemHeader>> _003C_003Et__builder = _003CGetAllHeaders_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetAllHeaders_003Ed__13>(ref _003CGetAllHeaders_003Ed__);
		return _003CGetAllHeaders_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task Delete(DataClassMetadataItemHeader header)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CDelete_003Ed__14 _003CDelete_003Ed__ = default(_003CDelete_003Ed__14);
		_003CDelete_003Ed__._003C_003E4__this = this;
		_003CDelete_003Ed__.header = header;
		_003CDelete_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CDelete_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CDelete_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CDelete_003Ed__14>(ref _003CDelete_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CDelete_003Ed__._003C_003Et__builder)).get_Task();
	}

	public System.Threading.Tasks.Task<DataClassMetadataItemHeader> Copy(Guid headerUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CCopy_003Ed__15 _003CCopy_003Ed__ = default(_003CCopy_003Ed__15);
		_003CCopy_003Ed__._003C_003E4__this = this;
		_003CCopy_003Ed__.headerUid = headerUid;
		_003CCopy_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<DataClassMetadataItemHeader>.Create();
		_003CCopy_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<DataClassMetadataItemHeader> _003C_003Et__builder = _003CCopy_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CCopy_003Ed__15>(ref _003CCopy_003Ed__);
		return _003CCopy_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<DataClassMetadataItem> Publish(Guid uid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CPublish_003Ed__16 _003CPublish_003Ed__ = default(_003CPublish_003Ed__16);
		_003CPublish_003Ed__._003C_003E4__this = this;
		_003CPublish_003Ed__.uid = uid;
		_003CPublish_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<DataClassMetadataItem>.Create();
		_003CPublish_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<DataClassMetadataItem> _003C_003Et__builder = _003CPublish_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CPublish_003Ed__16>(ref _003CPublish_003Ed__);
		return _003CPublish_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<DataClassMetadataItem> LoadOrNull(Guid uid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadOrNull_003Ed__17 _003CLoadOrNull_003Ed__ = default(_003CLoadOrNull_003Ed__17);
		_003CLoadOrNull_003Ed__._003C_003E4__this = this;
		_003CLoadOrNull_003Ed__.uid = uid;
		_003CLoadOrNull_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<DataClassMetadataItem>.Create();
		_003CLoadOrNull_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<DataClassMetadataItem> _003C_003Et__builder = _003CLoadOrNull_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadOrNull_003Ed__17>(ref _003CLoadOrNull_003Ed__);
		return _003CLoadOrNull_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<DataClassMetadataItem> Load(Guid uid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoad_003Ed__18 _003CLoad_003Ed__ = default(_003CLoad_003Ed__18);
		_003CLoad_003Ed__._003C_003E4__this = this;
		_003CLoad_003Ed__.uid = uid;
		_003CLoad_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<DataClassMetadataItem>.Create();
		_003CLoad_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<DataClassMetadataItem> _003C_003Et__builder = _003CLoad_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoad_003Ed__18>(ref _003CLoad_003Ed__);
		return _003CLoad_003Ed__._003C_003Et__builder.get_Task();
	}

	public DataClassMetadataItem LoadPublishedOrNull(Guid uid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		DataClassMetadataItem result = default(DataClassMetadataItem);
		if (((IDictionary<Guid, DataClassMetadataItem>)items).TryGetValue(uid, ref result))
		{
			return result;
		}
		return null;
	}

	public DataClassMetadataItem LoadItemByMetadataUid(Guid uid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		Guid val = default(Guid);
		if (!((IDictionary<Guid, Guid>)dataClasses).TryGetValue(uid, ref val))
		{
			return null;
		}
		DataClassMetadataItem result = default(DataClassMetadataItem);
		if (((IDictionary<Guid, DataClassMetadataItem>)drafts).TryGetValue(val, ref result))
		{
			return result;
		}
		if (((IDictionary<Guid, DataClassMetadataItem>)items).TryGetValue(val, ref result))
		{
			return result;
		}
		return null;
	}

	internal bool CheckItem(Guid itemUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return ((IDictionary<Guid, DataClassMetadataItem>)items).ContainsKey(itemUid);
	}

	internal void RegisterItem(DataClassMetadataItem item)
	{
		LocalSaveMetadataItem(item);
	}

	internal void RegisterForm(ImplementationForm implementationFormDataClass, ComponentMetadata componentMetadata)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Guid metadataUid = implementationFormDataClass.get_MetadataUid();
		string text = ((object)(Guid)(ref metadataUid)).ToString() + ((object)implementationFormDataClass.get_ViewType()).ToString();
		dataClassForms.Set(text, componentMetadata);
	}

	internal ComponentMetadata GetForm(Guid dataClassUid, ViewType viewType)
	{
		string text = ((object)(Guid)(ref dataClassUid)).ToString();
		int num = (int)viewType;
		string text2 = text + ((object)num).ToString();
		if (dataClassForms.Has(text2))
		{
			return dataClassForms.Get(text2);
		}
		return null;
	}

	internal System.Threading.Tasks.Task<Guid> GetComponentHeaderUid(SearchComponentHeaderRequestDto model)
	{
		return dataClassSearchService.GetComponentHeaderUid(model);
	}

	private System.Threading.Tasks.Task Save(DataClassMetadataItem metadataItem)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CSave_003Ed__26 _003CSave_003Ed__ = default(_003CSave_003Ed__26);
		_003CSave_003Ed__._003C_003E4__this = this;
		_003CSave_003Ed__.metadataItem = metadataItem;
		_003CSave_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CSave_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CSave_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CSave_003Ed__26>(ref _003CSave_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CSave_003Ed__._003C_003Et__builder)).get_Task();
	}

	private void LocalSaveMetadataItem(DataClassMetadataItem item, bool saveMetadata = true)
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		if (item != null)
		{
			if (item.get_IsPublished())
			{
				((IDictionary<Guid, DataClassMetadataItem>)items).set_Item(item.get_Uid(), item);
			}
			else
			{
				((IDictionary<Guid, DataClassMetadataItem>)drafts).set_Item(item.get_Uid(), item);
			}
			if (saveMetadata)
			{
				((IDictionary<Guid, Guid>)dataClasses).set_Item(((IMetadata)item.get_Metadata()).get_Uid(), item.get_Uid());
			}
		}
	}

	public override System.Threading.Tasks.Task<IUpdateModel> SaveAndUpdate(IUpdateModel updateModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CSaveAndUpdate_003Ed__28 _003CSaveAndUpdate_003Ed__ = default(_003CSaveAndUpdate_003Ed__28);
		_003CSaveAndUpdate_003Ed__._003C_003E4__this = this;
		_003CSaveAndUpdate_003Ed__.updateModel = updateModel;
		_003CSaveAndUpdate_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<IUpdateModel>.Create();
		_003CSaveAndUpdate_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IUpdateModel> _003C_003Et__builder = _003CSaveAndUpdate_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CSaveAndUpdate_003Ed__28>(ref _003CSaveAndUpdate_003Ed__);
		return _003CSaveAndUpdate_003Ed__._003C_003Et__builder.get_Task();
	}

	public override System.Threading.Tasks.Task<IUpdateModel> SaveAndPublish(IUpdateModel updateModel)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CSaveAndPublish_003Ed__29 _003CSaveAndPublish_003Ed__ = default(_003CSaveAndPublish_003Ed__29);
		_003CSaveAndPublish_003Ed__._003C_003E4__this = this;
		_003CSaveAndPublish_003Ed__.updateModel = updateModel;
		_003CSaveAndPublish_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<IUpdateModel>.Create();
		_003CSaveAndPublish_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IUpdateModel> _003C_003Et__builder = _003CSaveAndPublish_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CSaveAndPublish_003Ed__29>(ref _003CSaveAndPublish_003Ed__);
		return _003CSaveAndPublish_003Ed__._003C_003Et__builder.get_Task();
	}
}
