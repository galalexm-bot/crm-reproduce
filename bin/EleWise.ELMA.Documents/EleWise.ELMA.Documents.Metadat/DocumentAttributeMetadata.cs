using System;
using System.Reflection;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Metadata;

[Serializable]
[DataContract]
public class DocumentAttributeMetadata : EntityPropertyMetadata
{
	[XmlElement("RegistrationCardProperty")]
	[DataMember]
	public PropertyDescription RegistrationCardProperty { get; set; }

	public override void LoadFromPropertyInfo(PropertyInfo propertyInfo, PropertyMetadata filterTargetPropertyMetadata)
	{
		base.LoadFromPropertyInfo(propertyInfo, filterTargetPropertyMetadata);
		MapAttribute attribute = AttributeHelper<MapAttribute>.GetAttribute(propertyInfo, inherited: true);
		if (attribute != null)
		{
			RegistrationCardProperty = new PropertyDescription
			{
				PropertyUid = attribute.PropertyUid,
				ClassUid = attribute.ClassTypeUid
			};
		}
	}
}
