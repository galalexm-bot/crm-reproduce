using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Workflow.Models;

public interface IProcessContext : IEntityMetadata, IRootMetadata, IMetadata, IXsiType, ICodeItemMetadata, IGroupedMetadata
{
}
