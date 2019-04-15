using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CompanyService" in both code and config file together.
    public class CompanyService : IMyCompanyPublicService, IMyCompanyConfidentialService
    {

        public string GetPublicInformation()
        {
            return "Public service using http as it works over firewall";
        }

        public string GetCofidentialInformation()
        {
            return "confidential as it requires to work inside the firewall";
        }
    }
}
