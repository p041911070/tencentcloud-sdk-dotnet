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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeImageTagsRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用Id
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 偏移量，取值从0开始
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 分页个数，默认为20， 取值应为1~100
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 不填和0:查询 1:不查询
        /// </summary>
        [JsonProperty("QueryImageIdFlag")]
        public long? QueryImageIdFlag{ get; set; }

        /// <summary>
        /// 可用于搜索的 tag 名字
        /// </summary>
        [JsonProperty("SearchWord")]
        public string SearchWord{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "QueryImageIdFlag", this.QueryImageIdFlag);
            this.SetParamSimple(map, prefix + "SearchWord", this.SearchWord);
        }
    }
}

