using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using EleWise.ELMA.Common.Enums;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using Iesi.Collections.Generic;

namespace EleWise.ELMA.BPM.Web.Common.Models;

public class UnitMeasureModel : EntityModel<IUnitMeasure>
{
	public string JsonData { get; set; }

	public UnitMeasureModel()
	{
	}

	public UnitMeasureModel(IUnitMeasure unitMeasure)
	{
		if (unitMeasure == null)
		{
			unitMeasure = InterfaceActivator.Create<IUnitMeasure>();
			unitMeasure.Properties = InterfaceActivator.Create<IUnitMeasureProperties>();
			unitMeasure.WpiSelectList = (ISet<IWpiSelectListItem>)(object)new HashedSet<IWpiSelectListItem>();
			unitMeasure.Properties.Position = UnitMeasurePosition.Right;
			unitMeasure.Properties.DoublePrecision = 2;
			unitMeasure.Properties.DoubleSeparator = ",";
			unitMeasure.Properties.GroupMemberLenght = 3;
			unitMeasure.Properties.GroupSeparator = " ";
			unitMeasure.Properties.NegativeFormat = NegativeFormat.LeftMinus;
		}
		if (unitMeasure.Properties == null)
		{
			unitMeasure.Properties = InterfaceActivator.Create<IUnitMeasureProperties>();
			unitMeasure.Properties.Position = UnitMeasurePosition.Right;
			unitMeasure.Properties.DoublePrecision = 2;
			unitMeasure.Properties.DoubleSeparator = ",";
			unitMeasure.Properties.GroupMemberLenght = 3;
			unitMeasure.Properties.GroupSeparator = " ";
			unitMeasure.Properties.NegativeFormat = NegativeFormat.LeftMinus;
		}
		base.Entity = unitMeasure;
		JsonData = Serialize((ICollection<IWpiSelectListItem>)unitMeasure.WpiSelectList);
	}

	public static string Serialize(ICollection<IWpiSelectListItem> wpiSelectListItems)
	{
		EntityJsonSerializer serializer = new EntityJsonSerializer();
		EntitySerializationSettings settings = new EntitySerializationSettings
		{
			Mode = EntitySerializationMode.Compact
		};
		return new JsonSerializer().Serialize(wpiSelectListItems.Select((IWpiSelectListItem um) => serializer.ConvertToSerializable(um, settings)).ToArray());
	}

	public static List<IWpiSelectListItem> Deserialize(string wpiSelectListItems, bool loadEntityIfExists = true)
	{
		ExpandoObject[] source = new JsonSerializer().Deserialize<ExpandoObject[]>(wpiSelectListItems);
		EntityJsonSerializer serializer = new EntityJsonSerializer();
		return source.Select((ExpandoObject s) => (IWpiSelectListItem)serializer.ConvertFromSerializable(s, InterfaceActivator.TypeOf<IWpiSelectListItem>(), loadEntityIfExists)).ToList();
	}
}
