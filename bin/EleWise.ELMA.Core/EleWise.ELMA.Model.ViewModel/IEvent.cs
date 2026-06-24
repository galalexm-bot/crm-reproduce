using Bridge;

namespace EleWise.ELMA.Model.ViewModel;

[ObjectLiteral]
public interface IEvent
{
	long CaretPosition { get; set; }
}
[ObjectLiteral]
public interface IEvent<T> : IEvent
{
	T Value { get; set; }
}
