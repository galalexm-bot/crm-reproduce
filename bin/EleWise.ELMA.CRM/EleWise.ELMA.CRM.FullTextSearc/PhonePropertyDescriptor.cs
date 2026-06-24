using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.CRM.FullTextSearch.Components;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FullTextSearch.Descriptors;
using EleWise.ELMA.FullTextSearch.Enum;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.CRM.FullTextSearch.Descriptors;

internal sealed class PhonePropertyDescriptor : EntityPropertyDescriptor
{
	private const string IndexFieldValuePostfix = "_value";

	public PhonePropertyDescriptor(ISerializableTypeDescriptor typeDescriptor)
		: base(typeDescriptor)
	{
	}

	public override FieldIndexList GetMappingField(IPropertyMetadata propMd)
	{
		return new FieldIndexList
		{
			new FieldIndexListItem(propMd.Uid.ToString().ToLower() + "_value", null, FullTextFieldType.String, FullTextFieldTag.Value)
		};
	}

	public override FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd, bool reindex)
	{
		FieldIndexList indexField = base.GetIndexField(obj, propMd, reindex);
		FieldIndexList fieldIndexList = (reindex ? GetReIndexField(obj, propMd) : GetIndexField(obj, propMd));
		if (indexField == null)
		{
			return fieldIndexList;
		}
		indexField.AddRange(fieldIndexList);
		return indexField;
	}

	private FieldIndexList GetIndexField(object obj, IPropertyMetadata propMd)
	{
		if (propMd == null || obj == null)
		{
			return new FieldIndexList();
		}
		if (obj is IEnumerable<IPhone> source)
		{
			List<string> value = (from a in source
				select ContractorFullTextSearchExtension.ConvertPhoneNumber(a.PhoneString) into a
				where !string.IsNullOrWhiteSpace(a)
				select a).ToList();
			return new FieldIndexList
			{
				new FieldIndexListItem(propMd.Uid.ToString().ToLower() + "_value", value, FullTextFieldType.String)
			};
		}
		if (obj is IPhone phone)
		{
			return new FieldIndexList
			{
				new FieldIndexListItem(propMd.Uid.ToString().ToLower() + "_value", ContractorFullTextSearchExtension.ConvertPhoneNumber(phone.PhoneString), FullTextFieldType.String)
			};
		}
		return null;
	}

	private FieldIndexList GetReIndexField(object obj, IPropertyMetadata propMd)
	{
		if (propMd == null)
		{
			return new FieldIndexList();
		}
		Type type = obj.GetType();
		if (type.IsGenericType && (type.GetGenericTypeDefinition() == typeof(SerializableList<>) || type.GetGenericTypeDefinition() == typeof(List<>)))
		{
			IList<IPhone> list = (obj as IEnumerable).CastToListOrNull<IPhone>();
			if (list != null && list.Any())
			{
				List<string> list2 = (from a in list
					select ContractorFullTextSearchExtension.ConvertPhoneNumber(a.PhoneString) into a
					where !string.IsNullOrWhiteSpace(a)
					select a).ToList();
				if (list2.Any())
				{
					return new FieldIndexList
					{
						new FieldIndexListItem(propMd.Uid.ToString().ToLower() + "_value", list2, FullTextFieldType.String)
					};
				}
			}
			return new FieldIndexList
			{
				new FieldIndexListItem(propMd.Uid.ToString().ToLower() + "_value", null, FullTextFieldType.Long)
			};
		}
		IPhone phone = obj as IPhone;
		return new FieldIndexList
		{
			new FieldIndexListItem(propMd.Uid.ToString().ToLower() + "_value", ContractorFullTextSearchExtension.ConvertPhoneNumber(phone.PhoneString), FullTextFieldType.Long)
		};
	}

	public override FieldListItem GetSearchField(object value, IPropertyMetadata propMd)
	{
		return new FieldListItem($"{propMd.Uid.ToString().ToLower()}_value", (value == null) ? string.Empty : ContractorFullTextSearchExtension.ConvertPhoneNumber(value.ToString()));
	}

	public override FilterListItem GetFilterField(object value, IPropertyMetadata propMd, IEntityFilter filter)
	{
		if (value == null)
		{
			return null;
		}
		PropertyInfo property = filter.GetType().GetProperty(propMd.Name);
		if (property == null)
		{
			return null;
		}
		object value2 = property.GetValue(filter);
		if (value2 is IEnumerable<IPhone> enumerable)
		{
			List<object> list = new List<object>();
			foreach (IPhone item in enumerable)
			{
				string text = ContractorFullTextSearchExtension.ConvertPhoneNumber(item.PhoneString);
				if (!string.IsNullOrWhiteSpace(text))
				{
					list.Add(text);
				}
			}
			if (list.Any())
			{
				return new FilterListItem(propMd.Uid.ToString().ToLower() + "_value", list, FilterListItemType.Must, FullTextFieldType.String);
			}
		}
		else
		{
			string text2 = ContractorFullTextSearchExtension.ConvertPhoneNumber((value2 as IPhone).PhoneString);
			if (!string.IsNullOrWhiteSpace(text2))
			{
				return new FilterListItem(propMd.Uid.ToString().ToLower() + "_value", new List<object> { text2 }, FilterListItemType.Must, FullTextFieldType.String);
			}
		}
		return null;
	}
}
