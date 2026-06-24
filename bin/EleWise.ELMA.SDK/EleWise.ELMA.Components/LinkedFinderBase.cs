using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Components;

public abstract class LinkedFinderBase : ILinkedFinder
{
	internal static LinkedFinderBase X2syZyfhd5ceA4UetVZ2;

	public IEnumerable<IDependenciesExtension> DependenciesExtensions { get; set; }

	public abstract FindLinkedObjectsResult FindLinkedObjects(ICollection<ILinkedObject> metadataList, LinkedObjectsContext context);

	public virtual FindLinkedObjectsResult FindLinkedObjects(ICollection<ILinkedObject> metadataList, RuntimeObjectsContext emptyContext)
	{
		throw new NotImplementedException();
	}

	protected abstract IMetadata GetMetadataWithUid(Guid metadataId, LinkedObjectsContext context);

	protected IMetadata GetMetadata(Guid metadataId, LinkedObjectsContext context, FindLinkedObjectsResult resultObj)
	{
		int num = 7;
		IMetadata value = default(IMetadata);
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					value = GetMetadataWithUid(_003C_003Ec__DisplayClass7_.metadataId, context);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				case 4:
					return value;
				case 3:
					return value;
				default:
					if (value != null)
					{
						num2 = 2;
						continue;
					}
					goto case 3;
				case 7:
					_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
					num2 = 6;
					continue;
				case 6:
					_003C_003Ec__DisplayClass7_.metadataId = metadataId;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (!context.LoadedMetadata.TryGetValue(_003C_003Ec__DisplayClass7_.metadataId, out value))
					{
						if (context.AllObjects.FirstOrDefault(_003C_003Ec__DisplayClass7_._003CGetMetadata_003Eb__0) == null)
						{
							return null;
						}
						num2 = 5;
					}
					else
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
			context.LoadedMetadata[_003C_003Ec__DisplayClass7_.metadataId] = value;
			num = 3;
		}
	}

	protected void FillObj(FindLinkedObjectsResult resultObj, LinkedObjectsContext context, Guid mdId)
	{
		//Discarded unreachable code: IL_0077, IL_00a2, IL_00b1
		int num = 9;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		_003C_003Ec__DisplayClass8_1 _003C_003Ec__DisplayClass8_2 = default(_003C_003Ec__DisplayClass8_1);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 8:
					_003C_003Ec__DisplayClass8_.mdId = mdId;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					return;
				case 10:
					resultObj.LinkedObjects.Add(_003C_003Ec__DisplayClass8_2.obj);
					num2 = 6;
					continue;
				case 0:
					return;
				case 2:
					context.CheckedObjects.Add(_003C_003Ec__DisplayClass8_2.obj);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 12;
					}
					continue;
				case 5:
					if (resultObj.LinkedObjects.All(_003C_003Ec__DisplayClass8_2._003CFillObj_003Eb__3))
					{
						num2 = 10;
						continue;
					}
					goto case 6;
				case 1:
					break;
				case 6:
					resultObj.AddedObjects.Add(_003C_003Ec__DisplayClass8_2.obj);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					if (!context.CheckedObjects.All(_003C_003Ec__DisplayClass8_._003CFillObj_003Eb__1))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 7:
					if (!context.AllObjects.Any(_003C_003Ec__DisplayClass8_._003CFillObj_003Eb__0))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 12:
					return;
				case 4:
					_003C_003Ec__DisplayClass8_2 = new _003C_003Ec__DisplayClass8_1();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass8_2.obj = context.AllObjects.First(_003C_003Ec__DisplayClass8_._003CFillObj_003Eb__2);
			num = 5;
		}
	}

	protected T GetObjectFromContextLoadedDataOrLoad<T>(Guid uid, LinkedObjectsContext context, Func<Guid, T> loadFn) where T : class
	{
		if (context.LoadedData.TryGetValue(uid, out var value))
		{
			if (value is T result)
			{
				return result;
			}
		}
		else
		{
			T val = loadFn(uid);
			if (val != null)
			{
				context.LoadedData[uid] = val;
				return val;
			}
		}
		return null;
	}

	protected void FillProperties(ClassMetadata md, LinkedObjectsContext context, FindLinkedObjectsResult resultObj)
	{
		int num = 5;
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					_003C_003Ec__DisplayClass10_.md = md;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					_003C_003Ec__DisplayClass10_.resultObj = resultObj;
					num2 = 3;
					continue;
				case 3:
					_003C_003Ec__DisplayClass10_.context = context;
					num2 = 2;
					continue;
				case 2:
					break;
				case 5:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
					num2 = 4;
					continue;
				case 1:
					_003C_003Ec__DisplayClass10_._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return;
				}
				break;
			}
			PropertyDependencyHelper.PropertiesProcessing(_003C_003Ec__DisplayClass10_.md, _003C_003Ec__DisplayClass10_.context.AllObjects).ForEach(_003C_003Ec__DisplayClass10_._003CFillProperties_003Eb__0);
			num = 6;
		}
	}

	protected void FillDependencies(Guid mdUid, LinkedObjectsContext context, FindLinkedObjectsResult resultObj)
	{
		int num = 4;
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					_003C_003Ec__DisplayClass11_.resultObj = resultObj;
					num2 = 6;
					continue;
				case 5:
					GetObjectsUidsFromDependencies(_003C_003Ec__DisplayClass11_.mdUid).ForEach(_003C_003Ec__DisplayClass11_._003CFillDependencies_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					break;
				case 4:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					_003C_003Ec__DisplayClass11_.context = context;
					num2 = 5;
					continue;
				case 3:
					_003C_003Ec__DisplayClass11_.mdUid = mdUid;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass11_._003C_003E4__this = this;
			num = 2;
		}
	}

	protected T FillMetadataProperties<T>(T metadata) where T : EntityMetadata
	{
		if (metadata == null)
		{
			return null;
		}
		metadata.Properties.AddRange((IEnumerable<PropertyMetadata>)metadata.EntityProperties);
		metadata.TableParts.AddRange((IEnumerable<TablePartMetadata>)metadata.EntityTableParts);
		return metadata;
	}

	private ICollection<Guid> GetObjectsUidsFromDependencies(Guid uid)
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals0.uid = uid;
		HashSet<Guid> hashSet = new HashSet<Guid>();
		foreach (IDependencyContainer item in DependenciesExtensions.SelectMany((IDependenciesExtension point) => point.GetDependencyContainers(CS_0024_003C_003E8__locals0.uid)))
		{
			if (item is MetadataDependencyContainer dependencies)
			{
				GetObjectsUidsFromDependencies(dependencies, hashSet);
			}
			if (item is ScriptModuleDependencyContainer dependencies2)
			{
				GetObjectsUidsFromDependencies(dependencies2, hashSet);
			}
			if (item is ComponentDependencyContainer dependencies3)
			{
				GetObjectsUidsFromDependencies(dependencies3, hashSet);
			}
		}
		hashSet.Remove(Guid.Empty);
		return hashSet;
	}

	private void GetObjectsUidsFromDependencies(MetadataDependencyContainer dependencies, ISet<Guid> result)
	{
		if (dependencies == null)
		{
			return;
		}
		GetObjectsUidsFromDependencies(dependencies.EntityDependencies, result);
		GetObjectsUidsFromDependencies(dependencies.EnumDependencies, result);
		GetObjectsUidsFromDependencies(dependencies.DataClassDependencies, result);
		GetObjectsUidsFromDependencies(dependencies.FunctionDependencies, result);
		if (dependencies.FormDependencies == null)
		{
			return;
		}
		foreach (FormViewItemDependencyContainer formDependency in dependencies.FormDependencies)
		{
			GetObjectsUidsFromDependencies(formDependency.EntityDependencies, result);
			GetObjectsUidsFromDependencies(formDependency.DataClassDependencies, result);
			GetObjectsUidsFromDependencies(formDependency.ComponentDependencies, result);
		}
	}

	private void GetObjectsUidsFromDependencies(ScriptModuleDependencyContainer dependencies, ISet<Guid> result)
	{
		if (dependencies != null)
		{
			GetObjectsUidsFromDependencies(dependencies.EntityDependencies, result);
			GetObjectsUidsFromDependencies(dependencies.DataClassDependencies, result);
		}
	}

	private void GetObjectsUidsFromDependencies(ComponentDependencyContainer dependencies, ISet<Guid> result)
	{
		if (dependencies != null)
		{
			GetObjectsUidsFromDependencies(dependencies.EntityDependencies, result);
			GetObjectsUidsFromDependencies(dependencies.EnumDependencies, result);
			GetObjectsUidsFromDependencies(dependencies.DataClassDependencies, result);
			GetObjectsUidsFromDependencies(dependencies.FunctionDependencies, result);
			GetHeadersUidsFromDependencies(dependencies.ComponentDependencies, result);
		}
	}

	private void GetObjectsUidsFromDependencies(ICollection<EntityDependency> entityDependencies, ISet<Guid> result)
	{
		_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0();
		CS_0024_003C_003E8__locals0.result = result;
		if (entityDependencies == null)
		{
			return;
		}
		foreach (EntityDependency entityDependency in entityDependencies)
		{
			if (entityDependency.HeaderUid != Guid.Empty)
			{
				Guid interfaceUid = GetInterfaceUid(entityDependency);
				CS_0024_003C_003E8__locals0.result.Add(interfaceUid);
			}
			if (entityDependency.Properties == null)
			{
				continue;
			}
			entityDependency.Properties.ForEach(delegate(PropertySignature property)
			{
				//Discarded unreachable code: IL_003a, IL_0049, IL_008a, IL_0099, IL_00aa
				int num = 4;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						object obj;
						switch (num2)
						{
						case 1:
							return;
						case 5:
							return;
						case 2:
							CS_0024_003C_003E8__locals0.result.Add(property.Type.SubTypeUid);
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
							{
								num2 = 0;
							}
							continue;
						default:
							obj = null;
							goto IL_00c9;
						case 4:
							if (property != null)
							{
								break;
							}
							goto default;
						case 3:
							{
								obj = property.Type;
								goto IL_00c9;
							}
							IL_00c9:
							if (obj == null)
							{
								num2 = 5;
								continue;
							}
							goto case 2;
						}
						break;
					}
					num = 3;
				}
			});
		}
	}

	private Guid GetInterfaceUid(EntityDependency dependency)
	{
		//Discarded unreachable code: IL_0101, IL_0133, IL_016f, IL_017e, IL_0198, IL_01a7, IL_01fa, IL_0209
		int num = 2;
		int num2 = num;
		EntityMetadataType entityMetadataType = default(EntityMetadataType);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IMetadata metadata = default(IMetadata);
		Guid empty = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 7:
				switch (entityMetadataType)
				{
				default:
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					goto end_IL_0012;
				case EntityMetadataType.InterfaceImplementation:
					break;
				case EntityMetadataType.Entity:
				case EntityMetadataType.Interface:
					return pkmBMafhLv1FFGPCaq8F(entityMetadata);
				case EntityMetadataType.InterfaceExtension:
					return ofWDEefhU97XNSRKFVUJ(entityMetadata);
				}
				goto case 5;
			case 5:
				return FiWwlIfhYJ4iOO0i5Fm4(entityMetadata);
			case 6:
				sruJdXfhcbGVwjoi6hVE(F372YYfhs7K4uptrmxyy(), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -868014334), kFaKksfhjyt1Xwqs7YUs(entityMetadata)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				try
				{
					metadata = ((IMetadataService)wdseOIfhgJorlXpuFjke()).GetMetadata(Fdm4Fafh5ihLvZf5um0b(dependency), loadImplementation: false);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							empty = Guid.Empty;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
							{
								num4 = 0;
							}
							break;
						default:
							return empty;
						case 0:
							return empty;
						}
					}
				}
				goto case 1;
			default:
				return Fdm4Fafh5ihLvZf5um0b(dependency);
			case 1:
				if ((entityMetadata = metadata as EntityMetadata) != null)
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 4:
				return Fdm4Fafh5ihLvZf5um0b(dependency);
			case 3:
				{
					entityMetadataType = kFaKksfhjyt1Xwqs7YUs(entityMetadata);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 1;
					}
					break;
				}
				end_IL_0012:
				break;
			}
		}
	}

	private void GetObjectsUidsFromDependencies(ICollection<EnumDependency> enumDependencies, ISet<Guid> result)
	{
		if (enumDependencies == null)
		{
			return;
		}
		foreach (EnumDependency enumDependency in enumDependencies)
		{
			result.Add(enumDependency.HeaderUid);
		}
	}

	private void GetObjectsUidsFromDependencies(ICollection<DataClassDependency> dataClassDependencies, ISet<Guid> result)
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals0.result = result;
		if (dataClassDependencies == null)
		{
			return;
		}
		foreach (DataClassDependency dataClassDependency in dataClassDependencies)
		{
			CS_0024_003C_003E8__locals0.result.Add(dataClassDependency.HeaderUid);
			if (dataClassDependency.Properties == null)
			{
				continue;
			}
			dataClassDependency.Properties.ForEach(delegate(PropertySignature property)
			{
				//Discarded unreachable code: IL_0035, IL_0044, IL_0055
				int num = 1;
				int num2 = num;
				while (true)
				{
					object obj;
					switch (num2)
					{
					case 4:
						obj = null;
						break;
					case 1:
						if (property != null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 4;
					case 3:
						CS_0024_003C_003E8__locals0.result.Add(property.Type.SubTypeUid);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num2 = 2;
						}
						continue;
					case 2:
						return;
					default:
						obj = property.Type;
						break;
					}
					if (obj == null)
					{
						break;
					}
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
				}
			});
		}
	}

	private void GetObjectsUidsFromDependencies(ICollection<ComponentDependency> componentDependencies, ISet<Guid> result)
	{
		_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21_0();
		CS_0024_003C_003E8__locals0.result = result;
		if (componentDependencies == null)
		{
			return;
		}
		foreach (ComponentDependency componentDependency in componentDependencies)
		{
			CS_0024_003C_003E8__locals0.result.Add(componentDependency.HeaderUid);
			if (componentDependency.Inputs == null)
			{
				continue;
			}
			componentDependency.Inputs.ForEach(delegate(InputComputedValue input)
			{
				//Discarded unreachable code: IL_0031, IL_0040
				int num = 3;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						return;
					default:
						CS_0024_003C_003E8__locals0.result.Add(_003C_003Ec__DisplayClass21_0.jI1aPA8diOa0cE4fqarl(input));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						return;
					case 3:
						if (input == null)
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num2 = 2;
							}
							break;
						}
						goto default;
					}
				}
			});
		}
	}

	private void GetHeadersUidsFromDependencies(ICollection<ComponentDependency> componentDependencies, ISet<Guid> result)
	{
		if (componentDependencies == null)
		{
			return;
		}
		foreach (ComponentDependency componentDependency in componentDependencies)
		{
			result.Add(componentDependency.HeaderUid);
		}
	}

	private void GetObjectsUidsFromDependencies(ICollection<FunctionDependency> functionDependencies, ISet<Guid> result)
	{
		if (functionDependencies == null)
		{
			return;
		}
		foreach (FunctionDependency functionDependency in functionDependencies)
		{
			result.Add(functionDependency.HeaderUid);
			if (functionDependency != null && (functionDependency.ParameterType?.SubTypeUid).HasValue)
			{
				result.Add(functionDependency.ParameterType.SubTypeUid);
			}
			if (functionDependency != null && (functionDependency.ReturnType?.SubTypeUid).HasValue)
			{
				result.Add(functionDependency.ReturnType.SubTypeUid);
			}
		}
	}

	protected LinkedFinderBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		p6DUv3fhzXCNhla6iw8W();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool kEDFFYfhlhXS9XwrHjff()
	{
		return X2syZyfhd5ceA4UetVZ2 == null;
	}

	internal static LinkedFinderBase C0UbQQfhrQu5trNcEmmc()
	{
		return X2syZyfhd5ceA4UetVZ2;
	}

	internal static object wdseOIfhgJorlXpuFjke()
	{
		return MetadataServiceContext.Service;
	}

	internal static Guid Fdm4Fafh5ihLvZf5um0b(object P_0)
	{
		return ((Dependency)P_0).HeaderUid;
	}

	internal static EntityMetadataType kFaKksfhjyt1Xwqs7YUs(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid FiWwlIfhYJ4iOO0i5Fm4(object P_0)
	{
		return ((EntityMetadata)P_0).ImplementationUid;
	}

	internal static Guid pkmBMafhLv1FFGPCaq8F(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Guid ofWDEefhU97XNSRKFVUJ(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static object F372YYfhs7K4uptrmxyy()
	{
		return Logger.Log;
	}

	internal static void sruJdXfhcbGVwjoi6hVE(object P_0, object P_1)
	{
		((ILogger)P_0).Warn(P_1);
	}

	internal static void p6DUv3fhzXCNhla6iw8W()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
