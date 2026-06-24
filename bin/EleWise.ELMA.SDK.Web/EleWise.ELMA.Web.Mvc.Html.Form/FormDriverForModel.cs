using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc.Html.Forms;

public class FormDriverForModel<TModel> : FormDriver, IFormDriver<RowDriverForModel<TModel>>
{
	private IEnumerable<RowDriverForModel<TModel>> _cachedRows;

	public new Func<IEnumerable<RowDriverForModel<TModel>>> GetRows { get; set; }

	public FormDriverForModel(Type realModelType = null)
		: base(Guid.NewGuid().GetID(), realModelType ?? typeof(TModel))
	{
	}

	public FormDriverForModel(string elementId, Type realModelType = null)
		: base(elementId, realModelType ?? typeof(TModel))
	{
	}

	protected override void InitGetRows()
	{
		base.InitGetRows();
		GetRows = GetRows ?? new Func<IEnumerable<RowDriverForModel<TModel>>>(OnGetRowsForModel);
	}

	private IEnumerable<RowDriverForModel<TModel>> OnGetRowsForModel()
	{
		return OnGetRows().Cast<RowDriverForModel<TModel>>();
	}

	public new IEnumerable<RowDriverForModel<TModel>> GetRowDrivers()
	{
		IEnumerable<RowDriverForModel<TModel>> obj = _cachedRows ?? RowDrivers().Cast<RowDriverForModel<TModel>>();
		IEnumerable<RowDriverForModel<TModel>> result = obj;
		_cachedRows = obj;
		return result;
	}

	protected override IRowDriverDescriptor CreateRowDriverDescriptor(PropertyInfo property)
	{
		return new RowDriverDescriptor(base.ModelType, typeof(TModel), property);
	}
}
