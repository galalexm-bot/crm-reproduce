using System;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Web.Service.Internal.Model;

[DataContract]
internal sealed class ActionExecutionRequest
{
	[DataMember]
	public Guid TypeUid { get; set; }

	[DataMember]
	public Guid InstanceUid { get; set; }

	[DataMember]
	public string ScriptName { get; set; }

	[DataMember]
	public string Parameter { get; set; }

	[DataMember]
	public TypeSignature ParameterType { get; set; }

	[DataMember]
	public TypeSignature ReturnType { get; set; }

	[DataMember]
	public EntityTypeSerializationSettings[] EntityTypeSerializationSettings { get; set; }

	[DataMember]
	public UIRuntimeModel RuntimeModel { get; set; }

	public ActionExecutionRequest()
	{
		EntityTypeSerializationSettings = new EntityTypeSerializationSettings[0];
	}

	internal ActionExecutionParams ToParams()
	{
		return new ActionExecutionParams
		{
			Parameter = Parameter,
			InstanceUid = InstanceUid,
			ParameterType = ParameterType,
			ReturnType = ReturnType,
			ScriptName = ScriptName,
			TypeUid = TypeUid,
			EntityTypeSerializationSettings = EntityTypeSerializationSettings
		};
	}
}
