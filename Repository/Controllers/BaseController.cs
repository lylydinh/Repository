using Repository.Library.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Repository.Controllers
{
    public class BaseController : Controller
    { 
        public UnitOfWork UnitOfWork { get; }

        public BaseController()
        {
            UnitOfWork = new UnitOfWork();
        }

        public int ExchangeRate()
        {
            return 3410;
        }

        public int TimeDelay => int.Parse(ConfigurationManager.AppSettings["TimeDelay"]);

     
      
        protected string[] GetBlackListExtensions()
        {
            string[] blackList = { ".exe", ".cshtml", ".vbhtml", ".aspx", ".ascx", ".msi", ".bin", ".js", ".bat", ".cmd", ".ps1", ".reg", ".rgs", ".ws", ".wsf" };
            var blacklistConfig = ConfigurationManager.AppSettings["BlackListExtentions"];
            if (!string.IsNullOrWhiteSpace(blacklistConfig))
            {
                blacklistConfig = blacklistConfig.Replace(" ", "").ToLower();
                var split = blacklistConfig.Split(',', ';');
                if (split.Length != 0)
                {
                    blackList = split;
                }
            }
            return blackList;
        }

        protected int GetMaxFileLength()
        {
            var maxLengthConfig = ConfigurationManager.AppSettings["MaxFileLength"];
            int maxLength;
            if (string.IsNullOrWhiteSpace(maxLengthConfig))
            {
                maxLength = 5120000;
            }
            else
            {
                if (!int.TryParse(maxLengthConfig, out maxLength))
                {
                    maxLength = 5120000;
                }
            }

            return maxLength;
        } 

    }
}