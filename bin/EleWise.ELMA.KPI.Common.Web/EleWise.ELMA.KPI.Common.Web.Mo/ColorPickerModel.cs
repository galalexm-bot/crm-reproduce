namespace EleWise.ELMA.KPI.Common.Web.Models;

public class ColorPickerModel
{
	public string Id { get; private set; }

	public string CallbackOnSelect { get; set; }

	public string SelectedColor { get; set; }

	public ColorPickerModel(string id)
	{
		Id = id;
	}
}
