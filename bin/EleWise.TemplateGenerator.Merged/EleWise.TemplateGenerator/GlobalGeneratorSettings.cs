namespace EleWise.TemplateGenerator;

public static class GlobalGeneratorSettings
{
	public static IGeneratorProvider DefaultProvider { get; set; }

	static GlobalGeneratorSettings()
	{
		DefaultProvider = new DefaultGeneratorProvider();
	}
}
