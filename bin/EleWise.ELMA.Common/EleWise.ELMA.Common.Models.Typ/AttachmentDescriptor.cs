using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Models.Types;

public class AttachmentDescriptor : EntitySubTypeDescriptor<IAttachment>
{
	private static readonly Guid AttachmentEntityUid = new Guid("3536c931-154c-4618-93b8-4e35bd8db226");

	protected static string FilePropertyName = LinqUtils.NameOf((Expression<Func<IAttachment, object>>)((IAttachment a) => a.File));

	protected static string CreationAuthorPropertyName = LinqUtils.NameOf((Expression<Func<IAttachment, object>>)((IAttachment a) => a.CreationAuthor));

	protected static string CreationDatePropertyName = LinqUtils.NameOf((Expression<Func<IAttachment, object>>)((IAttachment a) => a.CreationDate));

	protected override Guid EntityUid => AttachmentEntityUid;

	public BinaryFileDescriptor BinaryFileDescriptor { get; set; }

	public DateTimeDescriptor DateTimeDescriptor { get; set; }

	public EntityDescriptor EntityDescriptor { get; set; }

	public override TypeSerializationDescriptor GetSerializeDescriptor(ClassMetadata metadata, PropertyMetadata propertyMetadata)
	{
		TypeSerializationDescriptor serializeDescriptor = base.GetSerializeDescriptor(metadata, propertyMetadata);
		EntitySettings obj = (EntitySettings)propertyMetadata.Settings;
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeof(IAttachment));
		PropertyMetadata propertyMetadata2 = classMetadata.Properties.First((PropertyMetadata p) => p.Uid == Guid.Parse("53c0cf38-a6a8-46a4-a141-6c7c698508ed"));
		TypeSerializationDescriptor serializeDescriptor2 = BinaryFileDescriptor.GetSerializeDescriptor(classMetadata, propertyMetadata2);
		if (obj.RelationType == RelationType.OneToOne)
		{
			TypeSerializationItemDescriptor typeSerializationItemDescriptor = serializeDescriptor.Items.First();
			{
				foreach (TypeSerializationItemDescriptor item in serializeDescriptor2.Items)
				{
					new TypeSerializationDescriptorBuilder(typeSerializationItemDescriptor.Descriptor).Item(item);
				}
				return serializeDescriptor;
			}
		}
		TypeSerializationItemDescriptor typeSerializationItemDescriptor2 = serializeDescriptor.Items.First().Descriptor.Items.First();
		foreach (TypeSerializationItemDescriptor item2 in serializeDescriptor2.Items)
		{
			new TypeSerializationDescriptorBuilder(typeSerializationItemDescriptor2.Descriptor).Item(item2);
		}
		return serializeDescriptor;
	}

	public override object SerializeSimple(object value, Type valueType, EntitySerializationSettings settings)
	{
		if (valueType == null)
		{
			throw new ArgumentNullException("valueType");
		}
		if (typeof(IAttachment).IsAssignableFrom(valueType))
		{
			IDictionary<string, object> dictionary = base.SerializeSimple(value, valueType, settings) as IDictionary<string, object>;
			if (value != null)
			{
				if (value is IAttachment attachment && dictionary != null)
				{
					if (!dictionary.ContainsKey(FilePropertyName))
					{
						BinaryFile file = attachment.File;
						object value2 = BinaryFileDescriptor.SerializeSimple(file);
						dictionary.Add(FilePropertyName, value2);
					}
					if (!dictionary.ContainsKey(CreationAuthorPropertyName) && attachment.CreationAuthor != null)
					{
						object value3 = EntityDescriptor.SerializeSimple(attachment.CreationAuthor);
						dictionary.Add(CreationAuthorPropertyName, value3);
					}
					if (!dictionary.ContainsKey(CreationDatePropertyName) && attachment.CreationDate.HasValue)
					{
						object value4 = DateTimeDescriptor.SerializeSimple(attachment.CreationDate.Value);
						dictionary.Add(CreationDatePropertyName, value4);
					}
				}
			}
			else
			{
				dictionary = new SerializableDictionary<string, object>
				{
					{
						EntityDescriptor.IdPropertyName,
						string.Empty
					},
					{
						"Name",
						string.Empty
					},
					{
						FilePropertyName,
						BinaryFileDescriptor.SerializeSimple(null)
					},
					{
						CreationAuthorPropertyName,
						EntityDescriptor.SerializeSimple(null)
					}
				};
			}
			return dictionary;
		}
		return base.SerializeSimple(value, valueType, settings);
	}

	public override object DeserializeSimple(object value, Type deserializeToType)
	{
		if (deserializeToType == null)
		{
			throw new ArgumentNullException("deserializeToType");
		}
		if (typeof(IAttachment).IsAssignableFrom(deserializeToType))
		{
			object obj = base.DeserializeSimple(value, deserializeToType);
			if (obj != null)
			{
				return obj;
			}
			if (!(value is IDictionary<string, object> dic))
			{
				return null;
			}
			return ConvertToEntity(dic);
		}
		return base.DeserializeSimple(value, deserializeToType);
	}

	private static IAttachment ConvertToEntity(IDictionary<string, object> dic)
	{
		IDictionary<string, object> value = dic[FilePropertyName] as IDictionary<string, object>;
		BinaryFile binaryFile = Locator.GetServiceNotNull<BinaryFileDescriptor>().DeserializeSimple(value);
		if (binaryFile != null)
		{
			IAttachment attachment = InterfaceActivator.Create<IAttachment>();
			attachment.CreationDate = DateTime.Now;
			attachment.File = binaryFile;
			return attachment;
		}
		return null;
	}
}
