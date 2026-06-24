namespace EleWise.ELMA.Ioc;

public interface ILazy<out T> where T : class
{
	T Value();
}
