using System.Collections.Generic;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.KPI.Interfaces;

[DeveloperApi(DeveloperApiType.Service)]
public interface IProjectionScaleService
{
	IProjectionScale AddInterval(IProjectionScale projectionScale, IProjectionScaleItem interval);

	IProjectionScale DefineIntervals(IProjectionScale projectionScale, IEnumerable<IProjectionScaleItem> intervals);

	double GetOutputValue(IProjectionScale projectionScale, double input);

	IProjectionScaleItem GetOutputItem(IProjectionScale projectionScale, double input);

	string SerializeItems(ICollection<IProjectionScaleItem> projectionScaleItems);

	IEnumerable<IProjectionScaleItem> DeserializeItems(string items, bool loadEntityIfExists = false);

	string SerializeForm(IProjectionScale scale);

	IProjectionScale DeserializeForm(string json, bool loadEntityIfExists = false);

	ICollection<IProjectionScaleItem> SortItems(ICollection<IProjectionScaleItem> projectionScaleItems);
}
