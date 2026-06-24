using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Serialization;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.Helpers;

public static class ScriptMethodInfoHelper
{
	public static string Serialize(ScriptMethodInfo methodInfo)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		if (methodInfo == null || string.IsNullOrWhiteSpace(methodInfo.Name))
		{
			return "";
		}
		if (methodInfo.MetadataUid == Guid.Empty)
		{
			return methodInfo.Name;
		}
		return SerializationHelper.SerializeObjectByJson(methodInfo);
	}

	public static ScriptMethodInfo Deserialize(string methodName)
	{
		if (!string.IsNullOrEmpty(methodName) && methodName.StartsWith("{"))
		{
			try
			{
				return SerializationHelper.DeserializeObjectFromJson<ScriptMethodInfo>(methodName);
			}
			catch (System.Exception message)
			{
				Logger.Log.Error(message);
			}
		}
		return new ScriptMethodInfo
		{
			Name = NormalizeMethodName(methodName)
		};
	}

	internal static string NormalizeMethodName(string methodName)
	{
		int num = methodName.IndexOf(") - ");
		if (num != -1)
		{
			return methodName.Substring(num + ") - ".get_Length(), methodName.LastIndexOf("(") - num - ") - ".get_Length());
		}
		return methodName;
	}

	internal static string GetLegacyMethodName(ScriptMethodDeclaration scriptMethodDeclaration)
	{
		string signature = scriptMethodDeclaration.get_Signature();
		string name = scriptMethodDeclaration.get_Name();
		System.Collections.Generic.ICollection<ScriptMethodParameter> parameters = scriptMethodDeclaration.get_Parameters();
		name += "(";
		string[] array = new string[0];
		System.Collections.Generic.IEnumerator<ScriptMethodParameter> enumerator = ((System.Collections.Generic.IEnumerable<ScriptMethodParameter>)parameters).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				string type = enumerator.get_Current().get_Type();
				ArrayExtensions.Push<string>(array, new string[1] { UpdateSignature(type) });
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		name += string.Join(", ", array);
		name += ")";
		return name + " - " + signature;
	}

	private static string UpdateSignature(string signature)
	{
		string text = signature;
		int num = text.IndexOf('<');
		if (num != -1)
		{
			int num2 = text.IndexOf('>');
			string text2 = text.Substring(num, num2 - num + 1);
			string text3 = text2;
			string text4 = text2.Substring(1, text2.get_Length() - 2);
			if (Enumerable.Contains<char>((System.Collections.Generic.IEnumerable<char>)text4, ','))
			{
				string[] array = Enumerable.ToArray<string>((System.Collections.Generic.IEnumerable<string>)text4.Split(new string[1] { "," }, (StringSplitOptions)0));
				HashSet<string> val = new HashSet<string>();
				string[] array2 = array;
				foreach (string text5 in array2)
				{
					if (val.Add(text5) && text5.get_Chars(0) != '[')
					{
						text3 = text3.Replace(text5, "[" + text5 + "]");
					}
				}
				text3 = text3.Replace("<", $"`{array.Length}[").Replace(">", "]");
			}
			else
			{
				text3 = text3.Replace("<", "`1[[").Replace(">", "]]");
			}
			text = text.Replace(text2, text3);
			if (text.IndexOf('<') != -1)
			{
				text = UpdateSignature(text);
			}
		}
		return text;
	}
}
