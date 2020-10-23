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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GeneralBasicOCRResponse : AbstractModel
    {
        
        /// <summary>
        /// 检测到的文本信息，包括文本行内容、置信度、文本行坐标以及文本行旋转纠正后的坐标，具体内容请点击左侧链接。
        /// </summary>
        [JsonProperty("TextDetections")]
        public TextDetection[] TextDetections{ get; set; }

        /// <summary>
        /// 检测到的语言类型，目前支持的语言类型参考入参LanguageType说明。
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// 图片旋转角度（角度制），文本的水平方向为0°；顺时针为正，逆时针为负。点击查看<a href="https://cloud.tencent.com/document/product/866/45139">如何纠正倾斜文本</a>
        /// </summary>
        [JsonProperty("Angel")]
        public float? Angel{ get; set; }

        /// <summary>
        /// 图片为PDF时，返回PDF的总页数，默认为0
        /// </summary>
        [JsonProperty("PdfPageSize")]
        public long? PdfPageSize{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "TextDetections.", this.TextDetections);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "Angel", this.Angel);
            this.SetParamSimple(map, prefix + "PdfPageSize", this.PdfPageSize);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

