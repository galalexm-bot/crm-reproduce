using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.FullTextSearch.Components;

[Component]
internal sealed class FullTextMetadataPublishFinishedEventHandler : IMetadataPublishFinishedEventHandler, IEventHandler
{
	private FullTextSearchSettingsModule fullTextSearchSettingsModule;

	private IEnumerable<IModuleFullTextSearchExtension> moduleFullTextSearchExtensions;

	private IEnumerable<IFullTextSearchMappingProvider> fullTextSearchMappingProvider;

	internal static FullTextMetadataPublishFinishedEventHandler MslGLSGVQHI3Op0udtJa;

	private IFullTextSearchMappingProvider Provider
	{
		get
		{
			//Discarded unreachable code: IL_0039, IL_0048
			int num = 3;
			int num2 = num;
			_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
			while (true)
			{
				switch (num2)
				{
				default:
					return fullTextSearchMappingProvider.FirstOrDefault(_003C_003Ec__DisplayClass5_._003Cget_Provider_003Eb__0);
				case 3:
					_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					if (fullTextSearchSettingsModule.Settings == null)
					{
						num2 = 4;
						break;
					}
					goto case 1;
				case 1:
					_003C_003Ec__DisplayClass5_.providerUid = fullTextSearchSettingsModule.Settings.ProviderUid;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					_003C_003Ec__DisplayClass5_.providerUid = default(Guid);
					num2 = 5;
					break;
				}
			}
		}
	}

	public FullTextMetadataPublishFinishedEventHandler(FullTextSearchSettingsModule fullTextSearchSettingsModule, IEnumerable<IModuleFullTextSearchExtension> moduleFullTextSearchExtensions, IEnumerable<IFullTextSearchMappingProvider> fullTextSearchMappingProvider)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.fullTextSearchSettingsModule = fullTextSearchSettingsModule;
		this.moduleFullTextSearchExtensions = moduleFullTextSearchExtensions;
		this.fullTextSearchMappingProvider = fullTextSearchMappingProvider;
	}

	public void PublishExecuted(MetadataPublishedEventArgs e)
	{
		//Discarded unreachable code: IL_0054, IL_0063, IL_006e, IL_00bc, IL_00cb, IL_014d, IL_0160, IL_022b, IL_026b, IL_027a, IL_0286, IL_02f0, IL_0328, IL_0337
		int num = 1;
		int num2 = num;
		List<Type> list = default(List<Type>);
		IEnumerator<ClassMetadata> enumerator = default(IEnumerator<ClassMetadata>);
		ClassMetadata current = default(ClassMetadata);
		IEnumerator<IModuleFullTextSearchExtension> enumerator2 = default(IEnumerator<IModuleFullTextSearchExtension>);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				list = new List<Type>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
							{
								num3 = 0;
							}
							goto IL_0072;
						}
						goto IL_0290;
						IL_0290:
						current = enumerator.Current;
						num3 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num3 = 4;
						}
						goto IL_0072;
						IL_0072:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 2:
								break;
							case 3:
								try
								{
									while (true)
									{
										int num4;
										if (!ncbBB2GVVQgynkQQCFqZ(enumerator2))
										{
											num4 = 2;
											goto IL_00da;
										}
										goto IL_0180;
										IL_00da:
										while (true)
										{
											switch (num4)
											{
											case 8:
												if (!MTtY8FGVug3uZhNX7Hhb(type, null))
												{
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
													{
														num4 = 1;
													}
													continue;
												}
												goto case 7;
											case 9:
												if (Provider != null)
												{
													num4 = 3;
													continue;
												}
												break;
											case 4:
												goto IL_0180;
											case 3:
											{
												x1RTm4GVI8jnueqEqTL6(Provider, type);
												int num5 = 6;
												num4 = num5;
												continue;
											}
											case 5:
												list.Add(type);
												num4 = 9;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
												{
													num4 = 2;
												}
												continue;
											case 7:
												if (list.Contains(type))
												{
													num4 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
													{
														num4 = 0;
													}
													continue;
												}
												goto case 5;
											case 2:
												goto end_IL_016a;
											}
											break;
										}
										continue;
										IL_0180:
										type = JD5AMHGVZ5NPOLNFXjfW(enumerator2.Current, DRdkIeGV8FRrnSCD2Itj(current));
										num4 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
										{
											num4 = 8;
										}
										goto IL_00da;
										continue;
										end_IL_016a:
										break;
									}
								}
								finally
								{
									int num6;
									if (enumerator2 == null)
									{
										num6 = 2;
										goto IL_022f;
									}
									goto IL_0245;
									IL_022f:
									switch (num6)
									{
									default:
										goto end_IL_021a;
									case 1:
										break;
									case 2:
										goto end_IL_021a;
									case 0:
										goto end_IL_021a;
									}
									goto IL_0245;
									IL_0245:
									enumerator2.Dispose();
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
									{
										num6 = 0;
									}
									goto IL_022f;
									end_IL_021a:;
								}
								break;
							case 1:
								goto IL_0290;
							case 4:
								enumerator2 = moduleFullTextSearchExtensions.GetEnumerator();
								num3 = 3;
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num7 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
						{
							num7 = 0;
						}
						while (true)
						{
							switch (num7)
							{
							case 1:
								uVjMMsGVSKPP6dQeGBp7(enumerator);
								num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
								{
									num7 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			default:
				enumerator = e.DeltaPublishedMetadata.OfType<ClassMetadata>().GetEnumerator();
				num2 = 3;
				break;
			}
		}
	}

	internal static bool PJwfCKGVCKOxIjDXaqdJ()
	{
		return MslGLSGVQHI3Op0udtJa == null;
	}

	internal static FullTextMetadataPublishFinishedEventHandler l8D3F3GVvsBunj32VkhU()
	{
		return MslGLSGVQHI3Op0udtJa;
	}

	internal static Guid DRdkIeGV8FRrnSCD2Itj(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static Type JD5AMHGVZ5NPOLNFXjfW(object P_0, Guid objectTypeUid)
	{
		return ((IModuleFullTextSearchExtension)P_0).GetSupportedCardTypeByTypeUid(objectTypeUid);
	}

	internal static bool MTtY8FGVug3uZhNX7Hhb(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static void x1RTm4GVI8jnueqEqTL6(object P_0, Type cardType)
	{
		((IFullTextSearchMappingProvider)P_0).UpdateMapping(cardType);
	}

	internal static bool ncbBB2GVVQgynkQQCFqZ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void uVjMMsGVSKPP6dQeGBp7(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
