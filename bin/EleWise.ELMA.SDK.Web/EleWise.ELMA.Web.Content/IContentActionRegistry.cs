namespace EleWise.ELMA.Web.Content;

public interface IContentActionRegistry
{
	IContentAction Get(string typeId, string id);
}
