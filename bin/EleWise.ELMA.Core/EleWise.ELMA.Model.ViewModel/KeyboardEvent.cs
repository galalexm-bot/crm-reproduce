using Bridge;

namespace EleWise.ELMA.Model.ViewModel;

[ObjectLiteral]
public class KeyboardEvent<T> : Event<T>, IKeyboardEvent<T>, IEvent<T>, IEvent, IKeyboardEvent
{
}
