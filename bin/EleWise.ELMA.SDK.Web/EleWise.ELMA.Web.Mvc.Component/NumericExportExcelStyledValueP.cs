using System;
using System.Linq;
using Aspose.Cells;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components.Excel;

[Component]
internal class NumericExportExcelStyledValueProvider : IExportExcelStyledValueProvider, IExportExcelValueProvider
{
	private const int DecimalFormat0 = 3;

	private const int DecimalFormat2 = 4;

	private const string CustomFormat = "#,##0.";

	public object GetStyledValue(IEntity entity, Guid propertyUid, Style cellStyle)
	{
		object obj = entity.GetPropertyValue(propertyUid);
		DoubleSettings doubleSettings = ((obj is double) ? entity.GetPropertySettings<DoubleSettings>(propertyUid) : null);
		if (obj is Money money)
		{
			if (!money.HasValue)
			{
				return "";
			}
			obj = ((Money)obj).Value;
		}
		int? num = ((doubleSettings != null) ? doubleSettings.Precision : ((obj is double || obj is float || obj is decimal) ? null : new int?(0)));
		if (num == 0)
		{
			cellStyle.set_Number(3);
		}
		else if (!num.HasValue || num == 2)
		{
			cellStyle.set_Number(4);
		}
		else
		{
			cellStyle.set_Custom("#,##0.".PadRight(num.Value + 6, '0'));
		}
		return obj;
	}

	public bool Resolve(IEntity entity, Guid propertyUid)
	{
		if ((MetadataLoader.LoadMetadata(EntityHelper.GetType(entity)) as ClassMetadata)?.Properties.FirstOrDefault((PropertyMetadata p) => p.Uid == propertyUid) == null)
		{
			return false;
		}
		object propertyValue = entity.GetPropertyValue(propertyUid);
		if (!(propertyValue is Money) && !(propertyValue is double) && !(propertyValue is float) && !(propertyValue is decimal) && !(propertyValue is byte) && !(propertyValue is ushort) && !(propertyValue is uint) && !(propertyValue is ulong) && !(propertyValue is sbyte) && !(propertyValue is short) && !(propertyValue is int))
		{
			return propertyValue is long;
		}
		return true;
	}

	public object GetValue(IEntity entity, Guid propertyUid)
	{
		return entity.GetPropertyValue(propertyUid);
	}
}
