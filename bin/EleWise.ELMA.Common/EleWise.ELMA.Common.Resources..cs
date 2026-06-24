using System;
using System.Collections.Generic;

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Security;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Security.Models;

namespace {NamespacePath}
{

    /// <inheritdoc />
    public partial class {ClassName} : IEntityPermissionExtension
    {

        /// <inheritdoc />
        public virtual IEntity Assigned
        {
            get
            {
                if (User != null)
                {
                    return User;
                }
                if (Group != null)
                {
                    return Group;
                }
                if (OrganizationItem != null)
                {
                    return OrganizationItem;
                }
                if (OrganizationItemPosition != null)
                {
                    return OrganizationItemPosition;
                }
                return null;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                if (value is User)
                {
                    User = (User)value;
                }
                else if (value is UserGroup)
                {
                    Group = (UserGroup)value;
                }
                else if (value is OrganizationItem)
                {
                    var organizationItem = (OrganizationItem)value;
                    if (organizationItem.ItemType == OrganizationItemType.Position)
                    {
                        OrganizationItemPosition = organizationItem;
                    }
                    else
                    {
                        OrganizationItem = organizationItem;
                    }
                }
                else
                {
                    throw new ArgumentException(value.ToString());
                }

            }
        }

        /// <inheritdoc />
        public virtual Guid TypeRoleId
        {
            get
            {
                return PermissionRole.Value;
            }
            set
            {
                PermissionRole = value;
            }
        }

        /// <inheritdoc />
        public virtual object Target
        {
            get
            {
                return Parent;
            }
            set
            {
                Parent = ({ParentClassName})value;
            }
        }

        /// <inheritdoc />
        public virtual IEntity Instance
        {
            get
            {
                return Parent;
            }
            set
            {
                Parent = ({ParentClassName})value;
            }
        }

    }
}