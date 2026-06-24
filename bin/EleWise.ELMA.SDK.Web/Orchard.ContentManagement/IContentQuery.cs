using System.Collections.Generic;

namespace Orchard.ContentManagement;

public interface IContentQuery
{
	IContentManager ContentManager { get; }

	IContentQuery<TPart> ForPart<TPart>() where TPart : IContent;
}
public interface IContentQuery<TPart> : IContentQuery where TPart : IContent
{
	IContentQuery<TPart> ForType(params string[] contentTypes);

	IEnumerable<TPart> List();
}
