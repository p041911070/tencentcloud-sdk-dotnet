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

namespace TencentCloud.Youmall.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PersonTagInfo : AbstractModel
    {
        
        /// <summary>
        /// 顾客原类型
        /// </summary>
        [JsonProperty("OldType")]
        public long? OldType{ get; set; }

        /// <summary>
        /// 顾客新类型
        /// </summary>
        [JsonProperty("NewType")]
        public long? NewType{ get; set; }

        /// <summary>
        /// 顾客face id
        /// </summary>
        [JsonProperty("PersonId")]
        public long? PersonId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OldType", this.OldType);
            this.SetParamSimple(map, prefix + "NewType", this.NewType);
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
        }
    }
}

