using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class PropertySelectorInfo
{
	public Type ObjectType { get; set; }

	public Dictionary<string, object> Properties { get; set; }

	public string PopupId { get; set; }

	public string DisplayPath { get; set; }

	public string Path { get; set; }

	public string TypePath { get; set; }

	public Guid ParentTypeUid
	{
		get
		{
			if (string.IsNullOrEmpty(TypePath))
			{
				return Guid.Empty;
			}
			List<Guid> list = (from p in TypePath.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries)
				select new Guid(p)).Reverse().ToList();
			if (list.Count > 1)
			{
				return list[1];
			}
			return Guid.Empty;
		}
	}

	public Guid TypeUid { get; set; }

	public bool IsEntity(object obj)
	{
		if (obj is EntityMetadata)
		{
			return true;
		}
		if (obj is PropertyMetadata)
		{
			PropertyMetadata propertyMetadata = (PropertyMetadata)obj;
			if (propertyMetadata.SubTypeUid != Guid.Empty && propertyMetadata.Settings is EntitySettings)
			{
				return true;
			}
		}
		return false;
	}

	public string GetPropertyName(KeyValuePair<string, object> pair)
	{
		if (!(pair.Value is NamedMetadata))
		{
			return pair.Key;
		}
		return ((NamedMetadata)pair.Value).Name;
	}

	public string GetPropertyDisplayName(KeyValuePair<string, object> pair)
	{
		if (!(pair.Value is NamedMetadata))
		{
			return pair.Value.ToString();
		}
		return ((NamedMetadata)pair.Value).DisplayName;
	}

	public string GetImageUrl(HtmlHelper html, KeyValuePair<string, object> pair)
	{
		if (pair.Value is EntityMetadata)
		{
			if (((EntityMetadata)pair.Value).GetImage(16) == null)
			{
				return "#faq.svg";
			}
			return html.Url().Action("Object", "Images", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				id = ((EntityMetadata)pair.Value).Uid,
				useParent = true
			});
		}
		if (pair.Value is PropertyMetadata)
		{
			PropertyMetadata propertyMetadata = (PropertyMetadata)pair.Value;
			if (propertyMetadata.TypeUid == EnumDescriptor.UID)
			{
				return "#unk.svg";
			}
			EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(propertyMetadata.SubTypeUid);
			if (propertyMetadata.SubTypeUid != Guid.Empty && entityMetadata.GetImage(16) != null)
			{
				return html.Url().Action("Object", "Images", (object)new
				{
					area = "EleWise.ELMA.SDK.Web",
					id = propertyMetadata.SubTypeUid,
					useParent = true
				});
			}
			return "#faq.svg";
		}
		return "#unk.svg";
	}

	public string GetPropertyType(KeyValuePair<string, object> pair)
	{
		if (pair.Value is EntityMetadata)
		{
			return ((EntityMetadata)pair.Value).DisplayName;
		}
		if (pair.Value is PropertyMetadata)
		{
			PropertyMetadata propertyMetadata = (PropertyMetadata)pair.Value;
			ITypeDescriptor typeDescriptor = MetadataServiceContext.Service.GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid);
			if (typeDescriptor != null)
			{
				return typeDescriptor.Name;
			}
		}
		return SR.T("Строка");
	}

	public string GetParentUpdateParam()
	{
		if (ParentTypeUid != Guid.Empty)
		{
			List<string> list = Path.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries).ToList();
			list.RemoveAt(list.Count - 1);
			string text = string.Join(".", list);
			List<string> list2 = DisplayPath.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries).ToList();
			list2.RemoveAt(list2.Count - 1);
			string text2 = string.Join(".", list2);
			List<string> list3 = TypePath.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries).ToList();
			list3.RemoveAt(list3.Count - 1);
			string text3 = string.Join(".", list3);
			return $"{{ typeUid: '{ParentTypeUid}', path: '{text}', displayPath: '{text2}', typePath: '{text3}', objectType: '{ObjectType.AssemblyQualifiedName}' }}";
		}
		return $"{{ objectType: '{ObjectType.AssemblyQualifiedName}' }}";
	}

	public string GetUpdateParams(KeyValuePair<string, object> pair, string path, string displayPath, string typePath)
	{
		if (pair.Value is EntityMetadata)
		{
			path = (string.IsNullOrEmpty(path) ? ((EntityMetadata)pair.Value).Name : $"{path}.{((EntityMetadata)pair.Value).Name}");
			displayPath = (string.IsNullOrEmpty(displayPath) ? ((EntityMetadata)pair.Value).DisplayName : $"{displayPath}.{((EntityMetadata)pair.Value).DisplayName}");
			typePath = (string.IsNullOrEmpty(typePath) ? ((EntityMetadata)pair.Value).Uid.ToString() : $"{typePath}.{((EntityMetadata)pair.Value).Uid.ToString()}");
			return $"{{ typeUid: '{((EntityMetadata)pair.Value).Uid}', path: '{path}', displayPath: '{displayPath}', typePath: '{typePath}', objectType: '{ObjectType.AssemblyQualifiedName}' }}";
		}
		if (pair.Value is PropertyMetadata)
		{
			PropertyMetadata propertyMetadata = (PropertyMetadata)pair.Value;
			if (propertyMetadata.SubTypeUid != Guid.Empty)
			{
				path = (string.IsNullOrEmpty(path) ? propertyMetadata.Name : $"{path}.{propertyMetadata.Name}");
				displayPath = (string.IsNullOrEmpty(displayPath) ? propertyMetadata.DisplayName : $"{displayPath}.{propertyMetadata.DisplayName}");
				typePath = (string.IsNullOrEmpty(typePath) ? propertyMetadata.SubTypeUid.ToString() : $"{typePath}.{propertyMetadata.SubTypeUid.ToString()}");
				return $"{{ typeUid: '{propertyMetadata.SubTypeUid}', path: '{path}', displayPath: '{displayPath}', typePath: '{typePath}', objectType: '{ObjectType.AssemblyQualifiedName}' }}";
			}
		}
		return "";
	}

	public List<string> GetCrumbs()
	{
		List<string> res = new List<string>();
		res.Add(SR.T("Корень"));
		if (!string.IsNullOrEmpty(Path))
		{
			List<string> displayPaths = DisplayPath.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries).ToList();
			List<string> paths = Path.Split(new string[1] { "." }, StringSplitOptions.RemoveEmptyEntries).ToList();
			paths.ForEach(delegate(string p)
			{
				res.Add(displayPaths[paths.IndexOf(p)]);
			});
		}
		return res;
	}

	public PropertySelectorInfo()
	{
		Properties = new Dictionary<string, object>();
	}
}
