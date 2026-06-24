using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Content;

public interface IContentItem
{
	string Id { get; }

	string Name { get; }

	string Description { get; }

	string Image16 { get; }

	string Image24 { get; }

	string Image32 { get; }

	int Order { get; }

	string GetImage(ObjectIconFormat size);
}
