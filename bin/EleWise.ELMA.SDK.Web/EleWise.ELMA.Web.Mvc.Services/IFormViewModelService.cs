using System;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.Web.Mvc.Services;

public interface IFormViewModelService
{
	EntityFormModel GetEntityFormModel(IEntity entity, Guid viewFormUid);
}
