using System;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Web.Mvc.Models.Grids;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public struct FilterModelSettings
{
	private bool gridStatePrefixChanged;

	private string gridStatePrefix;

	public IFilterBase Filter { get; set; }

	public Guid FilterObjectTypeUid { get; set; }

	public Guid? TypeUid { get; set; }

	public Guid? MainTypeUid { get; set; }

	public string GridStatePrefix
	{
		get
		{
			if (!gridStatePrefixChanged)
			{
				return "Filter";
			}
			return gridStatePrefix;
		}
		set
		{
			gridStatePrefixChanged = true;
			gridStatePrefix = value;
		}
	}

	public string GridStateId { get; set; }

	public IEntityFilter FilterToMerge { get; set; }

	public Guid? FilterCode { get; set; }

	public bool EnableEqlQuery { get; set; }

	public GridState GetSourceForRefresh { get; set; }

	public string GridIdPrefix { get; set; }

	public string TypesRootName { get; set; }

	public Type FilterEntityType { get; set; }
}
