using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class FormDriver : IFormDriver<RowDriver>
{
	protected interface IRowDriverDescriptor
	{
		RowDriver CreateRowDriver();
	}

	protected class RowDriverDescriptor : IRowDriverDescriptor
	{
		private readonly Type _modelType;

		private readonly string _propertyName;

		private readonly Type _driverType;

		public RowDriverDescriptor(Type modelType, Type modelTypeForGeneric, PropertyInfo property)
		{
			_modelType = modelType;
			_propertyName = property.Name;
			_driverType = typeof(RowDriverForProperty<, >).MakeGenericType(modelTypeForGeneric, property.PropertyType);
		}

		public RowDriver CreateRowDriver()
		{
			if (!(Activator.CreateInstance(_driverType, _propertyName, _modelType) is RowDriver rowDriver))
			{
				return null;
			}
			rowDriver.PropertyName = _propertyName;
			return rowDriver;
		}
	}

	private IEnumerable<RowDriver> _cachedRows;

	private Func<Type, List<IRowDriverDescriptor>> getRowDriverDescriptorCached;

	public Type ModelType { get; set; }

	public string ElementId { get; set; }

	public Func<IEnumerable<RowDriver>> GetRows { get; set; }

	public FormDriver(Type modelType)
		: this(Guid.NewGuid().GetID(), modelType)
	{
	}

	public FormDriver(string elementId, Type modelType)
	{
		ElementId = elementId;
		ModelType = modelType;
		GetRows = OnGetRows;
		getRowDriverDescriptorCached = MetadataLoader.UseCachingForFunc((Type type) => GetRowDriverDescriptors(type));
	}

	protected virtual void InitGetRows()
	{
		GetRows = GetRows ?? new Func<IEnumerable<RowDriver>>(OnGetRows);
	}

	protected List<IRowDriverDescriptor> GetRowDriverDescriptors(Type modelType)
	{
		return (from prop in modelType.GetReflectionProperties(BindingFlags.Instance | BindingFlags.Public).Where(delegate(PropertyInfo prop)
			{
				if (prop.GetIndexParameters().Any())
				{
					return false;
				}
				HiddenInputAttribute attribute = AttributeHelper<HiddenInputAttribute>.GetAttribute(prop, inherited: true);
				return attribute == null || attribute.get_DisplayValue();
			})
			select CreateRowDriverDescriptor(prop)).ToList();
	}

	protected IEnumerable<RowDriver> OnGetRows()
	{
		return from descriptor in getRowDriverDescriptorCached(ModelType)
			select descriptor.CreateRowDriver() into driver
			where driver != null
			select driver;
	}

	protected virtual IRowDriverDescriptor CreateRowDriverDescriptor(PropertyInfo property)
	{
		return new RowDriverDescriptor(ModelType, ModelType, property);
	}

	public IEnumerable<RowDriver> GetRowDrivers()
	{
		IEnumerable<RowDriver> obj = _cachedRows ?? RowDrivers();
		IEnumerable<RowDriver> result = obj;
		_cachedRows = obj;
		return result;
	}

	protected virtual IEnumerable<RowDriver> RowDrivers()
	{
		InitGetRows();
		if (GetRows != null)
		{
			return GetRows();
		}
		return null;
	}
}
