using System.Web;

namespace EleWise.ELMA.Web.Mvc.Models.Inputs;

public class BindClientEventsBuilder : IHtmlString
{
	protected BindClientEventsComponent Component { get; private set; }

	public BindClientEventsBuilder(BindClientEventsComponent component)
	{
		Component = component;
	}

	public BindClientEventsBuilder OnChange(string handler)
	{
		Component.OnChange = handler;
		return this;
	}

	public BindClientEventsBuilder OnClick(string handler)
	{
		Component.OnClick = handler;
		return this;
	}

	public virtual void Render()
	{
		Component.Render();
	}

	public string ToHtmlString()
	{
		return Component.ToHtmlString();
	}

	public override string ToString()
	{
		return ToHtmlString();
	}
}
