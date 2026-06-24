using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.API;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration.PublicApi;

public class PublicApiEnumSelectorPropertyNode : PublicApiPropertyClassNode
{
	private static PublicApiEnumSelectorPropertyNode h2XXubhHwTHqFshfD2gb;

	public override string Description => EnumMetadata.Description;

	[NotNull]
	internal EnumMetadata EnumMetadata { get; }

	public PublicApiEnumSelectorPropertyNode(string parent, [NotNull] EnumMetadata enumMetadata, bool register = true)
	{
		//Discarded unreachable code: IL_005a, IL_005f, IL_00a3, IL_00b2
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(parent, (string)KeRoyPhH7J88aSfL5xbE(lfnIGKhHHfYZNppjWvD3(enumMetadata), NpebauhHA5tXTxnPXbLI(-234299632 ^ -234117688)), (string)lfnIGKhHHfYZNppjWvD3(enumMetadata), enumMetadata.FullTypeName, hideProperty: false, register);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
		{
			num = 1;
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
				if (enumMetadata != null)
				{
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num = 3;
					}
					break;
				}
				goto case 2;
			case 2:
				throw new ArgumentNullException((string)NpebauhHA5tXTxnPXbLI(0x4DC2B14D ^ 0x4DC1CBB9));
			case 3:
				EnumMetadata = enumMetadata;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	protected override ISyntaxNode PropertyResultClass(IDictionary<string, IEnumerable<IPublicApiNode>> tree)
	{
		return base.ClassName.ClassDeclaration(Accessibility.Public, DeclarationModifiers.None, null, null, Members()).XmlComments(SR.T(EnumMetadata.DisplayName).SummaryComment()).MakeClassHide();
	}

	[IteratorStateMachine(typeof(_003CMembers_003Ed__7))]
	protected virtual IEnumerable<ISyntaxNode> Members()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CMembers_003Ed__7(-2)
		{
			_003C_003E4__this = this
		};
	}

	internal static object lfnIGKhHHfYZNppjWvD3(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object NpebauhHA5tXTxnPXbLI(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object KeRoyPhH7J88aSfL5xbE(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool cR0rUKhH4BIx0AKtKWTK()
	{
		return h2XXubhHwTHqFshfD2gb == null;
	}

	internal static PublicApiEnumSelectorPropertyNode D33LsyhH6geKH73ZffyQ()
	{
		return h2XXubhHwTHqFshfD2gb;
	}
}
