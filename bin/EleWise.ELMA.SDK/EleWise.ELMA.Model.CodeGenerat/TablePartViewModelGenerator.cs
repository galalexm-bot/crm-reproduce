using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public sealed class TablePartViewModelGenerator : EntityViewModelGenerator
{
	private readonly TablePartMetadata tablePartMetadata;

	internal static TablePartViewModelGenerator Rt2s6DhknkxgUAphrb5K;

	public TablePartViewModelGenerator(TablePartMetadata tablePartMetadata)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				TQrJkNhkPkd1ND00b5wK(tablePartMetadata, Cft8pWhke7YjxEsICAW5(-105199646 ^ -105281080));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.tablePartMetadata = tablePartMetadata;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override ISyntaxNode Generate()
	{
		int num = 3;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (metadata.IsInterfaceType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 3:
				text = "";
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				return ((string)oFbAt2hkNvZPI4pj5yTh(text, t1tDa8hk1PL93rsINi6k(tablePartMetadata), Cft8pWhke7YjxEsICAW5(-2138958856 ^ -2139005528))).ClassDeclaration(Accessibility.Internal, DeclarationModifiers.Sealed, (ISyntaxNode)CCKO4Hhk3EYqXwyx9an3(this), null, GetMembers());
			default:
				text = (string)Cft8pWhke7YjxEsICAW5(-541731959 ^ -541643441);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected override ISyntaxNode GetBaseClass()
	{
		return typeof(FormViewBuilder<>).CreateTypeSyntax((ISyntaxNode)CRKBmEhkagfiWH9BtagF(aEiWN1hkpFrT20yFF3Gm(tablePartMetadata)));
	}

	internal static object Cft8pWhke7YjxEsICAW5(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void TQrJkNhkPkd1ND00b5wK(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool HptDD8hkOgmtYV8XfOiX()
	{
		return Rt2s6DhknkxgUAphrb5K == null;
	}

	internal static TablePartViewModelGenerator jNoRLfhk2ZI5jnUP6bGw()
	{
		return Rt2s6DhknkxgUAphrb5K;
	}

	internal static object t1tDa8hk1PL93rsINi6k(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object oFbAt2hkNvZPI4pj5yTh(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object CCKO4Hhk3EYqXwyx9an3(object P_0)
	{
		return ((ClassGenerator)P_0).GetBaseClass();
	}

	internal static object aEiWN1hkpFrT20yFF3Gm(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static object CRKBmEhkagfiWH9BtagF(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}
}
