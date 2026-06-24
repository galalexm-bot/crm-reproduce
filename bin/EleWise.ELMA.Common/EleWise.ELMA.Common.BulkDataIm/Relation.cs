using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Models;

public class Relation
{
	public readonly RelationType RelationType;

	public readonly string KeyProperty;

	public MapObject TargetObject { get; set; }

	public Relation(RelationType relationType = RelationType.ManyToMany)
	{
		RelationType = relationType;
	}

	public Relation(string keyProperty)
	{
		RelationType = RelationType.OneToMany;
		KeyProperty = keyProperty;
	}
}
