using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Services;

namespace EleWise.ELMA.Model.Common;

public static class ModelHelper
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public string ns;

		internal bool _003CGetNamespacePartDisplayName_003Eb__0(NamespaceMetadata m)
		{
			return m.get_Namespace() == ns;
		}

		internal bool _003CGetNamespacePartDisplayName_003Eb__1(NamespaceInfo ni)
		{
			return ni.get_Namespace() == ns;
		}
	}

	private static readonly Dictionary<string, Dictionary<int, string>> loadedFullNamespaces = new Dictionary<string, Dictionary<int, string>>();

	private static readonly Dictionary<string, string> loadedShortNamespaces = new Dictionary<string, string>();

	private static readonly Dictionary<string, Dictionary<int, string>> loadedNamespaces = new Dictionary<string, Dictionary<int, string>>();

	public static string GetNamespaceShortName(string ns, IMetadataServiceContext metadataService)
	{
		if (string.IsNullOrEmpty(ns))
		{
			return "";
		}
		lock (loadedFullNamespaces)
		{
			string result = default(string);
			if (loadedShortNamespaces.TryGetValue(ns, ref result))
			{
				return result;
			}
			string[] array = ns.Split(".".ToCharArray(), (StringSplitOptions)1);
			result = "";
			string text = "";
			for (int i = 0; i < array.Length; i++)
			{
				if (i > 0)
				{
					text += ".";
				}
				text += array[i];
				if (!string.IsNullOrEmpty(GetNamespacePartDisplayName(text, metadataService)))
				{
					if (result != "")
					{
						result += ".";
					}
					result += array[i];
				}
			}
			loadedShortNamespaces.Add(ns, result);
			return result;
		}
	}

	public static string GetNamespaceDisplayName(string ns, IMetadataServiceContext metadataService)
	{
		if (string.IsNullOrEmpty(ns))
		{
			return "";
		}
		lock (loadedFullNamespaces)
		{
			Dictionary<int, string> val = default(Dictionary<int, string>);
			if (!loadedFullNamespaces.TryGetValue(ns, ref val))
			{
				val = new Dictionary<int, string>();
				loadedFullNamespaces.Add(ns, val);
			}
			string result = default(string);
			if (val.TryGetValue(0, ref result))
			{
				return result;
			}
			string[] array = ns.Split(".".ToCharArray(), (StringSplitOptions)1);
			result = "";
			string text = "";
			for (int i = 0; i < array.Length; i++)
			{
				if (i > 0)
				{
					text += ".";
				}
				text += array[i];
				string namespacePartDisplayName = GetNamespacePartDisplayName(text, metadataService);
				if (!string.IsNullOrEmpty(namespacePartDisplayName))
				{
					if (result != "")
					{
						result += ".";
					}
					result += namespacePartDisplayName;
				}
			}
			val.Add(0, result);
			return result;
		}
	}

	public static string GetNamespacePartDisplayName(string ns, IMetadataServiceContext metadataService)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.ns = ns;
		lock (loadedNamespaces)
		{
			Dictionary<int, string> val = default(Dictionary<int, string>);
			if (!loadedNamespaces.TryGetValue(CS_0024_003C_003E8__locals0.ns, ref val))
			{
				val = new Dictionary<int, string>();
				loadedNamespaces.Add(CS_0024_003C_003E8__locals0.ns, val);
			}
			string text = default(string);
			if (val.TryGetValue(0, ref text))
			{
				return text;
			}
			if (metadataService != null)
			{
				NamespaceMetadata obj = Enumerable.FirstOrDefault<NamespaceMetadata>(metadataService.GetNamespaceMetadataList(), (Func<NamespaceMetadata, bool>)((NamespaceMetadata m) => m.get_Namespace() == CS_0024_003C_003E8__locals0.ns));
				text = ((obj != null) ? ((INamedMetadata)obj).get_DisplayName() : null);
				if (text == null)
				{
					NamespaceInfo obj2 = Enumerable.FirstOrDefault<NamespaceInfo>(metadataService.GetNamespaceInfoList(), (Func<NamespaceInfo, bool>)((NamespaceInfo ni) => ni.get_Namespace() == CS_0024_003C_003E8__locals0.ns));
					text = ((obj2 != null) ? obj2.get_DisplayName() : null);
				}
			}
			if (text == null)
			{
				text = ((CS_0024_003C_003E8__locals0.ns.IndexOf('.') > 0) ? CS_0024_003C_003E8__locals0.ns.Substring(CS_0024_003C_003E8__locals0.ns.LastIndexOf('.') + 1) : CS_0024_003C_003E8__locals0.ns);
			}
			val.Add(0, text);
			return text;
		}
	}
}
