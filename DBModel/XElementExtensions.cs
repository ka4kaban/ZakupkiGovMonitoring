﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public static class XElementExtensions
    {
        public static XElement GetDescendant(this XElement node, string name)
        {
            return node.Descendants().Where(s => s.Name.LocalName.ToLower() == name.ToLower()).FirstOrDefault();
        }
        public static String GetString(this XElement node, string name)
        {
            if (node.GetDescendant(name) == null || node.GetDescendant(name).Value == null)
                return string.Empty;
            return node.GetDescendant(name).Value.ToString();
        }
        public static Guid GetGuid(this XElement node, string name)
        {
            return Guid.Parse(node.GetDescendant(name).Value.ToString());
        }
        public static bool GetBool(this XElement node, string name)
        {
            return Boolean.Parse(node.GetDescendant(name).Value.ToString());
        }
        public static DateTime GetDateTime(this XElement node, string name)
        {
            return DateTime.Parse(node.GetDescendant(name).Value.ToString());
        }
        //public static Nullable<DateTime> GetDateTimeNull(this XElement node, string name)
        //{
        //    //if (!allowNull) return GetDateTime(node, name);
        //    try {
        //        DateTime res = DateTime.Parse(node.GetDescendant(name).Value.ToString());
        //    }
        //    catch () {
        //    }
        //        //return null;
        //    return DateTime.Parse(node.GetDescendant(name).Value.ToString());
        //}
        public static int GetInt(this XElement node, string name)
        {
            return Int32.Parse(node.GetDescendant(name).Value.ToString());
        }
        public static double GetDouble(this XElement node, string name)
        {
            return Double.Parse(node.GetDescendant(name).Value.ToString());
        }
    }
}
