using Bridge;

namespace EleWise.ELMA.Model.ViewModel;

[ObjectLiteral]
public interface IKeyboardEvent : IEvent
{
}
[ObjectLiteral]
public interface IKeyboardEvent<T> : IEvent<T>, IEvent, IKeyboardEvent
{
}
