using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace WcfService1
{
    public class WsdlReflector : SoapExtensionReflector
    {
        public override void ReflectMethod()
        {
            var x = "hi'";
        }
        public override void ReflectDescription()
        {
            Console.WriteLine(ReflectionContext.ServiceDescription);
            ServiceDescription description = ReflectionContext.ServiceDescription;
            foreach (Service service in description.Services)
            {
                foreach (Port port in service.Ports)
                {
                    foreach (ServiceDescriptionFormatExtension extension in port.Extensions)
                    {
                        SoapAddressBinding binding = extension as SoapAddressBinding;
                        if (null != binding)
                        {
                            //binding.Location = binding.Location.Replace("http://mywebservice.comp.com", "https://uat.mywebservice.com");
                            binding.Location = "https://new.new";
                        }
                    }
                }
            }
            
        }
    }
}