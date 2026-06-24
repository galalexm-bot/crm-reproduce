namespace EleWise.ELMA.Packaging.Components.Web;

public class WebProjectSystem : ElmaProjectSystem
{
	public WebProjectSystem(IElmaComponent component)
		: base(component, "bin")
	{
	}
}
