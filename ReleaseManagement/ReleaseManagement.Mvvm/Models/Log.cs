using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics.Eventing;
using Microsoft.Win32;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HelloWorld.App_Code
{
    public enum STATE { 
        INITIALIZED,
        COMPLETED,
        INTERRUPTED
    }

    public enum ExceptionType { 
        SQLException,
        NullPointerException,
        Exception
    }

    public class Log
    {
        public string DetailLogPath = "Logs\\DetailLogs\\";
        public string ErrorLogPath = System.Environment.CurrentDirectory+"\\Logs\\ErrorLogs\\";
        public void DetailLog(string className, string methodName, STATE state, string text)
        {
            //Debug.WriteLine("Log Location: " + System.Environment.CurrentDirectory);
            System.IO.File.AppendAllText(DetailLogPath + DateTime.Now.Year.ToString() + "-" +
                DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "_" + 
                DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString() + ".txt",
                DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + 
                DateTime.Now.Day.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + 
                DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString() + ":" +
                DateTime.Now.Millisecond.ToString() + " | Class: "+className+" | Method: "+methodName+"" + " | State:  " + state + " | Domain: " + System.Environment.UserDomainName + " | Machine Name: " + System.Environment.MachineName + " | Username: " + System.Environment.UserName + " | OS Version: " + System.Environment.OSVersion + "| O.S 64-Bit: " + System.Environment.Is64BitOperatingSystem + " | Physical Memory: " + System.Environment.WorkingSet + " | Directory Location: " + System.Environment.CurrentDirectory + " | System Started Tick: " + System.Environment.TickCount + " | Description: " + text + ". \n" + System.Environment.NewLine);
        }

        public void ErrorLog(string className, string methodName, ExceptionType ExType, Exception ex)
        {

            System.IO.File.AppendAllText( ErrorLogPath + 
                DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + 
                DateTime.Now.Day.ToString() + "_" + DateTime.Now.Hour.ToString() + "-" + 
                DateTime.Now.Minute.ToString() + ".txt", DateTime.Now.Year.ToString() + "/" + 
                DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + " " + 
                DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + 
                DateTime.Now.Second.ToString() + ":" + DateTime.Now.Millisecond.ToString() +
                " | Class: " + className + " | Method: " + methodName + "" + " | State: Interrupted" + " | Domain: " + System.Environment.UserDomainName + " | Machine Name: " + System.Environment.MachineName + " | Username: " + System.Environment.UserName + " | OS Version: " + System.Environment.OSVersion + "| O.S 64-Bit: " + System.Environment.Is64BitOperatingSystem + " | Physical Memory: " + System.Environment.WorkingSet + " | Directory Location: " + System.Environment.CurrentDirectory + " | System Started Tick: " + System.Environment.TickCount + " | " + ExType + ": " + ex.Source + "\nException Description: " + ex.Message + ". \n" + System.Environment.NewLine);
            
        }
    }
}