using System.Runtime.Serialization;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class ScriptExecutionRequest
{
	[DataMember]
	public string ScriptName { get; set; }

	[DataMember]
	public string Model { get; set; }

	[DataMember]
	public string Item { get; set; }

	[DataMember]
	public ModelInfo ModelInfo { get; set; }

	[DataMember]
	public SerializedModel[] AdditionalModels { get; set; }

	[DataMember]
	public EntityTypeSerializationSettings[] EntityTypeSerializationSettings { get; set; }

	[DataMember]
	public UIRuntimeModel RuntimeModel { get; set; }

	public ScriptExecutionRequest()
	{
		AdditionalModels = new SerializedModel[0];
		EntityTypeSerializationSettings = new EntityTypeSerializationSettings[0];
	}

	internal ScriptExecutionParams ToParams()
	{
		return new ScriptExecutionParams
		{
			Item = Item,
			Model = Model,
			AdditionalModels = AdditionalModels,
			ModelInfo = ModelInfo,
			ScriptName = ScriptName
		};
	}
}
