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

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateWhiteBoxKeyResponse : AbstractModel
    {
        
        /// <summary>
        /// 用于加密的密钥，base64编码
        /// </summary>
        [JsonProperty("EncryptKey")]
        public string EncryptKey{ get; set; }

        /// <summary>
        /// 用于解密的密钥，base64编码
        /// </summary>
        [JsonProperty("DecryptKey")]
        public string DecryptKey{ get; set; }

        /// <summary>
        /// 白盒密钥的全局唯一标识符
        /// </summary>
        [JsonProperty("KeyId")]
        public string KeyId{ get; set; }

        /// <summary>
        /// 标签操作的返回码. 0: 成功；1: 内部错误；2: 业务处理错误
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagCode")]
        public ulong? TagCode{ get; set; }

        /// <summary>
        /// 标签操作的返回信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagMsg")]
        public string TagMsg{ get; set; }

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
            this.SetParamSimple(map, prefix + "EncryptKey", this.EncryptKey);
            this.SetParamSimple(map, prefix + "DecryptKey", this.DecryptKey);
            this.SetParamSimple(map, prefix + "KeyId", this.KeyId);
            this.SetParamSimple(map, prefix + "TagCode", this.TagCode);
            this.SetParamSimple(map, prefix + "TagMsg", this.TagMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

