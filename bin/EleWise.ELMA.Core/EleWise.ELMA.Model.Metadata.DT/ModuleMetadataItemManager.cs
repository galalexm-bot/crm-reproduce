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
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Exceptions;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

[Service]
public sealed class ModuleMetadataItemManager
{
	[StructLayout(3)]
	private struct _003CCreate_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ModuleMetadataItemHeader> _003C_003Et__builder;

		public ModuleMetadataItemManager _003C_003E4__this;

		public CreateModuleModel model;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ModuleMetadataItemManager moduleMetadataItemManager = _003C_003E4__this;
			ModuleMetadataItemHeader result2;
			try
			{
				TaskAwaiter<ModuleMetadataItemHeader> val;
				if (num != 0)
				{
					val = moduleMetadataItemManager.moduleMetadataService.Create(model).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ModuleMetadataItemHeader>, _003CCreate_003Ed__11>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<ModuleMetadataItemHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				ModuleMetadataItemHeader result = val.GetResult();
				((IDictionary<Guid, ModuleMetadataItemHeader>)moduleMetadataItemManager.headers).set_Item(result.get_Uid(), result);
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

		public static Func<KeyValuePair<Guid, ModuleMetadataItemHeader>, ModuleMetadataItemHeader> _003C_003E9__13_0;

		public static Func<KeyValuePair<Guid, ModuleMetadataItem>, ModuleMetadataItem> _003C_003E9__16_0;

		internal ModuleMetadataItemHeader _003CGetHeaderAll_003Eb__13_0(KeyValuePair<Guid, ModuleMetadataItemHeader> el)
		{
			return el.get_Value();
		}

		internal ModuleMetadataItem _003CGetAll_003Eb__16_0(KeyValuePair<Guid, ModuleMetadataItem> m)
		{
			return m.get_Value();
		}
	}

	[StructLayout(3)]
	private struct _003CGetHeaderAll_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ModuleMetadataItemHeader>> _003C_003Et__builder;

		public ModuleMetadataItemManager _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ModuleMetadataItemManager moduleMetadataItemManager = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<ModuleMetadataItemHeader> result;
			try
			{
				TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItemHeader>> val;
				if (num == 0)
				{
					val = (TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItemHeader>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00ab;
				}
				if (((System.Collections.Generic.ICollection<KeyValuePair<Guid, ModuleMetadataItemHeader>>)moduleMetadataItemManager.headers).get_Count() <= 0)
				{
					val = moduleMetadataItemManager.moduleMetadataService.LoadAll().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItemHeader>>, _003CGetHeaderAll_003Ed__13>(ref val, ref this);
						return;
					}
					goto IL_00ab;
				}
				result = (System.Collections.Generic.IEnumerable<ModuleMetadataItemHeader>)Enumerable.Select<KeyValuePair<Guid, ModuleMetadataItemHeader>, ModuleMetadataItemHeader>((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, ModuleMetadataItemHeader>>)moduleMetadataItemManager.headers, (Func<KeyValuePair<Guid, ModuleMetadataItemHeader>, ModuleMetadataItemHeader>)((KeyValuePair<Guid, ModuleMetadataItemHeader> el) => el.get_Value()));
				goto end_IL_000e;
				IL_00ab:
				ModuleMetadataItemHeader[] array = Enumerable.ToArray<ModuleMetadataItemHeader>(val.GetResult());
				ModuleMetadataItemHeader[] array2 = array;
				foreach (ModuleMetadataItemHeader val2 in array2)
				{
					((IDictionary<Guid, ModuleMetadataItemHeader>)moduleMetadataItemManager.headers).set_Item(val2.get_Uid(), val2);
				}
				result = array;
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
	private struct _003CGetAll_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ModuleMetadataItem>> _003C_003Et__builder;

		public ModuleMetadataItemManager _003C_003E4__this;

		private bool _003CneedReload_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ModuleMetadataItemManager moduleMetadataItemManager = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<ModuleMetadataItem> result;
			try
			{
				TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItem>> val;
				TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItemHeader>> val2;
				if (num != 0)
				{
					if (num == 1)
					{
						val = (TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItem>>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_013d;
					}
					_003CneedReload_003E5__2 = false;
					val2 = moduleMetadataItemManager.moduleMetadataService.LoadAll().GetAwaiter();
					if (!val2.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val2;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItemHeader>>, _003CGetAll_003Ed__16>(ref val2, ref this);
						return;
					}
				}
				else
				{
					val2 = (TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItemHeader>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				System.Collections.Generic.IEnumerator<ModuleMetadataItemHeader> enumerator = val2.GetResult().GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						ModuleMetadataItemHeader current = enumerator.get_Current();
						if (!((IDictionary<Guid, ModuleMetadataItemHeader>)moduleMetadataItemManager.headers).ContainsKey(current.get_Uid()))
						{
							((IDictionary<Guid, ModuleMetadataItemHeader>)moduleMetadataItemManager.headers).set_Item(current.get_Uid(), current);
							_003CneedReload_003E5__2 = true;
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
				if (_003CneedReload_003E5__2)
				{
					val = moduleMetadataItemManager.moduleMetadataService.GetDrafts().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<ModuleMetadataItem>>, _003CGetAll_003Ed__16>(ref val, ref this);
						return;
					}
					goto IL_013d;
				}
				goto IL_014e;
				IL_014e:
				result = (System.Collections.Generic.IEnumerable<ModuleMetadataItem>)Enumerable.Select<KeyValuePair<Guid, ModuleMetadataItem>, ModuleMetadataItem>((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, ModuleMetadataItem>>)moduleMetadataItemManager.items, (Func<KeyValuePair<Guid, ModuleMetadataItem>, ModuleMetadataItem>)((KeyValuePair<Guid, ModuleMetadataItem> m) => m.get_Value()));
				goto end_IL_000e;
				IL_013d:
				System.Collections.Generic.IEnumerable<ModuleMetadataItem> result2 = val.GetResult();
				moduleMetadataItemManager.LocalSaveFormMetadataItems(result2);
				goto IL_014e;
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
	private struct _003CLoadOrNullByHeaderAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ModuleMetadataItem> _003C_003Et__builder;

		public ModuleMetadataItemManager _003C_003E4__this;

		public Guid headerUid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ModuleMetadataItemManager moduleMetadataItemManager = _003C_003E4__this;
			ModuleMetadataItem result;
			try
			{
				Guid val = default(Guid);
				ModuleMetadataItem val2 = default(ModuleMetadataItem);
				if (num != 0 && ((IDictionary<Guid, Guid>)moduleMetadataItemManager.headerUids).TryGetValue(headerUid, ref val) && ((IDictionary<Guid, ModuleMetadataItem>)moduleMetadataItemManager.items).TryGetValue(val, ref val2))
				{
					result = val2;
				}
				else
				{
					try
					{
						TaskAwaiter<ModuleMetadataItem> val3;
						if (num != 0)
						{
							val3 = moduleMetadataItemManager.moduleMetadataService.Load(headerUid).GetAwaiter();
							if (!val3.get_IsCompleted())
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = val3;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ModuleMetadataItem>, _003CLoadOrNullByHeaderAsync_003Ed__20>(ref val3, ref this);
								return;
							}
						}
						else
						{
							val3 = (TaskAwaiter<ModuleMetadataItem>)_003C_003Eu__1;
							_003C_003Eu__1 = null;
							num = (_003C_003E1__state = -1);
						}
						ModuleMetadataItem result2 = val3.GetResult();
						moduleMetadataItemManager.LocalSaveMetadataItem(result2);
						result = result2;
					}
					catch (System.Exception exception)
					{
						moduleMetadataItemManager.logger.Error(SR.T("Ошибка загрузки черновика модуля"), exception);
						result = null;
					}
				}
			}
			catch (System.Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception2);
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
	private struct _003CLoadOrNullAsync_003Ed__21 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ModuleMetadataItem> _003C_003Et__builder;

		public ModuleMetadataItemManager _003C_003E4__this;

		public Guid itemUid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ModuleMetadataItemManager moduleMetadataItemManager = _003C_003E4__this;
			ModuleMetadataItem result;
			try
			{
				ModuleMetadataItem val = default(ModuleMetadataItem);
				if (num != 0 && ((IDictionary<Guid, ModuleMetadataItem>)moduleMetadataItemManager.items).TryGetValue(itemUid, ref val))
				{
					result = val;
				}
				else
				{
					try
					{
						TaskAwaiter<ModuleMetadataItem> val2;
						if (num != 0)
						{
							val2 = moduleMetadataItemManager.moduleMetadataService.Load(itemUid).GetAwaiter();
							if (!val2.get_IsCompleted())
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = val2;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ModuleMetadataItem>, _003CLoadOrNullAsync_003Ed__21>(ref val2, ref this);
								return;
							}
						}
						else
						{
							val2 = (TaskAwaiter<ModuleMetadataItem>)_003C_003Eu__1;
							_003C_003Eu__1 = null;
							num = (_003C_003E1__state = -1);
						}
						ModuleMetadataItem result2 = val2.GetResult();
						moduleMetadataItemManager.LocalSaveMetadataItem(result2);
						result = result2;
					}
					catch (System.Exception exception)
					{
						moduleMetadataItemManager.logger.Error(SR.T("Ошибка загрузки черновика модуля"), exception);
						result = null;
					}
				}
			}
			catch (System.Exception exception2)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception2);
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
	private struct _003CAddReference_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public System.Collections.Generic.IEnumerable<LinkToModule> references;

		public Guid moduleUid;

		public ModuleMetadataItemManager _003C_003E4__this;

		private LinkToModule[] _003CreferencesArray_003E5__2;

		private bool _003Cresult_003E5__3;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ModuleMetadataItemManager moduleMetadataItemManager = _003C_003E4__this;
			bool result2;
			try
			{
				TaskAwaiter<ModuleMetadataItem> val;
				TaskAwaiter<bool> val3;
				if (num != 0)
				{
					if (num == 1)
					{
						val = (TaskAwaiter<ModuleMetadataItem>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0114;
					}
					_003CreferencesArray_003E5__2 = Enumerable.ToArray<LinkToModule>(references);
					ReferencesToModule val2 = InterfaceCreator.Create<ReferencesToModule>();
					val2.set_ModuleUid(moduleUid);
					val2.get_References().AddRange(_003CreferencesArray_003E5__2);
					val3 = moduleMetadataItemManager.moduleMetadataService.AddReference(val2).GetAwaiter();
					if (!val3.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val3;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<bool>, _003CAddReference_003Ed__24>(ref val3, ref this);
						return;
					}
				}
				else
				{
					val3 = (TaskAwaiter<bool>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				bool flag = (_003Cresult_003E5__3 = val3.GetResult());
				val = moduleMetadataItemManager.LoadOrNullByHeaderAsync(moduleUid).GetAwaiter();
				if (!val.get_IsCompleted())
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = val;
					_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ModuleMetadataItem>, _003CAddReference_003Ed__24>(ref val, ref this);
					return;
				}
				goto IL_0114;
				IL_0114:
				ModuleMetadataItem result = val.GetResult();
				result.get_Metadata().get_DependencyModules().Clear();
				result.get_Metadata().get_DependencyModules().AddRange(_003CreferencesArray_003E5__2);
				result2 = _003Cresult_003E5__3;
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

	private readonly IModuleMetadataService moduleMetadataService;

	private readonly DataClassMetadataItemManager dataClassMetadataItemManager;

	private readonly ILogger logger;

	private readonly ICustomComponentCacheService customComponentCacheService;

	private readonly IReactiveDictionary<Guid, Guid> components;

	private readonly IReactiveDictionary<Guid, FunctionMetadata> functions;

	private readonly IReactiveDictionary<Guid, ModuleMetadataItem> items;

	private readonly IReactiveDictionary<Guid, ModuleMetadataItemHeader> headers;

	private readonly IReactiveDictionary<Guid, Guid> headerUids;

	private readonly IReactiveCollection<Guid> loadedScript;

	public ModuleMetadataItemManager(IModuleMetadataService moduleMetadataService, DataClassMetadataItemManager dataClassMetadataItemManager, ILogger logger, ICustomComponentCacheService customComponentCacheService)
	{
		this.moduleMetadataService = moduleMetadataService;
		this.dataClassMetadataItemManager = dataClassMetadataItemManager;
		this.logger = logger;
		this.customComponentCacheService = customComponentCacheService;
		components = new ReactiveDictionary<Guid, Guid>();
		functions = new ReactiveDictionary<Guid, FunctionMetadata>();
		items = new ReactiveDictionary<Guid, ModuleMetadataItem>();
		headers = new ReactiveDictionary<Guid, ModuleMetadataItemHeader>();
		headerUids = new ReactiveDictionary<Guid, Guid>();
		loadedScript = new ReactiveCollection<Guid>();
	}

	public System.Threading.Tasks.Task<ModuleMetadataItemHeader> Create(CreateModuleModel model)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CCreate_003Ed__11 _003CCreate_003Ed__ = default(_003CCreate_003Ed__11);
		_003CCreate_003Ed__._003C_003E4__this = this;
		_003CCreate_003Ed__.model = model;
		_003CCreate_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ModuleMetadataItemHeader>.Create();
		_003CCreate_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ModuleMetadataItemHeader> _003C_003Et__builder = _003CCreate_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CCreate_003Ed__11>(ref _003CCreate_003Ed__);
		return _003CCreate_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<ModuleMetadataItemHeader> SaveHeader(ModuleMetadataItemHeader metadata)
	{
		return moduleMetadataService.SaveHeader(metadata);
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ModuleMetadataItemHeader>> GetHeaderAll()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CGetHeaderAll_003Ed__13 _003CGetHeaderAll_003Ed__ = default(_003CGetHeaderAll_003Ed__13);
		_003CGetHeaderAll_003Ed__._003C_003E4__this = this;
		_003CGetHeaderAll_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ModuleMetadataItemHeader>>.Create();
		_003CGetHeaderAll_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ModuleMetadataItemHeader>> _003C_003Et__builder = _003CGetHeaderAll_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetHeaderAll_003Ed__13>(ref _003CGetHeaderAll_003Ed__);
		return _003CGetHeaderAll_003Ed__._003C_003Et__builder.get_Task();
	}

	public ModuleMetadataItemHeader GetHeader(Guid uid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		ModuleMetadataItemHeader result = default(ModuleMetadataItemHeader);
		if (((IDictionary<Guid, ModuleMetadataItemHeader>)headers).TryGetValue(uid, ref result))
		{
			return result;
		}
		return null;
	}

	public string GetHeaderName(Guid uid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		ModuleMetadataItemHeader val = default(ModuleMetadataItemHeader);
		if (((IDictionary<Guid, ModuleMetadataItemHeader>)headers).TryGetValue(uid, ref val))
		{
			return val.get_Name();
		}
		Guid val2 = default(Guid);
		ModuleMetadataItem val3 = default(ModuleMetadataItem);
		if (((IDictionary<Guid, Guid>)headerUids).TryGetValue(uid, ref val2) && ((IDictionary<Guid, ModuleMetadataItem>)items).TryGetValue(val2, ref val3))
		{
			return ((INamedMetadata)val3.get_Metadata()).get_Name();
		}
		return "Configuration";
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ModuleMetadataItem>> GetAll()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CGetAll_003Ed__16 _003CGetAll_003Ed__ = default(_003CGetAll_003Ed__16);
		_003CGetAll_003Ed__._003C_003E4__this = this;
		_003CGetAll_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ModuleMetadataItem>>.Create();
		_003CGetAll_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ModuleMetadataItem>> _003C_003Et__builder = _003CGetAll_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetAll_003Ed__16>(ref _003CGetAll_003Ed__);
		return _003CGetAll_003Ed__._003C_003Et__builder.get_Task();
	}

	public ModuleMetadataItem Load(Guid uid)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return LoadOrNull(uid) ?? throw new ObjectNotFoundException(SR.T("Метаданные модуля не найдены"));
	}

	public ModuleMetadataItem LoadOrNull(Guid uid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		ModuleMetadataItem result = default(ModuleMetadataItem);
		if (!((IDictionary<Guid, ModuleMetadataItem>)items).TryGetValue(uid, ref result))
		{
			return null;
		}
		return result;
	}

	internal ModuleMetadataItem TryLoadComponentByHeaderId(Guid headerId)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		Guid val = default(Guid);
		if (!((IDictionary<Guid, Guid>)components).TryGetValue(headerId, ref val))
		{
			return null;
		}
		return ((IDictionary<Guid, ModuleMetadataItem>)items).get_Item(val);
	}

	public System.Threading.Tasks.Task<ModuleMetadataItem> LoadOrNullByHeaderAsync(Guid headerUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadOrNullByHeaderAsync_003Ed__20 _003CLoadOrNullByHeaderAsync_003Ed__ = default(_003CLoadOrNullByHeaderAsync_003Ed__20);
		_003CLoadOrNullByHeaderAsync_003Ed__._003C_003E4__this = this;
		_003CLoadOrNullByHeaderAsync_003Ed__.headerUid = headerUid;
		_003CLoadOrNullByHeaderAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ModuleMetadataItem>.Create();
		_003CLoadOrNullByHeaderAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ModuleMetadataItem> _003C_003Et__builder = _003CLoadOrNullByHeaderAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadOrNullByHeaderAsync_003Ed__20>(ref _003CLoadOrNullByHeaderAsync_003Ed__);
		return _003CLoadOrNullByHeaderAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<ModuleMetadataItem> LoadOrNullAsync(Guid itemUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadOrNullAsync_003Ed__21 _003CLoadOrNullAsync_003Ed__ = default(_003CLoadOrNullAsync_003Ed__21);
		_003CLoadOrNullAsync_003Ed__._003C_003E4__this = this;
		_003CLoadOrNullAsync_003Ed__.itemUid = itemUid;
		_003CLoadOrNullAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<ModuleMetadataItem>.Create();
		_003CLoadOrNullAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ModuleMetadataItem> _003C_003Et__builder = _003CLoadOrNullAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadOrNullAsync_003Ed__21>(ref _003CLoadOrNullAsync_003Ed__);
		return _003CLoadOrNullAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	public ModuleMetadataItem LoadPublish(Guid headerUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		Guid val = default(Guid);
		if (((IDictionary<Guid, Guid>)headerUids).TryGetValue(headerUid, ref val) && ((IDictionary<Guid, ModuleMetadataItem>)items).ContainsKey(val))
		{
			return ((IDictionary<Guid, ModuleMetadataItem>)items).get_Item(val);
		}
		return null;
	}

	public System.Threading.Tasks.Task<ModuleMetadataItem> Publish(Guid uid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return moduleMetadataService.Publish(uid);
	}

	public System.Threading.Tasks.Task<bool> AddReference(Guid moduleUid, System.Collections.Generic.IEnumerable<LinkToModule> references)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CAddReference_003Ed__24 _003CAddReference_003Ed__ = default(_003CAddReference_003Ed__24);
		_003CAddReference_003Ed__._003C_003E4__this = this;
		_003CAddReference_003Ed__.moduleUid = moduleUid;
		_003CAddReference_003Ed__.references = references;
		_003CAddReference_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		_003CAddReference_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = _003CAddReference_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CAddReference_003Ed__24>(ref _003CAddReference_003Ed__);
		return _003CAddReference_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task Delete(Guid moduleUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return moduleMetadataService.Delete(moduleUid);
	}

	internal System.Collections.Generic.IEnumerable<ModuleMetadataItem> GetPublished()
	{
		return (System.Collections.Generic.IEnumerable<ModuleMetadataItem>)((IDictionary<Guid, ModuleMetadataItem>)items).get_Values();
	}

	internal bool TryLoadFunctionByHeaderId(Guid headerId, out FunctionMetadata functionMetadata)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		if (((IDictionary<Guid, FunctionMetadata>)functions).TryGetValue(headerId, ref functionMetadata))
		{
			return true;
		}
		return false;
	}

	internal bool CheckItem(Guid itemUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (((IDictionary<Guid, ModuleMetadataItem>)items).ContainsKey(itemUid))
		{
			return ((System.Collections.Generic.ICollection<Guid>)loadedScript).Contains(itemUid);
		}
		return false;
	}

	internal void RegisterItem(ModuleMetadataItem item, bool isLoadedScript = false)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (isLoadedScript)
		{
			((System.Collections.Generic.ICollection<Guid>)loadedScript).Add(item.get_Uid());
		}
		LocalSaveMetadataItem(item);
	}

	private void LocalSaveFormMetadataItems(System.Collections.Generic.IEnumerable<ModuleMetadataItem> result)
	{
		System.Collections.Generic.IEnumerator<ModuleMetadataItem> enumerator = result.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ModuleMetadataItem current = enumerator.get_Current();
				LocalSaveMetadataItem(current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void LocalSaveMetadataItem(ModuleMetadataItem item)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		if (item == null)
		{
			return;
		}
		((IDictionary<Guid, ModuleMetadataItem>)items).set_Item(item.get_Uid(), item);
		System.Collections.Generic.IEnumerator<ComponentMetadata> enumerator = ((System.Collections.Generic.IEnumerable<ComponentMetadata>)item.get_Metadata().get_Components()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ComponentMetadata current = enumerator.get_Current();
				((IDictionary<Guid, Guid>)components).set_Item(((IMetadata)current).get_Uid(), item.get_Uid());
				customComponentCacheService.RegisterComponent(current, ((IMetadata)current).get_Uid());
				if (current.get_ImplementationForms().get_Count() == 0)
				{
					continue;
				}
				System.Collections.Generic.IEnumerator<ImplementationForm> enumerator2 = ((System.Collections.Generic.IEnumerable<ImplementationForm>)current.get_ImplementationForms()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						ImplementationForm current2 = enumerator2.get_Current();
						dataClassMetadataItemManager.RegisterForm(current2, current);
					}
				}
				finally
				{
					((System.IDisposable)enumerator2)?.Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		System.Collections.Generic.IEnumerator<FunctionMetadata> enumerator3 = ((System.Collections.Generic.IEnumerable<FunctionMetadata>)item.get_Metadata().get_Functions()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator3).MoveNext())
			{
				FunctionMetadata current3 = enumerator3.get_Current();
				((IDictionary<Guid, FunctionMetadata>)functions).set_Item(((IMetadata)current3).get_Uid(), current3);
			}
		}
		finally
		{
			((System.IDisposable)enumerator3)?.Dispose();
		}
		((IDictionary<Guid, Guid>)headerUids).set_Item(item.get_Header_Uid(), item.get_Uid());
	}
}
