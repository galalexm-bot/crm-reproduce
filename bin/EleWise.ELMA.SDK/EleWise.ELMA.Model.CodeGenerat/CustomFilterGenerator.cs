using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class CustomFilterGenerator : EntityGenerator, IAutoClassGenerator
{
	private Type interfaceType;

	private Type[] extensionTypes;

	internal static CustomFilterGenerator j0rGRNh2UcJm1XVilB58;

	public string GenerateCode(Type interfaceType, params Type[] extensionTypes)
	{
		int num = 1;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return (string)c6EksXheBnlSINrV0Uuv(interfaceType.Namespace.NamespaceDeclaration(GetNamespaces().Concat(GenerateMainFile())));
			case 6:
				entityMetadata.LoadFromType(interfaceType);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 5;
				}
				break;
			default:
				this.interfaceType = interfaceType;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				((ICodeGenerator)this).Metadata = entityMetadata.CreateInterfaceImplementationMetadata();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				entityMetadata = new EntityMetadata();
				num2 = 6;
				break;
			case 1:
				pScrCHheFKkFJ7W4ZwX9(interfaceType, XEDpMkh2zj9gWo97O76Y(-606654180 ^ -606835348));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				this.extensionTypes = extensionTypes ?? new Type[0];
				num2 = 4;
				break;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		return WriteFilterClass();
	}

	protected override IEnumerable<ISyntaxNode> FilterForAttribute()
	{
		return Enumerable.Empty<ISyntaxNode>();
	}

	protected override string GetInterfaceTypeName()
	{
		return interfaceType.FullName;
	}

	protected override void FilterCommentSummary(ISyntaxNode filterType)
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
				filterType.XmlComments(SR.T((string)XEDpMkh2zj9gWo97O76Y(-1459557599 ^ -1459374161), HIRdwYheoWxTT85OYfxU(aosgcOheWyPxyPH7sg2K(metadata))).SummaryComment());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public CustomFilterGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		PyhJVVhebCtm2XMqIAdv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object XEDpMkh2zj9gWo97O76Y(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void pScrCHheFKkFJ7W4ZwX9(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object c6EksXheBnlSINrV0Uuv(object P_0)
	{
		return ((ISyntaxNode)P_0).GenerateCSCodeString();
	}

	internal static bool WZcUuGh2sGwXFm5RaEn0()
	{
		return j0rGRNh2UcJm1XVilB58 == null;
	}

	internal static CustomFilterGenerator oKraOlh2cSZDhRXnalxf()
	{
		return j0rGRNh2UcJm1XVilB58;
	}

	internal static object aosgcOheWyPxyPH7sg2K(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object HIRdwYheoWxTT85OYfxU(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void PyhJVVhebCtm2XMqIAdv()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
