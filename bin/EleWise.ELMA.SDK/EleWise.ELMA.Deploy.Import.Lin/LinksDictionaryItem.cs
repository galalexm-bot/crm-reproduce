using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Collections;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import.Links;

public class LinksDictionaryItem : ILinksDictionaryItem
{
	internal static LinksDictionaryItem S2l8ssEJ9EynArkhOt5B;

	public Guid EntityUid
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CEntityUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public Guid EntityTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityTypeUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CEntityTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string EntityPropertyName
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityPropertyName_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CEntityPropertyName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	internal Guid TablePartUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTablePartUid_003Ek__BackingField;
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
				case 1:
					_003CTablePartUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public Guid LinkUid
	{
		[CompilerGenerated]
		get
		{
			return _003CLinkUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CLinkUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public Guid LinkPropertyUid
	{
		[CompilerGenerated]
		get
		{
			return _003CLinkPropertyUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CLinkPropertyUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public LinksDictionaryItem(Guid entityUid, Guid entityTypeUid, string entityPropertyName, Guid linkUid, Guid linkPropertyUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IMpemJEJrkRIZEwNgwmU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				EntityUid = entityUid;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num = 4;
				}
				break;
			case 5:
				EntityPropertyName = entityPropertyName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
				{
					num = 1;
				}
				break;
			case 4:
				EntityTypeUid = entityTypeUid;
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 4;
				}
				break;
			case 1:
				LinkUid = linkUid;
				num = 3;
				break;
			case 3:
				LinkPropertyUid = linkPropertyUid;
				num = 2;
				break;
			}
		}
	}

	public bool UpdateLinkByUid(Guid oldUid, Guid newUid)
	{
		//Discarded unreachable code: IL_0042, IL_0051
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				LinkUid = newUid;
				num2 = 3;
				break;
			case 1:
				if (!gpCVHKEJglRNAFwbd7ju(LinkUid, oldUid))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 3:
				return true;
			default:
				return false;
			}
		}
	}

	public bool ContainLink(Guid propertyUidI)
	{
		return gpCVHKEJglRNAFwbd7ju(LinkUid, propertyUidI);
	}

	public bool SetLinkValue(IEntity entity, Guid eUid)
	{
		//Discarded unreachable code: IL_0157, IL_0166, IL_01a6, IL_01b5, IL_021c
		int num = 8;
		IEntity entity2 = default(IEntity);
		EntityMetadata entityMetadata = default(EntityMetadata);
		Type typeByUidOrNull = default(Type);
		IEntityManager entityManager = default(IEntityManager);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					((ISession)Gbwby4EJLbWglt1KvYHn(Locator.GetServiceNotNull<ISessionProvider>(), "")).Save((object)entity2);
					num2 = 14;
					continue;
				case 10:
					if (entityMetadata.Properties != null)
					{
						num2 = 4;
						continue;
					}
					goto default;
				case 8:
					if (!l1YD8yEJ54wVYfWIKCHA(eUid, LinkUid))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 11;
				case 11:
					return false;
				case 7:
					typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(EntityTypeUid);
					num = 5;
					break;
				case 1:
					return false;
				case 3:
					if (entity2 != null)
					{
						entityMetadata = MetadataLoader.LoadMetadata(typeByUidOrNull) as EntityMetadata;
						num2 = 13;
						continue;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					if (entityManager == null)
					{
						num2 = 2;
						continue;
					}
					entity2 = tj979gEJYngdvdiI2nNX(entityManager, EntityUid) as IEntity;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					continue;
				case 14:
					return true;
				case 13:
					if (entityMetadata != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 10;
						}
						continue;
					}
					goto default;
				case 5:
					if (!OJgq3NEJj7v9vU9cYW9k(typeByUidOrNull, null))
					{
						num = 15;
						break;
					}
					goto case 12;
				case 12:
					return false;
				case 15:
					entityManager = ModelHelper.GetEntityManager(typeByUidOrNull);
					num2 = 6;
					continue;
				case 2:
					return false;
				default:
					return false;
				case 4:
					SetLinkValue(entity, entityMetadata, entity2);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
		}
	}

	private void SetLinkValue(IEntity entity, EntityMetadata metadataLink, IEntity entityLink)
	{
		//Discarded unreachable code: IL_0075, IL_0170, IL_017f, IL_021b, IL_022a, IL_0239, IL_0288, IL_02bb, IL_02ca, IL_034a, IL_03e8, IL_03f7, IL_0428, IL_0460, IL_046f, IL_04cc, IL_04db, IL_04ec, IL_04f6, IL_0526, IL_0530, IL_05d9, IL_0636, IL_0717, IL_072a, IL_0739
		int num = 7;
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		PropertyInfo propertyCached2 = default(PropertyInfo);
		IEnumerator<PropertyMetadata> enumerator2 = default(IEnumerator<PropertyMetadata>);
		object obj2 = default(object);
		RelationType relationType = default(RelationType);
		IEnumerable enumerable = default(IEnumerable);
		object obj = default(object);
		PropertyInfo propertyCached = default(PropertyInfo);
		EntitySettings entitySettings = default(EntitySettings);
		IEnumerator enumerator3 = default(IEnumerator);
		IEntity entityLink2 = default(IEntity);
		TablePartMetadata current = default(TablePartMetadata);
		IEnumerable enumerable2 = default(IEnumerable);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					enumerator = metadataLink.TableParts.GetEnumerator();
					num2 = 2;
					continue;
				case 4:
					if (entityLink == null)
					{
						num2 = 3;
						continue;
					}
					propertyCached2 = entityLink.GetType().GetPropertyCached(EntityPropertyName);
					num2 = 8;
					continue;
				case 10:
					try
					{
						while (true)
						{
							IL_03a9:
							int num3;
							if (!wf8chsE9o3PMnYCq04eo(enumerator2))
							{
								num3 = 16;
								goto IL_0083;
							}
							goto IL_0354;
							IL_0083:
							while (true)
							{
								int num4;
								switch (num3)
								{
								case 6:
									obj2 = TFnensEJz7SmntGJiiP0(propertyCached2, entityLink, null);
									num3 = 17;
									continue;
								case 2:
									if ((uint)(relationType - 1) > 2u)
									{
										num3 = 21;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto case 19;
								case 25:
									if (relationType != 0)
									{
										num3 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto case 6;
								case 5:
									PPgUeBE9WTmllsuqAYiC(entity, enumerable, obj);
									num3 = 18;
									continue;
								case 9:
									if (!(TablePartUid != Guid.Empty))
									{
										num3 = 23;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
										{
											num3 = 10;
										}
										continue;
									}
									goto case 15;
								case 22:
									obj = n1GG0FE9B9WEhqeMAq33(entity);
									num3 = 9;
									continue;
								case 27:
									if (IsCurrentTablePart(entityLink, propertyCached))
									{
										num3 = 12;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
										{
											num3 = 8;
										}
										continue;
									}
									goto IL_03a9;
								default:
									relationType = jl5XDHEJctUPZ61Trq3X(entitySettings);
									num3 = 25;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
									{
										num3 = 5;
									}
									continue;
								case 19:
									enumerable = (IEnumerable)TFnensEJz7SmntGJiiP0(propertyCached2, entityLink, null);
									num4 = 8;
									goto IL_007f;
								case 3:
								case 26:
									if (obj2 == null)
									{
										num3 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto IL_03a9;
								case 7:
								case 23:
									PPgUeBE9WTmllsuqAYiC(entity, enumerable, obj);
									num3 = 10;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
									{
										num3 = 10;
									}
									continue;
								case 17:
									if (!l1YD8yEJ54wVYfWIKCHA(TablePartUid, Guid.Empty))
									{
										num3 = 26;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
										{
											num3 = 4;
										}
										continue;
									}
									goto case 27;
								case 20:
									if (entitySettings == null)
									{
										num3 = 24;
										continue;
									}
									goto case 14;
								case 1:
									rg7uu8E9FXqUqPd5gOdd(propertyCached2, entityLink, entity, null);
									num3 = 13;
									continue;
								case 15:
									if (!IsCurrentTablePart(entityLink, propertyCached))
									{
										goto IL_03a9;
									}
									num4 = 5;
									goto IL_007f;
								case 11:
									break;
								case 8:
									if (enumerable != null)
									{
										num3 = 22;
										continue;
									}
									goto IL_03a9;
								case 14:
									if (!gppR31EJsPyBpNbxohF4(propertyCached2, null))
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto IL_03a9;
								case 4:
								case 10:
								case 13:
								case 18:
								case 21:
								case 24:
									goto IL_03a9;
								case 12:
									propertyCached2.SetValue(entityLink, entity, null);
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
									{
										num3 = 0;
									}
									continue;
								case 16:
									goto end_IL_03a9;
									IL_007f:
									num3 = num4;
									continue;
								}
								break;
							}
							goto IL_0354;
							IL_0354:
							entitySettings = enumerator2.Current.Settings as EntitySettings;
							num3 = 20;
							goto IL_0083;
							continue;
							end_IL_03a9:
							break;
						}
					}
					finally
					{
						if (enumerator2 != null)
						{
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									Su7KbJE9bXZ2UMGDcsIY(enumerator2);
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
									{
										num5 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto default;
				case 1:
					return;
				case 9:
					break;
				case 7:
					if (entity != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					return;
				case 5:
					return;
				case 2:
					try
					{
						while (true)
						{
							IL_06d5:
							int num6;
							if (!enumerator.MoveNext())
							{
								num6 = 4;
								goto IL_04fa;
							}
							goto IL_068f;
							IL_04fa:
							while (true)
							{
								switch (num6)
								{
								case 4:
									return;
								case 6:
									try
									{
										while (true)
										{
											IL_058b:
											int num7;
											if (!wf8chsE9o3PMnYCq04eo(enumerator3))
											{
												num7 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
												{
													num7 = 1;
												}
												goto IL_0534;
											}
											goto IL_054e;
											IL_054e:
											entityLink2 = (IEntity)ir54IgE9fccrFMDL9fuW(enumerator3);
											num7 = 2;
											goto IL_0534;
											IL_0534:
											while (true)
											{
												switch (num7)
												{
												case 3:
													break;
												case 2:
													SetLinkValue(entity, current, entityLink2);
													num7 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
													{
														num7 = 0;
													}
													continue;
												default:
													goto IL_058b;
												case 1:
													goto end_IL_058b;
												}
												break;
											}
											goto IL_054e;
											continue;
											end_IL_058b:
											break;
										}
									}
									finally
									{
										IDisposable disposable = enumerator3 as IDisposable;
										int num8 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
										{
											num8 = 1;
										}
										while (true)
										{
											switch (num8)
											{
											case 2:
												Su7KbJE9bXZ2UMGDcsIY(disposable);
												num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
												{
													num8 = 0;
												}
												continue;
											case 1:
												if (disposable != null)
												{
													num8 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
													{
														num8 = 1;
													}
													continue;
												}
												break;
											case 0:
												break;
											}
											break;
										}
									}
									goto IL_06d5;
								case 2:
									enumerable2 = S9y0X5E9G62WsWQUAcNK(entityLink, V0ny4OE9h2wHeneLR8yb(current)) as IEnumerable;
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
									{
										num6 = 1;
									}
									continue;
								case 1:
									if (enumerable2 != null)
									{
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
										{
											num6 = 0;
										}
										continue;
									}
									goto IL_06d5;
								case 3:
									break;
								default:
									enumerator3 = (IEnumerator)Lahd98E9EmZNRuylP8TQ(enumerable2);
									num6 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
									{
										num6 = 1;
									}
									continue;
								case 5:
									goto IL_06d5;
								}
								break;
							}
							goto IL_068f;
							IL_068f:
							current = enumerator.Current;
							num6 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
							{
								num6 = 1;
							}
							goto IL_04fa;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
				case 3:
					return;
				case 6:
					if (metadataLink == null)
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				case 8:
					propertyCached = entityLink.GetType().GetPropertyCached((string)C8uanKEJUYtk9cZ3p8fv(-35995181 ^ -36000191));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 9;
					}
					continue;
				}
				break;
			}
			enumerator2 = metadataLink.Properties.Where((PropertyMetadata p) => gpCVHKEJglRNAFwbd7ju(BbEDQLE9CjOyMDHqGxJd(p), LinkPropertyUid)).GetEnumerator();
			num = 10;
		}
	}

	private static void SetTablePartLinkValue(object entity, object propValues, object entityId)
	{
		//Discarded unreachable code: IL_006f, IL_007e, IL_0089, IL_0143, IL_0190, IL_019f
		int num = 4;
		bool flag = default(bool);
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (flag)
					{
						return;
					}
					goto end_IL_0012;
				case 0:
					return;
				case 4:
					flag = false;
					num2 = 3;
					break;
				case 3:
					enumerator = (IEnumerator)Lahd98E9EmZNRuylP8TQ(propValues);
					num2 = 5;
					break;
				case 5:
					try
					{
						while (true)
						{
							IL_00a7:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
								{
									num3 = 0;
								}
								goto IL_008d;
							}
							goto IL_00cd;
							IL_00cd:
							if (n1GG0FE9B9WEhqeMAq33((IEntity)ir54IgE9fccrFMDL9fuW(enumerator)) != entityId)
							{
								continue;
							}
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
							{
								num3 = 3;
							}
							goto IL_008d;
							IL_008d:
							while (true)
							{
								switch (num3)
								{
								case 2:
									goto IL_00a7;
								case 1:
									goto IL_00cd;
								case 3:
									flag = true;
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
									{
										num3 = 0;
									}
									continue;
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
						IDisposable disposable = enumerator as IDisposable;
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								if (disposable != null)
								{
									num4 = 2;
									continue;
								}
								break;
							case 2:
								Su7KbJE9bXZ2UMGDcsIY(disposable);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 1;
				case 2:
					AUeDWSE9QcxV2qtv02lc(propValues.AsUntypedISet(), entity);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	private bool IsCurrentTablePart(IEntity entityLink, PropertyInfo uidPropInfo)
	{
		//Discarded unreachable code: IL_00a4, IL_00b3
		int num = 5;
		object obj = default(object);
		Guid result = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = TFnensEJz7SmntGJiiP0(uidPropInfo, entityLink, null);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return gpCVHKEJglRNAFwbd7ju(TablePartUid, result);
				case 4:
					return false;
				case 5:
					if (!(uidPropInfo != null))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 2:
					if (Guid.TryParse(obj.ToString(), out result))
					{
						num2 = 3;
						break;
					}
					goto case 4;
				default:
					if (obj != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	internal static void IMpemJEJrkRIZEwNgwmU()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool vQ5UrFEJdr7UKX292VlK()
	{
		return S2l8ssEJ9EynArkhOt5B == null;
	}

	internal static LinksDictionaryItem xvXHbdEJlPkG0ud2CWSH()
	{
		return S2l8ssEJ9EynArkhOt5B;
	}

	internal static bool gpCVHKEJglRNAFwbd7ju(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool l1YD8yEJ54wVYfWIKCHA(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool OJgq3NEJj7v9vU9cYW9k(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object tj979gEJYngdvdiI2nNX(object P_0, Guid uid)
	{
		return ((IEntityManager)P_0).LoadOrNull(uid);
	}

	internal static object Gbwby4EJLbWglt1KvYHn(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object C8uanKEJUYtk9cZ3p8fv(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool gppR31EJsPyBpNbxohF4(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static RelationType jl5XDHEJctUPZ61Trq3X(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static object TFnensEJz7SmntGJiiP0(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static void rg7uu8E9FXqUqPd5gOdd(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static object n1GG0FE9B9WEhqeMAq33(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void PPgUeBE9WTmllsuqAYiC(object P_0, object P_1, object P_2)
	{
		SetTablePartLinkValue(P_0, P_1, P_2);
	}

	internal static bool wf8chsE9o3PMnYCq04eo(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void Su7KbJE9bXZ2UMGDcsIY(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static Guid V0ny4OE9h2wHeneLR8yb(object P_0)
	{
		return ((TablePartMetadata)P_0).TablePartPropertyUid;
	}

	internal static object S9y0X5E9G62WsWQUAcNK(object P_0, Guid propertyUid)
	{
		return ((IEntity)P_0).GetPropertyValue(propertyUid);
	}

	internal static object Lahd98E9EmZNRuylP8TQ(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static object ir54IgE9fccrFMDL9fuW(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static void AUeDWSE9QcxV2qtv02lc(object P_0, object P_1)
	{
		((IUntypedCollectionProxy)P_0).Add(P_1);
	}

	internal static Guid BbEDQLE9CjOyMDHqGxJd(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}
}
