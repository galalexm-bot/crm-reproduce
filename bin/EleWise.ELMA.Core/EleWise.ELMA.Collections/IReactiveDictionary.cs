using System.Collections;
using System.Collections.Generic;
using Bridge;

namespace EleWise.ELMA.Collections;

[Reflectable]
[External]
[Module("Reactive")]
public interface IReactiveDictionary<TKey, TValue> : IDictionary<TKey, TValue>, System.Collections.Generic.ICollection<KeyValuePair<TKey, TValue>>, System.Collections.Generic.IEnumerable<KeyValuePair<TKey, TValue>>, System.Collections.IEnumerable, IBridgeClass
{
}
