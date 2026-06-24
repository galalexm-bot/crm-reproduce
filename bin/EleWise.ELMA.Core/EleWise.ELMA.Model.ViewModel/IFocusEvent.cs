using Bridge;

namespace EleWise.ELMA.Model.ViewModel;

[ObjectLiteral]
public interface IFocusEvent : IEvent
{
}
[ObjectLiteral]
public interface IFocusEvent<T> : IEvent<T>, IEvent, IFocusEvent
{
}
