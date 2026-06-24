using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Tasks.Models;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
    [Component]
    internal class SaleQuestionsHistoryPartProvider : QuestionHistoryPartProviderBase
    {
        protected override bool CheckEntity(HtmlHelper html, IEntity entity)
        {
            return entity is ISale;
        }

        protected override bool CheckEventActionObject(HtmlHelper html, IQuestionedHistoryModel eventData)
        {
            return eventData is ISaleHistoryBaseModel;
        }
    }
}
