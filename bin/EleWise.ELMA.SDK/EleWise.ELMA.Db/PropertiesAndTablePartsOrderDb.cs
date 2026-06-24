using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Runtime.Db;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Db;

internal class PropertiesAndTablePartsOrderDbStructure : DbStructureExtension
{
	internal static PropertiesAndTablePartsOrderDbStructure qmtLhvfF8YL0nOMK3CgF;

	public override Guid ProviderUid => Guid.Empty;

	internal void UpdatePropertiesAndTablePartsOrder()
	{
		//Discarded unreachable code: IL_0080, IL_008f, IL_010f, IL_011e, IL_017b, IL_0205, IL_0263, IL_0276, IL_034e, IL_0386, IL_0395
		int num = 3;
		int num2 = num;
		IEnumerable<IMetadataItem> enumerable = default(IEnumerable<IMetadataItem>);
		IEnumerator<IMetadataItem> enumerator = default(IEnumerator<IMetadataItem>);
		List<_003C_003Ef__AnonymousType0<int, IMetadata>>.Enumerator enumerator2 = default(List<_003C_003Ef__AnonymousType0<int, IMetadata>>.Enumerator);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		int num5 = default(int);
		IMetadata metadata = default(IMetadata);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			default:
				((MetadataItemManager)rOk5rafFRI4YIPYbHD4q()).Save(enumerable);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				enumerator = enumerable.GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_00ef:
						int num4;
						if (!RiVbyvfFSb0Id3YJTlL3(enumerator))
						{
							int num3 = 3;
							num4 = num3;
							goto IL_009e;
						}
						goto IL_00bc;
						IL_009e:
						while (true)
						{
							switch (num4)
							{
							case 4:
								goto IL_00ef;
							case 2:
								try
								{
									while (true)
									{
										int num6;
										if (!enumerator2.MoveNext())
										{
											num6 = 4;
											goto IL_012d;
										}
										goto IL_020f;
										IL_012d:
										while (true)
										{
											switch (num6)
											{
											case 7:
											{
												r1mtcffFISpDF3tuW3aM(propertyMetadata, num5);
												int num7 = 2;
												num6 = num7;
												continue;
											}
											case 9:
												if ((propertyMetadata = metadata as PropertyMetadata) != null)
												{
													num6 = 7;
													continue;
												}
												goto case 3;
											case 3:
												if ((tablePartMetadata = metadata as TablePartMetadata) == null)
												{
													num6 = 5;
													continue;
												}
												goto case 6;
											case 8:
												break;
											case 1:
											case 2:
											case 5:
												num5++;
												num6 = 8;
												continue;
											case 6:
												T5thIhfFV4Gdgp1gyKgM(tablePartMetadata, num5);
												num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
												{
													num6 = 1;
												}
												continue;
											default:
												goto IL_020f;
											case 4:
												goto end_IL_01b7;
											}
											break;
										}
										continue;
										IL_020f:
										metadata = enumerator2.Current.Metadata;
										num6 = 8;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
										{
											num6 = 9;
										}
										goto IL_012d;
										continue;
										end_IL_01b7:
										break;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num8 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
									{
										num8 = 0;
									}
									switch (num8)
									{
									case 0:
										break;
									}
								}
								goto IL_00ef;
							case 1:
							{
								var list = entityMetadata.Properties.Select((PropertyMetadata p) => new
								{
									Order = p.Order,
									Metadata = (IMetadata)p
								}).ToList();
								list.AddRange(entityMetadata.TableParts.Select((TablePartMetadata tp) => new
								{
									Order = tp.Order,
									Metadata = (IMetadata)tp
								}));
								list.Sort((po1, po2) => po1.Order.CompareTo(po2.Order));
								num5 = 1;
								enumerator2 = list.GetEnumerator();
								num4 = 2;
								continue;
							}
							case 3:
								goto end_IL_00ef;
							}
							break;
						}
						goto IL_00bc;
						IL_00bc:
						if ((entityMetadata = enumerator.Current.Metadata as EntityMetadata) == null)
						{
							continue;
						}
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
						{
							num4 = 1;
						}
						goto IL_009e;
						continue;
						end_IL_00ef:
						break;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num9 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num9 = 1;
						}
						while (true)
						{
							switch (num9)
							{
							case 1:
								OnUcygfFicdoOtqEDpew(enumerator);
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
								{
									num9 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				goto default;
			case 3:
				enumerable = MetadataItemManager.Instance.FindDraftItems();
				num2 = 2;
				break;
			}
		}
	}

	public PropertiesAndTablePartsOrderDbStructure()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		L7hJiHfFqNsxyumIFPjR();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void r1mtcffFISpDF3tuW3aM(object P_0, int value)
	{
		((PropertyMetadata)P_0).Order = value;
	}

	internal static void T5thIhfFV4Gdgp1gyKgM(object P_0, int value)
	{
		((TablePartMetadata)P_0).Order = value;
	}

	internal static bool RiVbyvfFSb0Id3YJTlL3(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void OnUcygfFicdoOtqEDpew(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object rOk5rafFRI4YIPYbHD4q()
	{
		return MetadataItemManager.Instance;
	}

	internal static bool GvxoBjfFZVGKDYCA59Hp()
	{
		return qmtLhvfF8YL0nOMK3CgF == null;
	}

	internal static PropertiesAndTablePartsOrderDbStructure mrNl3MfFuxUOTvVXhFJL()
	{
		return qmtLhvfF8YL0nOMK3CgF;
	}

	internal static void L7hJiHfFqNsxyumIFPjR()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
