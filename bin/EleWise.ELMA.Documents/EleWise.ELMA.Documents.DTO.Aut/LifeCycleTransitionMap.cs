using System;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.AutoMaps;

namespace EleWise.ELMA.Documents.DTO.AutoMaps;

public class LifeCycleTransitionMap : BidirectionalMap<ILifeCycleTransition, LifeCycleTransitionDTO>
{
	protected override void InitReverseMap(IMappingExpression<LifeCycleTransitionDTO, ILifeCycleTransition> map)
	{
		base.InitReverseMap(map);
		map.ForMember<ILifeCycleStatus>((Expression<Func<ILifeCycleTransition, ILifeCycleStatus>>)((ILifeCycleTransition m) => m.Start), (Action<IMemberConfigurationExpression<LifeCycleTransitionDTO, ILifeCycleTransition, ILifeCycleStatus>>)delegate(IMemberConfigurationExpression<LifeCycleTransitionDTO, ILifeCycleTransition, ILifeCycleStatus> a)
		{
			a.MapFrom<ILifeCycleStatus>((Expression<Func<LifeCycleTransitionDTO, ILifeCycleStatus>>)((LifeCycleTransitionDTO s) => LifeCycleStatusManager.Instance.Load(s.Start.Id)));
		});
		map.ForMember<ILifeCycleStatus>((Expression<Func<ILifeCycleTransition, ILifeCycleStatus>>)((ILifeCycleTransition m) => m.Finish), (Action<IMemberConfigurationExpression<LifeCycleTransitionDTO, ILifeCycleTransition, ILifeCycleStatus>>)delegate(IMemberConfigurationExpression<LifeCycleTransitionDTO, ILifeCycleTransition, ILifeCycleStatus> a)
		{
			a.MapFrom<ILifeCycleStatus>((Expression<Func<LifeCycleTransitionDTO, ILifeCycleStatus>>)((LifeCycleTransitionDTO s) => LifeCycleStatusManager.Instance.Load(s.Finish.Id)));
		});
	}
}
