namespace EleWise.ELMA.Web.Mvc.Binders;

public class DateTimeNoOffsetBinder : DateTimeBinder
{
	public DateTimeNoOffsetBinder()
		: base(noOffsetFlag: true)
	{
	}
}
