using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IHelloRemotingService;
namespace HelloRemotingService
{
    public class HelloRemotingService:MarshalByRefObject,IHelloRemotingService.IHelloRemotingService

    {

        public string GetMessage1(string name)
        {
            return "Hello " + name;
        }
    }
}
