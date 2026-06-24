using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Scripts;

[ServiceContract]
public interface IFormService
{
	void ProcessForm(EntityFormView model);

	void UpdateForm(FormViewItem formViewItem, FormViewBuilderInfo builderInfo);
}
