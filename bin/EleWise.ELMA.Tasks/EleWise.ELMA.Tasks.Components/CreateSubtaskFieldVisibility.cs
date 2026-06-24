using System;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
public class CreateSubtaskFieldVisibility : ICreateSubtaskFieldVisibility
{
	public bool IsDefaultValue(ITaskBase parent, PropertyMetadata property)
	{
		if (parent != null)
		{
			try
			{
				object obj = ((SubtaskDefaultFieldCheckAttribute)property.DeclaringType.GetReflectionProperty(property.Name).GetCustomAttributes(typeof(SubtaskDefaultFieldCheckAttribute), inherit: false).FirstOrDefault()).Method.Invoke(null, new object[1] { parent });
				if (obj is bool)
				{
					return (bool)obj;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}
		return false;
	}
}
