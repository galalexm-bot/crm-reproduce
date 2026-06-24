namespace EleWise.ELMA.Model.Types.Settings;

public interface IHasDefaultValue<T>
{
	T DefaultValue { get; set; }
}
