using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Bridge.Html5;
using EleWise.ELMA.Api.Services.Internal;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Dispatcher;

[Component]
internal sealed class SaveEntitiesAsyncCommandHandler : AbstractAsyncCommandHandler
{
	private class EntityPropertyInfo
	{
		private object _003CModel_003Ek__BackingField;

		private string _003CPropertyName_003Ek__BackingField;

		private object _003CEntity_003Ek__BackingField;

		private RelationType _003CRelationType_003Ek__BackingField;

		public object Model
		{
			get
			{
				return _003CModel_003Ek__BackingField;
			}
			set
			{
				_003CModel_003Ek__BackingField = value;
			}
		}

		public string PropertyName
		{
			get
			{
				return _003CPropertyName_003Ek__BackingField;
			}
			set
			{
				_003CPropertyName_003Ek__BackingField = value;
			}
		}

		public object Entity
		{
			get
			{
				return _003CEntity_003Ek__BackingField;
			}
			set
			{
				_003CEntity_003Ek__BackingField = value;
			}
		}

		public RelationType RelationType
		{
			get
			{
				return _003CRelationType_003Ek__BackingField;
			}
			set
			{
				_003CRelationType_003Ek__BackingField = value;
			}
		}

		public EntityPropertyInfo(string propertyName, Entity entity, object model, RelationType relationType)
		{
			PropertyName = propertyName;
			Entity = entity;
			Model = model;
			RelationType = relationType;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ComputedValue, bool> _003C_003E9__8_0;

		public static Func<string, Guid> _003C_003E9__8_2;

		public static Func<string, EnumerableInstance<Guid>> _003C_003E9__8_1;

		internal bool _003CHandleAsync_003Eb__8_0(ComputedValue p)
		{
			return p.Name == "SaveActionPropertiesInput";
		}

		internal EnumerableInstance<Guid> _003CHandleAsync_003Eb__8_1(string s)
		{
			return Enumerable.Select<string, Guid>((System.Collections.Generic.IEnumerable<string>)StringPrototype.Split(s, "_"), (Func<string, Guid>)((string k) => new Guid(k)));
		}

		internal Guid _003CHandleAsync_003Eb__8_2(string k)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return new Guid(k);
		}
	}

	[StructLayout(3)]
	private struct _003CHandleAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ActionCommand command;

		public SaveEntitiesAsyncCommandHandler _003C_003E4__this;

		private IMetadataViewModel _003Cowner_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Expected O, but got Unknown
			int num = _003C_003E1__state;
			SaveEntitiesAsyncCommandHandler saveEntitiesAsyncCommandHandler = _003C_003E4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0133;
				}
				EnumerableInstance<EnumerableInstance<Guid>> val = default(EnumerableInstance<EnumerableInstance<Guid>>);
				if (!(command.ActionTypeId != "SaveEntitiesAsyncTypeCommand"))
				{
					_003Cowner_003E5__2 = (command.Args[0] as IViewModel)?.RenderOwner as IMetadataViewModel;
					if (_003Cowner_003E5__2 != null && command.Args[1] is object[] array && array[0] is SaveEntitiesModel saveEntitiesModel)
					{
						string text = Enumerable.FirstOrDefault<ComputedValue>((System.Collections.Generic.IEnumerable<ComputedValue>)saveEntitiesModel.DynamicProperties, (Func<ComputedValue, bool>)((ComputedValue p) => p.Name == "SaveActionPropertiesInput"))?.Value;
						if (!string.IsNullOrWhiteSpace(text))
						{
							val = Enumerable.Select<string, EnumerableInstance<Guid>>((System.Collections.Generic.IEnumerable<string>)StringPrototype.Split(text, ","), (Func<string, EnumerableInstance<Guid>>)((string s) => Enumerable.Select<string, Guid>((System.Collections.Generic.IEnumerable<string>)StringPrototype.Split(s, "_"), (Func<string, Guid>)((string k) => new Guid(k)))));
							if (val.Any())
							{
								saveEntitiesAsyncCommandHandler.loaderService.Show("SaveEntitiesActionExecution", SR.T("Сохранение"));
								goto IL_0133;
							}
						}
					}
				}
				goto end_IL_000e;
				IL_0133:
				try
				{
					TaskAwaiter val2;
					if (num != 0)
					{
						val2 = saveEntitiesAsyncCommandHandler.SaveEntities((System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<Guid>>)val, _003Cowner_003E5__2.ModelMetadata).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val2;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CHandleAsync_003Ed__8>(ref val2, ref this);
							return;
						}
					}
					else
					{
						val2 = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
					}
					val2.GetResult();
				}
				catch (System.Exception ex)
				{
					string message = SR.T("Ошибка при сохранении данных в компоненте '{0}':\r\n{1}", _003Cowner_003E5__2.Component.Name, ex.get_Message());
					saveEntitiesAsyncCommandHandler.notificationService.Error(SR.T("Ошибка"), message, autoClosed: false);
				}
				finally
				{
					if (num < 0)
					{
						saveEntitiesAsyncCommandHandler.loaderService.Hide("SaveEntitiesActionExecution");
					}
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

	[StructLayout(3)]
	private struct _003CSaveEntities_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<Guid>> propertyPaths;

		public SaveEntitiesAsyncCommandHandler _003C_003E4__this;

		public ModelMetadata modelMetadata;

		private void MoveNext()
		{
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			SaveEntitiesAsyncCommandHandler CS_0024_003C_003E8__locals0 = _003C_003E4__this;
			try
			{
				List<EntitySaveRequest> val = new List<EntitySaveRequest>();
				Dictionary<string, EntityPropertyInfo[]> entityPropertyMap = new Dictionary<string, EntityPropertyInfo[]>();
				System.Collections.Generic.IEnumerator<System.Collections.Generic.IEnumerable<Guid>> enumerator = propertyPaths.GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						System.Collections.Generic.IEnumerable<Guid> current = enumerator.get_Current();
						ValueTuple<string, object> property = CS_0024_003C_003E8__locals0.GetProperty(current, modelMetadata);
						string item = property.Item1;
						object item2 = property.Item2;
						if (item != null && item2 != null)
						{
							EntitySaveRequest val2 = CS_0024_003C_003E8__locals0.GenerateRequestItem(item, item2, entityPropertyMap);
							if (val2 != null)
							{
								val.Add(val2);
							}
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
				if (Enumerable.Any<EntitySaveRequest>((System.Collections.Generic.IEnumerable<EntitySaveRequest>)val))
				{
					EntityListSaveRequest obj = InterfaceCreator.Create<EntityListSaveRequest>();
					obj.set_Items((System.Collections.Generic.ICollection<EntitySaveRequest>)val);
					obj.set_EntityTypeSerializationSettings((System.Collections.Generic.ICollection<EntityTypeSerializationSettings>)Enumerable.Select<EntityDependency, EntityTypeSerializationSettings>(CS_0024_003C_003E8__locals0.currentPageService.GetEntityDependencies(), (Func<EntityDependency, EntityTypeSerializationSettings>)delegate(EntityDependency a)
					{
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						EntityTypeSerializationSettings obj2 = InterfaceCreator.Create<EntityTypeSerializationSettings>();
						obj2.set_TypeUid(((Dependency)a).get_HeaderUid());
						obj2.set_Properties((System.Collections.Generic.ICollection<string>)a.GetProperties(CS_0024_003C_003E8__locals0.dependencyHackList));
						return obj2;
					}).ToList());
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

	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public Guid propertyUid;

		internal bool _003CGetProperty_003Eb__0(PropertyMetadata prop)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)prop).get_Uid() == propertyUid;
		}
	}

	private const string SaveActionPropertiesInputName = "SaveActionPropertiesInput";

	private readonly IMetadataServiceContext metadataService;

	private readonly INotificationService notificationService;

	private readonly IEntityService entityService;

	private readonly ILoaderService loaderService;

	private readonly ICurrentPageService currentPageService;

	private readonly System.Collections.Generic.IEnumerable<IDependencyHackList> dependencyHackList;

	public SaveEntitiesAsyncCommandHandler(IMetadataServiceContext metadataService, INotificationService notificationService, IEntityService entityService, ILoaderService loaderService, ICurrentPageService currentPageService, System.Collections.Generic.IEnumerable<IDependencyHackList> dependencyHackList)
	{
		this.metadataService = metadataService;
		this.notificationService = notificationService;
		this.entityService = entityService;
		this.loaderService = loaderService;
		this.currentPageService = currentPageService;
		this.dependencyHackList = dependencyHackList;
	}

	public override System.Threading.Tasks.Task HandleAsync(ActionCommand command)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CHandleAsync_003Ed__8 _003CHandleAsync_003Ed__ = default(_003CHandleAsync_003Ed__8);
		_003CHandleAsync_003Ed__._003C_003E4__this = this;
		_003CHandleAsync_003Ed__.command = command;
		_003CHandleAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CHandleAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CHandleAsync_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CHandleAsync_003Ed__8>(ref _003CHandleAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CHandleAsync_003Ed__._003C_003Et__builder)).get_Task();
	}

	private System.Threading.Tasks.Task SaveEntities(System.Collections.Generic.IEnumerable<System.Collections.Generic.IEnumerable<Guid>> propertyPaths, ModelMetadata modelMetadata)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CSaveEntities_003Ed__9 _003CSaveEntities_003Ed__ = default(_003CSaveEntities_003Ed__9);
		_003CSaveEntities_003Ed__._003C_003E4__this = this;
		_003CSaveEntities_003Ed__.propertyPaths = propertyPaths;
		_003CSaveEntities_003Ed__.modelMetadata = modelMetadata;
		_003CSaveEntities_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CSaveEntities_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CSaveEntities_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CSaveEntities_003Ed__9>(ref _003CSaveEntities_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CSaveEntities_003Ed__._003C_003Et__builder)).get_Task();
	}

	private ValueTuple<string, object> GetProperty(System.Collections.Generic.IEnumerable<Guid> propertyPath, ModelMetadata modelMetadata)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		System.Collections.Generic.ICollection<PropertyMetadata> properties = modelMetadata.Metadata.get_Properties();
		object obj = modelMetadata.Model;
		string text = null;
		System.Collections.Generic.IEnumerator<Guid> enumerator = propertyPath.GetEnumerator();
		bool flag = ((System.Collections.IEnumerator)enumerator).MoveNext();
		while (flag)
		{
			_003C_003Ec__DisplayClass10_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass10_0();
			CS_0024_003C_003E8__locals0.propertyUid = enumerator.get_Current();
			PropertyMetadata val = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)properties, (Func<PropertyMetadata, bool>)((PropertyMetadata prop) => ((IMetadata)prop).get_Uid() == CS_0024_003C_003E8__locals0.propertyUid));
			if (val == null)
			{
				return new ValueTuple<string, object>((string)null, (object)null);
			}
			text = ((INamedMetadata)val).get_Name();
			flag = ((System.Collections.IEnumerator)enumerator).MoveNext();
			if (flag)
			{
				IMetadata metadata = metadataService.GetMetadata(((IPropertyMetadata)val).get_SubTypeUid());
				EntityMetadata val2 = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null);
				if (val2 == null)
				{
					return new ValueTuple<string, object>((string)null, (object)null);
				}
				properties = ((ClassMetadata)val2).get_Properties();
				obj = obj.GetPlainPropertyValue(text);
				if (obj == null)
				{
					return new ValueTuple<string, object>((string)null, (object)null);
				}
			}
		}
		return new ValueTuple<string, object>(text, obj);
	}

	private EntitySaveRequest GenerateRequestItem(string propertyName, object model, Dictionary<string, EntityPropertyInfo[]> entityPropertyMap)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		object plainPropertyValue = model.GetPlainPropertyValue(propertyName);
		if (plainPropertyValue == null)
		{
			return null;
		}
		object obj = null;
		Guid val = Guid.Empty;
		Guid uid;
		if (plainPropertyValue is System.Collections.Generic.ICollection<Entity> collection && Enumerable.Any<Entity>((System.Collections.Generic.IEnumerable<Entity>)collection))
		{
			List<object> val2 = new List<object>();
			val = Enumerable.First<Entity>((System.Collections.Generic.IEnumerable<Entity>)collection).TypeUid;
			System.Collections.Generic.IEnumerator<Entity> enumerator = ((System.Collections.Generic.IEnumerable<Entity>)collection).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					Entity current = enumerator.get_Current();
					val2.Add(((object)current).get_Item("$jsonObj"));
					uid = current.Uid;
					string key = ((object)(Guid)(ref uid)).ToString();
					EntityPropertyInfo item = new EntityPropertyInfo(propertyName, current, model, RelationType.ManyToMany);
					SetOrUpdateMapItem(entityPropertyMap, key, item);
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
			if (Enumerable.Any<object>((System.Collections.Generic.IEnumerable<object>)val2))
			{
				obj = val2;
			}
		}
		else if (plainPropertyValue is Entity entity)
		{
			obj = ((object)entity).get_Item("$jsonObj");
			val = entity.TypeUid;
			EntityPropertyInfo item2 = new EntityPropertyInfo(propertyName, entity, model, RelationType.OneToOne);
			uid = entity.Uid;
			string key2 = ((object)(Guid)(ref uid)).ToString();
			SetOrUpdateMapItem(entityPropertyMap, key2, item2);
		}
		if (obj == null || val == Guid.Empty)
		{
			return null;
		}
		EntitySaveRequest obj2 = InterfaceCreator.Create<EntitySaveRequest>();
		obj2.set_TypeUid(val);
		obj2.set_Model(JSON.Stringify(ConvertHelper.Serialize(obj, new SerializationSettings
		{
			WriteReferences = true
		})));
		return obj2;
	}

	private void UpdateProps(System.Collections.Generic.ICollection<EntitySaveResponse> entities, Dictionary<string, EntityPropertyInfo[]> entityPropertyMap)
	{
		if (entities == null)
		{
			return;
		}
		System.Collections.Generic.IEnumerator<EntitySaveResponse> enumerator = ((System.Collections.Generic.IEnumerable<EntitySaveResponse>)entities).GetEnumerator();
		try
		{
			EntityPropertyInfo[] array = default(EntityPropertyInfo[]);
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				object obj = JSON.Parse(enumerator.get_Current().get_Model());
				string uidPropertyValue = GetUidPropertyValue(obj);
				if (uidPropertyValue == null || !entityPropertyMap.TryGetValue(uidPropertyValue, ref array))
				{
					continue;
				}
				EntityPropertyInfo[] array2 = array;
				foreach (EntityPropertyInfo entityPropertyInfo in array2)
				{
					if (entityPropertyInfo.RelationType != 0)
					{
						ConvertHelper.Reconcile(entityPropertyInfo.Entity, obj);
					}
					else
					{
						ConvertHelper.ReconcileProperty(entityPropertyInfo.PropertyName, entityPropertyInfo.Model, obj);
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void SetOrUpdateMapItem(Dictionary<string, EntityPropertyInfo[]> map, string key, EntityPropertyInfo item)
	{
		EntityPropertyInfo[] array = default(EntityPropertyInfo[]);
		if (map.TryGetValue(key, ref array))
		{
			ArrayExtensions.Push<EntityPropertyInfo>(array, new EntityPropertyInfo[1] { item });
		}
		else
		{
			map.Add(key, new EntityPropertyInfo[1] { item });
		}
	}

	private string GetUidPropertyValue(object model)
	{
		if (model.HasProperty("Uid"))
		{
			return (string)model.GetPlainPropertyValue("Uid");
		}
		return null;
	}

	private EntityTypeSerializationSettings _003CSaveEntities_003Eb__9_0(EntityDependency a)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		EntityTypeSerializationSettings obj = InterfaceCreator.Create<EntityTypeSerializationSettings>();
		obj.set_TypeUid(((Dependency)a).get_HeaderUid());
		obj.set_Properties((System.Collections.Generic.ICollection<string>)a.GetProperties(dependencyHackList));
		return obj;
	}
}
