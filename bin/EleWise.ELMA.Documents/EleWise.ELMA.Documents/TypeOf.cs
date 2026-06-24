using System.Reflection;
using System.Reflection.Extensions;
using EleWise.ELMA.Documents.Managers;

namespace EleWise.ELMA.Documents;

public static class TypeOf
{
	public static readonly RipeType DocumentManager2 = typeof(DocumentManager<, >).ToRipeType();
}
