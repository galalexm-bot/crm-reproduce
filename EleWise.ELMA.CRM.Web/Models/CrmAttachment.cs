// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CRM.Web.Models.CrmAttachment
// Assembly: EleWise.ELMA.CRM.Web, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F0C16743-1D89-40E8-934E-B30ADB346902
// Assembly location: D:\ELMA-CE\Web\Modules\EleWise.ELMA.CRM.Web\bin\EleWise.ELMA.CRM.Web.dll

using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Models.Forms;
using System;

namespace EleWise.ELMA.CRM.Web.Models
{
  public class CrmAttachment : FormViewModel
  {
    public string PopupId { get; set; }

    public bool UseJson { get; set; }

    public long EntityId { get; set; }

    public Guid EntityTypeUid { get; set; }

    public ICrmAttachmentActionModel ActionModel { get; set; }

    public CrmAttachment()
    {
      this.PostAction = "AddAttachment";
      this.PostController = "Attachment";
      this.PostArea = "EleWise.ELMA.CRM.Web";
      this.ActionModel = InterfaceActivator.Create<ICrmAttachmentActionModel>();
    }
  }
}
