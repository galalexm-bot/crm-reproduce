using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

internal class DataClassGenerator : ClassGenerator
{
	internal static DataClassGenerator Nwoqo6he1S2hahxA1gbu;

	private static DataClassDescriptor DataClassDescriptor => Locator.GetServiceNotNull<DataClassDescriptor>();

	public IEnumerable<ISyntaxNode> Generate()
	{
		return ((ICollection<string>)ignoreNamespaces).WithIgnoreNamespaces((Func<IEnumerable<ISyntaxNode>>)GenerateMainFile);
	}

	internal void AddIgnoreNamespace(string ignoreNamespace)
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
				ignoreNamespaces.Add(ignoreNamespace);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override Accessibility GetMainClassAccessibility()
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return Accessibility.Internal;
			default:
				return Accessibility.Public;
			case 1:
				if (!AL8aeLhepA4SaNG72HM8(metadata))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> GetBaseInterfaces()
	{
		return new ISyntaxNode[1] { typeof(IDataClass).CreateTypeSyntax() };
	}

	protected override ISyntaxNode GetBaseClass()
	{
		return (ISyntaxNode)NGRne3heDhLtVNcchPh2(g9SkvSheaHPGNm3Naj39(typeof(DataClass).TypeHandle));
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return base.GetMembers().If(generationParams.Mode == GenerationMode.Publish, (IEnumerable<ISyntaxNode> _) => _.Concat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307DCDEF).FieldDeclaration(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575931690).CreateTypeSyntax(), Accessibility.Private, DeclarationModifiers.Static | DeclarationModifiers.ReadOnly, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475946613).CreateTypeSyntax().MemberAccessExpression(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x724740FE).GenericName(metadata.TypeName.CreateTypeSyntax()))
			.InvocationExpression())));
	}

	protected override IEnumerable<ISyntaxNode> GetCtors(List<ISyntaxNode> ctorStatements)
	{
		return new ISyntaxNode[1] { SyntaxGeneratorExtensions.ConstructorDeclaration(CtorParameters(), CtorAccessibility(), DeclarationModifiers.None, new ISyntaxNode[1] { (generationParams.Mode == GenerationMode.Publish) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C31445).IdentifierName() : SyntaxGeneratorExtensions.Null }, ctorStatements) };
	}

	protected override void WritePropertyAttributes(ISyntaxNode property, PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_00ba
		int num = 5;
		int num2 = num;
		int num3 = default(int);
		PropertyMetadataAdditionalAttribute[] additionalAttributes = default(PropertyMetadataAdditionalAttribute[]);
		string fullName = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 7:
				property.AddAttributes(TypeOf<EditorBrowsableAttribute>.Raw.CreateAttribute(EditorBrowsableState.Never));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 6;
				}
				break;
			case 8:
			case 12:
				if (num3 >= additionalAttributes.Length)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 13;
			case 0:
				return;
			case 4:
				if (propertyMetadata.AdditionalAttributes.Length == 0)
				{
					num2 = 10;
					break;
				}
				goto case 2;
			case 5:
				if (propertyMetadata.AdditionalAttributes != null)
				{
					num2 = 4;
					break;
				}
				goto case 10;
			case 9:
				num3 = 0;
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 3;
				}
				break;
			case 10:
			case 11:
				base.WritePropertyAttributes(property, propertyMetadata, resourcePrefix);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				fullName = TypeOf<ObsoleteAttribute>.FullName;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
			case 6:
				num3++;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 6;
				}
				break;
			case 13:
				if (!(additionalAttributes[num3].AddtibuteName == fullName))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 3:
				additionalAttributes = propertyMetadata.AdditionalAttributes;
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 8;
				}
				break;
			}
		}
	}

	protected override void WriteTypeAttributes(ISyntaxNode type)
	{
		//Discarded unreachable code: IL_00a6, IL_00b5, IL_011b, IL_012a, IL_023a, IL_024d
		int num = 5;
		List<DataClassDependency>.Enumerator enumerator = default(List<DataClassDependency>.Enumerator);
		DataClassMetadata dataClassMetadata2 = default(DataClassMetadata);
		DataClassDependency current = default(DataClassDependency);
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 4:
					if (ep5TvthetF3V6QKvAcmD(generationParams) != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 2;
						}
						continue;
					}
					base.WriteTypeAttributes(type);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 4;
					}
					continue;
				case 7:
					return;
				case 2:
					break;
				case 3:
					return;
				case 6:
					enumerator = dataClassMetadata2.IncludeList.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					if ((dataClassMetadata2 = metadata as DataClassMetadata) == null)
					{
						return;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							IL_019b:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
								{
									num3 = 0;
								}
								goto IL_0139;
							}
							goto IL_0184;
							IL_0184:
							current = enumerator.Current;
							int num4 = 4;
							num3 = num4;
							goto IL_0139;
							IL_0139:
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 0:
									return;
								case 4:
									dataClassMetadata = (DataClassMetadata)dAL8Avhe6o7NHihv5vlq(zF1tKhhewlB3OcmbWlEt(), YoLVukhe48q8EsuHc10N(current));
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
									{
										num3 = 1;
									}
									continue;
								case 2:
									break;
								case 3:
									goto IL_019b;
								case 1:
									type.AddAttributes(g9SkvSheaHPGNm3Naj39(typeof(IncludeAttribute).TypeHandle).CreateAttribute(WTnNZeheAKem2rXxJd3Z(oUuY17heHJMvpilW7ami(dataClassMetadata).ToString())));
									num3 = 3;
									continue;
								}
								break;
							}
							goto IL_0184;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
				}
				break;
			}
			WriteIncludeComments(type, dataClassMetadata2);
			num = 3;
		}
	}

	protected override GeneratedFileInfo GenerateMainFileInternal()
	{
		//Discarded unreachable code: IL_009e, IL_00c9, IL_01d3, IL_0217, IL_0226
		int num = 1;
		int num2 = num;
		GeneratedFileInfo result = default(GeneratedFileInfo);
		ISyntaxTrivia[] array = default(ISyntaxTrivia[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.NotNull(metadata, (string)b2a5fche7d2YLB7bGku8(0x5A4C7B29 ^ 0x5A4C3217));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				ISyntaxNode syntaxNode = ((string)DNdXeuhexEud7YZ6kXJT(metadata)).NamespaceDeclaration(GetNamespaces().Concat(GenerateMainFile()));
				int num3 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num3 = 2;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return result;
					case 0:
						return result;
					case 3:
						if (array.Length == 0)
						{
							num3 = 4;
							break;
						}
						goto case 5;
					case 5:
						syntaxNode.TextCommentsTrailing(array);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num3 = 0;
						}
						break;
					case 2:
						array = WriteLocalizationResources().ToArray();
						num3 = 3;
						break;
					case 1:
					case 4:
						result = GenerateMainFileHelper((string)rk9Cf1heyS4Pkm2OxQrW((!OKPJ5Zhe0x40bT24Sqqv(generationParams.Prefix)) ? (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70036252) + (string)YINXVkhemhTG4G4c8VxQ(generationParams)) : "", b2a5fche7d2YLB7bGku8(0x49E27B8A ^ 0x49E362C4)), syntaxNode);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num3 = 0;
						}
						break;
					}
				}
			}
			catch (Exception innerException)
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				default:
					throw new CodeGenerationException(SR.T((string)b2a5fche7d2YLB7bGku8(-2138160520 ^ -2138090248), metadata.Name), innerException);
				}
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> WriteProperty(PropertyMetadata propertyMetadata, List<ISyntaxNode> ctorStatements, bool writeAttributes = true, Action<ISyntaxNode> propertyAction = null)
	{
		if (propertyMetadata.TypeUid == ActionDescriptor.UID)
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		ITypeGenerationInfo typeDescriptor = (ITypeGenerationInfo)GetPropertyTypeDescriptor(propertyMetadata);
		ISyntaxNode propertyTypeReference = GetPropertyTypeReference(propertyMetadata, typeDescriptor);
		IEnumerable<ISyntaxNode> getAccessorStatements = null;
		IEnumerable<ISyntaxNode> setAccessorStatements = null;
		if (generationParams.Mode == GenerationMode.Publish)
		{
			getAccessorStatements = new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521322344).GenericName(propertyTypeReference).InvocationExpression(CodeGenerator.CreateGuid(metadata.Uid), CodeGenerator.CreateGuid(propertyMetadata.Uid))
				.ReturnStatement() };
			setAccessorStatements = new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289750754).GenericName(propertyTypeReference).InvocationExpression(CodeGenerator.CreateGuid(metadata.Uid), CodeGenerator.CreateGuid(propertyMetadata.Uid), SyntaxGeneratorExtensions.Value) };
		}
		ISyntaxNode syntaxNode = PropertyDeclaration(propertyMetadata, propertyTypeReference, getAccessorStatements, setAccessorStatements);
		WritePropertyComments(syntaxNode, propertyMetadata);
		if (generationParams.Mode == GenerationMode.Publish)
		{
			WritePropertyAttributes(syntaxNode, propertyMetadata);
		}
		return new ISyntaxNode[1] { syntaxNode };
	}

	protected override ISyntaxNode PropertyDeclaration(PropertyMetadata propertyMetadata, ISyntaxNode propertyType, IEnumerable<ISyntaxNode> getAccessorStatements = null, IEnumerable<ISyntaxNode> setAccessorStatements = null)
	{
		bool flag = false;
		if (propertyMetadata.TypeUid == ListOfSimpleTypeDescriptor.UID)
		{
			flag = true;
		}
		else
		{
			RelationType? relationType = GetRelationType(propertyMetadata);
			if (relationType.HasValue && relationType != RelationType.OneToOne)
			{
				flag = true;
			}
		}
		return propertyMetadata.Name.PropertyDeclaration(propertyType, Accessibility.Public, DeclarationModifiers.Virtual, getAccessorStatements, setAccessorStatements, Accessibility.NotApplicable, flag ? Accessibility.Private : Accessibility.NotApplicable);
	}

	protected override IEnumerable<ISyntaxNode> UidStaticMembers(bool useNewKeyword = false)
	{
		return Enumerable.Empty<ISyntaxNode>();
	}

	protected override IEnumerable<ISyntaxTrivia> WriteLocalizationResources()
	{
		List<ISyntaxTrivia> list = base.WriteLocalizationResources().ToList();
		foreach (PropertyMetadata property in metadata.Properties)
		{
			ISyntaxTrivia syntaxTrivia = GetLocalizableText(property.DisplayName).TextComment();
			if (syntaxTrivia != null)
			{
				list.Add(syntaxTrivia);
			}
			ISyntaxTrivia syntaxTrivia2 = GetLocalizableText(property.Description).TextComment();
			if (syntaxTrivia2 != null)
			{
				list.Add(syntaxTrivia2);
			}
		}
		return list;
	}

	protected internal void WriteIncludeComments(ISyntaxNode type, DataClassMetadata dataClassMetadata)
	{
		int num = 4;
		int num2 = num;
		List<ISyntaxTrivia> list = default(List<ISyntaxTrivia>);
		List<DataClassDependency> includeList = default(List<DataClassDependency>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 7:
				type.TextComments(list);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				list.Add((ISyntaxTrivia)DUMRQdheM4WobOIhwnB3(SR.T((string)b2a5fche7d2YLB7bGku8(0x49E27B8A ^ 0x49E12768))));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				WriteIncludeComments(list, includeList);
				num2 = 6;
				break;
			case 2:
				if (includeList.Count > 0)
				{
					num2 = 5;
					break;
				}
				goto case 1;
			case 0:
				return;
			case 6:
				if (kUxyKLheJuvKlPETVdfY(list) <= 0)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 7;
				}
				break;
			case 4:
				list = new List<ISyntaxTrivia>();
				num2 = 3;
				break;
			case 3:
				includeList = dataClassMetadata.IncludeList;
				num2 = 2;
				break;
			}
		}
	}

	private static void WriteIncludeComments(ICollection<ISyntaxTrivia> comments, IEnumerable<DataClassDependency> includeList, string indent = null)
	{
		foreach (DataClassDependency include in includeList)
		{
			comments.Add(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A626896), indent, include.Name, include.ModuleUid, include.HeaderUid).TextComment());
			try
			{
				DataClassMetadata metadataByUid = DataClassDescriptor.GetMetadataByUid(include.HeaderUid);
				if (metadataByUid != null)
				{
					WriteIncludeComments(comments, metadataByUid.IncludeList, indent + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4F2643));
				}
			}
			catch (Exception)
			{
			}
		}
	}

	public DataClassGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cgVqLqhe9Gs1GEDjs4xx();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool JRcd83heNqpq5AAxKdLh()
	{
		return Nwoqo6he1S2hahxA1gbu == null;
	}

	internal static DataClassGenerator rmHpoUhe3UC21DjfEljs()
	{
		return Nwoqo6he1S2hahxA1gbu;
	}

	internal static bool AL8aeLhepA4SaNG72HM8(object P_0)
	{
		return ((AbstractMetadata)P_0).Internal;
	}

	internal static Type g9SkvSheaHPGNm3Naj39(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object NGRne3heDhLtVNcchPh2(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static GenerationMode ep5TvthetF3V6QKvAcmD(object P_0)
	{
		return ((GenerationParams)P_0).Mode;
	}

	internal static object zF1tKhhewlB3OcmbWlEt()
	{
		return DataClassDescriptor;
	}

	internal static Guid YoLVukhe48q8EsuHc10N(object P_0)
	{
		return ((Dependency)P_0).HeaderUid;
	}

	internal static object dAL8Avhe6o7NHihv5vlq(object P_0, Guid typeUid)
	{
		return ((DataClassDescriptor)P_0).GetMetadataByUid(typeUid);
	}

	internal static Guid oUuY17heHJMvpilW7ami(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object WTnNZeheAKem2rXxJd3Z(object P_0)
	{
		return P_0.CreateSyntaxNode();
	}

	internal static object b2a5fche7d2YLB7bGku8(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object DNdXeuhexEud7YZ6kXJT(object P_0)
	{
		return ((ClassMetadata)P_0).Namespace;
	}

	internal static bool OKPJ5Zhe0x40bT24Sqqv(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object YINXVkhemhTG4G4c8VxQ(object P_0)
	{
		return ((GenerationParams)P_0).Prefix;
	}

	internal static object rk9Cf1heyS4Pkm2OxQrW(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object DUMRQdheM4WobOIhwnB3(object P_0)
	{
		return ((string)P_0).TextComment();
	}

	internal static int kUxyKLheJuvKlPETVdfY(object P_0)
	{
		return ((List<ISyntaxTrivia>)P_0).Count;
	}

	internal static void cgVqLqhe9Gs1GEDjs4xx()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
