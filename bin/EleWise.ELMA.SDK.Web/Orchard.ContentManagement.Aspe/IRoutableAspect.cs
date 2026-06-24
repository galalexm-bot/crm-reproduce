namespace Orchard.ContentManagement.Aspects;

public interface IRoutableAspect : ITitleAspect, IContent, IAliasAspect
{
	string Slug { get; set; }
}
