using Microsoft.SqlServer.Server;
using System.Data.SqlTypes;
using System.Text.RegularExpressions;

namespace CLRFunction
{
    public class CLR
    {
        [SqlFunction (IsDeterministic=true)]

        public static SqlBoolean CheckEmail(SqlString email)
        {
            var pattern = @"^\S+@\S+$";
            return (SqlBoolean)Regex.IsMatch(email.ToString(),pattern);
        }

    }
}
