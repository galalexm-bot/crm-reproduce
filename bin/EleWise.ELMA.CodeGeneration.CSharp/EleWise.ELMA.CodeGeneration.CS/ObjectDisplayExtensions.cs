using EleWise.ELMA.CodeGeneration.CSharp.Enums;

namespace EleWise.ELMA.CodeGeneration.CSharp.Extensions;

internal static class ObjectDisplayExtensions
{
	internal static bool IncludesOption(this ObjectDisplayOptions options, ObjectDisplayOptions flag)
	{
		return (options & flag) == flag;
	}
}
