using Bridge;

namespace EleWise.ELMA.Model.ViewModel;

[ObjectLiteral]
public interface IChangeEvent : IEvent
{
}
[ObjectLiteral]
public interface IChangeEvent<T> : IEvent<T>, IEvent, IChangeEvent
{
}
