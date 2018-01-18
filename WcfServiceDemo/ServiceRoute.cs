using System;
using System.ServiceModel.Activation;

namespace WcfServiceDemo
{
    internal class ServiceRoute
    {
        private string v;
        private WebServiceHostFactory webServiceHostFactory;
        private Type type;

        public ServiceRoute(string v, WebServiceHostFactory webServiceHostFactory, Type type)
        {
            this.v = v;
            this.webServiceHostFactory = webServiceHostFactory;
            this.type = type;
        }
    }
}