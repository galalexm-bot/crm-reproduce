using System;
using System.Collections.Generic;
using System.Reflection;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.CRM;

public class CustomSet<T, TZ> : HashedSet<T>
{
	private ISet<TZ> setableObject;

	private Dictionary<string, object> properties;

	public ISet<TZ> SetableObject
	{
		get
		{
			return setableObject;
		}
		set
		{
			setableObject = value;
		}
	}

	public CustomSet(ISet<TZ> setableObject, ICollection<T> initialValues, Dictionary<string, object> properties)
		: base(initialValues)
	{
		this.setableObject = setableObject;
		this.properties = properties;
	}

	public CustomSet()
	{
	}

	public void Add(T item)
	{
		Type typeFromHandle = typeof(TZ);
		object obj = Activator.CreateInstance(typeof(TZ));
		PropertyInfo[] reflectionProperties = typeFromHandle.GetReflectionProperties();
		foreach (PropertyInfo propertyInfo in reflectionProperties)
		{
			if (!propertyInfo.CanWrite)
			{
				continue;
			}
			if (propertyInfo.PropertyType == typeof(T))
			{
				propertyInfo.SetValue(obj, item, null);
				continue;
			}
			foreach (KeyValuePair<string, object> property in properties)
			{
				if (propertyInfo.Name == property.Key)
				{
					propertyInfo.SetValue(obj, property.Value, null);
				}
			}
		}
		((object)setableObject).GetType().GetMethod("Add", ((object)setableObject).GetType().GetGenericArguments()).Invoke(setableObject, new object[1] { obj });
	}
}
