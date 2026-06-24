using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Service;

internal class DocumentationParser
{
	private static readonly ConcurrentDictionary<Type, ClassDocumentationElement> ParsedCache = new ConcurrentDictionary<Type, ClassDocumentationElement>();

	private readonly Type classType;

	private ClassDocumentationElement parsedElement;

	public DocumentationParser([NotNull] Type classType)
	{
		if (classType == null)
		{
			throw new ArgumentNullException("classType");
		}
		this.classType = classType;
	}

	public ClassDocumentationElement Parse()
	{
		if (parsedElement != null)
		{
			return parsedElement;
		}
		parsedElement = ParsedCache.GetOrAdd(classType, (Type type) => new ClassDocumentationElement(GetClassSummary(), type, type.Name)
		{
			Methods = ParseMethods()
		});
		return parsedElement;
	}

	private MethodDocumentationElement[] ParseMethods()
	{
		return classType.GetMethods().Select(ParseMethod).ToArray();
	}

	private MethodDocumentationElement ParseMethod(MethodInfo methodInfo)
	{
		return new MethodDocumentationElement(GetMemberSummary(methodInfo), methodInfo.Name, "1.0.9")
		{
			ReturnValue = ParseReturnValue(methodInfo),
			Parameters = ParseParameters(methodInfo),
			RequiresAuthorization = (AttributeHelper<AuthorizeOperationBehavior>.GetAttribute(methodInfo, inherited: false) != null)
		};
	}

	public static TypeSerializationDescriptor BuildTypeSerializationDescriptor(Type clrType)
	{
		DescriptionAttribute attribute = AttributeHelper<DescriptionAttribute>.GetAttribute(clrType, inherited: true);
		TypeSerializationDescriptor model = new TypeSerializationDescriptor
		{
			Description = attribute?.Description,
			Type = clrType
		};
		foreach (MemberInfo item2 in from m in clrType.GetReflectionMembers()
			where m is PropertyInfo || m is FieldInfo
			select m)
		{
			DataMemberAttribute attribute2 = AttributeHelper<DataMemberAttribute>.GetAttribute(item2, inherited: false);
			if (attribute2 != null)
			{
				Type propertyOrFieldType = GetPropertyOrFieldType(item2);
				Type type = CheckPropertyType(propertyOrFieldType);
				TypeSerializationDescriptorBuilder typeSerializationDescriptorBuilder = new TypeSerializationDescriptorBuilder().Type(type);
				if (IsArrayOrEnumerable(propertyOrFieldType))
				{
					TypeSerializationItemDescriptor typeSerializationItemDescriptor = new TypeSerializationItemDescriptor
					{
						Descriptor = typeSerializationDescriptorBuilder.Descriptor
					};
					typeSerializationDescriptorBuilder = new TypeSerializationDescriptorBuilder().Description(typeSerializationItemDescriptor.Descriptor.Description).IsArray().Item(typeSerializationItemDescriptor);
				}
				DescriptionAttribute attribute3 = AttributeHelper<DescriptionAttribute>.GetAttribute(item2, inherited: true);
				if (attribute3 != null)
				{
					typeSerializationDescriptorBuilder.Description(attribute3.Description);
				}
				if ((type.IsPrimitive || type.IsValueType || type.IsEnum) && IsNullableType(propertyOrFieldType))
				{
					typeSerializationDescriptorBuilder.Optional();
				}
				if (AttributeHelper<ObsoleteAttribute>.GetAttribute(item2, inherited: true) != null)
				{
					typeSerializationDescriptorBuilder.Obsolete();
				}
				TypeSerializationItemDescriptor typeSerializationItemDescriptor2 = new TypeSerializationItemDescriptor();
				typeSerializationItemDescriptor2.Name = attribute2.Name ?? item2.Name;
				typeSerializationItemDescriptor2.Descriptor = typeSerializationDescriptorBuilder.Descriptor;
				model.Items.Add(typeSerializationItemDescriptor2);
			}
		}
		if (IsArrayOrEnumerable(clrType))
		{
			TypeSerializationItemDescriptor item = new TypeSerializationItemDescriptor
			{
				Descriptor = model
			};
			model = new TypeSerializationDescriptorBuilder().Description(model.Description).IsArray().Item(item)
				.Descriptor;
		}
		List<TypeSerializationItemDescriptor> list = model.Items.Where((TypeSerializationItemDescriptor i) => i.Descriptor.IsObsolete).ToList();
		list.ForEach(delegate(TypeSerializationItemDescriptor i)
		{
			model.Items.Remove(i);
		});
		list.ForEach(delegate(TypeSerializationItemDescriptor i)
		{
			model.Items.Add(i);
		});
		return model;
	}

	private static Type GetPropertyOrFieldType(MemberInfo memberInfo)
	{
		PropertyInfo propertyInfo = memberInfo as PropertyInfo;
		if (propertyInfo != null)
		{
			return propertyInfo.PropertyType;
		}
		FieldInfo fieldInfo = memberInfo as FieldInfo;
		if (fieldInfo != null)
		{
			return fieldInfo.FieldType;
		}
		return null;
	}

	private static bool IsNullableType(Type type)
	{
		if (type.IsGenericType)
		{
			return type.GetGenericTypeDefinition() == typeof(Nullable<>);
		}
		return false;
	}

	private static bool IsArrayOrEnumerable(Type clrType)
	{
		if (clrType == typeof(string))
		{
			return false;
		}
		if (!clrType.IsArray)
		{
			return IsEnumerable(clrType);
		}
		return true;
	}

	private static bool IsEnumerable(Type clrType)
	{
		return clrType.GetInterface("IEnumerable`1") != null;
	}

	private static Type CheckPropertyType(Type propertyType)
	{
		if (IsEnumerable(propertyType) || propertyType.IsGenericType)
		{
			Type[] genericArguments = propertyType.GetGenericArguments();
			if (genericArguments.Any())
			{
				return genericArguments[0];
			}
		}
		if (propertyType.IsArray)
		{
			return propertyType.GetElementType();
		}
		return propertyType;
	}

	private ParameterDocumentationElement[] ParseParameters(MethodInfo methodInfo)
	{
		return methodInfo.GetParameters().Select(ParseParameter).ToArray();
	}

	private ParameterDocumentationElement ParseParameter(ParameterInfo parameterInfo)
	{
		return new ParameterDocumentationElement(GetParameterSummary(parameterInfo), parameterInfo.ParameterType, parameterInfo.Name)
		{
			TypeDescriptor = BuildTypeSerializationDescriptor(parameterInfo.ParameterType)
		};
	}

	private ReturnValueDocumentationElement ParseReturnValue(MethodInfo methodInfo)
	{
		return new ReturnValueDocumentationElement(GetParameterSummary(methodInfo.ReturnParameter), methodInfo.ReturnType)
		{
			TypeDescriptor = BuildTypeSerializationDescriptor(methodInfo.ReturnType)
		};
	}

	private string GetClassSummary()
	{
		string result = "";
		WsdlDocumentationAttribute attribute = AttributeHelper<WsdlDocumentationAttribute>.GetAttribute(classType, inherited: false);
		if (attribute != null)
		{
			result = attribute.Value;
		}
		return result;
	}

	private string GetParameterSummary(ParameterInfo parameterInfo)
	{
		string result = "";
		WsdlParamOrReturnDocumentationAttribute attribute = AttributeHelper<WsdlParamOrReturnDocumentationAttribute>.GetAttribute(parameterInfo, inherited: false);
		if (attribute != null)
		{
			result = attribute.Value;
		}
		return result;
	}

	private string GetMemberSummary(MemberInfo memberInfo)
	{
		string result = "";
		WsdlDocumentationAttribute attribute = AttributeHelper<WsdlDocumentationAttribute>.GetAttribute(memberInfo, inherited: false);
		if (attribute != null)
		{
			result = attribute.Value;
		}
		return result;
	}
}
