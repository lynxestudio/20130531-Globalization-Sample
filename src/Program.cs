using System;
using System.Globalization;
using System.Threading;

Console.Clear();
try
{
    DateTime startDate, finishDate;
    TimeSpan workingTime;
    int workingDays, taxRate;
    Decimal salaryRate, netIncome, grossSalary, taxDeduction;
    CultureInfo ci = null;
    string[] menu = {"USA","Canada","UK","Brasil"};
    Utilities.ShowMenu("Globalization Example",menu);
    string option = Utilities.Scanf("Please select your country:");
    do
    {
    
        Thread.CurrentThread.CurrentCulture = ci;
        string sdate = Utilities.Scanf("Enter start date");
        string fdate = Utilities.Scanf("Enter finish date");
        string ssalary = Utilities.Scanf("Enter salary rate");
        string srate =  Utilities.Scanf("Enter tax rate %");
        startDate = Convert.ToDateTime(sdate);
        finishDate = Convert.ToDateTime(fdate);
        workingTime = finishDate - startDate;
        workingDays = workingTime.Days;
        salaryRate = Convert.ToDecimal(ssalary);
        taxRate = Convert.ToInt32(srate);
        grossSalary = workingDays * salaryRate;
        taxDeduction = grossSalary * Convert.ToDecimal(taxRate * .01);
        netIncome = grossSalary - taxDeduction;

    }
    while(option != "0");

    
}
catch(ApplicationException ex)
{
    Console.WriteLine(ex.Message);
}
Utilities.Pause();

