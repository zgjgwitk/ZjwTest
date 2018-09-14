using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.App_Code.Entity
{
    public class GenerateOrderRequest : OperateUserInfo
    {
        /// <summary>
        /// 会员id
        /// </summary>
        public int MemberId { get; set; }
        /// <summary>
        /// 会员手机号
        /// </summary>
        public string MemberMobile { get; set; }
        /// <summary>
        /// 平台id
        /// </summary>
        public int PlatformId { get; set; }
        /// <summary>
        /// refid
        /// </summary>
        public int RefId { get; set; }
        /// <summary>
        /// 是否需要发票:0-不需要；1-需要
        /// </summary>
        public int InvoiceFlag { get; set; }
        /// <summary>
        /// 发货方式，0-快递，1-门店自提
        /// </summary>
        public int DeliveryMode { get; set; }
        /// <summary>
        /// 订单总金额
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 应付金额
        /// </summary>
        public decimal PayAmount { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        public int Integral { get; set; }
        /// <summary>
        /// 用户备注
        /// </summary>
        public string UserRemark { get; set; }
        /// <summary>
        /// 商品列表
        /// </summary>
        public List<Goods> GoodsList { get; set; }
        /// <summary>
        /// 发票信息
        /// </summary>
        public Invoice InvoiceInfo { get; set; }
        /// <summary>
        /// 订单物流信息
        /// </summary>
        public Logistics LogisticsInfo { get; set; }
        /// <summary>
        /// 订单联系人
        /// </summary>
        public string LinkMan { get; set; }
        /// <summary>
        /// 下单门店id
        /// </summary>
        public long StoreId { get; set; }
        /// <summary>
        /// 下单门店code
        /// </summary>
        public string StoreCode { get; set; }

        public class Goods
        {
            /// <summary>
            /// 商品id
            /// </summary>
            public long Id { get; set; }
            /// <summary>
            /// 货号
            /// </summary>
            public string SN { get; set; }
            /// <summary>
            /// 商品名称
            /// </summary>
            public string Name { get; set; }
            /// <summary>
            /// 数量
            /// </summary>
            public int Quantity { get; set; }
            /// <summary>
            /// 单价
            /// </summary>
            public decimal Price { get; set; }
            /// <summary>
            /// 积分
            /// </summary>
            public int Integral { get; set; }
            /// <summary>
            /// 积分比例
            /// </summary>
            public decimal IntegralRatio { get; set; }
        }

        public class Invoice
        {
            /// <summary>
            /// 发票类型，0-普通发票，1-专用发票
            /// </summary>
            public int Type { get; set; }
            /// <summary>
            /// 发票形式，0-纸质发票，1-电子发票
            /// </summary>
            public int Form { get; set; }
            /// <summary>
            /// 发票抬头
            /// </summary>
            public string Title { get; set; }
            /// <summary>
            /// 发票内容
            /// </summary>
            public string Content { get; set; }
            /// <summary>
            /// 发票金额
            /// </summary>
            public decimal Amount { get; set; }
            /// <summary>
            /// 收件人
            /// </summary>
            public string Receiver { get; set; }
            /// <summary>
            /// 收件人号码
            /// </summary>
            public string Mobile { get; set; }
            /// <summary>
            /// 收件地址
            /// </summary>
            public string Address { get; set; }
            /// <summary>
            /// 邮编
            /// </summary>
            public string Postcode { get; set; }
        }

        public class Logistics
        {
            /// <summary>
            /// 门店Id
            /// </summary>
            public long StoreId { get; set; }
            /// <summary>
            /// 收件人
            /// </summary>
            public string Receiver { get; set; }
            /// <summary>
            /// 收件人号码
            /// </summary>
            public string Mobile { get; set; }
            /// <summary>
            /// 收件地址
            /// </summary>
            public string Address { get; set; }
            /// <summary>
            /// 邮编
            /// </summary>
            public string Postcode { get; set; }
        }
    }

    public class GenerateOrderResponse : BaseResponseEntity
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderSerialNo { get; set; }
    }

    public class CancelOrderRequest : OperateUserInfo
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string OrderSerialNO { get; set; }
    }

    public class CancelOrderResponse : BaseResponseEntity
    {
    }
}