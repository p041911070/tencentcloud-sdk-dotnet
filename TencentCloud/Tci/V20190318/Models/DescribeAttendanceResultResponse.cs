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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAttendanceResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 缺失人员的ID列表(只针对请求中的libids字段)
        /// </summary>
        [JsonProperty("AbsenceSetInLibs")]
        public AbsenceInfo[] AbsenceSetInLibs{ get; set; }

        /// <summary>
        /// 确定出勤人员列表
        /// </summary>
        [JsonProperty("AttendanceSet")]
        public AttendanceInfo[] AttendanceSet{ get; set; }

        /// <summary>
        /// 疑似出勤人员列表
        /// </summary>
        [JsonProperty("SuspectedSet")]
        public SuspectedInfo[] SuspectedSet{ get; set; }

        /// <summary>
        /// 缺失人员的ID列表(只针对请求中的personids字段)
        /// </summary>
        [JsonProperty("AbsenceSet")]
        public string[] AbsenceSet{ get; set; }

        /// <summary>
        /// 请求处理进度
        /// </summary>
        [JsonProperty("Progress")]
        public long? Progress{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "AbsenceSetInLibs.", this.AbsenceSetInLibs);
            this.SetParamArrayObj(map, prefix + "AttendanceSet.", this.AttendanceSet);
            this.SetParamArrayObj(map, prefix + "SuspectedSet.", this.SuspectedSet);
            this.SetParamArraySimple(map, prefix + "AbsenceSet.", this.AbsenceSet);
            this.SetParamSimple(map, prefix + "Progress", this.Progress);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

