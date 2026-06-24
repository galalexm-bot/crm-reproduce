using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Html.Card;

public sealed class CardBuilder
{
	public Card Card { get; private set; }

	public CardBuilder(HtmlHelper htmlHelper)
	{
		Card = new Card(htmlHelper);
	}

	public CardBuilder CardAttributes(object cardAttributes)
	{
		Card.ContainerAttributes = cardAttributes;
		return this;
	}

	public CardBuilder PaddingSize(CardSize paddingSize)
	{
		Card.PaddingSize = paddingSize;
		return this;
	}

	public CardBuilder ShadowType(CardShadowType shadowType)
	{
		Card.ShadowType = shadowType;
		return this;
	}

	public CardBuilder FullWidth(bool fullWidth)
	{
		Card.FullWidth = fullWidth;
		return this;
	}

	public Card Render()
	{
		return Card.Render();
	}
}
