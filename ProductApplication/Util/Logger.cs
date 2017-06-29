using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApplication.Util
{
    internal sealed class Logger
    {
        private static void LogMessage(string message, bool isException)
        {

            if (message == null)
            {
                message = string.Empty;
            }

            if (!EventLog.SourceExists("ProductApplication"))                                        
            {
                EventLog.CreateEventSource("ProductApplication", "ADONETLogs");                                            
                
            }

            EventLog myLog = new EventLog();
            myLog.Source = "ProductApplication";
            message = Environment.NewLine + DateTime.Now.ToString() +
                      Environment.NewLine +
                      message +
                      Environment.NewLine;

            if (isException)
            {
                myLog.WriteEntry(message, EventLogEntryType.Error);

            }
            else
            {
                myLog.WriteEntry(message, EventLogEntryType.Information);
            }

        }

        private static void LogMessage(string message)
        {
            LogMessage(message,false);
        }

        private static void LogSqlErrors(string message, SqlErrorCollection errors)
        {
            StringBuilder sb = new StringBuilder(); // da
            sb.Append(message);
            foreach (SqlError error in errors)
	        {
                sb.Append(Environment.NewLine);
                sb.Append(" Procedure");
                sb.Append(error.Procedure);

                sb.Append(Environment.NewLine);
                sb.Append(" Line Number");
                sb.Append(error.LineNumber);

                sb.Append(Environment.NewLine);
                sb.Append(" Severity Level");
                sb.Append(error.Class);

                sb.Append(Environment.NewLine);
                sb.Append(" Message");
                sb.Append(error.Message);

                sb.Append(Environment.NewLine);
                sb.Append(" Server");
                sb.Append(error.Server);

                sb.Append(Environment.NewLine);
                sb.Append(" State");
                sb.Append(error.State);
	        }

            LogMessage(sb.ToString());
        }

        public static void LogException(Exception ex)
        {
            try
            {
                SqlException sqlEx = ex as SqlException;
                if (sqlEx != null)
                {
                    LogMessage(ex.Message, true);
                    LogSqlErrors(ex.Message, sqlEx.Errors);
                }
            }
            catch 
            {

                LogMessage(ex.ToString(), true);
            }
        }

        public static void LogConnectionStateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Connection State Change Event: ");
            sb.Append(Environment.NewLine);
            sb.Append(" Original State: " + e.OriginalState);
            sb.Append(" Current State: " + e.CurrentState);

            LogMessage(sb.ToString());
        }
    }
}
