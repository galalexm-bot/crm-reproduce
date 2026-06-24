using System.Collections;

namespace EleWise.ELMA.Helpers;

public static class HashCodeHelper
{
	internal static HashCodeHelper DggWwbhc81qpplBV6ACE;

	public static int GetGashCode32(IEnumerable enumerable)
	{
		HashCodeCombiner hashCodeCombiner = new HashCodeCombiner();
		pZ1YBihcI7K2fHERkmaQ(hashCodeCombiner, enumerable);
		return jfOfsDhcV8Tke2R2Rv0P(hashCodeCombiner);
	}

	public static string GetGashCodeString(IEnumerable enumerable)
	{
		HashCodeCombiner hashCodeCombiner = new HashCodeCombiner();
		pZ1YBihcI7K2fHERkmaQ(hashCodeCombiner, enumerable);
		return hashCodeCombiner.CombinedHashString;
	}

	internal static void pZ1YBihcI7K2fHERkmaQ(object P_0, object P_1)
	{
		((HashCodeCombiner)P_0).AddEnumerable((IEnumerable)P_1);
	}

	internal static int jfOfsDhcV8Tke2R2Rv0P(object P_0)
	{
		return ((HashCodeCombiner)P_0).CombinedHash32;
	}

	internal static bool LAr55KhcZvQdhcnhHQrF()
	{
		return DggWwbhc81qpplBV6ACE == null;
	}

	internal static HashCodeHelper G7aophhcucgJPuQkZ83u()
	{
		return DggWwbhc81qpplBV6ACE;
	}
}
