using System;
using System.Linq.Expressions;
using AutoMapper;
using EleWise.ELMA.Messages.Impl.Actors.ActorStates;
using EleWise.ELMA.Model.AutoMaps;

namespace EleWise.ELMA.Messages.DTO.AutoMaps;

internal sealed class ChatActorStateMap : BidirectionalMap<ChatActorState, ChatDTO>
{
	protected override void InitMap(IMappingExpression<ChatActorState, ChatDTO> map)
	{
		base.InitMap(map);
		map.ForMember<string>((Expression<Func<ChatDTO, string>>)((ChatDTO m) => m.LastMessageHash), (Action<IMemberConfigurationExpression<ChatActorState, ChatDTO, string>>)delegate(IMemberConfigurationExpression<ChatActorState, ChatDTO, string> opt)
		{
			opt.MapFrom<string>((Expression<Func<ChatActorState, string>>)((ChatActorState a) => a.LastHash));
		});
		map.ForMember<ParticipantsDTO>((Expression<Func<ChatDTO, ParticipantsDTO>>)((ChatDTO m) => m.Participants), (Action<IMemberConfigurationExpression<ChatActorState, ChatDTO, ParticipantsDTO>>)delegate(IMemberConfigurationExpression<ChatActorState, ChatDTO, ParticipantsDTO> o)
		{
			o.ResolveUsing<ParticipantsDTO>((Func<ChatActorState, ParticipantsDTO>)((ChatActorState c) => (c.Recipients != null) ? new ParticipantsDTO
			{
				Users = c.Recipients,
				ParticipantsCount = c.Recipients.Count
			} : null));
		});
	}
}
