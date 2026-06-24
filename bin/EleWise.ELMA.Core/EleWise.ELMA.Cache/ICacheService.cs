using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Cache;

[ExtensionPoint]
public interface ICacheService
{
	System.Threading.Tasks.Task<int> Count();

	System.Threading.Tasks.Task<object> Get(string key);

	System.Threading.Tasks.Task<object[]> GetValues();

	System.Threading.Tasks.Task<object[]> GetValues(string[] keys);

	void Set(string key, object value);

	void Remove(string key);

	void Clear();

	System.Threading.Tasks.Task<string[]> GetAllKeys();
}
