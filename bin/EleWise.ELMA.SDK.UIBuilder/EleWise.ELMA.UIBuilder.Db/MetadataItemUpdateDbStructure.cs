using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;

namespace EleWise.ELMA.UIBuilder.Db;

internal sealed class MetadataItemUpdateDbStructure : DbStructureExtension
{
	private static readonly Regex regex = new Regex("(?<=\\[\")(?<typeRef>\\w+)\\$(?<propertyName>\\w+)(?=\"\\])");

	public override Guid ProviderUid => Guid.Empty;

	internal void ClearDynamicPropertyForms()
	{
		IEnumerable<IMetadataItem> itemsWithRuntimeV = MetadataItemManager.Instance.GetItemsWithRuntimeV2();
		foreach (IMetadataItem item in itemsWithRuntimeV)
		{
			if (itemsWithRuntimeV != null)
			{
				ClearMetadataItem(item);
				ClearMetadataItem(item);
			}
		}
		foreach (ComponentMetadataItemHeader item2 in ComponentMetadataItemHeaderManager.Instance.Find(FetchOptions.All))
		{
			if (item2 != null && !item2.IsDeleted)
			{
				ClearComponentMetadataItem(item2.Draft);
				ClearComponentMetadataItem(item2.Published);
				ClearComponentMetadataItem(item2.Emulation);
			}
		}
	}

	private void ClearComponentMetadataItem(ComponentMetadataItem metadataItem)
	{
		if (metadataItem?.Metadata is ComponentMetadata obj)
		{
			ComponentMetadata componentMetadata = ClassSerializationHelper.CloneObjectByXml(obj);
			DeleteEmptyFormItem(componentMetadata.Content.View);
			metadataItem.Metadata = componentMetadata;
			metadataItem.Save();
		}
	}

	private void ClearMetadataItem(IMetadataItem metadataItem)
	{
		if (!(metadataItem?.Metadata is EntityMetadata obj))
		{
			return;
		}
		bool flag = false;
		EntityMetadata entityMetadata = ClassSerializationHelper.CloneObjectByXml(obj);
		foreach (FormViewItem form in entityMetadata.Forms)
		{
			if (form.RuntimeVersion != 0)
			{
				DeleteEmptyFormItem(form);
				flag = true;
			}
		}
		if (flag)
		{
			metadataItem.Metadata = entityMetadata;
			metadataItem.Save();
		}
	}

	private void DeleteEmptyFormItem(ViewItem viewItem)
	{
		if (viewItem is RootViewItem rootViewItem)
		{
			List<ViewItem> list = new List<ViewItem>();
			foreach (ViewItem item in rootViewItem.Items)
			{
				if (item.Hide)
				{
					list.Add(item);
				}
				else
				{
					DeleteEmptyFormItem(item);
				}
			}
			foreach (ViewItem item2 in list)
			{
				rootViewItem.Items.Remove(item2);
			}
		}
		if (viewItem.DynamicProperties.Count == 0)
		{
			return;
		}
		ComputedValue[] array = viewItem.DynamicProperties.ToArray();
		foreach (ComputedValue computedValue in array)
		{
			if (computedValue is InputComputedValue)
			{
				continue;
			}
			if (computedValue.ComputedValueType == ComputedValueType.CalculateScript && string.IsNullOrWhiteSpace(computedValue.CalculateScript))
			{
				ClearProperty(viewItem, computedValue);
			}
			else if (computedValue.ComputedValueType == ComputedValueType.Function)
			{
				if (viewItem is ButtonViewItem buttonViewItem && computedValue.Name == "ButtonViewItem" && string.IsNullOrWhiteSpace(buttonViewItem.ScriptName))
				{
					ClearProperty(viewItem, computedValue);
				}
				else if (string.IsNullOrWhiteSpace(computedValue.MethodName))
				{
					ClearProperty(viewItem, computedValue);
				}
			}
			else
			{
				if (computedValue.ComputedValueType != 0)
				{
					continue;
				}
				if (computedValue.Value is ActionValue actionValue)
				{
					if ((actionValue.CodeType == CodeType.Client || actionValue.CodeType == CodeType.Server) && string.IsNullOrWhiteSpace(actionValue.MethodName))
					{
						ClearProperty(viewItem, computedValue);
					}
					else if (actionValue.CodeType == CodeType.GlobalFunction && actionValue.FunctionHeaderUid == Guid.Empty)
					{
						ClearProperty(viewItem, computedValue);
					}
				}
				else
				{
					ClearProperty(viewItem, computedValue);
				}
			}
		}
	}

	private void ClearProperty(ViewItem viewItem, ComputedValue dynamicProperty)
	{
		viewItem.DynamicProperties.Remove(dynamicProperty);
	}

	internal void UpdateClientScriptModules()
	{
		IDataClassMetadataTypeReferenceService serviceNotNull = Locator.GetServiceNotNull<IDataClassMetadataTypeReferenceService>();
		foreach (MetadataItemWithScriptModuleWrapper itemsWithClientScriptModule in MetadataItemManager.Instance.GetItemsWithClientScriptModules())
		{
			if (!(itemsWithClientScriptModule.Metadata is EntityMetadata entityMetadata))
			{
				continue;
			}
			DataClassMetadata viewModelMetadata = entityMetadata.ViewModelMetadata;
			if (viewModelMetadata == null)
			{
				continue;
			}
			ScriptModule scriptModule = itemsWithClientScriptModule.ScriptModule;
			if (scriptModule != null)
			{
				byte[] assemblyRaw = scriptModule.AssemblyRaw;
				if (assemblyRaw != null)
				{
					byte[] array2 = (scriptModule.AssemblyRaw = ProcessScriptModuleRaw(serviceNotNull, assemblyRaw, viewModelMetadata.Uid));
				}
				byte[] debugRaw = scriptModule.DebugRaw;
				if (debugRaw != null)
				{
					byte[] array4 = (scriptModule.DebugRaw = ProcessScriptModuleRaw(serviceNotNull, debugRaw, viewModelMetadata.Uid));
				}
				scriptModule.Save();
			}
		}
	}

	private static byte[] ProcessScriptModuleRaw(IDataClassMetadataTypeReferenceService typeReferenceService, byte[] raw, Guid metadataUid)
	{
		string @string = Encoding.UTF8.GetString(raw);
		string s = regex.Replace(@string, delegate(Match match)
		{
			GroupCollection groups = match.Groups;
			string value = groups["propertyName"].Value;
			string value2 = groups["typeRef"].Value;
			if (value2.StartsWith("E_"))
			{
				return $"{value}${metadataUid:n}";
			}
			Guid? metadataUid2 = typeReferenceService.GetMetadataUid(value2);
			return metadataUid2.HasValue ? $"{value}${metadataUid2.Value:n}" : match.Value;
		});
		return Encoding.UTF8.GetBytes(s);
	}
}
