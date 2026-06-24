using Bridge;

namespace EleWise.ELMA.Model.ViewModel;

[ObjectLiteral]
public class ChangeEvent<T> : Event<T>, IChangeEvent<T>, IEvent<T>, IEvent, IChangeEvent
{
}
