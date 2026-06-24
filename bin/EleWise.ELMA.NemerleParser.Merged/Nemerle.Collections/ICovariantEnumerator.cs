namespace Nemerle.Collections;

public interface ICovariantEnumerator<out T>
{
	T Current { get; }

	bool MoveNext();

	void Reset();
}
