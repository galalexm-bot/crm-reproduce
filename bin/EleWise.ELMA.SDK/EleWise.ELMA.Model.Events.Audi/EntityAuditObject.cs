using System;
using System.Drawing;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Events.Audit;

[Serializable]
public class EntityAuditObject : IAuditObject
{
	private Guid uid;

	private Guid parentClassUid;

	private string fullTypeName;

	private MetadataImage image;

	private EntityMetadata metadata;

	private IAuditObject parent;

	private static EntityAuditObject h6UBiioWVUPjEtHvv613;

	public Guid Uid => uid;

	public IAuditObjectType Type => (IAuditObjectType)b3C8r5oWka4Zgvmen0H9();

	public IAuditObject Parent
	{
		get
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (parent == null)
					{
						num2 = 2;
						break;
					}
					goto case 1;
				case 2:
					if (zlcQYhoWng78yYRqZE9T(parentClassUid, Guid.Empty))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 1:
					return parent;
				default:
					parent = (IAuditObject)GSLIWGoWOurEgo9DLQ9H(Locator.GetServiceNotNull<IAuditManager>(), parentClassUid);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Name => fullTypeName;

	public string DisplayName
	{
		get
		{
			int num = 2;
			int num2 = num;
			EntityMetadata entityMetadata = default(EntityMetadata);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (entityMetadata == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return (string)o0hYIZoW2C0ILC18Sh9N(entityMetadata);
				default:
					return fullTypeName;
				case 2:
					entityMetadata = (EntityMetadata)Locator.GetServiceNotNull<IMetadataRuntimeService>().GetMetadata(uid);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Image Image
	{
		get
		{
			//Discarded unreachable code: IL_0060, IL_006f
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (image != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return null;
				case 1:
					return (Image)oHl2O3oWeRhlPEuIqocS(image);
				}
			}
		}
	}

	public MetadataImage MetadataImage => image;

	public EntityAuditObject(EntityMetadata metadata)
	{
		//Discarded unreachable code: IL_002a, IL_002f, IL_011b
		TXepxaoWRJZD2pHI3jtf();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 9:
				fullTypeName = metadata.FullTypeName;
				num = 3;
				break;
			case 1:
				this.metadata = metadata;
				num = 2;
				break;
			case 3:
				image = (MetadataImage)nFo0QZoWXwKc4FAwxqqA(metadata);
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num = 2;
				}
				break;
			default:
				parentClassUid = metadata.BaseClassUid;
				num = 9;
				break;
			case 5:
				if (image != null)
				{
					num = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num = 1;
					}
					break;
				}
				goto case 6;
			case 6:
				image = (MetadataImage)t9UISQoWTH4V7fRbAMx3(metadata, 16);
				num = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num = 2;
				}
				break;
			case 4:
				return;
			case 8:
				return;
			case 7:
				uid = metadata.Uid;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num = 0;
				}
				break;
			case 2:
				gdv5sAoWKSQq10539pJO(metadata, WJ81ScoWqxE677nImao4(0x26FFCB59 ^ 0x26FF8267));
				num = 7;
				break;
			}
		}
	}

	public MetadataImage GetImage(int size)
	{
		int num = 1;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj = MetadataLoader.ParentImage(metadata, size);
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_0060;
			default:
				obj = nFo0QZoWXwKc4FAwxqqA(metadata);
				goto IL_0060;
			case 2:
				{
					obj = MetadataLoader.ParentImage(metadata, 16);
					break;
				}
				IL_0060:
				if (obj != null)
				{
					break;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 1;
				}
				continue;
			}
			break;
		}
		return (MetadataImage)obj;
	}

	internal static void TXepxaoWRJZD2pHI3jtf()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object WJ81ScoWqxE677nImao4(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void gdv5sAoWKSQq10539pJO(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object nFo0QZoWXwKc4FAwxqqA(object P_0)
	{
		return ((NamedMetadata)P_0).DefaultImage;
	}

	internal static object t9UISQoWTH4V7fRbAMx3(object P_0, int size)
	{
		return MetadataLoader.ParentImage((ClassMetadata)P_0, size);
	}

	internal static bool VpKafWoWStUVk2kTLXtk()
	{
		return h6UBiioWVUPjEtHvv613 == null;
	}

	internal static EntityAuditObject dj5T6poWixr02v4HiauD()
	{
		return h6UBiioWVUPjEtHvv613;
	}

	internal static object b3C8r5oWka4Zgvmen0H9()
	{
		return EntityAuditObjectType.Instance;
	}

	internal static bool zlcQYhoWng78yYRqZE9T(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object GSLIWGoWOurEgo9DLQ9H(object P_0, Guid uid)
	{
		return ((IAuditManager)P_0).GetObject(uid);
	}

	internal static object o0hYIZoW2C0ILC18Sh9N(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object oHl2O3oWeRhlPEuIqocS(object P_0)
	{
		return ((MetadataImage)P_0).CreateImage();
	}
}
