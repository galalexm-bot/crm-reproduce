using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public class EntityActionsGenerator : EnumGenerator
{
	internal static EntityActionsGenerator BJioxaha0krfSel6GYZs;

	public EntityMetadata EntityMetadata
	{
		[CompilerGenerated]
		get
		{
			return _003CEntityMetadata_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CEntityMetadata_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected override bool IsExtendable => true;

	protected override void WriteTypeAttributes(ISyntaxNode declaration)
	{
	}

	protected override Accessibility CtorAccessibility()
	{
		return Accessibility.Protected;
	}

	[IteratorStateMachine(typeof(_003CCtorParameters_003Ed__6))]
	protected override IEnumerable<ISyntaxNode> CtorParameters()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CCtorParameters_003Ed__6(-2);
	}

	protected override IEnumerable<ISyntaxNode> BaseCtorArguments()
	{
		return null;
	}

	protected override ISyntaxNode DeserializationCtor()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CValue_003Ed__9))]
	protected override IEnumerable<ISyntaxNode> Value(EnumValueMetadata valueMetadata)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CValue_003Ed__9(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__valueMetadata = valueMetadata
		};
	}

	protected override ISyntaxNode GetBaseClass()
	{
		//Discarded unreachable code: IL_00d1, IL_00e0, IL_00ef, IL_0139, IL_0148, IL_0178, IL_0187
		int num = 9;
		Func<EntityMetadata, EntityMetadata> func = default(Func<EntityMetadata, EntityMetadata>);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					func = delegate(EntityMetadata m)
					{
						//Discarded unreachable code: IL_002d, IL_003c
						int num3 = 2;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 2:
								if (ns4JZshaYADDmLslmMFq(RdYQj1hajBJAuL8Vc4F5(m), Guid.Empty))
								{
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
									{
										num4 = 1;
									}
									break;
								}
								goto default;
							default:
								return null;
							case 1:
								return (EntityMetadata)GetMetadata(RdYQj1hajBJAuL8Vc4F5(m));
							}
						}
					};
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					if (UX9iJLha9GFe58tl813H(entityMetadata) == null)
					{
						num2 = 10;
						continue;
					}
					goto case 7;
				case 9:
					break;
				case 11:
				case 13:
					if (entityMetadata == null)
					{
						num2 = 2;
						continue;
					}
					return (ISyntaxNode)F2DQSwha5GfhgLVY1mSB(A31WgRhagcTa80tUJYis(tTLBv8harEq0BDewyeQg(entityMetadata), vmtE6uhaML60MeTepWCr(0x34A6D230 ^ 0x34A6C8F4), EntityGenerator.GetActionsTypeName(entityMetadata)));
				case 2:
					return (ISyntaxNode)KW2FQthale2bykJmoBkG(TypeOf<DefaultEntityActions>.Raw);
				case 7:
					if (yun0oShadWYob9EnlHFJ(((EnumMetadata)UX9iJLha9GFe58tl813H(entityMetadata)).Values) == 0)
					{
						num2 = 6;
						continue;
					}
					goto case 11;
				case 4:
					entityMetadata = func(EntityMetadata);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
				case 6:
				case 10:
					entityMetadata = func(entityMetadata);
					num2 = 3;
					continue;
				case 8:
					XPxObmhaJYLVks1xthrY(EntityMetadata, vmtE6uhaML60MeTepWCr(-2112703338 ^ -2112759030));
					num2 = 12;
					continue;
				default:
					if (entityMetadata == null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 1;
				}
				break;
			}
			XPxObmhaJYLVks1xthrY(metadata, vmtE6uhaML60MeTepWCr(-1921202237 ^ -1921216771));
			num = 8;
		}
	}

	public EntityActionsGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool NOQJBmhamm3xcfctoZoc()
	{
		return BJioxaha0krfSel6GYZs == null;
	}

	internal static EntityActionsGenerator xZFxPghayZrcYumtJYvg()
	{
		return BJioxaha0krfSel6GYZs;
	}

	internal static object vmtE6uhaML60MeTepWCr(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void XPxObmhaJYLVks1xthrY(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static object UX9iJLha9GFe58tl813H(object P_0)
	{
		return ((EntityMetadata)P_0).Actions;
	}

	internal static int yun0oShadWYob9EnlHFJ(object P_0)
	{
		return ((List<EnumValueMetadata>)P_0).Count;
	}

	internal static object KW2FQthale2bykJmoBkG(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static object tTLBv8harEq0BDewyeQg(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static object A31WgRhagcTa80tUJYis(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object F2DQSwha5GfhgLVY1mSB(object P_0)
	{
		return ((string)P_0).CreateTypeSyntax();
	}

	internal static Guid RdYQj1hajBJAuL8Vc4F5(object P_0)
	{
		return ((ClassMetadata)P_0).BaseClassUid;
	}

	internal static bool ns4JZshaYADDmLslmMFq(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}
}
