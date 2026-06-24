namespace EleWise.ELMA.Modules;

public interface IWebModuleUnit
{
	string Uid { get; }

	string Name { get; }

	string DisplayName { get; }

	string Description { get; }

	string Author { get; }

	string WebSite { get; }
}
