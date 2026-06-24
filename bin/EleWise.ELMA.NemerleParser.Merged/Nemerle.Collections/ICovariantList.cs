namespace Nemerle.Collections;

public interface ICovariantList<out T>
{
	bool IsEmpty { get; }

	T Head { get; }

	ICovariantList<T> CovariantTail { get; }
}
