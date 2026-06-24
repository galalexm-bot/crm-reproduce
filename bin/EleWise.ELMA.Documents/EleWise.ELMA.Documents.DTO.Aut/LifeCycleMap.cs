using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.AutoMaps;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.Documents.DTO.AutoMaps;

public class LifeCycleMap : BidirectionalMap<ILifeCycle, LifeCycleDTO>
{
	protected override void InitMap(IMappingExpression<ILifeCycle, LifeCycleDTO> map)
	{
		base.InitMap(map);
		map.ForMember<List<LifeCycleStatusDTO>>((Expression<Func<LifeCycleDTO, List<LifeCycleStatusDTO>>>)((LifeCycleDTO m) => m.Statuses), (Action<IMemberConfigurationExpression<ILifeCycle, LifeCycleDTO, List<LifeCycleStatusDTO>>>)delegate(IMemberConfigurationExpression<ILifeCycle, LifeCycleDTO, List<LifeCycleStatusDTO>> a)
		{
			a.Ignore();
		});
		map.ForMember<List<LifeCycleTransitionDTO>>((Expression<Func<LifeCycleDTO, List<LifeCycleTransitionDTO>>>)((LifeCycleDTO m) => m.Transitions), (Action<IMemberConfigurationExpression<ILifeCycle, LifeCycleDTO, List<LifeCycleTransitionDTO>>>)delegate(IMemberConfigurationExpression<ILifeCycle, LifeCycleDTO, List<LifeCycleTransitionDTO>> a)
		{
			a.Ignore();
		});
		map.AfterMap((Action<ILifeCycle, LifeCycleDTO>)MapStatusesAndTransitionsToDto);
	}

	protected override void InitReverseMap(IMappingExpression<LifeCycleDTO, ILifeCycle> map)
	{
		base.InitReverseMap(map);
		map.ForMember<ISet<ILifeCycleStatus>>((Expression<Func<ILifeCycle, ISet<ILifeCycleStatus>>>)((ILifeCycle m) => m.Statuses), (Action<IMemberConfigurationExpression<LifeCycleDTO, ILifeCycle, ISet<ILifeCycleStatus>>>)delegate(IMemberConfigurationExpression<LifeCycleDTO, ILifeCycle, ISet<ILifeCycleStatus>> a)
		{
			a.Ignore();
		});
		map.ForMember<ISet<ILifeCycleTransition>>((Expression<Func<ILifeCycle, ISet<ILifeCycleTransition>>>)((ILifeCycle m) => m.Transitions), (Action<IMemberConfigurationExpression<LifeCycleDTO, ILifeCycle, ISet<ILifeCycleTransition>>>)delegate(IMemberConfigurationExpression<LifeCycleDTO, ILifeCycle, ISet<ILifeCycleTransition>> a)
		{
			a.Ignore();
		});
		map.ForMember<ILifeCycleStatus>((Expression<Func<ILifeCycle, ILifeCycleStatus>>)((ILifeCycle m) => m.DefaultStatus), (Action<IMemberConfigurationExpression<LifeCycleDTO, ILifeCycle, ILifeCycleStatus>>)delegate(IMemberConfigurationExpression<LifeCycleDTO, ILifeCycle, ILifeCycleStatus> a)
		{
			a.MapFrom<ILifeCycleStatus>((Expression<Func<LifeCycleDTO, ILifeCycleStatus>>)((LifeCycleDTO s) => (s.DefaultStatus != null) ? LifeCycleStatusManager.Instance.LoadOrNull(s.DefaultStatus.Id) : null));
		});
		map.AfterMap((Action<LifeCycleDTO, ILifeCycle>)MapStatusesAndTransitions);
	}

	private static void MapStatusesAndTransitions(LifeCycleDTO dto, ILifeCycle obj)
	{
		List<ILifeCycleStatus> list = dto.Statuses.Select((LifeCycleStatusDTO s) => Mapper.Map<LifeCycleStatusDTO, ILifeCycleStatus>(s, (s.Id > 0) ? LifeCycleStatusManager.Instance.Load(s.Id) : LifeCycleStatusManager.Instance.Create())).ToList();
		((ICollection<ILifeCycleStatus>)obj.Statuses).Clear();
		obj.Statuses.AddAll((ICollection<ILifeCycleStatus>)list);
		List<ILifeCycleTransition> list2 = dto.Transitions.Select((LifeCycleTransitionDTO t) => Mapper.Map<LifeCycleTransitionDTO, ILifeCycleTransition>(t, (t.Id > 0) ? LifeCycleTransitionManager.Instance.Load(t.Id) : LifeCycleTransitionManager.Instance.Create())).ToList();
		((ICollection<ILifeCycleTransition>)obj.Transitions).Clear();
		obj.Transitions.AddAll((ICollection<ILifeCycleTransition>)list2);
	}

	private static void MapStatusesAndTransitionsToDto(ILifeCycle obj, LifeCycleDTO dto)
	{
		dto.Statuses.Clear();
		foreach (ILifeCycleStatus item in (IEnumerable<ILifeCycleStatus>)obj.Statuses)
		{
			dto.Statuses.Add(Mapper.Map<ILifeCycleStatus, LifeCycleStatusDTO>(item, new LifeCycleStatusDTO()));
		}
		dto.Transitions.Clear();
		foreach (ILifeCycleTransition item2 in (IEnumerable<ILifeCycleTransition>)obj.Transitions)
		{
			dto.Transitions.Add(Mapper.Map<ILifeCycleTransition, LifeCycleTransitionDTO>(item2, new LifeCycleTransitionDTO()));
		}
	}
}
