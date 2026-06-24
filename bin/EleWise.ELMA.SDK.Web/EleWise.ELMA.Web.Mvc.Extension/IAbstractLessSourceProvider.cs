namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

public interface IAbstractLessSourceProvider
{
	string Area { get; }

	string ContentPath { get; }

	string FileName { get; }
}
