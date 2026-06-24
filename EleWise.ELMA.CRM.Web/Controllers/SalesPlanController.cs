using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models.SalesPlan;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Controllers;
using EleWise.ELMA.Web.Mvc.Menu;
using EleWise.ELMA.Web.Mvc.Security;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers
{
    [Permission("{46401803-1B46-4E60-8DA0-227FF8CF60F3}")]
    public class SalesPlanController : BPMController<IPayment, long>
    {
        private int GetCalendarModeState(int mode)
        {
            string str = "SalesPlanCalendarMode";
            int calendarModeState;
            if (mode == 0)
            {
                MenuState menuState = StateExtensions.LoadState<MenuState>(str);
                calendarModeState = menuState != null ? menuState.Width : 1;
            }
            else
            {
                StateExtensions.SaveState<MenuState>(str, new MenuState()
                {
                    Width = mode
                });
                calendarModeState = mode;
            }
            return calendarModeState;
        }

        private DateTime GetCalendarStartDate(DateTime? startDate)
        {
            string str = "SalesPlanCalendarStartDate";
            DateTime calendarStartDate;
            if (!startDate.HasValue)
            {
                MenuState menuState = StateExtensions.LoadState<MenuState>(str);
                calendarStartDate = menuState != null ? DateTime.Parse(menuState.Id) : DateTime.Today;
            }
            else
            {
                StateExtensions.SaveState<MenuState>(str, new MenuState()
                {
                    Id = startDate.Value.ToString()
                });
                calendarStartDate = startDate.Value;
            }
            return calendarStartDate;
        }

        public ActionResult Index(int mode = 0)
        {
            mode = this.GetCalendarModeState(mode);
            DateTime calendarStartDate = this.GetCalendarStartDate(new DateTime?());
            List<IPayment> actualPayments = PaymentManager.Instance.GetActualPayments(calendarStartDate, calendarStartDate.AddMonths(mode));
            List<ISale> sales = SaleManager.Instance.GetSales(base.AuthenticationService.GetCurrentUser<IUser>());
            return View((object)new CalendarModel(mode, calendarStartDate, sales, actualPayments));
        }

        public ActionResult SalesPlan(int mode = 0)
        {
            mode = this.GetCalendarModeState(mode);
            DateTime calendarStartDate = this.GetCalendarStartDate(new DateTime?());
            List<IPayment> actualPayments = PaymentManager.Instance.GetActualPayments(calendarStartDate, calendarStartDate.AddMonths(mode));
            List<ISale> sales = SaleManager.Instance.GetSales(base.AuthenticationService.GetCurrentUser<IUser>());
            return PartialView((object)new CalendarModel(mode, calendarStartDate, sales, actualPayments));
        }

        public ActionResult Calendar(int mode = 0)
        {
            mode = this.GetCalendarModeState(mode);
            DateTime calendarStartDate = this.GetCalendarStartDate(new DateTime?());
            List<IPayment> actualPayments = PaymentManager.Instance.GetActualPayments(calendarStartDate, calendarStartDate.AddMonths(mode));
            List<ISale> sales = SaleManager.Instance.GetSales(base.AuthenticationService.GetCurrentUser<IUser>());
            return PartialView((object)new CalendarModel(mode, calendarStartDate, sales, actualPayments));
        }

        public ActionResult CalendarToday()
        {
            int calendarModeState = this.GetCalendarModeState(0);
            DateTime calendarStartDate = this.GetCalendarStartDate(new DateTime?(DateTime.Today));
            List<IPayment> actualPayments = PaymentManager.Instance.GetActualPayments(calendarStartDate, calendarStartDate.AddMonths(calendarModeState));
            List<ISale> sales = SaleManager.Instance.GetSales(base.AuthenticationService.GetCurrentUser<IUser>());
            return PartialView("Calendar", (object)new CalendarModel(calendarModeState, calendarStartDate, sales, actualPayments));
        }

        public ActionResult CalendarPrev(DateTime startDate)
        {
            int calendarModeState = this.GetCalendarModeState(0);
            DateTime calendarStartDate = this.GetCalendarStartDate(new DateTime?(startDate.AddMonths(-1 * calendarModeState)));
            PaymentManager.Instance.GetActualPayments(startDate, startDate.AddMonths(calendarModeState));
            SaleManager.Instance.GetSales(base.AuthenticationService.GetCurrentUser<IUser>());
            return PartialView("Calendar", (object)new CalendarModel(calendarModeState, calendarStartDate));
        }

        public ActionResult CalendarNext(DateTime startDate)
        {
            int calendarModeState = this.GetCalendarModeState(0);
            DateTime calendarStartDate = this.GetCalendarStartDate(new DateTime?(startDate.AddMonths(calendarModeState)));
            PaymentManager.Instance.GetActualPayments(startDate, startDate.AddMonths(calendarModeState));
            SaleManager.Instance.GetSales(base.AuthenticationService.GetCurrentUser<IUser>());
            return PartialView("Calendar", (object)new CalendarModel(calendarModeState, calendarStartDate));
        }

        public ActionResult WeekDays(DateTime startDate)
        {
            CultureInfo currentCulture = CultureInfo.CurrentCulture;
            DateTime dateTime;
            if (currentCulture.Calendar.GetDayOfWeek(startDate) == DayOfWeek.Monday)
            {
                dateTime = startDate;
            }
            else
            {
                int num = (currentCulture.Calendar.GetDayOfWeek(startDate) != DayOfWeek.Sunday ? (int)currentCulture.Calendar.GetDayOfWeek(startDate) : 7) - 1;
                dateTime = startDate.AddDays((double)(-1 * num));
            }
            return PartialView("Days", (object)new Tuple<int, DateTime>(7, dateTime));
        }

        public ActionResult Move(long id, string date, int dayNum)
        {
            PaymentManager instance = PaymentManager.Instance;
            IPayment payment = instance.Load(id);
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            DateTime newDate = DateTime.ParseExact(date, "yyyyMMdd", (IFormatProvider)invariantCulture);
            if (dayNum > 1)
                newDate = newDate.AddDays((double)(dayNum - 1));
            instance.ChangeDate(payment, newDate);
            return (ActionResult)null;
        }

        public ActionResult ChangeStatus(long id, int status)
        {
            PaymentManager instance = PaymentManager.Instance;
            instance.ChangeStatus(instance.Load(id), (PaymentStatus)status);
            return (ActionResult)null;
        }

        public ActionResult ChangeSum(long id, long sum)
        {
            PaymentManager instance = PaymentManager.Instance;
            instance.ChangeSum(instance.Load(id), sum);
            return (ActionResult)null;
        }

        public ActionResult CreatePayment(long id, string date, int dayNum, string name, long sum)
        {
            CultureInfo invariantCulture = CultureInfo.InvariantCulture;
            DateTime dateTime = DateTime.ParseExact(date, "yyyyMMdd", (IFormatProvider)invariantCulture);
            if (dayNum > 1)
                dateTime = dateTime.AddDays((double)(dayNum - 1));
            IPayment payment = PaymentManager.Instance.Create();
            payment.Name = name;
            payment.Sum = sum;
            payment.Sale = SaleManager.Instance.Load(id);
            payment.PaymentStatus = PaymentStatus.Planned;
            payment.PaymentDate = dateTime;
            payment.Save();
            return (ActionResult)null;
        }
    }
}
