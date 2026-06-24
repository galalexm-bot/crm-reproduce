using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EleWise.TemplateGenerator.Helpers;

namespace EleWise.TemplateGenerator.DataSources;

public class DefaultObjectGeneratorDataSource : IGeneratorDataSource
{
	private object dataSourceObject;

	private Dictionary<string, BlockInfo> blockInfos = new Dictionary<string, BlockInfo>();

	public DefaultObjectGeneratorDataSource(object dataSourceObject)
	{
		this.dataSourceObject = dataSourceObject;
	}

	public FormatedValue GetVariableValue(string name)
	{
		if (dataSourceObject == null || string.IsNullOrEmpty(name))
		{
			return null;
		}
		string[] propertyNames = PropertyNamesHelper.GetPropertyNames(name);
		string text = ((propertyNames.Length != 0) ? propertyNames[0] : null);
		BlockInfo blockInfo;
		if (text != null && (blockInfo = GetBlockInfo(text)) != null)
		{
			return GetPropertiesExpressionValue(blockInfo.CurrentValue, CutPropertyNames(propertyNames));
		}
		return GetPropertiesExpressionValue(CreateFormatedValue(dataSourceObject), propertyNames);
	}

	public virtual BlockInfo EnterBlock(string identifier, FormatedValue value)
	{
		if (blockInfos.ContainsKey(identifier))
		{
			throw new InvalidOperationException($"Cycle with identifier \"{identifier}\" is already exists");
		}
		BlockInfo blockInfo = new BlockInfo();
		blockInfos[identifier] = blockInfo;
		IEnumerable enumerable = ((value != null) ? (value.Value as IEnumerable) : null);
		if (enumerable != null)
		{
			blockInfo.List = enumerable.Cast<object>().ToList();
			blockInfo.Count = blockInfo.List.Count;
		}
		return blockInfo;
	}

	public virtual void SetBlockIndex(string identifier, int index)
	{
		if (!blockInfos.TryGetValue(identifier, out var value))
		{
			return;
		}
		value.Index = index;
		if (value.List != null)
		{
			value.CurrentValue = CreateFormatedValue(value.List[index]);
			if (value.CurrentValue != null)
			{
				value.CurrentValue.BlockInfo = value;
			}
		}
	}

	public virtual void LeaveBlock(string identifier)
	{
		if (blockInfos.ContainsKey(identifier))
		{
			blockInfos.Remove(identifier);
		}
	}

	public virtual BlockInfo GetBlockInfo(string identifier)
	{
		blockInfos.TryGetValue(identifier, out var value);
		return value;
	}

	protected string[] CutPropertyNames(string[] arr)
	{
		if (arr.Length != 0)
		{
			string[] array = new string[arr.Length - 1];
			for (int i = 1; i < arr.Length; i++)
			{
				array[i - 1] = arr[i];
			}
			return array;
		}
		return arr;
	}

	protected virtual FormatedValue GetPropertiesExpressionValue(FormatedValue value, string[] propertyNames)
	{
		if (value == null || value.Value == null || propertyNames.Length == 0)
		{
			return value;
		}
		string text = propertyNames[0];
		if (string.IsNullOrEmpty(text))
		{
			return GetPropertiesExpressionValue(value, CutPropertyNames(propertyNames));
		}
		List<int> list = new List<int>();
		int num;
		while (text.EndsWith("]") && (num = text.LastIndexOf("[")) >= 0)
		{
			if (text.Length - num - 2 > 0 && int.TryParse(text.Substring(num + 1, text.Length - num - 2), out var result))
			{
				list.Add(result);
			}
			text = text.Substring(0, num);
		}
		FormatedValue formatedValue = GetPropertyValue(value, text);
		if (list.Count > 0)
		{
			foreach (int item in Enumerable.Reverse(list))
			{
				FormatedValue formatedValue2 = null;
				IList list2 = ((formatedValue != null) ? (formatedValue.Value as IList) : null);
				if (list2 != null)
				{
					if (item >= 0 && item < list2.Count)
					{
						formatedValue2 = CreateFormatedValue(list2[item]);
					}
				}
				else
				{
					IEnumerable enumerable = ((formatedValue != null) ? (formatedValue.Value as IEnumerable) : null);
					if (enumerable != null)
					{
						int num2 = 0;
						foreach (object item2 in enumerable)
						{
							if (num2 == item)
							{
								formatedValue2 = CreateFormatedValue(item2);
								break;
							}
							num2++;
						}
					}
				}
				formatedValue = formatedValue2;
			}
		}
		return GetPropertiesExpressionValue(formatedValue, CutPropertyNames(propertyNames));
	}

	protected virtual FormatedValue GetPropertyValue(FormatedValue container, string name)
	{
		if (container == null)
		{
			return null;
		}
		object value = container.Value;
		PropertyDescriptor propertyDescriptor = TypeDescriptor.GetProvider(value).GetTypeDescriptor(value).GetProperties()
			.Find(name, ignoreCase: false);
		if (propertyDescriptor != null)
		{
			return CreateFormatedValue(propertyDescriptor.GetValue(container.Value));
		}
		return null;
	}

	protected virtual FormatedValue CreateFormatedValue(object value)
	{
		return new FormatedValue(value);
	}
}
