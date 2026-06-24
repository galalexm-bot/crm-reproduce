namespace EleWise.ELMA.Web.Mvc.Html;

public interface INamingService
{
	string GenerateName(string prefix);

	void CheckName(string name);

	void RegisterName(string name);
}
