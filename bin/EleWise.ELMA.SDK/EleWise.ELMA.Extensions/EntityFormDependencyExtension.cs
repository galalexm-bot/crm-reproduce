using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

[Component(Order = 50)]
internal class EntityFormDependencyExtension : IFormDependencyExtension
{
	private readonly IMetadataRuntimeService metadataRuntimeService;

	private static EntityFormDependencyExtension b7ApDiGt1gFdYOBOuTpM;

	public EntityFormDependencyExtension(IMetadataRuntimeService metadataRuntimeService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.metadataRuntimeService = metadataRuntimeService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual bool CheckType(Guid uid)
	{
		//Discarded unreachable code: IL_0059, IL_008c, IL_00de, IL_00ed
		bool flag = default(bool);
		switch (1)
		{
		default:
			return flag;
		case 1:
			try
			{
				flag = metadataRuntimeService.GetMetadata(uid, loadImplementation: false) is EntityMetadata;
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num = 0;
				}
				return num switch
				{
					0 => flag, 
					_ => flag, 
				};
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return flag;
					case 2:
						flag = false;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 0;
						}
						break;
					default:
						swm4FPGtaBlK54xMc56M(bHYPKnGtpkN1NSk8MEXa(), ex);
						num2 = 2;
						break;
					}
				}
			}
		}
	}

	public void GenerateNewDependencies(Guid dependObjectUid)
	{
		int num = 3;
		IMetadata metadata = default(IMetadata);
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
					return;
				case 2:
					if (metadata != null)
					{
						GenerateNewDependencies(metadata);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 1;
						}
					}
					continue;
				case 0:
					return;
				case 3:
					break;
				}
				break;
			}
			metadata = metadataRuntimeService.GetMetadata(dependObjectUid, loadImplementation: false);
			num = 2;
		}
	}

	public void GenerateNewDependencies(IMetadata dependObjectMetadata)
	{
		//Discarded unreachable code: IL_0093, IL_00a2, IL_01ad, IL_02e3, IL_02f2, IL_040d, IL_049e, IL_04ad, IL_04bd, IL_04cc, IL_0500, IL_05e5, IL_05f4, IL_062a, IL_063d, IL_064c, IL_07d1, IL_07e4, IL_081b, IL_082a, IL_0835, IL_0921, IL_0934, IL_0943, IL_0969, IL_0978
		int num = 20;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_3 = default(_003C_003Ec__DisplayClass4_0);
		EntityMetadata entityMetadata = default(EntityMetadata);
		List<FormViewItemTransformation>.Enumerator enumerator = default(List<FormViewItemTransformation>.Enumerator);
		List<FormViewItemTransformation> list2 = default(List<FormViewItemTransformation>);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		_003C_003Ec__DisplayClass4_2 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_2);
		_003C_003Ec__DisplayClass4_3 _003C_003Ec__DisplayClass4_2 = default(_003C_003Ec__DisplayClass4_3);
		List<ViewItemTransformation>.Enumerator enumerator2 = default(List<ViewItemTransformation>.Enumerator);
		ViewItemTransformation current = default(ViewItemTransformation);
		ViewItemTransformationChange viewItemTransformationChange = default(ViewItemTransformationChange);
		ButtonViewItem buttonViewItem = default(ButtonViewItem);
		Type type = default(Type);
		ViewItemTransformationAdd viewItemTransformationAdd = default(ViewItemTransformationAdd);
		List<Guid> list = default(List<Guid>);
		_003C_003Ec__DisplayClass4_1 _003C_003Ec__DisplayClass4_4 = default(_003C_003Ec__DisplayClass4_1);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 6:
				case 12:
					_003C_003Ec__DisplayClass4_3.deps = new List<IFormDependencyData>();
					num2 = 3;
					continue;
				case 9:
					if (entityMetadata != null)
					{
						num = 14;
						break;
					}
					return;
				case 20:
					_003C_003Ec__DisplayClass4_3 = new _003C_003Ec__DisplayClass4_0();
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 13;
					}
					continue;
				case 3:
					enumerator = list2.GetEnumerator();
					num = 18;
					break;
				case 8:
					list2 = entityMetadata.FormTransformations.ToList();
					num2 = 17;
					continue;
				case 1:
					_003C_003Ec__DisplayClass4_3.objectUid = xyV7rNGttohHDK9LejNO(entityMetadata);
					num2 = 21;
					continue;
				case 11:
					FormDependencyHelper.Update(_003C_003Ec__DisplayClass4_3.objectUid, (IFormDependencyData[])KjYOdYGtdQEq0iLdyjpK(_003C_003Ec__DisplayClass4_3.deps));
					num = 4;
					break;
				case 21:
					entityMetadata2 = metadataRuntimeService.GetMetadata(xyV7rNGttohHDK9LejNO(entityMetadata), loadImplementation: false) as EntityMetadata;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 22;
					}
					continue;
				case 19:
					entityMetadata = dependObjectMetadata as EntityMetadata;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					return;
				case 18:
					try
					{
						while (true)
						{
							IL_076e:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
								{
									num3 = 5;
								}
								goto IL_01bb;
							}
							goto IL_0287;
							IL_0287:
							_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_2();
							num3 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
							{
								num3 = 4;
							}
							goto IL_01bb;
							IL_01bb:
							while (true)
							{
								int num4;
								switch (num3)
								{
								case 3:
									_003C_003Ec__DisplayClass4_2.dependFormUid = _003C_003Ec__DisplayClass4_2.CS_0024_003C_003E8__locals2.t.Uid;
									num3 = 10;
									continue;
								case 12:
									_003C_003Ec__DisplayClass4_2.dependFormUid = _003C_003Ec__DisplayClass4_2.CS_0024_003C_003E8__locals2.t.NewFormUid;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
									{
										num3 = 14;
									}
									continue;
								default:
									if (NJcdfoGt6qrjgEchMNUU(_003C_003Ec__DisplayClass4_2.CS_0024_003C_003E8__locals2.t.NewFormUid, Guid.Empty))
									{
										num4 = 12;
										goto IL_01b7;
									}
									goto case 8;
								case 13:
									break;
								case 4:
									enumerator2 = _003C_003Ec__DisplayClass4_2.CS_0024_003C_003E8__locals2.t.Items.GetEnumerator();
									num3 = 6;
									continue;
								case 9:
									_003C_003Ec__DisplayClass4_.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass4_3;
									num3 = 11;
									continue;
								case 6:
									try
									{
										while (true)
										{
											IL_0473:
											int num5;
											if (!enumerator2.MoveNext())
											{
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
												{
													num5 = 0;
												}
												goto IL_0301;
											}
											goto IL_04e8;
											IL_04e8:
											current = enumerator2.Current;
											num5 = 16;
											goto IL_0301;
											IL_0301:
											while (true)
											{
												switch (num5)
												{
												case 7:
													viewItemTransformationChange = current as ViewItemTransformationChange;
													num5 = 14;
													continue;
												case 22:
													if (buttonViewItem != null)
													{
														num5 = 15;
														continue;
													}
													goto IL_0473;
												case 4:
													type = k43MtyGtJ2AcPG73meFm(qpYolcGtyTvnmXgEvqEj(viewItemTransformationChange));
													num5 = 10;
													continue;
												case 12:
													if (!wWrpX3GtMUicGOW5RIPV(qpYolcGtyTvnmXgEvqEj(viewItemTransformationChange)))
													{
														num5 = 4;
														continue;
													}
													goto IL_0473;
												case 16:
													viewItemTransformationAdd = current as ViewItemTransformationAdd;
													num5 = 13;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
													{
														num5 = 12;
													}
													continue;
												case 10:
													if (!RWmbadGt9VZUYtQ75w9S(type, null))
													{
														num5 = 7;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
														{
															num5 = 17;
														}
														continue;
													}
													goto case 2;
												case 5:
													FormDependencyHelper.GenerateFormDependencies(viewItemTransformationChange.Value.ToString(), _003C_003Ec__DisplayClass4_2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.objectUid, _003C_003Ec__DisplayClass4_2.dependFormUid, _003C_003Ec__DisplayClass4_2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.deps);
													num5 = 18;
													continue;
												case 9:
													buttonViewItem = xn2iF0GtHqhJKTCFjC8q(viewItemTransformationAdd) as ButtonViewItem;
													num5 = 22;
													continue;
												case 1:
												case 3:
												case 6:
												case 8:
												case 11:
												case 17:
												case 18:
													goto IL_0473;
												case 14:
													if (viewItemTransformationChange == null)
													{
														num5 = 6;
														continue;
													}
													goto case 21;
												case 19:
													goto IL_04e8;
												case 21:
													if (!x0EY7KGtxB05KCf3EGUW(XdFSYAGtmUg9TSivVIx8(viewItemTransformationChange), ORsHhXGt75TFynGmxWFG(0x3A5D5EF ^ 0x3A62BD7)))
													{
														num5 = 3;
														continue;
													}
													goto case 12;
												case 20:
													FormDependencyHelper.GenerateFormDependencies((string)tLflr2Gt05Va6TifSE5V(buttonViewItem), _003C_003Ec__DisplayClass4_2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.objectUid, _003C_003Ec__DisplayClass4_2.dependFormUid, _003C_003Ec__DisplayClass4_2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.deps);
													num5 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
													{
														num5 = 1;
													}
													continue;
												case 2:
													if (!type.IsInheritOrSame<ButtonViewItem>())
													{
														num5 = 8;
														continue;
													}
													goto case 5;
												case 13:
													if (viewItemTransformationAdd != null)
													{
														int num6 = 9;
														num5 = num6;
														continue;
													}
													goto case 7;
												case 15:
													if (!x0EY7KGtxB05KCf3EGUW(e8dghMGtAdVRu4UvSh3h(buttonViewItem), ORsHhXGt75TFynGmxWFG(-1334993905 ^ -1334870737)))
													{
														num5 = 11;
														continue;
													}
													goto case 20;
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
										((IDisposable)enumerator2).Dispose();
										int num7 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
										{
											num7 = 0;
										}
										switch (num7)
										{
										case 0:
											break;
										}
									}
									goto IL_076e;
								case 14:
									_003C_003Ec__DisplayClass4_2.dependType = FormDependencyDataType.Child;
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
									{
										num3 = 1;
									}
									continue;
								case 10:
									_003C_003Ec__DisplayClass4_2.dependType = FormDependencyDataType.Inherit;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
									{
										num3 = 0;
									}
									continue;
								case 1:
									_003C_003Ec__DisplayClass4_2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.deps.Add(new FormDependencyData(_003C_003Ec__DisplayClass4_2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.objectUid, _003C_003Ec__DisplayClass4_2.dependFormUid, _003C_003Ec__DisplayClass4_2.CS_0024_003C_003E8__locals2.CS_0024_003C_003E8__locals1.objectUid, _003C_003Ec__DisplayClass4_2.CS_0024_003C_003E8__locals2.t.Uid, _003C_003Ec__DisplayClass4_2.dependType));
									num3 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
									{
										num3 = 6;
									}
									continue;
								case 11:
									_003C_003Ec__DisplayClass4_.t = enumerator.Current;
									num4 = 2;
									goto IL_01b7;
								case 7:
									_003C_003Ec__DisplayClass4_2.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass4_;
									num3 = 3;
									continue;
								case 8:
									list.ForEach(_003C_003Ec__DisplayClass4_2._003CGenerateNewDependencies_003Eb__4);
									num3 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
									{
										num3 = 1;
									}
									continue;
								case 15:
									goto IL_076e;
								case 2:
									_003C_003Ec__DisplayClass4_2 = new _003C_003Ec__DisplayClass4_3();
									num3 = 7;
									continue;
								case 5:
									goto end_IL_076e;
									IL_01b7:
									num3 = num4;
									continue;
								}
								break;
							}
							goto IL_0287;
							continue;
							end_IL_076e:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 16;
				case 17:
					if (HvOOOOGtDO9WFKXAOv18(entityMetadata) == EntityMetadataType.InterfaceExtension)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				case 15:
					try
					{
						while (true)
						{
							IL_08ac:
							int num9;
							if (!enumerator.MoveNext())
							{
								num9 = 4;
								goto IL_0839;
							}
							goto IL_0873;
							IL_0839:
							while (true)
							{
								switch (num9)
								{
								case 1:
									list2.Add(_003C_003Ec__DisplayClass4_4.t);
									num9 = 2;
									continue;
								case 5:
									_003C_003Ec__DisplayClass4_4.t = enumerator.Current;
									num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
									{
										num9 = 3;
									}
									continue;
								case 2:
									goto IL_08ac;
								case 3:
									if (!list2.Any(_003C_003Ec__DisplayClass4_4._003CGenerateNewDependencies_003Eb__2))
									{
										num9 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
										{
											num9 = 1;
										}
										continue;
									}
									goto IL_08ac;
								case 4:
									goto end_IL_08ac;
								}
								break;
							}
							goto IL_0873;
							IL_0873:
							_003C_003Ec__DisplayClass4_4 = new _003C_003Ec__DisplayClass4_1();
							num9 = 5;
							goto IL_0839;
							continue;
							end_IL_08ac:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num10 = 0;
						}
						switch (num10)
						{
						case 0:
							break;
						}
					}
					goto case 6;
				case 0:
					return;
				case 14:
					list = new List<Guid>();
					num = 8;
					break;
				case 13:
					return;
				case 2:
					enumerator = entityMetadata2.FormTransformations.GetEnumerator();
					num2 = 15;
					continue;
				case 16:
					entityMetadata.Forms.ForEach(_003C_003Ec__DisplayClass4_3._003CGenerateNewDependencies_003Eb__0);
					num = 11;
					break;
				case 22:
					if (entityMetadata2 == null)
					{
						num2 = 12;
						continue;
					}
					goto case 7;
				case 5:
					if (!AlcxXyGtwa7E3e2tpCF5(metadataRuntimeService.GetTypeByUidOrNull(xyV7rNGttohHDK9LejNO(entityMetadata), loadImplementation: false), null))
					{
						_003C_003Ec__DisplayClass4_3.objectUid = yURfTeGt4vbyDoux876x(entityMetadata);
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
						{
							num2 = 4;
						}
					}
					else
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 13;
						}
					}
					continue;
				case 7:
					list.AddRange(from q in MetadataLoader.GetBaseClassMetadataList(entityMetadata2, includeExtensions: false, loadImplementation: false)
						select q.Uid);
					num2 = 2;
					continue;
				case 10:
					list.AddRange(from q in MetadataLoader.GetBaseClassMetadataList(entityMetadata, includeExtensions: false, loadImplementation: false)
						select _003C_003Ec.dhFkwv8oNhMimQtWj7cr(q));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	public IEnumerable<Guid> GetFormUids(Guid uid)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.result = new List<Guid>();
		CS_0024_003C_003E8__locals0.cMd = metadataRuntimeService.GetMetadata(uid, loadImplementation: false) as ClassMetadata;
		if (CS_0024_003C_003E8__locals0.cMd == null)
		{
			return CS_0024_003C_003E8__locals0.result;
		}
		CS_0024_003C_003E8__locals0.cMd.Forms.ForEach(delegate(FormViewItem q)
		{
			int num9 = 1;
			int num10 = num9;
			while (true)
			{
				switch (num10)
				{
				default:
					return;
				case 1:
					CS_0024_003C_003E8__locals0.result.Add(_003C_003Ec__DisplayClass5_0.lNPc018otDkCdaLybJjE(q));
					num10 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num10 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		CS_0024_003C_003E8__locals0.cMd.FormTransformations.ForEach(delegate(FormViewItemTransformation q)
		{
			int num7 = 1;
			int num8 = num7;
			while (true)
			{
				switch (num8)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					CS_0024_003C_003E8__locals0.result.Add(_003C_003Ec__DisplayClass5_0.nAM7kv8o4QygKLxSv58u(_003C_003Ec__DisplayClass5_0.baaP8g8owqCUx49hyEXc(q), Guid.Empty) ? _003C_003Ec__DisplayClass5_0.baaP8g8owqCUx49hyEXc(q) : q.Uid);
					num8 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num8 = 0;
					}
					break;
				}
			}
		});
		EntityMetadata entityMetadata = metadataRuntimeService.GetMetadataList().OfType<EntityMetadata>().FirstOrDefault(delegate(EntityMetadata q)
		{
			int num5 = 2;
			int num6 = num5;
			while (true)
			{
				switch (num6)
				{
				case 1:
					if (q.Type == EntityMetadataType.InterfaceExtension)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num6 = 0;
						}
						break;
					}
					goto IL_007a;
				default:
					return _003C_003Ec__DisplayClass5_0.micbn28oxLIR8SHkHyNu(_003C_003Ec__DisplayClass5_0.cLCQ9c8o7FMAowfEjhpq(q), (string)_003C_003Ec__DisplayClass5_0.cLCQ9c8o7FMAowfEjhpq(CS_0024_003C_003E8__locals0.cMd) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4F2B9B));
				case 2:
					{
						if (_003C_003Ec__DisplayClass5_0.WK1qx78oA6mLSUVMDYlU(_003C_003Ec__DisplayClass5_0.jmLVWr8o6YLdvUUDBJDY(q), _003C_003Ec__DisplayClass5_0.lQt86N8oHBJarWpfCAnB(CS_0024_003C_003E8__locals0.cMd)))
						{
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
							{
								num6 = 1;
							}
							break;
						}
						goto IL_007a;
					}
					IL_007a:
					return false;
				}
			}
		});
		if (entityMetadata == null)
		{
			return CS_0024_003C_003E8__locals0.result;
		}
		entityMetadata.Forms.ForEach(delegate(FormViewItem q)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					CS_0024_003C_003E8__locals0.result.Add(_003C_003Ec__DisplayClass5_0.lNPc018otDkCdaLybJjE(q));
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		});
		entityMetadata.FormTransformations.ForEach(delegate(FormViewItemTransformation q)
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
					CS_0024_003C_003E8__locals0.result.Add(_003C_003Ec__DisplayClass5_0.nAM7kv8o4QygKLxSv58u(_003C_003Ec__DisplayClass5_0.baaP8g8owqCUx49hyEXc(q), Guid.Empty) ? _003C_003Ec__DisplayClass5_0.baaP8g8owqCUx49hyEXc(q) : q.Uid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
		return CS_0024_003C_003E8__locals0.result;
	}

	public IEnumerable<IFormDependencyData> GetDependenciesForBaseClasses(Guid dependObjectUid, Guid dependObjectFormUid, IMetadata usesObjectMetadata, Guid usesObjectFormUid, FormDependencyDataType type)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		CS_0024_003C_003E8__locals0.dependObjectUid = dependObjectUid;
		CS_0024_003C_003E8__locals0.dependObjectFormUid = dependObjectFormUid;
		CS_0024_003C_003E8__locals0.usesObjectFormUid = usesObjectFormUid;
		CS_0024_003C_003E8__locals0.type = type;
		if (!(usesObjectMetadata is ClassMetadata metadata))
		{
			return new List<IFormDependencyData>();
		}
		return from q in MetadataLoader.GetBaseClassMetadataList(metadata, includeExtensions: false, loadImplementation: false)
			select new FormDependencyData(CS_0024_003C_003E8__locals0.dependObjectUid, CS_0024_003C_003E8__locals0.dependObjectFormUid, _003C_003Ec__DisplayClass6_0.U6483n8oJGdQLBvy41Fc(q), CS_0024_003C_003E8__locals0.usesObjectFormUid, CS_0024_003C_003E8__locals0.type);
	}

	public IEnumerable<IFormDependencyData> GetDependenciesForBaseClasses(Guid dependObjectUid, Guid dependObjectFormUid, Guid usesObjectUid, Guid usesObjectFormUid, FormDependencyDataType type)
	{
		IMetadata metadata = metadataRuntimeService.GetMetadata(usesObjectUid, loadImplementation: false);
		return GetDependenciesForBaseClasses(dependObjectUid, dependObjectFormUid, metadata, usesObjectFormUid, type);
	}

	public bool ExistForm(Guid objectUid, Guid formUid)
	{
		//Discarded unreachable code: IL_00c4, IL_0126, IL_0194, IL_01a3, IL_01f1, IL_021b, IL_0253, IL_0280, IL_02d0, IL_02e0, IL_0336, IL_03d1, IL_03e0, IL_03f0
		int num = 11;
		EntityMetadata entityMetadata = default(EntityMetadata);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		ViewType viewType = default(ViewType);
		bool flag = default(bool);
		bool result = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				int num3;
				switch (num2)
				{
				case 14:
					if (entityMetadata.Forms.Any(_003C_003Ec__DisplayClass8_._003CExistForm_003Eb__3))
					{
						num = 18;
						break;
					}
					goto case 1;
				case 6:
					if (entityMetadata == null)
					{
						num2 = 7;
						continue;
					}
					goto case 19;
				case 10:
					_003C_003Ec__DisplayClass8_.formUid = formUid;
					num2 = 16;
					continue;
				case 13:
					if (viewType != ViewType.All)
					{
						num2 = 3;
						continue;
					}
					if (!_003C_003Ec__DisplayClass8_.eMd.Forms.Any(_003C_003Ec__DisplayClass8_._003CExistForm_003Eb__1))
					{
						num2 = 12;
						continue;
					}
					num4 = 1;
					goto IL_03fb;
				case 20:
					if (flag)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 6;
				case 16:
					try
					{
						_003C_003Ec__DisplayClass8_.eMd = metadataRuntimeService.GetMetadata(objectUid, loadImplementation: false) as EntityMetadata;
						int num5 = 3;
						while (true)
						{
							switch (num5)
							{
							case 3:
								if (_003C_003Ec__DisplayClass8_.eMd != null)
								{
									num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
									{
										num5 = 2;
									}
									continue;
								}
								goto case 4;
							case 4:
								result = false;
								num5 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
								{
									num5 = 5;
								}
								continue;
							case 1:
							case 2:
								entityMetadata = metadataRuntimeService.GetMetadataList().OfType<EntityMetadata>().FirstOrDefault(_003C_003Ec__DisplayClass8_._003CExistForm_003Eb__0);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
								{
									num5 = 0;
								}
								continue;
							case 0:
								break;
							case 5:
								return result;
							}
							break;
						}
					}
					catch (Exception)
					{
						int num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num6 = 1;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								result = false;
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
								{
									num6 = 0;
								}
								break;
							default:
								return result;
							case 0:
								return result;
							}
						}
					}
					goto case 9;
				case 12:
					num4 = (_003C_003Ec__DisplayClass8_.eMd.FormTransformations.Any(_003C_003Ec__DisplayClass8_._003CExistForm_003Eb__2) ? 1 : 0);
					goto IL_03fb;
				case 3:
					flag = NJcdfoGt6qrjgEchMNUU(KBBw3cGtrp27XsNTAIgN(Ycv9WwGtlHOMumwKnGnk(_003C_003Ec__DisplayClass8_.eMd), viewType), Guid.Empty);
					num = 20;
					break;
				case 1:
					num3 = (entityMetadata.FormTransformations.Any(_003C_003Ec__DisplayClass8_._003CExistForm_003Eb__4) ? 1 : 0);
					goto IL_0418;
				case 4:
				case 8:
				case 15:
					return flag;
				case 11:
					_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					num2 = 10;
					continue;
				default:
					if (flag)
					{
						num2 = 4;
						continue;
					}
					goto case 17;
				case 17:
					if (entityMetadata == null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 14;
				case 19:
					flag = NJcdfoGt6qrjgEchMNUU(KBBw3cGtrp27XsNTAIgN(Ycv9WwGtlHOMumwKnGnk(entityMetadata), viewType), Guid.Empty);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
				case 5:
				case 7:
					return flag;
				case 9:
					viewType = FormDependencyHelper.GuidToViewType(_003C_003Ec__DisplayClass8_.formUid);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 11;
					}
					continue;
				case 18:
					{
						num3 = 1;
						goto IL_0418;
					}
					IL_0418:
					flag = (byte)num3 != 0;
					num2 = 15;
					continue;
					IL_03fb:
					flag = (byte)num4 != 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static bool lbdGSdGtNHU1AcOyrTf8()
	{
		return b7ApDiGt1gFdYOBOuTpM == null;
	}

	internal static EntityFormDependencyExtension aJAErpGt3XEkhZ4YL3eL()
	{
		return b7ApDiGt1gFdYOBOuTpM;
	}

	internal static object bHYPKnGtpkN1NSk8MEXa()
	{
		return Logger.Log;
	}

	internal static void swm4FPGtaBlK54xMc56M(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static EntityMetadataType HvOOOOGtDO9WFKXAOv18(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid xyV7rNGttohHDK9LejNO(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool AlcxXyGtwa7E3e2tpCF5(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid yURfTeGt4vbyDoux876x(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool NJcdfoGt6qrjgEchMNUU(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object xn2iF0GtHqhJKTCFjC8q(object P_0)
	{
		return ((ViewItemTransformationAdd)P_0).Item;
	}

	internal static object e8dghMGtAdVRu4UvSh3h(object P_0)
	{
		return ((ButtonViewItem)P_0).ActionTypeProviderId;
	}

	internal static object ORsHhXGt75TFynGmxWFG(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool x0EY7KGtxB05KCf3EGUW(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object tLflr2Gt05Va6TifSE5V(object P_0)
	{
		return ((ButtonViewItem)P_0).ActionId;
	}

	internal static object XdFSYAGtmUg9TSivVIx8(object P_0)
	{
		return ((ViewItemTransformationChange)P_0).PropertyName;
	}

	internal static object qpYolcGtyTvnmXgEvqEj(object P_0)
	{
		return ((ViewItemTransformationChange)P_0).TypeName;
	}

	internal static bool wWrpX3GtMUicGOW5RIPV(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static Type k43MtyGtJ2AcPG73meFm(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static bool RWmbadGt9VZUYtQ75w9S(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object KjYOdYGtdQEq0iLdyjpK(object P_0)
	{
		return ((List<IFormDependencyData>)P_0).ToArray();
	}

	internal static object Ycv9WwGtlHOMumwKnGnk(object P_0)
	{
		return ((ClassMetadata)P_0).DefaultForms;
	}

	internal static Guid KBBw3cGtrp27XsNTAIgN(object P_0, ViewType viewType)
	{
		return ((ClassDefaultForms)P_0).GetFormUid(viewType);
	}
}
