using System.Collections.Generic;

namespace EleWise.ELMA.Services;

public interface IEnumerableLazy<T> : ILazy<IEnumerable<T>> where T : class
{
}
