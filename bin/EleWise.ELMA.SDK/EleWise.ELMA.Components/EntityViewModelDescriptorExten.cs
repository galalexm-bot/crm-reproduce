using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Components;

[Component]
internal sealed class EntityViewModelDescriptorExtension : IViewModelDescriptorExtension
{
	private readonly MetadataItemHeaderManager metadataItemHeaderManager;

	private readonly IMetadataRuntimeService metadataRuntimeService;

	private static EntityViewModelDescriptorExtension nlKQtbfh3SYZFJQ0r3D5;

	public EntityViewModelDescriptorExtension(MetadataItemHeaderManager metadataItemHeaderManager, IMetadataRuntimeService metadataRuntimeService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				this.metadataItemHeaderManager = metadataItemHeaderManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num = 0;
				}
				break;
			default:
				this.metadataRuntimeService = metadataRuntimeService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public bool Check(string typeRef)
	{
		return q6OIo6fhtGCjvpASCDKQ(typeRef, Um5qvTfhDDoJ7LAwhAE0(-541731959 ^ -542051953));
	}

	public IMetadata GetMetadata(string typeRef)
	{
		//Discarded unreachable code: IL_0035
		int num = 1;
		int num2 = num;
		IMetadataItemHeader metadataItemHeader = default(IMetadataItemHeader);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Check(typeRef))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 3:
				metadataItemHeader = metadataItemHeaderManager.Load(atOy8Tfh4AJLU5L2pY7o(text));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return metadataRuntimeService.GetMetadata(ieLa6Bfh6oou0pYjUU4L(metadataItemHeader), loadImplementation: false);
			case 4:
				return null;
			default:
				text = typeRef.Substring(qtEViofhwJNeGiBYPGVQ(Um5qvTfhDDoJ7LAwhAE0(0x53CB464B ^ 0x53CE644D)));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	internal static bool pB0F7UfhpnYftTsZKd7L()
	{
		return nlKQtbfh3SYZFJQ0r3D5 == null;
	}

	internal static EntityViewModelDescriptorExtension GLfs3ufharvrts6jN5Gf()
	{
		return nlKQtbfh3SYZFJQ0r3D5;
	}

	internal static object Um5qvTfhDDoJ7LAwhAE0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool q6OIo6fhtGCjvpASCDKQ(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static int qtEViofhwJNeGiBYPGVQ(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static long atOy8Tfh4AJLU5L2pY7o(object P_0)
	{
		return long.Parse((string)P_0);
	}

	internal static Guid ieLa6Bfh6oou0pYjUU4L(object P_0)
	{
		return ((IMetadataItemHeader)P_0).Uid;
	}
}
