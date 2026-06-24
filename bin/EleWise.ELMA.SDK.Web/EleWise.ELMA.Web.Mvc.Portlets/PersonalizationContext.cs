namespace EleWise.ELMA.Web.Mvc.Portlets;

public class PersonalizationContext
{
	private PersonalizationScope _currentScope;

	private readonly string _path;

	public PersonalizationScope CurrentScope => _currentScope;

	public string Path => _path;

	public PersonalizationContext(PersonalizationScope currentScope, string path)
	{
		_currentScope = currentScope;
		_path = path;
	}

	public void SetScope(PersonalizationScope scope)
	{
		_currentScope = scope;
	}
}
