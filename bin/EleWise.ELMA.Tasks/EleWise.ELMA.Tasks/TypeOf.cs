using System.Reflection;
using System.Reflection.Extensions;
using EleWise.ELMA.Tasks.Managers;

namespace EleWise.ELMA.Tasks;

public static class TypeOf
{
	public static readonly RipeType TaskBaseManager1 = typeof(TaskBaseManager<>).ToRipeType();
}
