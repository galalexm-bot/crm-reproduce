using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Managers;

internal class ComponentMetadataItemHeaderManager : EntityManager<ComponentMetadataItemHeader, long>, IComponentMetadataItemHeaderManager, IEntityManager<ComponentMetadataItemHeader, long>, IEntityManager<ComponentMetadataItemHeader>, IEntityManager
{
	internal static class _Resources_PropertyNames
	{
		public static readonly string Id;

		public static readonly string Uid;

		public static readonly string Name;

		public static readonly string DisplayName;

		public static readonly string MetadataTypeUid;

		public static readonly string Published;

		public static readonly string Draft;

		internal static _Resources_PropertyNames OIAytpQbAwsauIKAFyKk;

		static _Resources_PropertyNames()
		{
			int num = 6;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 5:
					Id = (string)LILyqdQbm0br1TuAWLLZ(-1459557599 ^ -1459590529);
					num2 = 7;
					break;
				case 2:
					MetadataTypeUid = (string)LILyqdQbm0br1TuAWLLZ(0x3CE17B75 ^ 0x3CE41097);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 1;
					}
					break;
				case 7:
					Uid = (string)LILyqdQbm0br1TuAWLLZ(0x57A5235E ^ 0x57A54CCC);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 0;
					}
					break;
				case 8:
					DisplayName = (string)LILyqdQbm0br1TuAWLLZ(0x3B36AB09 ^ 0x3B345DBD);
					num2 = 2;
					break;
				case 1:
					Published = (string)LILyqdQbm0br1TuAWLLZ(-70007027 ^ -70141545);
					num2 = 4;
					break;
				default:
					Name = (string)LILyqdQbm0br1TuAWLLZ(-978351861 ^ -978322741);
					num2 = 8;
					break;
				case 6:
					QisjySQb05Tf3rTyoPBg();
					num2 = 5;
					break;
				case 4:
					Draft = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x63803817);
					num2 = 3;
					break;
				}
			}
		}

		internal static void QisjySQb05Tf3rTyoPBg()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object LILyqdQbm0br1TuAWLLZ(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static bool F5xlOJQb7bVceR48HoZH()
		{
			return OIAytpQbAwsauIKAFyKk == null;
		}

		internal static _Resources_PropertyNames bCPH0ZQbxP0odnC6NTc3()
		{
			return OIAytpQbAwsauIKAFyKk;
		}
	}

	private static readonly Dictionary<Guid, ComponentMetadataItemHeader> SystemComponents;

	private static ComponentMetadataItemHeaderManager EYHJlfBflFZgVwpHWPbw;

	public new static ComponentMetadataItemHeaderManager Instance => Locator.GetServiceNotNull<ComponentMetadataItemHeaderManager>();

	public override ComponentMetadataItemHeader Load(Guid uid)
	{
		//Discarded unreachable code: IL_0064, IL_0073
		int num = 2;
		int num2 = num;
		ComponentMetadataItemHeader value = default(ComponentMetadataItemHeader);
		while (true)
		{
			switch (num2)
			{
			default:
				return base.Load(uid);
			case 1:
				return value;
			case 2:
				if (SystemComponents.TryGetValue(uid, out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public override ComponentMetadataItemHeader LoadOrNull(Guid uid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				if (!SystemComponents.TryGetValue(uid, out var value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return value;
			}
			default:
				return base.LoadOrNull(uid);
			}
		}
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0076, IL_00a1, IL_00b0, IL_0124
		int num = 1;
		int num2 = num;
		bool? isPublished = default(bool?);
		ComponentMetadataItemHeaderFilter componentMetadataItemHeaderFilter = default(ComponentMetadataItemHeaderFilter);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 10:
				return;
			case 7:
				isPublished = componentMetadataItemHeaderFilter.IsPublished;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 5;
				}
				break;
			case 9:
				if (componentMetadataItemHeaderFilter == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 10;
					}
					break;
				}
				isPublished = componentMetadataItemHeaderFilter.IsPublished;
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 11;
				}
				break;
			case 1:
				b5XHKWBf5bWdvipJGD00(this, criteria, filter);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				USvYVLBfYINXdeyh25s7(criteria, yXLoUoBfjv0xkkPYDP90(_Resources_PropertyNames.Published));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				if (!isPublished.Value)
				{
					num2 = 4;
					break;
				}
				goto case 8;
			case 2:
				return;
			default:
				componentMetadataItemHeaderFilter = filter as ComponentMetadataItemHeaderFilter;
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 9;
				}
				break;
			case 6:
				return;
			case 4:
				criteria.Add((ICriterion)(object)Restrictions.IsNull(_Resources_PropertyNames.Published));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 2;
				}
				break;
			case 11:
				if (!isPublished.HasValue)
				{
					return;
				}
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 7;
				}
				break;
			}
		}
	}

	public override void Delete(ComponentMetadataItemHeader obj)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (CuNCKDBfL7oOjRHBB79p(obj) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 1;
					}
					break;
				}
				base.Delete(obj);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				throw new InvalidOperationException(SR.T((string)dmwtb8BfU3qZn7oh2BkQ(-951514650 ^ -951453250)));
			}
		}
	}

	public virtual long GetPublishingVersionNumber(long headerId)
	{
		//Discarded unreachable code: IL_004f, IL_005e
		int num = 3;
		object obj = default(object);
		string text = default(string);
		ITransformationProvider service = default(ITransformationProvider);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return 1L;
				case 6:
					if (obj != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto default;
				case 4:
					obj = QHU0SuBQFP7xEyiT19pU(((IQuery)q5EX2EBfzf19DWbOHvBX(base.Session, text)).CleanUpCache(cleanUpCache: false));
					num2 = 6;
					continue;
				case 7:
					return 1L;
				case 2:
					service = Locator.GetService<ITransformationProvider>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 5;
					}
					continue;
				case 3:
					if (headerId > 0)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 7;
				case 1:
					if (!(obj is DBNull))
					{
						return Convert.ToInt64(obj) + 1;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					text = (string)tmO7GvBfc8EE1935DZHR(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x47854CAB), (service != null) ? ((Dialect)zGNhc3Bfsqn7MNRQxpD9(service)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876084195)) : dmwtb8BfU3qZn7oh2BkQ(0x12A5FAC7 ^ 0x12A54C75), headerId);
					num = 4;
					break;
				}
				break;
			}
		}
	}

	public IEnumerable<ComponentMetadataItemHeader> GetAllPublished()
	{
		return CreateCriteria(FetchOptions.All, base.ImplementationType).Add((ICriterion)(object)Restrictions.IsNotNull(_Resources_PropertyNames.Published)).List<ComponentMetadataItemHeader>();
	}

	public IEnumerable<ComponentMetadataItemHeader> GetAllDrafts()
	{
		return CreateCriteria(FetchOptions.All, base.ImplementationType).Add((ICriterion)(object)Restrictions.IsNotNull(_Resources_PropertyNames.Draft)).List<ComponentMetadataItemHeader>();
	}

	[Transaction]
	public virtual void Delete(long headerId)
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
				qIesnQBQBvmie0b048ii(Load(headerId));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual bool ValidateName(Guid headerUid, string name, out string errorMessage)
	{
		return ValidateName((ICriterion)(object)Restrictions.Eq(_Resources_PropertyNames.Uid, (object)headerUid), name, out errorMessage);
	}

	public virtual bool ValidateDisplayName(Guid headerUid, string displayName, out string errorMessage)
	{
		return ValidateDisplayName((ICriterion)bZdle1BQW4MVox9OQvyy(_Resources_PropertyNames.Uid, headerUid), displayName, out errorMessage);
	}

	public ComponentMetadataItemHeader Edit(Guid uid, Guid groupUid)
	{
		int num = 1;
		int num2 = num;
		ComponentMetadataItemHeader componentMetadataItemHeader = default(ComponentMetadataItemHeader);
		while (true)
		{
			switch (num2)
			{
			case 1:
				componentMetadataItemHeader = Load(uid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return componentMetadataItemHeader;
			default:
				zwBUvNBQbT9n7qEbKq4i(componentMetadataItemHeader, ((AbstractNHEntityManager<MetadataItemGroupUI, long>)yF0ngIBQoPNsLgCWZfrC()).LoadOrNull(groupUid));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				Save(componentMetadataItemHeader);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public IEnumerable<ComponentMetadataItemHeader> SortByDependencies(IEnumerable<ComponentMetadataItemHeader> headers)
	{
		_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
		List<Guid> list = new List<Guid>();
		HashSet<Guid> hashSet = new HashSet<Guid>();
		List<Guid> other = headers.Select((ComponentMetadataItemHeader h) => _003C_003Ec.nFngrFQb5ikDGSWbTtEb(h)).ToList();
		Dictionary<Guid, ISet<Guid>> dictionary = new Dictionary<Guid, ISet<Guid>>();
		List<ComponentMetadataItem> list2 = headers.Select((ComponentMetadataItemHeader header) => (ComponentMetadataItem)_003C_003Ec.Oq1f6gQbjS3u16h9sI5h(header)).ToList();
		foreach (ComponentMetadataItem item in list2)
		{
			Guid uid2 = item.Header.Uid;
			if (item.Metadata is ComponentMetadata componentMetadata && componentMetadata.Content?.View != null)
			{
				HashSet<Guid> hashSet2 = (from c in componentMetadata.Content.View.GetAllItems(ignoreHide: false).OfType<ComponentViewItem>()
					select _003C_003Ec.xS5ItbQbYylJYoKOeYfZ(c)).ToHashSet();
				hashSet2.IntersectWith(other);
				if (hashSet2.Count > 0)
				{
					dictionary.Add(uid2, hashSet2);
					continue;
				}
			}
			hashSet.Add(uid2);
			list.Add(uid2);
		}
		foreach (KeyValuePair<Guid, ISet<Guid>> item2 in dictionary)
		{
			SortByDependenciesVisit(item2.Key, dictionary, hashSet, list);
		}
		CS_0024_003C_003E8__locals0.dic = list2.ToDictionary((ComponentMetadataItem i) => ((ComponentMetadataItemHeader)_003C_003Ec.jyRkMdQbL0MsXkQA5AV7(i)).Uid, (ComponentMetadataItem i) => i);
		return list.Select((Guid uid) => (ComponentMetadataItemHeader)_003C_003Ec__DisplayClass14_0.w3wDf7Qb9FNMQh785im7(CS_0024_003C_003E8__locals0.dic[uid]));
	}

	public static void UpdateCalculateScriptDynamicProperties(ComponentMetadata metadata)
	{
		//Discarded unreachable code: IL_0046, IL_0050, IL_0080, IL_008a, IL_0122, IL_0135, IL_020e, IL_0221, IL_02aa, IL_02b9, IL_02c4, IL_02e8, IL_02f7, IL_0302, IL_038a, IL_039d, IL_0420, IL_043f, IL_046b, IL_047a, IL_048b, IL_049a, IL_04a5, IL_04c9, IL_04d8, IL_04e3, IL_057b, IL_058e, IL_059d, IL_0601, IL_0639
		int num = 8;
		List<PropertyMetadata>.Enumerator enumerator4 = default(List<PropertyMetadata>.Enumerator);
		List<ComputedValue>.Enumerator enumerator3 = default(List<ComputedValue>.Enumerator);
		IViewModelPropertyMetadata viewModelPropertyMetadata = default(IViewModelPropertyMetadata);
		FormViewItem formViewItem = default(FormViewItem);
		IEnumerator<ToolbarItem> enumerator2 = default(IEnumerator<ToolbarItem>);
		IEnumerator<ViewItem> enumerator = default(IEnumerator<ViewItem>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					try
					{
						while (true)
						{
							int num11;
							if (!enumerator4.MoveNext())
							{
								num11 = 5;
								goto IL_0054;
							}
							goto IL_01ba;
							IL_0054:
							while (true)
							{
								switch (num11)
								{
								case 1:
									try
									{
										while (true)
										{
											int num12;
											if (!enumerator3.MoveNext())
											{
												num12 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
												{
													num12 = 1;
												}
												goto IL_008e;
											}
											goto IL_00ca;
											IL_00ca:
											mrdgj6BQQQTcqS5UlckS(enumerator3.Current, P3HFOqBQfD44gnK4rjCl(metadata));
											num12 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
											{
												num12 = 0;
											}
											goto IL_008e;
											IL_008e:
											switch (num12)
											{
											case 2:
												goto IL_00ca;
											case 1:
												goto end_IL_00a4;
											}
											continue;
											end_IL_00a4:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator3).Dispose();
										int num13 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
										{
											num13 = 0;
										}
										switch (num13)
										{
										case 0:
											break;
										}
									}
									break;
								case 3:
									mrdgj6BQQQTcqS5UlckS(tTO58kBQEVZiBsI9qDhS(viewModelPropertyMetadata), P3HFOqBQfD44gnK4rjCl(metadata));
									num11 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
									{
										num11 = 0;
									}
									continue;
								case 4:
									break;
								case 2:
									enumerator3 = viewModelPropertyMetadata.ComputedValues.GetEnumerator();
									num11 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
									{
										num11 = 1;
									}
									continue;
								default:
									if (viewModelPropertyMetadata != null)
									{
										num11 = 3;
										continue;
									}
									break;
								case 6:
									goto IL_01ba;
								case 5:
									goto end_IL_016b;
								}
								break;
							}
							continue;
							IL_01ba:
							viewModelPropertyMetadata = enumerator4.Current as IViewModelPropertyMetadata;
							num11 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
							{
								num11 = 0;
							}
							goto IL_0054;
							continue;
							end_IL_016b:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
						int num14 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num14 = 0;
						}
						switch (num14)
						{
						case 0:
							break;
						}
					}
					break;
				default:
					if (dUxdyVBQZqrsQTDB57h6(formViewItem) != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					return;
				case 8:
					goto end_IL_0012;
				case 6:
					enumerator2 = formViewItem.Toolbar.GetAllItems(ignoreHide: false).GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					try
					{
						while (true)
						{
							int num7;
							if (!s2o74fBQvkQoQSUtg8yN(enumerator))
							{
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
								{
									num7 = 1;
								}
								goto IL_02c8;
							}
							goto IL_03a7;
							IL_03a7:
							enumerator3 = enumerator.Current.DynamicProperties.GetEnumerator();
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
							{
								num7 = 0;
							}
							goto IL_02c8;
							IL_02c8:
							switch (num7)
							{
							default:
								try
								{
									while (true)
									{
										int num8;
										if (!enumerator3.MoveNext())
										{
											num8 = 2;
											goto IL_0306;
										}
										goto IL_031c;
										IL_0306:
										switch (num8)
										{
										case 1:
											continue;
										case 2:
											goto end_IL_0348;
										}
										goto IL_031c;
										IL_031c:
										ComputedValueHelper.SetCalculateScriptMethodName(enumerator3.Current, P3HFOqBQfD44gnK4rjCl(metadata));
										num8 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
										{
											num8 = 1;
										}
										goto IL_0306;
										continue;
										end_IL_0348:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator3).Dispose();
									int num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
									{
										num9 = 0;
									}
									switch (num9)
									{
									case 0:
										break;
									}
								}
								continue;
							case 2:
								break;
							case 3:
								continue;
							case 1:
								goto end_IL_03d4;
							}
							goto IL_03a7;
							continue;
							end_IL_03d4:
							break;
						}
					}
					finally
					{
						int num10;
						if (enumerator == null)
						{
							num10 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num10 = 1;
							}
							goto IL_0424;
						}
						goto IL_0449;
						IL_0449:
						DP9WxIBQ8HCG7t1qAAdn(enumerator);
						num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num10 = 0;
						}
						goto IL_0424;
						IL_0424:
						switch (num10)
						{
						default:
							goto end_IL_03ff;
						case 1:
							goto end_IL_03ff;
						case 2:
							break;
						case 0:
							goto end_IL_03ff;
						}
						goto IL_0449;
						end_IL_03ff:;
					}
					goto default;
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!s2o74fBQvkQoQSUtg8yN(enumerator2))
							{
								num3 = 3;
								goto IL_04a9;
							}
							goto IL_05be;
							IL_04a9:
							switch (num3)
							{
							case 2:
								try
								{
									while (true)
									{
										int num4;
										if (!enumerator3.MoveNext())
										{
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
											{
												num4 = 2;
											}
											goto IL_04e7;
										}
										goto IL_04fd;
										IL_04fd:
										mrdgj6BQQQTcqS5UlckS(enumerator3.Current, metadata.Uid);
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
										{
											num4 = 0;
										}
										goto IL_04e7;
										IL_04e7:
										switch (num4)
										{
										case 1:
											break;
										default:
											continue;
										case 2:
											goto end_IL_0529;
										}
										goto IL_04fd;
										continue;
										end_IL_0529:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator3).Dispose();
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								break;
							case 1:
								goto IL_05be;
							case 3:
								return;
							}
							continue;
							IL_05be:
							enumerator3 = enumerator2.Current.DynamicProperties.GetEnumerator();
							num3 = 2;
							goto IL_04a9;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
							{
								num6 = 1;
							}
							while (true)
							{
								switch (num6)
								{
								case 1:
									DP9WxIBQ8HCG7t1qAAdn(enumerator2);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
									{
										num6 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 3:
					return;
				case 2:
					enumerator = formViewItem.GetAllItems(ignoreHide: false).Concat(formViewItem).GetEnumerator();
					num2 = 5;
					continue;
				case 4:
					break;
				}
				formViewItem = (FormViewItem)tCh4y4BQC3k4ky5SFmS1(WRdEAFBQhdSdO2T46cOZ(metadata));
				num2 = 2;
				continue;
				end_IL_0012:
				break;
			}
			enumerator4 = ((ClassMetadata)LJYprBBQGPyyZJKbRCjC(WRdEAFBQhdSdO2T46cOZ(metadata))).Properties.GetEnumerator();
			num = 7;
		}
	}

	internal void AddSystemComponent(ComponentMetadataItemHeader header)
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
				SystemComponents.Add(header.Uid, header);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal virtual ICriteria ValidateNameCriteria(string name)
	{
		return (ICriteria)DpG3dOBQiV6WR1pvDCHX(((ICriteria)f0UvQQBQum4PonP5fCZY(this, null)).Add((ICriterion)vSgSMpBQVQuA9FeBpBkt(KPD0nMBQIa3WOeRtiIdL(_Resources_PropertyNames.Name), name)), new IProjection[1] { (IProjection)Jqk1sTBQSyDBVoHhKZ5w(_Resources_PropertyNames.Id) });
	}

	private bool ValidateName(ICriterion compareCriterion, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_01ef, IL_01fe, IL_020e, IL_021d
		int num = 12;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return true;
				case 7:
					errorMessage = (string)Qg10hGBQqvErDI81ibAE(dmwtb8BfU3qZn7oh2BkQ(0x1637C429 ^ 0x16373573));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					return false;
				case 3:
					errorMessage = null;
					num2 = 4;
					continue;
				case 6:
					return false;
				case 11:
					if (!string.IsNullOrEmpty(name))
					{
						if (WviwDhBQKKSBJxaC2h4C(name))
						{
							num2 = 8;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto default;
					}
					num2 = 7;
					continue;
				case 10:
					errorMessage = SR.T((string)dmwtb8BfU3qZn7oh2BkQ(0x6DC147B0 ^ 0x6DC1B5FC), name);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					return false;
				case 9:
					errorMessage = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x3418AC19), name);
					num = 5;
					break;
				case 12:
					ULp13lBQRdEe6g7JfUFh(compareCriterion, dmwtb8BfU3qZn7oh2BkQ(0x638095EB ^ 0x638064DD));
					num2 = 11;
					continue;
				default:
					errorMessage = SR.T((string)dmwtb8BfU3qZn7oh2BkQ(0xA592A41 ^ 0xA59DBCB), name);
					num2 = 2;
					continue;
				case 2:
					return false;
				case 8:
					if (Convert.ToInt64(LR00leBQTRP5dmXX40LZ(USvYVLBfYINXdeyh25s7(mqtUmMBQXH4G10I5Fbeu(this, name), Restrictions.Not(compareCriterion)))) <= 0)
					{
						if (oLxHvnBQnmFnWwF2y6ts(LR00leBQTRP5dmXX40LZ(cMQoRhBQkPNbgQTiciP5(Locator.GetServiceNotNull<FormMetadataItemHeaderManager>(), name))) <= 0)
						{
							num = 3;
							break;
						}
						goto case 9;
					}
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	private bool ValidateDisplayName(ICriterion compareCriterion, string displayName, out string errorMessage)
	{
		//Discarded unreachable code: IL_0161
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				errorMessage = null;
				num2 = 5;
				break;
			case 5:
				return true;
			case 1:
				Contract.ArgumentNotNull(compareCriterion, (string)dmwtb8BfU3qZn7oh2BkQ(-1123633026 ^ -1123661496));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				errorMessage = (string)Qg10hGBQqvErDI81ibAE(dmwtb8BfU3qZn7oh2BkQ(-1979251663 ^ -1979189611));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				return false;
			default:
				if (!bYuMSqBQOVI87ml74Wrw(displayName))
				{
					num2 = 4;
					break;
				}
				goto case 7;
			case 6:
				return false;
			case 4:
				if (oLxHvnBQnmFnWwF2y6ts(((ICriteria)DpG3dOBQiV6WR1pvDCHX(USvYVLBfYINXdeyh25s7(USvYVLBfYINXdeyh25s7(f0UvQQBQum4PonP5fCZY(this, null), oEYFaiBQ2MM3rJC56Opv(compareCriterion)), vSgSMpBQVQuA9FeBpBkt(KPD0nMBQIa3WOeRtiIdL(_Resources_PropertyNames.DisplayName), displayName)), new IProjection[1] { (IProjection)Jqk1sTBQSyDBVoHhKZ5w(_Resources_PropertyNames.Id) })).UniqueResult()) > 0)
				{
					errorMessage = (string)Qg10hGBQqvErDI81ibAE(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FF399B));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	private void SortByDependenciesVisit(Guid node, IDictionary<Guid, ISet<Guid>> dependencies, ISet<Guid> visited, ICollection<Guid> result)
	{
		if (visited.Contains(node))
		{
			return;
		}
		visited.Add(node);
		foreach (Guid item in dependencies[node])
		{
			SortByDependenciesVisit(item, dependencies, visited, result);
		}
		result.Add(node);
	}

	public ComponentMetadataItemHeaderManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		fjYoqfBQevcvd5f6BqCG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ComponentMetadataItemHeaderManager()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				SystemComponents = new Dictionary<Guid, ComponentMetadataItemHeader>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool ReKQUOBfrysg5WV5qriM()
	{
		return EYHJlfBflFZgVwpHWPbw == null;
	}

	internal static ComponentMetadataItemHeaderManager F2HpjfBfg6ZQgiKOUl4P()
	{
		return EYHJlfBflFZgVwpHWPbw;
	}

	internal static void b5XHKWBf5bWdvipJGD00(object P_0, object P_1, object P_2)
	{
		((EntityManager<ComponentMetadataItemHeader, long>)P_0).SetupFilter((ICriteria)P_1, (IEntityFilter)P_2);
	}

	internal static object yXLoUoBfjv0xkkPYDP90(object P_0)
	{
		return Restrictions.IsNotNull((string)P_0);
	}

	internal static object USvYVLBfYINXdeyh25s7(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object CuNCKDBfL7oOjRHBB79p(object P_0)
	{
		return ((ComponentMetadataItemHeader)P_0).Published;
	}

	internal static object dmwtb8BfU3qZn7oh2BkQ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object zGNhc3Bfsqn7MNRQxpD9(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object tmO7GvBfc8EE1935DZHR(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object q5EX2EBfzf19DWbOHvBX(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object QHU0SuBQFP7xEyiT19pU(object P_0)
	{
		return ((IQuery)P_0).UniqueResult();
	}

	internal static void qIesnQBQBvmie0b048ii(object P_0)
	{
		((Entity<long>)P_0).Delete();
	}

	internal static object bZdle1BQW4MVox9OQvyy(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object yF0ngIBQoPNsLgCWZfrC()
	{
		return MetadataItemGroupUIManager.Instance;
	}

	internal static void zwBUvNBQbT9n7qEbKq4i(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).Group = (MetadataItemGroupUI)P_1;
	}

	internal static object WRdEAFBQhdSdO2T46cOZ(object P_0)
	{
		return ((ComponentMetadata)P_0).Content;
	}

	internal static object LJYprBBQGPyyZJKbRCjC(object P_0)
	{
		return ((ComponentContentMetadata)P_0).Context;
	}

	internal static object tTO58kBQEVZiBsI9qDhS(object P_0)
	{
		return ((IViewModelPropertyMetadata)P_0).ComputedValue;
	}

	internal static Guid P3HFOqBQfD44gnK4rjCl(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void mrdgj6BQQQTcqS5UlckS(object P_0, Guid metadataUid)
	{
		ComputedValueHelper.SetCalculateScriptMethodName((IComputedValue)P_0, metadataUid);
	}

	internal static object tCh4y4BQC3k4ky5SFmS1(object P_0)
	{
		return ((ComponentContentMetadata)P_0).View;
	}

	internal static bool s2o74fBQvkQoQSUtg8yN(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void DP9WxIBQ8HCG7t1qAAdn(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object dUxdyVBQZqrsQTDB57h6(object P_0)
	{
		return ((FormViewItem)P_0).Toolbar;
	}

	internal static object f0UvQQBQum4PonP5fCZY(object P_0, object P_1)
	{
		return ((EntityManager<ComponentMetadataItemHeader, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object KPD0nMBQIa3WOeRtiIdL(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object vSgSMpBQVQuA9FeBpBkt(object P_0, object P_1)
	{
		return ElmaRestrictions.InsensitiveLike((IProjection)P_0, P_1);
	}

	internal static object Jqk1sTBQSyDBVoHhKZ5w(object P_0)
	{
		return Projections.Count((string)P_0);
	}

	internal static object DpG3dOBQiV6WR1pvDCHX(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static void ULp13lBQRdEe6g7JfUFh(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object Qg10hGBQqvErDI81ibAE(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool WviwDhBQKKSBJxaC2h4C(object P_0)
	{
		return ((string)P_0).IsValidIdentifier();
	}

	internal static object mqtUmMBQXH4G10I5Fbeu(object P_0, object P_1)
	{
		return ((ComponentMetadataItemHeaderManager)P_0).ValidateNameCriteria((string)P_1);
	}

	internal static object LR00leBQTRP5dmXX40LZ(object P_0)
	{
		return ((ICriteria)P_0).UniqueResult();
	}

	internal static object cMQoRhBQkPNbgQTiciP5(object P_0, object P_1)
	{
		return ((FormMetadataItemHeaderManager)P_0).ValidateNameCriteria((string)P_1);
	}

	internal static long oLxHvnBQnmFnWwF2y6ts(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static bool bYuMSqBQOVI87ml74Wrw(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object oEYFaiBQ2MM3rJC56Opv(object P_0)
	{
		return Restrictions.Not((ICriterion)P_0);
	}

	internal static void fjYoqfBQevcvd5f6BqCG()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
