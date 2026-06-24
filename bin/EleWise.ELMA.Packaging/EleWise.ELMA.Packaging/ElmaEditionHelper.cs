namespace EleWise.ELMA.Packaging;

public static class ElmaEditionHelper
{
	public static string GetDisplayName(ElmaEdition edition)
	{
		return edition switch
		{
			ElmaEdition.CE => SR.T("Community Edition"), 
			ElmaEdition.Express => SR.T("Экспресс"), 
			ElmaEdition.Standart => SR.T("Стандарт"), 
			ElmaEdition.Enterprise => SR.T("Корпоративная"), 
			_ => edition.ToString(), 
		};
	}
}
