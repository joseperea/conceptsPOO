using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conceptsPOO
{
    public class Date
    {

        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(year, month, day);
        }

        private int CheckDay(int year, int month, int day)
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }

            throw new DayException($"invalid Day: {day}");

        }

        private bool IsLeapYear(int year)
        {

            return year % 400 == 00 || year % 4 == 0 && year % 100 != 0;
        }

        private int CheckMonth(int month)
        {
            if (month > 0 && month <= 12)
            {
                return month;
            }
            throw new MonthException($"invalid Month: {month}");
        }

        public override string ToString()
        {
            return $"{_year:0000}/{_month:00}/{_day:00}";
        }

    }
}
