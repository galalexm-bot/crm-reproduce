using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
    [Component]
    public class SaleCommentHistoryPartProvider : CommentHistoryPartProviderBase
    {
        protected override bool CheckEntity(HtmlHelper html, IEntity entity)
        {
            return entity is ISale;
        }
        protected override bool CheckEventActionObject(HtmlHelper html, ICommentedHistoryModel eventData)
        {
            return eventData is ISaleHistoryBaseModel;
        }
    }
}
