using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Models.ConvertType;

public class PropertyInfo
{
	private Lazy<PropertyMetadata> propertyMetadata;

	public Guid TargetTypeUid { get; set; }

	public string Name { get; set; }

	public string DisplayName { get; set; }

	public Guid Uid { get; set; }

	public Guid ParentBlockUid { get; set; }

	public string ParentBlockName { get; set; }

	public Guid TypeUid { get; set; }

	public Guid SubTypeUid { get; set; }

	public bool IsSystem { get; set; }

	public bool IsBlock { get; set; }

	public RelationType RelationType { get; set; }

	public int Level { get; set; }

	public string BlockTreeName { get; set; }

	public string TypeDisplayName => GetTypeDisplayName();

	public PropertyMetadata PropertyMetadata
	{
		get
		{
			if (Uid != Guid.Empty && TargetTypeUid != Guid.Empty && propertyMetadata == null)
			{
				propertyMetadata = new Lazy<PropertyMetadata>(() => ((EntityMetadata)MetadataLoader.LoadMetadata(TargetTypeUid)).Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == Uid));
			}
			if (propertyMetadata == null)
			{
				return null;
			}
			return propertyMetadata.Value;
		}
	}

	public void SetPropertyDisplayName()
	{
		if (!(TargetTypeUid == Guid.Empty) && !(Uid == Guid.Empty))
		{
			EntityMetadata obj = (EntityMetadata)MetadataLoader.LoadMetadata(TargetTypeUid);
			PropertyInfo propertyInfo = GetChildPropsAndBlocks(obj, obj.Uid, Level, new Guid[0], BlockTreeName).FirstOrDefault((PropertyInfo m) => m.Uid == Uid);
			if (propertyInfo != null)
			{
				Name = propertyInfo.Name;
				DisplayName = propertyInfo.DisplayName;
				IsSystem = propertyInfo.IsSystem;
				TypeUid = propertyInfo.TypeUid;
				SubTypeUid = propertyInfo.SubTypeUid;
			}
		}
	}

	public static PropertyInfo[] Sort(IEnumerable<PropertyInfo> props)
	{
		List<PropertyInfo> list = new List<PropertyInfo>();
		list.AddRange(props);
		int num = props.Max((PropertyInfo p) => p.Level);
		int i;
		for (i = 1; i <= num; i++)
		{
			foreach (PropertyInfo propertyInfo in from p in props
				where p.Level == i
				orderby p.IsBlock
				select p)
			{
				PropertyInfo item = list.Find((PropertyInfo p) => p.Uid == propertyInfo.ParentBlockUid);
				list.Remove(propertyInfo);
				int num2 = list.IndexOf(item);
				list.Insert(num2 + 1, propertyInfo);
			}
		}
		return list.ToArray();
	}

	public static PropertyInfo[] GetChildPropsAndBlocks(EntityMetadata rootTablePart, Guid TargetTypeUid, int level, Guid[] systemFields, string ParentBlockTreeName)
	{
		List<PropertyInfo> retList = new List<PropertyInfo>();
		retList.AddRange(from w in rootTablePart.Properties
			where !(rootTablePart is TablePartMetadata) || (w.Name != "Uid" && w.Name != "Parent")
			select w into p
			select new PropertyInfo
			{
				TargetTypeUid = TargetTypeUid,
				Uid = p.Uid,
				Name = p.Name,
				DisplayName = p.DisplayName,
				TypeUid = p.TypeUid,
				SubTypeUid = p.SubTypeUid,
				IsSystem = systemFields.Contains(p.Uid),
				IsBlock = false,
				Level = level,
				BlockTreeName = ((rootTablePart is TablePartMetadata) ? (ParentBlockTreeName + "_" + p.Name) : p.Name),
				RelationType = ((p.SubTypeUid != Guid.Empty) ? ((p.Settings is EntitySettings) ? ((EntitySettings)p.Settings).RelationType : RelationType.OneToOne) : RelationType.OneToOne),
				ParentBlockUid = ((rootTablePart is TablePartMetadata) ? rootTablePart.Uid : Guid.Empty),
				ParentBlockName = ((rootTablePart is TablePartMetadata) ? rootTablePart.Name : string.Empty)
			});
		retList.AddRange(rootTablePart.TableParts.Select((TablePartMetadata p) => new PropertyInfo
		{
			TargetTypeUid = TargetTypeUid,
			Uid = p.Uid,
			Name = p.Name,
			DisplayName = p.DisplayName,
			IsSystem = systemFields.Contains(p.Uid),
			IsBlock = true,
			Level = level,
			BlockTreeName = ((rootTablePart is TablePartMetadata) ? (ParentBlockTreeName + "_" + p.Name) : p.Name),
			ParentBlockUid = ((rootTablePart is TablePartMetadata) ? rootTablePart.Uid : Guid.Empty),
			ParentBlockName = ((rootTablePart is TablePartMetadata) ? rootTablePart.Name : string.Empty)
		}));
		retList.AddRange(rootTablePart.TableParts.SelectMany((TablePartMetadata tp) => GetChildPropsAndBlocks(tp, TargetTypeUid, level + 1, systemFields, retList.FirstOrDefault((PropertyInfo p) => p.Uid == tp.Uid).BlockTreeName)));
		return retList.ToArray();
	}

	public static PropertyInfo[] GetPropertiesInfosForType(EntityMetadata targetTypeMetadata)
	{
		List<Guid> systemFields = new List<Guid>();
		ComponentManager.Current.GetExtensionPoints<IConvertDocumentSystemFields>().ForEach(delegate(IConvertDocumentSystemFields c)
		{
			systemFields.AddRange(c.GetSytemFieldsUids(targetTypeMetadata.Uid));
		});
		List<PropertyInfo> list = new List<PropertyInfo>();
		list.AddRange(GetChildPropsAndBlocks(targetTypeMetadata, targetTypeMetadata.Uid, 0, systemFields.ToArray(), string.Empty));
		return Sort(list);
	}

	public string GetTypeDisplayName()
	{
		if (IsBlock)
		{
			return SR.T("Блок");
		}
		ITypeDescriptor typeDescriptor = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(TypeUid, SubTypeUid);
		if (typeDescriptor == null)
		{
			return SR.T("<Неизвестный тип ({0})>", PropertyMetadata.TypeUid);
		}
		try
		{
			if (typeDescriptor is IPropertyTypeInfo propertyTypeInfo)
			{
				return propertyTypeInfo.GetPropertyTypeDisplayName(PropertyMetadata);
			}
			return typeDescriptor.Name;
		}
		catch
		{
		}
		return string.Empty;
	}
}
