using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Web.App_Code.Entity
{
    public class BaseResponseEntity
    {
        public BaseResponseEntity()
        {
            ResponseCode = ResponseCodeEnum.C0000;
            ErrorMsg = string.Empty;
        }

        public ResponseCodeEnum ResponseCode { get; set; }
        public string ErrorMsg { get; set; }
    }

    public enum ResponseCodeEnum
    {
        /// <summary>
        /// 业务错误
        /// </summary>
        [Description("业务错误")]
        C8000 = 8000,
        /// <summary>
        /// 配置错误[未定义]
        /// </summary>
        [Description("配置错误[未定义]")]
        C7000 = 7000,
        /// <summary>
        /// 配置错误[接口地址未配置]
        /// </summary>
        [Description("配置错误[接口地址未配置]")]
        C7001 = 7001,
        /// <summary>
        /// 配置错误[帐号未配置]
        /// </summary>
        [Description("配置错误[帐号未配置]")]
        C7002 = 7002,
        /// <summary>
        /// 配置错误[协议版本未配置]
        /// </summary>
        [Description("配置错误[协议版本未配置]")]
        C7003 = 7003,
        /// <summary>
        /// Ioc配置错误
        /// </summary>
        [Description("Ioc配置错误")]
        C7004 = 7004,
        /// <summary>
        /// 报文错误[未分类]
        /// </summary>
        [Description("报文错误[未分类]")]
        C6000 = 6000,
        /// <summary>
        /// 缺少报文头
        /// </summary>
        [Description("缺少报文头")]
        C6001 = 6001,
        /// <summary>
        /// 请求报文头错误
        /// </summary>
        [Description("请求报文头错误")]
        C6002 = 6002,
        /// <summary>
        /// 应答报文头错误
        /// </summary>
        [Description("应答报文头错误")]
        C6003 = 6003,
        /// <summary>
        /// 协议版本错误
        /// </summary>
        [Description("协议版本错误")]
        C6004 = 6004,
        /// <summary>
        /// 未找到方法
        /// </summary>
        [Description("未找到方法")]
        C6005 = 6005,
        /// <summary>
        /// 报文体错误
        /// </summary>
        [Description("报文体错误")]
        C6006 = 6006,
        /// <summary>
        /// 认证错误[未分类]
        /// </summary>
        [Description("认证错误[未分类]")]
        C5000 = 5000,
        /// <summary>
        /// 认证错误[账号不存在]
        /// </summary>
        [Description("认证错误[账号不存在]")]
        C5001 = 5001,
        /// <summary>
        /// 程序执行错误
        /// </summary>
        [Description("程序执行错误")]
        C4000 = 4000,
        /// <summary>
        /// 网络错误[未分类]
        /// </summary>
        [Description("网络错误[未分类]")]
        C3000 = 3000,
        /// <summary>
        /// 网络连接失败
        /// </summary>
        [Description("网络连接失败")]
        C3001 = 3001,
        /// <summary>
        /// 拒绝访问
        /// </summary>
        [Description("拒绝访问")]
        C3002 = 3002,
        /// <summary>
        /// 网络连接超时
        /// </summary>
        [Description("网络连接超时")]
        C3003 = 3003,
        /// <summary>
        /// 数据错误[未分类]
        /// </summary>
        [Description("数据错误[未分类]")]
        C2000 = 2000,
        /// <summary>
        /// 连接数据库失败
        /// </summary>
        [Description("连接数据库失败")]
        C2001 = 2001,
        /// <summary>
        /// 添加失败
        /// </summary>
        [Description("添加失败")]
        C2002 = 2002,
        /// <summary>
        /// 查询失败
        /// </summary>
        [Description("查询失败")]
        C2003 = 2003,
        /// <summary>
        /// 更新失败
        /// </summary>
        [Description("更新失败")]
        C2004 = 2004,
        /// <summary>
        /// 删除失败
        /// </summary>
        [Description("删除失败")]
        C2005 = 2005,
        /// <summary>
        /// 参数错误[未分类]
        /// </summary>
        [Description("参数错误[未分类]")]
        C1000 = 1000,
        /// <summary>
        /// 参数错误[缺少参数]
        /// </summary>
        [Description("参数错误[缺少参数]")]
        C1001 = 1001,
        /// <summary>
        /// 参数错误[类型错误]
        /// </summary>
        [Description("参数错误[类型错误]")]
        C1002 = 1002,
        /// <summary>
        /// 参数错误[范围错误]
        /// </summary>
        [Description(" 参数错误[范围错误]")]
        C1003 = 1003,
        /// <summary>
        /// 参数错误[获取参数失败]
        /// </summary>
        [Description(" 参数错误[获取参数失败]")]
        C1004 = 1004,
        /// <summary>
        /// 请求处理成功
        /// </summary>
        [Description("请求处理成功")]
        C0000 = 0,
        /// <summary>
        /// 请求处理成功[无预期结果]
        /// </summary>
        [Description("请求处理成功[无预期结果]")]
        C0001 = 1,
    }

    public class BasePageResponseEntity : BaseResponseEntity
    {
        /// <summary>
        /// 页码
        /// </summary>
        public int PageIndex { get; set; }
        /// <summary>
        /// 每页记录条数
        /// </summary>
        public int PageSize { get; set; }
        /// <summary>
        /// 记录总数
        /// </summary>
        public int RecordTotal { get; set; }
    }

    public class SearchCondition
    {
        public SearchCondition()
        {
            Size = 10;
            PageIndex = 1;
        }
        /// <summary>
        /// 每次查询返回的条数
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// 每次查询的当前页码
        /// </summary>
        public int PageIndex { get; set; }
    }

    public class OperateUserInfo
    {
        public OperateUserInfo()
        {
            UserName = "系统操作";
        }

        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 工号
        /// </summary>
        public string JobNum { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        public int UserId { get; set; }
    }

    public class CommonRequestEntity
    {
        public CommonRequestEntity()
        {
            OperateUserInfo = new OperateUserInfo();
        }

        public OperateUserInfo OperateUserInfo { get; set; }
    }
}