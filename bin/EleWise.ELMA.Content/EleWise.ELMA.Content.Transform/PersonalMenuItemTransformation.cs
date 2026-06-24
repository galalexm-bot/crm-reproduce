using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Transformations.Struct;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Content.Transformation;

public class PersonalMenuItemTransformationSerializer : JsonSerializer
{
	private class PersonalMenuItemTransformationConverter : JavaScriptConverter
	{
		public override IEnumerable<Type> SupportedTypes => new Type[1] { typeof(PersonalMenuItemTransformation) };

		public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
		{
			PersonalMenuItemTransformation personalMenuItemTransformation = (PersonalMenuItemTransformation)Activator.CreateInstance(type);
			if (dictionary.TryGetValue("Uid", out var value))
			{
				personalMenuItemTransformation.Uid = new Guid(value.ToString());
			}
			if (dictionary.TryGetValue("Items", out var value2) && value2 is IList)
			{
				foreach (object item5 in value2 as IList)
				{
					if (item5 is PersonalMenuItemTransformationAdd item)
					{
						personalMenuItemTransformation.Items.Add(item);
					}
					if (item5 is PersonalMenuItemTransformationMove item2)
					{
						personalMenuItemTransformation.Items.Add(item2);
					}
					if (item5 is PersonalMenuItemTransformationHide item3)
					{
						personalMenuItemTransformation.Items.Add(item3);
					}
					if (item5 is PersonalMenuItemTransformationChange item4)
					{
						personalMenuItemTransformation.Items.Add(item4);
					}
				}
				return personalMenuItemTransformation;
			}
			return personalMenuItemTransformation;
		}

		public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
		{
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			if (obj is PersonalMenuItemTransformation personalMenuItemTransformation)
			{
				if (personalMenuItemTransformation.Uid != Guid.Empty)
				{
					dictionary["Uid"] = personalMenuItemTransformation.Uid.ToString();
				}
				if (personalMenuItemTransformation.Items.Any())
				{
					dictionary["Items"] = personalMenuItemTransformation.Items;
				}
			}
			return dictionary;
		}
	}

	private class MenuItemConverter : JavaScriptConverter
	{
		public ILogger Logger { get; set; }

		public override IEnumerable<Type> SupportedTypes => new Type[2]
		{
			typeof(IMenuItem),
			InterfaceActivator.TypeOf<IMenuItem>()
		};

		public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
		{
			return new EntityJsonSerializer().ConvertFromSerializable<IMenuItem>(dictionary);
		}

		public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
		{
			if (obj is IMenuItem obj2)
			{
				return new EntityJsonSerializer().ConvertToSerializable(obj2).ToDictionary();
			}
			return new Dictionary<string, object>();
		}
	}

	public PersonalMenuItemTransformationSerializer()
		: base(new SimpleTypeResolver())
	{
		RegisterConverters(new JavaScriptConverter[2]
		{
			new PersonalMenuItemTransformationConverter(),
			new MenuItemConverter()
		});
	}
}
[Serializable]
public class PersonalMenuItemTransformationAdd : TransformationAdd<IMenuItem, PersonalMenuItemTransformation, Guid>
{
}
[Serializable]
public class PersonalMenuItemTransformationMove : TransformationMove<IMenuItem, PersonalMenuItemTransformation, Guid>
{
}
[Serializable]
public class PersonalMenuItemTransformationHide : TransformationHide<IMenuItem, PersonalMenuItemTransformation, Guid>
{
}
[Serializable]
public class PersonalMenuItemTransformationChange : TransformationChange<IMenuItem, PersonalMenuItemTransformation, Guid>
{
}
[Serializable]
public class PersonalMenuItemTransformation : MenuItemTransformationBase<PersonalMenuItemTransformation, PersonalMenuItemTransformationAdd, PersonalMenuItemTransformationMove, PersonalMenuItemTransformationHide, PersonalMenuItemTransformationChange>
{
}
