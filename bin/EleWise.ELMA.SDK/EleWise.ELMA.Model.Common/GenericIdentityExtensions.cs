namespace EleWise.ELMA.Model.Common;

public static class GenericIdentityExtensions
{
	public static bool Same<T>(this IGenericIdentity<T> source, IGenericIdentity<T> target)
	{
		if (source == null && target == null)
		{
			return true;
		}
		if (source == null || target == null)
		{
			return false;
		}
		return source.Id.Equals(target.Id);
	}
}
