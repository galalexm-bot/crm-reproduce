using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using EleWise.ELMA.UIBuilder.CodeGeneration.Types;

namespace EleWise.ELMA.UIBuilder.CodeGeneration;

internal sealed class DataClassWebGenerator : DataClassGenerator
{
	private readonly IUITypeGenerationFacade uiTypeGenerationFacade;

	private static DataClassDescriptor DataClassDescriptor => Locator.GetServiceNotNull<DataClassDescriptor>();

	public DataClassWebGenerator(IUITypeGenerationFacade uiTypeGenerationFacade)
	{
		this.uiTypeGenerationFacade = uiTypeGenerationFacade;
	}

	protected override IEnumerable<ISyntaxNode> GetBaseInterfaces()
	{
		return new ISyntaxNode[1] { typeof(IDataClass).CreateTypeSyntax(useGlobal: false) };
	}

	protected override ISyntaxNode GetBaseClass()
	{
		if (metadata is DataClassMetadata && metadata.IsInterfaceType)
		{
			return typeof(IDataClass).CreateTypeSyntax(useGlobal: false);
		}
		if (metadata is EntityMetadata && metadata.BaseClassUid != Guid.Empty)
		{
			return ((GetMetadata(metadata.BaseClassUid) as EntityMetadata) ?? throw new CodeGenerationException($"Base entity class for \"{metadata.TypeName}\" not found. Uid={metadata.BaseClassUid}")).FullTypeName.CreateTypeSyntax();
		}
		return typeof(DataClass).CreateTypeSyntax(useGlobal: false);
	}

	protected override IEnumerable<ISyntaxTrivia> Resources()
	{
		yield break;
	}

	protected override IEnumerable<ISyntaxTrivia> WriteLocalizationResources()
	{
		yield break;
	}

	protected override IEnumerable<ISyntaxNode> GetNamespaces()
	{
		if (generationParams.Mode != 0)
		{
			return new ISyntaxNode[2]
			{
				"System".NamespaceImportDeclaration(),
				"EleWise.ELMA.DataClasses".NamespaceImportDeclaration()
			};
		}
		return new ISyntaxNode[2]
		{
			"Bridge".NamespaceImportDeclaration(),
			"System".NamespaceImportDeclaration()
		};
	}

	protected override IEnumerable<ISyntaxNode> GenerateMainFile()
	{
		IEnumerable<ISyntaxNode> baseInterfaces = GetBaseInterfaces();
		ISyntaxNode syntaxNode = (metadata.IsInterfaceType ? metadata.TypeName.InterfaceDeclaration(GetMainClassAccessibility(), DeclarationModifiers.Partial, baseInterfaces, GetMembers()) : metadata.TypeName.ClassDeclaration(GetMainClassAccessibility(), DeclarationModifiers.Partial, GetBaseClass(), baseInterfaces, GetMembers()));
		WriteComments(syntaxNode);
		WriteTypeAttributes(syntaxNode);
		return new ISyntaxNode[1] { syntaxNode }.Concat(WriteTablePartClasses());
	}

	protected override IEnumerable<ISyntaxNode> GetMembers()
	{
		return GetProperties(new List<ISyntaxNode>());
	}

	protected override IEnumerable<ISyntaxNode> GetProperties(List<ISyntaxNode> ctorStatements)
	{
		IEnumerable<ISyntaxNode> enumerable = base.GetProperties(ctorStatements);
		if (metadata is EntityMetadata entityMetadata)
		{
			if (entityMetadata.BaseClassUid == Guid.Empty && entityMetadata.IdTypeUid != Guid.Empty)
			{
				ITypeDescriptor idTypeDescriptor = MetadataServiceContext.Service.GetIdTypeDescriptor(entityMetadata.IdTypeUid);
				if (idTypeDescriptor != null)
				{
					enumerable = enumerable.Concat(WriteProperty(new PropertyMetadata
					{
						Uid = Guid.NewGuid(),
						Name = "Id",
						DisplayName = SR.T("Уникальный идентификатор"),
						Settings = (TypeSettings)Activator.CreateInstance(idTypeDescriptor.SettingsType),
						IsSystem = true,
						Nullable = false,
						TypeUid = entityMetadata.IdTypeUid
					}, ctorStatements));
				}
			}
			enumerable = enumerable.Concat(WriteTablePartProperties(ctorStatements));
		}
		return enumerable;
	}

	protected override void WriteTypeAttributes(ISyntaxNode type)
	{
		if (metadata is DataClassMetadata dataClassMetadata && generationParams.Mode != 0)
		{
			WriteIncludeComments(type, dataClassMetadata);
		}
	}

	protected override void WritePropertyAttributes(ISyntaxNode property, PropertyMetadata propertyMetadata, string resourcePrefix = null)
	{
		if (generationParams.Mode != 0 || !(metadata is DataClassMetadata dataClassMetadata))
		{
			return;
		}
		property.AddAttributes("Bridge.Name".CreateAttribute($"{propertyMetadata.Name}${dataClassMetadata.Uid:n}"));
		if (propertyMetadata.AdditionalAttributes == null || propertyMetadata.AdditionalAttributes.Length == 0)
		{
			return;
		}
		string fullName = TypeOf<ObsoleteAttribute>.FullName;
		PropertyMetadataAdditionalAttribute[] additionalAttributes = propertyMetadata.AdditionalAttributes;
		for (int i = 0; i < additionalAttributes.Length; i++)
		{
			if (additionalAttributes[i].AddtibuteName == fullName)
			{
				property.AddAttributes(TypeOf<EditorBrowsableAttribute>.Raw.CreateAttribute(EditorBrowsableState.Never));
			}
		}
	}

	protected override IEnumerable<ISyntaxNode> WriteProperty(PropertyMetadata propertyMetadata, List<ISyntaxNode> ctorStatements, bool writeAttributes = true, Action<ISyntaxNode> propertyAction = null)
	{
		Contract.ArgumentNotNull(propertyMetadata, "propertyMetadata");
		ITypeDescriptor propertyTypeDescriptor = GetPropertyTypeDescriptor(propertyMetadata);
		if (propertyTypeDescriptor == null)
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		if (!uiTypeGenerationFacade.UIBuilderSupports(propertyTypeDescriptor))
		{
			return Enumerable.Empty<ISyntaxNode>();
		}
		ISyntaxNode propertyTypeReference = uiTypeGenerationFacade.GetPropertyTypeReference(propertyTypeDescriptor, metadata, propertyMetadata, forFilter: false);
		ISyntaxNode syntaxNode = PropertyDeclaration(propertyMetadata, propertyTypeReference, Enumerable.Empty<ISyntaxNode>(), Enumerable.Empty<ISyntaxNode>());
		if (writeAttributes)
		{
			WritePropertyAttributes(syntaxNode, propertyMetadata);
		}
		WritePropertyComments(syntaxNode, propertyMetadata);
		return new ISyntaxNode[1] { syntaxNode };
	}

	private IEnumerable<ISyntaxNode> WriteTablePartClasses()
	{
		Contract.NotNull(metadata, "metadata");
		if (metadata is EntityMetadata entityMetadata)
		{
			List<TablePartMetadata> tableParts = entityMetadata.TableParts;
			if (tableParts == null || tableParts.Count == 0)
			{
				return Enumerable.Empty<ISyntaxNode>();
			}
			List<ISyntaxNode> list = new List<ISyntaxNode>(tableParts.Count);
			{
				foreach (ISyntaxNode item in entityMetadata.TableParts.SelectMany(WriteTablePartClass))
				{
					list.Add(item);
				}
				return list;
			}
		}
		return Enumerable.Empty<ISyntaxNode>();
	}

	private IEnumerable<ISyntaxNode> WriteTablePartClass(TablePartMetadata tablePart)
	{
		Contract.ArgumentNotNull(tablePart, "tablePart");
		Contract.NotNull(metadata, "metadata");
		return new DataClassWebGenerator(uiTypeGenerationFacade)
		{
			GenerationParams = generationParams,
			Metadata = tablePart
		}.GenerateMainFile();
	}

	private IEnumerable<ISyntaxNode> WriteTablePartProperties(List<ISyntaxNode> ctorStatements)
	{
		Contract.NotNull(metadata, "metadata");
		if (metadata is EntityMetadata entityMetadata && entityMetadata.TableParts != null && entityMetadata.TableParts.Count != 0)
		{
			List<ISyntaxNode> list = new List<ISyntaxNode>(entityMetadata.TableParts.Count);
			{
				foreach (ISyntaxNode item in entityMetadata.TableParts.SelectMany((TablePartMetadata tablePart) => WriteTablePartProperty(tablePart, ctorStatements)))
				{
					list.Add(item);
				}
				return list;
			}
		}
		return Enumerable.Empty<ISyntaxNode>();
	}

	private IEnumerable<ISyntaxNode> WriteTablePartProperty(TablePartMetadata tablePart, List<ISyntaxNode> ctorStatements)
	{
		Contract.NotNull(metadata, "metadata");
		Contract.ArgumentNotNull(tablePart, "tablePart");
		if (metadata is EntityMetadata entityMetadata)
		{
			EntityPropertyTablePartMetadata propertyMetadata = new EntityPropertyTablePartMetadata(entityMetadata, tablePart);
			return WriteProperty(propertyMetadata, ctorStatements);
		}
		return Enumerable.Empty<ISyntaxNode>();
	}
}
