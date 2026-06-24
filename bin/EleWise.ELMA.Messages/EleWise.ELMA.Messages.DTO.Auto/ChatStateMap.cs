using System;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.Messages.Impl.Actors.ActorStates;
using EleWise.ELMA.Model.AutoMaps;

namespace EleWise.ELMA.Messages.DTO.AutoMaps;

internal sealed class ChatStateMap : BidirectionalMap<ChatState, ChatDTO>
{
	protected override void InitMap(IMappingExpression<ChatState, ChatDTO> map)
	{
		base.InitMap(map);
		map.ForMember<string>((Expression<Func<ChatDTO, string>>)((ChatDTO m) => m.LastReadMessageHash), (Action<IMemberConfigurationExpression<ChatState, ChatDTO, string>>)delegate(IMemberConfigurationExpression<ChatState, ChatDTO, string> opt)
		{
			opt.MapFrom<string>((Expression<Func<ChatState, string>>)((ChatState a) => a.LastReadHash));
		});
		map.ForMember<bool>((Expression<Func<ChatDTO, bool>>)((ChatDTO m) => m.IsMember), (Action<IMemberConfigurationExpression<ChatState, ChatDTO, bool>>)delegate(IMemberConfigurationExpression<ChatState, ChatDTO, bool> opt)
		{
			opt.UseValue<bool>(true);
		});
	}
}
