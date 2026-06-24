using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Types.Storage;

namespace EleWise.ELMA.Storages;

[Service]
internal sealed class EntityStorage : IEntityStorage
{
	[StructLayout(3)]
	private struct _003CGetOrAddAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Entity> _003C_003Et__builder;

		public EntityStorage _003C_003E4__this;

		public string typeUid;

		public string uid;

		public object serializedEntity;

		public IProxyGeneratorServiceInternal proxyGeneratorService;

		public IExtendEntityService extendEntityService;

		private TypedMap<string, Entity> _003Cstorage_003E5__2;

		private Entity _003Centity_003E5__3;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Expected O, but got Unknown
			int num = _003C_003E1__state;
			EntityStorage entityStorage = _003C_003E4__this;
			Entity result;
			try
			{
				TaskAwaiter<ReactiveProxy> val;
				if (num == 0)
				{
					val = (TaskAwaiter<ReactiveProxy>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_011d;
				}
				TaskAwaiter val2;
				if (num == 1)
				{
					val2 = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_01ff;
				}
				if (entityStorage.entityStorage == null)
				{
					entityStorage.entityStorage = new TypedMap<string, TypedMap<string, Entity>>();
				}
				_003Cstorage_003E5__2 = entityStorage.entityStorage.Get(typeUid);
				if (_003Cstorage_003E5__2 == null)
				{
					_003Cstorage_003E5__2 = new TypedMap<string, Entity>();
					entityStorage.entityStorage.Set(typeUid, _003Cstorage_003E5__2);
				}
				_003Centity_003E5__3 = _003Cstorage_003E5__2.Get(uid);
				if (_003Centity_003E5__3 == null)
				{
					val = proxyGeneratorService.GenerateProxyByStringUidAsync(typeUid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ReactiveProxy>, _003CGetOrAddAsync_003Ed__8>(ref val, ref this);
						return;
					}
					goto IL_011d;
				}
				ConvertHelper.Reconcile(_003Centity_003E5__3, serializedEntity, Script.Write<object>("globals.reconcileContext", new object[0]));
				result = _003Centity_003E5__3;
				goto end_IL_000e;
				IL_011d:
				ReactiveProxy result2 = val.GetResult();
				_003Centity_003E5__3 = ObjectExtensions.As<Entity>((object)result2);
				string text = uid;
				Guid empty = Guid.Empty;
				if (text != ((object)(Guid)(ref empty)).ToString())
				{
					_003Centity_003E5__3.Uid = new Guid(uid);
					_003Cstorage_003E5__2.Set(uid, _003Centity_003E5__3);
				}
				ConvertHelper.Reconcile(_003Centity_003E5__3, serializedEntity, Script.Write<object>("globals.reconcileContext", new object[0]));
				val2 = TryExtendEntityAsync(_003Centity_003E5__3, extendEntityService).GetAwaiter();
				if (!val2.get_IsCompleted())
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = val2;
					_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter, _003CGetOrAddAsync_003Ed__8>(ref val2, ref this);
					return;
				}
				goto IL_01ff;
				IL_01ff:
				val2.GetResult();
				result = _003Centity_003E5__3;
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
	private struct _003CTryExtendEntityAsync_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public IExtendEntityService extendEntityService;

		public Entity entity;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter val;
				if (num == 0)
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00bf;
				}
				if (extendEntityService != null && !entity.GetPlainPropertyValue<bool>("extended") && !(((object)entity).get_Item("$$proxyMetadata") is TablePartMetadata))
				{
					IPropertyMetadata[] propertiesToExtend = extendEntityService.GetPropertiesToExtend(entity);
					if (propertiesToExtend.Length != 0)
					{
						val = extendEntityService.AnalyzeEntityCompleteness(entity, propertiesToExtend).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CTryExtendEntityAsync_003Ed__11>(ref val, ref this);
							return;
						}
						goto IL_00bf;
					}
					goto IL_00c5;
				}
				goto end_IL_0007;
				IL_00c5:
				((object)entity).set_Item("extended", (object)true);
				goto end_IL_0007;
				IL_00bf:
				val.GetResult();
				goto IL_00c5;
				end_IL_0007:;
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

	private readonly IExtendEntityService extendEntityService;

	private readonly IProxyGeneratorServiceInternal proxyGeneratorService;

	private TypedMap<string, TypedMap<string, Entity>> entityStorage;

	public EntityStorage(IExtendEntityService extendEntityService, IProxyGeneratorServiceInternal proxyGeneratorService)
	{
		this.extendEntityService = extendEntityService;
		this.proxyGeneratorService = proxyGeneratorService;
	}

	public Entity TryAdd(Entity entity)
	{
		return TryAddInternal(entity, extendEntityService);
	}

	public Entity GetOrAdd(string typeUid, string uid, object serializedEntity)
	{
		return GetOrAdd(typeUid, uid, serializedEntity, proxyGeneratorService, extendEntityService);
	}

	public System.Threading.Tasks.Task<Entity> GetOrAddAsync(string typeUid, string uid, object serializedEntity)
	{
		return GetOrAddAsync(typeUid, uid, serializedEntity, proxyGeneratorService, extendEntityService);
	}

	private Entity GetOrAdd(string typeUid, string uid, object serializedEntity, IProxyGeneratorServiceInternal proxyGeneratorService, IExtendEntityService extendEntityService)
	{
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		if (entityStorage == null)
		{
			entityStorage = new TypedMap<string, TypedMap<string, Entity>>();
		}
		TypedMap<string, Entity> val = entityStorage.Get(typeUid);
		if (val == null)
		{
			val = new TypedMap<string, Entity>();
			entityStorage.Set(typeUid, val);
		}
		Entity entity = val.Get(uid);
		if (entity != null)
		{
			if (ReactiveHelper.InAction())
			{
				ConvertHelper.Reconcile(entity, serializedEntity, Script.Write<object>("globals.reconcileContext", new object[0]));
				return entity;
			}
			ReactiveHelper.ChangeStrictMode(enabled: false);
			try
			{
				ConvertHelper.Reconcile(entity, serializedEntity, Script.Write<object>("globals.reconcileContext", new object[0]));
				return entity;
			}
			catch
			{
				throw;
			}
			finally
			{
				ReactiveHelper.ChangeStrictMode(enabled: true);
			}
		}
		entity = ObjectExtensions.As<Entity>((object)proxyGeneratorService.GenerateProxyByStringUid(typeUid));
		Guid empty = Guid.Empty;
		if (uid != ((object)(Guid)(ref empty)).ToString())
		{
			entity.Uid = new Guid(uid);
			val.Set(uid, entity);
		}
		ConvertHelper.Reconcile(entity, serializedEntity, Script.Write<object>("globals.reconcileContext", new object[0]));
		TryExtendEntity(entity, extendEntityService);
		return entity;
	}

	private System.Threading.Tasks.Task<Entity> GetOrAddAsync(string typeUid, string uid, object serializedEntity, IProxyGeneratorServiceInternal proxyGeneratorService, IExtendEntityService extendEntityService)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		_003CGetOrAddAsync_003Ed__8 _003CGetOrAddAsync_003Ed__ = default(_003CGetOrAddAsync_003Ed__8);
		_003CGetOrAddAsync_003Ed__._003C_003E4__this = this;
		_003CGetOrAddAsync_003Ed__.typeUid = typeUid;
		_003CGetOrAddAsync_003Ed__.uid = uid;
		_003CGetOrAddAsync_003Ed__.serializedEntity = serializedEntity;
		_003CGetOrAddAsync_003Ed__.proxyGeneratorService = proxyGeneratorService;
		_003CGetOrAddAsync_003Ed__.extendEntityService = extendEntityService;
		_003CGetOrAddAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<Entity>.Create();
		_003CGetOrAddAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<Entity> _003C_003Et__builder = _003CGetOrAddAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetOrAddAsync_003Ed__8>(ref _003CGetOrAddAsync_003Ed__);
		return _003CGetOrAddAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	private Entity TryAddInternal(Entity entity, IExtendEntityService extendEntityService)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		if (entity == null)
		{
			return null;
		}
		if (entityStorage == null)
		{
			entityStorage = new TypedMap<string, TypedMap<string, Entity>>();
		}
		Guid uid = entity.Uid;
		if (uid == Guid.Empty)
		{
			return entity;
		}
		string text = ((object)(Guid)(ref uid)).ToString();
		Guid typeUid = entity.TypeUid;
		string text2 = ((object)(Guid)(ref typeUid)).ToString();
		if (entityStorage.Has(text2))
		{
			TypedMap<string, Entity> val = entityStorage.Get(text2);
			if (val.Has(text))
			{
				Entity entity2 = val.Get(text);
				object json = entity2.As<ReactiveProxy>().Json;
				object json2 = entity.As<ReactiveProxy>().Json;
				if (entity == entity2)
				{
					TryExtendEntity(entity2, extendEntityService);
					return entity2;
				}
				if (json2 == json)
				{
					TryExtendEntity(entity2, extendEntityService);
					return entity2;
				}
				TryExtendEntity(entity2, extendEntityService);
				ConvertHelper.Reconcile(entity2, json2, Script.Write<object>("globals.reconcileContext", new object[0]));
				return entity2;
			}
			val.Set(text, entity);
			return entity;
		}
		TypedMap<string, Entity> val2 = new TypedMap<string, Entity>();
		val2.Set(text, entity);
		entityStorage.Set(text2, val2);
		TryExtendEntity(entity, extendEntityService);
		return entity;
	}

	private static void TryExtendEntity(Entity entity, IExtendEntityService extendEntityService)
	{
		if (extendEntityService != null && !entity.GetPlainPropertyValue<bool>("extended") && !(((object)entity).get_Item("$$proxyMetadata") is TablePartMetadata))
		{
			IPropertyMetadata[] propertiesToExtend = extendEntityService.GetPropertiesToExtend(entity);
			if (propertiesToExtend.Length != 0)
			{
				extendEntityService.AnalyzeEntityCompleteness(entity, propertiesToExtend);
			}
			((object)entity).set_Item("extended", (object)true);
		}
	}

	private static System.Threading.Tasks.Task TryExtendEntityAsync(Entity entity, IExtendEntityService extendEntityService)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CTryExtendEntityAsync_003Ed__11 _003CTryExtendEntityAsync_003Ed__ = default(_003CTryExtendEntityAsync_003Ed__11);
		_003CTryExtendEntityAsync_003Ed__.entity = entity;
		_003CTryExtendEntityAsync_003Ed__.extendEntityService = extendEntityService;
		_003CTryExtendEntityAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CTryExtendEntityAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CTryExtendEntityAsync_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CTryExtendEntityAsync_003Ed__11>(ref _003CTryExtendEntityAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CTryExtendEntityAsync_003Ed__._003C_003Et__builder)).get_Task();
	}
}
