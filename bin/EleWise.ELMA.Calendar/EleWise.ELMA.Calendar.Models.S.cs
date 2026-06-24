using System;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Calendar.Models
{
    public partial class SchedulePermission
    {
        // TODO использовать кодогенерацию !
        public virtual IEntity Assigned
        {
            get
            {
                if (User != null)
                    return User;
                if (Group != null)
                    return Group;
                if (this.OrganizationItem != null)
                    return OrganizationItem;
                if (OrganizationItemPosition != null)
                    return OrganizationItemPosition;
                return null;
            }
            set
            {
                if (value == null)
                    return;
                if (value is User)
                    User = (User)value;
                else if (value is UserGroup)
                    Group = (UserGroup)value;
                else if (value is OrganizationItem)
                {
                    var organizationItem = (OrganizationItem)value;
                    if (organizationItem.ItemType == OrganizationItemType.Position)
                        OrganizationItemPosition = organizationItem;
                    else
                        OrganizationItem = organizationItem;
                }
                else
                    throw new ArgumentException(value.ToString());

            }
        }
        
        public virtual Guid TypeRoleId
        {
            get { return PermissionRole.Value; }
            set { PermissionRole = value; }
        }

        public virtual object Target
        {
            get { return Schedule; }
            set { Schedule = (Schedule)value; }
        }
    }
}