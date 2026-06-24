using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Core.Engine.Metadata.Services.Abstractions;
using EleWise.ELMA.Core.Model.Managers;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Types.Storage;

namespace EleWise.ELMA.Core.Services;

[Service]
internal sealed class MetadataServiceContext : IMetadataServiceContext
{
	private readonly MetadataService metadataService;

	private readonly ICurrentPageService currentPageService;

	private readonly IMetadataReferenceStorage metadataReferenceStorage;

	private readonly TypedMap<string, PropertyInfoExpression> propertyExpressionCache = new TypedMap<string, PropertyInfoExpression>();

	private Guid CurrentModuleUid => currentPageService.CurrentPageViewModel?.ModuleUid ?? Guid.Empty;

	public MetadataServiceContext(MetadataService metadataService, ICurrentPageService currentPageService, IMetadataReferenceStorage metadataReferenceStorage)
	{
		this.metadataService = metadataService;
		this.currentPageService = currentPageService;
		this.metadataReferenceStorage = metadataReferenceStorage;
	}

	public IMetadata GetMetadata(Guid metadataUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetMetadata(CurrentModuleUid, metadataUid);
	}

	public System.Collections.Generic.IEnumerable<ClassMetadata> GetBaseClasses(Guid metadataUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetBaseClasses(CurrentModuleUid, metadataUid);
	}

	public System.Threading.Tasks.Task<IMetadata> GetMetadataAsync(Guid metadataUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetMetadataAsync(CurrentModuleUid, metadataUid);
	}

	public IMetadata GetMetadataByHash(string hash)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetMetadataByHash(CurrentModuleUid, hash);
	}

	public System.Collections.Generic.IEnumerable<MetadataHeader> GetMetadataHeaders(bool withDrafts)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetMetadataHeaders(CurrentModuleUid, withDrafts);
	}

	public System.Collections.Generic.IEnumerable<IMetadata> GetMetadataList()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetMetadataList(CurrentModuleUid);
	}

	public IMetadata LoadMetadata(System.Type type)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.LoadMetadata(CurrentModuleUid, type);
	}

	public void DeleteMetadata(Guid uid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		metadataService.DeleteMetadata(CurrentModuleUid, uid);
	}

	public System.Collections.Generic.IEnumerable<NamespaceMetadata> GetNamespaceMetadataList()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetNamespaceMetadataList(CurrentModuleUid);
	}

	public System.Collections.Generic.IEnumerable<NamespaceInfo> GetNamespaceInfoList()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetNamespaceInfoList(CurrentModuleUid);
	}

	public IPropertyMetadata GetProperty(ClassMetadata metadataDto, Guid propertyUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetProperty(CurrentModuleUid, metadataDto, propertyUid);
	}

	public ValueTuple<ClassMetadata, IPropertyMetadata> GetPropertyWithOwner(ClassMetadata metadataDto, Guid propertyUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetPropertyWithOwner(CurrentModuleUid, metadataDto, propertyUid);
	}

	public ValueTuple<PropertyMetadata, DataClassMetadata> FindProperty(DataClassMetadata dataClassMetadata, Guid propertyUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.FindProperty(CurrentModuleUid, dataClassMetadata, propertyUid);
	}

	public System.Collections.Generic.IEnumerable<IPropertyMetadata> GetProperties(ClassMetadata metadataDto, bool includeBase)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetProperties(CurrentModuleUid, metadataDto, includeBase);
	}

	public PropertyInfoExpression GetPropertyExpression(IPropertyMetadata property, ClassMetadata metadata)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		Contract.ArgumentNotNull(property, "property");
		Guid uid = ((IMetadata)property).get_Uid();
		string text = string.Concat((object)((IMetadata)metadata).get_Uid(), (object)"_", (object)uid);
		if (propertyExpressionCache.Has(text))
		{
			return propertyExpressionCache.Get(text);
		}
		string name = ((INamedMetadata)property).get_Name();
		DataClassMetadata val;
		PropertyInfoExpression propertyInfoExpression;
		if ((val = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null)) != null)
		{
			ValueTuple<PropertyMetadata, DataClassMetadata> val2 = FindProperty(val, uid);
			PropertyMetadata item = val2.Item1;
			DataClassMetadata item2 = val2.Item2;
			Guid uid2;
			if (item != null)
			{
				IMetadataReferenceStorage obj = metadataReferenceStorage;
				uid2 = ((IMetadata)item2).get_Uid();
				string expressionForSerialize = ((ISystemMetadataTypeReferenceStorage)obj).GetTypeReference(((object)(Guid)(ref uid2)).ToString()) + "$" + ((INamedMetadata)item).get_Name();
				propertyInfoExpression = new PropertyInfoExpression
				{
					ObjectExpression = $"{((INamedMetadata)item).get_Name()}${((IMetadata)item2).get_Uid():n}",
					ExpressionForSerialize = expressionForSerialize
				};
				propertyExpressionCache.Set(text, propertyInfoExpression);
				return propertyInfoExpression;
			}
			IMetadataReferenceStorage obj2 = metadataReferenceStorage;
			uid2 = ((IMetadata)val).get_Uid();
			string expressionForSerialize2 = ((ISystemMetadataTypeReferenceStorage)obj2).GetTypeReference(((object)(Guid)(ref uid2)).ToString()) + "$" + name;
			propertyInfoExpression = new PropertyInfoExpression
			{
				ObjectExpression = $"{name}${((IMetadata)val).get_Uid():n}",
				ExpressionForSerialize = expressionForSerialize2
			};
			propertyExpressionCache.Set(text, propertyInfoExpression);
			return propertyInfoExpression;
		}
		TablePartMetadata val3;
		if ((val3 = (TablePartMetadata)(object)((property is TablePartMetadata) ? property : null)) != null)
		{
			string tablePartPropertyName = val3.get_TablePartPropertyName();
			propertyInfoExpression = new PropertyInfoExpression
			{
				ObjectExpression = tablePartPropertyName,
				ExpressionForSerialize = tablePartPropertyName
			};
			propertyExpressionCache.Set(text, propertyInfoExpression);
			return propertyInfoExpression;
		}
		propertyInfoExpression = new PropertyInfoExpression
		{
			ObjectExpression = name,
			ExpressionForSerialize = name
		};
		propertyExpressionCache.Set(text, propertyInfoExpression);
		return propertyInfoExpression;
	}

	public System.Threading.Tasks.Task InitHeaders()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.InitHeaders(CurrentModuleUid);
	}

	public System.Threading.Tasks.Task<MetadataHeader> GetMetadataHeader(Guid metadataUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetMetadataHeader(CurrentModuleUid, metadataUid);
	}

	public System.Threading.Tasks.Task<bool> CheckChanges()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.CheckChanges(CurrentModuleUid);
	}

	public DataClassMetadata GetViewModelMetadata(EntityMetadata entityMetadata)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetViewModelMetadata(CurrentModuleUid, entityMetadata);
	}

	public System.Threading.Tasks.Task<DataClassMetadata> GetViewModelMetadataAsync(EntityMetadata entityMetadata)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetViewModelMetadataAsync(CurrentModuleUid, entityMetadata);
	}

	public System.Threading.Tasks.Task<List<ExtendMetadataModel>> GetMetadataListWithParents(EntityMetadata metadata)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetMetadataListWithParents(CurrentModuleUid, metadata);
	}

	public EntityMetadata GetTablePartRoot(TablePartMetadata tablePartMetadata)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return metadataService.GetTablePartRoot(CurrentModuleUid, tablePartMetadata);
	}

	internal void ProcessMetadata(IMetadata metadata)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		metadataService.ProcessMetadata(CurrentModuleUid, metadata);
	}

	internal void ProcessMetadata(System.Collections.Generic.IEnumerable<IMetadata> metadataList)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		metadataService.ProcessMetadata(CurrentModuleUid, metadataList);
	}
}
