using System;
using System.Net;
using System.Net.Security;
using WcfClientDemo.ProductServiceRef;

namespace WcfClientDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Como conectarnos al WCF y aceptar el certificado Self-Signed del IIS
            // Usamos el escenario del cliente WCF anonimo y confiamos en el certificado del servidor
            // Funcion callback que siempre retorna true para evitar el uso del WCA y "certificado-cer-pfx"
            using (var proxy = new ProductServiceClient())
            {
                RemoteCertificateValidationCallback callBack = (sender, certificate, chain, sslPolicyErrors) => true;

                ServicePointManager.ServerCertificateValidationCallback += callBack;

                var productos = proxy.GetAllProducts();
                foreach (var producto in productos)
                {
                    Console.WriteLine(producto.Id + " - " + producto.Name);
                }

                ServicePointManager.ServerCertificateValidationCallback -= callBack;
            }
        }
    }
}
