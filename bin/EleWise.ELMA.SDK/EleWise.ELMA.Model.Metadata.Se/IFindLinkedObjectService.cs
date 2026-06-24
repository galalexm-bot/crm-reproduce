namespace EleWise.ELMA.Model.Metadata.Services;

public interface IFindLinkedObjectService
{
	LinkedObjectsSearchResult FindLinkedObjects(RuntimeObjectsSearchParams searchParams);

	LinkedObjectsSearchResult FindLinkedObjects(LinkedObjectsSearchParams searchParams);
}
