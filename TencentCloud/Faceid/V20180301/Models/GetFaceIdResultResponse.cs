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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFaceIdResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 身份证
        /// </summary>
        [JsonProperty("IdCard")]
        public string IdCard{ get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 业务核验结果，参考https://cloud.tencent.com/document/product/1007/47912
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 业务核验描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 相似度，0-100，数值越大相似度越高
        /// </summary>
        [JsonProperty("Similarity")]
        public float? Similarity{ get; set; }

        /// <summary>
        /// 用户核验的视频
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoBase64")]
        public string VideoBase64{ get; set; }

        /// <summary>
        /// 用户核验视频的截帧
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BestFrameBase64")]
        public string BestFrameBase64{ get; set; }

        /// <summary>
        /// 获取token时透传的信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Extra")]
        public string Extra{ get; set; }

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
            this.SetParamSimple(map, prefix + "IdCard", this.IdCard);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Similarity", this.Similarity);
            this.SetParamSimple(map, prefix + "VideoBase64", this.VideoBase64);
            this.SetParamSimple(map, prefix + "BestFrameBase64", this.BestFrameBase64);
            this.SetParamSimple(map, prefix + "Extra", this.Extra);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

