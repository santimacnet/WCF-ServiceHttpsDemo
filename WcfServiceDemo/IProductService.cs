using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceDemo
{

    /// <summary>
    /// Catalogo de Servicios WCF
    /// </summary>
    [ServiceContract]
    interface IProductService
    {
        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "products/add/{name}")]
        bool AddProduct(string name);

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "products/update/{id}/{name}")]
        bool UpdateProduct(string id, string name);

        [OperationContract]
        [WebInvoke(ResponseFormat = WebMessageFormat.Json, UriTemplate = "products/delete/{id}")]
        bool DeleteProduct(string id);

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "products")]
        List<Product> GetAllProducts();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json, UriTemplate = "products/{id}")]
        Product GetProductById(string id);

    }
}
