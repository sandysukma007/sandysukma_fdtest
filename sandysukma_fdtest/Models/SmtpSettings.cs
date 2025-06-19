using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sandysukma_fdtest.Models
{
    public class SmtpSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public bool EnableSSL { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
