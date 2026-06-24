using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public static class FormBuilderExtensions
{
	public static FormBuilder ShowOnlyUserProperties([NotNull] this FormBuilder formBuilder)
	{
		if (formBuilder == null)
		{
			throw new ArgumentNullException("formBuilder");
		}
		formBuilder.FilterProperties(FilterUserProperties);
		return formBuilder;
	}

	public static FormBuilder UserProperties([NotNull] this FormBuilder formBuilder)
	{
		if (formBuilder == null)
		{
			throw new ArgumentNullException("formBuilder");
		}
		formBuilder.Model.FormModel.GetType().GetReflectionProperties().Where(FilterUserProperties)
			.ForEach(delegate(PropertyInfo pi)
			{
				formBuilder.Model.GetPropertyRow(pi.Name);
			});
		return formBuilder;
	}

	public static FormBuilder UserPropertiesOrder([NotNull] this FormBuilder formBuilder, int order)
	{
		if (formBuilder == null)
		{
			throw new ArgumentNullException("formBuilder");
		}
		formBuilder.EachPropertyRow(delegate(PropertyRowModel model)
		{
			if (FilterUserProperties(model.Driver.GetPropertyInfo()))
			{
				model.Order = order;
			}
		});
		return formBuilder;
	}

	public static FormBuilder<TModel> ShowOnlyUserProperties<TModel>([NotNull] this FormBuilder<TModel> formBuilder)
	{
		if (formBuilder == null)
		{
			throw new ArgumentNullException("formBuilder");
		}
		formBuilder.FilterProperties(FilterUserProperties);
		return formBuilder;
	}

	public static FormBuilder<TModel> UserProperties<TModel>([NotNull] this FormBuilder<TModel> formBuilder)
	{
		if (formBuilder == null)
		{
			throw new ArgumentNullException("formBuilder");
		}
		formBuilder.Model.FormModel.GetType().GetReflectionProperties().Where(FilterUserProperties)
			.ForEach(delegate(PropertyInfo pi)
			{
				formBuilder.Model.GetPropertyRow(pi.Name);
			});
		return formBuilder;
	}

	public static FormBuilder<TModel> HideEmptyProperties<TModel>([NotNull] this FormBuilder<TModel> formBuilder)
	{
		if (formBuilder == null)
		{
			throw new ArgumentNullException("formBuilder");
		}
		formBuilder.EachPropertyRow(delegate(PropertyRowModel model)
		{
			model.Visible &= FilterNonEmptyProperties(model.Driver.GetPropertyInfo(), model.FormModel);
		});
		return formBuilder;
	}

	public static FormBuilder<TModel> UserPropertiesOrder<TModel>([NotNull] this FormBuilder<TModel> formBuilder, int order)
	{
		return formBuilder.UserPropertiesOrder(order, 0);
	}

	public static FormBuilder<TModel> UserPropertiesOrder<TModel>([NotNull] this FormBuilder<TModel> formBuilder, int order, int increment)
	{
		if (formBuilder == null)
		{
			throw new ArgumentNullException("formBuilder");
		}
		formBuilder.EachPropertyRow(delegate(PropertyRowModel model)
		{
			if (FilterUserProperties(model.Driver.GetPropertyInfo()))
			{
				model.Order = order;
				order += increment;
			}
		});
		return formBuilder;
	}

	public static FormBuilder<TModel> ReorderAll<TModel>([NotNull] this FormBuilder<TModel> formBuilder, int order = 1, int increment = 1)
	{
		if (formBuilder == null)
		{
			throw new ArgumentNullException("formBuilder");
		}
		formBuilder.EachPropertyRow(delegate(PropertyRowModel model)
		{
			model.Order = order;
			order += increment;
		});
		return formBuilder;
	}

	private static bool FilterUserProperties(PropertyInfo propertyInfo)
	{
		if (MetadataLoader.LoadMetadata(propertyInfo.DeclaringType) is EntityMetadata entityMetadata && entityMetadata.ImplementedExtensionUids != null)
		{
			IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
			foreach (Guid item in entityMetadata.ImplementedExtensionUids.Where((Guid extensionUid) => extensionUid.IsConfigMetadata()))
			{
				Type typeByUid = serviceNotNull.GetTypeByUid(item, loadImplementation: false);
				if (typeByUid != null && (from p in typeByUid.GetReflectionProperties()
					where p.Name == propertyInfo.Name
					select p).FirstOrDefault() != null)
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	private static bool FilterNonEmptyProperties(PropertyInfo propertyInfo, object model)
	{
		object value = propertyInfo.GetValue(model, null);
		if (value == null)
		{
			return false;
		}
		if (value is string)
		{
			return !string.IsNullOrWhiteSpace((string)value);
		}
		using (IEnumerator<bool?> enumerator = (from point in ComponentManager.Current.GetExtensionPoints<ICheckEmptyProperty>()
			select point.IsEmpty(propertyInfo, model) into res
			where res.HasValue
			select res).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				return !enumerator.Current.Value;
			}
		}
		if (value is IEnumerable)
		{
			return ((IEnumerable)value).Cast<object>().Any();
		}
		return true;
	}
}
