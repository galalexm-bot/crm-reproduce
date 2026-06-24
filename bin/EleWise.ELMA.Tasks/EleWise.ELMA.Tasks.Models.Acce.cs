using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks.Managers;

namespace EleWise.ELMA.Tasks.Models
{
    /// <summary>
    /// Задача выдачи прав
    /// </summary>
    /// <remarks>
    /// Задача согласования выдачи прав доступа
    /// </remarks>
    public partial class AccessRequestTask
    {
        /// <summary>
        /// Список запрашиваемых привилегий
        /// </summary>
        public virtual IEnumerable<Permission> AccessRequestPermissions
        {
            get
            {
                return AccessRequestTaskManager.Instance.GetAccessRequestPermissions(this);
            }
        }
    }
}