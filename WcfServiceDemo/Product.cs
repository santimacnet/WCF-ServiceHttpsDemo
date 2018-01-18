using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WcfServiceDemo
{
    /// <summary>
    /// Class Represent a Product
    /// </summary>
    [DataContract]
    public class Product
    {
        /// <summary>
        /// Product Id
        /// </summary>
        [DataMember]
        public int Id { get; set; }

        /// <summary>
        /// Product Name
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Product Price
        /// </summary>
        [DataMember]
        public float Price { get; set; }
    }
}