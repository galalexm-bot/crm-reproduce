using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

internal class ComponentMetadataGenerator : CodeGenerator
{
	internal static ComponentMetadataGenerator aE4VSTBVF0sGiHCKJ5ew;

	protected ComponentMetadata Metadata
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadata_003Ek__BackingField;
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
					_003CMetadata_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
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

	protected override void InitInternal(IMetadata metadata)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Metadata = (ComponentMetadata)metadata;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				Ep9IXqBVbkMWIZmP1l0X(metadata, zx12h1BVojUZ4Hc6aLDC(--1418440330 ^ 0x548BE7B4));
				num2 = 2;
				break;
			case 1:
				return;
			case 2:
				cj6pTkBVhmNqvxSwPEw9(metadata is ComponentMetadata, zx12h1BVojUZ4Hc6aLDC(-1751176224 ^ -1751243328));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override GeneratedFileInfo GenerateMainFileInternal()
	{
		//Discarded unreachable code: IL_0081, IL_0178, IL_01bb, IL_01ca
		int num = 2;
		int num2 = num;
		GeneratedFileInfo result = default(GeneratedFileInfo);
		ISyntaxTrivia[] array2 = default(ISyntaxTrivia[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				Contract.NotNull(Metadata, (string)zx12h1BVojUZ4Hc6aLDC(-289714582 ^ -289671000));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					ISyntaxNode[] array = GetNamespaces().Concat(GenerateMainFile()).ToArray();
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						case 4:
							result = GenerateMainFileHelper((string)zx12h1BVojUZ4Hc6aLDC(-210725949 ^ -210664039), ((string)CchBsVBVG1JKSgaJJe3b(Metadata)).NamespaceDeclaration(array));
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
							{
								num3 = 1;
							}
							break;
						default:
							array.Last().TextCommentsTrailing(array2);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
							{
								num3 = 4;
							}
							break;
						case 3:
							if (array2.Any())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num3 = 0;
								}
								break;
							}
							goto case 4;
						case 2:
							array2 = WriteLocalizationResources().ToArray();
							num3 = 3;
							break;
						case 1:
							return result;
						}
					}
				}
				catch (Exception innerException)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					default:
						throw new CodeGenerationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939446772), O3RB5UBVE05QL6tNrP0y(Metadata)), innerException);
					}
				}
			default:
				return result;
			}
		}
	}

	protected override IEnumerable<GeneratedFileInfo> GenerateAdditionalFilesInternal()
	{
		return new GeneratedFileInfo[2]
		{
			GenerateMainFileHelper(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C95830E), GenerateViewModel()),
			GenerateMainFileHelper(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822822148), GenerateServerController())
		};
	}

	[IteratorStateMachine(typeof(_003CGetNamespaces_003Ed__10))]
	protected virtual IEnumerable<ISyntaxNode> GetNamespaces()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetNamespaces_003Ed__10(-2);
	}

	[IteratorStateMachine(typeof(_003CGenerateMainFile_003Ed__11))]
	protected virtual IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGenerateMainFile_003Ed__11(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected virtual IEnumerable<ISyntaxNode> GenerateMainFileContent()
	{
		return GenerateFileContent(new ComponentContextGenerator()).Concat(GenerateDataClasses(new DataClassGenerator()));
	}

	protected IEnumerable<ISyntaxNode> GenerateFileContent(ComponentContextGenerator generator)
	{
		Contract.NotNull(Metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123676484));
		Contract.NotNull(Metadata.Content, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FEDC45));
		Contract.NotNull(Metadata.Content.Context, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A32E964));
		ComponentContextMetadata context = Metadata.Content.Context;
		EntityMetadata entityMetadata = (EntityMetadata)(((ICodeGenerator)generator).Metadata = new EntityMetadata
		{
			Properties = context.Properties,
			Namespace = Metadata.Namespace,
			Name = context.Name,
			DisplayName = context.DisplayName,
			Uid = context.Uid,
			Type = EntityMetadataType.Entity
		});
		((ICodeGenerator)generator).GenerationParams.Mode = generationParams.Mode;
		return generator.Generate();
	}

	protected IEnumerable<ISyntaxNode> GenerateDataClasses(DataClassGenerator dataClassGenerator)
	{
		Contract.NotNull(Metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629808160));
		List<ISyntaxNode> list = new List<ISyntaxNode>();
		using List<DataClassMetadata>.Enumerator enumerator = Metadata.DataClasses.GetEnumerator();
		while (enumerator.MoveNext())
		{
			DataClassMetadata dataClassMetadata = (DataClassMetadata)(((ICodeGenerator)dataClassGenerator).Metadata = enumerator.Current);
			((ICodeGenerator)dataClassGenerator).GenerationParams.Mode = generationParams.Mode;
			dataClassGenerator.AddIgnoreNamespace(Metadata.Namespace);
			list.AddRange(dataClassGenerator.Generate());
		}
		return list;
	}

	protected virtual ISyntaxNode GenerateViewModel()
	{
		ComponentViewModelGenerator componentViewModelGenerator = new ComponentViewModelGenerator();
		jBiqWdBVfHtwVunfNie2(componentViewModelGenerator, Metadata);
		return (ISyntaxNode)JO0w3tBVQJ3QVYKXpLWE(componentViewModelGenerator);
	}

	protected virtual IEnumerable<ISyntaxTrivia> WriteLocalizationResources()
	{
		List<ISyntaxTrivia> list = Resources().ToList();
		if (list.Any())
		{
			list.Insert(0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1636D3B1).TextComment());
			return list;
		}
		return Enumerable.Empty<ISyntaxTrivia>();
	}

	[IteratorStateMachine(typeof(_003CResources_003Ed__17))]
	protected virtual IEnumerable<ISyntaxTrivia> Resources()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CResources_003Ed__17(-2)
		{
			_003C_003E4__this = this
		};
	}

	private ISyntaxNode GenerateServerController()
	{
		ComponentServerControllerGenerator componentServerControllerGenerator = new ComponentServerControllerGenerator();
		jBiqWdBVfHtwVunfNie2(componentServerControllerGenerator, Metadata);
		return (ISyntaxNode)dNHP5jBVC8TTGmHMTGbR(componentServerControllerGenerator);
	}

	private ISyntaxNode CreateContainerTypeDeclaration()
	{
		int num = 1;
		int num2 = num;
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		while (true)
		{
			switch (num2)
			{
			case 1:
				syntaxNode = ((string)O3RB5UBVE05QL6tNrP0y(Metadata)).ClassDeclaration(Accessibility.Internal, DeclarationModifiers.Partial, null, null, GenerateMainFileContent());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				if (u6FAXbBVvBURsHWJE2uy(generationParams) == GenerationMode.Publish)
				{
					num2 = 3;
					continue;
				}
				break;
			case 3:
				WriteBasicAttributes(syntaxNode);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				break;
			}
			break;
		}
		return syntaxNode;
	}

	public ComponentMetadataGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool VyEWlZBVBqmplPtge1g1()
	{
		return aE4VSTBVF0sGiHCKJ5ew == null;
	}

	internal static ComponentMetadataGenerator WEPydxBVW1U4NCBoM2F7()
	{
		return aE4VSTBVF0sGiHCKJ5ew;
	}

	internal static object zx12h1BVojUZ4Hc6aLDC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Ep9IXqBVbkMWIZmP1l0X(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void cj6pTkBVhmNqvxSwPEw9(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object CchBsVBVG1JKSgaJJe3b(object P_0)
	{
		return ((ComponentMetadata)P_0).Namespace;
	}

	internal static object O3RB5UBVE05QL6tNrP0y(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static void jBiqWdBVfHtwVunfNie2(object P_0, object P_1)
	{
		((ICodeGenerator)P_0).Metadata = (IMetadata)P_1;
	}

	internal static object JO0w3tBVQJ3QVYKXpLWE(object P_0)
	{
		return ((ComponentViewModelGenerator)P_0).Generate();
	}

	internal static object dNHP5jBVC8TTGmHMTGbR(object P_0)
	{
		return ((ComponentServerControllerGenerator)P_0).Generate();
	}

	internal static GenerationMode u6FAXbBVvBURsHWJE2uy(object P_0)
	{
		return ((GenerationParams)P_0).Mode;
	}

	internal static object Vo7CYhBV8lm5T4cXQFfg(object P_0)
	{
		return ((string)P_0).TextComment();
	}
}
