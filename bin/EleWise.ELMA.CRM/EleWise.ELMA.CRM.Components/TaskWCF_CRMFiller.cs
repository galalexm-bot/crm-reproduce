using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Tasks.API.Models;
using EleWise.ELMA.Tasks.ExtensionPoints.API;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.CRM.Components;

[Component]
public class TaskWCF_CRMFiller : ITaskWCFFiller
{
	public void FillTaskWCF(ITask task, TaskWCF taskWCF)
	{
		if (task is ICRMTaskBase iCRMTaskBase && (iCRMTaskBase.Contractor != null || iCRMTaskBase.Contact != null || iCRMTaskBase.Lead != null || iCRMTaskBase.Sale != null))
		{
			if (taskWCF.AdditionalFields == null)
			{
				taskWCF.AdditionalFields = new WebData();
			}
			List<WebDataItem> list = ((taskWCF.AdditionalFields.Items != null) ? taskWCF.AdditionalFields.Items.ToList() : new List<WebDataItem>());
			if (iCRMTaskBase.Contractor != null)
			{
				list.Add(new WebDataItem
				{
					Name = "Contractor",
					Data = new WebData
					{
						Items = new WebDataItem[3]
						{
							new WebDataItem
							{
								Name = "TypeUid",
								Value = iCRMTaskBase.Contractor.TypeUid.ToString()
							},
							new WebDataItem
							{
								Name = "Id",
								Value = iCRMTaskBase.Contractor.Id.ToString()
							},
							new WebDataItem
							{
								Name = "Name",
								Value = iCRMTaskBase.Contractor.Name
							}
						}
					}
				});
			}
			if (iCRMTaskBase.Contact != null)
			{
				list.Add(new WebDataItem
				{
					Name = "Contact",
					Data = new WebData
					{
						Items = new WebDataItem[2]
						{
							new WebDataItem
							{
								Name = "Id",
								Value = iCRMTaskBase.Contact.Id.ToString()
							},
							new WebDataItem
							{
								Name = "Name",
								Value = iCRMTaskBase.Contact.Name
							}
						}
					}
				});
			}
			if (iCRMTaskBase.Lead != null)
			{
				list.Add(new WebDataItem
				{
					Name = "Lead",
					Data = new WebData
					{
						Items = new WebDataItem[2]
						{
							new WebDataItem
							{
								Name = "Id",
								Value = iCRMTaskBase.Lead.Id.ToString()
							},
							new WebDataItem
							{
								Name = "Name",
								Value = iCRMTaskBase.Lead.Name
							}
						}
					}
				});
			}
			if (iCRMTaskBase.Sale != null)
			{
				list.Add(new WebDataItem
				{
					Name = "Sale",
					Data = new WebData
					{
						Items = new WebDataItem[2]
						{
							new WebDataItem
							{
								Name = "Id",
								Value = iCRMTaskBase.Sale.Id.ToString()
							},
							new WebDataItem
							{
								Name = "Name",
								Value = iCRMTaskBase.Sale.Name
							}
						}
					}
				});
			}
			taskWCF.AdditionalFields.Items = list.ToArray();
		}
	}
}
