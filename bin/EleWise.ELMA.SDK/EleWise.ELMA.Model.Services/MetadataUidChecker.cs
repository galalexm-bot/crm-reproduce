using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Services;

[Service(Type = ComponentType.Server)]
internal class MetadataUidChecker : IMetadataUidChecker
{
	private static MetadataUidChecker F6Y0ryb8CQYmyMY0TaWL;

	public bool AddUidIfNeeded(IEnumerable<IMetadata> metadata)
	{
		bool result = false;
		foreach (IMetadata metadatum in metadata)
		{
			if (AddUidIfNeeded(metadatum))
			{
				result = true;
			}
		}
		return result;
	}

	public bool AddUidIfNeeded(IEnumerable<IMetadataItem> metadataItems)
	{
		bool result = false;
		foreach (IMetadataItem metadataItem in metadataItems)
		{
			AbstractMetadata metadata = metadataItem.Metadata as AbstractMetadata;
			if (AddUidIfNeeded(metadata))
			{
				result = true;
			}
		}
		return result;
	}

	public bool AddUidIfNeeded(IMetadata metadata)
	{
		//Discarded unreachable code: IL_0058, IL_0067, IL_0141, IL_0150, IL_0161, IL_016f, IL_024a, IL_025d
		int num = 11;
		bool result = default(bool);
		TablePartMetadata tablePartMetadata = default(TablePartMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		List<TablePartMetadata>.Enumerator enumerator = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata current = default(TablePartMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					return result;
				case 11:
					result = false;
					num2 = 10;
					break;
				case 12:
					KQYxuHb8ZlmDgDGv8Ikl(tablePartMetadata);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 6;
					}
					break;
				case 4:
					if (entityMetadata != null)
					{
						num2 = 8;
						break;
					}
					goto case 9;
				case 10:
					tablePartMetadata = metadata as TablePartMetadata;
					num2 = 2;
					break;
				case 2:
					if (tablePartMetadata == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				case 6:
					result = true;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 2;
					}
					break;
				case 8:
					enumerator = entityMetadata.TableParts.GetEnumerator();
					num2 = 3;
					break;
				case 1:
				case 5:
				case 7:
					entityMetadata = metadata as EntityMetadata;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					try
					{
						while (true)
						{
							IL_01f8:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
								{
									num3 = 4;
								}
								goto IL_0173;
							}
							goto IL_01d5;
							IL_01d5:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
							{
								num3 = 0;
							}
							goto IL_0173;
							IL_0173:
							while (true)
							{
								switch (num3)
								{
								case 4:
									return result;
								case 1:
									if (AddUidIfNeeded(current))
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
										{
											num3 = 2;
										}
										continue;
									}
									goto IL_01f8;
								case 2:
									result = true;
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
									{
										num3 = 0;
									}
									continue;
								case 3:
									break;
								default:
									goto IL_01f8;
								}
								break;
							}
							goto IL_01d5;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				default:
					if (tablePartMetadata.Properties.Any((PropertyMetadata p1) => _003C_003Ec.tbod2OC2o60OAwad08b2(_003C_003Ec.JbA1knC2BoqE0IwvABRy(p1), _003C_003Ec.UujaJ4C2WWA8VaM2G8lu(-1487388570 ^ -1487392780))))
					{
						goto end_IL_0012;
					}
					goto case 12;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public MetadataUidChecker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Yyu6qhb8uf85qiTEnF0X();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object KQYxuHb8ZlmDgDGv8Ikl(object P_0)
	{
		return ((EntityMetadata)P_0).CreateUidProperty();
	}

	internal static bool yrJ9d6b8vTW9CVqm3k0s()
	{
		return F6Y0ryb8CQYmyMY0TaWL == null;
	}

	internal static MetadataUidChecker HXMTLYb88ymowL5nxIHL()
	{
		return F6Y0ryb8CQYmyMY0TaWL;
	}

	internal static void Yyu6qhb8uf85qiTEnF0X()
	{
		SingletonReader.PushGlobal();
	}
}
