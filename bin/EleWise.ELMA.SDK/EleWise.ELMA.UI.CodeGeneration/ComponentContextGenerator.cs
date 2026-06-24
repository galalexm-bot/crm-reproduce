using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.CodeGeneration;

internal class ComponentContextGenerator : ClassGenerator
{
	internal static ComponentContextGenerator dC2nOVBIjJUqKEsv1i3y;

	public IEnumerable<ISyntaxNode> Generate()
	{
		return GenerateMainFile();
	}

	protected override IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		ISyntaxNode syntaxNode = ignoreNamespaces.WithIgnoreNamespaces(() => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538534894).ClassDeclaration(Accessibility.Internal, DeclarationModifiers.None, GetBaseClass(), GetBaseInterfaces(), GetMembers()));
		WriteComments(syntaxNode);
		WriteTypeAttributes(syntaxNode);
		ISyntaxTrivia[] array = WriteLocalizationResources().ToArray();
		if (array.Length != 0)
		{
			syntaxNode.TextCommentsTrailing(array);
		}
		return new ISyntaxNode[1] { syntaxNode };
	}

	protected override void WriteTypeAttributes(ISyntaxNode type)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				if (OdARsqBIUqiqevqXo3ZF(generationParams) != 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 1;
					}
					break;
				}
				type.AddAttributes(b9CYDXBIsrW1c0bEq3OR(typeof(UidAttribute).TypeHandle).CreateAttribute(zfBqvsBIcKeisooysmD3(metadata).ToString()), b9CYDXBIsrW1c0bEq3OR(typeof(MetadataTypeAttribute).TypeHandle).CreateAttribute(b9CYDXBIsrW1c0bEq3OR(typeof(ComponentContextMetadata).TypeHandle)), b9CYDXBIsrW1c0bEq3OR(typeof(DefaultManagerAttribute).TypeHandle).CreateAttribute(b9CYDXBIsrW1c0bEq3OR(typeof(MemoryEntityManagerMaker).TypeHandle)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 0:
				return;
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> WriteProperty(PropertyMetadata propertyMetadata, List<ISyntaxNode> ctorStatements, bool writeAttributes = true, Action<ISyntaxNode> propertyAction = null)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.propertyMetadata = propertyMetadata;
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3314360));
		if (CS_0024_003C_003E8__locals0.propertyMetadata.TypeUid == ActionDescriptor.UID)
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		if (!(CS_0024_003C_003E8__locals0.propertyMetadata is IViewModelPropertyMetadata viewModelPropertyMetadata) || viewModelPropertyMetadata.ClientOnly)
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		bool flag = generationParams.Mode == GenerationMode.Publish;
		if (!flag)
		{
			propertyAction = delegate(ISyntaxNode property)
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
						_003C_003Ec__DisplayClass4_0.VO5XwIQErPh8Puqoomx5(CS_0024_003C_003E8__locals0._003C_003E4__this, property, CS_0024_003C_003E8__locals0.propertyMetadata);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			};
		}
		return base.WriteProperty(CS_0024_003C_003E8__locals0.propertyMetadata, ctorStatements, flag, propertyAction);
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
		if (propertyMetadata is IViewModelPropertyMetadata viewModelPropertyMetadata && viewModelPropertyMetadata.Input)
		{
			return propertyMetadata.Name.PropertyDeclaration(propertyType, Accessibility.Public, DeclarationModifiers.Virtual, getAccessorStatements, setAccessorStatements, Accessibility.NotApplicable, Accessibility.Private);
		}
		return propertyMetadata.Name.PropertyDeclaration(propertyType, Accessibility.Public, DeclarationModifiers.Virtual, getAccessorStatements, setAccessorStatements, Accessibility.NotApplicable, flag ? Accessibility.Private : Accessibility.NotApplicable);
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

	public ComponentContextGenerator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ShcJnYBIzpgd7TURTyrv();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static GenerationMode OdARsqBIUqiqevqXo3ZF(object P_0)
	{
		return ((GenerationParams)P_0).Mode;
	}

	internal static Type b9CYDXBIsrW1c0bEq3OR(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Guid zfBqvsBIcKeisooysmD3(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static bool qmy0RjBIYu6e4cO724eM()
	{
		return dC2nOVBIjJUqKEsv1i3y == null;
	}

	internal static ComponentContextGenerator fF9UssBIL08foDckhSWA()
	{
		return dC2nOVBIjJUqKEsv1i3y;
	}

	internal static void ShcJnYBIzpgd7TURTyrv()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
