using System.Collections;
using System.Collections.Generic;

namespace EleWise.ELMA.Hubs;

public interface INameValueCollectionWrapper : IEnumerable<KeyValuePair<string, string>>, IEnumerable
{
	string this[string key] { get; }

	IEnumerable<string> GetValues(string key);

	string Get(string key);
}
