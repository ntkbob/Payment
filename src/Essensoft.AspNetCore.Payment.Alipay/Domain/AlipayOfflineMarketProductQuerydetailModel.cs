using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOfflineMarketProductQuerydetailModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketProductQuerydetailModel : AlipayObject
    {
        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonProperty("item_id")]
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 操作人角色，默认商户操作:MERCHANT；服务商操作：PROVIDER。支付宝内部使用，外部商户不需填写此字段。
        /// </summary>
        [JsonProperty("op_role")]
        [XmlElement("op_role")]
        public string OpRole { get; set; }

        /// <summary>
        /// 门店ID。支付宝内部使用，外部商户不需填写此字段。
        /// </summary>
        [JsonProperty("shop_id")]
        [XmlElement("shop_id")]
        public string ShopId { get; set; }
    }
}
