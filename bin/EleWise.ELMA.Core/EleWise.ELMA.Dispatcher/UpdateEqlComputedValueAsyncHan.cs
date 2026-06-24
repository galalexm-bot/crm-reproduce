using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge.Html5;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Api.Services;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Storages;

namespace EleWise.ELMA.Dispatcher;

[Component]
internal sealed class UpdateEqlComputedValueAsyncHandler : AbstractAsyncCommandHandler
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public Guid subTypeUid;

		internal bool _003CHandleAsync_003Eb__1(EntityDependency a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)a).get_HeaderUid() == subTypeUid;
		}
	}

	[StructLayout(3)]
	private struct _003CHandleAsync_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionCommand command;

		public UpdateEqlComputedValueAsyncHandler _003C_003E4__this;

		private ReactiveProxy _003Ccontext_003E5__2;

		private PropertyInfoExpression _003CpropertyName_003E5__3;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			UpdateEqlComputedValueAsyncHandler CS_0024_003C_003E8__locals0 = _003C_003E4__this;
			try
			{
				TaskAwaiter<Entity[]> val;
				if (num == 0)
				{
					val = (TaskAwaiter<Entity[]>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_01fe;
				}
				if (num == 1)
				{
					val = (TaskAwaiter<Entity[]>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_02ac;
				}
				if (!(command.ActionTypeId != "UpdateEqlComputedValue") && command.Args.Length > 1 && command.Args[1] is object[] array && array.Length > 2)
				{
					_003Ccontext_003E5__2 = array[0] as ReactiveProxy;
					if (_003Ccontext_003E5__2 != null)
					{
						object obj = array[1];
						IPropertyMetadata val2 = (IPropertyMetadata)((obj is IPropertyMetadata) ? obj : null);
						EntitySettings val3;
						if (val2 != null && array[2] is string eqlQuery && (val3 = (EntitySettings)/*isinst with value type is only supported in some contexts*/) != null)
						{
							_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass6_0();
							CS_0024_003C_003E8__locals1.subTypeUid = val2.get_SubTypeUid();
							System.Collections.Generic.IEnumerable<EntityDependency> entityDependencies = CS_0024_003C_003E8__locals0.currentPageService.GetEntityDependencies();
							EntityTypeSerializationSettingsDto[] array2 = Enumerable.Select<EntityDependency, EntityTypeSerializationSettingsDto>(entityDependencies, (Func<EntityDependency, EntityTypeSerializationSettingsDto>)((EntityDependency a) => new EntityTypeSerializationSettingsDto
							{
								TypeUid = ((Dependency)a).get_HeaderUid(),
								Properties = a.GetProperties(CS_0024_003C_003E8__locals0.dependencyHackList)
							})).ToArray();
							if (Enumerable.FirstOrDefault<EntityDependency>(entityDependencies, (Func<EntityDependency, bool>)((EntityDependency a) => ((Dependency)a).get_HeaderUid() == CS_0024_003C_003E8__locals1.subTypeUid)) == null)
							{
								ArrayExtensions.Push<EntityTypeSerializationSettingsDto>(array2, new EntityTypeSerializationSettingsDto[1]
								{
									new EntityTypeSerializationSettingsDto
									{
										TypeUid = CS_0024_003C_003E8__locals1.subTypeUid,
										Properties = new string[2] { "Uid", "$toString" }
									}
								});
							}
							_003CpropertyName_003E5__3 = CS_0024_003C_003E8__locals0.metadataServiceContext.GetPropertyExpression(val2, _003Ccontext_003E5__2.Metadata);
							if (val3.get_RelationType() == 0)
							{
								IEntityService entityService = CS_0024_003C_003E8__locals0.entityService;
								Guid subTypeUid = val2.get_SubTypeUid();
								val = entityService.QueryTreeWithDependencies(((object)(Guid)(ref subTypeUid)).ToString(), eqlQuery, "", array2, "", 1).GetAwaiter();
								if (!val.get_IsCompleted())
								{
									num = (_003C_003E1__state = 0);
									_003C_003Eu__1 = val;
									((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<Entity[]>, _003CHandleAsync_003Ed__6>(ref val, ref this);
									return;
								}
								goto IL_01fe;
							}
							val = CS_0024_003C_003E8__locals0.entityService.QueryTreeWithDependencies(((object)(Guid)(ref CS_0024_003C_003E8__locals1.subTypeUid)).ToString(), eqlQuery, "", array2, "").GetAwaiter();
							if (!val.get_IsCompleted())
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__1 = val;
								((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<Entity[]>, _003CHandleAsync_003Ed__6>(ref val, ref this);
								return;
							}
							goto IL_02ac;
						}
					}
				}
				goto end_IL_000e;
				IL_01fe:
				Entity[] result = val.GetResult();
				Entity[] array3 = CS_0024_003C_003E8__locals0.ExtendEntities(result);
				_003Ccontext_003E5__2.SetPlainPropertyValue(_003CpropertyName_003E5__3, Enumerable.FirstOrDefault<Entity>((System.Collections.Generic.IEnumerable<Entity>)array3));
				goto IL_02e3;
				IL_02e3:
				_003CpropertyName_003E5__3 = null;
				goto end_IL_000e;
				IL_02ac:
				Entity[] result2 = val.GetResult();
				Entity[] source = CS_0024_003C_003E8__locals0.ExtendEntities(result2);
				System.Collections.Generic.ICollection<Entity> collection = ObjectExtensions.As<System.Collections.Generic.ICollection<Entity>>(_003Ccontext_003E5__2.GetPlainPropertyValue(_003CpropertyName_003E5__3));
				collection.Clear();
				collection.AddRange(source);
				goto IL_02e3;
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

	private readonly IMetadataServiceContext metadataServiceContext;

	private readonly IEntityService entityService;

	private readonly IEntityStorage entityStorage;

	private readonly ICurrentPageService currentPageService;

	private readonly System.Collections.Generic.IEnumerable<IDependencyHackList> dependencyHackList;

	public UpdateEqlComputedValueAsyncHandler(IEntityService entityService, IMetadataServiceContext metadataServiceContext, IEntityStorage entityStorage, ICurrentPageService currentPageService, System.Collections.Generic.IEnumerable<IDependencyHackList> dependencyHackList)
	{
		this.metadataServiceContext = metadataServiceContext;
		this.entityService = entityService;
		this.entityStorage = entityStorage;
		this.currentPageService = currentPageService;
		this.dependencyHackList = dependencyHackList;
	}

	public override System.Threading.Tasks.Task HandleAsync(ActionCommand command)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CHandleAsync_003Ed__6 _003CHandleAsync_003Ed__ = default(_003CHandleAsync_003Ed__6);
		_003CHandleAsync_003Ed__._003C_003E4__this = this;
		_003CHandleAsync_003Ed__.command = command;
		_003CHandleAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CHandleAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CHandleAsync_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CHandleAsync_003Ed__6>(ref _003CHandleAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CHandleAsync_003Ed__._003C_003Et__builder)).get_Task();
	}

	private Entity[] ExtendEntities(System.Collections.Generic.IEnumerable<Entity> entities)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		Entity[] array = new Entity[0];
		System.Collections.Generic.IEnumerator<Entity> enumerator = entities.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				Entity current = enumerator.get_Current();
				IEntityStorage obj = entityStorage;
				Guid val = current.TypeUid;
				string typeUid = ((object)(Guid)(ref val)).ToString();
				val = current.Uid;
				Entity orAdd = obj.GetOrAdd(typeUid, ((object)(Guid)(ref val)).ToString(), JSON.Parse(JSON.Stringify(((object)current).get_Item("$jsonObj"))));
				ArrayExtensions.Push<Entity>(array, new Entity[1] { orAdd });
			}
			return array;
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private EntityTypeSerializationSettingsDto _003CHandleAsync_003Eb__6_0(EntityDependency a)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return new EntityTypeSerializationSettingsDto
		{
			TypeUid = ((Dependency)a).get_HeaderUid(),
			Properties = a.GetProperties(dependencyHackList)
		};
	}
}
