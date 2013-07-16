using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

namespace uNews
{
    public class uNewsMvcHelper
    {

        public static string GetLat(object Xml){
            XmlDocument xd = new XmlDocument();

            try
            {
                xd.LoadXml(Xml.ToString());
                return xd.SelectSingleNode("//coords ").Attributes["lat"].Value;
            }
            catch
            {
                return "";
            }
        }

        public static string GetLng(object Xml)
        {
            XmlDocument xd = new XmlDocument();

            try
            {
                xd.LoadXml(Xml.ToString());
                return xd.SelectSingleNode("//coords ").Attributes["lng"].Value;
            }
            catch
            {
                return "";
            }
        }


        public static string GetZoom(object Xml)
        {
            XmlDocument xd = new XmlDocument();

            try
            {
                xd.LoadXml(Xml.ToString());
                return xd.SelectSingleNode("//zoom ").InnerText;
            }
            catch
            {
                return "";
            }
        }

        public static string GetAddress(object Xml)
        {
            XmlDocument xd = new XmlDocument();

            try
            {
                xd.LoadXml(Xml.ToString());
                return xd.SelectSingleNode("//address ").InnerText;
            }
            catch
            {
                return "";
            }
        }
    }
}