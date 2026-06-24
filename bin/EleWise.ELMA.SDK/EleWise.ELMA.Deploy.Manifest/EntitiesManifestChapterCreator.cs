using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Manifest;

[Component]
public class EntitiesManifestChapterCreator : IManifestChapterCreator
{
	internal static EntitiesManifestChapterCreator omh80QEpg4qx97uYgUF3;

	public void Resolve(ConfigExportSettings settings, ExportedObjectsDescription desc)
	{
		//Discarded unreachable code: IL_003a, IL_0049, IL_0054, IL_00a7, IL_00b6, IL_020a, IL_023a, IL_0249, IL_0255, IL_0264, IL_02cb, IL_02da, IL_0367, IL_042b, IL_043e, IL_0474, IL_0487, IL_0496, IL_04e2
		int num = 3;
		int num2 = num;
		List<PacketMetadata>.Enumerator enumerator = default(List<PacketMetadata>.Enumerator);
		PacketMetadata current = default(PacketMetadata);
		IEnumerator<KeyValuePair<Guid, SubUserMetadataInfo>> enumerator3 = default(IEnumerator<KeyValuePair<Guid, SubUserMetadataInfo>>);
		EntityManifest item2 = default(EntityManifest);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		KeyValuePair<Guid, SubUserMetadataInfo> current2 = default(KeyValuePair<Guid, SubUserMetadataInfo>);
		List<IGroupedMetadata>.Enumerator enumerator2 = default(List<IGroupedMetadata>.Enumerator);
		EntityMetadata entityMetadata = default(EntityMetadata);
		EntityManifest item = default(EntityManifest);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				try
				{
					while (true)
					{
						IL_0287:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
							{
								num3 = 3;
							}
							goto IL_0058;
						}
						goto IL_007e;
						IL_007e:
						current = enumerator.Current;
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num3 = 4;
						}
						goto IL_0058;
						IL_0058:
						while (true)
						{
							switch (num3)
							{
							case 5:
								try
								{
									while (true)
									{
										IL_017c:
										int num8;
										if (!enumerator3.MoveNext())
										{
											int num7 = 4;
											num8 = num7;
											goto IL_00c5;
										}
										goto IL_0169;
										IL_00c5:
										while (true)
										{
											switch (num8)
											{
											case 3:
												((ElmaStoreComponentManifest)gqUB8REaB47lbHxk1XlM(settings)).Entities.Add(item2);
												num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
												{
													num8 = 1;
												}
												continue;
											case 6:
											{
												EntityManifest obj = new EntityManifest
												{
													Name = (string)SQMPCaEpYXpjJGtKONPC(entityMetadata2)
												};
												im1e9WEpU36VlgL1ewYD(obj, GkGZMxEaWFfaOltf5faU(entityMetadata2));
												HiiSKgEaoNP1l2qQDqph(obj, oMhK1WEps4hSyL7VeiNZ(entityMetadata2));
												eXfu5YEpzWuSrby3gZsr(obj, entityMetadata2.DisplayName);
												xfUZuSEaF1h4KWcwhTvq(obj, sKvwpTEabIsoHnaTUN3D(entityMetadata2));
												item2 = obj;
												num8 = 3;
												continue;
											}
											case 2:
												break;
											case 1:
												goto IL_017c;
											default:
												if (entityMetadata2 != null)
												{
													num8 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
													{
														num8 = 6;
													}
													continue;
												}
												goto IL_017c;
											case 5:
												entityMetadata2 = current2.Value.Metadata as EntityMetadata;
												num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
												{
													num8 = 0;
												}
												continue;
											case 4:
												goto end_IL_017c;
											}
											break;
										}
										goto IL_0169;
										IL_0169:
										current2 = enumerator3.Current;
										num8 = 5;
										goto IL_00c5;
										continue;
										end_IL_017c:
										break;
									}
								}
								finally
								{
									int num9;
									if (enumerator3 == null)
									{
										num9 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
										{
											num9 = 1;
										}
										goto IL_020e;
									}
									goto IL_0224;
									IL_0224:
									LBsPe9Eahh0UYNlMcGjF(enumerator3);
									num9 = 2;
									goto IL_020e;
									IL_020e:
									switch (num9)
									{
									case 1:
										goto end_IL_01e9;
									case 2:
										goto end_IL_01e9;
									}
									goto IL_0224;
									end_IL_01e9:;
								}
								goto IL_0287;
							case 2:
								enumerator3 = current.SubUserMetadataInfo.GetEnumerator();
								num3 = 5;
								continue;
							case 1:
								goto IL_0287;
							case 4:
								enumerator2 = current.SubSystemMetadata.GetEnumerator();
								num3 = 6;
								continue;
							case 6:
								try
								{
									while (true)
									{
										IL_034c:
										int num4;
										if (!enumerator2.MoveNext())
										{
											num4 = 5;
											goto IL_02e9;
										}
										goto IL_030f;
										IL_02e9:
										while (true)
										{
											switch (num4)
											{
											case 3:
												break;
											case 1:
												if (entityMetadata == null)
												{
													int num5 = 6;
													num4 = num5;
													continue;
												}
												goto case 4;
											default:
												goto IL_034c;
											case 2:
												((ElmaStoreComponentManifest)gqUB8REaB47lbHxk1XlM(settings)).Entities.Add(item);
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
												{
													num4 = 0;
												}
												continue;
											case 4:
											{
												EntityManifest entityManifest = new EntityManifest();
												mZoyTIEpLinPY5TyFVra(entityManifest, SQMPCaEpYXpjJGtKONPC(entityMetadata));
												im1e9WEpU36VlgL1ewYD(entityManifest, entityMetadata.Namespace);
												entityManifest.Uid = oMhK1WEps4hSyL7VeiNZ(entityMetadata);
												eXfu5YEpzWuSrby3gZsr(entityManifest, JfsD94EpcBELXYrfgZJS(entityMetadata));
												xfUZuSEaF1h4KWcwhTvq(entityManifest, entityMetadata.TableName);
												item = entityManifest;
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
												{
													num4 = 2;
												}
												continue;
											}
											case 5:
												goto end_IL_034c;
											}
											break;
										}
										goto IL_030f;
										IL_030f:
										entityMetadata = enumerator2.Current as EntityMetadata;
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
										{
											num4 = 1;
										}
										goto IL_02e9;
										continue;
										end_IL_034c:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
									{
										num6 = 0;
									}
									switch (num6)
									{
									case 0:
										break;
									}
								}
								goto case 2;
							case 3:
								return;
							}
							break;
						}
						goto IL_007e;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num10 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num10 = 0;
					}
					switch (num10)
					{
					case 0:
						break;
					}
				}
			case 5:
				enumerator = desc.ExportedPacketMetadatas.GetEnumerator();
				num2 = 4;
				break;
			case 3:
				if (settings.Manifest == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 2;
					}
					break;
				}
				if (desc.ExportedPacketMetadatas == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 0:
				return;
			case 2:
				return;
			case 1:
				return;
			}
		}
	}

	public EntitiesManifestChapterCreator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		LxROqAEaGn8S2JHF4QXW();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object SQMPCaEpYXpjJGtKONPC(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void mZoyTIEpLinPY5TyFVra(object P_0, object P_1)
	{
		((EntityManifest)P_0).Name = (string)P_1;
	}

	internal static void im1e9WEpU36VlgL1ewYD(object P_0, object P_1)
	{
		((EntityManifest)P_0).Namespace = (string)P_1;
	}

	internal static Guid oMhK1WEps4hSyL7VeiNZ(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object JfsD94EpcBELXYrfgZJS(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void eXfu5YEpzWuSrby3gZsr(object P_0, object P_1)
	{
		((EntityManifest)P_0).DisplayName = (string)P_1;
	}

	internal static void xfUZuSEaF1h4KWcwhTvq(object P_0, object P_1)
	{
		((EntityManifest)P_0).TableName = (string)P_1;
	}

	internal static object gqUB8REaB47lbHxk1XlM(object P_0)
	{
		return ((ConfigExportSettings)P_0).Manifest;
	}

	internal static object GkGZMxEaWFfaOltf5faU(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static void HiiSKgEaoNP1l2qQDqph(object P_0, Guid P_1)
	{
		((EntityManifest)P_0).Uid = P_1;
	}

	internal static object sKvwpTEabIsoHnaTUN3D(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static void LBsPe9Eahh0UYNlMcGjF(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool KB4VOWEp5CV6sn94KVaf()
	{
		return omh80QEpg4qx97uYgUF3 == null;
	}

	internal static EntitiesManifestChapterCreator bT2mt6EpjF9Fo0lc4YRP()
	{
		return omh80QEpg4qx97uYgUF3;
	}

	internal static void LxROqAEaGn8S2JHF4QXW()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
