namespace EleWise.ELMA.Packaging.Components.PostgreSQL;

public class PostgreSQLFolder : ElmaMappedFolder
{
	protected override string SourcePath => "Content\\";

	protected override string TargetPath => "";

	public PostgreSQLFolder(IElmaComponent component)
		: base(component)
	{
	}
}
