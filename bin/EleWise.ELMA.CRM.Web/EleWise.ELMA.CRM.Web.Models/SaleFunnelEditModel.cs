using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.CRM.Web.Models;

public class SaleFunnelEditModel
{
	public ISaleFunnel Entity { get; set; }

	public string JsonData { get; set; }

	public SaleFunnelEditModel()
	{
	}

	public SaleFunnelEditModel(ISaleFunnel funnel)
	{
		Entity = funnel;
		JsonData = Serialize((ICollection<ISaleStage>)funnel.SaleStages);
	}

	public static string Serialize(ICollection<ISaleStage> saleStages)
	{
		EntityJsonSerializer @object = new EntityJsonSerializer();
		return new JsonSerializer().Serialize(saleStages.Select(@object.ConvertToSerializable).ToArray());
	}

	public static List<ISaleStage> Deserialize(string saleStages, bool loadEntityIfExists = true)
	{
		ExpandoObject[] source = new JsonSerializer().Deserialize<ExpandoObject[]>(saleStages);
		EntityJsonSerializer serializer = new EntityJsonSerializer();
		return source.Select((ExpandoObject s) => (ISaleStage)serializer.ConvertFromSerializable(s, InterfaceActivator.TypeOf<ISaleStage>(), loadEntityIfExists)).ToList();
	}
}
