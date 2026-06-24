using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.History.Services;

internal interface IEventSerializationService
{
	EntityActionEventArgs Deserialize(string serializedData);

	string Serialize(EntityActionEventArgs eventArgs);
}
