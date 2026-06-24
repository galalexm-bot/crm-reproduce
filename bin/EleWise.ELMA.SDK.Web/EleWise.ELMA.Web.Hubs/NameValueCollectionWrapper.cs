using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Hubs;
using Microsoft.AspNet.SignalR.Hosting;

namespace EleWise.ELMA.Web.Hubs;

internal sealed class NameValueCollectionWrapper : INameValueCollectionWrapper, IEnumerable<KeyValuePair<string, string>>, IEnumerable
{
	private readonly INameValueCollection collection;

	public string this[string key] => collection.get_Item(key);

	public NameValueCollectionWrapper(INameValueCollection collection)
	{
		this.collection = collection;
	}

	public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
	{
		return ((IEnumerable<KeyValuePair<string, string>>)collection).GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return ((IEnumerable<KeyValuePair<string, string>>)collection).GetEnumerator();
	}

	public IEnumerable<string> GetValues(string key)
	{
		return collection.GetValues(key);
	}

	public string Get(string key)
	{
		return collection.Get(key);
	}
}
