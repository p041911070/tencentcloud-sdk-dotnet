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

namespace TencentCloud.Rkp.V20191209.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetOpenIdRequest : AbstractModel
    {
        
        /// <summary>
        /// dev临时token，通过sdk接口获取
        /// </summary>
        [JsonProperty("DeviceToken")]
        public string DeviceToken{ get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        [JsonProperty("BusinessId")]
        public long? BusinessId{ get; set; }

        /// <summary>
        /// 业务侧账号体系下的用户ID
        /// </summary>
        [JsonProperty("BusinessUserId")]
        public string BusinessUserId{ get; set; }

        /// <summary>
        /// 平台：0-Android， 1-iOS， 2-web
        /// </summary>
        [JsonProperty("Platform")]
        public long? Platform{ get; set; }

        /// <summary>
        /// 选项
        /// </summary>
        [JsonProperty("Option")]
        public string Option{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DeviceToken", this.DeviceToken);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "BusinessUserId", this.BusinessUserId);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
            this.SetParamSimple(map, prefix + "Option", this.Option);
        }
    }
}

