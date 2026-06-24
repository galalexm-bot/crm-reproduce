using System;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Common.Models
{
    public partial class CatalogAccess
    {
        public virtual IEntity Assigned
        {
            get
            {
                if (User != null)
                    return User;
                if (Group != null)
                    return Group;
                if (OrganizationItem != null)
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
            get { return CatalogProfile; }
            set { CatalogProfile = (CatalogProfile)value; }
        }
    }
}