using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;

/// <summary>
/// Utility provides various methods for User Interface.
/// </summary>
public static class Utility
{
	public static string ConvertPassword(string password)
	{
        return ConvertPassword(password, "*");
	}

	public static string ConvertPassword(string password, string replacement)
	{
        StringBuilder sb = new StringBuilder();
        for (int count = 0; count < password.Length; count++)
            sb.Append(replacement);
        return sb.ToString();
	}


}
