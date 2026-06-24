using System;
using EleWise.ELMA.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Common.Models
{
    public partial class PropertyAccess
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
                if (AssignedPropertyUid != null && AssignedPropertyEntityUid != null)
                    return new PropertyMetadataReference(AssignedPropertyEntityUid, AssignedPropertyUid);
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
                else if (value is PropertyMetadataReference)
                {
                    var reference = value as PropertyMetadataReference;
                    AssignedPropertyUid = reference.PropertyMetadataGuid;
                    AssignedPropertyEntityUid = reference.MetadataGuid;
                }
                else
                    throw new ArgumentException(value.ToString());

            }
        }

        public virtual Guid TypeRoleId
        {
            get { return PermissionRole; }
            set { PermissionRole = value; }
        }

        public virtual object Target
        {
            get { return PropertyProfile; }
            set { PropertyProfile = (PropertyProfile)value; }
        }

        public virtual Guid GetPropertyGuid()
        {
            return PropertyProfile != null ? PropertyProfile.PropertyGuid : Guid.Empty;
        }

        public virtual PropertyPermissionType GetPermissionType()
        {
            if (PermissionId == PermissionProvider.PropertyHidePermission.Id)
                return PropertyPermissionType.Hide;
            if (PermissionId == PermissionProvider.PropertyViewPermission.Id)
                return PropertyPermissionType.Read;
            if (PermissionId == PermissionProvider.PropertyEditPermission.Id)
                return PropertyPermissionType.Edit;

            return PropertyPermissionType.None;
        }

    }
}