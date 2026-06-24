using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Iesi.Collections;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities;

public class TablePartChangesModel
{
	private static IEnumerable<IOriginalCollectionExtension> originalCollectionExtension;

	private static ISecurityService securityService;

	[NonSerialized]
	[ScriptIgnore]
	[JsonIgnore]
	[XmlIgnore]
	private List<IEntity> _addedEntities;

	[NonSerialized]
	[ScriptIgnore]
	[JsonIgnore]
	[XmlIgnore]
	private List<IEntity> _changedEntities;

	[NonSerialized]
	[XmlIgnore]
	[JsonIgnore]
	[ScriptIgnore]
	private List<IEntity> _deletedEntities;

	internal static TablePartChangesModel zeIO6PhZf2fy1xxZoT96;

	private static IEnumerable<IOriginalCollectionExtension> OriginalCollectionExtension => originalCollectionExtension ?? (originalCollectionExtension = ComponentManager.Current.GetExtensionPoints<IOriginalCollectionExtension>());

	private static ISecurityService SecurityService
	{
		get
		{
			int num = 1;
			int num2 = num;
			ISecurityService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = securityService;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (securityService = Locator.GetServiceNotNull<ISecurityService>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	public List<IDictionary<string, object>> Added { get; set; }

	public List<IDictionary<string, object>> Changed { get; set; }

	public List<string> Deleted { get; set; }

	public string Transformation
	{
		get
		{
			return ViewItemTransformation.SerializeToJson();
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					ViewItemTransformation = ((!VapOMMhZRAgQjVAOrt1v(value)) ? ViewItemTransformation.DeserializeFromJson(value) : null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int? TotalCount { get; set; }

	[JsonIgnore]
	[ScriptIgnore]
	[XmlIgnore]
	public IEnumerable<IEntity> AddedEntities => _addedEntities;

	[XmlIgnore]
	[JsonIgnore]
	[ScriptIgnore]
	public IEnumerable<IEntity> ChangedEntities => _changedEntities;

	[XmlIgnore]
	[ScriptIgnore]
	[JsonIgnore]
	public IEnumerable<IEntity> DeletedEntities => _deletedEntities;

	[JsonIgnore]
	[XmlIgnore]
	[ScriptIgnore]
	public ViewItemTransformation ViewItemTransformation
	{
		[CompilerGenerated]
		get
		{
			return _003CViewItemTransformation_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CViewItemTransformation_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TablePartChangesModel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				Added = new List<IDictionary<string, object>>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				Changed = new List<IDictionary<string, object>>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num = 0;
				}
				break;
			default:
				Deleted = new List<string>();
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num = 2;
				}
				break;
			case 3:
				return;
			}
		}
	}

	public TablePartChangesModel(IEnumerable items, IEnumerable originalItems)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		mn84yfhZvo3ntpDjEj2B();
		this._002Ector(items, originalItems, null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TablePartChangesModel(IEnumerable items, IEnumerable originalItems, ViewItemTransformation viewItemTransformation)
	{
		//Discarded unreachable code: IL_0043, IL_00f3, IL_0113, IL_0122, IL_012d, IL_01f6, IL_0215, IL_0241, IL_0250, IL_02e5, IL_02f4, IL_03b6, IL_03c5, IL_046a, IL_049c, IL_04e9, IL_04f8, IL_0548, IL_0557, IL_0592
		SingletonReader.JJCZtPuTvSt();
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0.originalItems = originalItems;
		this._002Ector();
		int num = 12;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
		{
			num = 7;
		}
		IOriginalCollectionExtension originalCollectionExtension = default(IOriginalCollectionExtension);
		IEnumerator<IEntity> enumerator = default(IEnumerator<IEntity>);
		IEntity current = default(IEntity);
		IEnumerator enumerator2 = default(IEnumerator);
		IEnumerable enumerable = default(IEnumerable);
		EntitySerializationSettings settings = default(EntitySerializationSettings);
		IEntity entity = default(IEntity);
		_003C_003Ec__DisplayClass8_1 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_1);
		while (true)
		{
			object obj;
			switch (num)
			{
			case 4:
				if (originalCollectionExtension == null)
				{
					num = 3;
					break;
				}
				obj = JVgsi8hZinOB3L1F3oba(originalCollectionExtension, CS_0024_003C_003E8__locals0.originalItems);
				goto IL_05f2;
			case 5:
			case 19:
			{
				TotalCount = items.Cast<object>().Count();
				int num2 = 13;
				num = num2;
				break;
			}
			case 3:
				obj = CS_0024_003C_003E8__locals0.originalItems;
				goto IL_05f2;
			case 20:
				_deletedEntities = new List<IEntity>();
				num = 21;
				break;
			case 7:
				try
				{
					while (true)
					{
						int num6;
						if (!enumerator.MoveNext())
						{
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
							{
								num6 = 0;
							}
							goto IL_0131;
						}
						goto IL_0196;
						IL_0196:
						current = enumerator.Current;
						num6 = 2;
						goto IL_0131;
						IL_0131:
						while (true)
						{
							switch (num6)
							{
							case 3:
								break;
							case 2:
								Deleted.Add(Mroko9hZV2k6FxbC5Ya3(current).ToString());
								num6 = 4;
								continue;
							default:
								goto IL_0196;
							case 4:
								_deletedEntities.Add(current);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
								{
									num6 = 3;
								}
								continue;
							case 1:
								goto end_IL_014f;
							}
							break;
						}
						continue;
						end_IL_014f:
						break;
					}
				}
				finally
				{
					int num7;
					if (enumerator == null)
					{
						num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num7 = 1;
						}
						goto IL_01fa;
					}
					goto IL_021f;
					IL_021f:
					enumerator.Dispose();
					num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num7 = 0;
					}
					goto IL_01fa;
					IL_01fa:
					switch (num7)
					{
					default:
						goto end_IL_01d5;
					case 1:
						goto end_IL_01d5;
					case 2:
						break;
					case 0:
						goto end_IL_01d5;
					}
					goto IL_021f;
					end_IL_01d5:;
				}
				goto case 5;
			case 6:
				_changedEntities = new List<IEntity>();
				num = 20;
				break;
			case 17:
				enumerator2 = (IEnumerator)DQ6Qu7hZZvB0iuEcFA6j(items);
				num = 9;
				break;
			case 14:
				originalCollectionExtension = OriginalCollectionExtension.FirstOrDefault((IOriginalCollectionExtension ext) => _003C_003Ec__DisplayClass8_0.V6SbvWCc8DDCUkImVWdP(ext, CS_0024_003C_003E8__locals0.originalItems));
				num = 4;
				break;
			case 18:
				if (enumerable != null)
				{
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num = 1;
					}
					break;
				}
				goto case 2;
			case 13:
				return;
			default:
			{
				EntitySerializationSettings entitySerializationSettings = new EntitySerializationSettings();
				ixsdJVhZ8pmr7GTNKW4I(entitySerializationSettings, EntitySerializationMode.ChangesOnly);
				settings = entitySerializationSettings;
				num = 17;
				break;
			}
			case 9:
				try
				{
					while (true)
					{
						IL_043f:
						int num3;
						if (!enumerator2.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
							{
								num3 = 0;
							}
							goto IL_0303;
						}
						goto IL_035a;
						IL_035a:
						entity = (IEntity)QY6WOphZuyYYiMxhle5w(enumerator2);
						num3 = 6;
						goto IL_0303;
						IL_0303:
						while (true)
						{
							switch (num3)
							{
							case 4:
							case 10:
								_003C_003Ec__DisplayClass8_.currentIds.Add(Mroko9hZV2k6FxbC5Ya3(entity));
								num3 = 3;
								continue;
							case 5:
								goto IL_035a;
							case 2:
								_addedEntities.Add(entity);
								num3 = 4;
								continue;
							case 11:
								Changed.Add((IDictionary<string, object>)new EntityJsonSerializer().ConvertToSerializable(entity, settings));
								num3 = 8;
								continue;
							case 1:
								Added.Add((IDictionary<string, object>)new EntityJsonSerializer().ConvertToSerializable(entity, settings));
								num3 = 2;
								continue;
							case 7:
							case 9:
								if (UKUWAVhZIP0LSHjyMjk8(entity))
								{
									num3 = 11;
									continue;
								}
								goto case 4;
							case 6:
								if (!entity.IsNew())
								{
									num3 = 7;
									continue;
								}
								goto case 1;
							case 8:
							{
								_changedEntities.Add(entity);
								int num4 = 10;
								num3 = num4;
								continue;
							}
							case 3:
								goto IL_043f;
							case 0:
								break;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					IDisposable disposable = enumerator2 as IDisposable;
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 2:
							oZGWOVhZS8ULWGREWDbx(disposable);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
							{
								num5 = 0;
							}
							continue;
						default:
							if (disposable != null)
							{
								num5 = 2;
								continue;
							}
							break;
						case 1:
							break;
						}
						break;
					}
				}
				goto case 22;
			case 11:
				ViewItemTransformation = viewItemTransformation;
				num = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num = 3;
				}
				break;
			case 21:
				if (items != null)
				{
					num = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num = 16;
					}
					break;
				}
				return;
			case 10:
				_addedEntities = new List<IEntity>();
				num = 6;
				break;
			case 22:
				if (CS_0024_003C_003E8__locals0.originalItems == null)
				{
					num = 19;
					break;
				}
				goto case 14;
			case 12:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_1();
				num = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 9;
				}
				break;
			case 8:
				return;
			case 16:
				_003C_003Ec__DisplayClass8_.currentIds = new List<object>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				enumerable = (from e in items.OfType<IEntity>()
					where !e.IsNew()
					select e).ToList();
				num = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num = 15;
				}
				break;
			case 1:
			case 15:
				{
					enumerator = enumerable.OfType<IEntity>().Where(_003C_003Ec__DisplayClass8_._003C_002Ector_003Eb__2).GetEnumerator();
					num = 7;
					break;
				}
				IL_05f2:
				enumerable = (IEnumerable)obj;
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num = 18;
				}
				break;
			}
		}
	}

	public void Apply(ISet items, Type itemType, Func<IEntity, bool> needBindProperties = null)
	{
		Apply(items, itemType, needRemoveOldItems: false, needBindProperties);
	}

	public IEnumerable ApplyImmutable(IEnumerable items, Type itemType, Func<IEntity, bool> needBindProperties = null)
	{
		HashedSet<IEntity> val = ((items != null) ? new HashedSet<IEntity>(items.Cast<IEntity>()) : new HashedSet<IEntity>());
		Apply((ISet)(object)val, itemType, needRemoveOldItems: false, needBindProperties);
		return (IEnumerable)val;
	}

	public void Apply(ISet items, Type itemType, bool needRemoveOldItems, Func<IEntity, bool> needBindProperties = null)
	{
		_003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass40_0();
		if (items == null || itemType == null)
		{
			return;
		}
		Dictionary<object, IEntity> dictionary = (from e in ((IEnumerable)items).OfType<IEntity>()
			select new
			{
				id = e.GetId(),
				entity = e
			} into i
			where !i.entity.GetType().IsDefaultId(i.id.GetType(), i.id)
			select i).ToDictionary(i => i.id, i => i.entity);
		CS_0024_003C_003E8__locals0.uidProp = itemType.GetReflectionProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411205569));
		Dictionary<object, IEntity> itemsByUid = ((CS_0024_003C_003E8__locals0.uidProp != null) ? (from i in ((IEnumerable)items).OfType<IEntity>()
			where _003C_003Ec.ync4OCCcOV0iaatv3Z0y(i.GetType(), i.GetId().GetType(), _003C_003Ec.phX5rsCcnEpiKGDvd35i(i))
			select i into k
			group k by _003C_003Ec__DisplayClass40_0.XqppaCCc1CIyTbV56S3N(CS_0024_003C_003E8__locals0.uidProp, k, null) into p
			where p.Count() == 1
			select p).ToDictionary((IGrouping<object, IEntity> p) => p.Key, (IGrouping<object, IEntity> p) => p.First()) : null);
		CS_0024_003C_003E8__locals0.neededItemIds = new List<object>();
		foreach (IDictionary<string, object> item in Added)
		{
			IEntity entity = DeserializeEntity(items, null, itemsByUid, itemType, needBindProperties, item, canCreateNew: true);
			if (entity != null)
			{
				CS_0024_003C_003E8__locals0.neededItemIds.Add(entity.GetId());
			}
		}
		foreach (IDictionary<string, object> item2 in Changed)
		{
			IEntity entity2 = DeserializeEntity(items, dictionary, null, itemType, needBindProperties, item2, canCreateNew: false);
			if (entity2 != null)
			{
				CS_0024_003C_003E8__locals0.neededItemIds.Add(entity2.GetId());
			}
		}
		foreach (string item3 in Deleted)
		{
			object obj = ModelHelper.TryConvertEntityId(itemType, item3);
			if (obj != null && dictionary.TryGetValue(obj, out var value))
			{
				items.Remove((object)value);
				if (MetadataLoader.LoadMetadata(value.GetType()) is ITablePartMetadata tablePartMetadata && tablePartMetadata.ParentPropertyUid != Guid.Empty)
				{
					value.SetPropertyValue(tablePartMetadata.ParentPropertyUid, null);
				}
			}
		}
		if (!needRemoveOldItems)
		{
			return;
		}
		foreach (IEntity item4 in ((IEnumerable)items).OfType<IEntity>().Where(delegate(IEntity i)
		{
			int num = 1;
			int num2 = num;
			_003C_003Ec__DisplayClass40_1 _003C_003Ec__DisplayClass40_ = default(_003C_003Ec__DisplayClass40_1);
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (!_003C_003Ec__DisplayClass40_0.J5XBeeCcNqDSmUOSirlb(_003C_003Ec__DisplayClass40_.i))
					{
						return false;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass40_ = new _003C_003Ec__DisplayClass40_1();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					_003C_003Ec__DisplayClass40_.i = i;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					return !CS_0024_003C_003E8__locals0.neededItemIds.Any(_003C_003Ec__DisplayClass40_._003CApply_003Eb__10);
				}
			}
		}).ToList())
		{
			items.Remove((object)item4);
		}
	}

	public IDictionary<string, object> ToDictionary()
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (TotalCount.HasValue)
		{
			dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFDBA08)] = TotalCount.Value;
		}
		if (Added.Count > 0)
		{
			dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099571411)] = Added;
		}
		if (Changed.Count > 0)
		{
			dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334911353)] = Changed;
		}
		if (Deleted.Count > 0)
		{
			dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7C7088)] = Deleted;
		}
		if (ViewItemTransformation != null)
		{
			dictionary[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A74D51B)] = ViewItemTransformation.SerializeToJson();
		}
		return dictionary;
	}

	public static TablePartChangesModel FromDictionary(IDictionary<string, object> dict)
	{
		_003C_003Ec__DisplayClass42_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass42_0();
		CS_0024_003C_003E8__locals0.dict = dict;
		TablePartChangesModel tablePartChangesModel = new TablePartChangesModel();
		if (CS_0024_003C_003E8__locals0.dict != null)
		{
			Action<string, IList> obj = delegate(string key, IList resultList)
			{
				//Discarded unreachable code: IL_0094, IL_00a3, IL_00ae, IL_0160, IL_01c5, IL_01d4, IL_01e0, IL_01ef
				int num = 3;
				object value2 = default(object);
				IEnumerator enumerator = default(IEnumerator);
				IEnumerable enumerable = default(IEnumerable);
				object obj2 = default(object);
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 3:
							if (!CS_0024_003C_003E8__locals0.dict.TryGetValue(key, out value2))
							{
								return;
							}
							goto end_IL_0012;
						default:
							enumerator = (IEnumerator)_003C_003Ec__DisplayClass42_0.EHpTrxCcA7eovpOe6iTa(enumerable);
							num2 = 4;
							break;
						case 1:
							return;
						case 2:
							if ((enumerable = value2 as IEnumerable) == null)
							{
								return;
							}
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
							{
								num2 = 0;
							}
							break;
						case 4:
							try
							{
								while (true)
								{
									IL_0112:
									int num3;
									if (!_003C_003Ec__DisplayClass42_0.paorGMCc0V2mWSElcrhU(enumerator))
									{
										num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
										{
											num3 = 1;
										}
										goto IL_00b2;
									}
									goto IL_00ef;
									IL_00ef:
									obj2 = _003C_003Ec__DisplayClass42_0.yoNWx8Cc7tjVaRo11edV(enumerator);
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
									{
										num3 = 2;
									}
									goto IL_00b2;
									IL_00b2:
									while (true)
									{
										switch (num3)
										{
										case 1:
											return;
										case 2:
											_003C_003Ec__DisplayClass42_0.sUg4JQCcxQ7ck2Ni7UGt(resultList, obj2);
											num3 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
											{
												num3 = 1;
											}
											continue;
										case 3:
											goto IL_0112;
										}
										break;
									}
									goto IL_00ef;
								}
							}
							finally
							{
								IDisposable disposable = enumerator as IDisposable;
								int num4 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
								{
									num4 = 3;
								}
								while (true)
								{
									switch (num4)
									{
									case 3:
										if (disposable == null)
										{
											num4 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
											{
												num4 = 0;
											}
											continue;
										}
										break;
									case 2:
										goto end_IL_0164;
									case 1:
										goto end_IL_0164;
									}
									_003C_003Ec__DisplayClass42_0.C8X9b4CcmY5lMq3vHrKk(disposable);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
									{
										num4 = 1;
									}
									continue;
									end_IL_0164:
									break;
								}
							}
						}
						continue;
						end_IL_0012:
						break;
					}
					num = 2;
				}
			};
			obj(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -282054974), tablePartChangesModel.Added);
			obj(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72444002), tablePartChangesModel.Changed);
			obj(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859067077), tablePartChangesModel.Deleted);
			if (CS_0024_003C_003E8__locals0.dict.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217571947), out var value) && value is string)
			{
				tablePartChangesModel.ViewItemTransformation = ((!string.IsNullOrEmpty((string)value)) ? ViewItemTransformation.DeserializeFromJson((string)value) : null);
			}
		}
		return tablePartChangesModel;
	}

	public string ToJson()
	{
		return new JsonSerializer().Serialize(ToDictionary());
	}

	private IEntity DeserializeEntity(ISet items, Dictionary<object, IEntity> itemsById, Dictionary<object, IEntity> itemsByUid, Type itemType, Func<IEntity, bool> needBindProperties, IDictionary<string, object> expItem, bool canCreateNew)
	{
		_003C_003Ec__DisplayClass47_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass47_0();
		CS_0024_003C_003E8__locals0.needBindProperties = needBindProperties;
		CS_0024_003C_003E8__locals0.itemType = itemType;
		CS_0024_003C_003E8__locals0.itemsById = itemsById;
		CS_0024_003C_003E8__locals0.expItem = expItem;
		CS_0024_003C_003E8__locals0.itemsByUid = itemsByUid;
		CS_0024_003C_003E8__locals0.canCreateNew = canCreateNew;
		CS_0024_003C_003E8__locals0.items = items;
		if (!CS_0024_003C_003E8__locals0.expItem.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x4264B35D), out CS_0024_003C_003E8__locals0.idObj))
		{
			return null;
		}
		CS_0024_003C_003E8__locals0.entity = null;
		SecurityService.RunWithElevatedPrivilegiesAndWithDeleted(delegate
		{
			//Discarded unreachable code: IL_00e4, IL_00f3, IL_011b, IL_012a, IL_0139, IL_0148, IL_0185, IL_0242
			int num = 1;
			EntityJsonSerializer entityJsonSerializer = default(EntityJsonSerializer);
			object obj = default(object);
			object key = default(object);
			object value = default(object);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 11:
						entityJsonSerializer.ConvertFromSerializable(CS_0024_003C_003E8__locals0.entity, CS_0024_003C_003E8__locals0.expItem);
						num2 = 10;
						continue;
					case 20:
						if (CS_0024_003C_003E8__locals0.itemsById.TryGetValue(obj, out CS_0024_003C_003E8__locals0.entity))
						{
							num = 11;
							break;
						}
						goto case 15;
					case 4:
						return;
					case 9:
					case 19:
						if (!CS_0024_003C_003E8__locals0.canCreateNew)
						{
							num2 = 8;
							continue;
						}
						goto case 23;
					case 16:
						return;
					case 3:
						if (CS_0024_003C_003E8__locals0.itemsById == null)
						{
							num2 = 15;
							continue;
						}
						goto case 20;
					case 6:
						return;
					default:
						obj = _003C_003Ec__DisplayClass47_0.R0PMGICcd36Mc5whLA2r(CS_0024_003C_003E8__locals0.itemType, CS_0024_003C_003E8__locals0.idObj);
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
						{
							num2 = 2;
						}
						continue;
					case 8:
						return;
					case 5:
						obj = _003C_003Ec__DisplayClass47_0.yo3DI8Cc52rm3eS01nmm(CS_0024_003C_003E8__locals0.entity);
						num = 24;
						break;
					case 25:
						CS_0024_003C_003E8__locals0.items.Add((object)CS_0024_003C_003E8__locals0.entity);
						num2 = 12;
						continue;
					case 10:
						return;
					case 15:
					case 21:
						if (CS_0024_003C_003E8__locals0.itemsByUid != null)
						{
							num2 = 13;
							continue;
						}
						goto case 9;
					case 12:
						return;
					case 7:
						if (!CS_0024_003C_003E8__locals0.itemsByUid.TryGetValue(key, out CS_0024_003C_003E8__locals0.entity))
						{
							num = 19;
							break;
						}
						goto case 5;
					case 2:
						if (obj == null)
						{
							num2 = 14;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
							{
								num2 = 21;
							}
							continue;
						}
						goto case 3;
					case 22:
						if (CS_0024_003C_003E8__locals0.entity == null)
						{
							num2 = 6;
							continue;
						}
						goto case 14;
					case 1:
						entityJsonSerializer = new EntityJsonSerializer
						{
							NeedBindProperties = CS_0024_003C_003E8__locals0.needBindProperties
						};
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
						{
							num2 = 0;
						}
						continue;
					case 23:
						CS_0024_003C_003E8__locals0.entity = (IEntity)entityJsonSerializer.ConvertFromSerializable(CS_0024_003C_003E8__locals0.expItem, CS_0024_003C_003E8__locals0.itemType);
						num2 = 22;
						continue;
					case 17:
						if ((key = _003C_003Ec__DisplayClass47_0.gnlXXbCcgDWh87opucW0(Locator.GetServiceNotNull<GuidDescriptor>(), value, _003C_003Ec__DisplayClass47_0.QHwDZ8Ccrl0q9UcgsEiL(typeof(Guid).TypeHandle))) != null)
						{
							num2 = 7;
							continue;
						}
						goto case 9;
					case 18:
						CS_0024_003C_003E8__locals0.entity.SetId(obj);
						num2 = 4;
						continue;
					case 13:
						if (!CS_0024_003C_003E8__locals0.expItem.TryGetValue((string)_003C_003Ec__DisplayClass47_0.D0f5YXCcl7fR41CQ7Mf5(0x49E27B8A ^ 0x49E21418), out value))
						{
							num2 = 9;
							continue;
						}
						goto case 17;
					case 24:
						entityJsonSerializer.ConvertFromSerializable(CS_0024_003C_003E8__locals0.entity, CS_0024_003C_003E8__locals0.expItem);
						num2 = 18;
						continue;
					case 14:
						if (!((IEnumerable)CS_0024_003C_003E8__locals0.items).OfType<IEntity>().All((IEntity i) => !i.Equals(CS_0024_003C_003E8__locals0.entity)))
						{
							num = 16;
							break;
						}
						goto case 25;
					}
					break;
				}
			}
		});
		return CS_0024_003C_003E8__locals0.entity;
	}

	internal static bool u1Ei9khZQLsNgMj9y4MU()
	{
		return zeIO6PhZf2fy1xxZoT96 == null;
	}

	internal static TablePartChangesModel cO179EhZC5oEdTms5hIB()
	{
		return zeIO6PhZf2fy1xxZoT96;
	}

	internal static void mn84yfhZvo3ntpDjEj2B()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void ixsdJVhZ8pmr7GTNKW4I(object P_0, EntitySerializationMode value)
	{
		((EntitySerializationSettings)P_0).Mode = value;
	}

	internal static object DQ6Qu7hZZvB0iuEcFA6j(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object QY6WOphZuyYYiMxhle5w(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static bool UKUWAVhZIP0LSHjyMjk8(object P_0)
	{
		return ((IEntity)P_0).IsDirty();
	}

	internal static object Mroko9hZV2k6FxbC5Ya3(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void oZGWOVhZS8ULWGREWDbx(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object JVgsi8hZinOB3L1F3oba(object P_0, object P_1)
	{
		return ((IOriginalCollectionExtension)P_0).OriginalItems(P_1);
	}

	internal static bool VapOMMhZRAgQjVAOrt1v(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
