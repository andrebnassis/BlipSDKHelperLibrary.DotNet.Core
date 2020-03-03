using RestEase;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StandardBlipSDKHelperLibrary.Interfaces
{
    public interface IFacebookGraphApi : IDisposable
    {
        [Post("v2.6/me/thread_settings")]
        [Header("Content-Type", "application/json")]
        Task<object> RegisterDomainToWhiteList([Query] string access_token, [Body] DomainWhiteListModel domainWhiteListInfo);
    }

    public class DomainWhiteListModel 
    {
        public List<string> whitelisted_domains { get; set; }
        public string setting_type { get; set; } = "domain_whitelisting";
        public string domain_action_type { get; set; } = "add";
    }
}
