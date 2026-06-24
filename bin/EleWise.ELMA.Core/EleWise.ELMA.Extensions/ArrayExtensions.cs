using System;
using Bridge;

namespace EleWise.ELMA.Extensions;

[External]
[Convention(/*Could not decode attribute arguments.*/)]
public static class ArrayExtensions
{
	[Template("{array}.find({callback})")]
	public static extern T Find<T>(this T[] array, Func<T, bool> callback);

	[Template("{array}.find({callback})")]
	public static extern T Find<T>(this T[] array, Func<T, int, bool> callback);

	[Template("{array}.find({callback})")]
	public static extern T Find<T>(this T[] array, Func<T, int, T[], bool> callback);
}
