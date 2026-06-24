using System;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Content.Models
{
    public partial class PortalObjectPermission
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
                if (this.OrganizationItemEmployee != null)
                    return OrganizationItemEmployee;
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
                        OrganizationItemEmployee = organizationItem;
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
            get { return PortalObject; }
            set { PortalObject = (PortalObject)value; }
        }
    }
}