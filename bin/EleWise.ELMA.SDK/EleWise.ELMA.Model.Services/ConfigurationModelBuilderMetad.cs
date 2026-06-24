using System;
using System.Collections.Generic;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Services;

public class ConfigurationModelBuilderMetadataService : IMetadataService
{
	private IMetadataRuntimeService source;

	private Dictionary<Guid, IMetadata> metadataByUid;

	private static ConfigurationModelBuilderMetadataService O7JNMnb8LJFEShpQpnKo;

	public ConfigurationModelBuilderMetadataService(IMetadataRuntimeService source, IEnumerable<IMetadata> metadataList)
	{
		SingletonReader.JJCZtPuTvSt();
		metadataByUid = new Dictionary<Guid, IMetadata>();
		base._002Ector();
		this.source = source;
		foreach (IMetadata metadata in source.GetMetadataList())
		{
			metadataByUid[metadata.Uid] = metadata;
		}
		if (metadataList == null)
		{
			return;
		}
		foreach (IMetadata metadata2 in metadataList)
		{
			AddMetadata(metadata2);
		}
	}

	public void AddMetadata(IMetadata metadata)
	{
		//Discarded unreachable code: IL_0046, IL_0050, IL_00ef, IL_0127, IL_019f
		int num = 3;
		IEnumerator<IMetadata> enumerator = default(IEnumerator<IMetadata>);
		IMetadata current = default(IMetadata);
		IEnumerable<IMetadata> compositeParts = default(IEnumerable<IMetadata>);
		ICompositeMetadata compositeMetadata = default(ICompositeMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					try
					{
						while (true)
						{
							IL_0081:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
								{
									num3 = 0;
								}
								goto IL_0054;
							}
							goto IL_006e;
							IL_006e:
							current = enumerator.Current;
							num3 = 3;
							goto IL_0054;
							IL_0054:
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 2:
									break;
								case 1:
									goto IL_0081;
								case 3:
									AddMetadata(current);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
									{
										num3 = 1;
									}
									continue;
								case 0:
									return;
								}
								break;
							}
							goto IL_006e;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									enumerator.Dispose();
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
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
				case 8:
					compositeParts = compositeMetadata.GetCompositeParts();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					enumerator = compositeParts.GetEnumerator();
					num2 = 5;
					continue;
				case 2:
					compositeMetadata = metadata as ICompositeMetadata;
					num2 = 7;
					continue;
				case 3:
					break;
				case 4:
					return;
				case 6:
					return;
				case 1:
					if (compositeParts == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					if (compositeMetadata == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 8;
				}
				break;
			}
			metadataByUid[H5m33Cb8cqmVGB1PTNNs(metadata)] = metadata;
			num = 2;
		}
	}

	public IMetadata GetMetadata(Guid metadataUid, bool loadImplementation = true)
	{
		//Discarded unreachable code: IL_0093, IL_00a2
		int num = 1;
		int num2 = num;
		IMetadata value = default(IMetadata);
		while (true)
		{
			switch (num2)
			{
			case 2:
				throw new ObjectNotFoundException(metadataByUid.ToString(), SR.T((string)i04yJ6b8zyqj7Bclr17f(-541731959 ^ -541610879), metadataUid));
			default:
				return value;
			case 1:
				if (metadataByUid.TryGetValue(metadataUid, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public IEnumerable<IMetadata> GetMetadataList()
	{
		return metadataByUid.Values;
	}

	public IEnumerable<ITypeDescriptor> GetTypeDescriptors()
	{
		return source.GetTypeDescriptors();
	}

	public ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid)
	{
		return (ITypeDescriptor)sWIPyEbZF3DQeg784MCR(source, typeUid, subTypeUid);
	}

	public ITypeDescriptor GetTypeDescriptor(Type runtimeType)
	{
		return (ITypeDescriptor)JXsATvbZBRIbiPYIUjin(source, runtimeType);
	}

	public IEnumerable<ITypeDescriptor> GetIdTypeDescriptors()
	{
		return source.GetIdTypeDescriptors();
	}

	public ITypeDescriptor GetIdTypeDescriptor(Guid typeUid)
	{
		return (ITypeDescriptor)g12lb4bZWR0os8UOdgc9(source, typeUid);
	}

	public bool IsSystem(Guid typeUid)
	{
		return b39VQlbZoWcSgUfVXvAW(source, typeUid);
	}

	public bool IsConfig(Guid typeUid)
	{
		//Discarded unreachable code: IL_0031
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return !source.IsSystem(typeUid);
			default:
				return true;
			case 1:
				if (source.IsConfig(typeUid))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				break;
			}
			if (!metadataByUid.ContainsKey(typeUid))
			{
				break;
			}
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
			{
				num2 = 1;
			}
		}
		return false;
	}

	internal static Guid H5m33Cb8cqmVGB1PTNNs(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static bool Gw7n1mb8UGeZbDalw9Lq()
	{
		return O7JNMnb8LJFEShpQpnKo == null;
	}

	internal static ConfigurationModelBuilderMetadataService FLMygjb8sBw4qJOgpox9()
	{
		return O7JNMnb8LJFEShpQpnKo;
	}

	internal static object i04yJ6b8zyqj7Bclr17f(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object sWIPyEbZF3DQeg784MCR(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static object JXsATvbZBRIbiPYIUjin(object P_0, Type runtimeType)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(runtimeType);
	}

	internal static object g12lb4bZWR0os8UOdgc9(object P_0, Guid typeUid)
	{
		return ((IMetadataService)P_0).GetIdTypeDescriptor(typeUid);
	}

	internal static bool b39VQlbZoWcSgUfVXvAW(object P_0, Guid typeUid)
	{
		return ((IMetadataRuntimeService)P_0).IsSystem(typeUid);
	}
}
