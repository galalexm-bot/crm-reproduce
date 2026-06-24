using System;
using System.ComponentModel;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Binders;

namespace EleWise.ELMA.BPM.Web.Common.Components;

public class FilterModelBinder : ElmaModelBinder
{
	protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
	{
		if (modelType.IsInheritOrSame<FilterModel>())
		{
			if (!(base.CreateModel(controllerContext, bindingContext, modelType) is FilterModel filterModel))
			{
				return null;
			}
			string prefix = ElmaModelBinder.GetPrefix(bindingContext);
			string value = bindingContext.GetValue<string>(prefix + "Entity.__TypeName");
			IEntityManager entityManager = null;
			if (!string.IsNullOrEmpty(value))
			{
				Type type = ElmaModelBinder.FindType(value);
				if (type != null)
				{
					entityManager = EntityHelper.GetEntityManager(type);
				}
			}
			long? value2 = bindingContext.GetValue<long?>(prefix + "Entity.Id");
			if (value2.HasValue)
			{
				filterModel.Entity = ((IFilterBase)(entityManager ?? FilterManager.Instance).LoadOrNull(value2.Value)) ?? filterModel.Entity;
				if (filterModel.Entity != null && filterModel.Entity.FilterFields != null)
				{
					Guid? value3 = bindingContext.GetValue<Guid?>(prefix + "FilterTypeUid");
					IEntityFilter entityFilter2 = (filterModel.Filter = UniversalFilterSaver.UnPack(filterModel.Entity.FilterFields, (value3.HasValue && value3 != Guid.Empty) ? new ReferenceOnEntityType
					{
						TypeUid = value3.Value
					} : null));
				}
			}
			else if (entityManager != null)
			{
				filterModel.Entity = (IFilterBase)entityManager.Create();
				filterModel.Entity.ObjectsType = new ReferenceOnEntityType();
				filterModel.Entity.UseDefaultSettings = true;
				filterModel.GridIdPrefix = "Filter";
			}
			return filterModel;
		}
		if (bindingContext.get_Model() is IEntityFilter && modelType.IsInheritOrSame<IEntityFilter>())
		{
			string key = ElmaModelBinder.GetPrefix(bindingContext) + "__TypeName";
			string value4 = bindingContext.GetValue<string>(key);
			if (!string.IsNullOrEmpty(value4))
			{
				Type type2 = ElmaModelBinder.FindType(value4);
				if (type2 != null && type2 != bindingContext.get_Model().GetType())
				{
					return base.CreateModel(controllerContext, bindingContext, modelType);
				}
			}
		}
		return bindingContext.get_Model() ?? base.CreateModel(controllerContext, bindingContext, modelType);
	}

	protected override object GetPropertyValue(ControllerContext controllerContext, ModelBindingContext bindingContext, PropertyDescriptor propertyDescriptor, IModelBinder propertyBinder)
	{
		if ((bindingContext.get_ModelMetadata() != null && bindingContext.get_ModelMetadata().get_ContainerType() != null && typeof(FilterModel).IsAssignableFrom(bindingContext.get_ModelMetadata().get_ContainerType()) && propertyDescriptor.Name == "Entity") || typeof(IEntityFilter).IsAssignableFrom(propertyDescriptor.PropertyType))
		{
			return ((DefaultModelBinder)this).BindModel(controllerContext, bindingContext);
		}
		return ((DefaultModelBinder)this).GetPropertyValue(controllerContext, bindingContext, propertyDescriptor, propertyBinder);
	}
}
