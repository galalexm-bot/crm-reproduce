using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Services;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

[Service]
public sealed class MetadataItemGroupManager
{
	[StructLayout(3)]
	private struct _003CFind_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MetadataItemGroup>> _003C_003Et__builder;

		public MetadataItemGroupManager _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MetadataItemGroupManager metadataItemGroupManager = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<MetadataItemGroup> values;
			try
			{
				TaskAwaiter<System.Collections.Generic.ICollection<MetadataItemGroup>> val;
				if (num == 0)
				{
					val = (TaskAwaiter<System.Collections.Generic.ICollection<MetadataItemGroup>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0082;
				}
				if (!metadataItemGroupManager.groupsLoaded)
				{
					val = metadataItemGroupManager.metadataItemGroupService.LoadAll().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<MetadataItemGroup>>, _003CFind_003Ed__4>(ref val, ref this);
						return;
					}
					goto IL_0082;
				}
				values = (System.Collections.Generic.IEnumerable<MetadataItemGroup>)((IDictionary<Guid, MetadataItemGroup>)metadataItemGroupManager.items).get_Values();
				goto end_IL_000e;
				IL_0082:
				System.Collections.Generic.ICollection<MetadataItemGroup> result = val.GetResult();
				metadataItemGroupManager.groupsLoaded = true;
				System.Collections.Generic.IEnumerator<MetadataItemGroup> enumerator = ((System.Collections.Generic.IEnumerable<MetadataItemGroup>)result).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						MetadataItemGroup current = enumerator.get_Current();
						if (current.get_ParentId() == 0L)
						{
							((IDictionary<Guid, MetadataItemGroup>)metadataItemGroupManager.items).set_Item(current.get_Uid(), current);
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
				values = (System.Collections.Generic.IEnumerable<MetadataItemGroup>)((IDictionary<Guid, MetadataItemGroup>)metadataItemGroupManager.items).get_Values();
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(values);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CLoadRootGroup_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<MetadataItemGroup> _003C_003Et__builder;

		public MetadataItemGroupManager _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MetadataItemGroupManager metadataItemGroupManager = _003C_003E4__this;
			MetadataItemGroup result2;
			try
			{
				TaskAwaiter<System.Collections.Generic.IEnumerable<MetadataItemGroup>> val;
				if (num != 0)
				{
					val = metadataItemGroupManager.Find().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<MetadataItemGroup>>, _003CLoadRootGroup_003Ed__5>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<System.Collections.Generic.IEnumerable<MetadataItemGroup>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				System.Collections.Generic.IEnumerable<MetadataItemGroup> result = val.GetResult();
				MetadataItemGroup val2 = InterfaceCreator.Create<MetadataItemGroup>();
				val2.set_Name(SR.T("Все объекты"));
				val2.set_DisplayName(SR.T("Все объекты"));
				System.Collections.Generic.IEnumerator<MetadataItemGroup> enumerator = result.GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						MetadataItemGroup current = enumerator.get_Current();
						val2.get_SubGroups().Add(current);
					}
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
				}
				result2 = val2;
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

	private readonly IMetadataItemGroupService metadataItemGroupService;

	private readonly IReactiveDictionary<Guid, MetadataItemGroup> items;

	private bool groupsLoaded;

	public MetadataItemGroupManager(IMetadataItemGroupService metadataItemGroupService)
	{
		this.metadataItemGroupService = metadataItemGroupService;
		items = new ReactiveDictionary<Guid, MetadataItemGroup>();
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<MetadataItemGroup>> Find()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CFind_003Ed__4 _003CFind_003Ed__ = default(_003CFind_003Ed__4);
		_003CFind_003Ed__._003C_003E4__this = this;
		_003CFind_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MetadataItemGroup>>.Create();
		_003CFind_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<MetadataItemGroup>> _003C_003Et__builder = _003CFind_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CFind_003Ed__4>(ref _003CFind_003Ed__);
		return _003CFind_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<MetadataItemGroup> LoadRootGroup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadRootGroup_003Ed__5 _003CLoadRootGroup_003Ed__ = default(_003CLoadRootGroup_003Ed__5);
		_003CLoadRootGroup_003Ed__._003C_003E4__this = this;
		_003CLoadRootGroup_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<MetadataItemGroup>.Create();
		_003CLoadRootGroup_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<MetadataItemGroup> _003C_003Et__builder = _003CLoadRootGroup_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadRootGroup_003Ed__5>(ref _003CLoadRootGroup_003Ed__);
		return _003CLoadRootGroup_003Ed__._003C_003Et__builder.get_Task();
	}
}
