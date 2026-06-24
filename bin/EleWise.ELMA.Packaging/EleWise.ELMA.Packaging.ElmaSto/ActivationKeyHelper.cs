using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EleWise.ELMA.Packaging.ElmaStoreManifest;

internal static class ActivationKeyHelper
{
	private class ActivationKeyInfo
	{
		public string ModuleHash { get; set; }

		public string ActivationKey { get; set; }
	}

	private static readonly ConcurrentDictionary<string, IEnumerable<ActivationKeyInfo>> cache = new ConcurrentDictionary<string, IEnumerable<ActivationKeyInfo>>();

	public static string GetUnitActivationKey(string activationKey, Guid unitUid)
	{
		string unitHash = GetUnitHashCode(unitUid).ToString();
		return GetActivationKeyInfos(activationKey).FirstOrDefault((ActivationKeyInfo i) => i.ModuleHash == unitHash)?.ActivationKey;
	}

	public static string[] GetUnitActivationKeys(string activationKey, Guid unitUid)
	{
		string unitHash = GetUnitHashCode(unitUid).ToString();
		return (from i in GetActivationKeyInfos(activationKey)
			where i.ModuleHash == unitHash
			select i.ActivationKey).ToArray();
	}

	public static uint GetUnitHashCode(Guid uid)
	{
		return BitConverter.ToUInt32(BitConverter.GetBytes(uid.GetHashCode()), 0);
	}

	private static IEnumerable<ActivationKeyInfo> GetActivationKeyInfos(string actKey)
	{
		if (actKey != null)
		{
			actKey = actKey.Trim(" \t".ToCharArray());
		}
		if (string.IsNullOrEmpty(actKey) || !actKey.StartsWith("EaK"))
		{
			return new ActivationKeyInfo[0];
		}
		try
		{
			byte[] array = Convert.FromBase64String(actKey.Substring(3));
			StringBuilder stringBuilder = new StringBuilder();
			byte[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				string text = Convert.ToString(array2[i], 16).ToUpper();
				if (text.Length < 2)
				{
					text = "0" + text;
				}
				stringBuilder.Append(text);
			}
			string text2 = stringBuilder.ToString().Replace("C", "");
			List<ActivationKeyInfo> list = new List<ActivationKeyInfo>();
			string[] array3 = text2.Split("B".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
			for (int i = 0; i < array3.Length; i++)
			{
				string[] array4 = array3[i].Split("A".ToCharArray());
				list.Add(new ActivationKeyInfo
				{
					ModuleHash = array4[0],
					ActivationKey = array4[1]
				});
			}
			cache[actKey] = list;
			return list;
		}
		catch
		{
			cache[actKey] = new ActivationKeyInfo[0];
			return new ActivationKeyInfo[0];
		}
	}
}
