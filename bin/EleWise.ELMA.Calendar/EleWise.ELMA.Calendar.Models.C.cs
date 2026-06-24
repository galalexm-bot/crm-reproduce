namespace EleWise.ELMA.Calendar.Models
{
    using System;
    using System.Linq;
    using EleWise.ELMA.Extensions;
    using Iesi.Collections.Generic;

    partial class CalendarEventPeriodical
    {
        EleWise.ELMA.Security.Models.IUser EleWise.ELMA.Common.Models.IPeriodicalEntity.CreationAuthor
        {
            get { return CreationAuthor; }
            set { CreationAuthor = (EleWise.ELMA.Security.Models.User)value; }
        }

        int EleWise.ELMA.Common.Models.IPeriodicalEntity.ForwardCreated
        {
            get { return (int)ForwardCreated; }
            set { ForwardCreated = (long)value; }
        }
    }
}