// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Components.ContactCommentHistoryPartProvider
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Entities;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Components
{
    [Component]
    public class ContactCommentHistoryPartProvider : CommentHistoryPartProviderBase
    {
        protected override bool CheckEntity(HtmlHelper html, IEntity entity)
        {
            return entity is IContact;
        }

        protected override bool CheckEventActionObject(HtmlHelper html, ICommentedHistoryModel eventData)
        {
            return eventData is IContactHistoryBaseModel;
        }
    }
}
