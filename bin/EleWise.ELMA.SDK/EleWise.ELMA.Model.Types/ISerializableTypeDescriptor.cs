using System;
using System.Collections.Generic;
using EleWise.ELMA.Common;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Model.Types;

public interface ISerializableTypeDescriptor
{
	TypeSerializationDescriptor GetSerializeDescriptor(ClassMetadata metadata, PropertyMetadata propertyMetadata);

	TypeSerializationDescriptor GetSerializeDescriptor(Guid subTypeUid);

	TypeSerializationDescriptor GetSettingsSerializeDescriptor();

	IDictionary<string, object> Serialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata);

	IDictionary<string, object> Serialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, EntitySerializationSettings settings);

	void Deserialize(object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata, IDictionary<string, object> values);

	object SerializeSimple(object value, [NotNull] Type valueType);

	object SerializeSimple(object value, [NotNull] Type valueType, EntitySerializationSettings settings);

	object DeserializeSimple(object value, [NotNull] Type deserializeToType);
}
