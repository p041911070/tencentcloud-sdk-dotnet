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

namespace TencentCloud.Tic.V20201117
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Tic.V20201117.Models;

   public class TicClient : AbstractClient{

       private const string endpoint = "tic.tencentcloudapi.com";
       private const string version = "2020-11-17";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public TicClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public TicClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口（ApplyStack）用于触发资源栈下某个版本的Apply事件。
        /// 
        /// - 当版本处于PLAN_IN_PROGRESS或APPLY_IN_PROGRESS状态时，将无法再执行本操作
        /// - 当版本处于APPLY_COMPLETED状态时，本操作无法执行
        /// </summary>
        /// <param name="req"><see cref="ApplyStackRequest"/></param>
        /// <returns><see cref="ApplyStackResponse"/></returns>
        public async Task<ApplyStackResponse> ApplyStack(ApplyStackRequest req)
        {
             JsonResponseModel<ApplyStackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyStack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyStackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（ApplyStack）用于触发资源栈下某个版本的Apply事件。
        /// 
        /// - 当版本处于PLAN_IN_PROGRESS或APPLY_IN_PROGRESS状态时，将无法再执行本操作
        /// - 当版本处于APPLY_COMPLETED状态时，本操作无法执行
        /// </summary>
        /// <param name="req"><see cref="ApplyStackRequest"/></param>
        /// <returns><see cref="ApplyStackResponse"/></returns>
        public ApplyStackResponse ApplyStackSync(ApplyStackRequest req)
        {
             JsonResponseModel<ApplyStackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyStack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyStackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateStack）用于通过传递一个COS的terraform zip模版URL来创建一个资源栈。创建资源栈后仍需要用户调用对应的plan, apply, destory执行对应的事件。
        /// </summary>
        /// <param name="req"><see cref="CreateStackRequest"/></param>
        /// <returns><see cref="CreateStackResponse"/></returns>
        public async Task<CreateStackResponse> CreateStack(CreateStackRequest req)
        {
             JsonResponseModel<CreateStackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateStack）用于通过传递一个COS的terraform zip模版URL来创建一个资源栈。创建资源栈后仍需要用户调用对应的plan, apply, destory执行对应的事件。
        /// </summary>
        /// <param name="req"><see cref="CreateStackRequest"/></param>
        /// <returns><see cref="CreateStackResponse"/></returns>
        public CreateStackResponse CreateStackSync(CreateStackRequest req)
        {
             JsonResponseModel<CreateStackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateStackVersion）用于给资源栈新增一个HCL模版版本，仅限COS链接，且为zip格式。
        /// </summary>
        /// <param name="req"><see cref="CreateStackVersionRequest"/></param>
        /// <returns><see cref="CreateStackVersionResponse"/></returns>
        public async Task<CreateStackVersionResponse> CreateStackVersion(CreateStackVersionRequest req)
        {
             JsonResponseModel<CreateStackVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateStackVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStackVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（CreateStackVersion）用于给资源栈新增一个HCL模版版本，仅限COS链接，且为zip格式。
        /// </summary>
        /// <param name="req"><see cref="CreateStackVersionRequest"/></param>
        /// <returns><see cref="CreateStackVersionResponse"/></returns>
        public CreateStackVersionResponse CreateStackVersionSync(CreateStackVersionRequest req)
        {
             JsonResponseModel<CreateStackVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateStackVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateStackVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteStack）用于删除一个资源栈（配置、版本、事件信息）。但不会销毁资源管理的云资源。如果需要销毁资源栈管理的云资源，请调用 DestoryStack 接口销毁云资源。
        /// </summary>
        /// <param name="req"><see cref="DeleteStackRequest"/></param>
        /// <returns><see cref="DeleteStackResponse"/></returns>
        public async Task<DeleteStackResponse> DeleteStack(DeleteStackRequest req)
        {
             JsonResponseModel<DeleteStackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteStack）用于删除一个资源栈（配置、版本、事件信息）。但不会销毁资源管理的云资源。如果需要销毁资源栈管理的云资源，请调用 DestoryStack 接口销毁云资源。
        /// </summary>
        /// <param name="req"><see cref="DeleteStackRequest"/></param>
        /// <returns><see cref="DeleteStackResponse"/></returns>
        public DeleteStackResponse DeleteStackSync(DeleteStackRequest req)
        {
             JsonResponseModel<DeleteStackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteStack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteStackVersion）用于删除一个版本，处于PLAN_IN_PROGRESS和APPLY_IN_PROGRESS状态中的版本无法删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteStackVersionRequest"/></param>
        /// <returns><see cref="DeleteStackVersionResponse"/></returns>
        public async Task<DeleteStackVersionResponse> DeleteStackVersion(DeleteStackVersionRequest req)
        {
             JsonResponseModel<DeleteStackVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteStackVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStackVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DeleteStackVersion）用于删除一个版本，处于PLAN_IN_PROGRESS和APPLY_IN_PROGRESS状态中的版本无法删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteStackVersionRequest"/></param>
        /// <returns><see cref="DeleteStackVersionResponse"/></returns>
        public DeleteStackVersionResponse DeleteStackVersionSync(DeleteStackVersionRequest req)
        {
             JsonResponseModel<DeleteStackVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteStackVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteStackVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeStackEvent）用于获取单个事件详情，尤其是可以得到事件的详细控制台输出文本。
        /// </summary>
        /// <param name="req"><see cref="DescribeStackEventRequest"/></param>
        /// <returns><see cref="DescribeStackEventResponse"/></returns>
        public async Task<DescribeStackEventResponse> DescribeStackEvent(DescribeStackEventRequest req)
        {
             JsonResponseModel<DescribeStackEventResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStackEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStackEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeStackEvent）用于获取单个事件详情，尤其是可以得到事件的详细控制台输出文本。
        /// </summary>
        /// <param name="req"><see cref="DescribeStackEventRequest"/></param>
        /// <returns><see cref="DescribeStackEventResponse"/></returns>
        public DescribeStackEventResponse DescribeStackEventSync(DescribeStackEventRequest req)
        {
             JsonResponseModel<DescribeStackEventResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStackEvent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStackEventResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeStackEvents）用于查看一个或多个事件详细信息。
        /// 
        /// - 可以根据事件ID过滤感兴趣的事件
        /// - 也可以根据版本ID，资源栈ID，事件类型，事件状态过滤事件，过滤信息详细请见过滤器Filter
        /// - 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的事件
        /// </summary>
        /// <param name="req"><see cref="DescribeStackEventsRequest"/></param>
        /// <returns><see cref="DescribeStackEventsResponse"/></returns>
        public async Task<DescribeStackEventsResponse> DescribeStackEvents(DescribeStackEventsRequest req)
        {
             JsonResponseModel<DescribeStackEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStackEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStackEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeStackEvents）用于查看一个或多个事件详细信息。
        /// 
        /// - 可以根据事件ID过滤感兴趣的事件
        /// - 也可以根据版本ID，资源栈ID，事件类型，事件状态过滤事件，过滤信息详细请见过滤器Filter
        /// - 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的事件
        /// </summary>
        /// <param name="req"><see cref="DescribeStackEventsRequest"/></param>
        /// <returns><see cref="DescribeStackEventsResponse"/></returns>
        public DescribeStackEventsResponse DescribeStackEventsSync(DescribeStackEventsRequest req)
        {
             JsonResponseModel<DescribeStackEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStackEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStackEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeStackVersions）用于查询一个或多个版本的详细信息。
        /// 
        /// - 可以根据版本ID查询感兴趣的版本
        /// - 可以根据版本名字和状态来过滤版本，详见过滤器Filter
        /// - 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的版本
        /// </summary>
        /// <param name="req"><see cref="DescribeStackVersionsRequest"/></param>
        /// <returns><see cref="DescribeStackVersionsResponse"/></returns>
        public async Task<DescribeStackVersionsResponse> DescribeStackVersions(DescribeStackVersionsRequest req)
        {
             JsonResponseModel<DescribeStackVersionsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStackVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStackVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeStackVersions）用于查询一个或多个版本的详细信息。
        /// 
        /// - 可以根据版本ID查询感兴趣的版本
        /// - 可以根据版本名字和状态来过滤版本，详见过滤器Filter
        /// - 如果参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的版本
        /// </summary>
        /// <param name="req"><see cref="DescribeStackVersionsRequest"/></param>
        /// <returns><see cref="DescribeStackVersionsResponse"/></returns>
        public DescribeStackVersionsResponse DescribeStackVersionsSync(DescribeStackVersionsRequest req)
        {
             JsonResponseModel<DescribeStackVersionsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStackVersions");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStackVersionsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeStacks）用于查询一个或多个资源栈的详细信息。
        /// 
        /// - 可以根据资源栈ID来查询感兴趣的资源栈信息
        /// - 若参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的资源栈
        /// </summary>
        /// <param name="req"><see cref="DescribeStacksRequest"/></param>
        /// <returns><see cref="DescribeStacksResponse"/></returns>
        public async Task<DescribeStacksResponse> DescribeStacks(DescribeStacksRequest req)
        {
             JsonResponseModel<DescribeStacksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeStacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DescribeStacks）用于查询一个或多个资源栈的详细信息。
        /// 
        /// - 可以根据资源栈ID来查询感兴趣的资源栈信息
        /// - 若参数为空，返回当前用户一定数量（Limit所指定的数量，默认为20）的资源栈
        /// </summary>
        /// <param name="req"><see cref="DescribeStacksRequest"/></param>
        /// <returns><see cref="DescribeStacksResponse"/></returns>
        public DescribeStacksResponse DescribeStacksSync(DescribeStacksRequest req)
        {
             JsonResponseModel<DescribeStacksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeStacks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeStacksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DestroyStack）用于删除资源栈下的某个版本所创建的资源。
        /// </summary>
        /// <param name="req"><see cref="DestroyStackRequest"/></param>
        /// <returns><see cref="DestroyStackResponse"/></returns>
        public async Task<DestroyStackResponse> DestroyStack(DestroyStackRequest req)
        {
             JsonResponseModel<DestroyStackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DestroyStack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyStackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（DestroyStack）用于删除资源栈下的某个版本所创建的资源。
        /// </summary>
        /// <param name="req"><see cref="DestroyStackRequest"/></param>
        /// <returns><see cref="DestroyStackResponse"/></returns>
        public DestroyStackResponse DestroyStackSync(DestroyStackRequest req)
        {
             JsonResponseModel<DestroyStackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DestroyStack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DestroyStackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（PlanStack）用于触发资源栈下某个版本的PLAN事件。
        /// 
        /// - 当版本处于PLAN_IN_PROGRESS或APPLY_IN_PROGRESS状态时，将无法再执行本操作
        /// - 当版本处于APPLY_COMPLETED状态时，本操作无法执行
        /// </summary>
        /// <param name="req"><see cref="PlanStackRequest"/></param>
        /// <returns><see cref="PlanStackResponse"/></returns>
        public async Task<PlanStackResponse> PlanStack(PlanStackRequest req)
        {
             JsonResponseModel<PlanStackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PlanStack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PlanStackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（PlanStack）用于触发资源栈下某个版本的PLAN事件。
        /// 
        /// - 当版本处于PLAN_IN_PROGRESS或APPLY_IN_PROGRESS状态时，将无法再执行本操作
        /// - 当版本处于APPLY_COMPLETED状态时，本操作无法执行
        /// </summary>
        /// <param name="req"><see cref="PlanStackRequest"/></param>
        /// <returns><see cref="PlanStackResponse"/></returns>
        public PlanStackResponse PlanStackSync(PlanStackRequest req)
        {
             JsonResponseModel<PlanStackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PlanStack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PlanStackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateStack）用于更新资源栈的名称和描述。
        /// </summary>
        /// <param name="req"><see cref="UpdateStackRequest"/></param>
        /// <returns><see cref="UpdateStackResponse"/></returns>
        public async Task<UpdateStackResponse> UpdateStack(UpdateStackRequest req)
        {
             JsonResponseModel<UpdateStackResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateStack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateStackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateStack）用于更新资源栈的名称和描述。
        /// </summary>
        /// <param name="req"><see cref="UpdateStackRequest"/></param>
        /// <returns><see cref="UpdateStackResponse"/></returns>
        public UpdateStackResponse UpdateStackSync(UpdateStackRequest req)
        {
             JsonResponseModel<UpdateStackResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateStack");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateStackResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateStackVersion）用于更新一个版本的模版内容，名称或描述，模版仅限COS URL，且为zip格式。
        /// </summary>
        /// <param name="req"><see cref="UpdateStackVersionRequest"/></param>
        /// <returns><see cref="UpdateStackVersionResponse"/></returns>
        public async Task<UpdateStackVersionResponse> UpdateStackVersion(UpdateStackVersionRequest req)
        {
             JsonResponseModel<UpdateStackVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateStackVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateStackVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（UpdateStackVersion）用于更新一个版本的模版内容，名称或描述，模版仅限COS URL，且为zip格式。
        /// </summary>
        /// <param name="req"><see cref="UpdateStackVersionRequest"/></param>
        /// <returns><see cref="UpdateStackVersionResponse"/></returns>
        public UpdateStackVersionResponse UpdateStackVersionSync(UpdateStackVersionRequest req)
        {
             JsonResponseModel<UpdateStackVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateStackVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateStackVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
