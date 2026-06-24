namespace Nemerle.Collections;

public interface ICovariantEnumerable<out T>
{
	ICovariantEnumerator<T> GetEnumerator();
}
