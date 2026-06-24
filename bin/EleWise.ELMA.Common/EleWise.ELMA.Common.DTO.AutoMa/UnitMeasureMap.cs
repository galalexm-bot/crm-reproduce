using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.Common.DTO.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.AutoMaps;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Common.DTO.AutoMaps;

public class UnitMeasureMap : BidirectionalMap<IUnitMeasure, UnitMeasureDTO>
{
	protected override void InitMap(IMappingExpression<IUnitMeasure, UnitMeasureDTO> map)
	{
		base.InitMap(map);
		map.ForMember<long>((Expression<Func<UnitMeasureDTO, long>>)((UnitMeasureDTO e) => e.Id), (Action<IMemberConfigurationExpression<IUnitMeasure, UnitMeasureDTO, long>>)delegate(IMemberConfigurationExpression<IUnitMeasure, UnitMeasureDTO, long> o)
		{
			o.Ignore();
		});
		map.ForMember<UnitMeasurePropertiesDTO>((Expression<Func<UnitMeasureDTO, UnitMeasurePropertiesDTO>>)((UnitMeasureDTO e) => e.Properties), (Action<IMemberConfigurationExpression<IUnitMeasure, UnitMeasureDTO, UnitMeasurePropertiesDTO>>)delegate(IMemberConfigurationExpression<IUnitMeasure, UnitMeasureDTO, UnitMeasurePropertiesDTO> o)
		{
			o.Ignore();
		});
		map.ForMember<IList<WpiSelectListItemDTO>>((Expression<Func<UnitMeasureDTO, IList<WpiSelectListItemDTO>>>)((UnitMeasureDTO e) => e.WpiSelectList), (Action<IMemberConfigurationExpression<IUnitMeasure, UnitMeasureDTO, IList<WpiSelectListItemDTO>>>)delegate(IMemberConfigurationExpression<IUnitMeasure, UnitMeasureDTO, IList<WpiSelectListItemDTO>> o)
		{
			o.Ignore();
		});
	}

	protected override void InitReverseMap(IMappingExpression<UnitMeasureDTO, IUnitMeasure> map)
	{
		base.InitReverseMap(map);
		map.ForMember<long>((Expression<Func<IUnitMeasure, long>>)((IUnitMeasure e) => e.Id), (Action<IMemberConfigurationExpression<UnitMeasureDTO, IUnitMeasure, long>>)delegate(IMemberConfigurationExpression<UnitMeasureDTO, IUnitMeasure, long> o)
		{
			o.Ignore();
		});
		map.ForMember<IUnitMeasureProperties>((Expression<Func<IUnitMeasure, IUnitMeasureProperties>>)((IUnitMeasure e) => e.Properties), (Action<IMemberConfigurationExpression<UnitMeasureDTO, IUnitMeasure, IUnitMeasureProperties>>)delegate(IMemberConfigurationExpression<UnitMeasureDTO, IUnitMeasure, IUnitMeasureProperties> o)
		{
			o.Ignore();
		});
		map.ForMember<ISet<IWpiSelectListItem>>((Expression<Func<IUnitMeasure, ISet<IWpiSelectListItem>>>)((IUnitMeasure e) => e.WpiSelectList), (Action<IMemberConfigurationExpression<UnitMeasureDTO, IUnitMeasure, ISet<IWpiSelectListItem>>>)delegate(IMemberConfigurationExpression<UnitMeasureDTO, IUnitMeasure, ISet<IWpiSelectListItem>> o)
		{
			o.Ignore();
		});
	}
}
