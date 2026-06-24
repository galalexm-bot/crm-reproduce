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
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Signatures;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Types.Storage;

namespace EleWise.ELMA.DTO;

[Service]
internal sealed class ExtendEntityService : IExtendEntityService
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public Guid metadataUid;

		public Guid metadataImplementationUid;

		public Guid implementationUid;

		public IDependencyHackList hack;

		internal bool _003CGetPropertiesToExtend_003Eb__0(EntityDependency a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			if (!(((Dependency)a).get_HeaderUid() == metadataUid))
			{
				return ((Dependency)a).get_HeaderUid() == metadataImplementationUid;
			}
			return true;
		}

		internal bool _003CGetPropertiesToExtend_003Eb__1(IDependencyHackList a)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ArrayExtensions.Contains<Guid>(a.TypeUids, implementationUid);
		}

		internal bool _003CGetPropertiesToExtend_003Eb__2(IPropertyMetadata a)
		{
			_003C_003Ec__DisplayClass9_6 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_6();
			CS_0024_003C_003E8__locals0.a = a;
			return Enumerable.Any<ValueTuple<Guid, string>>((System.Collections.Generic.IEnumerable<ValueTuple<Guid, string>>)hack.Properties, (Func<ValueTuple<Guid, string>, bool>)((ValueTuple<Guid, string> h) => h.Item2.Equals(((INamedMetadata)CS_0024_003C_003E8__locals0.a).get_Name(), (StringComparison)3)));
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_1
	{
		public ClassMetadata baseClass;

		internal bool _003CGetPropertiesToExtend_003Eb__3(EntityDependency a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)a).get_HeaderUid() == ((IMetadata)baseClass).get_Uid();
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_2
	{
		public string[] queryModelProps;

		internal bool _003CGetPropertiesToExtend_003Eb__5(IPropertyMetadata a)
		{
			_003C_003Ec__DisplayClass9_5 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_5();
			CS_0024_003C_003E8__locals0.a = a;
			return Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)queryModelProps, (Func<string, bool>)((string h) => h.Equals(((INamedMetadata)CS_0024_003C_003E8__locals0.a).get_Name(), (StringComparison)3)));
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_3
	{
		public EnumerableInstance<string> combinedProps;

		internal bool _003CGetPropertiesToExtend_003Eb__7(IPropertyMetadata a)
		{
			_003C_003Ec__DisplayClass9_4 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_4();
			CS_0024_003C_003E8__locals0.a = a;
			return combinedProps.Any((Func<string, bool>)((string h) => h.Equals(((INamedMetadata)CS_0024_003C_003E8__locals0.a).get_Name(), (StringComparison)3)));
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_4
	{
		public IPropertyMetadata a;

		internal bool _003CGetPropertiesToExtend_003Eb__8(string h)
		{
			return h.Equals(((INamedMetadata)a).get_Name(), (StringComparison)3);
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_5
	{
		public IPropertyMetadata a;

		internal bool _003CGetPropertiesToExtend_003Eb__9(string h)
		{
			return h.Equals(((INamedMetadata)a).get_Name(), (StringComparison)3);
		}
	}

	private sealed class _003C_003Ec__DisplayClass9_6
	{
		public IPropertyMetadata a;

		internal bool _003CGetPropertiesToExtend_003Eb__10(ValueTuple<Guid, string> h)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return h.Item2.Equals(((INamedMetadata)a).get_Name(), (StringComparison)3);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<PropertySignature, string> _003C_003E9__9_4;

		public static Func<ValueTuple<Guid, string>, string> _003C_003E9__9_6;

		public static Func<EntityTypeSerializationSettingsDto, Guid> _003C_003E9__10_2;

		public static Func<EntityTypeSerializationSettingsDto, EntityTypeSerializationSettingsDto> _003C_003E9__10_3;

		public static Func<ValueTuple<Guid, string>, string> _003C_003E9__10_4;

		internal string _003CGetPropertiesToExtend_003Eb__9_4(PropertySignature a)
		{
			return a.get_Name();
		}

		internal string _003CGetPropertiesToExtend_003Eb__9_6(ValueTuple<Guid, string> a)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return a.Item2;
		}

		internal Guid _003CLoadEntityDto_003Eb__10_2(EntityTypeSerializationSettingsDto a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return a.TypeUid;
		}

		internal EntityTypeSerializationSettingsDto _003CLoadEntityDto_003Eb__10_3(EntityTypeSerializationSettingsDto b)
		{
			return b;
		}

		internal string _003CLoadEntityDto_003Eb__10_4(ValueTuple<Guid, string> a)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return a.Item2;
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public string uid;

		public ExtendEntityService _003C_003E4__this;

		internal bool _003CLoadEntityDto_003Eb__0(string a)
		{
			return a == uid;
		}

		internal EntityTypeSerializationSettingsDto _003CLoadEntityDto_003Eb__1(EntityDependency a)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return new EntityTypeSerializationSettingsDto
			{
				TypeUid = ((Dependency)a).get_HeaderUid(),
				Properties = a.GetProperties(_003C_003E4__this.dependencyHackList)
			};
		}
	}

	[StructLayout(3)]
	private struct _003CLoadEntityDto_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ExtendEntityService _003C_003E4__this;

		public Entity entityHeader;

		private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

		private string[] _003CextendedList_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ExtendEntityService extendEntityService = _003C_003E4__this;
			try
			{
				TaskAwaiter<Entity> val;
				if (num == 0)
				{
					val = (TaskAwaiter<Entity>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0272;
				}
				_003C_003E8__1 = new _003C_003Ec__DisplayClass10_0();
				_003C_003E8__1._003C_003E4__this = _003C_003E4__this;
				Contract.ArgumentNotNull(entityHeader, "entityHeader");
				Guid val2 = entityHeader.TypeUid;
				string text = ((object)(Guid)(ref val2)).ToString();
				_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = _003C_003E8__1;
				val2 = entityHeader.Uid;
				_003C_003Ec__DisplayClass10_.uid = ((object)(Guid)(ref val2)).ToString();
				_003CextendedList_003E5__2 = extendEntityService.loadedEntities.Get(text);
				if (_003CextendedList_003E5__2 == null)
				{
					_003CextendedList_003E5__2 = new string[0];
					extendEntityService.loadedEntities.Set(text, _003CextendedList_003E5__2);
				}
				if (_003CextendedList_003E5__2.Find((Func<string, bool>)((string a) => a == _003C_003E8__1.uid)) == null)
				{
					Dictionary<Guid, EntityTypeSerializationSettingsDto> val3 = Enumerable.Select<EntityDependency, EntityTypeSerializationSettingsDto>((System.Collections.Generic.IEnumerable<EntityDependency>)Enumerable.ToArray<EntityDependency>(extendEntityService.currentPageService.GetEntityDependencies()), (Func<EntityDependency, EntityTypeSerializationSettingsDto>)((EntityDependency a) => new EntityTypeSerializationSettingsDto
					{
						TypeUid = ((Dependency)a).get_HeaderUid(),
						Properties = a.GetProperties(_003C_003E8__1._003C_003E4__this.dependencyHackList)
					})).ToDictionary<Guid, EntityTypeSerializationSettingsDto>((Func<EntityTypeSerializationSettingsDto, Guid>)((EntityTypeSerializationSettingsDto a) => a.TypeUid), (Func<EntityTypeSerializationSettingsDto, EntityTypeSerializationSettingsDto>)((EntityTypeSerializationSettingsDto b) => b));
					System.Collections.Generic.IEnumerator<IDependencyHackList> enumerator = extendEntityService.dependencyHackList.GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							IDependencyHackList current = enumerator.get_Current();
							Guid[] typeUids = current.TypeUids;
							foreach (Guid val4 in typeUids)
							{
								if (!val3.ContainsKey(val4))
								{
									val3.set_Item(val4, new EntityTypeSerializationSettingsDto
									{
										TypeUid = val4,
										Properties = Enumerable.Select<ValueTuple<Guid, string>, string>((System.Collections.Generic.IEnumerable<ValueTuple<Guid, string>>)current.Properties, (Func<ValueTuple<Guid, string>, string>)((ValueTuple<Guid, string> a) => a.Item2)).ToArray()
									});
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
					val = extendEntityService.entityService.LoadTree(text, _003C_003E8__1.uid, "", Enumerable.ToArray<EntityTypeSerializationSettingsDto>((System.Collections.Generic.IEnumerable<EntityTypeSerializationSettingsDto>)val3.get_Values())).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<Entity>, _003CLoadEntityDto_003Ed__10>(ref val, ref this);
						return;
					}
					goto IL_0272;
				}
				goto end_IL_000e;
				IL_0272:
				Entity result = val.GetResult();
				ConvertHelper.Reconcile(entityHeader, result);
				ArrayExtensions.Push<string>(_003CextendedList_003E5__2, new string[1] { _003C_003E8__1.uid });
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

	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public string uidStr;

		internal bool _003CAnalyzeEntityCompleteness_003Eb__0(string a)
		{
			return a == uidStr;
		}
	}

	[StructLayout(3)]
	private struct _003CAnalyzeEntityCompleteness_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Entity entityHeader;

		public ExtendEntityService _003C_003E4__this;

		public System.Collections.Generic.IEnumerable<IPropertyMetadata> properties;

		private _003C_003Ec__DisplayClass11_0 _003C_003E8__1;

		private string[] _003CextendedList_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e9: Expected O, but got Unknown
			int num = _003C_003E1__state;
			ExtendEntityService extendEntityService = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				if (num == 0)
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_01f9;
				}
				_003C_003E8__1 = new _003C_003Ec__DisplayClass11_0();
				Guid uid = entityHeader.Uid;
				if (!(uid == Guid.Empty))
				{
					_003C_003E8__1.uidStr = ((object)(Guid)(ref uid)).ToString();
					Guid typeUid = entityHeader.TypeUid;
					string text = ((object)(Guid)(ref typeUid)).ToString();
					_003CextendedList_003E5__2 = extendEntityService.checkCompletenessEntities.Get(text);
					if (_003CextendedList_003E5__2 == null)
					{
						_003CextendedList_003E5__2 = new string[0];
						extendEntityService.loadedEntities.Set(text, _003CextendedList_003E5__2);
					}
					if (_003CextendedList_003E5__2.Find((Func<string, bool>)((string a) => a == _003C_003E8__1.uidStr)) == null)
					{
						IPropertyMetadata[] array = (IPropertyMetadata[])(object)new IPropertyMetadata[0];
						object target = ((object)entityHeader).get_Item("$jsonObj");
						System.Collections.Generic.IEnumerator<IPropertyMetadata> enumerator = properties.GetEnumerator();
						try
						{
							while (((System.Collections.IEnumerator)enumerator).MoveNext())
							{
								IPropertyMetadata current = enumerator.get_Current();
								TablePartMetadata val2;
								if (!target.HasProperty(((INamedMetadata)current).get_Name()) && ((val2 = (TablePartMetadata)(object)((current is TablePartMetadata) ? current : null)) == null || !target.HasProperty(val2.get_TablePartPropertyName())))
								{
									ArrayExtensions.Push<IPropertyMetadata>(array, (IPropertyMetadata[])(object)new IPropertyMetadata[1] { current });
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
						if (extendEntityService.loadingEntities.Get(_003C_003E8__1.uidStr) == null)
						{
							if (array.Length != 0)
							{
								extendEntityService.loadingEntities.Set(_003C_003E8__1.uidStr, _003C_003E8__1.uidStr);
								val = extendEntityService.LoadEntityDto(entityHeader).GetAwaiter();
								if (!val.get_IsCompleted())
								{
									num = (_003C_003E1__state = 0);
									_003C_003Eu__1 = val;
									((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CAnalyzeEntityCompleteness_003Ed__11>(ref val, ref this);
									return;
								}
								goto IL_01f9;
							}
							goto IL_0217;
						}
					}
				}
				goto end_IL_000e;
				IL_0217:
				ArrayExtensions.Push<string>(_003CextendedList_003E5__2, new string[1] { _003C_003E8__1.uidStr });
				goto end_IL_000e;
				IL_01f9:
				val.GetResult();
				extendEntityService.loadingEntities.Delete(_003C_003E8__1.uidStr);
				goto IL_0217;
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

	private readonly TypedMap<string, string> loadingEntities = new TypedMap<string, string>();

	private readonly TypedMap<string, string[]> loadedEntities = new TypedMap<string, string[]>();

	private readonly TypedMap<string, string[]> checkCompletenessEntities = new TypedMap<string, string[]>();

	private readonly IProxyGeneratorService proxyGeneratorService;

	private readonly IEntityService entityService;

	private readonly ICurrentPageService currentPageService;

	private readonly IMetadataServiceContext metadataService;

	private readonly System.Collections.Generic.IEnumerable<IDependencyHackList> dependencyHackList;

	public ExtendEntityService(IEntityService entityService, IProxyGeneratorService proxyGeneratorService, ICurrentPageService currentPageService, IMetadataServiceContext metadataService, System.Collections.Generic.IEnumerable<IDependencyHackList> dependencyHackList)
	{
		this.proxyGeneratorService = proxyGeneratorService;
		this.entityService = entityService;
		this.currentPageService = currentPageService;
		this.metadataService = metadataService;
		this.dependencyHackList = dependencyHackList;
	}

	public IPropertyMetadata[] GetPropertiesToExtend(Entity entity)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass9_6 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
		if (entity == null)
		{
			return (IPropertyMetadata[])(object)new IPropertyMetadata[0];
		}
		CS_0024_003C_003E8__locals0.implementationUid = entity.TypeUid;
		IMetadata metadata = metadataService.GetMetadata(CS_0024_003C_003E8__locals0.implementationUid);
		EntityMetadata val;
		if ((val = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null)) == null)
		{
			return (IPropertyMetadata[])(object)new IPropertyMetadata[0];
		}
		CS_0024_003C_003E8__locals0.metadataImplementationUid = val.get_ImplementationUid();
		CS_0024_003C_003E8__locals0.metadataUid = ((IMetadata)val).get_Uid();
		entity.As<ReactiveProxy>().Metadata = (ClassMetadata)(object)val;
		EntityDependency[] array = Enumerable.ToArray<EntityDependency>(currentPageService.GetEntityDependencies());
		EntityDependency val2 = Enumerable.FirstOrDefault<EntityDependency>((System.Collections.Generic.IEnumerable<EntityDependency>)array, (Func<EntityDependency, bool>)((EntityDependency a) => ((Dependency)a).get_HeaderUid() == CS_0024_003C_003E8__locals0.metadataUid || ((Dependency)a).get_HeaderUid() == CS_0024_003C_003E8__locals0.metadataImplementationUid));
		if (val2 != null)
		{
			System.Collections.Generic.ICollection<PropertySignature> properties = ((ClassDependency)val2).get_Properties();
			EntityDependency obj = InterfaceCreator.Create<EntityDependency>();
			((Dependency)obj).set_HeaderUid(((Dependency)val2).get_HeaderUid());
			val2 = obj;
			((ClassDependency)val2).get_Properties().AddRange((System.Collections.Generic.IEnumerable<PropertySignature>)properties);
		}
		System.Collections.Generic.IEnumerator<ClassMetadata> enumerator = metadataService.GetBaseClasses(CS_0024_003C_003E8__locals0.metadataUid).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				_003C_003Ec__DisplayClass9_1 CS_0024_003C_003E8__locals2 = new _003C_003Ec__DisplayClass9_1();
				CS_0024_003C_003E8__locals2.baseClass = enumerator.get_Current();
				EntityDependency val3 = Enumerable.FirstOrDefault<EntityDependency>((System.Collections.Generic.IEnumerable<EntityDependency>)array, (Func<EntityDependency, bool>)((EntityDependency a) => ((Dependency)a).get_HeaderUid() == ((IMetadata)CS_0024_003C_003E8__locals2.baseClass).get_Uid()));
				if (val3 != null)
				{
					if (val2 == null)
					{
						EntityDependency obj2 = InterfaceCreator.Create<EntityDependency>();
						((Dependency)obj2).set_HeaderUid(((Dependency)val3).get_HeaderUid());
						val2 = obj2;
						((ClassDependency)val2).get_Properties().AddRange((System.Collections.Generic.IEnumerable<PropertySignature>)((ClassDependency)val3).get_Properties());
					}
					else
					{
						((ClassDependency)val2).get_Properties().AddRange((System.Collections.Generic.IEnumerable<PropertySignature>)((ClassDependency)val3).get_Properties());
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		System.Collections.Generic.IEnumerable<IPropertyMetadata> properties2 = metadataService.GetProperties((ClassMetadata)(object)val, val != null);
		CS_0024_003C_003E8__locals0.hack = Enumerable.FirstOrDefault<IDependencyHackList>(dependencyHackList, (Func<IDependencyHackList, bool>)((IDependencyHackList a) => ArrayExtensions.Contains<Guid>(a.TypeUids, CS_0024_003C_003E8__locals0.implementationUid)));
		if (val2 != null)
		{
			_003C_003Ec__DisplayClass9_2 CS_0024_003C_003E8__locals3 = new _003C_003Ec__DisplayClass9_2();
			CS_0024_003C_003E8__locals3.queryModelProps = Enumerable.Select<PropertySignature, string>((System.Collections.Generic.IEnumerable<PropertySignature>)((ClassDependency)val2).get_Properties(), (Func<PropertySignature, string>)((PropertySignature a) => a.get_Name())).ToArray();
			if (CS_0024_003C_003E8__locals0.hack != null)
			{
				_003C_003Ec__DisplayClass9_3 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass9_3();
				CS_0024_003C_003E8__locals1.combinedProps = Enumerable.Concat<string>((System.Collections.Generic.IEnumerable<string>)CS_0024_003C_003E8__locals3.queryModelProps, (System.Collections.Generic.IEnumerable<string>)Enumerable.Select<ValueTuple<Guid, string>, string>((System.Collections.Generic.IEnumerable<ValueTuple<Guid, string>>)CS_0024_003C_003E8__locals0.hack.Properties, (Func<ValueTuple<Guid, string>, string>)((ValueTuple<Guid, string> a) => a.Item2)));
				return Enumerable.Where<IPropertyMetadata>(properties2, (Func<IPropertyMetadata, bool>)delegate(IPropertyMetadata a)
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_4();
					CS_0024_003C_003E8__locals0.a = a;
					return CS_0024_003C_003E8__locals1.combinedProps.Any((Func<string, bool>)((string h) => h.Equals(((INamedMetadata)CS_0024_003C_003E8__locals0.a).get_Name(), (StringComparison)3)));
				}).ToArray();
			}
			if (CS_0024_003C_003E8__locals3.queryModelProps.Length == 0)
			{
				return (IPropertyMetadata[])(object)new IPropertyMetadata[0];
			}
			return Enumerable.Where<IPropertyMetadata>(properties2, (Func<IPropertyMetadata, bool>)delegate(IPropertyMetadata a)
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_5();
				CS_0024_003C_003E8__locals0.a = a;
				return Enumerable.Any<string>((System.Collections.Generic.IEnumerable<string>)CS_0024_003C_003E8__locals3.queryModelProps, (Func<string, bool>)((string h) => h.Equals(((INamedMetadata)CS_0024_003C_003E8__locals0.a).get_Name(), (StringComparison)3)));
			}).ToArray();
		}
		if (CS_0024_003C_003E8__locals0.hack == null)
		{
			return (IPropertyMetadata[])(object)new IPropertyMetadata[0];
		}
		return Enumerable.Where<IPropertyMetadata>(properties2, (Func<IPropertyMetadata, bool>)delegate(IPropertyMetadata a)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_6();
			CS_0024_003C_003E8__locals0.a = a;
			return Enumerable.Any<ValueTuple<Guid, string>>((System.Collections.Generic.IEnumerable<ValueTuple<Guid, string>>)CS_0024_003C_003E8__locals0.hack.Properties, (Func<ValueTuple<Guid, string>, bool>)((ValueTuple<Guid, string> h) => h.Item2.Equals(((INamedMetadata)CS_0024_003C_003E8__locals0.a).get_Name(), (StringComparison)3)));
		}).ToArray();
	}

	private System.Threading.Tasks.Task LoadEntityDto(Entity entityHeader)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadEntityDto_003Ed__10 _003CLoadEntityDto_003Ed__ = default(_003CLoadEntityDto_003Ed__10);
		_003CLoadEntityDto_003Ed__._003C_003E4__this = this;
		_003CLoadEntityDto_003Ed__.entityHeader = entityHeader;
		_003CLoadEntityDto_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CLoadEntityDto_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CLoadEntityDto_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CLoadEntityDto_003Ed__10>(ref _003CLoadEntityDto_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CLoadEntityDto_003Ed__._003C_003Et__builder)).get_Task();
	}

	public System.Threading.Tasks.Task AnalyzeEntityCompleteness(Entity entityHeader, System.Collections.Generic.IEnumerable<IPropertyMetadata> properties)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CAnalyzeEntityCompleteness_003Ed__11 _003CAnalyzeEntityCompleteness_003Ed__ = default(_003CAnalyzeEntityCompleteness_003Ed__11);
		_003CAnalyzeEntityCompleteness_003Ed__._003C_003E4__this = this;
		_003CAnalyzeEntityCompleteness_003Ed__.entityHeader = entityHeader;
		_003CAnalyzeEntityCompleteness_003Ed__.properties = properties;
		_003CAnalyzeEntityCompleteness_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CAnalyzeEntityCompleteness_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CAnalyzeEntityCompleteness_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CAnalyzeEntityCompleteness_003Ed__11>(ref _003CAnalyzeEntityCompleteness_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CAnalyzeEntityCompleteness_003Ed__._003C_003Et__builder)).get_Task();
	}
}
