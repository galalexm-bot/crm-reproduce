using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Packaging.ElmaStoreManifest;

namespace EleWise.ELMA.Packaging;

[Serializable]
public class ElmaPackageMetadata
{
	public ElmaPackageType Type { get; set; }

	public List<string> Components { get; set; }

	public List<ElmaEdition> Editions { get; set; }

	public List<string> OwnerIds { get; set; }

	public ElmaStoreComponentActivationType ActivationType { get; set; }

	public string WebSite { get; set; }

	public bool Default { get; set; }

	public string Tags { get; set; }

	public int Priority { get; set; }

	public bool EleWise { get; set; }

	public bool ELMA { get; set; }

	public ElmaPackageMetadata()
	{
		Tags = "";
		OwnerIds = new List<string>();
		Components = new List<string>();
		Editions = new List<ElmaEdition>();
		Type = ElmaPackageType.Unknown;
	}

	public ElmaPackageMetadata(string tags)
		: this()
	{
		Tags = tags;
		if (string.IsNullOrEmpty(tags))
		{
			return;
		}
		string[] source = tags.Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
		Func<string, bool> isElmaTagItem = (string s) => s.StartsWith("[") && s.EndsWith("]");
		List<Tuple<string, string>> list = (from t in source.Where(isElmaTagItem).Select(delegate(string s)
			{
				string text = s.Substring(1, s.Length - 2);
				int num = text.IndexOf(':');
				return (num <= 0) ? new Tuple<string, string>(text, null) : new Tuple<string, string>(text.Substring(0, num), text.Substring(num + 1));
			})
			where t != null
			select t).ToList();
		Tags = string.Join(" ", source.Where((string s) => !isElmaTagItem(s)));
		foreach (Tuple<string, string> item2 in list)
		{
			switch (item2.Item1.ToLower())
			{
			case "type":
			{
				if (item2.Item2 != null && Enum.TryParse<ElmaPackageType>(item2.Item2, out var result2))
				{
					Type = result2;
				}
				break;
			}
			case "ownerid":
				if (item2.Item2 != null && !OwnerIds.Contains(item2.Item2))
				{
					OwnerIds.Add(item2.Item2);
				}
				break;
			case "component":
				if (item2.Item2 != null && !Components.Contains(item2.Item2))
				{
					Components.Add(item2.Item2);
				}
				break;
			case "priority":
			{
				if (item2.Item2 != null && int.TryParse(item2.Item2, out var result))
				{
					Priority = result;
				}
				break;
			}
			case "edition":
				if (item2.Item2 != null)
				{
					ElmaEdition item = (ElmaEdition)Enum.Parse(typeof(ElmaEdition), item2.Item2);
					if (!Editions.Contains(item))
					{
						Editions.Add(item);
					}
				}
				break;
			case "activationtype":
				if (item2.Item2 != null)
				{
					ElmaStoreComponentActivationType elmaStoreComponentActivationType2 = (ActivationType = (ElmaStoreComponentActivationType)Enum.Parse(typeof(ElmaStoreComponentActivationType), item2.Item2));
				}
				break;
			case "website":
				if (item2.Item2 != null)
				{
					WebSite = item2.Item2;
				}
				break;
			case "default":
				Default = true;
				break;
			case "elewise":
				EleWise = true;
				break;
			case "elma":
				ELMA = true;
				break;
			}
		}
	}

	public bool IsCompatible(ElmaEdition currentEdition)
	{
		if (Editions.Any())
		{
			return Editions.Any((ElmaEdition e) => (currentEdition != ElmaEdition.CE && e != ElmaEdition.CE && (e <= currentEdition || e == ElmaEdition.Express)) || (currentEdition == ElmaEdition.CE && e == ElmaEdition.CE));
		}
		return true;
	}

	public static string FormatMetadataTag(string key, string value)
	{
		return "[" + key + ":" + value + "]";
	}
}
