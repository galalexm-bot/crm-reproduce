using System;

namespace EleWise.ELMA.Tasks.Models
{
    public partial class WorkLogItem
    {

        public virtual string Name
        {
            get
            {
                 try
                 {
                     if (EleWise.ELMA.Tasks.Components.WorkLogExtensionHelper.FindExtensionByObjectUid(ObjectUID) != null)
                      {
                           var entity = EleWise.ELMA.Tasks.Components.WorkLogExtensionHelper.LoadObject(ObjectId, ObjectUID);
                           if (entity != null)
                               return entity.ToString();
                           }
                      }
                     catch (Exception)
                     {
                     }
                     return null;
             }
        }

        public virtual System.Nullable<EleWise.ELMA.Common.Models.WorkTime> PlanWorkTime
        {
            get
            {
                  return EleWise.ELMA.Tasks.Components.WorkLogHelper.PlanWorkLog(ObjectUID, ObjectId);
            }
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
