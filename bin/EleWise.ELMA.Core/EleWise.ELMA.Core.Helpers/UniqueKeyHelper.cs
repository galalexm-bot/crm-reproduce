using System;
using Bridge.Html5;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Core.Helpers;

public static class UniqueKeyHelper
{
	private static readonly WeakMap KeysRepository = new WeakMap();

	public static string GetUniqueKey(this object obj)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		if (obj == null)
		{
			Guid val = Guid.NewGuid();
			return ((object)(Guid)(ref val)).ToString();
		}
		if (obj.HasProperty("$getUniqueKey"))
		{
			return $"{((ReactiveProxy)obj).GetUniqueKey()}_{obj.GetHashCode()}";
		}
		if (obj.HasProperty("Uid"))
		{
			object plainPropertyValue = obj.GetPlainPropertyValue("Uid");
			if (plainPropertyValue != null)
			{
				return $"{plainPropertyValue}_{obj.GetHashCode()}";
			}
		}
		if (obj.HasProperty("Id"))
		{
			object plainPropertyValue2 = obj.GetPlainPropertyValue("Id");
			if (plainPropertyValue2 != null)
			{
				return $"{plainPropertyValue2}_{obj.GetHashCode()}";
			}
		}
		if (!obj.IsObject())
		{
			return obj.ToString();
		}
		if (KeysRepository.Has<object>(obj))
		{
			return KeysRepository.Get<object>(obj).ToString();
		}
		string text = $"{Guid.NewGuid()}_{obj.GetHashCode()}";
		KeysRepository.Set<object>(obj, (object)text);
		return text;
	}
}
