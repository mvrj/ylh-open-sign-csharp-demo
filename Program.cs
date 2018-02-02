using System;
using System.Collections.Generic;
using System.Text;
using Aop.Api.Util;

namespace SignDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<string,string> paramsMap = new Dictionary<string, string>();
            //添加请求参数(除sign)
            paramsMap.Add("client_id","YLH");
            paramsMap.Add("access_token","123");
            Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            paramsMap.Add("timestamp",unixTimestamp.ToString());
            Console.WriteLine(unixTimestamp);
            
            string privateKeyPem = Environment.CurrentDirectory + "\\test\\private.pem";
            string sign = AlipaySignature.RSASign(paramsMap,privateKeyPem,null,"RSA2");
            
            //sign签名好了
            Console.WriteLine(sign);
            
            //将所有参数进行HTTP请求(包括sign)

            //请求代码自行完成

        }
    }
}
