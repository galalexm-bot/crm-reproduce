using Bridge;

namespace EleWise.ELMA.Model.ViewModel;

[ObjectLiteral]
public class FocusEvent<T> : Event<T>, IFocusEvent<T>, IEvent<T>, IEvent, IFocusEvent
{
}
