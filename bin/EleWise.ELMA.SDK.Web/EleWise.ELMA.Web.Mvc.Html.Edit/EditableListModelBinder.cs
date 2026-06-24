using System.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Web.Mvc.Html.EditableList;

public class EditableListModelBinder : IModelBinder
{
	public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
	{
		EditableListModel editableListModel = (EditableListModel)bindingContext.get_Model();
		if (editableListModel == null)
		{
			editableListModel = new EditableListModel();
		}
		editableListModel.Name = bindingContext.get_ModelName();
		ValueProviderResult value = bindingContext.get_ValueProvider().GetValue(bindingContext.get_ModelName() + "_value");
		if (value == null || string.IsNullOrEmpty(value.get_AttemptedValue()))
		{
			return new EditableListModel();
		}
		EditableListItem[] array = (EditableListItem[])(editableListModel.Items = value.get_AttemptedValue().FromJson<EditableListItem[]>());
		return editableListModel;
	}
}
