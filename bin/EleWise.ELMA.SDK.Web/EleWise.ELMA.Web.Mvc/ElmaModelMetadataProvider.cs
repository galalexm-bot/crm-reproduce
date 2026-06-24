using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc;

public class ElmaModelMetadataProvider : DataAnnotationsModelMetadataProvider
{
	private IEnumerable<IModelTypeMetadataExtensionPoint> customTypeDescriptorExtensionPoints;

	private IEnumerable<IModelTypeMetadataExtensionPoint> CustomTypeDescriptorExtensionPoints => customTypeDescriptorExtensionPoints ?? (customTypeDescriptorExtensionPoints = ComponentManager.Current.GetExtensionPoints<IModelTypeMetadataExtensionPoint>());

	protected override ModelMetadata CreateMetadata(IEnumerable<Attribute> attributes, Type containerType, Func<object> modelAccessor, Type modelType, string propertyName)
	{
		modelType = CalculateModelType(containerType, modelAccessor) ?? modelType;
		ModelMetadata metadata = ((DataAnnotationsModelMetadataProvider)this).CreateMetadata(attributes, containerType, modelAccessor, modelType, propertyName);
		if (metadata.get_ContainerType() != null && !string.IsNullOrEmpty(metadata.get_PropertyName()))
		{
			if (modelAccessor != null && modelAccessor.Target != null)
			{
				FieldInfo containerFieldInfo = GetContainerFieldInfo(modelAccessor.Target.GetType());
				if (containerFieldInfo != null)
				{
					object value = containerFieldInfo.GetValue(modelAccessor.Target);
					if (value != null && metadata.get_ContainerType().IsAssignableFrom(value.GetType()))
					{
						metadata.SetContainerObject(value);
					}
				}
				else
				{
					FieldInfo vdiFieldInfo = GetVdiFieldInfo(modelAccessor.Target.GetType());
					if (vdiFieldInfo != null)
					{
						object value2 = vdiFieldInfo.GetValue(modelAccessor.Target);
						ViewDataInfo val = (ViewDataInfo)((value2 is ViewDataInfo) ? value2 : null);
						if (val != null && val.get_Container() != null && metadata.get_ContainerType().IsAssignableFrom(val.get_Container().GetType()))
						{
							metadata.SetContainerObject(val.get_Container());
						}
					}
				}
			}
			ClassMetadata classMetadata = MetadataLoader.LoadMetadata(metadata.get_ContainerType()) as ClassMetadata;
			IEntityMetadata entityMetadata = classMetadata as IEntityMetadata;
			if (classMetadata != null)
			{
				PropertyMetadata propertyMetadata = classMetadata.Properties.FirstOrDefault((PropertyMetadata p) => p.Name.Equals(metadata.get_PropertyName()));
				if (propertyMetadata != null)
				{
					metadata.SetPropertyMetadata(propertyMetadata);
				}
				else if (entityMetadata != null)
				{
					ITablePartMetadata tablePartMetadata = entityMetadata.GetPropertiesAndTableParts().OfType<ITablePartMetadata>().FirstOrDefault((ITablePartMetadata t) => t.TablePartPropertyName == metadata.get_PropertyName());
					if (tablePartMetadata != null)
					{
						metadata.SetPropertyMetadata(tablePartMetadata);
					}
				}
			}
		}
		if (metadata.get_ModelType() == typeof(Money) || metadata.get_ModelType() == typeof(DateTime) || attributes.Any((Attribute a) => a is RangeValueAttribute))
		{
			metadata.set_IsRequired(false);
		}
		return metadata;
	}

	protected override ICustomTypeDescriptor GetTypeDescriptor(Type type)
	{
		if (type.IsInterface)
		{
			return ((AssociatedMetadataProvider)this).GetTypeDescriptor(InterfaceActivator.TypeOf(type));
		}
		return ((AssociatedMetadataProvider)this).GetTypeDescriptor(type);
	}

	private FieldInfo GetContainerFieldInfoNonCache(Type type)
	{
		return type.GetField("container");
	}

	private FieldInfo GetContainerFieldInfo(Type type)
	{
		if (!ContextVars.HasImpl)
		{
			return GetContainerFieldInfoNonCache(type);
		}
		return ContextVars.GetOrAdd("ElmaModelMetadataProvider_ContainerFieldInfo_" + type.GetHashCode(), () => GetContainerFieldInfoNonCache(type));
	}

	private FieldInfo GetVdiFieldInfoNonCache(Type type)
	{
		return type.GetField("vdi");
	}

	private FieldInfo GetVdiFieldInfo(Type type)
	{
		if (!ContextVars.HasImpl)
		{
			return GetVdiFieldInfoNonCache(type);
		}
		return ContextVars.GetOrAdd("ElmaModelMetadataProvider_VdiFieldInfo_" + type.GetHashCode(), () => GetVdiFieldInfoNonCache(type));
	}

	private Type CalculateModelType(Type containerType, Func<object> modelAccessor)
	{
		if (containerType != null && modelAccessor != null && modelAccessor.Target != null)
		{
			FieldInfo containerFieldInfo = GetContainerFieldInfo(modelAccessor.Target.GetType());
			if (containerFieldInfo != null)
			{
				object value = containerFieldInfo.GetValue(modelAccessor.Target);
				if (value != null)
				{
					return CustomTypeDescriptorExtensionPoints?.FirstOrDefault((IModelTypeMetadataExtensionPoint e) => e.CanUse(containerType))?.GetModelType(containerType, value);
				}
			}
			else
			{
				FieldInfo vdiFieldInfo = GetVdiFieldInfo(modelAccessor.Target.GetType());
				if (vdiFieldInfo != null)
				{
					object value2 = vdiFieldInfo.GetValue(modelAccessor.Target);
					ViewDataInfo val = (ViewDataInfo)((value2 is ViewDataInfo) ? value2 : null);
					if (val != null && val.get_Container() != null)
					{
						return CustomTypeDescriptorExtensionPoints?.FirstOrDefault((IModelTypeMetadataExtensionPoint e) => e.CanUse(containerType))?.GetModelType(containerType, val.get_Container());
					}
				}
			}
		}
		return null;
	}
}
