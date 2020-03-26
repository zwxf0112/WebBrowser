﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// AUTHOR GREGORY GOODREAU
/// VERSION 3/26/2020
/// WEB BROWSER
/// </summary>

namespace WebBrowser.Logic
{
    ////////////////////////////////////////////
    // GET AND SET VARIABLES USED IN HISTORY //
    //////////////////////////////////////////
    public class HistoryItem
    {
        public int Id
        {
            get; set;
        }
        public string URL
        {
            get; set;
        }
        public string Title
        {
            get; set;
        }
        public DateTime Date
        {
            get; set;
        }
    }
}
