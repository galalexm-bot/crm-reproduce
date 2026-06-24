using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Tasks.Models;

[Uid("90DACDD5-5F7D-4EBB-B639-9AB7672CFFBC")]
[BaseClass("0f338330-068c-4135-be4e-95797a209c4e")]
[ShowInTypeTree(false)]
[ShowInDesigner(false)]
[ShowInCatalogList(false)]
[FilterType(typeof(ITaskControlFilter))]
[Filterable]
[EntityMetadataType(EntityMetadataType.Interface)]
[ClassGenerator(typeof(CustomFilterGenerator))]
public interface ITaskControl : IAutoImplement
{
}
