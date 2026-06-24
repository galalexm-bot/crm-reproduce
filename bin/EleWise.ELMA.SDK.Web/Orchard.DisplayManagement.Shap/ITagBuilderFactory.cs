namespace Orchard.DisplayManagement.Shapes;

public interface ITagBuilderFactory : IDependency
{
	OrchardTagBuilder Create(dynamic shape, string tagName);
}
