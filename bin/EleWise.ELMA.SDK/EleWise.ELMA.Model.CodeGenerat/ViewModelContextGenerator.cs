using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.CodeGeneration;

public sealed class ViewModelContextGenerator : ClassGenerator
{
	private readonly Guid? parentMetadataUid;

	internal static ViewModelContextGenerator Qepm81hO6k3eF9Pb7gF1;

	private string ClassName => (string)K5VaKFhOxb530xJCG5yy(metadata.Name, IBlgY9hO7jGSXhwNCkIa(0x34185E55 ^ 0x341AEA61));

	private DataClassMetadata ViewModelMetadata => (DataClassMetadata)RU14SBhO0QFcZUnQp7uh((EntityMetadata)metadata);

	public ViewModelContextGenerator(Guid? parentMetadataUid)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.parentMetadataUid = parentMetadataUid;
	}

	public ISyntaxNode Generate()
	{
		int num = 1;
		int num2 = num;
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		while (true)
		{
			switch (num2)
			{
			case 1:
				syntaxNode = ClassName.ClassDeclaration(Accessibility.Internal, DeclarationModifiers.Sealed, (ISyntaxNode)p2xRmlhOmMaOyPTKM5GJ(this), null, GetMembers());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 0;
				}
				break;
			default:
				r3BErihOyWGZXlR0Lpi6(this, syntaxNode);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				WmuX6BhOM5yCB8mq5Sar(this, syntaxNode);
				num2 = 3;
				break;
			case 3:
				return syntaxNode;
			}
		}
	}

	protected override ISyntaxNode GetBaseClass()
	{
		return (ISyntaxNode)mReRAZhO9c6snBnAIZSE(E5QtqNhOJKJV7Qu6tQ8K(typeof(DataClass).TypeHandle));
	}

	protected override IEnumerable<ISyntaxNode> GetCtors(List<ISyntaxNode> ctorStatements)
	{
		return new ISyntaxNode[1] { SyntaxGeneratorExtensions.ConstructorDeclaration(CtorParameters(), CtorAccessibility(), DeclarationModifiers.None, new ISyntaxNode[1] { (generationParams.Mode == GenerationMode.Publish) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C31445).IdentifierName() : SyntaxGeneratorExtensions.Null }, ctorStatements) };
	}

	protected override void WriteTypeAttributes(ISyntaxNode type)
	{
		int num = 4;
		int num2 = num;
		Guid? guid = default(Guid?);
		while (true)
		{
			switch (num2)
			{
			case 2:
				guid = parentMetadataUid;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				type.AddAttributes(typeof(EntityMetadataUidAttribute).CreateAttribute(metadata.Uid.ToString()));
				num2 = 2;
				break;
			case 7:
				if (D82xbLhOl4w99HT91mTs(guid.Value, Guid.Empty))
				{
					num2 = 8;
					break;
				}
				return;
			default:
				if (guid.HasValue)
				{
					num2 = 5;
					break;
				}
				return;
			case 8:
			{
				ISyntaxNode[] array = new ISyntaxNode[1];
				Type attributeType = E5QtqNhOJKJV7Qu6tQ8K(typeof(IncludeAttribute).TypeHandle);
				object[] array2 = new object[1];
				guid = parentMetadataUid;
				array2[0] = guid.Value.ToString();
				array[0] = attributeType.CreateAttribute(array2);
				type.AddAttributes(array);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 5;
				}
				break;
			}
			case 4:
				type.AddAttributes(E5QtqNhOJKJV7Qu6tQ8K(typeof(UidAttribute).TypeHandle).CreateAttribute(wb80SLhOdtWh0B6Pn6WQ(ViewModelMetadata).ToString()));
				num2 = 3;
				break;
			case 3:
				type.AddAttributes(E5QtqNhOJKJV7Qu6tQ8K(typeof(MetadataTypeAttribute).TypeHandle).CreateAttribute(E5QtqNhOJKJV7Qu6tQ8K(typeof(DataClassMetadata).TypeHandle)));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				return;
			case 5:
				guid = parentMetadataUid;
				num2 = 7;
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGetMembers_003Ed__11))]
	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetMembers_003Ed__11(-2)
		{
			_003C_003E4__this = this
		};
	}

	protected override IEnumerable<ISyntaxNode> WriteProperty(PropertyMetadata propertyMetadata, List<ISyntaxNode> ctorStatements, bool writeAttributes = true, Action<ISyntaxNode> propertyAction = null)
	{
		Contract.ArgumentNotNull(propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B36E25B));
		if (propertyMetadata.TypeUid == ActionDescriptor.UID)
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		if (propertyMetadata is IViewModelPropertyMetadata viewModelPropertyMetadata && viewModelPropertyMetadata.ClientOnly)
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		ITypeGenerationInfo typeDescriptor = (ITypeGenerationInfo)GetPropertyTypeDescriptor(propertyMetadata);
		ISyntaxNode propertyTypeReference = GetPropertyTypeReference(propertyMetadata, typeDescriptor);
		IEnumerable<ISyntaxNode> getAccessorStatements = null;
		IEnumerable<ISyntaxNode> setAccessorStatements = null;
		if (generationParams.Mode == GenerationMode.Publish)
		{
			getAccessorStatements = new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123685856).InvocationExpression(CodeGenerator.CreateGuid(ViewModelMetadata.Uid), CodeGenerator.CreateGuid(propertyMetadata.Uid)).CastExpression(propertyTypeReference)
				.ReturnStatement() };
			setAccessorStatements = new ISyntaxNode[1] { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488697409).InvocationExpression(CodeGenerator.CreateGuid(ViewModelMetadata.Uid), CodeGenerator.CreateGuid(propertyMetadata.Uid), SyntaxGeneratorExtensions.Value) };
		}
		ISyntaxNode syntaxNode = propertyMetadata.Name.PropertyDeclaration(propertyTypeReference, Accessibility.Public, DeclarationModifiers.None, getAccessorStatements, setAccessorStatements, Accessibility.NotApplicable, (propertyMetadata.Name == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AD1294)) ? Accessibility.Private : Accessibility.NotApplicable);
		if (writeAttributes)
		{
			WritePropertyComments(syntaxNode, propertyMetadata);
		}
		return new ISyntaxNode[1] { syntaxNode };
	}

	protected override ISyntaxNode GetPropertyTypeReference(PropertyMetadata propertyMetadata, ITypeGenerationInfo typeDescriptor)
	{
		int num = 1;
		int num2 = num;
		DataClassMetadata dataClassMetadata = default(DataClassMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				DataClassMetadata dataClassMetadata2 = new DataClassMetadata();
				AQC5i9hOr44WEuPFXNtq(dataClassMetadata2, wb80SLhOdtWh0B6Pn6WQ(metadata));
				R2EHXehOg9lTQwwQUtYi(dataClassMetadata2, metadata.BaseClassUid);
				dataClassMetadata2.isInterfaceType = T1w05qhO5UbVIfwY7a48(metadata);
				dataClassMetadata = dataClassMetadata2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				break;
			}
			default:
				return (ISyntaxNode)zdMy2QhOjWrOI2TQort6(typeDescriptor, dataClassMetadata, propertyMetadata, false);
			}
		}
	}

	internal static object IBlgY9hO7jGSXhwNCkIa(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object K5VaKFhOxb530xJCG5yy(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool keiC8rhOHJyOY62MBXHT()
	{
		return Qepm81hO6k3eF9Pb7gF1 == null;
	}

	internal static ViewModelContextGenerator SnvuTjhOA5Qq3jKncSpS()
	{
		return Qepm81hO6k3eF9Pb7gF1;
	}

	internal static object RU14SBhO0QFcZUnQp7uh(object P_0)
	{
		return ((EntityMetadata)P_0).ViewModelMetadata;
	}

	internal static object p2xRmlhOmMaOyPTKM5GJ(object P_0)
	{
		return ((ClassGenerator)P_0).GetBaseClass();
	}

	internal static void r3BErihOyWGZXlR0Lpi6(object P_0, object P_1)
	{
		((ClassGenerator)P_0).WriteComments((ISyntaxNode)P_1);
	}

	internal static void WmuX6BhOM5yCB8mq5Sar(object P_0, object P_1)
	{
		((ClassGenerator)P_0).WriteTypeAttributes((ISyntaxNode)P_1);
	}

	internal static Type E5QtqNhOJKJV7Qu6tQ8K(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object mReRAZhO9c6snBnAIZSE(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static Guid wb80SLhOdtWh0B6Pn6WQ(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool D82xbLhOl4w99HT91mTs(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void AQC5i9hOr44WEuPFXNtq(object P_0, Guid value)
	{
		((AbstractMetadata)P_0).Uid = value;
	}

	internal static void R2EHXehOg9lTQwwQUtYi(object P_0, Guid value)
	{
		((ClassMetadata)P_0).BaseClassUid = value;
	}

	internal static bool T1w05qhO5UbVIfwY7a48(object P_0)
	{
		return ((ClassMetadata)P_0).IsInterfaceType;
	}

	internal static object zdMy2QhOjWrOI2TQort6(object P_0, object P_1, object P_2, bool forFilter)
	{
		return ((ITypeGenerationInfo)P_0).GetPropertyTypeReference((ClassMetadata)P_1, (PropertyMetadata)P_2, forFilter);
	}
}
