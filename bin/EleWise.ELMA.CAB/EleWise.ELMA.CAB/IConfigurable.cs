using System.Collections.Specialized;

namespace EleWise.ELMA.CAB;

public interface IConfigurable
{
	void Configure(NameValueCollection settings);
}
