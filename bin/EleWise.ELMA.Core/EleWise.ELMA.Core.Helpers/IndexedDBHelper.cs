using System.Threading.Tasks;
using Bridge;

namespace EleWise.ELMA.Core.Helpers;

internal static class IndexedDBHelper
{
	[Template("elmaComponents.IndexedDB.put({storeName}, {key}, {value})")]
	public static extern void Put(string storeName, string key, object value);

	[Template("elmaComponents.IndexedDB.get({storeName})")]
	public static extern IPromise Count(string storeName);

	[Template("elmaComponents.IndexedDB.get({storeName}, {key})")]
	public static extern IPromise Get(string storeName, string key);

	[Template("elmaComponents.IndexedDB.getValues({storeName}, {keys})")]
	public static extern IPromise GetValues(string storeName, string[] keys);

	[Template("elmaComponents.IndexedDB.getAllValues({storeName})")]
	public static extern IPromise GetValues(string storeName);

	[Template("elmaComponents.IndexedDB.getAllKeys({storeName})")]
	public static extern IPromise GetAllKeys(string storeName);

	[Template("elmaComponents.IndexedDB.remove({storeName}, {key})")]
	public static extern void Remove(string storeName, string key);

	[Template("elmaComponents.IndexedDB.clear({storeName})")]
	public static extern void Clear(string storeName);
}
