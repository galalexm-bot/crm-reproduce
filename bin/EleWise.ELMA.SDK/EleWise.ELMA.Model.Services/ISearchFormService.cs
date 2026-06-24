using EleWise.ELMA.Model.Services.Models;

namespace EleWise.ELMA.Model.Services;

public interface ISearchFormService
{
	EntityFormView GetEntityForm(SearchForm searchForm);

	EntityFormView ProcessEntityForm(EntityForm entityForm);
}
