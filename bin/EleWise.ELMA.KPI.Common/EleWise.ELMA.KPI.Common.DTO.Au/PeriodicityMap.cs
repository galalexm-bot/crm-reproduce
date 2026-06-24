using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.KPI.Common.DTO.Models;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Model.AutoMaps;

namespace EleWise.ELMA.KPI.Common.DTO.AutoMaps;

public class PeriodicityMap : SimpleMap<IPeriodicity, PeriodicityDTO>
{
	protected override void InitMap(IMappingExpression<IPeriodicity, PeriodicityDTO> map)
	{
		base.InitMap(map);
		map.ForMember<Guid>((Expression<Func<PeriodicityDTO, Guid>>)((PeriodicityDTO e) => e.Id), (Action<IMemberConfigurationExpression<IPeriodicity, PeriodicityDTO, Guid>>)delegate(IMemberConfigurationExpression<IPeriodicity, PeriodicityDTO, Guid> o)
		{
			o.Ignore();
		});
		map.ForMember<Collection<CustomPeriodDTO>>((Expression<Func<PeriodicityDTO, Collection<CustomPeriodDTO>>>)((PeriodicityDTO e) => e.Periods), (Action<IMemberConfigurationExpression<IPeriodicity, PeriodicityDTO, Collection<CustomPeriodDTO>>>)delegate(IMemberConfigurationExpression<IPeriodicity, PeriodicityDTO, Collection<CustomPeriodDTO>> o)
		{
			o.Ignore();
		});
		map.AfterMap((Action<IPeriodicity, PeriodicityDTO>)delegate(IPeriodicity entity, PeriodicityDTO dto)
		{
			if (entity.Periods != null)
			{
				foreach (IPersistedCustomPeriod item in (IEnumerable<IPersistedCustomPeriod>)entity.Periods)
				{
					((IPersistedCustomPeriod)Mapper.Map((object)item, typeof(CustomPeriodDTO), typeof(IPersistedCustomPeriod))).Periodicity = entity;
				}
			}
		});
	}
}
