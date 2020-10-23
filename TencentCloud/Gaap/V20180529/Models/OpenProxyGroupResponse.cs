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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpenProxyGroupResponse : AbstractModel
    {
        
        /// <summary>
        /// 非关闭状态下的通道实例ID列表，不可开启。
        /// </summary>
        [JsonProperty("InvalidStatusInstanceSet")]
        public string[] InvalidStatusInstanceSet{ get; set; }

        /// <summary>
        /// 开启操作失败的通道实例ID列表。
        /// </summary>
        [JsonProperty("OperationFailedInstanceSet")]
        public string[] OperationFailedInstanceSet{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "InvalidStatusInstanceSet.", this.InvalidStatusInstanceSet);
            this.SetParamArraySimple(map, prefix + "OperationFailedInstanceSet.", this.OperationFailedInstanceSet);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

