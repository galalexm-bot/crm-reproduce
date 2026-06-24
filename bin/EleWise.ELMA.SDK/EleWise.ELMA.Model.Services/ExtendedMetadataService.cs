using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Services;

public class ExtendedMetadataService : IMetadataService
{
	private IMetadataService source;

	private Dictionary<Guid, IMetadata> metadataByUid;

	internal static ExtendedMetadataService faPFJsbZbv9m0TxxhjgF;

	public ExtendedMetadataService(IMetadataService source, IEnumerable<IMetadata> metadataList)
	{
		SingletonReader.JJCZtPuTvSt();
		metadataByUid = new Dictionary<Guid, IMetadata>();
		base._002Ector();
		this.source = source;
		if (metadataList == null)
		{
			return;
		}
		foreach (IMetadata metadata in metadataList)
		{
			ProcessMetadata(metadata);
		}
	}

	public IMetadata GetMetadata(Guid metadataUid, bool loadImplementation = true)
	{
		int num = 1;
		int num2 = num;
		IMetadata value = default(IMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return value;
			case 1:
				if (!metadataByUid.TryGetValue(metadataUid, out value))
				{
					return source.GetMetadata(metadataUid, loadImplementation);
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IEnumerable<IMetadata> GetMetadataList()
	{
		return metadataByUid.Values.Union(source.GetMetadataList());
	}

	public IEnumerable<ITypeDescriptor> GetTypeDescriptors()
	{
		return source.GetTypeDescriptors();
	}

	public ITypeDescriptor GetTypeDescriptor(Guid typeUid, Guid subTypeUid)
	{
		return (ITypeDescriptor)G1jeL8bZEqhGJ8fkmJnG(source, typeUid, subTypeUid);
	}

	public ITypeDescriptor GetTypeDescriptor(Type runtimeType)
	{
		return (ITypeDescriptor)gGLWIbbZfPdm1kXJwFbH(source, runtimeType);
	}

	public IEnumerable<ITypeDescriptor> GetIdTypeDescriptors()
	{
		return source.GetIdTypeDescriptors();
	}

	public ITypeDescriptor GetIdTypeDescriptor(Guid typeUid)
	{
		return (ITypeDescriptor)ioKQiNbZQWMVXxFQBKZ9(source, typeUid);
	}

	public bool IsSystem(Guid typeUid)
	{
		return BeSHvMbZCBJC1J0MGtpB(source, typeUid);
	}

	public bool IsConfig(Guid typeUid)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (metadataByUid.ContainsKey(typeUid))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			case 2:
				if (!GflC5WbZvsavfs4kkeb9(source, typeUid))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 1;
					}
					break;
				}
				return true;
			default:
				return !BeSHvMbZCBJC1J0MGtpB(source, typeUid);
			}
		}
	}

	private void ProcessMetadata(IMetadata metadata)
	{
		//Discarded unreachable code: IL_00df, IL_00ff, IL_010f, IL_011e, IL_0129, IL_01c8, IL_0200, IL_020f
		int num = 2;
		int num2 = num;
		IEnumerator<IMetadata> enumerator = default(IEnumerator<IMetadata>);
		IEnumerable<IMetadata> compositeParts = default(IEnumerable<IMetadata>);
		ICompositeMetadata compositeMetadata = default(ICompositeMetadata);
		IMetadata current = default(IMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				enumerator = compositeParts.GetEnumerator();
				num2 = 7;
				break;
			case 8:
				if (compositeParts == null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 3;
			case 2:
				metadataByUid[trlR6wbZ8ZvRF7DXNI4d(metadata)] = metadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 4:
				return;
			case 5:
				return;
			case 1:
				compositeMetadata = metadata as ICompositeMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 6;
				}
				break;
			case 9:
				compositeParts = compositeMetadata.GetCompositeParts();
				num2 = 8;
				break;
			case 6:
				if (compositeMetadata == null)
				{
					num2 = 5;
					break;
				}
				goto case 9;
			case 7:
				try
				{
					while (true)
					{
						int num3;
						if (!o9ZRcobZZUfmWTMMKTlx(enumerator))
						{
							num3 = 2;
							goto IL_012d;
						}
						goto IL_015d;
						IL_012d:
						while (true)
						{
							switch (num3)
							{
							case 2:
								return;
							case 3:
								goto IL_015d;
							case 1:
								ProcessMetadata(current);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
						continue;
						IL_015d:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
						{
							num3 = 1;
						}
						goto IL_012d;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								enumerator.Dispose();
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
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
			}
		}
	}

	internal static bool JLUsAxbZhhmBrgVRRQXG()
	{
		return faPFJsbZbv9m0TxxhjgF == null;
	}

	internal static ExtendedMetadataService qsLnVobZGQy9DgvDAdmp()
	{
		return faPFJsbZbv9m0TxxhjgF;
	}

	internal static object G1jeL8bZEqhGJ8fkmJnG(object P_0, Guid typeUid, Guid subTypeUid)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(typeUid, subTypeUid);
	}

	internal static object gGLWIbbZfPdm1kXJwFbH(object P_0, Type runtimeType)
	{
		return ((IMetadataService)P_0).GetTypeDescriptor(runtimeType);
	}

	internal static object ioKQiNbZQWMVXxFQBKZ9(object P_0, Guid typeUid)
	{
		return ((IMetadataService)P_0).GetIdTypeDescriptor(typeUid);
	}

	internal static bool BeSHvMbZCBJC1J0MGtpB(object P_0, Guid typeUid)
	{
		return ((IMetadataService)P_0).IsSystem(typeUid);
	}

	internal static bool GflC5WbZvsavfs4kkeb9(object P_0, Guid typeUid)
	{
		return ((IMetadataService)P_0).IsConfig(typeUid);
	}

	internal static Guid trlR6wbZ8ZvRF7DXNI4d(object P_0)
	{
		return ((IMetadata)P_0).Uid;
	}

	internal static bool o9ZRcobZZUfmWTMMKTlx(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}
}
