using System;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA;
using EleWise.ELMA.Security.Managers;

namespace EleWise.ELMA.Security.Models
{
    public partial class User
    {
        public virtual TimeZoneModel TimeZone
        {
            get
            {
                return string.IsNullOrEmpty(TimeZoneData) ? TZ.ServerTimeZone : TZ.Deserialize(TimeZoneData);
            }
        }

        [Obsolete("Использовать UserSecurityProfile.Password", false)]
        public virtual string Password
        {
            get
            {
                return UserSecurityProfileManager.Instance.Load(this).Password;
            }
            set
            {
                UserSecurityProfileManager.Instance.PasswordReset(this, value);
            }
        }
    }
}