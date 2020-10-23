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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RechargeByThirdPayResponse : AbstractModel
    {
        
        /// <summary>
        /// 保留字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReservedMessage")]
        public string ReservedMessage{ get; set; }

        /// <summary>
        /// 银行流水号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FrontSequenceNumber")]
        public string FrontSequenceNumber{ get; set; }

        /// <summary>
        /// 请求类型
        /// </summary>
        [JsonProperty("RequestType")]
        public string RequestType{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReservedMessage", this.ReservedMessage);
            this.SetParamSimple(map, prefix + "FrontSequenceNumber", this.FrontSequenceNumber);
            this.SetParamSimple(map, prefix + "RequestType", this.RequestType);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

