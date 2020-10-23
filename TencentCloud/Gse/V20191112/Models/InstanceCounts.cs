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

namespace TencentCloud.Gse.V20191112.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceCounts : AbstractModel
    {
        
        /// <summary>
        /// 活跃的服务器实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Active")]
        public ulong? Active{ get; set; }

        /// <summary>
        /// 期望的服务器实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Desired")]
        public ulong? Desired{ get; set; }

        /// <summary>
        /// 空闲的服务器实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Idle")]
        public ulong? Idle{ get; set; }

        /// <summary>
        /// 服务器实例数最大限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MaxiNum")]
        public ulong? MaxiNum{ get; set; }

        /// <summary>
        /// 服务器实例数最小限制
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MiniNum")]
        public ulong? MiniNum{ get; set; }

        /// <summary>
        /// 已开始创建，但未激活的服务器实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Pending")]
        public ulong? Pending{ get; set; }

        /// <summary>
        /// 结束中的服务器实例数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Terminating")]
        public ulong? Terminating{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Active", this.Active);
            this.SetParamSimple(map, prefix + "Desired", this.Desired);
            this.SetParamSimple(map, prefix + "Idle", this.Idle);
            this.SetParamSimple(map, prefix + "MaxiNum", this.MaxiNum);
            this.SetParamSimple(map, prefix + "MiniNum", this.MiniNum);
            this.SetParamSimple(map, prefix + "Pending", this.Pending);
            this.SetParamSimple(map, prefix + "Terminating", this.Terminating);
        }
    }
}

