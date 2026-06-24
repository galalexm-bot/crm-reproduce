using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Models;

[Serializable]
[MetadataType(typeof(EnumMetadata))]
[Uid("49d918d6-3755-4cd1-8456-d572c65b2086")]
[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_SignType), "DisplayName")]
[EnumMetadataType(EnumMetadataType.ExtendableEnum)]
[TypeConverter(typeof(EnumBaseConverter<SignType>))]
[DefaultValueUid("901d68b6-9c46-4ac5-beb9-21b21cf1d133")]
public class SignType : EnumBase
{
	private static SignType _notSign = new SignType(new Guid("901d68b6-9c46-4ac5-beb9-21b21cf1d133"), "NotSign");

	private static SignType _fullSign = new SignType(new Guid("5d08d574-a451-4a1a-b980-6e1a460a8977"), "FullSign");

	[Uid("901d68b6-9c46-4ac5-beb9-21b21cf1d133")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_SignType), "P_NotSign_DisplayName")]
	public static SignType NotSign => _notSign;

	[Uid("5d08d574-a451-4a1a-b980-6e1a460a8977")]
	[EleWise.ELMA.Model.Attributes.DisplayName(typeof(__Resources_SignType), "P_FullSign_DisplayName")]
	public static SignType FullSign => _fullSign;

	public SignType(Guid value, string name)
		: base(value, name)
	{
	}

	protected SignType(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
