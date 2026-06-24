using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class PropertyRowModel<TModel> : PropertyRowModel
{
	public new Func<PropertyRowModel<TModel>, object> Template
	{
		get
		{
			if (base.Template != null)
			{
				return (PropertyRowModel<TModel> model) => base.Template(model);
			}
			return null;
		}
		set
		{
			if (value != null)
			{
				base.Template = (PropertyRowModel model) => value((PropertyRowModel<TModel>)model);
			}
			else
			{
				base.Template = null;
			}
		}
	}

	public TModel Model => (TModel)base.FormModel;

	public new RowDriverForModel<TModel> Driver => (RowDriverForModel<TModel>)base.Driver;

	public PropertyRowModel(TModel model, RowDriverForModel<TModel> rowDriver)
		: base(model, rowDriver)
	{
	}
}
public class PropertyRowModel
{
	public string PropertyName { get; protected set; }

	public virtual Expression PropertyAccessor { get; protected set; }

	public object FormModel { get; protected set; }

	public RowDriver Driver { get; protected set; }

	public int Order { get; set; }

	public bool Visible { get; set; }

	public virtual Func<PropertyRowModel, object> Template { get; set; }

	public WebViewAttributes Attributes { get; set; }

	public ICollection<Action<PropertyRowModel>> RowDisplayActions { get; protected set; }

	public PropertyRowModel([NotNull] object model, [NotNull] RowDriver rowDriver)
	{
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		if (rowDriver == null)
		{
			throw new ArgumentNullException("rowDriver");
		}
		FormModel = model;
		PropertyName = rowDriver.PropertyName;
		Driver = rowDriver;
		Visible = true;
		Attributes = new WebViewAttributes();
		RowDisplayActions = new List<Action<PropertyRowModel>>();
	}
}
