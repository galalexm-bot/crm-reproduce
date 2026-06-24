using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services.Public;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.PublicService;

public class ProcessContextMetadataInfo : IPublicMetadataInfo
{
	private List<Guid> publishedPropertyUids;

	private readonly Guid processHeaderUid;

	private readonly string processName;

	private readonly string processDisplayName;

	private readonly Guid fullContextUid;

	private readonly Guid publishedContextUid;

	internal static ProcessContextMetadataInfo QMVKSXbWHpRhlfxUbbi;

	public Guid Uid => processHeaderUid;

	public Guid GroupUid => PublicMetadataProvider.ProcessesGroupInfo.UID;

	public string Name => processName;

	public string DisplayName => processDisplayName;

	public ProcessContextMetadataInfo(Guid processHeaderUid, string processDisplayName, string processName, Guid fullContextUid, Guid publishedContextUid)
	{
		//Discarded unreachable code: IL_002a
		sue7n4b6lku69ULJGob();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
			{
				this.processDisplayName = processDisplayName;
				int num2 = 4;
				num = num2;
				break;
			}
			case 5:
				this.fullContextUid = fullContextUid;
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
				{
					num = 1;
				}
				break;
			case 3:
				this.processHeaderUid = processHeaderUid;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.publishedContextUid = publishedContextUid;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
				{
					num = 0;
				}
				break;
			case 4:
				this.processName = processName;
				num = 5;
				break;
			}
		}
	}

	[Obsolete("Конструктор устарел, используйте другой конструктор", true)]
	public ProcessContextMetadataInfo(IProcessHeader processHeader, Type contextType)
	{
		//Discarded unreachable code: IL_005c, IL_0061
		sue7n4b6lku69ULJGob();
		this._002Ector(o5JkZ7bqYgTdJEtu8Wn(processHeader), (string)s7XJnyb3uNPdmCxrt3N(processHeader), (string)CKrhpCbQqWnmHHcr2hW(Ymw21dbTXCwNoNX1e6S(processHeader)), d1CgFAbpWLwsZfYKJpt(Ymw21dbTXCwNoNX1e6S(processHeader)), d1CgFAbpWLwsZfYKJpt(rVENPIbMQUgsyuf3608(Rj4622bCnKVHp1jnQms(processHeader))));
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public IMetadata GetMetadata()
	{
		return (IMetadata)yZZLc2bkf3IVmDPWaDf(fullContextUid, true, true);
	}

	public void ProcessPropertyDescriptor(IPropertyMetadata propMetadata, TypeSerializationItemDescriptor propDescriptor)
	{
		//Discarded unreachable code: IL_00a3, IL_00b2, IL_00bd, IL_012c, IL_019f, IL_01d7, IL_01e6, IL_0211, IL_0220
		int num = 3;
		int num2 = num;
		IEnumerator<IEntityMetadataSearcher> enumerator = default(IEnumerator<IEntityMetadataSearcher>);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 7:
				return;
			default:
				if (publishedPropertyUids.Contains(propMetadata.PropertyUid))
				{
					num2 = 7;
					break;
				}
				goto case 1;
			case 2:
				publishedPropertyUids = new List<Guid>();
				num2 = 5;
				break;
			case 3:
				if (publishedPropertyUids == null)
				{
					num2 = 2;
					break;
				}
				goto default;
			case 1:
				OMbsKxb79rt37Ar6P64(MXt3dsbG37Xy2QVQNej(propDescriptor), true);
				num2 = 6;
				break;
			case 4:
				try
				{
					while (true)
					{
						IL_00e3:
						int num3;
						if (!sFLON3bVWVKE6YnUNKP(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
							{
								num3 = 0;
							}
							goto IL_00c1;
						}
						goto IL_0109;
						IL_0109:
						entityMetadata = (EntityMetadata)iX7079bUPZ3NkLDEOxQ(enumerator.Current, publishedContextUid);
						num3 = 3;
						goto IL_00c1;
						IL_00c1:
						while (true)
						{
							switch (num3)
							{
							case 2:
								goto IL_00e3;
							case 5:
								goto IL_0109;
							case 1:
								break;
							case 3:
								if (entityMetadata != null)
								{
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
									{
										num3 = 3;
									}
									continue;
								}
								goto IL_00e3;
							case 4:
								AddPropertyUids(entityMetadata);
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
								{
									num3 = 1;
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
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								C2vJbbbABbSHWBnI8TQ(enumerator);
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
								{
									num4 = 1;
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
			case 5:
				enumerator = ComponentManager.Current.GetExtensionPoints<IEntityMetadataSearcher>().GetEnumerator();
				num2 = 4;
				break;
			}
		}
	}

	private void AddPropertyUids(EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_0037, IL_0046, IL_012a, IL_013d, IL_014c, IL_0184, IL_0193, IL_019e, IL_023d, IL_0250, IL_025f
		int num = 4;
		int num2 = num;
		List<TablePartMetadata>.Enumerator enumerator2 = default(List<TablePartMetadata>.Enumerator);
		TablePartMetadata current2 = default(TablePartMetadata);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		PropertyMetadata current = default(PropertyMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				try
				{
					while (true)
					{
						int num6;
						if (!enumerator2.MoveNext())
						{
							int num5 = 2;
							num6 = num5;
							goto IL_0055;
						}
						goto IL_00db;
						IL_0055:
						while (true)
						{
							switch (num6)
							{
							case 2:
								return;
							case 3:
								AddPropertyUids(current2);
								num6 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
								{
									num6 = 1;
								}
								continue;
							case 4:
								publishedPropertyUids.Add(vE5ChQb2WUY95nnp3gm(current2));
								num6 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
								{
									num6 = 3;
								}
								continue;
							case 1:
								break;
							default:
								goto IL_00db;
							}
							break;
						}
						continue;
						IL_00db:
						current2 = enumerator2.Current;
						num6 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
						{
							num6 = 4;
						}
						goto IL_0055;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
			case 4:
				enumerator = metadata.Properties.GetEnumerator();
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				try
				{
					while (true)
					{
						IL_01fb:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_01a2;
						}
						goto IL_01e8;
						IL_01a2:
						while (true)
						{
							switch (num3)
							{
							case 2:
								publishedPropertyUids.Add(((IPropertyMetadata)current).PropertyUid);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
								break;
							default:
								goto IL_01fb;
							case 3:
								goto end_IL_01fb;
							}
							break;
						}
						goto IL_01e8;
						IL_01e8:
						current = enumerator.Current;
						num3 = 2;
						goto IL_01a2;
						continue;
						end_IL_01fb:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				break;
			case 1:
				break;
			}
			enumerator2 = metadata.TableParts.GetEnumerator();
			num2 = 2;
		}
	}

	internal static void sue7n4b6lku69ULJGob()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool SkBL8pbjIKedwUHmAlj()
	{
		return QMVKSXbWHpRhlfxUbbi == null;
	}

	internal static ProcessContextMetadataInfo pXmX9nbRS6suDEoRpww()
	{
		return QMVKSXbWHpRhlfxUbbi;
	}

	internal static Guid o5JkZ7bqYgTdJEtu8Wn(object P_0)
	{
		return ((IProcessHeader)P_0).Uid;
	}

	internal static object s7XJnyb3uNPdmCxrt3N(object P_0)
	{
		return ((IProcessHeader)P_0).Name;
	}

	internal static object Ymw21dbTXCwNoNX1e6S(object P_0)
	{
		return ((IProcessHeader)P_0).Context;
	}

	internal static object CKrhpCbQqWnmHHcr2hW(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static Guid d1CgFAbpWLwsZfYKJpt(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object Rj4622bCnKVHp1jnQms(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static object rVENPIbMQUgsyuf3608(object P_0)
	{
		return ((IWorkflowProcess)P_0).Context;
	}

	internal static object yZZLc2bkf3IVmDPWaDf(Guid P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object iX7079bUPZ3NkLDEOxQ(object P_0, Guid P_1)
	{
		return ((IEntityMetadataSearcher)P_0).FindEntityMetadata(P_1);
	}

	internal static bool sFLON3bVWVKE6YnUNKP(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void C2vJbbbABbSHWBnI8TQ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object MXt3dsbG37Xy2QVQNej(object P_0)
	{
		return ((TypeSerializationItemDescriptor)P_0).Descriptor;
	}

	internal static void OMbsKxb79rt37Ar6P64(object P_0, bool P_1)
	{
		((TypeSerializationDescriptor)P_0).IsObsolete = P_1;
	}

	internal static Guid vE5ChQb2WUY95nnp3gm(object P_0)
	{
		return ((IPropertyMetadata)P_0).PropertyUid;
	}
}
