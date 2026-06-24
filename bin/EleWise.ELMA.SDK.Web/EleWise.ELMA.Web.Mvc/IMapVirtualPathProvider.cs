namespace EleWise.ELMA.Web.Mvc;

public interface IMapVirtualPathProvider
{
	string GetExistsFilePath(string virtualPath);
}
