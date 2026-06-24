using EleWise.ELMA.Messages.Impl.Actors.ActorStates;
using EleWise.ELMA.Messages.Models.Chats;
using EleWise.ELMA.Model.AutoMaps;

namespace EleWise.ELMA.Messages.DTO.AutoMaps;

internal sealed class MessageActorStateMap : BidirectionalMap<IChatMessage, MessageActorState>
{
}
