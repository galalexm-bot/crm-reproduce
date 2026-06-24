using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Transformations;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Components;

[Component]
internal sealed class EntityMetadataPublicationHandler : IPublicationHandler
{
	private readonly IEntityMetadataDependencyService entityMetadataDependencyService;

	private readonly IActorContextService actorContextService;

	private static EntityMetadataPublicationHandler eGYVdyfbdMB7vbjUvTgN;

	public EntityMetadataPublicationHandler(IEntityMetadataDependencyService entityMetadataDependencyService, IActorContextService actorContextService)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		LMbB40fbgQacXCMksrG1();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				this.actorContextService = actorContextService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			case 2:
				this.entityMetadataDependencyService = entityMetadataDependencyService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void UpdateMetadata(IMetadata metadata)
	{
		//Discarded unreachable code: IL_005a, IL_00eb, IL_0128, IL_0137, IL_0159, IL_0163, IL_01fc, IL_020f, IL_021e, IL_02dc, IL_02ef, IL_02fe, IL_030f, IL_031e, IL_0329, IL_0396, IL_03a0, IL_0400, IL_040a, IL_04a3, IL_04b6, IL_04c5, IL_04d4, IL_04fc, IL_050b, IL_0628, IL_0637, IL_072a, IL_0739, IL_0778, IL_0833, IL_0842, IL_0865, IL_0874, IL_0899, IL_08a8, IL_0a1b, IL_0a2e, IL_0ad9, IL_0aec, IL_0afb, IL_0b5b, IL_0b6e, IL_0b7d, IL_0bc7, IL_0bd1, IL_0c23, IL_0c32, IL_0c3d, IL_0ca4, IL_0cb3, IL_0cbe, IL_0d47, IL_0d5a, IL_0d8a, IL_0dba, IL_0dc9, IL_0dd5, IL_0e64, IL_0e77, IL_0e86, IL_0e95
		int num = 11;
		EntityMetadata entityMetadata = default(EntityMetadata);
		List<FormViewItem> list = default(List<FormViewItem>);
		List<FormViewItem>.Enumerator enumerator = default(List<FormViewItem>.Enumerator);
		List<PropertyMetadata>.Enumerator enumerator7 = default(List<PropertyMetadata>.Enumerator);
		IViewModelPropertyMetadata viewModelPropertyMetadata = default(IViewModelPropertyMetadata);
		List<ComputedValue>.Enumerator enumerator3 = default(List<ComputedValue>.Enumerator);
		List<FormViewItemTransformation>.Enumerator enumerator4 = default(List<FormViewItemTransformation>.Enumerator);
		List<ViewItemTransformation>.Enumerator enumerator5 = default(List<ViewItemTransformation>.Enumerator);
		FormViewItemTransformation current4 = default(FormViewItemTransformation);
		List<FormViewItemTransformation> list3 = default(List<FormViewItemTransformation>);
		ComputedValueTransformation computedValueTransformation = default(ComputedValueTransformation);
		List<BaseTransformation<ComputedValue, string>> list2 = default(List<BaseTransformation<ComputedValue, string>>);
		ViewItemTransformationChange viewItemTransformationChange = default(ViewItemTransformationChange);
		ViewItemTransformation current3 = default(ViewItemTransformation);
		List<BaseTransformation<ComputedValue, string>>.Enumerator enumerator6 = default(List<BaseTransformation<ComputedValue, string>>.Enumerator);
		ViewItemTransformationAdd viewItemTransformationAdd = default(ViewItemTransformationAdd);
		ComputedValueTransformationChange computedValueTransformationChange = default(ComputedValueTransformationChange);
		string text2 = default(string);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		_003C_003Ec__DisplayClass3_1 _003C_003Ec__DisplayClass3_2 = default(_003C_003Ec__DisplayClass3_1);
		ComputedValueTransformationChange computedValueTransformationChange3 = default(ComputedValueTransformationChange);
		string text = default(string);
		ComputedValueTransformationAdd computedValueTransformationAdd = default(ComputedValueTransformationAdd);
		BaseTransformation<ComputedValue, string> current2 = default(BaseTransformation<ComputedValue, string>);
		ComputedValueType computedValueType = default(ComputedValueType);
		object value = default(object);
		ComputedValueTransformationChange computedValueTransformationChange2 = default(ComputedValueTransformationChange);
		FormViewItem current = default(FormViewItem);
		IEnumerator<ViewItem> enumerator2 = default(IEnumerator<ViewItem>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj3;
				switch (num2)
				{
				case 9:
					obj3 = null;
					break;
				case 10:
					if (entityMetadata == null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					obj3 = entityMetadata.ViewModelMetadata;
					break;
				case 6:
					return;
				case 8:
				{
					List<FormViewItem> forms = entityMetadata.Forms;
					list = new List<FormViewItem>(forms.Count);
					enumerator = forms.GetEnumerator();
					num2 = 12;
					continue;
				}
				case 5:
					BsK2ALfhfOeFAHhT723h(entityMetadata);
					num2 = 6;
					continue;
				case 2:
					return;
				default:
					enumerator7 = ((ClassMetadata)jUvWshfb5TguUTfs4Uw1(entityMetadata)).Properties.GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							int num19;
							if (!enumerator7.MoveNext())
							{
								int num18 = 7;
								num19 = num18;
								goto IL_00f9;
							}
							goto IL_025b;
							IL_00f9:
							while (true)
							{
								switch (num19)
								{
								case 3:
									if (viewModelPropertyMetadata == null)
									{
										num19 = 4;
										continue;
									}
									goto default;
								case 2:
									try
									{
										while (true)
										{
											int num20;
											if (!enumerator3.MoveNext())
											{
												num20 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
												{
													num20 = 0;
												}
												goto IL_0167;
											}
											goto IL_017d;
											IL_017d:
											GBjRKtfbLmstDEJnUToW(enumerator3.Current, xw5RKtfbYgIYNZSCTyyP(entityMetadata));
											num20 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
											{
												num20 = 0;
											}
											goto IL_0167;
											IL_0167:
											switch (num20)
											{
											case 2:
												goto IL_017d;
											case 1:
												continue;
											case 0:
												break;
											}
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator3).Dispose();
										int num21 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
										{
											num21 = 0;
										}
										switch (num21)
										{
										case 0:
											break;
										}
									}
									break;
								case 1:
								case 4:
									break;
								case 6:
									enumerator3 = viewModelPropertyMetadata.ComputedValues.GetEnumerator();
									num19 = 2;
									continue;
								case 5:
									goto IL_025b;
								default:
									GBjRKtfbLmstDEJnUToW(jNhqJhfbjNq2gNpOY6oV(viewModelPropertyMetadata), xw5RKtfbYgIYNZSCTyyP(entityMetadata));
									num19 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
									{
										num19 = 6;
									}
									continue;
								case 7:
									goto end_IL_0229;
								}
								break;
							}
							continue;
							IL_025b:
							viewModelPropertyMetadata = enumerator7.Current as IViewModelPropertyMetadata;
							num19 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
							{
								num19 = 3;
							}
							goto IL_00f9;
							continue;
							end_IL_0229:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator7).Dispose();
						int num22 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num22 = 0;
						}
						switch (num22)
						{
						case 0:
							break;
						}
					}
					goto case 7;
				case 13:
					try
					{
						while (true)
						{
							IL_0b19:
							int num9;
							if (!enumerator4.MoveNext())
							{
								num9 = 3;
								goto IL_032d;
							}
							goto IL_0b06;
							IL_032d:
							while (true)
							{
								switch (num9)
								{
								case 2:
									enumerator5 = current4.Items.GetEnumerator();
									num9 = 5;
									continue;
								default:
									list3.Add(ClassSerializationHelper.CloneObjectByXml(current4));
									num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
									{
										num9 = 0;
									}
									continue;
								case 5:
									try
									{
										while (true)
										{
											IL_060c:
											int num10;
											if (!enumerator5.MoveNext())
											{
												num10 = 16;
												goto IL_03a4;
											}
											goto IL_052e;
											IL_03a4:
											while (true)
											{
												object obj;
												switch (num10)
												{
												case 10:
													try
													{
														while (true)
														{
															int num14;
															if (!enumerator3.MoveNext())
															{
																num14 = 1;
																if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
																{
																	num14 = 1;
																}
																goto IL_040e;
															}
															goto IL_044a;
															IL_044a:
															GBjRKtfbLmstDEJnUToW(enumerator3.Current, xw5RKtfbYgIYNZSCTyyP(entityMetadata));
															num14 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
															{
																num14 = 0;
															}
															goto IL_040e;
															IL_040e:
															switch (num14)
															{
															case 2:
																goto IL_044a;
															case 1:
																goto end_IL_0424;
															}
															continue;
															end_IL_0424:
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator3).Dispose();
														int num15 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
														{
															num15 = 0;
														}
														switch (num15)
														{
														case 0:
															break;
														}
													}
													goto IL_060c;
												case 5:
													computedValueTransformation.Items.AddRange(list2);
													num10 = 11;
													continue;
												case 2:
												case 15:
													if ((viewItemTransformationChange = current3 as ViewItemTransformationChange) == null)
													{
														num10 = 9;
														continue;
													}
													goto case 6;
												case 13:
													break;
												case 12:
													enumerator6 = computedValueTransformation.Items.GetEnumerator();
													num10 = 4;
													continue;
												case 8:
													if ((viewItemTransformationAdd = current3 as ViewItemTransformationAdd) == null)
													{
														num10 = 2;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
														{
															num10 = 2;
														}
														continue;
													}
													goto case 1;
												case 7:
													if (computedValueTransformation != null)
													{
														num10 = 18;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
														{
															num10 = 5;
														}
														continue;
													}
													goto IL_060c;
												case 14:
													computedValueTransformation = eA6t0ufhB0g606i4X77L(viewItemTransformationChange) as ComputedValueTransformation;
													num10 = 7;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
													{
														num10 = 4;
													}
													continue;
												case 6:
													if (!gyUECNfhFCHmaxtTZ1rt(M72ScJfbc0CQOlS5te90(viewItemTransformationChange), E8J4mLfbzk6On3e4r29t(0x3630F361 ^ 0x363290B3)))
													{
														num10 = 14;
														continue;
													}
													goto IL_060c;
												case 3:
												case 9:
												case 11:
													goto IL_060c;
												case 4:
													try
													{
														while (true)
														{
															IL_0949:
															int num11;
															if (!enumerator6.MoveNext())
															{
																num11 = 21;
																goto IL_0646;
															}
															goto IL_084d;
															IL_0646:
															while (true)
															{
																int num12;
																switch (num11)
																{
																case 19:
																	if (computedValueTransformationChange == null)
																	{
																		num11 = 7;
																		continue;
																	}
																	goto case 18;
																case 3:
																	text2 = TY2HAifho5enDVVvt1bo(_003C_003Ec__DisplayClass3_.computedValueTransformationChange) as string;
																	num11 = 22;
																	continue;
																case 15:
																	_003C_003Ec__DisplayClass3_2.methodPropertyName = (string)E8J4mLfbzk6On3e4r29t(-1426094279 ^ -1426203349);
																	num11 = 4;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
																	{
																		num11 = 0;
																	}
																	continue;
																case 4:
																	if ((computedValueTransformationChange3 = computedValueTransformation.Items.Find(_003C_003Ec__DisplayClass3_2._003CUpdateMetadata_003Eb__1) as ComputedValueTransformationChange) != null)
																	{
																		num11 = 17;
																		continue;
																	}
																	goto case 13;
																case 17:
																	r3UKBhfhbde17fVRAJJH(computedValueTransformationChange3, text);
																	num11 = 2;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
																	{
																		num11 = 2;
																	}
																	continue;
																case 11:
																	if ((computedValueTransformationAdd = current2 as ComputedValueTransformationAdd) == null)
																	{
																		num11 = 22;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
																		{
																			num11 = 26;
																		}
																		continue;
																	}
																	goto case 9;
																case 18:
																	if (!gyUECNfhFCHmaxtTZ1rt(x0qg7IfhWyxGNHYfW7AL(_003C_003Ec__DisplayClass3_.computedValueTransformationChange), E8J4mLfbzk6On3e4r29t(0x1637C429 ^ 0x16359E03)))
																	{
																		num11 = 3;
																		continue;
																	}
																	goto IL_0949;
																case 10:
																	text = ComputedValueHelper.GenerateMethodName(text2, entityMetadata.Uid);
																	num12 = 15;
																	goto IL_0642;
																case 25:
																	if (computedValueType == ComputedValueType.CalculateScript)
																	{
																		num11 = 24;
																		continue;
																	}
																	goto IL_0949;
																case 1:
																	break;
																case 24:
																	_003C_003Ec__DisplayClass3_2 = new _003C_003Ec__DisplayClass3_1();
																	num12 = 6;
																	goto IL_0642;
																default:
																	computedValueType = (ComputedValueType)value;
																	num11 = 15;
																	if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
																	{
																		num11 = 25;
																	}
																	continue;
																case 9:
																	ComputedValueHelper.SetCalculateScriptMethodName(computedValueTransformationAdd.Item, xw5RKtfbYgIYNZSCTyyP(entityMetadata));
																	num11 = 14;
																	continue;
																case 22:
																	if (text2 == null)
																	{
																		goto IL_0949;
																	}
																	num12 = 16;
																	goto IL_0642;
																case 8:
																	_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
																	num11 = 11;
																	continue;
																case 13:
																	list2.Add(Transformation<ComputedValue, ComputedValueTransformation, string, string>.SetPropertyValue(_003C_003Ec__DisplayClass3_2.CS_0024_003C_003E8__locals1.computedValueTransformationChange.Uid, _003C_003Ec__DisplayClass3_2.methodPropertyName, text));
																	num11 = 20;
																	continue;
																case 2:
																case 5:
																case 7:
																case 14:
																case 20:
																case 23:
																	goto IL_0949;
																case 6:
																	_003C_003Ec__DisplayClass3_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass3_;
																	num11 = 10;
																	continue;
																case 16:
																	if ((computedValueTransformationChange2 = computedValueTransformation.Items.Find(_003C_003Ec__DisplayClass3_._003CUpdateMetadata_003Eb__0) as ComputedValueTransformationChange) == null)
																	{
																		num11 = 23;
																		continue;
																	}
																	goto case 12;
																case 12:
																	if (!((value = computedValueTransformationChange2.Value) is ComputedValueType))
																	{
																		num11 = 5;
																		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
																		{
																			num11 = 3;
																		}
																		continue;
																	}
																	goto default;
																case 26:
																case 27:
																	computedValueTransformationChange = (_003C_003Ec__DisplayClass3_.computedValueTransformationChange = current2 as ComputedValueTransformationChange);
																	num12 = 19;
																	goto IL_0642;
																case 21:
																	goto end_IL_0949;
																	IL_0642:
																	num11 = num12;
																	continue;
																}
																break;
															}
															goto IL_084d;
															IL_084d:
															current2 = enumerator6.Current;
															num11 = 8;
															goto IL_0646;
															continue;
															end_IL_0949:
															break;
														}
													}
													finally
													{
														((IDisposable)enumerator6).Dispose();
														int num13 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
														{
															num13 = 0;
														}
														switch (num13)
														{
														case 0:
															break;
														}
													}
													goto case 5;
												case 17:
													enumerator3 = ((ViewItem)Q5umeSfbspb4rFLyjrVj(viewItemTransformationAdd)).DynamicProperties.GetEnumerator();
													num10 = 10;
													continue;
												case 18:
													list2 = new List<BaseTransformation<ComputedValue, string>>();
													num10 = 12;
													continue;
												case 1:
												{
													object obj2 = Q5umeSfbspb4rFLyjrVj(viewItemTransformationAdd);
													if (obj2 == null)
													{
														num10 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
														{
															num10 = 0;
														}
														continue;
													}
													obj = ((ViewItem)obj2).DynamicProperties;
													goto IL_0a9e;
												}
												default:
													obj = null;
													goto IL_0a9e;
												case 16:
													goto end_IL_060c;
													IL_0a9e:
													if (obj == null)
													{
														num10 = 3;
														continue;
													}
													goto case 17;
												}
												break;
											}
											goto IL_052e;
											IL_052e:
											current3 = enumerator5.Current;
											num10 = 4;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
											{
												num10 = 8;
											}
											goto IL_03a4;
											continue;
											end_IL_060c:
											break;
										}
									}
									finally
									{
										((IDisposable)enumerator5).Dispose();
										int num16 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
										{
											num16 = 0;
										}
										switch (num16)
										{
										case 0:
											break;
										}
									}
									goto default;
								case 4:
									break;
								case 1:
									goto IL_0b19;
								case 3:
									goto end_IL_0b19;
								}
								break;
							}
							goto IL_0b06;
							IL_0b06:
							current4 = enumerator4.Current;
							num9 = 2;
							goto IL_032d;
							continue;
							end_IL_0b19:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator4).Dispose();
						int num17 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num17 = 0;
						}
						switch (num17)
						{
						case 0:
							break;
						}
					}
					goto end_IL_0012;
				case 11:
					entityMetadata = metadata as EntityMetadata;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 9;
					}
					continue;
				case 3:
					goto end_IL_0012;
				case 12:
					try
					{
						while (true)
						{
							IL_0bf7:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num3 = 0;
								}
								goto IL_0bd5;
							}
							goto IL_0e15;
							IL_0e15:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num3 = 1;
							}
							goto IL_0bd5;
							IL_0bd5:
							while (true)
							{
								switch (num3)
								{
								case 2:
									goto IL_0bf7;
								case 4:
									try
									{
										while (true)
										{
											int num4;
											if (!r93FGFfhhWR0Q1DgYXkF(enumerator2))
											{
												num4 = 3;
												goto IL_0c41;
											}
											goto IL_0c5b;
											IL_0c41:
											switch (num4)
											{
											case 1:
												break;
											case 2:
												continue;
											default:
												try
												{
													while (true)
													{
														int num5;
														if (!enumerator3.MoveNext())
														{
															num5 = 1;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
															{
																num5 = 1;
															}
															goto IL_0cc2;
														}
														goto IL_0cfe;
														IL_0cfe:
														GBjRKtfbLmstDEJnUToW(enumerator3.Current, xw5RKtfbYgIYNZSCTyyP(entityMetadata));
														num5 = 2;
														goto IL_0cc2;
														IL_0cc2:
														switch (num5)
														{
														case 2:
															break;
														default:
															goto IL_0cfe;
														case 1:
															goto end_IL_0cd8;
														}
														continue;
														end_IL_0cd8:
														break;
													}
												}
												finally
												{
													((IDisposable)enumerator3).Dispose();
													int num6 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
													{
														num6 = 0;
													}
													switch (num6)
													{
													case 0:
														break;
													}
												}
												continue;
											case 3:
												goto end_IL_0c88;
											}
											goto IL_0c5b;
											IL_0c5b:
											enumerator3 = enumerator2.Current.DynamicProperties.GetEnumerator();
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
											{
												num4 = 0;
											}
											goto IL_0c41;
											continue;
											end_IL_0c88:
											break;
										}
									}
									finally
									{
										int num7;
										if (enumerator2 == null)
										{
											num7 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
											{
												num7 = 0;
											}
											goto IL_0d8e;
										}
										goto IL_0da4;
										IL_0da4:
										OAM81ofhGCsyVuD0tB6B(enumerator2);
										num7 = 2;
										goto IL_0d8e;
										IL_0d8e:
										switch (num7)
										{
										default:
											goto end_IL_0d69;
										case 1:
											break;
										case 0:
											goto end_IL_0d69;
										case 2:
											goto end_IL_0d69;
										}
										goto IL_0da4;
										end_IL_0d69:;
									}
									goto case 5;
								case 1:
									enumerator2 = current.GetAllItems(ignoreHide: false).GetEnumerator();
									num3 = 4;
									continue;
								case 5:
									list.Add((FormViewItem)mj0A5SfhE5gyjteFCy7Z(current));
									num3 = 2;
									continue;
								case 3:
									goto IL_0e15;
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
						((IDisposable)enumerator).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 4;
				case 4:
					entityMetadata.Forms = list;
					num2 = 5;
					continue;
				case 7:
				{
					List<FormViewItemTransformation> formTransformations = entityMetadata.FormTransformations;
					list3 = new List<FormViewItemTransformation>(CWBPlrfbUEYOiaMIWy8O(formTransformations));
					enumerator4 = formTransformations.GetEnumerator();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 13;
					}
					continue;
				}
				}
				if (obj3 == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			entityMetadata.FormTransformations = list3;
			num = 8;
		}
	}

	internal static void UpdateIncludeList(EntityMetadata entityMetadata)
	{
		//Discarded unreachable code: IL_0164, IL_01e5, IL_01f4, IL_0204, IL_0213, IL_0282, IL_0291
		int num = 1;
		DataClassDependency signature = default(DataClassDependency);
		EntityMetadata entityMetadata3 = default(EntityMetadata);
		EntityMetadata entityMetadata2 = default(EntityMetadata);
		DataClassDependency signature2 = default(DataClassDependency);
		DataClassDependency signature3 = default(DataClassDependency);
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					((DataClassMetadata)jUvWshfb5TguUTfs4Uw1(entityMetadata)).IncludeList.Add(signature);
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 1;
					}
					continue;
				case 19:
					return;
				case 20:
					return;
				case 5:
					signature = ((DataClassMetadata)jUvWshfb5TguUTfs4Uw1(entityMetadata3)).GetSignature(simple: true);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
				case 11:
				case 15:
					if (jUvWshfb5TguUTfs4Uw1(entityMetadata2) == null)
					{
						num = 20;
						break;
					}
					goto case 18;
				case 6:
					if (MsSlOjfhvbYubM1ImLlQ(entityMetadata) == EntityMetadataType.InterfaceExtension)
					{
						num2 = 13;
						continue;
					}
					goto case 3;
				case 18:
					signature2 = entityMetadata2.ViewModelMetadata.GetSignature(simple: true);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 4;
					}
					continue;
				case 10:
					if (jUvWshfb5TguUTfs4Uw1(entityMetadata3) != null)
					{
						num2 = 5;
						continue;
					}
					goto case 17;
				case 12:
					signature3 = _003C_003Ec__DisplayClass4_.realBaseMetadata.ViewModelMetadata.GetSignature(simple: true);
					num = 4;
					break;
				case 8:
					if (entityMetadata3 == null)
					{
						num2 = 17;
						continue;
					}
					goto case 10;
				case 1:
					((DataClassMetadata)jUvWshfb5TguUTfs4Uw1(entityMetadata)).IncludeList.Clear();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
				case 21:
					if (jUvWshfb5TguUTfs4Uw1(_003C_003Ec__DisplayClass4_.realBaseMetadata) == null)
					{
						num2 = 3;
						continue;
					}
					goto case 12;
				case 4:
					((DataClassMetadata)jUvWshfb5TguUTfs4Uw1(entityMetadata)).IncludeList.Add(signature3);
					num2 = 11;
					continue;
				case 7:
					((DataClassMetadata)jUvWshfb5TguUTfs4Uw1(entityMetadata)).IncludeList.Add(signature2);
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 19;
					}
					continue;
				case 9:
					return;
				case 13:
					if (!(jRloVmfh8JO5a3FXtgXV(entityMetadata2) != Guid.Empty))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 16;
				default:
					if (!xjMUoYfhQxriY1UpjlCs(entityMetadata.BaseClassUid, Guid.Empty))
					{
						entityMetadata2 = (EntityMetadata)((IMetadataService)Nl1NihfhCnQkIYwotTNa()).GetMetadata(entityMetadata.BaseClassUid, loadImplementation: false);
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 1;
						}
					}
					else
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 9;
						}
					}
					continue;
				case 16:
					_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
					num2 = 14;
					continue;
				case 22:
					entityMetadata3 = MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>().FirstOrDefault(_003C_003Ec__DisplayClass4_._003CUpdateIncludeList_003Eb__0);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 8;
					}
					continue;
				case 14:
					_003C_003Ec__DisplayClass4_.realBaseMetadata = (EntityMetadata)MetadataServiceContext.Service.GetMetadata(entityMetadata2.BaseClassUid, loadImplementation: false);
					num2 = 22;
					continue;
				}
				break;
			}
		}
	}

	public void UpdateMetadataItem(IMetadataItem source, IMetadataItem destination)
	{
		//Discarded unreachable code: IL_007e, IL_00f1, IL_0100, IL_0110, IL_01e9, IL_01f8
		int num = 11;
		int num2 = num;
		ScriptModule scriptModule = default(ScriptModule);
		IMetadata metadata = default(IMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				scriptModule.ObjectUid = FdKWI7fhSgQh3rlxTCRS(metadata);
				num2 = 5;
				continue;
			case 7:
				obj = null;
				break;
			case 9:
			case 12:
				entityMetadata = MQmLurfhRjHMN3kVM2Y8(destination) as EntityMetadata;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
			case 10:
				VcCHJZfhic6U6y1lKvix(destination, null);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (entityMetadata != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 7;
			case 6:
				CollectDependencies(entityMetadata, destination);
				num2 = 13;
				continue;
			case 16:
				return;
			case 13:
				return;
			case 5:
				VcCHJZfhic6U6y1lKvix(destination, scriptModule);
				num2 = 12;
				continue;
			case 11:
				if (VOOC4hfhZJ4mxcHcpDne(source) == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 10;
					}
					continue;
				}
				goto default;
			default:
				scriptModule = CloneHelperBuilder.Create(source.ScriptModule).Clone();
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 8;
				}
				continue;
			case 15:
				if ((metadata = destination.Metadata as IMetadata) != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 5;
			case 8:
			{
				ScriptModule scriptModule2 = scriptModule;
				object obj2 = VOOC4hfhZJ4mxcHcpDne(destination);
				wIa63wfhVT3lArQU8VjB(scriptModule2, (obj2 != null) ? QrxXSyfhIysdM3haO23X(obj2) : GLh3TufhuYwxX5dYWdV9());
				num2 = 14;
				continue;
			}
			case 14:
				scriptModule.Id = ((Entity<long>)VOOC4hfhZJ4mxcHcpDne(destination))?.Id ?? 0;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 15;
				}
				continue;
			case 4:
				obj = jUvWshfb5TguUTfs4Uw1(entityMetadata);
				break;
			}
			if (obj != null)
			{
				rE5VkefhKPyrXELCDBLe(jUvWshfb5TguUTfs4Uw1(entityMetadata), TMalPvfhqrQbhKkMP3ob(E8J4mLfbzk6On3e4r29t(0x7E6E5A0B ^ 0x7E6B780D), destination.Header.Id));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 6;
				}
			}
			else
			{
				num2 = 16;
			}
		}
	}

	private void CollectDependencies(EntityMetadata metadata, IMetadataItem destination)
	{
		//Discarded unreachable code: IL_00db, IL_0113, IL_014b, IL_015a
		int num = 1;
		int num2 = num;
		ICollection<IMetadata> promisedMetadataDependencies = default(ICollection<IMetadata>);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		while (true)
		{
			switch (num2)
			{
			default:
				promisedMetadataDependencies = EntityMetadataDependencyService.GetPromisedMetadataDependencies(actorContextService);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				gMLZsXfhTL3dvGwFIP35(entityMetadataDependencyService, metadata, destination);
				num2 = 3;
				break;
			case 1:
			{
				if (!actorContextService.TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812006774), out var _))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			}
			case 6:
				try
				{
					gMLZsXfhTL3dvGwFIP35(entityMetadataDependencyService, metadata, destination);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					if (metadataServiceContext != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								OAM81ofhGCsyVuD0tB6B(metadataServiceContext);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
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
				}
			case 3:
				return;
			case 4:
				metadataServiceContext = MetadataServiceContext.Extend(promisedMetadataDependencies);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				if (HZiy8WfhXXtYJXZIe39R(promisedMetadataDependencies) > 0)
				{
					num2 = 4;
					break;
				}
				goto case 5;
			}
		}
	}

	internal static void LMbB40fbgQacXCMksrG1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool djgHWJfblrKr1YxSV97o()
	{
		return eGYVdyfbdMB7vbjUvTgN == null;
	}

	internal static EntityMetadataPublicationHandler FU9rISfbr7TQHQUrRJYb()
	{
		return eGYVdyfbdMB7vbjUvTgN;
	}

	internal static object jUvWshfb5TguUTfs4Uw1(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static object jNhqJhfbjNq2gNpOY6oV(object P_0)
	{
		return ((IViewModelPropertyMetadata)P_0).ComputedValue;
	}

	internal static Guid xw5RKtfbYgIYNZSCTyyP(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void GBjRKtfbLmstDEJnUToW(object P_0, Guid metadataUid)
	{
		ComputedValueHelper.SetCalculateScriptMethodName((IComputedValue)P_0, metadataUid);
	}

	internal static int CWBPlrfbUEYOiaMIWy8O(object P_0)
	{
		return ((List<FormViewItemTransformation>)P_0).Count;
	}

	internal static object Q5umeSfbspb4rFLyjrVj(object P_0)
	{
		return ((ViewItemTransformationAdd)P_0).Item;
	}

	internal static object M72ScJfbc0CQOlS5te90(object P_0)
	{
		return ((ViewItemTransformationChange)P_0).PropertyName;
	}

	internal static object E8J4mLfbzk6On3e4r29t(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool gyUECNfhFCHmaxtTZ1rt(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static object eA6t0ufhB0g606i4X77L(object P_0)
	{
		return ((ViewItemTransformationChange)P_0).Value;
	}

	internal static object x0qg7IfhWyxGNHYfW7AL(object P_0)
	{
		return ((TransformationChange<ComputedValue, ComputedValueTransformation, string, string>)P_0).PropertyName;
	}

	internal static object TY2HAifho5enDVVvt1bo(object P_0)
	{
		return ((TransformationChange<ComputedValue, ComputedValueTransformation, string, string>)P_0).Value;
	}

	internal static void r3UKBhfhbde17fVRAJJH(object P_0, object P_1)
	{
		((TransformationChange<ComputedValue, ComputedValueTransformation, string, string>)P_0).Value = P_1;
	}

	internal static bool r93FGFfhhWR0Q1DgYXkF(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void OAM81ofhGCsyVuD0tB6B(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object mj0A5SfhE5gyjteFCy7Z(object P_0)
	{
		return ((ViewItem)P_0).Clone();
	}

	internal static void BsK2ALfhfOeFAHhT723h(object P_0)
	{
		UpdateIncludeList((EntityMetadata)P_0);
	}

	internal static bool xjMUoYfhQxriY1UpjlCs(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object Nl1NihfhCnQkIYwotTNa()
	{
		return MetadataServiceContext.Service;
	}

	internal static EntityMetadataType MsSlOjfhvbYubM1ImLlQ(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static Guid jRloVmfh8JO5a3FXtgXV(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static object VOOC4hfhZJ4mxcHcpDne(object P_0)
	{
		return ((IMetadataItem)P_0).ScriptModule;
	}

	internal static Guid GLh3TufhuYwxX5dYWdV9()
	{
		return Guid.NewGuid();
	}

	internal static Guid QrxXSyfhIysdM3haO23X(object P_0)
	{
		return ((ScriptModule)P_0).Uid;
	}

	internal static void wIa63wfhVT3lArQU8VjB(object P_0, Guid value)
	{
		((ScriptModule)P_0).Uid = value;
	}

	internal static Guid FdKWI7fhSgQh3rlxTCRS(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static void VcCHJZfhic6U6y1lKvix(object P_0, object P_1)
	{
		((IMetadataItem)P_0).ScriptModule = (ScriptModule)P_1;
	}

	internal static object MQmLurfhRjHMN3kVM2Y8(object P_0)
	{
		return ((IMetadataItem)P_0).Metadata;
	}

	internal static object TMalPvfhqrQbhKkMP3ob(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static void rE5VkefhKPyrXELCDBLe(object P_0, object P_1)
	{
		((DataClassMetadata)P_0).TypeRef = (string)P_1;
	}

	internal static int HZiy8WfhXXtYJXZIe39R(object P_0)
	{
		return ((ICollection<IMetadata>)P_0).Count;
	}

	internal static void gMLZsXfhTL3dvGwFIP35(object P_0, object P_1, object P_2)
	{
		((IEntityMetadataDependencyService)P_0).CollectDependencies((EntityMetadata)P_1, (IMetadataItem)P_2);
	}
}
