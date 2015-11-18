using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for stateName
/// </summary>
public class stateName
{

    private string _abbreviatedName;
    private string _stateName;

    public string AbName { get { return _abbreviatedName; } set { _abbreviatedName = value; } }
    public string StateName { get { return _stateName; } set { _stateName = value; } }
}