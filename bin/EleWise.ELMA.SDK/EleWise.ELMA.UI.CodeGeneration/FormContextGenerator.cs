using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

public class FormContextGenerator : EntityGenerator
{
	private static FormContextGenerator Voq6pIBVRm6TvrcEk9hg;

	public IEnumerable<ISyntaxNode> Generate()
	{
		return GenerateMainFile();
	}

	protected override ISyntaxNode GetBaseClass()
	{
		int num = 1;
		int num2 = num;
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		while (true)
		{
			switch (num2)
			{
			case 1:
				syntaxNode = (ISyntaxNode)MEDsvnBVXitjJGh2kJ6S((ITypeGenerationInfo)GetIdTypeDescriptor(), metadata, null, false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return J0FEqRBVT2DmTA4qoC6n(typeof(Entity<>).TypeHandle).CreateTypeSyntax(syntaxNode);
			}
		}
	}

	protected override void WriteTypeAttributes(ISyntaxNode type)
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
				type.AddAttributes(J0FEqRBVT2DmTA4qoC6n(typeof(UidAttribute).TypeHandle).CreateAttribute(qyCSFnBVkgMrc3T7TORs(metadata).ToString()), J0FEqRBVT2DmTA4qoC6n(typeof(MetadataTypeAttribute).TypeHandle).CreateAttribute(metadata.GetType()), J0FEqRBVT2DmTA4qoC6n(typeof(DefaultManagerAttribute).TypeHandle).CreateAttribute(J0FEqRBVT2DmTA4qoC6n(typeof(MemoryEntityManagerMaker).TypeHandle)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void WritePropertyAttributes(ISyntaxNode property, PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
		int num = 2;
		Dictionary<string, object> settingsValuePairs = default(Dictionary<string, object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					h10ZB6BVOi5fgTjNNpsh(property, XrsQnMBVnpjBMgNlvHNs(0x12A5FAC7 ^ 0x12A4E3C1));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					property.AddAttributes(WriteValidatePropertyAttributes(propertyMetadata));
					num2 = 7;
					continue;
				case 6:
					if (wFL3rtBVesdhI0YN9iEB(propertyMetadata) != null)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					return;
				case 4:
					if (TDBkeDBV2K8aQ8HB6McS(propertyMetadata))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 7:
					return;
				case 1:
					h10ZB6BVOi5fgTjNNpsh(propertyMetadata, XrsQnMBVnpjBMgNlvHNs(0x63ABA4E8 ^ 0x63ABEDBA));
					num2 = 4;
					continue;
				case 5:
					property.AddAttributes((ISyntaxNode)I3FViKBVPoXLZlqbm59S(wFL3rtBVesdhI0YN9iEB(propertyMetadata).GetType(), settingsValuePairs.ToArray()));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					break;
				default:
					property.AddAttributes(J0FEqRBVT2DmTA4qoC6n(typeof(RequiredAttribute).TypeHandle).CreateAttribute(TDBkeDBV2K8aQ8HB6McS(propertyMetadata)));
					num2 = 6;
					continue;
				}
				break;
			}
			settingsValuePairs = ((TypeSettings)wFL3rtBVesdhI0YN9iEB(propertyMetadata)).GetSettingsValuePairs();
			num = 5;
		}
	}

	[IteratorStateMachine(typeof(_003CResources_003Ed__4))]
	protected override IEnumerable<ISyntaxTrivia> Resources()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CResources_003Ed__4(-2);
	}

	[Obsolete("Метод устарел", true)]
	protected override EntityGenerator CreateTablePartGenerator()
	{
		return (EntityGenerator)wkEAyMBV1Jb64jnmQavs(this, null);
	}

	protected override EntityGenerator CreateTablePartGenerator(TablePartMetadata tablePart)
	{
		return new FormContextGenerator();
	}

	public FormContextGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vLXdrEBVNtkA6o08ZnLT();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object MEDsvnBVXitjJGh2kJ6S(object P_0, object P_1, object P_2, bool forFilter)
	{
		return ((ITypeGenerationInfo)P_0).GetPropertyTypeReference((ClassMetadata)P_1, (PropertyMetadata)P_2, forFilter);
	}

	internal static Type J0FEqRBVT2DmTA4qoC6n(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool tUUI2kBVqYnCDrp4dFAn()
	{
		return Voq6pIBVRm6TvrcEk9hg == null;
	}

	internal static FormContextGenerator xAkyoRBVK5s9W0Wt1s0x()
	{
		return Voq6pIBVRm6TvrcEk9hg;
	}

	internal static Guid qyCSFnBVkgMrc3T7TORs(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object XrsQnMBVnpjBMgNlvHNs(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void h10ZB6BVOi5fgTjNNpsh(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool TDBkeDBV2K8aQ8HB6McS(object P_0)
	{
		return ((PropertyMetadata)P_0).Required;
	}

	internal static object wFL3rtBVesdhI0YN9iEB(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static object I3FViKBVPoXLZlqbm59S(Type attributeType, object P_1)
	{
		return attributeType.CreateAttribute((KeyValuePair<string, object>[])P_1);
	}

	internal static object wkEAyMBV1Jb64jnmQavs(object P_0, object P_1)
	{
		return ((EntityGenerator)P_0).CreateTablePartGenerator((TablePartMetadata)P_1);
	}

	internal static void vLXdrEBVNtkA6o08ZnLT()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
