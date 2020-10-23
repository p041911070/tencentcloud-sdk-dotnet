/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDBInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例可用区，类似ap-guangzhou-1（广州一区）；实例可售卖区域可以通过接口DescribeZones获取
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例内存大小，单位GB
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 实例磁盘大小，单位GB
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// 付费模式，取值支持 PREPAID（预付费），POSTPAID（后付费）。
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public long? ProjectId{ get; set; }

        /// <summary>
        /// 本次购买几个实例，默认值为1。取值不超过10
        /// </summary>
        [JsonProperty("GoodsNum")]
        public long? GoodsNum{ get; set; }

        /// <summary>
        /// VPC子网ID，形如subnet-bdoe83fa；SubnetId和VpcId需同时设置或者同时不设置
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// VPC网络ID，形如vpc-dsp338hz；SubnetId和VpcId需同时设置或者同时不设置
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 购买实例周期，默认取值为1，表示一个月。取值不超过48
        /// </summary>
        [JsonProperty("Period")]
        public long? Period{ get; set; }

        /// <summary>
        /// 是否自动使用代金券；1 - 是，0 - 否，默认不使用
        /// </summary>
        [JsonProperty("AutoVoucher")]
        public long? AutoVoucher{ get; set; }

        /// <summary>
        /// 代金券ID数组，目前单个订单只能使用一张
        /// </summary>
        [JsonProperty("VoucherIds")]
        public string[] VoucherIds{ get; set; }

        /// <summary>
        /// sqlserver版本，目前只支持：2008R2（SQL Server 2008 Enterprise），2012SP3（SQL Server 2012 Enterprise），2016SP1（SQL Server 2016 Enterprise），201602（SQL Server 2016 Standard）2017（SQL Server 2017 Enterprise）版本。每个地域支持售卖的版本不同，可通过DescribeProductConfig接口来拉取每个地域可售卖的版本信息。不填，默认为版本2008R2。
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// 自动续费标志：0-正常续费  1-自动续费，默认为1自动续费。只在购买预付费实例时有效。
        /// </summary>
        [JsonProperty("AutoRenewFlag")]
        public long? AutoRenewFlag{ get; set; }

        /// <summary>
        /// 安全组列表，填写形如sg-xxx的安全组ID
        /// </summary>
        [JsonProperty("SecurityGroupList")]
        public string[] SecurityGroupList{ get; set; }

        /// <summary>
        /// 可维护时间窗配置，以周为单位，表示周几允许维护，1-7分别代表周一到周末
        /// </summary>
        [JsonProperty("Weekly")]
        public long?[] Weekly{ get; set; }

        /// <summary>
        /// 可维护时间窗配置，每天可维护的开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 可维护时间窗配置，持续时间，单位：小时
        /// </summary>
        [JsonProperty("Span")]
        public long? Span{ get; set; }

        /// <summary>
        /// 购买高可用实例的类型：DUAL-双机高可用  CLUSTER-集群，默认值为DUAL
        /// </summary>
        [JsonProperty("HAType")]
        public string HAType{ get; set; }

        /// <summary>
        /// 是否跨可用区部署，默认值为false
        /// </summary>
        [JsonProperty("MultiZones")]
        public bool? MultiZones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "GoodsNum", this.GoodsNum);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "AutoVoucher", this.AutoVoucher);
            this.SetParamArraySimple(map, prefix + "VoucherIds.", this.VoucherIds);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "AutoRenewFlag", this.AutoRenewFlag);
            this.SetParamArraySimple(map, prefix + "SecurityGroupList.", this.SecurityGroupList);
            this.SetParamArraySimple(map, prefix + "Weekly.", this.Weekly);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "Span", this.Span);
            this.SetParamSimple(map, prefix + "HAType", this.HAType);
            this.SetParamSimple(map, prefix + "MultiZones", this.MultiZones);
        }
    }
}

