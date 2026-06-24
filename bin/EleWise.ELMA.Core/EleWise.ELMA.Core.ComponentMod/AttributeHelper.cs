using System;
using System.Collections;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.Core.ComponentModel;

public static class AttributeHelper<T> where T : System.Attribute
{
	public static T GetAttribute(System.Type type, bool inherited)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (type == null)
		{
			throw new ArgumentNullException("type");
		}
		return Enumerable.OfType<T>((System.Collections.IEnumerable)(object)type.GetCustomAttributes(inherited)).FirstOrDefault();
	}

	public static T GetAttribute(Assembly assembly)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (assembly == null)
		{
			throw new ArgumentNullException("assembly");
		}
		return Enumerable.OfType<T>((System.Collections.IEnumerable)(object)assembly.GetCustomAttributes(false)).FirstOrDefault();
	}

	public static T GetAttribute(MemberInfo memberInfo, bool inherited)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (memberInfo == null)
		{
			throw new ArgumentNullException("memberInfo");
		}
		return Enumerable.OfType<T>((System.Collections.IEnumerable)(object)memberInfo.GetCustomAttributes(inherited)).FirstOrDefault();
	}
}
