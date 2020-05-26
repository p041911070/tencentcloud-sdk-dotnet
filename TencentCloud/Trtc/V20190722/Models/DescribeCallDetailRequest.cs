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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCallDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 通话 ID（唯一标识一次通话）： sdkappid_roomgString（房间号_createTime（房间创建时间，unix时间戳，单位为s）。通过 DescribeRoomInformation（查询房间列表）接口获取。
        /// </summary>
        [JsonProperty("CommId")]
        public string CommId{ get; set; }

        /// <summary>
        /// 查询开始时间，5天内。本地unix时间戳（1588031999s）
        /// </summary>
        [JsonProperty("StartTime")]
        public ulong? StartTime{ get; set; }

        /// <summary>
        /// 查询结束时间，本地unix时间戳（1588031999s）
        /// </summary>
        [JsonProperty("EndTime")]
        public ulong? EndTime{ get; set; }

        /// <summary>
        /// 用户sdkappid
        /// </summary>
        [JsonProperty("SdkAppId")]
        public string SdkAppId{ get; set; }

        /// <summary>
        /// 需查询的用户数组，不填默认返回6个用户,最多可填6个用户
        /// </summary>
        [JsonProperty("UserIds")]
        public string[] UserIds{ get; set; }

        /// <summary>
        /// 需查询的指标，不填则只返回用户列表，填all则返回所有指标。
        /// appCpu：APP CPU使用率；
        /// sysCpu：系统 CPU使用率；
        /// aBit：上/下行音频码率；
        /// aBlock：音频卡顿时长；
        /// vBit：上/下行视频码率；
        /// vCapFps：视频采集帧率；
        /// vEncFps：视频发送帧率；
        /// vDecFps：渲染帧率；
        /// vBlock：视频卡顿时长；
        /// aLoss：上/下行音频丢包；
        /// vLoss：上/下行视频丢包；
        /// vWidth：上/下行分辨率宽；
        /// vHeight：上/下行分辨率高
        /// </summary>
        [JsonProperty("DataType")]
        public string[] DataType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CommId", this.CommId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamArraySimple(map, prefix + "UserIds.", this.UserIds);
            this.SetParamArraySimple(map, prefix + "DataType.", this.DataType);
        }
    }
}

