using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public class PublicApiCreateFilterHelperMethodNode : IPublicApiNode
{
	private readonly EntityMetadata entityMetadata;

	private readonly string displayName;

	private readonly bool skipExample;

	internal static PublicApiCreateFilterHelperMethodNode Fu84cih6lgI3QYNyTTP7;

	public string ParentPath
	{
		[CompilerGenerated]
		get
		{
			return _003CParentPath_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CParentPath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string Path => (string)U8ErN8h6sKbJ1k40CVhh(ParentPath, MMAxQwh6UQykndgnqSA0(-1939377524 ^ -1939602396));

	public PublicApiCreateFilterHelperMethodNode(string parentPath, [NotNull] EntityMetadata entityMetadata, bool skipExample = false)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GyTfYvh65kWBJGjPN806();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 5:
				entityMetadata = (EntityMetadata)((PublicApiCodeGenerator)aakVD0h6LMUpg7pKboZu()).GetMetadata(entityMetadata.BaseClassUid, loadImplementation: false);
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num = 6;
				}
				continue;
			case 3:
				ParentPath = parentPath;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num = 0;
				}
				continue;
			case 4:
				if (USsyQUh6YD09XINdHmAf(entityMetadata) == EntityMetadataType.InterfaceExtension)
				{
					num = 5;
					continue;
				}
				break;
			case 1:
				displayName = SR.T((string)TmwbPBh6jSHqb14H1poy(entityMetadata));
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num = 4;
				}
				continue;
			default:
				this.skipExample = skipExample;
				num = 2;
				continue;
			case 6:
				break;
			case 2:
				return;
			}
			this.entityMetadata = entityMetadata;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
			{
				num = 0;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGenerate_003Ed__10))]
	public IEnumerable<ISyntaxNode> Generate(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerate_003Ed__10(-2)
		{
			_003C_003E4__this = this
		};
	}

	internal static void GyTfYvh65kWBJGjPN806()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object TmwbPBh6jSHqb14H1poy(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static EntityMetadataType USsyQUh6YD09XINdHmAf(object P_0)
	{
		return ((EntityMetadata)P_0).Type;
	}

	internal static object aakVD0h6LMUpg7pKboZu()
	{
		return PublicApiCodeGenerator.Current;
	}

	internal static bool DNpSJhh6r2TnXsJJ9U4F()
	{
		return Fu84cih6lgI3QYNyTTP7 == null;
	}

	internal static PublicApiCreateFilterHelperMethodNode Ve9o4Zh6g0Fvi1DshIL6()
	{
		return Fu84cih6lgI3QYNyTTP7;
	}

	internal static object MMAxQwh6UQykndgnqSA0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object U8ErN8h6sKbJ1k40CVhh(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
