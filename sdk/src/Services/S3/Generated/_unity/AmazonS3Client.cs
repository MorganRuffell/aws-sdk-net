/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3
{
    /// <summary>
    /// Implementation for accessing S3
    ///
    /// 
    /// </summary>
    public partial class AmazonS3Client : AmazonServiceClient, IAmazonS3
    {
        private static IServiceMetadata serviceMetadata = new AmazonS3Metadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonS3Client(AWSCredentials credentials)
            : this(credentials, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonS3Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials and an
        /// AmazonS3Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(AWSCredentials credentials, AmazonS3Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonS3Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new Amazon.S3.Internal.S3Signer();
        }

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3.Internal.AmazonS3PreMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3.Internal.AmazonS3PostMarshallHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.EndpointResolver>(new Amazon.S3.Internal.AmazonS3HttpDeleteHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.EndpointResolver>(new Amazon.S3.Internal.AmazonS3KmsHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.S3.Internal.AmazonS3ResponseHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.ErrorCallbackHandler>(new Amazon.S3.Internal.AmazonS3ExceptionHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.S3.Internal.AmazonS3RedirectHandler());
            pipeline.ReplaceHandler<Amazon.Runtime.Internal.RetryHandler>(new Amazon.Runtime.Internal.RetryHandler(new Amazon.S3.Internal.AmazonS3RetryPolicy(this.Config)));
        }    
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AbortMultipartUpload

        /// <summary>
        /// This operation aborts a multipart upload. After a multipart upload is aborted, no
        /// additional parts can be uploaded using that upload ID. The storage consumed by any
        /// previously uploaded parts will be freed. However, if any part uploads are currently
        /// in progress, those part uploads might or might not succeed. As a result, it might
        /// be necessary to abort a given multipart upload multiple times in order to completely
        /// free all storage consumed by all parts. 
        /// 
        ///  
        /// <para>
        /// To verify that all parts have been removed, so you don't get charged for the part
        /// storage, you should call the <a>ListParts</a> operation and ensure that the parts
        /// list is empty.
        /// </para>
        ///  
        /// <para>
        /// For information about permissions required to use the multipart upload API, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>AbortMultipartUpload</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The bucket name to which the upload was taking place.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Key of the object for which the multipart upload was initiated.</param>
        /// <param name="uploadId">Upload ID that identifies the multipart upload.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the AbortMultipartUpload service method, as returned by S3.</returns>
        public virtual void AbortMultipartUploadAsync(string bucketName, string key, string uploadId,  AmazonServiceCallback<AbortMultipartUploadRequest, AbortMultipartUploadResponse> callback, AsyncOptions options = null)
        {
            var request = new AbortMultipartUploadRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.UploadId = uploadId;
            AbortMultipartUploadAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void AbortMultipartUploadAsync(AbortMultipartUploadRequest request, AmazonServiceCallback<AbortMultipartUploadRequest, AbortMultipartUploadResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("AbortMultipartUpload is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = AbortMultipartUploadRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<AbortMultipartUploadRequest,AbortMultipartUploadResponse> responseObject 
                            = new AmazonServiceResult<AbortMultipartUploadRequest,AbortMultipartUploadResponse>((AbortMultipartUploadRequest)req, (AbortMultipartUploadResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CompleteMultipartUpload

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, AmazonServiceCallback<CompleteMultipartUploadRequest, CompleteMultipartUploadResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("CompleteMultipartUpload is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CompleteMultipartUploadRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CompleteMultipartUploadRequest,CompleteMultipartUploadResponse> responseObject 
                            = new AmazonServiceResult<CompleteMultipartUploadRequest,CompleteMultipartUploadResponse>((CompleteMultipartUploadRequest)req, (CompleteMultipartUploadResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CopyObject

        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// 
        ///  <note> 
        /// <para>
        /// You can store individual objects of up to 5 TB in Amazon S3. You create a copy of
        /// your object up to 5 GB in size in a single atomic operation using this API. However,
        /// for copying an object greater than 5 GB, you must use the multipart upload Upload
        /// Part - Copy API. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjctsUsingRESTMPUapi.html">Copy
        /// Object Using the REST Multipart Upload API</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When copying an object, you can preserve all metadata (default) or specify new metadata.
        /// However, the ACL is not preserved and is set to private for the user making the request.
        /// To override the default ACL setting, specify a new ACL when generating a copy request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon S3 transfer acceleration does not support cross-region copies. If you request
        /// a cross-region copy using a transfer acceleration endpoint, you get a 400 <code>Bad
        /// Request</code> error. For more information about transfer acceleration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/transfer-acceleration.html">Transfer
        /// Acceleration</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// All copy requests must be authenticated. Additionally, you must have <i>read</i> access
        /// to the source object and <i>write</i> access to the destination bucket. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">REST
        /// Authentication</a>. Both the Region that you want to copy the object from and the
        /// Region that you want to copy the object to must be enabled for your account.
        /// </para>
        ///  
        /// <para>
        /// To only copy an object under certain conditions, such as whether the <code>Etag</code>
        /// matches or whether the object was modified before or after a specified date, use the
        /// request parameters <code>x-amz-copy-source-if-match</code>, <code>x-amz-copy-source-if-none-match</code>,
        /// <code>x-amz-copy-source-if-unmodified-since</code>, or <code> x-amz-copy-source-if-modified-since</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// All headers with the <code>x-amz-</code> prefix, including <code>x-amz-copy-source</code>,
        /// must be signed.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use this operation to change the storage class of an object that is already
        /// stored in Amazon S3 using the <code>StorageClass</code> parameter. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html">Storage
        /// Classes</a>.
        /// </para>
        ///  
        /// <para>
        /// The source object that you are copying can be encrypted or unencrypted. If the source
        /// object is encrypted, it can be encrypted by server-side encryption using AWS managed
        /// encryption keys or by using a customer-provided encryption key. When copying an object,
        /// you can request that Amazon S3 encrypt the target object by using either the AWS managed
        /// encryption keys or by using your own encryption key. You can do this regardless of
        /// the form of server-side encryption that was used to encrypt the source, or even if
        /// the source object was not encrypted. For more information about server-side encryption,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingServerSideEncryption.html">Using
        /// Server-Side Encryption</a>.
        /// </para>
        ///  
        /// <para>
        /// A copy request might return an error when Amazon S3 receives the copy request or while
        /// Amazon S3 is copying the files. If the error occurs before the copy operation starts,
        /// you receive a standard Amazon S3 error. If the error occurs during the copy operation,
        /// the error response is embedded in the <code>200 OK</code> response. This means that
        /// a <code>200 OK</code> response can contain either a success or an error. Design your
        /// application to parse the contents of the response and handle it appropriately.
        /// </para>
        ///  
        /// <para>
        /// If the copy is successful, you receive a response with information about the copied
        /// object.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the request is an HTTP 1.1 request, the response is chunk encoded. If it were not,
        /// it would not contain the content-length, and you would need to read the entire body.
        /// </para>
        ///  </note> 
        /// <para>
        /// Consider the following when using request headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Consideration 1 – If both the <code>x-amz-copy-source-if-match</code> and <code>x-amz-copy-source-if-unmodified-since</code>
        /// headers are present in the request and evaluate as follows, Amazon S3 returns 200
        /// OK and copies the data:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-match</code> condition evaluates to true
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-unmodified-since</code> condition evaluates to false
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  Consideration 2 – If both of the <code>x-amz-copy-source-if-none-match</code> and
        /// <code>x-amz-copy-source-if-modified-since</code> headers are present in the request
        /// and evaluate as follows, Amazon S3 returns the <code>412 Precondition Failed</code>
        /// response code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-none-match</code> condition evaluates to false
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-modified-since</code> condition evaluates to true
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The copy request charge is based on the storage class and Region you specify for the
        /// destination object. For pricing information, see <a href="https://aws.amazon.com/s3/pricing/">Amazon
        /// S3 Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// Following are other considerations when using <code>CopyObject</code>:
        /// </para>
        ///  <dl> <dt>Versioning</dt> <dd> 
        /// <para>
        /// By default, <code>x-amz-copy-source</code> identifies the current version of an object
        /// to copy. (If the current version is a delete marker, Amazon S3 behaves as if the object
        /// was deleted.) To copy a different version, use the <code>versionId</code> subresource.
        /// </para>
        ///  
        /// <para>
        /// If you enable versioning on the target bucket, Amazon S3 generates a unique version
        /// ID for the object being copied. This version ID is different from the version ID of
        /// the source object. Amazon S3 returns the version ID of the copied object in the <code>x-amz-version-id</code>
        /// response header in the response.
        /// </para>
        ///  
        /// <para>
        /// If you do not enable versioning or suspend it on the target bucket, the version ID
        /// that Amazon S3 generates is always null.
        /// </para>
        ///  
        /// <para>
        /// If the source object's storage class is GLACIER, you must restore a copy of this object
        /// before you can use it as a source object for the copy operation. For more information,
        /// see .
        /// </para>
        ///  </dd> <dt>Access Permissions</dt> <dd> 
        /// <para>
        /// When copying an object, you can optionally specify the accounts or groups that should
        /// be granted specific permissions on the new object. There are two ways to grant the
        /// permissions using the request headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL with the <code>x-amz-acl</code> request header. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly with the <code>x-amz-grant-read</code>, <code>x-amz-grant-read-acp</code>,
        /// <code>x-amz-grant-write-acp</code>, and <code>x-amz-grant-full-control</code> headers.
        /// These parameters map to the set of permissions that Amazon S3 supports in an ACL.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use either a canned ACL or specify access permissions explicitly. You cannot
        /// do both.
        /// </para>
        ///  </dd> <dt>Server-Side- Encryption-Specific Request Headers</dt> <dd> 
        /// <para>
        /// To encrypt the target object, you must provide the appropriate encryption-related
        /// request headers. The one you use depends on whether you want to use AWS managed encryption
        /// keys or provide your own encryption key. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To encrypt the target object using server-side encryption with an AWS managed encryption
        /// key, provide the following request headers, as appropriate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-server-side​-encryption</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-server-side-encryption-aws-kms-key-id</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-server-side-encryption-context</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you specify <code>x-amz-server-side-encryption:aws:kms</code> but don't provide
        /// <code>x-amz-server-side- encryption-aws-kms-key-id</code>, Amazon S3 uses the AWS
        /// managed customer master key (CMK) in AWS KMS to protect the data.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// All GET and PUT requests for an object protected by AWS KMS fail if you don't make
        /// them with SSL or by using SigV4.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about server-side encryption with CMKs stored in AWS KMS (SSE-KMS),
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">Protecting
        /// Data Using Server-Side Encryption with CMKs stored in KMS</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To encrypt the target object using server-side encryption with an encryption key that
        /// you provide, use the following headers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If the source object is encrypted using server-side encryption with customer-provided
        /// encryption keys, you must use the following headers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-copy-source​-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-copy-source​-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-copy-source-​server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about server-side encryption with CMKs stored in AWS KMS (SSE-KMS),
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">Protecting
        /// Data Using Server-Side Encryption with CMKs stored in Amazon KMS</a>.
        /// </para>
        ///  </li> </ul> </dd> <dt>Access-Control-List (ACL)-Specific Request Headers</dt> <dd>
        /// 
        /// <para>
        /// You also can use the following access control–related headers with this operation.
        /// By default, all objects are private. Only the owner has full access control. When
        /// adding a new object, you can grant permissions to individual AWS accounts or to predefined
        /// groups defined by Amazon S3. These permissions are then added to the access control
        /// list (ACL) on the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>. With this operation, you can grant access permissions using one of the following
        /// two methods:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL (<code>x-amz-acl</code>) — Amazon S3 supports a set of predefined
        /// ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined set of grantees
        /// and permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly — To explicitly grant access permissions to
        /// specific AWS accounts or groups, use the following headers. Each header maps to specific
        /// permissions that Amazon S3 supports in an ACL. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>. In the header, you specify a list of grantees who
        /// get the specific permission. To grant permissions explicitly, use:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-grant-read
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-write
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-read-acp
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-write-acp
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-full-control
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You specify each grantee as a type=value pair, where the type is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>emailAddress</code> – if the value specified is the email address of an AWS
        /// account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>id</code> – if the value specified is the canonical user ID of an AWS account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>uri</code> – if you are granting permissions to a predefined group
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, the following <code>x-amz-grant-read</code> header grants the AWS accounts
        /// identified by email addresses permissions to read object data and its metadata:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-grant-read: emailAddress="xyz@amazon.com", emailAddress="abc@amazon.com"
        /// </code> 
        /// </para>
        ///  </li> </ul> </dd> </dl> 
        /// <para>
        /// The following operations are related to <code>CopyObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjectsExamples.html">Copying
        /// Objects</a>.
        /// </para>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="sourceBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        public virtual void CopyObjectAsync(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey,  AmazonServiceCallback<CopyObjectRequest, CopyObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new CopyObjectRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            CopyObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// 
        ///  <note> 
        /// <para>
        /// You can store individual objects of up to 5 TB in Amazon S3. You create a copy of
        /// your object up to 5 GB in size in a single atomic operation using this API. However,
        /// for copying an object greater than 5 GB, you must use the multipart upload Upload
        /// Part - Copy API. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjctsUsingRESTMPUapi.html">Copy
        /// Object Using the REST Multipart Upload API</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When copying an object, you can preserve all metadata (default) or specify new metadata.
        /// However, the ACL is not preserved and is set to private for the user making the request.
        /// To override the default ACL setting, specify a new ACL when generating a copy request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// Amazon S3 transfer acceleration does not support cross-region copies. If you request
        /// a cross-region copy using a transfer acceleration endpoint, you get a 400 <code>Bad
        /// Request</code> error. For more information about transfer acceleration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/transfer-acceleration.html">Transfer
        /// Acceleration</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// All copy requests must be authenticated. Additionally, you must have <i>read</i> access
        /// to the source object and <i>write</i> access to the destination bucket. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">REST
        /// Authentication</a>. Both the Region that you want to copy the object from and the
        /// Region that you want to copy the object to must be enabled for your account.
        /// </para>
        ///  
        /// <para>
        /// To only copy an object under certain conditions, such as whether the <code>Etag</code>
        /// matches or whether the object was modified before or after a specified date, use the
        /// request parameters <code>x-amz-copy-source-if-match</code>, <code>x-amz-copy-source-if-none-match</code>,
        /// <code>x-amz-copy-source-if-unmodified-since</code>, or <code> x-amz-copy-source-if-modified-since</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// All headers with the <code>x-amz-</code> prefix, including <code>x-amz-copy-source</code>,
        /// must be signed.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can use this operation to change the storage class of an object that is already
        /// stored in Amazon S3 using the <code>StorageClass</code> parameter. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html">Storage
        /// Classes</a>.
        /// </para>
        ///  
        /// <para>
        /// The source object that you are copying can be encrypted or unencrypted. If the source
        /// object is encrypted, it can be encrypted by server-side encryption using AWS managed
        /// encryption keys or by using a customer-provided encryption key. When copying an object,
        /// you can request that Amazon S3 encrypt the target object by using either the AWS managed
        /// encryption keys or by using your own encryption key. You can do this regardless of
        /// the form of server-side encryption that was used to encrypt the source, or even if
        /// the source object was not encrypted. For more information about server-side encryption,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingServerSideEncryption.html">Using
        /// Server-Side Encryption</a>.
        /// </para>
        ///  
        /// <para>
        /// A copy request might return an error when Amazon S3 receives the copy request or while
        /// Amazon S3 is copying the files. If the error occurs before the copy operation starts,
        /// you receive a standard Amazon S3 error. If the error occurs during the copy operation,
        /// the error response is embedded in the <code>200 OK</code> response. This means that
        /// a <code>200 OK</code> response can contain either a success or an error. Design your
        /// application to parse the contents of the response and handle it appropriately.
        /// </para>
        ///  
        /// <para>
        /// If the copy is successful, you receive a response with information about the copied
        /// object.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the request is an HTTP 1.1 request, the response is chunk encoded. If it were not,
        /// it would not contain the content-length, and you would need to read the entire body.
        /// </para>
        ///  </note> 
        /// <para>
        /// Consider the following when using request headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Consideration 1 – If both the <code>x-amz-copy-source-if-match</code> and <code>x-amz-copy-source-if-unmodified-since</code>
        /// headers are present in the request and evaluate as follows, Amazon S3 returns 200
        /// OK and copies the data:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-match</code> condition evaluates to true
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-unmodified-since</code> condition evaluates to false
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        ///  Consideration 2 – If both of the <code>x-amz-copy-source-if-none-match</code> and
        /// <code>x-amz-copy-source-if-modified-since</code> headers are present in the request
        /// and evaluate as follows, Amazon S3 returns the <code>412 Precondition Failed</code>
        /// response code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-none-match</code> condition evaluates to false
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-copy-source-if-modified-since</code> condition evaluates to true
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The copy request charge is based on the storage class and Region you specify for the
        /// destination object. For pricing information, see <a href="https://aws.amazon.com/s3/pricing/">Amazon
        /// S3 Pricing</a>.
        /// </para>
        ///  
        /// <para>
        /// Following are other considerations when using <code>CopyObject</code>:
        /// </para>
        ///  <dl> <dt>Versioning</dt> <dd> 
        /// <para>
        /// By default, <code>x-amz-copy-source</code> identifies the current version of an object
        /// to copy. (If the current version is a delete marker, Amazon S3 behaves as if the object
        /// was deleted.) To copy a different version, use the <code>versionId</code> subresource.
        /// </para>
        ///  
        /// <para>
        /// If you enable versioning on the target bucket, Amazon S3 generates a unique version
        /// ID for the object being copied. This version ID is different from the version ID of
        /// the source object. Amazon S3 returns the version ID of the copied object in the <code>x-amz-version-id</code>
        /// response header in the response.
        /// </para>
        ///  
        /// <para>
        /// If you do not enable versioning or suspend it on the target bucket, the version ID
        /// that Amazon S3 generates is always null.
        /// </para>
        ///  
        /// <para>
        /// If the source object's storage class is GLACIER, you must restore a copy of this object
        /// before you can use it as a source object for the copy operation. For more information,
        /// see .
        /// </para>
        ///  </dd> <dt>Access Permissions</dt> <dd> 
        /// <para>
        /// When copying an object, you can optionally specify the accounts or groups that should
        /// be granted specific permissions on the new object. There are two ways to grant the
        /// permissions using the request headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL with the <code>x-amz-acl</code> request header. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly with the <code>x-amz-grant-read</code>, <code>x-amz-grant-read-acp</code>,
        /// <code>x-amz-grant-write-acp</code>, and <code>x-amz-grant-full-control</code> headers.
        /// These parameters map to the set of permissions that Amazon S3 supports in an ACL.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use either a canned ACL or specify access permissions explicitly. You cannot
        /// do both.
        /// </para>
        ///  </dd> <dt>Server-Side- Encryption-Specific Request Headers</dt> <dd> 
        /// <para>
        /// To encrypt the target object, you must provide the appropriate encryption-related
        /// request headers. The one you use depends on whether you want to use AWS managed encryption
        /// keys or provide your own encryption key. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To encrypt the target object using server-side encryption with an AWS managed encryption
        /// key, provide the following request headers, as appropriate.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>x-amz-server-side​-encryption</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-server-side-encryption-aws-kms-key-id</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>x-amz-server-side-encryption-context</code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you specify <code>x-amz-server-side-encryption:aws:kms</code> but don't provide
        /// <code>x-amz-server-side- encryption-aws-kms-key-id</code>, Amazon S3 uses the AWS
        /// managed customer master key (CMK) in AWS KMS to protect the data.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// All GET and PUT requests for an object protected by AWS KMS fail if you don't make
        /// them with SSL or by using SigV4.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about server-side encryption with CMKs stored in AWS KMS (SSE-KMS),
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">Protecting
        /// Data Using Server-Side Encryption with CMKs stored in KMS</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To encrypt the target object using server-side encryption with an encryption key that
        /// you provide, use the following headers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// If the source object is encrypted using server-side encryption with customer-provided
        /// encryption keys, you must use the following headers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-copy-source​-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-copy-source​-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-copy-source-​server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about server-side encryption with CMKs stored in AWS KMS (SSE-KMS),
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">Protecting
        /// Data Using Server-Side Encryption with CMKs stored in Amazon KMS</a>.
        /// </para>
        ///  </li> </ul> </dd> <dt>Access-Control-List (ACL)-Specific Request Headers</dt> <dd>
        /// 
        /// <para>
        /// You also can use the following access control–related headers with this operation.
        /// By default, all objects are private. Only the owner has full access control. When
        /// adding a new object, you can grant permissions to individual AWS accounts or to predefined
        /// groups defined by Amazon S3. These permissions are then added to the access control
        /// list (ACL) on the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>. With this operation, you can grant access permissions using one of the following
        /// two methods:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL (<code>x-amz-acl</code>) — Amazon S3 supports a set of predefined
        /// ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined set of grantees
        /// and permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly — To explicitly grant access permissions to
        /// specific AWS accounts or groups, use the following headers. Each header maps to specific
        /// permissions that Amazon S3 supports in an ACL. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>. In the header, you specify a list of grantees who
        /// get the specific permission. To grant permissions explicitly, use:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-grant-read
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-write
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-read-acp
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-write-acp
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-full-control
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You specify each grantee as a type=value pair, where the type is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>emailAddress</code> – if the value specified is the email address of an AWS
        /// account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>id</code> – if the value specified is the canonical user ID of an AWS account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>uri</code> – if you are granting permissions to a predefined group
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, the following <code>x-amz-grant-read</code> header grants the AWS accounts
        /// identified by email addresses permissions to read object data and its metadata:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-grant-read: emailAddress="xyz@amazon.com", emailAddress="abc@amazon.com"
        /// </code> 
        /// </para>
        ///  </li> </ul> </dd> </dl> 
        /// <para>
        /// The following operations are related to <code>CopyObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjectsExamples.html">Copying
        /// Objects</a>.
        /// </para>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="sourceBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceVersionId">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        public virtual void CopyObjectAsync(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey,  AmazonServiceCallback<CopyObjectRequest, CopyObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new CopyObjectRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.SourceVersionId = sourceVersionId;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            CopyObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyObject operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyObject operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void CopyObjectAsync(CopyObjectRequest request, AmazonServiceCallback<CopyObjectRequest, CopyObjectResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("CopyObject is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CopyObjectRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CopyObjectResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CopyObjectRequest,CopyObjectResponse> responseObject 
                            = new AmazonServiceResult<CopyObjectRequest,CopyObjectResponse>((CopyObjectRequest)req, (CopyObjectResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  CopyPart

        /// <summary>
        /// Uploads a part by copying data from an existing object as data source. You specify
        /// the data source by adding the request header <code>x-amz-copy-source</code> in your
        /// request and a byte range by adding the request header <code>x-amz-copy-source-range</code>
        /// in your request. 
        /// 
        ///  
        /// <para>
        /// The minimum allowable part size for a multipart upload is 5 MB. For more information
        /// about multipart upload limits, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/qfacts.html">Quick
        /// Facts</a> in the <i>Amazon Simple Storage Service Developer Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Instead of using an existing object as part data, you might use the <a>UploadPart</a>
        /// operation and provide data in your request.
        /// </para>
        ///  </note> 
        /// <para>
        /// You must initiate a multipart upload before you can upload any part. In response to
        /// your initiate request. Amazon S3 returns a unique identifier, the upload ID, that
        /// you must include in your upload part request.
        /// </para>
        ///  
        /// <para>
        /// For more information about using the <code>UploadPartCopy</code> operation, see the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For conceptual information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
        /// Objects Using Multipart Upload</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about permissions required to use the multipart upload API, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about copying objects using a single atomic operation vs. the multipart
        /// upload, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ObjectOperations.html">Operations
        /// on Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about using server-side encryption with customer-provided encryption
        /// keys with the UploadPartCopy operation, see <a>CopyObject</a> and <a>UploadPart</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note the following additional considerations about the request headers <code>x-amz-copy-source-if-match</code>,
        /// <code>x-amz-copy-source-if-none-match</code>, <code>x-amz-copy-source-if-unmodified-since</code>,
        /// and <code>x-amz-copy-source-if-modified-since</code>:
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Consideration 1</b> - If both of the <code>x-amz-copy-source-if-match</code> and
        /// <code>x-amz-copy-source-if-unmodified-since</code> headers are present in the request
        /// as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-match</code> condition evaluates to <code>true</code>,
        /// and;
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-unmodified-since</code> condition evaluates to <code>false</code>;
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 returns <code>200 OK</code> and copies the data. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Consideration 2</b> - If both of the <code>x-amz-copy-source-if-none-match</code>
        /// and <code>x-amz-copy-source-if-modified-since</code> headers are present in the request
        /// as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-none-match</code> condition evaluates to <code>false</code>,
        /// and;
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-modified-since</code> condition evaluates to <code>true</code>;
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 returns <code>412 Precondition Failed</code> response code. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Versioning</b> 
        /// </para>
        ///  
        /// <para>
        /// If your bucket has versioning enabled, you could have multiple versions of the same
        /// object. By default, <code>x-amz-copy-source</code> identifies the current version
        /// of the object to copy. If the current version is a delete marker and you don't specify
        /// a versionId in the <code>x-amz-copy-source</code>, Amazon S3 returns a 404 error,
        /// because the object does not exist. If you specify versionId in the <code>x-amz-copy-source</code>
        /// and the versionId is a delete marker, Amazon S3 returns an HTTP 400 error, because
        /// you are not allowed to specify a delete marker as a version for the <code>x-amz-copy-source</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify a specific version of the source object to copy by adding
        /// the <code>versionId</code> subresource as shown in the following example:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source: /bucket/object?versionId=version id</code> 
        /// </para>
        ///  <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: NoSuchUpload</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: The specified multipart upload does not exist. The upload ID might be invalid,
        /// or the multipart upload might have been aborted or completed.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 404 Not Found</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: InvalidRequest</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: The specified copy source is not supported as a byte-range copy source.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 400 Bad Request</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="sourceBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose part is being copied.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        public virtual void CopyPartAsync(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, string uploadId,  AmazonServiceCallback<CopyPartRequest, CopyPartResponse> callback, AsyncOptions options = null)
        {
            var request = new CopyPartRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            request.UploadId = uploadId;
            CopyPartAsync(request, callback, options);
        }


        /// <summary>
        /// Uploads a part by copying data from an existing object as data source. You specify
        /// the data source by adding the request header <code>x-amz-copy-source</code> in your
        /// request and a byte range by adding the request header <code>x-amz-copy-source-range</code>
        /// in your request. 
        /// 
        ///  
        /// <para>
        /// The minimum allowable part size for a multipart upload is 5 MB. For more information
        /// about multipart upload limits, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/qfacts.html">Quick
        /// Facts</a> in the <i>Amazon Simple Storage Service Developer Guide</i>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Instead of using an existing object as part data, you might use the <a>UploadPart</a>
        /// operation and provide data in your request.
        /// </para>
        ///  </note> 
        /// <para>
        /// You must initiate a multipart upload before you can upload any part. In response to
        /// your initiate request. Amazon S3 returns a unique identifier, the upload ID, that
        /// you must include in your upload part request.
        /// </para>
        ///  
        /// <para>
        /// For more information about using the <code>UploadPartCopy</code> operation, see the
        /// following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For conceptual information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
        /// Objects Using Multipart Upload</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about permissions required to use the multipart upload API, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about copying objects using a single atomic operation vs. the multipart
        /// upload, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ObjectOperations.html">Operations
        /// on Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For information about using server-side encryption with customer-provided encryption
        /// keys with the UploadPartCopy operation, see <a>CopyObject</a> and <a>UploadPart</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note the following additional considerations about the request headers <code>x-amz-copy-source-if-match</code>,
        /// <code>x-amz-copy-source-if-none-match</code>, <code>x-amz-copy-source-if-unmodified-since</code>,
        /// and <code>x-amz-copy-source-if-modified-since</code>:
        /// </para>
        ///  
        /// <para>
        ///  
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Consideration 1</b> - If both of the <code>x-amz-copy-source-if-match</code> and
        /// <code>x-amz-copy-source-if-unmodified-since</code> headers are present in the request
        /// as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-match</code> condition evaluates to <code>true</code>,
        /// and;
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-unmodified-since</code> condition evaluates to <code>false</code>;
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 returns <code>200 OK</code> and copies the data. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Consideration 2</b> - If both of the <code>x-amz-copy-source-if-none-match</code>
        /// and <code>x-amz-copy-source-if-modified-since</code> headers are present in the request
        /// as follows:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-none-match</code> condition evaluates to <code>false</code>,
        /// and;
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source-if-modified-since</code> condition evaluates to <code>true</code>;
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 returns <code>412 Precondition Failed</code> response code. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Versioning</b> 
        /// </para>
        ///  
        /// <para>
        /// If your bucket has versioning enabled, you could have multiple versions of the same
        /// object. By default, <code>x-amz-copy-source</code> identifies the current version
        /// of the object to copy. If the current version is a delete marker and you don't specify
        /// a versionId in the <code>x-amz-copy-source</code>, Amazon S3 returns a 404 error,
        /// because the object does not exist. If you specify versionId in the <code>x-amz-copy-source</code>
        /// and the versionId is a delete marker, Amazon S3 returns an HTTP 400 error, because
        /// you are not allowed to specify a delete marker as a version for the <code>x-amz-copy-source</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify a specific version of the source object to copy by adding
        /// the <code>versionId</code> subresource as shown in the following example:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-copy-source: /bucket/object?versionId=version id</code> 
        /// </para>
        ///  <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: NoSuchUpload</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: The specified multipart upload does not exist. The upload ID might be invalid,
        /// or the multipart upload might have been aborted or completed.</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 404 Not Found</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: InvalidRequest</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: The specified copy source is not supported as a byte-range copy source.</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 400 Bad Request</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="sourceBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceVersionId">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose part is being copied.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        public virtual void CopyPartAsync(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, string uploadId,  AmazonServiceCallback<CopyPartRequest, CopyPartResponse> callback, AsyncOptions options = null)
        {
            var request = new CopyPartRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.SourceVersionId = sourceVersionId;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            request.UploadId = uploadId;
            CopyPartAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyPart operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyPart operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void CopyPartAsync(CopyPartRequest request, AmazonServiceCallback<CopyPartRequest, CopyPartResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("CopyPart is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = CopyPartRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = CopyPartResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<CopyPartRequest,CopyPartResponse> responseObject 
                            = new AmazonServiceResult<CopyPartRequest,CopyPartResponse>((CopyPartRequest)req, (CopyPartResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteBucket

        /// <summary>
        /// Deletes the bucket. All objects (including all object versions and delete markers)
        /// in the bucket must be deleted before the bucket itself can be deleted.
        /// 
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">Specifies the bucket being deleted.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by S3.</returns>
        public virtual void DeleteBucketAsync(string bucketName,  AmazonServiceCallback<DeleteBucketRequest, DeleteBucketResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteBucketRequest();
            request.BucketName = bucketName;
            DeleteBucketAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucket operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeleteBucketAsync(DeleteBucketRequest request, AmazonServiceCallback<DeleteBucketRequest, DeleteBucketResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteBucket is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteBucketRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteBucketResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteBucketRequest,DeleteBucketResponse> responseObject 
                            = new AmazonServiceResult<DeleteBucketRequest,DeleteBucketResponse>((DeleteBucketRequest)req, (DeleteBucketResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteBucketAnalyticsConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketAnalyticsConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketAnalyticsConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeleteBucketAnalyticsConfigurationAsync(DeleteBucketAnalyticsConfigurationRequest request, AmazonServiceCallback<DeleteBucketAnalyticsConfigurationRequest, DeleteBucketAnalyticsConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteBucketAnalyticsConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteBucketAnalyticsConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteBucketAnalyticsConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteBucketAnalyticsConfigurationRequest,DeleteBucketAnalyticsConfigurationResponse> responseObject 
                            = new AmazonServiceResult<DeleteBucketAnalyticsConfigurationRequest,DeleteBucketAnalyticsConfigurationResponse>((DeleteBucketAnalyticsConfigurationRequest)req, (DeleteBucketAnalyticsConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteBucketEncryption

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketEncryption operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketEncryption operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeleteBucketEncryptionAsync(DeleteBucketEncryptionRequest request, AmazonServiceCallback<DeleteBucketEncryptionRequest, DeleteBucketEncryptionResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteBucketEncryption is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteBucketEncryptionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteBucketEncryptionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteBucketEncryptionRequest,DeleteBucketEncryptionResponse> responseObject 
                            = new AmazonServiceResult<DeleteBucketEncryptionRequest,DeleteBucketEncryptionResponse>((DeleteBucketEncryptionRequest)req, (DeleteBucketEncryptionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteBucketInventoryConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketInventoryConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketInventoryConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeleteBucketInventoryConfigurationAsync(DeleteBucketInventoryConfigurationRequest request, AmazonServiceCallback<DeleteBucketInventoryConfigurationRequest, DeleteBucketInventoryConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteBucketInventoryConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteBucketInventoryConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteBucketInventoryConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteBucketInventoryConfigurationRequest,DeleteBucketInventoryConfigurationResponse> responseObject 
                            = new AmazonServiceResult<DeleteBucketInventoryConfigurationRequest,DeleteBucketInventoryConfigurationResponse>((DeleteBucketInventoryConfigurationRequest)req, (DeleteBucketInventoryConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteBucketMetricsConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketMetricsConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketMetricsConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeleteBucketMetricsConfigurationAsync(DeleteBucketMetricsConfigurationRequest request, AmazonServiceCallback<DeleteBucketMetricsConfigurationRequest, DeleteBucketMetricsConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteBucketMetricsConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteBucketMetricsConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteBucketMetricsConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteBucketMetricsConfigurationRequest,DeleteBucketMetricsConfigurationResponse> responseObject 
                            = new AmazonServiceResult<DeleteBucketMetricsConfigurationRequest,DeleteBucketMetricsConfigurationResponse>((DeleteBucketMetricsConfigurationRequest)req, (DeleteBucketMetricsConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteBucketPolicy

        /// <summary>
        /// This implementation of the DELETE operation uses the policy subresource to delete
        /// the policy of a specified bucket. If you are using an identity other than the root
        /// user of the AWS account that owns the bucket, the calling identity must have the <code>DeleteBucketPolicy</code>
        /// permissions on the specified bucket and belong to the bucket owner's account to use
        /// this operation. 
        /// 
        ///  
        /// <para>
        /// If you don't have <code>DeleteBucketPolicy</code> permissions, Amazon S3 returns a
        /// <code>403 Access Denied</code> error. If you have the correct permissions, but you're
        /// not using an identity that belongs to the bucket owner's account, Amazon S3 returns
        /// a <code>405 Method Not Allowed</code> error. 
        /// </para>
        ///  <important> 
        /// <para>
        /// As a security precaution, the root user of the AWS account that owns a bucket can
        /// always use this operation, even if the policy explicitly denies the root user the
        /// ability to perform this action.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href=" https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and UserPolicies</a>. 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketPolicy</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteObject</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The bucket name.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3.</returns>
        public virtual void DeleteBucketPolicyAsync(string bucketName,  AmazonServiceCallback<DeleteBucketPolicyRequest, DeleteBucketPolicyResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteBucketPolicyRequest();
            request.BucketName = bucketName;
            DeleteBucketPolicyAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketPolicy operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeleteBucketPolicyAsync(DeleteBucketPolicyRequest request, AmazonServiceCallback<DeleteBucketPolicyRequest, DeleteBucketPolicyResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteBucketPolicy is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteBucketPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteBucketPolicyRequest,DeleteBucketPolicyResponse> responseObject 
                            = new AmazonServiceResult<DeleteBucketPolicyRequest,DeleteBucketPolicyResponse>((DeleteBucketPolicyRequest)req, (DeleteBucketPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteBucketReplication

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketReplication operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketReplication operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeleteBucketReplicationAsync(DeleteBucketReplicationRequest request, AmazonServiceCallback<DeleteBucketReplicationRequest, DeleteBucketReplicationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteBucketReplication is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteBucketReplicationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteBucketReplicationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteBucketReplicationRequest,DeleteBucketReplicationResponse> responseObject 
                            = new AmazonServiceResult<DeleteBucketReplicationRequest,DeleteBucketReplicationResponse>((DeleteBucketReplicationRequest)req, (DeleteBucketReplicationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteBucketTagging

        /// <summary>
        /// Deletes the tags from the bucket.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:PutBucketTagging</code>
        /// action. By default, the bucket owner has this permission and can grant this permission
        /// to others. 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketTagging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketTagging</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketTagging</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The bucket that has the tag set to be removed.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketTagging service method, as returned by S3.</returns>
        public virtual void DeleteBucketTaggingAsync(string bucketName,  AmazonServiceCallback<DeleteBucketTaggingRequest, DeleteBucketTaggingResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteBucketTaggingRequest();
            request.BucketName = bucketName;
            DeleteBucketTaggingAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketTagging operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeleteBucketTaggingAsync(DeleteBucketTaggingRequest request, AmazonServiceCallback<DeleteBucketTaggingRequest, DeleteBucketTaggingResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteBucketTagging is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteBucketTaggingRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteBucketTaggingRequest,DeleteBucketTaggingResponse> responseObject 
                            = new AmazonServiceResult<DeleteBucketTaggingRequest,DeleteBucketTaggingResponse>((DeleteBucketTaggingRequest)req, (DeleteBucketTaggingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteBucketWebsite

        /// <summary>
        /// This operation removes the website configuration for a bucket. Amazon S3 returns a
        /// <code>200 OK</code> response upon successfully deleting a website configuration on
        /// the specified bucket. You will get a <code>200 OK</code> response if the website configuration
        /// you are trying to delete does not exist on the bucket. Amazon S3 returns a <code>404</code>
        /// response if the bucket specified in the request does not exist.
        /// 
        ///  
        /// <para>
        /// This DELETE operation requires the <code>S3:DeleteBucketWebsite</code> permission.
        /// By default, only the bucket owner can delete the website configuration attached to
        /// a bucket. However, bucket owners can grant other users permission to delete the website
        /// configuration by writing a bucket policy granting them the <code>S3:DeleteBucketWebsite</code>
        /// permission. 
        /// </para>
        ///  
        /// <para>
        /// For more information about hosting websites, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">Hosting
        /// Websites on Amazon S3</a>. 
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketWebsite</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketWebsite</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketWebsite</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The bucket name for which you want to remove the website configuration. </param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketWebsite service method, as returned by S3.</returns>
        public virtual void DeleteBucketWebsiteAsync(string bucketName,  AmazonServiceCallback<DeleteBucketWebsiteRequest, DeleteBucketWebsiteResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteBucketWebsiteRequest();
            request.BucketName = bucketName;
            DeleteBucketWebsiteAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketWebsite operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketWebsite operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeleteBucketWebsiteAsync(DeleteBucketWebsiteRequest request, AmazonServiceCallback<DeleteBucketWebsiteRequest, DeleteBucketWebsiteResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteBucketWebsite is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteBucketWebsiteRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteBucketWebsiteResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteBucketWebsiteRequest,DeleteBucketWebsiteResponse> responseObject 
                            = new AmazonServiceResult<DeleteBucketWebsiteRequest,DeleteBucketWebsiteResponse>((DeleteBucketWebsiteRequest)req, (DeleteBucketWebsiteResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteCORSConfiguration

        /// <summary>
        /// Deletes the <code>cors</code> configuration information set for the bucket.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:PutBucketCORS</code>
        /// action. The bucket owner has this permission by default and can grant this permission
        /// to others. 
        /// </para>
        ///  
        /// <para>
        /// For information about <code>cors</code>, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html">Enabling
        /// Cross-Origin Resource Sharing</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  <p class="title"> <b>Related Resources:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RESTOPTIONSobject</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">Specifies the bucket whose <code>cors</code> configuration is being deleted.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCORSConfiguration service method, as returned by S3.</returns>
        public virtual void DeleteCORSConfigurationAsync(string bucketName,  AmazonServiceCallback<DeleteCORSConfigurationRequest, DeleteCORSConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteCORSConfigurationRequest();
            request.BucketName = bucketName;
            DeleteCORSConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCORSConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCORSConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeleteCORSConfigurationAsync(DeleteCORSConfigurationRequest request, AmazonServiceCallback<DeleteCORSConfigurationRequest, DeleteCORSConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteCORSConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteCORSConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteCORSConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteCORSConfigurationRequest,DeleteCORSConfigurationResponse> responseObject 
                            = new AmazonServiceResult<DeleteCORSConfigurationRequest,DeleteCORSConfigurationResponse>((DeleteCORSConfigurationRequest)req, (DeleteCORSConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteLifecycleConfiguration

        /// <summary>
        /// Deletes the lifecycle configuration from the specified bucket. Amazon S3 removes all
        /// the lifecycle configuration rules in the lifecycle subresource associated with the
        /// bucket. Your objects never expire, and Amazon S3 no longer automatically deletes any
        /// objects on the basis of rules contained in the deleted lifecycle configuration.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:PutLifecycleConfiguration</code>
        /// action. By default, the bucket owner has this permission and the bucket owner can
        /// grant this permission to others.
        /// </para>
        ///  
        /// <para>
        /// There is usually some time lag before lifecycle configuration deletion is fully propagated
        /// to all the Amazon S3 systems.
        /// </para>
        ///  
        /// <para>
        /// For more information about the object expiration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/intro-lifecycle-rules.html#intro-lifecycle-rules-actions">Elements
        /// to Describe Lifecycle Actions</a>.
        /// </para>
        ///  
        /// <para>
        /// Related actions include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The bucket name of the lifecycle to delete.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual void DeleteLifecycleConfigurationAsync(string bucketName,  AmazonServiceCallback<DeleteLifecycleConfigurationRequest, DeleteLifecycleConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            DeleteLifecycleConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeleteLifecycleConfigurationAsync(DeleteLifecycleConfigurationRequest request, AmazonServiceCallback<DeleteLifecycleConfigurationRequest, DeleteLifecycleConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteLifecycleConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteLifecycleConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteLifecycleConfigurationRequest,DeleteLifecycleConfigurationResponse> responseObject 
                            = new AmazonServiceResult<DeleteLifecycleConfigurationRequest,DeleteLifecycleConfigurationResponse>((DeleteLifecycleConfigurationRequest)req, (DeleteLifecycleConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteObject

        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// 
        ///  
        /// <para>
        /// To remove a specific version, you must be the bucket owner and you must use the version
        /// Id subresource. Using this subresource permanently deletes the version. If the object
        /// deleted is a delete marker, Amazon S3 sets the response header, <code>x-amz-delete-marker</code>,
        /// to true. 
        /// </para>
        ///  
        /// <para>
        /// If the object you want to delete is in a bucket where the bucket versioning configuration
        /// is MFA Delete enabled, you must include the <code>x-amz-mfa</code> request header
        /// in the DELETE <code>versionId</code> request. Requests that include <code>x-amz-mfa</code>
        /// must use HTTPS. 
        /// </para>
        ///  
        /// <para>
        ///  For more information about MFA Delete, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMFADelete.html">Using
        /// MFA Delete</a>. To see sample requests that use versioning, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectDELETE.html#ExampleVersionObjectDelete">Sample
        /// Request</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can delete objects by explicitly calling the DELETE Object API or configure its
        /// lifecycle (<a>PutBucketLifecycle</a>) to enable Amazon S3 to remove them for you.
        /// If you want to block users or accounts from removing or deleting objects from your
        /// bucket, you must deny them the <code>s3:DeleteObject</code>, <code>s3:DeleteObjectVersion</code>,
        /// and <code>s3:PutLifeCycleConfiguration</code> actions. 
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>DeleteObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The bucket name of the bucket containing the object.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Key name of the object to delete.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        public virtual void DeleteObjectAsync(string bucketName, string key,  AmazonServiceCallback<DeleteObjectRequest, DeleteObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            DeleteObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// 
        ///  
        /// <para>
        /// To remove a specific version, you must be the bucket owner and you must use the version
        /// Id subresource. Using this subresource permanently deletes the version. If the object
        /// deleted is a delete marker, Amazon S3 sets the response header, <code>x-amz-delete-marker</code>,
        /// to true. 
        /// </para>
        ///  
        /// <para>
        /// If the object you want to delete is in a bucket where the bucket versioning configuration
        /// is MFA Delete enabled, you must include the <code>x-amz-mfa</code> request header
        /// in the DELETE <code>versionId</code> request. Requests that include <code>x-amz-mfa</code>
        /// must use HTTPS. 
        /// </para>
        ///  
        /// <para>
        ///  For more information about MFA Delete, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMFADelete.html">Using
        /// MFA Delete</a>. To see sample requests that use versioning, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTObjectDELETE.html#ExampleVersionObjectDelete">Sample
        /// Request</a>. 
        /// </para>
        ///  
        /// <para>
        /// You can delete objects by explicitly calling the DELETE Object API or configure its
        /// lifecycle (<a>PutBucketLifecycle</a>) to enable Amazon S3 to remove them for you.
        /// If you want to block users or accounts from removing or deleting objects from your
        /// bucket, you must deny them the <code>s3:DeleteObject</code>, <code>s3:DeleteObjectVersion</code>,
        /// and <code>s3:PutLifeCycleConfiguration</code> actions. 
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>DeleteObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The bucket name of the bucket containing the object.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Key name of the object to delete.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        public virtual void DeleteObjectAsync(string bucketName, string key, string versionId,  AmazonServiceCallback<DeleteObjectRequest, DeleteObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new DeleteObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            DeleteObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeleteObjectAsync(DeleteObjectRequest request, AmazonServiceCallback<DeleteObjectRequest, DeleteObjectResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteObject is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteObjectRequest,DeleteObjectResponse> responseObject 
                            = new AmazonServiceResult<DeleteObjectRequest,DeleteObjectResponse>((DeleteObjectRequest)req, (DeleteObjectResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteObjects

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjects operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeleteObjectsAsync(DeleteObjectsRequest request, AmazonServiceCallback<DeleteObjectsRequest, DeleteObjectsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteObjectsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteObjectsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteObjectsRequest,DeleteObjectsResponse> responseObject 
                            = new AmazonServiceResult<DeleteObjectsRequest,DeleteObjectsResponse>((DeleteObjectsRequest)req, (DeleteObjectsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeleteObjectTagging

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjectTagging operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjectTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeleteObjectTaggingAsync(DeleteObjectTaggingRequest request, AmazonServiceCallback<DeleteObjectTaggingRequest, DeleteObjectTaggingResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeleteObjectTagging is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeleteObjectTaggingRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeleteObjectTaggingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeleteObjectTaggingRequest,DeleteObjectTaggingResponse> responseObject 
                            = new AmazonServiceResult<DeleteObjectTaggingRequest,DeleteObjectTaggingResponse>((DeleteObjectTaggingRequest)req, (DeleteObjectTaggingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  DeletePublicAccessBlock

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePublicAccessBlock operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicAccessBlock operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void DeletePublicAccessBlockAsync(DeletePublicAccessBlockRequest request, AmazonServiceCallback<DeletePublicAccessBlockRequest, DeletePublicAccessBlockResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("DeletePublicAccessBlock is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = DeletePublicAccessBlockRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = DeletePublicAccessBlockResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<DeletePublicAccessBlockRequest,DeletePublicAccessBlockResponse> responseObject 
                            = new AmazonServiceResult<DeletePublicAccessBlockRequest,DeletePublicAccessBlockResponse>((DeletePublicAccessBlockRequest)req, (DeletePublicAccessBlockResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetACL

        /// <summary>
        /// This implementation of the <code>GET</code> operation uses the <code>acl</code> subresource
        /// to return the access control list (ACL) of a bucket. To use <code>GET</code> to return
        /// the ACL of the bucket, you must have <code>READ_ACP</code> access to the bucket. If
        /// <code>READ_ACP</code> permission is granted to the anonymous user, you can return
        /// the ACL of the bucket without using an authorization header.
        /// 
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">Specifies the S3 bucket whose ACL is being requested.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        public virtual void GetACLAsync(string bucketName,  AmazonServiceCallback<GetACLRequest, GetACLResponse> callback, AsyncOptions options = null)
        {
            var request = new GetACLRequest();
            request.BucketName = bucketName;
            GetACLAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetACL operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetACLAsync(GetACLRequest request, AmazonServiceCallback<GetACLRequest, GetACLResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetACLRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetACLResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetACLRequest,GetACLResponse> responseObject 
                            = new AmazonServiceResult<GetACLRequest,GetACLResponse>((GetACLRequest)req, (GetACLResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketAccelerateConfiguration

        /// <summary>
        /// This implementation of the GET operation uses the <code>accelerate</code> subresource
        /// to return the Transfer Acceleration state of a bucket, which is either <code>Enabled</code>
        /// or <code>Suspended</code>. Amazon S3 Transfer Acceleration is a bucket-level feature
        /// that enables you to perform faster data transfers to and from Amazon S3.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:GetAccelerateConfiguration</code>
        /// action. The bucket owner has this permission by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev//using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev//s3-access-control.html">Managing
        /// Access Permissions to your Amazon S3 Resources</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You set the Transfer Acceleration state of an existing bucket to <code>Enabled</code>
        /// or <code>Suspended</code> by using the <a>PutBucketAccelerateConfiguration</a> operation.
        /// 
        /// </para>
        ///  
        /// <para>
        /// A GET <code>accelerate</code> request does not return a state value for a bucket that
        /// has no transfer acceleration state. A bucket has no Transfer Acceleration state if
        /// a state has never been set on the bucket. 
        /// </para>
        ///  
        /// <para>
        /// For more information about transfer acceleration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev//transfer-acceleration.html">Transfer
        /// Acceleration</a> in the Amazon Simple Storage Service Developer Guide.
        /// </para>
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketAccelerateConfiguration</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">Name of the bucket for which the accelerate configuration is retrieved.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketAccelerateConfiguration service method, as returned by S3.</returns>
        public virtual void GetBucketAccelerateConfigurationAsync(string bucketName,  AmazonServiceCallback<GetBucketAccelerateConfigurationRequest, GetBucketAccelerateConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketAccelerateConfigurationRequest();
            request.BucketName = bucketName;
            GetBucketAccelerateConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketAccelerateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAccelerateConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketAccelerateConfigurationAsync(GetBucketAccelerateConfigurationRequest request, AmazonServiceCallback<GetBucketAccelerateConfigurationRequest, GetBucketAccelerateConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketAccelerateConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketAccelerateConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketAccelerateConfigurationRequest,GetBucketAccelerateConfigurationResponse> responseObject 
                            = new AmazonServiceResult<GetBucketAccelerateConfigurationRequest,GetBucketAccelerateConfigurationResponse>((GetBucketAccelerateConfigurationRequest)req, (GetBucketAccelerateConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketAnalyticsConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketAnalyticsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAnalyticsConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketAnalyticsConfigurationAsync(GetBucketAnalyticsConfigurationRequest request, AmazonServiceCallback<GetBucketAnalyticsConfigurationRequest, GetBucketAnalyticsConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketAnalyticsConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketAnalyticsConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketAnalyticsConfigurationRequest,GetBucketAnalyticsConfigurationResponse> responseObject 
                            = new AmazonServiceResult<GetBucketAnalyticsConfigurationRequest,GetBucketAnalyticsConfigurationResponse>((GetBucketAnalyticsConfigurationRequest)req, (GetBucketAnalyticsConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketEncryption

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketEncryption operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketEncryptionAsync(GetBucketEncryptionRequest request, AmazonServiceCallback<GetBucketEncryptionRequest, GetBucketEncryptionResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketEncryptionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketEncryptionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketEncryptionRequest,GetBucketEncryptionResponse> responseObject 
                            = new AmazonServiceResult<GetBucketEncryptionRequest,GetBucketEncryptionResponse>((GetBucketEncryptionRequest)req, (GetBucketEncryptionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketInventoryConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketInventoryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketInventoryConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketInventoryConfigurationAsync(GetBucketInventoryConfigurationRequest request, AmazonServiceCallback<GetBucketInventoryConfigurationRequest, GetBucketInventoryConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketInventoryConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketInventoryConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketInventoryConfigurationRequest,GetBucketInventoryConfigurationResponse> responseObject 
                            = new AmazonServiceResult<GetBucketInventoryConfigurationRequest,GetBucketInventoryConfigurationResponse>((GetBucketInventoryConfigurationRequest)req, (GetBucketInventoryConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketLocation

        /// <summary>
        /// Returns the Region the bucket resides in. You set the bucket's Region using the <code>LocationConstraint</code>
        /// request parameter in a <code>CreateBucket</code> request. For more information, see
        /// <a>CreateBucket</a>.
        /// 
        ///  
        /// <para>
        ///  To use this implementation of the operation, you must be the bucket owner.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketLocation</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket for which to get the location.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by S3.</returns>
        public virtual void GetBucketLocationAsync(string bucketName,  AmazonServiceCallback<GetBucketLocationRequest, GetBucketLocationResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketLocationRequest();
            request.BucketName = bucketName;
            GetBucketLocationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLocation operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketLocationAsync(GetBucketLocationRequest request, AmazonServiceCallback<GetBucketLocationRequest, GetBucketLocationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketLocationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketLocationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketLocationRequest,GetBucketLocationResponse> responseObject 
                            = new AmazonServiceResult<GetBucketLocationRequest,GetBucketLocationResponse>((GetBucketLocationRequest)req, (GetBucketLocationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketLogging

        /// <summary>
        /// Returns the logging status of a bucket and the permissions users have to view and
        /// modify that status. To use GET, you must be the bucket owner.
        /// 
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketLogging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketLogging</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name for which to get the logging information.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by S3.</returns>
        public virtual void GetBucketLoggingAsync(string bucketName,  AmazonServiceCallback<GetBucketLoggingRequest, GetBucketLoggingResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketLoggingRequest();
            request.BucketName = bucketName;
            GetBucketLoggingAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLogging operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketLoggingAsync(GetBucketLoggingRequest request, AmazonServiceCallback<GetBucketLoggingRequest, GetBucketLoggingResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketLoggingRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketLoggingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketLoggingRequest,GetBucketLoggingResponse> responseObject 
                            = new AmazonServiceResult<GetBucketLoggingRequest,GetBucketLoggingResponse>((GetBucketLoggingRequest)req, (GetBucketLoggingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketMetricsConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketMetricsConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketMetricsConfigurationAsync(GetBucketMetricsConfigurationRequest request, AmazonServiceCallback<GetBucketMetricsConfigurationRequest, GetBucketMetricsConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketMetricsConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketMetricsConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketMetricsConfigurationRequest,GetBucketMetricsConfigurationResponse> responseObject 
                            = new AmazonServiceResult<GetBucketMetricsConfigurationRequest,GetBucketMetricsConfigurationResponse>((GetBucketMetricsConfigurationRequest)req, (GetBucketMetricsConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketNotification

        /// <summary>
        /// Returns the notification configuration of a bucket.
        /// 
        ///  
        /// <para>
        /// If notifications are not enabled on the bucket, the operation returns an empty <code>NotificationConfiguration</code>
        /// element.
        /// </para>
        ///  
        /// <para>
        /// By default, you must be the bucket owner to read the notification configuration of
        /// a bucket. However, the bucket owner can use a bucket policy to grant permission to
        /// other users to read this configuration with the <code>s3:GetBucketNotification</code>
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting and reading the notification configuration on a
        /// bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Setting
        /// Up Notification of Bucket Events</a>. For more information about bucket policies,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>GetBucketNotification</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketNotification</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">Name of the bucket for which to get the notification configuration</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by S3.</returns>
        public virtual void GetBucketNotificationAsync(string bucketName,  AmazonServiceCallback<GetBucketNotificationRequest, GetBucketNotificationResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketNotificationRequest();
            request.BucketName = bucketName;
            GetBucketNotificationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketNotification operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketNotificationAsync(GetBucketNotificationRequest request, AmazonServiceCallback<GetBucketNotificationRequest, GetBucketNotificationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketNotificationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketNotificationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketNotificationRequest,GetBucketNotificationResponse> responseObject 
                            = new AmazonServiceResult<GetBucketNotificationRequest,GetBucketNotificationResponse>((GetBucketNotificationRequest)req, (GetBucketNotificationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketPolicy

        /// <summary>
        /// Returns the policy of a specified bucket. If you are using an identity other than
        /// the root user of the AWS account that owns the bucket, the calling identity must have
        /// the <code>GetBucketPolicy</code> permissions on the specified bucket and belong to
        /// the bucket owner's account in order to use this operation.
        /// 
        ///  
        /// <para>
        /// If you don't have <code>GetBucketPolicy</code> permissions, Amazon S3 returns a <code>403
        /// Access Denied</code> error. If you have the correct permissions, but you're not using
        /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>405
        /// Method Not Allowed</code> error.
        /// </para>
        ///  <important> 
        /// <para>
        /// As a security precaution, the root user of the AWS account that owns a bucket can
        /// always use this operation, even if the policy explicitly denies the root user the
        /// ability to perform this action.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>GetBucketPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name for which to get the bucket policy.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by S3.</returns>
        public virtual void GetBucketPolicyAsync(string bucketName,  AmazonServiceCallback<GetBucketPolicyRequest, GetBucketPolicyResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketPolicyRequest();
            request.BucketName = bucketName;
            GetBucketPolicyAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketPolicyAsync(GetBucketPolicyRequest request, AmazonServiceCallback<GetBucketPolicyRequest, GetBucketPolicyResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketPolicyRequest,GetBucketPolicyResponse> responseObject 
                            = new AmazonServiceResult<GetBucketPolicyRequest,GetBucketPolicyResponse>((GetBucketPolicyRequest)req, (GetBucketPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketPolicyStatus

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicyStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicyStatus operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketPolicyStatusAsync(GetBucketPolicyStatusRequest request, AmazonServiceCallback<GetBucketPolicyStatusRequest, GetBucketPolicyStatusResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketPolicyStatusRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketPolicyStatusResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketPolicyStatusRequest,GetBucketPolicyStatusResponse> responseObject 
                            = new AmazonServiceResult<GetBucketPolicyStatusRequest,GetBucketPolicyStatusResponse>((GetBucketPolicyStatusRequest)req, (GetBucketPolicyStatusResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketReplication

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketReplication operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketReplication operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketReplicationAsync(GetBucketReplicationRequest request, AmazonServiceCallback<GetBucketReplicationRequest, GetBucketReplicationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("GetBucketReplication is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketReplicationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketReplicationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketReplicationRequest,GetBucketReplicationResponse> responseObject 
                            = new AmazonServiceResult<GetBucketReplicationRequest,GetBucketReplicationResponse>((GetBucketReplicationRequest)req, (GetBucketReplicationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketRequestPayment

        /// <summary>
        /// Returns the request payment configuration of a bucket. To use this version of the
        /// operation, you must be the bucket owner. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html">Requester
        /// Pays Buckets</a>.
        /// 
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketRequestPayment</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListObjects</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket for which to get the payment request configuration</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by S3.</returns>
        public virtual void GetBucketRequestPaymentAsync(string bucketName,  AmazonServiceCallback<GetBucketRequestPaymentRequest, GetBucketRequestPaymentResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketRequestPaymentRequest();
            request.BucketName = bucketName;
            GetBucketRequestPaymentAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketRequestPayment operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketRequestPaymentAsync(GetBucketRequestPaymentRequest request, AmazonServiceCallback<GetBucketRequestPaymentRequest, GetBucketRequestPaymentResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketRequestPaymentRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketRequestPaymentResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketRequestPaymentRequest,GetBucketRequestPaymentResponse> responseObject 
                            = new AmazonServiceResult<GetBucketRequestPaymentRequest,GetBucketRequestPaymentResponse>((GetBucketRequestPaymentRequest)req, (GetBucketRequestPaymentResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketTagging

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketTaggingAsync(GetBucketTaggingRequest request, AmazonServiceCallback<GetBucketTaggingRequest, GetBucketTaggingResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketTaggingRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketTaggingRequest,GetBucketTaggingResponse> responseObject 
                            = new AmazonServiceResult<GetBucketTaggingRequest,GetBucketTaggingResponse>((GetBucketTaggingRequest)req, (GetBucketTaggingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketVersioning

        /// <summary>
        /// Returns the versioning state of a bucket.
        /// 
        ///  
        /// <para>
        /// To retrieve the versioning state of a bucket, you must be the bucket owner.
        /// </para>
        ///  
        /// <para>
        /// This implementation also returns the MFA Delete status of the versioning state. If
        /// the MFA Delete status is <code>enabled</code>, the bucket owner must use an authentication
        /// device to change the versioning state of the bucket.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketVersioning</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket for which to get the versioning information.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by S3.</returns>
        public virtual void GetBucketVersioningAsync(string bucketName,  AmazonServiceCallback<GetBucketVersioningRequest, GetBucketVersioningResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketVersioningRequest();
            request.BucketName = bucketName;
            GetBucketVersioningAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketVersioning operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketVersioningAsync(GetBucketVersioningRequest request, AmazonServiceCallback<GetBucketVersioningRequest, GetBucketVersioningResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketVersioningRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketVersioningRequest,GetBucketVersioningResponse> responseObject 
                            = new AmazonServiceResult<GetBucketVersioningRequest,GetBucketVersioningResponse>((GetBucketVersioningRequest)req, (GetBucketVersioningResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetBucketWebsite

        /// <summary>
        /// Returns the website configuration for a bucket. To host website on Amazon S3, you
        /// can configure a bucket as website by adding a website configuration. For more information
        /// about hosting websites, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">Hosting
        /// Websites on Amazon S3</a>. 
        /// 
        ///  
        /// <para>
        /// This GET operation requires the <code>S3:GetBucketWebsite</code> permission. By default,
        /// only the bucket owner can read the bucket website configuration. However, bucket owners
        /// can allow other users to read the website configuration by writing a bucket policy
        /// granting them the <code>S3:GetBucketWebsite</code> permission.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>DeleteBucketWebsite</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteBucketWebsite</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketWebsite</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name for which to get the website configuration.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by S3.</returns>
        public virtual void GetBucketWebsiteAsync(string bucketName,  AmazonServiceCallback<GetBucketWebsiteRequest, GetBucketWebsiteResponse> callback, AsyncOptions options = null)
        {
            var request = new GetBucketWebsiteRequest();
            request.BucketName = bucketName;
            GetBucketWebsiteAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketWebsite operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetBucketWebsiteAsync(GetBucketWebsiteRequest request, AmazonServiceCallback<GetBucketWebsiteRequest, GetBucketWebsiteResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetBucketWebsiteRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetBucketWebsiteResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetBucketWebsiteRequest,GetBucketWebsiteResponse> responseObject 
                            = new AmazonServiceResult<GetBucketWebsiteRequest,GetBucketWebsiteResponse>((GetBucketWebsiteRequest)req, (GetBucketWebsiteResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetCORSConfiguration

        /// <summary>
        /// Returns the cors configuration information set for the bucket.
        /// 
        ///  
        /// <para>
        ///  To use this operation, you must have permission to perform the s3:GetBucketCORS action.
        /// By default, the bucket owner has this permission and can grant it to others.
        /// </para>
        ///  
        /// <para>
        ///  For more information about cors, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html">
        /// Enabling Cross-Origin Resource Sharing</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetBucketCors</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketCors</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketCors</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name for which to get the cors configuration.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by S3.</returns>
        public virtual void GetCORSConfigurationAsync(string bucketName,  AmazonServiceCallback<GetCORSConfigurationRequest, GetCORSConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new GetCORSConfigurationRequest();
            request.BucketName = bucketName;
            GetCORSConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCORSConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetCORSConfigurationAsync(GetCORSConfigurationRequest request, AmazonServiceCallback<GetCORSConfigurationRequest, GetCORSConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetCORSConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetCORSConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetCORSConfigurationRequest,GetCORSConfigurationResponse> responseObject 
                            = new AmazonServiceResult<GetCORSConfigurationRequest,GetCORSConfigurationResponse>((GetCORSConfigurationRequest)req, (GetCORSConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetLifecycleConfiguration

        /// <summary>
        /// <note> 
        /// <para>
        /// Bucket lifecycle configuration now supports specifying a lifecycle rule using an object
        /// key name prefix, one or more object tags, or a combination of both. Accordingly, this
        /// section describes the latest API. The response describes the new filter element that
        /// you can use to specify a filter to select a subset of objects to which the rule applies.
        /// If you are still using previous version of the lifecycle configuration, it works.
        /// For the earlier API description, see <a>GetBucketLifecycle</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// Returns the lifecycle configuration information set on the bucket. For information
        /// about lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a>.
        /// </para>
        ///  
        /// <para>
        /// To use this operation, you must have permission to perform the <code>s3:GetLifecycleConfiguration</code>
        /// action. The bucket owner has this permission, by default. The bucket owner can grant
        /// this permission to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetBucketLifecycleConfiguration</code> has the following special error:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>NoSuchLifecycleConfiguration</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The lifecycle configuration does not exist.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// HTTP Status Code: 404 Not Found
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SOAP Fault Code Prefix: Client
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The following operations are related to <code>DeleteBucketMetricsConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketLifecycle</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutBucketLifecycle</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketLifecycle</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket for which to get the lifecycle information.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual void GetLifecycleConfigurationAsync(string bucketName,  AmazonServiceCallback<GetLifecycleConfigurationRequest, GetLifecycleConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new GetLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            GetLifecycleConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecycleConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetLifecycleConfigurationAsync(GetLifecycleConfigurationRequest request, AmazonServiceCallback<GetLifecycleConfigurationRequest, GetLifecycleConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetLifecycleConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetLifecycleConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetLifecycleConfigurationRequest,GetLifecycleConfigurationResponse> responseObject 
                            = new AmazonServiceResult<GetLifecycleConfigurationRequest,GetLifecycleConfigurationResponse>((GetLifecycleConfigurationRequest)req, (GetLifecycleConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetObject

        /// <summary>
        /// Retrieves objects from Amazon S3. To use <code>GET</code>, you must have <code>READ</code>
        /// access to the object. If you grant <code>READ</code> access to the anonymous user,
        /// you can return the object without using an authorization header.
        /// 
        ///  
        /// <para>
        /// An Amazon S3 bucket has no directory hierarchy such as you would find in a typical
        /// computer file system. You can, however, create a logical hierarchy by using object
        /// key names that imply a folder structure. For example, instead of naming an object
        /// <code>sample.jpg</code>, you can name it <code>photos/2006/February/sample.jpg</code>.
        /// </para>
        ///  
        /// <para>
        /// To get an object from such a logical hierarchy, specify the full key name for the
        /// object in the <code>GET</code> operation. For a virtual hosted-style request example,
        /// if you have the object <code>photos/2006/February/sample.jpg</code>, specify the resource
        /// as <code>/photos/2006/February/sample.jpg</code>. For a path-style request example,
        /// if you have the object <code>photos/2006/February/sample.jpg</code> in the bucket
        /// named <code>examplebucket</code>, specify the resource as <code>/examplebucket/photos/2006/February/sample.jpg</code>.
        /// For more information about request types, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html#VirtualHostingSpecifyBucket">HTTP
        /// Host Header Bucket Specification</a>.
        /// </para>
        ///  
        /// <para>
        /// To distribute large files to many people, you can save bandwidth costs by using BitTorrent.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3Torrent.html">Amazon
        /// S3 Torrent</a>. For more information about returning the ACL of an object, see <a>GetObjectAcl</a>.
        /// </para>
        ///  
        /// <para>
        /// If the object you are retrieving is stored in the GLACIER or DEEP_ARCHIVE storage
        /// classes, before you can retrieve the object you must first restore a copy using .
        /// Otherwise, this operation returns an <code>InvalidObjectStateError</code> error. For
        /// information about restoring archived objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
        /// Archived Objects</a>.
        /// </para>
        ///  
        /// <para>
        /// Encryption request headers, like <code>x-amz-server-side-encryption</code>, should
        /// not be sent for GET requests if your object uses server-side encryption with CMKs
        /// stored in AWS KMS (SSE-KMS) or server-side encryption with Amazon S3–managed encryption
        /// keys (SSE-S3). If your object does use these types of keys, you’ll get an HTTP 400
        /// BadRequest error.
        /// </para>
        ///  
        /// <para>
        /// If you encrypt an object by using server-side encryption with customer-provided encryption
        /// keys (SSE-C) when you store the object in Amazon S3, then when you GET the object,
        /// you must use the following headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
        /// Encryption (Using Customer-Provided Encryption Keys)</a>.
        /// </para>
        ///  
        /// <para>
        /// Assuming you have permission to read object tags (permission for the <code>s3:GetObjectVersionTagging</code>
        /// action), the response also returns the <code>x-amz-tagging-count</code> header that
        /// provides the count of number of tags associated with the object. You can use <a>GetObjectTagging</a>
        /// to retrieve the tag set associated with an object.
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// You need the <code>s3:GetObject</code> permission for this operation. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a>. If the object you request does not exist, the error Amazon
        /// S3 returns depends on whether you also have the <code>s3:ListBucket</code> permission.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have the <code>s3:ListBucket</code> permission on the bucket, Amazon S3 will
        /// return an HTTP status code 404 ("no such key") error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don’t have the <code>s3:ListBucket</code> permission, Amazon S3 will return
        /// an HTTP status code 403 ("access denied") error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Versioning</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, the GET operation returns the current version of an object. To return
        /// a different version, use the <code>versionId</code> subresource.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the current version of the object is a delete marker, Amazon S3 behaves as if the
        /// object was deleted and includes <code>x-amz-delete-marker: true</code> in the response.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about versioning, see <a>PutBucketVersioning</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Overriding Response Header Values</b> 
        /// </para>
        ///  
        /// <para>
        /// There are times when you want to override certain response header values in a GET
        /// response. For example, you might override the Content-Disposition response header
        /// value in your GET request.
        /// </para>
        ///  
        /// <para>
        /// You can override values for a set of response headers using the following query parameters.
        /// These response header values are sent only on a successful request, that is, when
        /// status code 200 OK is returned. The set of headers you can override using these parameters
        /// is a subset of the headers that Amazon S3 accepts when you create an object. The response
        /// headers that you can override for the GET response are <code>Content-Type</code>,
        /// <code>Content-Language</code>, <code>Expires</code>, <code>Cache-Control</code>, <code>Content-Disposition</code>,
        /// and <code>Content-Encoding</code>. To override these header values in the GET response,
        /// you use the following request parameters.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must sign the request, either using an Authorization header or a presigned URL,
        /// when using these parameters. They cannot be used with an unsigned (anonymous) request.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <code>response-content-type</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-language</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-expires</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-cache-control</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-disposition</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-encoding</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Additional Considerations about Request Headers</b> 
        /// </para>
        ///  
        /// <para>
        /// If both of the <code>If-Match</code> and <code>If-Unmodified-Since</code> headers
        /// are present in the request as follows: <code>If-Match</code> condition evaluates to
        /// <code>true</code>, and; <code>If-Unmodified-Since</code> condition evaluates to <code>false</code>;
        /// then, S3 returns 200 OK and the data requested. 
        /// </para>
        ///  
        /// <para>
        /// If both of the <code>If-None-Match</code> and <code>If-Modified-Since</code> headers
        /// are present in the request as follows:<code> If-None-Match</code> condition evaluates
        /// to <code>false</code>, and; <code>If-Modified-Since</code> condition evaluates to
        /// <code>true</code>; then, S3 returns 304 Not Modified response code.
        /// </para>
        ///  
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListBuckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObjectAcl</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name containing the object.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Key of the object to get.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        public virtual void GetObjectAsync(string bucketName, string key,  AmazonServiceCallback<GetObjectRequest, GetObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new GetObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            GetObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Retrieves objects from Amazon S3. To use <code>GET</code>, you must have <code>READ</code>
        /// access to the object. If you grant <code>READ</code> access to the anonymous user,
        /// you can return the object without using an authorization header.
        /// 
        ///  
        /// <para>
        /// An Amazon S3 bucket has no directory hierarchy such as you would find in a typical
        /// computer file system. You can, however, create a logical hierarchy by using object
        /// key names that imply a folder structure. For example, instead of naming an object
        /// <code>sample.jpg</code>, you can name it <code>photos/2006/February/sample.jpg</code>.
        /// </para>
        ///  
        /// <para>
        /// To get an object from such a logical hierarchy, specify the full key name for the
        /// object in the <code>GET</code> operation. For a virtual hosted-style request example,
        /// if you have the object <code>photos/2006/February/sample.jpg</code>, specify the resource
        /// as <code>/photos/2006/February/sample.jpg</code>. For a path-style request example,
        /// if you have the object <code>photos/2006/February/sample.jpg</code> in the bucket
        /// named <code>examplebucket</code>, specify the resource as <code>/examplebucket/photos/2006/February/sample.jpg</code>.
        /// For more information about request types, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html#VirtualHostingSpecifyBucket">HTTP
        /// Host Header Bucket Specification</a>.
        /// </para>
        ///  
        /// <para>
        /// To distribute large files to many people, you can save bandwidth costs by using BitTorrent.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3Torrent.html">Amazon
        /// S3 Torrent</a>. For more information about returning the ACL of an object, see <a>GetObjectAcl</a>.
        /// </para>
        ///  
        /// <para>
        /// If the object you are retrieving is stored in the GLACIER or DEEP_ARCHIVE storage
        /// classes, before you can retrieve the object you must first restore a copy using .
        /// Otherwise, this operation returns an <code>InvalidObjectStateError</code> error. For
        /// information about restoring archived objects, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
        /// Archived Objects</a>.
        /// </para>
        ///  
        /// <para>
        /// Encryption request headers, like <code>x-amz-server-side-encryption</code>, should
        /// not be sent for GET requests if your object uses server-side encryption with CMKs
        /// stored in AWS KMS (SSE-KMS) or server-side encryption with Amazon S3–managed encryption
        /// keys (SSE-S3). If your object does use these types of keys, you’ll get an HTTP 400
        /// BadRequest error.
        /// </para>
        ///  
        /// <para>
        /// If you encrypt an object by using server-side encryption with customer-provided encryption
        /// keys (SSE-C) when you store the object in Amazon S3, then when you GET the object,
        /// you must use the following headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
        /// Encryption (Using Customer-Provided Encryption Keys)</a>.
        /// </para>
        ///  
        /// <para>
        /// Assuming you have permission to read object tags (permission for the <code>s3:GetObjectVersionTagging</code>
        /// action), the response also returns the <code>x-amz-tagging-count</code> header that
        /// provides the count of number of tags associated with the object. You can use <a>GetObjectTagging</a>
        /// to retrieve the tag set associated with an object.
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// You need the <code>s3:GetObject</code> permission for this operation. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a>. If the object you request does not exist, the error Amazon
        /// S3 returns depends on whether you also have the <code>s3:ListBucket</code> permission.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have the <code>s3:ListBucket</code> permission on the bucket, Amazon S3 will
        /// return an HTTP status code 404 ("no such key") error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don’t have the <code>s3:ListBucket</code> permission, Amazon S3 will return
        /// an HTTP status code 403 ("access denied") error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Versioning</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, the GET operation returns the current version of an object. To return
        /// a different version, use the <code>versionId</code> subresource.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the current version of the object is a delete marker, Amazon S3 behaves as if the
        /// object was deleted and includes <code>x-amz-delete-marker: true</code> in the response.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about versioning, see <a>PutBucketVersioning</a>. 
        /// </para>
        ///  
        /// <para>
        ///  <b>Overriding Response Header Values</b> 
        /// </para>
        ///  
        /// <para>
        /// There are times when you want to override certain response header values in a GET
        /// response. For example, you might override the Content-Disposition response header
        /// value in your GET request.
        /// </para>
        ///  
        /// <para>
        /// You can override values for a set of response headers using the following query parameters.
        /// These response header values are sent only on a successful request, that is, when
        /// status code 200 OK is returned. The set of headers you can override using these parameters
        /// is a subset of the headers that Amazon S3 accepts when you create an object. The response
        /// headers that you can override for the GET response are <code>Content-Type</code>,
        /// <code>Content-Language</code>, <code>Expires</code>, <code>Cache-Control</code>, <code>Content-Disposition</code>,
        /// and <code>Content-Encoding</code>. To override these header values in the GET response,
        /// you use the following request parameters.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must sign the request, either using an Authorization header or a presigned URL,
        /// when using these parameters. They cannot be used with an unsigned (anonymous) request.
        /// </para>
        ///  </note> <ul> <li> 
        /// <para>
        ///  <code>response-content-type</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-language</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-expires</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-cache-control</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-disposition</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>response-content-encoding</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Additional Considerations about Request Headers</b> 
        /// </para>
        ///  
        /// <para>
        /// If both of the <code>If-Match</code> and <code>If-Unmodified-Since</code> headers
        /// are present in the request as follows: <code>If-Match</code> condition evaluates to
        /// <code>true</code>, and; <code>If-Unmodified-Since</code> condition evaluates to <code>false</code>;
        /// then, S3 returns 200 OK and the data requested. 
        /// </para>
        ///  
        /// <para>
        /// If both of the <code>If-None-Match</code> and <code>If-Modified-Since</code> headers
        /// are present in the request as follows:<code> If-None-Match</code> condition evaluates
        /// to <code>false</code>, and; <code>If-Modified-Since</code> condition evaluates to
        /// <code>true</code>; then, S3 returns 304 Not Modified response code.
        /// </para>
        ///  
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>GetObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListBuckets</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObjectAcl</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name containing the object.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Key of the object to get.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        public virtual void GetObjectAsync(string bucketName, string key, string versionId,  AmazonServiceCallback<GetObjectRequest, GetObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new GetObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            GetObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObject operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetObjectAsync(GetObjectRequest request, AmazonServiceCallback<GetObjectRequest, GetObjectResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetObjectRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetObjectResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetObjectRequest,GetObjectResponse> responseObject 
                            = new AmazonServiceResult<GetObjectRequest,GetObjectResponse>((GetObjectRequest)req, (GetObjectResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetObjectLegalHold

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectLegalHold operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectLegalHold operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetObjectLegalHoldAsync(GetObjectLegalHoldRequest request, AmazonServiceCallback<GetObjectLegalHoldRequest, GetObjectLegalHoldResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetObjectLegalHoldRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetObjectLegalHoldResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetObjectLegalHoldRequest,GetObjectLegalHoldResponse> responseObject 
                            = new AmazonServiceResult<GetObjectLegalHoldRequest,GetObjectLegalHoldResponse>((GetObjectLegalHoldRequest)req, (GetObjectLegalHoldResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetObjectLockConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectLockConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectLockConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetObjectLockConfigurationAsync(GetObjectLockConfigurationRequest request, AmazonServiceCallback<GetObjectLockConfigurationRequest, GetObjectLockConfigurationResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetObjectLockConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetObjectLockConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetObjectLockConfigurationRequest,GetObjectLockConfigurationResponse> responseObject 
                            = new AmazonServiceResult<GetObjectLockConfigurationRequest,GetObjectLockConfigurationResponse>((GetObjectLockConfigurationRequest)req, (GetObjectLockConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetObjectMetadata

        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// 
        ///  
        /// <para>
        /// A <code>HEAD</code> request has the same options as a <code>GET</code> operation on
        /// an object. The response is identical to the <code>GET</code> response except that
        /// there is no response body.
        /// </para>
        ///  
        /// <para>
        /// If you encrypt an object by using server-side encryption with customer-provided encryption
        /// keys (SSE-C) when you store the object in Amazon S3, then when you retrieve the metadata
        /// from the object, you must use the following headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
        /// Encryption (Using Customer-Provided Encryption Keys)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Encryption request headers, like <code>x-amz-server-side-encryption</code>, should
        /// not be sent for GET requests if your object uses server-side encryption with CMKs
        /// stored in AWS KMS (SSE-KMS) or server-side encryption with Amazon S3–managed encryption
        /// keys (SSE-S3). If your object does use these types of keys, you’ll get an HTTP 400
        /// BadRequest error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Request headers are limited to 8 KB in size. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTCommonRequestHeaders.html">Common
        /// Request Headers</a>.
        /// </para>
        ///  
        /// <para>
        /// Consider the following when using request headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Consideration 1 – If both of the <code>If-Match</code> and <code>If-Unmodified-Since</code>
        /// headers are present in the request as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>If-Match</code> condition evaluates to <code>true</code>, and;
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>If-Unmodified-Since</code> condition evaluates to <code>false</code>;
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Then Amazon S3 returns <code>200 OK</code> and the data requested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Consideration 2 – If both of the <code>If-None-Match</code> and <code>If-Modified-Since</code>
        /// headers are present in the request as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>If-None-Match</code> condition evaluates to <code>false</code>, and;
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>If-Modified-Since</code> condition evaluates to <code>true</code>;
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Then Amazon S3 returns the <code>304 Not Modified</code> response code.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// You need the <code>s3:GetObject</code> permission for this operation. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a>. If the object you request does not exist, the error Amazon
        /// S3 returns depends on whether you also have the s3:ListBucket permission.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have the <code>s3:ListBucket</code> permission on the bucket, Amazon S3 returns
        /// an HTTP status code 404 ("no such key") error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don’t have the <code>s3:ListBucket</code> permission, Amazon S3 returns an
        /// HTTP status code 403 ("access denied") error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following operation is related to <code>HeadObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The name of the bucket containing the object.</param>
        /// <param name="key">The object key.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        public virtual void GetObjectMetadataAsync(string bucketName, string key,  AmazonServiceCallback<GetObjectMetadataRequest, GetObjectMetadataResponse> callback, AsyncOptions options = null)
        {
            var request = new GetObjectMetadataRequest();
            request.BucketName = bucketName;
            request.Key = key;
            GetObjectMetadataAsync(request, callback, options);
        }


        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// 
        ///  
        /// <para>
        /// A <code>HEAD</code> request has the same options as a <code>GET</code> operation on
        /// an object. The response is identical to the <code>GET</code> response except that
        /// there is no response body.
        /// </para>
        ///  
        /// <para>
        /// If you encrypt an object by using server-side encryption with customer-provided encryption
        /// keys (SSE-C) when you store the object in Amazon S3, then when you retrieve the metadata
        /// from the object, you must use the following headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about SSE-C, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/ServerSideEncryptionCustomerKeys.html">Server-Side
        /// Encryption (Using Customer-Provided Encryption Keys)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Encryption request headers, like <code>x-amz-server-side-encryption</code>, should
        /// not be sent for GET requests if your object uses server-side encryption with CMKs
        /// stored in AWS KMS (SSE-KMS) or server-side encryption with Amazon S3–managed encryption
        /// keys (SSE-S3). If your object does use these types of keys, you’ll get an HTTP 400
        /// BadRequest error.
        /// </para>
        ///  </note> 
        /// <para>
        /// Request headers are limited to 8 KB in size. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/RESTCommonRequestHeaders.html">Common
        /// Request Headers</a>.
        /// </para>
        ///  
        /// <para>
        /// Consider the following when using request headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  Consideration 1 – If both of the <code>If-Match</code> and <code>If-Unmodified-Since</code>
        /// headers are present in the request as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>If-Match</code> condition evaluates to <code>true</code>, and;
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>If-Unmodified-Since</code> condition evaluates to <code>false</code>;
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Then Amazon S3 returns <code>200 OK</code> and the data requested.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Consideration 2 – If both of the <code>If-None-Match</code> and <code>If-Modified-Since</code>
        /// headers are present in the request as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>If-None-Match</code> condition evaluates to <code>false</code>, and;
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>If-Modified-Since</code> condition evaluates to <code>true</code>;
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Then Amazon S3 returns the <code>304 Not Modified</code> response code.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// You need the <code>s3:GetObject</code> permission for this operation. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html">Specifying
        /// Permissions in a Policy</a>. If the object you request does not exist, the error Amazon
        /// S3 returns depends on whether you also have the s3:ListBucket permission.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have the <code>s3:ListBucket</code> permission on the bucket, Amazon S3 returns
        /// an HTTP status code 404 ("no such key") error.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don’t have the <code>s3:ListBucket</code> permission, Amazon S3 returns an
        /// HTTP status code 403 ("access denied") error.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following operation is related to <code>HeadObject</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The name of the bucket containing the object.</param>
        /// <param name="key">The object key.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        public virtual void GetObjectMetadataAsync(string bucketName, string key, string versionId,  AmazonServiceCallback<GetObjectMetadataRequest, GetObjectMetadataResponse> callback, AsyncOptions options = null)
        {
            var request = new GetObjectMetadataRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            GetObjectMetadataAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectMetadata operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectMetadata operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetObjectMetadataAsync(GetObjectMetadataRequest request, AmazonServiceCallback<GetObjectMetadataRequest, GetObjectMetadataResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("GetObjectMetadata is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetObjectMetadataRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetObjectMetadataRequest,GetObjectMetadataResponse> responseObject 
                            = new AmazonServiceResult<GetObjectMetadataRequest,GetObjectMetadataResponse>((GetObjectMetadataRequest)req, (GetObjectMetadataResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetObjectRetention

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectRetention operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectRetention operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetObjectRetentionAsync(GetObjectRetentionRequest request, AmazonServiceCallback<GetObjectRetentionRequest, GetObjectRetentionResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetObjectRetentionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetObjectRetentionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetObjectRetentionRequest,GetObjectRetentionResponse> responseObject 
                            = new AmazonServiceResult<GetObjectRetentionRequest,GetObjectRetentionResponse>((GetObjectRetentionRequest)req, (GetObjectRetentionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetObjectTagging

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetObjectTaggingAsync(GetObjectTaggingRequest request, AmazonServiceCallback<GetObjectTaggingRequest, GetObjectTaggingResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetObjectTaggingRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetObjectTaggingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetObjectTaggingRequest,GetObjectTaggingResponse> responseObject 
                            = new AmazonServiceResult<GetObjectTaggingRequest,GetObjectTaggingResponse>((GetObjectTaggingRequest)req, (GetObjectTaggingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetObjectTorrent

        /// <summary>
        /// Return torrent files from a bucket. BitTorrent can save you bandwidth when you're
        /// distributing large files. For more information about BitTorrent, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3Torrent.html">Amazon
        /// S3 Torrent</a>.
        /// 
        ///  <note> 
        /// <para>
        /// You can get torrent only for objects that are less than 5 GB in size and that are
        /// not encrypted using server-side encryption with customer-provided encryption key.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use GET, you must have READ access to the object.
        /// </para>
        ///  
        /// <para>
        /// The following operation is related to <code>GetObjectTorrent</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket containing the object for which to get the torrent files.</param>
        /// <param name="key">The object key for which to get the information.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by S3.</returns>
        public virtual void GetObjectTorrentAsync(string bucketName, string key,  AmazonServiceCallback<GetObjectTorrentRequest, GetObjectTorrentResponse> callback, AsyncOptions options = null)
        {
            var request = new GetObjectTorrentRequest();
            request.BucketName = bucketName;
            request.Key = key;
            GetObjectTorrentAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectTorrent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTorrent operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetObjectTorrentAsync(GetObjectTorrentRequest request, AmazonServiceCallback<GetObjectTorrentRequest, GetObjectTorrentResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetObjectTorrentRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetObjectTorrentResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetObjectTorrentRequest,GetObjectTorrentResponse> responseObject 
                            = new AmazonServiceResult<GetObjectTorrentRequest,GetObjectTorrentResponse>((GetObjectTorrentRequest)req, (GetObjectTorrentResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  GetPublicAccessBlock

        /// <summary>
        /// Initiates the asynchronous execution of the GetPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPublicAccessBlock operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void GetPublicAccessBlockAsync(GetPublicAccessBlockRequest request, AmazonServiceCallback<GetPublicAccessBlockRequest, GetPublicAccessBlockResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = GetPublicAccessBlockRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = GetPublicAccessBlockResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<GetPublicAccessBlockRequest,GetPublicAccessBlockResponse> responseObject 
                            = new AmazonServiceResult<GetPublicAccessBlockRequest,GetPublicAccessBlockResponse>((GetPublicAccessBlockRequest)req, (GetPublicAccessBlockResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  HeadBucket

        /// <summary>
        /// Initiates the asynchronous execution of the HeadBucket operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HeadBucket operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        internal virtual void HeadBucketAsync(HeadBucketRequest request, AmazonServiceCallback<HeadBucketRequest, HeadBucketResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("HeadBucket is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = HeadBucketRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = HeadBucketResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<HeadBucketRequest,HeadBucketResponse> responseObject 
                            = new AmazonServiceResult<HeadBucketRequest,HeadBucketResponse>((HeadBucketRequest)req, (HeadBucketResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  InitiateMultipartUpload

        /// <summary>
        /// This operation initiates a multipart upload and returns an upload ID. This upload
        /// ID is used to associate all of the parts in the specific multipart upload. You specify
        /// this upload ID in each of your subsequent upload part requests (see <a>UploadPart</a>).
        /// You also include this upload ID in the final request to either complete or abort the
        /// multipart upload request.
        /// 
        ///  
        /// <para>
        /// For more information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html">Multipart
        /// Upload Overview</a>.
        /// </para>
        ///  
        /// <para>
        /// If you have configured a lifecycle rule to abort incomplete multipart uploads, the
        /// upload must complete within the number of days specified in the bucket lifecycle configuration.
        /// Otherwise, the incomplete multipart upload becomes eligible for an abort operation
        /// and Amazon S3 aborts the multipart upload. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html#mpu-abort-incomplete-mpu-lifecycle-config">Aborting
        /// Incomplete Multipart Uploads Using a Bucket Lifecycle Policy</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about the permissions required to use the multipart upload API, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// For request signing, multipart upload is just a series of regular requests. You initiate
        /// a multipart upload, send one or more requests to upload parts, and then complete the
        /// multipart upload process. You sign each request individually. There is nothing special
        /// about signing multipart upload requests. For more information about signing, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
        /// Requests (AWS Signature Version 4)</a>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  After you initiate a multipart upload and upload one or more parts, to stop being
        /// charged for storing the uploaded parts, you must either complete or abort the multipart
        /// upload. Amazon S3 frees up the space used to store the parts and stop charging you
        /// for storing them only after you either complete or abort a multipart upload. 
        /// </para>
        ///  </note> 
        /// <para>
        /// You can optionally request server-side encryption. For server-side encryption, Amazon
        /// S3 encrypts your data as it writes it to disks in its data centers and decrypts it
        /// when you access it. You can provide your own encryption key, or use AWS Key Management
        /// Service (AWS KMS) customer master keys (CMKs) or Amazon S3-managed encryption keys.
        /// If you choose to provide your own encryption key, the request headers you provide
        /// in <a>UploadPart</a>) and <a>UploadPartCopy</a>) requests must match the headers you
        /// used in the request to initiate the upload by using <code>CreateMultipartUpload</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To perform a multipart upload with encryption using an AWS KMS CMK, the requester
        /// must have permission to the <code>kms:Encrypt</code>, <code>kms:Decrypt</code>, <code>kms:ReEncrypt*</code>,
        /// <code>kms:GenerateDataKey*</code>, and <code>kms:DescribeKey</code> actions on the
        /// key. These permissions are required because Amazon S3 must decrypt and read data from
        /// the encrypted file parts before it completes the multipart upload.
        /// </para>
        ///  
        /// <para>
        /// If your AWS Identity and Access Management (IAM) user or role is in the same AWS account
        /// as the AWS KMS CMK, then you must have these permissions on the key policy. If your
        /// IAM user or role belongs to a different account than the key, then you must have the
        /// permissions on both the key policy and your IAM user or role.
        /// </para>
        ///  
        /// <para>
        ///  For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
        /// Data Using Server-Side Encryption</a>.
        /// </para>
        ///  <dl> <dt>Access Permissions</dt> <dd> 
        /// <para>
        /// When copying an object, you can optionally specify the accounts or groups that should
        /// be granted specific permissions on the new object. There are two ways to grant the
        /// permissions using the request headers:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL with the <code>x-amz-acl</code> request header. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly with the <code>x-amz-grant-read</code>, <code>x-amz-grant-read-acp</code>,
        /// <code>x-amz-grant-write-acp</code>, and <code>x-amz-grant-full-control</code> headers.
        /// These parameters map to the set of permissions that Amazon S3 supports in an ACL.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can use either a canned ACL or specify access permissions explicitly. You cannot
        /// do both.
        /// </para>
        ///  </dd> <dt>Server-Side- Encryption-Specific Request Headers</dt> <dd> 
        /// <para>
        /// You can optionally tell Amazon S3 to encrypt data at rest using server-side encryption.
        /// Server-side encryption is for data encryption at rest. Amazon S3 encrypts your data
        /// as it writes it to disks in its data centers and decrypts it when you access it. The
        /// option you use depends on whether you want to use AWS managed encryption keys or provide
        /// your own encryption key. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use encryption keys managed by Amazon S3 or customer master keys (CMKs) stored in
        /// AWS Key Management Service (AWS KMS) – If you want AWS to manage the keys used to
        /// encrypt data, specify the following headers in the request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side-encryption-aws-kms-key-id
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side-encryption-context
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you specify <code>x-amz-server-side-encryption:aws:kms</code>, but don't provide
        /// <code>x-amz-server-side- encryption-aws-kms-key-id</code>, Amazon S3 uses the AWS
        /// managed CMK in AWS KMS to protect the data.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// All GET and PUT requests for an object protected by AWS KMS fail if you don't make
        /// them with SSL or by using SigV4.
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about server-side encryption with CMKs stored in AWS KMS (SSE-KMS),
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">Protecting
        /// Data Using Server-Side Encryption with CMKs stored in AWS KMS</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use customer-provided encryption keys – If you want to manage your own encryption
        /// keys, provide all the following headers in the request.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-algorithm
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-server-side​-encryption​-customer-key-MD5
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about server-side encryption with CMKs stored in AWS KMS (SSE-KMS),
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">Protecting
        /// Data Using Server-Side Encryption with CMKs stored in AWS KMS</a>.
        /// </para>
        ///  </li> </ul> </dd> <dt>Access-Control-List (ACL)-Specific Request Headers</dt> <dd>
        /// 
        /// <para>
        /// You also can use the following access control–related headers with this operation.
        /// By default, all objects are private. Only the owner has full access control. When
        /// adding a new object, you can grant permissions to individual AWS accounts or to predefined
        /// groups defined by Amazon S3. These permissions are then added to the access control
        /// list (ACL) on the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>. With this operation, you can grant access permissions using one of the following
        /// two methods:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL (<code>x-amz-acl</code>) — Amazon S3 supports a set of predefined
        /// ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined set of grantees
        /// and permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly — To explicitly grant access permissions to
        /// specific AWS accounts or groups, use the following headers. Each header maps to specific
        /// permissions that Amazon S3 supports in an ACL. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>. In the header, you specify a list of grantees who
        /// get the specific permission. To grant permissions explicitly, use:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// x-amz-grant-read
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-write
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-read-acp
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-write-acp
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// x-amz-grant-full-control
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You specify each grantee as a type=value pair, where the type is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>emailAddress</code> – if the value specified is the email address of an AWS
        /// account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>id</code> – if the value specified is the canonical user ID of an AWS account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>uri</code> – if you are granting permissions to a predefined group
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, the following <code>x-amz-grant-read</code> header grants the AWS accounts
        /// identified by email addresses permissions to read object data and its metadata:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-grant-read: emailAddress="xyz@amazon.com", emailAddress="abc@amazon.com"
        /// </code> 
        /// </para>
        ///  </li> </ul> </dd> </dl> 
        /// <para>
        /// The following operations are related to <code>CreateMultipartUpload</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The name of the bucket to which to initiate the upload</param>
        /// <param name="key">Object key for which the multipart upload is to be initiated.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by S3.</returns>
        public virtual void InitiateMultipartUploadAsync(string bucketName, string key,  AmazonServiceCallback<InitiateMultipartUploadRequest, InitiateMultipartUploadResponse> callback, AsyncOptions options = null)
        {
            var request = new InitiateMultipartUploadRequest();
            request.BucketName = bucketName;
            request.Key = key;
            InitiateMultipartUploadAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, AmazonServiceCallback<InitiateMultipartUploadRequest, InitiateMultipartUploadResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("InitiateMultipartUpload is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = InitiateMultipartUploadRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<InitiateMultipartUploadRequest,InitiateMultipartUploadResponse> responseObject 
                            = new AmazonServiceResult<InitiateMultipartUploadRequest,InitiateMultipartUploadResponse>((InitiateMultipartUploadRequest)req, (InitiateMultipartUploadResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListBucketAnalyticsConfigurations

        /// <summary>
        /// Initiates the asynchronous execution of the ListBucketAnalyticsConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBucketAnalyticsConfigurations operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void ListBucketAnalyticsConfigurationsAsync(ListBucketAnalyticsConfigurationsRequest request, AmazonServiceCallback<ListBucketAnalyticsConfigurationsRequest, ListBucketAnalyticsConfigurationsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListBucketAnalyticsConfigurationsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListBucketAnalyticsConfigurationsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListBucketAnalyticsConfigurationsRequest,ListBucketAnalyticsConfigurationsResponse> responseObject 
                            = new AmazonServiceResult<ListBucketAnalyticsConfigurationsRequest,ListBucketAnalyticsConfigurationsResponse>((ListBucketAnalyticsConfigurationsRequest)req, (ListBucketAnalyticsConfigurationsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListBucketInventoryConfigurations

        /// <summary>
        /// Initiates the asynchronous execution of the ListBucketInventoryConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBucketInventoryConfigurations operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void ListBucketInventoryConfigurationsAsync(ListBucketInventoryConfigurationsRequest request, AmazonServiceCallback<ListBucketInventoryConfigurationsRequest, ListBucketInventoryConfigurationsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListBucketInventoryConfigurationsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListBucketInventoryConfigurationsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListBucketInventoryConfigurationsRequest,ListBucketInventoryConfigurationsResponse> responseObject 
                            = new AmazonServiceResult<ListBucketInventoryConfigurationsRequest,ListBucketInventoryConfigurationsResponse>((ListBucketInventoryConfigurationsRequest)req, (ListBucketInventoryConfigurationsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListBucketMetricsConfigurations

        /// <summary>
        /// Initiates the asynchronous execution of the ListBucketMetricsConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBucketMetricsConfigurations operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void ListBucketMetricsConfigurationsAsync(ListBucketMetricsConfigurationsRequest request, AmazonServiceCallback<ListBucketMetricsConfigurationsRequest, ListBucketMetricsConfigurationsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListBucketMetricsConfigurationsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListBucketMetricsConfigurationsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListBucketMetricsConfigurationsRequest,ListBucketMetricsConfigurationsResponse> responseObject 
                            = new AmazonServiceResult<ListBucketMetricsConfigurationsRequest,ListBucketMetricsConfigurationsResponse>((ListBucketMetricsConfigurationsRequest)req, (ListBucketMetricsConfigurationsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListBuckets

        /// <summary>
        /// Returns a list of all buckets owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
         
         /// <param name="options">
         ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
         ///     procedure using the AsyncState property.
         /// </param>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by S3.</returns>
        public virtual void ListBucketsAsync(AmazonServiceCallback<ListBucketsRequest, ListBucketsResponse> callback, AsyncOptions options = null)
        {
            ListBucketsAsync(new ListBucketsRequest(), callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListBuckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuckets operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void ListBucketsAsync(ListBucketsRequest request, AmazonServiceCallback<ListBucketsRequest, ListBucketsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListBucketsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListBucketsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListBucketsRequest,ListBucketsResponse> responseObject 
                            = new AmazonServiceResult<ListBucketsRequest,ListBucketsResponse>((ListBucketsRequest)req, (ListBucketsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListMultipartUploads

        /// <summary>
        /// This operation lists in-progress multipart uploads. An in-progress multipart upload
        /// is a multipart upload that has been initiated using the Initiate Multipart Upload
        /// request, but has not yet been completed or aborted.
        /// 
        ///  
        /// <para>
        /// This operation returns at most 1,000 multipart uploads in the response. 1,000 multipart
        /// uploads is the maximum number of uploads a response can include, which is also the
        /// default value. You can further limit the number of uploads in a response by specifying
        /// the <code>max-uploads</code> parameter in the response. If additional multipart uploads
        /// satisfy the list criteria, the response will contain an <code>IsTruncated</code> element
        /// with the value true. To list the additional multipart uploads, use the <code>key-marker</code>
        /// and <code>upload-id-marker</code> request parameters.
        /// </para>
        ///  
        /// <para>
        /// In the response, the uploads are sorted by key. If your application has initiated
        /// more than one multipart upload using the same object key, then uploads in the response
        /// are first sorted by key. Additionally, uploads are sorted in ascending order within
        /// each key by the upload initiation time.
        /// </para>
        ///  
        /// <para>
        /// For more information on multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
        /// Objects Using Multipart Upload</a>.
        /// </para>
        ///  
        /// <para>
        /// For information on permissions required to use the multipart upload API, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListMultipartUploads</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">Name of the bucket to which the multipart upload was initiated.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        public virtual void ListMultipartUploadsAsync(string bucketName,  AmazonServiceCallback<ListMultipartUploadsRequest, ListMultipartUploadsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListMultipartUploadsRequest();
            request.BucketName = bucketName;
            ListMultipartUploadsAsync(request, callback, options);
        }


        /// <summary>
        /// This operation lists in-progress multipart uploads. An in-progress multipart upload
        /// is a multipart upload that has been initiated using the Initiate Multipart Upload
        /// request, but has not yet been completed or aborted.
        /// 
        ///  
        /// <para>
        /// This operation returns at most 1,000 multipart uploads in the response. 1,000 multipart
        /// uploads is the maximum number of uploads a response can include, which is also the
        /// default value. You can further limit the number of uploads in a response by specifying
        /// the <code>max-uploads</code> parameter in the response. If additional multipart uploads
        /// satisfy the list criteria, the response will contain an <code>IsTruncated</code> element
        /// with the value true. To list the additional multipart uploads, use the <code>key-marker</code>
        /// and <code>upload-id-marker</code> request parameters.
        /// </para>
        ///  
        /// <para>
        /// In the response, the uploads are sorted by key. If your application has initiated
        /// more than one multipart upload using the same object key, then uploads in the response
        /// are first sorted by key. Additionally, uploads are sorted in ascending order within
        /// each key by the upload initiation time.
        /// </para>
        ///  
        /// <para>
        /// For more information on multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
        /// Objects Using Multipart Upload</a>.
        /// </para>
        ///  
        /// <para>
        /// For information on permissions required to use the multipart upload API, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListMultipartUploads</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListParts</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">Name of the bucket to which the multipart upload was initiated.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="prefix">Lists in-progress uploads only for those keys that begin with the specified prefix. You can use prefixes to separate a bucket into different grouping of keys. (You can think of using prefix to make groups in the same way you'd use a folder in a file system.)</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        public virtual void ListMultipartUploadsAsync(string bucketName, string prefix,  AmazonServiceCallback<ListMultipartUploadsRequest, ListMultipartUploadsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListMultipartUploadsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            ListMultipartUploadsAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void ListMultipartUploadsAsync(ListMultipartUploadsRequest request, AmazonServiceCallback<ListMultipartUploadsRequest, ListMultipartUploadsResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("ListMultipartUploads is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListMultipartUploadsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListMultipartUploadsRequest,ListMultipartUploadsResponse> responseObject 
                            = new AmazonServiceResult<ListMultipartUploadsRequest,ListMultipartUploadsResponse>((ListMultipartUploadsRequest)req, (ListMultipartUploadsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListObjects

        /// <summary>
        /// Returns some or all (up to 1,000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket. A
        /// 200 OK response can contain valid or invalid XML. Be sure to design your application
        /// to parse the contents of the response and handle it appropriately.
        /// 
        ///  <important> 
        /// <para>
        /// This API has been revised. We recommend that you use the newer version, <a>ListObjectsV2</a>,
        /// when developing applications. For backward compatibility, Amazon S3 continues to support
        /// <code>ListObjects</code>.
        /// </para>
        ///  </important> 
        /// <para>
        /// The following operations are related to <code>ListObjects</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListObjectsV2</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuckets</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket containing the objects.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        public virtual void ListObjectsAsync(string bucketName,  AmazonServiceCallback<ListObjectsRequest, ListObjectsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListObjectsRequest();
            request.BucketName = bucketName;
            ListObjectsAsync(request, callback, options);
        }


        /// <summary>
        /// Returns some or all (up to 1,000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket. A
        /// 200 OK response can contain valid or invalid XML. Be sure to design your application
        /// to parse the contents of the response and handle it appropriately.
        /// 
        ///  <important> 
        /// <para>
        /// This API has been revised. We recommend that you use the newer version, <a>ListObjectsV2</a>,
        /// when developing applications. For backward compatibility, Amazon S3 continues to support
        /// <code>ListObjects</code>.
        /// </para>
        ///  </important> 
        /// <para>
        /// The following operations are related to <code>ListObjects</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListObjectsV2</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListBuckets</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The name of the bucket containing the objects.</param>
        /// <param name="prefix">Limits the response to keys that begin with the specified prefix.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        public virtual void ListObjectsAsync(string bucketName, string prefix,  AmazonServiceCallback<ListObjectsRequest, ListObjectsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListObjectsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            ListObjectsAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjects operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void ListObjectsAsync(ListObjectsRequest request, AmazonServiceCallback<ListObjectsRequest, ListObjectsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListObjectsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListObjectsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListObjectsRequest,ListObjectsResponse> responseObject 
                            = new AmazonServiceResult<ListObjectsRequest,ListObjectsResponse>((ListObjectsRequest)req, (ListObjectsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListObjectsV2

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectsV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectsV2 operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void ListObjectsV2Async(ListObjectsV2Request request, AmazonServiceCallback<ListObjectsV2Request, ListObjectsV2Response> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListObjectsV2RequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListObjectsV2ResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListObjectsV2Request,ListObjectsV2Response> responseObject 
                            = new AmazonServiceResult<ListObjectsV2Request,ListObjectsV2Response>((ListObjectsV2Request)req, (ListObjectsV2Response)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListParts

        /// <summary>
        /// Lists the parts that have been uploaded for a specific multipart upload. This operation
        /// must include the upload ID, which you obtain by sending the initiate multipart upload
        /// request (see <a>CreateMultipartUpload</a>). This request returns a maximum of 1,000
        /// uploaded parts. The default number of parts returned is 1,000 parts. You can restrict
        /// the number of parts returned by specifying the <code>max-parts</code> request parameter.
        /// If your multipart upload consists of more than 1,000 parts, the response returns an
        /// <code>IsTruncated</code> field with the value of true, and a <code>NextPartNumberMarker</code>
        /// element. In subsequent <code>ListParts</code> requests you can include the part-number-marker
        /// query string parameter and set its value to the <code>NextPartNumberMarker</code>
        /// field value from the previous response.
        /// 
        ///  
        /// <para>
        /// For more information on multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/uploadobjusingmpu.html">Uploading
        /// Objects Using Multipart Upload</a>.
        /// </para>
        ///  
        /// <para>
        /// For information on permissions required to use the multipart upload API, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
        /// Upload API and Permissions</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListParts</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UploadPart</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>CompleteMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>AbortMultipartUpload</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListMultipartUploads</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">Name of the bucket to which the parts are being uploaded.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Object key for which the multipart upload was initiated.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose parts are being listed.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by S3.</returns>
        public virtual void ListPartsAsync(string bucketName, string key, string uploadId,  AmazonServiceCallback<ListPartsRequest, ListPartsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListPartsRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.UploadId = uploadId;
            ListPartsAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParts operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void ListPartsAsync(ListPartsRequest request, AmazonServiceCallback<ListPartsRequest, ListPartsResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("ListParts is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListPartsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListPartsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListPartsRequest,ListPartsResponse> responseObject 
                            = new AmazonServiceResult<ListPartsRequest,ListPartsResponse>((ListPartsRequest)req, (ListPartsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  ListVersions

        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket. You can also use
        /// request parameters as selection criteria to return metadata about a subset of all
        /// the object versions. 
        /// 
        ///  <note> 
        /// <para>
        ///  A 200 OK response can contain valid or invalid XML. Make sure to design your application
        /// to parse the contents of the response and handle it appropriately.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this operation, you must have READ access to the bucket.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListObjectVersions</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListObjectsV2</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name that contains the objects.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        public virtual void ListVersionsAsync(string bucketName,  AmazonServiceCallback<ListVersionsRequest, ListVersionsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListVersionsRequest();
            request.BucketName = bucketName;
            ListVersionsAsync(request, callback, options);
        }


        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket. You can also use
        /// request parameters as selection criteria to return metadata about a subset of all
        /// the object versions. 
        /// 
        ///  <note> 
        /// <para>
        ///  A 200 OK response can contain valid or invalid XML. Make sure to design your application
        /// to parse the contents of the response and handle it appropriately.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this operation, you must have READ access to the bucket.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>ListObjectVersions</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>ListObjectsV2</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteObject</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name that contains the objects.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="prefix">Use this parameter to select only those keys that begin with the specified prefix. You can use prefixes to separate a bucket into different groupings of keys. (You can think of using prefix to make groups in the same way you'd use a folder in a file system.) You can use prefix with delimiter to roll up numerous objects into a single result under CommonPrefixes. </param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        public virtual void ListVersionsAsync(string bucketName, string prefix,  AmazonServiceCallback<ListVersionsRequest, ListVersionsResponse> callback, AsyncOptions options = null)
        {
            var request = new ListVersionsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            ListVersionsAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersions operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void ListVersionsAsync(ListVersionsRequest request, AmazonServiceCallback<ListVersionsRequest, ListVersionsResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = ListVersionsRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = ListVersionsResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<ListVersionsRequest,ListVersionsResponse> responseObject 
                            = new AmazonServiceResult<ListVersionsRequest,ListVersionsResponse>((ListVersionsRequest)req, (ListVersionsResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutACL

        /// <summary>
        /// Initiates the asynchronous execution of the PutACL operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutACL operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutACLAsync(PutACLRequest request, AmazonServiceCallback<PutACLRequest, PutACLResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutACL is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutACLRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutACLResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutACLRequest,PutACLResponse> responseObject 
                            = new AmazonServiceResult<PutACLRequest,PutACLResponse>((PutACLRequest)req, (PutACLResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucket

        /// <summary>
        /// Creates a new bucket. To create a bucket, you must register with Amazon S3 and have
        /// a valid AWS Access Key ID to authenticate requests. Anonymous requests are never allowed
        /// to create buckets. By creating the bucket, you become the bucket owner.
        /// 
        ///  
        /// <para>
        /// Not every string is an acceptable bucket name. For information on bucket naming restrictions,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingBucket.html">Working
        /// with Amazon S3 Buckets</a>.
        /// </para>
        ///  
        /// <para>
        /// By default, the bucket is created in the US East (N. Virginia) Region. You can optionally
        /// specify a Region in the request body. You might choose a Region to optimize latency,
        /// minimize costs, or address regulatory requirements. For example, if you reside in
        /// Europe, you will probably find it advantageous to create buckets in the EU (Ireland)
        /// Region. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingBucket.html#access-bucket-intro">How
        /// to Select a Region for Your Buckets</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you send your create bucket request to the <code>s3.amazonaws.com</code> endpoint,
        /// the request goes to the us-east-1 Region. Accordingly, the signature calculations
        /// in Signature Version 4 must use us-east-1 as the Region, even if the location constraint
        /// in the request specifies another Region where the bucket is to be created. If you
        /// create a bucket in a Region other than US East (N. Virginia), your application must
        /// be able to handle 307 redirect. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html">Virtual
        /// Hosting of Buckets</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// When creating a bucket using this operation, you can optionally specify the accounts
        /// or groups that should be granted specific permissions on the bucket. There are two
        /// ways to grant the appropriate permissions using the request headers.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify a canned ACL using the <code>x-amz-acl</code> request header. Amazon S3 supports
        /// a set of predefined ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined
        /// set of grantees and permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify access permissions explicitly using the <code>x-amz-grant-read</code>, <code>x-amz-grant-write</code>,
        /// <code>x-amz-grant-read-acp</code>, <code>x-amz-grant-write-acp</code>, and <code>x-amz-grant-full-control</code>
        /// headers. These headers map to the set of permissions Amazon S3 supports in an ACL.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a>.
        /// </para>
        ///  
        /// <para>
        /// You specify each grantee as a type=value pair, where the type is one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>emailAddress</code> – if the value specified is the email address of an AWS
        /// account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>id</code> – if the value specified is the canonical user ID of an AWS account
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>uri</code> – if you are granting permissions to a predefined group
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For example, the following <code>x-amz-grant-read</code> header grants the AWS accounts
        /// identified by email addresses permissions to read object data and its metadata:
        /// </para>
        ///  
        /// <para>
        ///  <code>x-amz-grant-read: emailAddress="xyz@amazon.com", emailAddress="abc@amazon.com"
        /// </code> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// You can use either a canned ACL or specify access permissions explicitly. You cannot
        /// do both.
        /// </para>
        ///  </note> 
        /// <para>
        /// The following operations are related to <code>CreateBucket</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucket</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The name of the bucket to create.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by S3.</returns>
        public virtual void PutBucketAsync(string bucketName,  AmazonServiceCallback<PutBucketRequest, PutBucketResponse> callback, AsyncOptions options = null)
        {
            var request = new PutBucketRequest();
            request.BucketName = bucketName;
            PutBucketAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucket operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucket operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutBucketAsync(PutBucketRequest request, AmazonServiceCallback<PutBucketRequest, PutBucketResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucket is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutBucketRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutBucketResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketRequest,PutBucketResponse> responseObject 
                            = new AmazonServiceResult<PutBucketRequest,PutBucketResponse>((PutBucketRequest)req, (PutBucketResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketAccelerateConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketAccelerateConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAccelerateConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutBucketAccelerateConfigurationAsync(PutBucketAccelerateConfigurationRequest request, AmazonServiceCallback<PutBucketAccelerateConfigurationRequest, PutBucketAccelerateConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketAccelerateConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutBucketAccelerateConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutBucketAccelerateConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketAccelerateConfigurationRequest,PutBucketAccelerateConfigurationResponse> responseObject 
                            = new AmazonServiceResult<PutBucketAccelerateConfigurationRequest,PutBucketAccelerateConfigurationResponse>((PutBucketAccelerateConfigurationRequest)req, (PutBucketAccelerateConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketAnalyticsConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketAnalyticsConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAnalyticsConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutBucketAnalyticsConfigurationAsync(PutBucketAnalyticsConfigurationRequest request, AmazonServiceCallback<PutBucketAnalyticsConfigurationRequest, PutBucketAnalyticsConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketAnalyticsConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutBucketAnalyticsConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutBucketAnalyticsConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketAnalyticsConfigurationRequest,PutBucketAnalyticsConfigurationResponse> responseObject 
                            = new AmazonServiceResult<PutBucketAnalyticsConfigurationRequest,PutBucketAnalyticsConfigurationResponse>((PutBucketAnalyticsConfigurationRequest)req, (PutBucketAnalyticsConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketEncryption

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketEncryption operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketEncryption operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutBucketEncryptionAsync(PutBucketEncryptionRequest request, AmazonServiceCallback<PutBucketEncryptionRequest, PutBucketEncryptionResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketEncryption is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutBucketEncryptionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutBucketEncryptionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketEncryptionRequest,PutBucketEncryptionResponse> responseObject 
                            = new AmazonServiceResult<PutBucketEncryptionRequest,PutBucketEncryptionResponse>((PutBucketEncryptionRequest)req, (PutBucketEncryptionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketInventoryConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketInventoryConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketInventoryConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutBucketInventoryConfigurationAsync(PutBucketInventoryConfigurationRequest request, AmazonServiceCallback<PutBucketInventoryConfigurationRequest, PutBucketInventoryConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketInventoryConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutBucketInventoryConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutBucketInventoryConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketInventoryConfigurationRequest,PutBucketInventoryConfigurationResponse> responseObject 
                            = new AmazonServiceResult<PutBucketInventoryConfigurationRequest,PutBucketInventoryConfigurationResponse>((PutBucketInventoryConfigurationRequest)req, (PutBucketInventoryConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketLogging

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketLogging operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLogging operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutBucketLoggingAsync(PutBucketLoggingRequest request, AmazonServiceCallback<PutBucketLoggingRequest, PutBucketLoggingResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketLogging is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutBucketLoggingRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutBucketLoggingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketLoggingRequest,PutBucketLoggingResponse> responseObject 
                            = new AmazonServiceResult<PutBucketLoggingRequest,PutBucketLoggingResponse>((PutBucketLoggingRequest)req, (PutBucketLoggingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketMetricsConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketMetricsConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketMetricsConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutBucketMetricsConfigurationAsync(PutBucketMetricsConfigurationRequest request, AmazonServiceCallback<PutBucketMetricsConfigurationRequest, PutBucketMetricsConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketMetricsConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutBucketMetricsConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutBucketMetricsConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketMetricsConfigurationRequest,PutBucketMetricsConfigurationResponse> responseObject 
                            = new AmazonServiceResult<PutBucketMetricsConfigurationRequest,PutBucketMetricsConfigurationResponse>((PutBucketMetricsConfigurationRequest)req, (PutBucketMetricsConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketNotification

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketNotification operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketNotification operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutBucketNotificationAsync(PutBucketNotificationRequest request, AmazonServiceCallback<PutBucketNotificationRequest, PutBucketNotificationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketNotification is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutBucketNotificationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutBucketNotificationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketNotificationRequest,PutBucketNotificationResponse> responseObject 
                            = new AmazonServiceResult<PutBucketNotificationRequest,PutBucketNotificationResponse>((PutBucketNotificationRequest)req, (PutBucketNotificationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketPolicy

        /// <summary>
        /// Applies an Amazon S3 bucket policy to an Amazon S3 bucket. If you are using an identity
        /// other than the root user of the AWS account that owns the bucket, the calling identity
        /// must have the <code>PutBucketPolicy</code> permissions on the specified bucket and
        /// belong to the bucket owner's account in order to use this operation.
        /// 
        ///  
        /// <para>
        /// If you don't have <code>PutBucketPolic</code>y permissions, Amazon S3 returns a <code>403
        /// Access Denied</code> error. If you have the correct permissions, but you're not using
        /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>405
        /// Method Not Allowed</code> error.
        /// </para>
        ///  <important> 
        /// <para>
        ///  As a security precaution, the root user of the AWS account that owns a bucket can
        /// always use this operation, even if the policy explicitly denies the root user the
        /// ability to perform this action. 
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>PutBucketPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucket</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="policy">The bucket policy as a JSON document.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        public virtual void PutBucketPolicyAsync(string bucketName, string policy,  AmazonServiceCallback<PutBucketPolicyRequest, PutBucketPolicyResponse> callback, AsyncOptions options = null)
        {
            var request = new PutBucketPolicyRequest();
            request.BucketName = bucketName;
            request.Policy = policy;
            PutBucketPolicyAsync(request, callback, options);
        }


        /// <summary>
        /// Applies an Amazon S3 bucket policy to an Amazon S3 bucket. If you are using an identity
        /// other than the root user of the AWS account that owns the bucket, the calling identity
        /// must have the <code>PutBucketPolicy</code> permissions on the specified bucket and
        /// belong to the bucket owner's account in order to use this operation.
        /// 
        ///  
        /// <para>
        /// If you don't have <code>PutBucketPolic</code>y permissions, Amazon S3 returns a <code>403
        /// Access Denied</code> error. If you have the correct permissions, but you're not using
        /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>405
        /// Method Not Allowed</code> error.
        /// </para>
        ///  <important> 
        /// <para>
        ///  As a security precaution, the root user of the AWS account that owns a bucket can
        /// always use this operation, even if the policy explicitly denies the root user the
        /// ability to perform this action. 
        /// </para>
        ///  </important> 
        /// <para>
        /// For more information about bucket policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
        /// Bucket Policies and User Policies</a>.
        /// </para>
        ///  
        /// <para>
        /// The following operations are related to <code>PutBucketPolicy</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucket</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="policy">The bucket policy as a JSON document.</param>
        /// <param name="contentMD5">The MD5 hash of the request body.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        public virtual void PutBucketPolicyAsync(string bucketName, string policy, string contentMD5,  AmazonServiceCallback<PutBucketPolicyRequest, PutBucketPolicyResponse> callback, AsyncOptions options = null)
        {
            var request = new PutBucketPolicyRequest();
            request.BucketName = bucketName;
            request.Policy = policy;
            request.ContentMD5 = contentMD5;
            PutBucketPolicyAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketPolicy operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutBucketPolicyAsync(PutBucketPolicyRequest request, AmazonServiceCallback<PutBucketPolicyRequest, PutBucketPolicyResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketPolicy is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutBucketPolicyRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketPolicyRequest,PutBucketPolicyResponse> responseObject 
                            = new AmazonServiceResult<PutBucketPolicyRequest,PutBucketPolicyResponse>((PutBucketPolicyRequest)req, (PutBucketPolicyResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketReplication

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketReplication operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketReplication operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutBucketReplicationAsync(PutBucketReplicationRequest request, AmazonServiceCallback<PutBucketReplicationRequest, PutBucketReplicationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketReplication is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutBucketReplicationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutBucketReplicationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketReplicationRequest,PutBucketReplicationResponse> responseObject 
                            = new AmazonServiceResult<PutBucketReplicationRequest,PutBucketReplicationResponse>((PutBucketReplicationRequest)req, (PutBucketReplicationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketRequestPayment

        /// <summary>
        /// Sets the request payment configuration for a bucket. By default, the bucket owner
        /// pays for downloads from the bucket. This configuration parameter enables the bucket
        /// owner (only) to specify that the person requesting the download will be charged for
        /// the download. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html">Requester
        /// Pays Buckets</a>.
        /// 
        ///  
        /// <para>
        /// The following operations are related to <code>PutBucketRequestPayment</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateBucket</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketRequestPayment</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The bucket name.</param>
        /// <param name="requestPaymentConfiguration">Container for Payer.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketRequestPayment service method, as returned by S3.</returns>
        public virtual void PutBucketRequestPaymentAsync(string bucketName, RequestPaymentConfiguration requestPaymentConfiguration,  AmazonServiceCallback<PutBucketRequestPaymentRequest, PutBucketRequestPaymentResponse> callback, AsyncOptions options = null)
        {
            var request = new PutBucketRequestPaymentRequest();
            request.BucketName = bucketName;
            request.RequestPaymentConfiguration = requestPaymentConfiguration;
            PutBucketRequestPaymentAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketRequestPayment operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketRequestPayment operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutBucketRequestPaymentAsync(PutBucketRequestPaymentRequest request, AmazonServiceCallback<PutBucketRequestPaymentRequest, PutBucketRequestPaymentResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketRequestPayment is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutBucketRequestPaymentRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutBucketRequestPaymentResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketRequestPaymentRequest,PutBucketRequestPaymentResponse> responseObject 
                            = new AmazonServiceResult<PutBucketRequestPaymentRequest,PutBucketRequestPaymentResponse>((PutBucketRequestPaymentRequest)req, (PutBucketRequestPaymentResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketTagging

        /// <summary>
        /// Sets the tags for a bucket.
        /// 
        ///  
        /// <para>
        /// Use tags to organize your AWS bill to reflect your own cost structure. To do this,
        /// sign up to get your AWS account bill with tag key values included. Then, to see the
        /// cost of combined resources, organize your billing information according to resources
        /// with the same tag key values. For example, you can tag several resources with a specific
        /// application name, and then organize your billing information to see the total cost
        /// of that application across several services. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Cost
        /// Allocation and Tagging</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Within a bucket, if you add a tag that has the same key as an existing tag, the new
        /// value overwrites the old value. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CostAllocTagging.html">Using
        /// Cost Allocation in Amazon S3 Bucket Tags</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:PutBucketTagging</code>
        /// action. The bucket owner has this permission by default and can grant this permission
        /// to others. For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        ///  <code>PutBucketTagging</code> has the following special errors:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Error code: <code>InvalidTagError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The tag provided was not a valid tag. This error can occur if the tag
        /// did not pass input validation. For information about tag restrictions, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2//allocation-tag-restrictions.html">User-Defined
        /// Tag Restrictions</a> and <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2//aws-tag-restrictions.html">AWS-Generated
        /// Cost Allocation Tag Restrictions</a>.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>MalformedXMLError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The XML provided does not match the schema.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>OperationAbortedError </code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: A conflicting conditional operation is currently in progress against
        /// this resource. Please try again.
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Error code: <code>InternalError</code> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Description: The service was unable to apply the provided tag to the bucket.
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// The following operations are related to <code>PutBucketTagging</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketTagging</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketTagging</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The bucket name.</param>
        /// <param name="tagSet">A property of PutBucketTaggingRequest used to execute the PutBucketTagging service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketTagging service method, as returned by S3.</returns>
        public virtual void PutBucketTaggingAsync(string bucketName, List<Tag> tagSet,  AmazonServiceCallback<PutBucketTaggingRequest, PutBucketTaggingResponse> callback, AsyncOptions options = null)
        {
            var request = new PutBucketTaggingRequest();
            request.BucketName = bucketName;
            request.TagSet = tagSet;
            PutBucketTaggingAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketTagging operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutBucketTaggingAsync(PutBucketTaggingRequest request, AmazonServiceCallback<PutBucketTaggingRequest, PutBucketTaggingResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketTagging is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutBucketTaggingRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketTaggingRequest,PutBucketTaggingResponse> responseObject 
                            = new AmazonServiceResult<PutBucketTaggingRequest,PutBucketTaggingResponse>((PutBucketTaggingRequest)req, (PutBucketTaggingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketVersioning

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketVersioning operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketVersioning operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutBucketVersioningAsync(PutBucketVersioningRequest request, AmazonServiceCallback<PutBucketVersioningRequest, PutBucketVersioningResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketVersioning is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutBucketVersioningRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutBucketVersioningResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketVersioningRequest,PutBucketVersioningResponse> responseObject 
                            = new AmazonServiceResult<PutBucketVersioningRequest,PutBucketVersioningResponse>((PutBucketVersioningRequest)req, (PutBucketVersioningResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutBucketWebsite

        /// <summary>
        /// Sets the configuration of the website that is specified in the <code>website</code>
        /// subresource. To configure a bucket as a website, you can add this subresource on the
        /// bucket with website configuration information such as the file name of the index document
        /// and any redirect rules. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">Hosting
        /// Websites on Amazon S3</a>.
        /// 
        ///  
        /// <para>
        /// This PUT operation requires the <code>S3:PutBucketWebsite</code> permission. By default,
        /// only the bucket owner can configure the website attached to a bucket; however, bucket
        /// owners can allow other users to set the website configuration by writing a bucket
        /// policy that grants them the <code>S3:PutBucketWebsite</code> permission.
        /// </para>
        ///  
        /// <para>
        /// To redirect all website requests sent to the bucket's website endpoint, you add a
        /// website configuration with the following elements. Because all requests are sent to
        /// another website, you don't need to provide index document name for the bucket.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>WebsiteConfiguration</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RedirectAllRequestsTo</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HostName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Protocol</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you want granular control over redirects, you can use the following elements to
        /// add routing rules that describe conditions for redirecting requests and information
        /// about the redirect destination. In this case, the website configuration must provide
        /// an index document for the bucket, because some requests might not be redirected. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>WebsiteConfiguration</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>IndexDocument</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Suffix</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ErrorDocument</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Key</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RoutingRules</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RoutingRule</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Condition</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HttpErrorCodeReturnedEquals</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>KeyPrefixEquals</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Redirect</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>Protocol</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HostName</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReplaceKeyPrefixWith</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ReplaceKeyWith</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>HttpRedirectCode</code> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The bucket name.</param>
        /// <param name="websiteConfiguration">Container for the request.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketWebsite service method, as returned by S3.</returns>
        public virtual void PutBucketWebsiteAsync(string bucketName, WebsiteConfiguration websiteConfiguration,  AmazonServiceCallback<PutBucketWebsiteRequest, PutBucketWebsiteResponse> callback, AsyncOptions options = null)
        {
            var request = new PutBucketWebsiteRequest();
            request.BucketName = bucketName;
            request.WebsiteConfiguration = websiteConfiguration;
            PutBucketWebsiteAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketWebsite operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketWebsite operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutBucketWebsiteAsync(PutBucketWebsiteRequest request, AmazonServiceCallback<PutBucketWebsiteRequest, PutBucketWebsiteResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutBucketWebsite is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutBucketWebsiteRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutBucketWebsiteResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutBucketWebsiteRequest,PutBucketWebsiteResponse> responseObject 
                            = new AmazonServiceResult<PutBucketWebsiteRequest,PutBucketWebsiteResponse>((PutBucketWebsiteRequest)req, (PutBucketWebsiteResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutCORSConfiguration

        /// <summary>
        /// Sets the <code>cors</code> configuration for your bucket. If the configuration exists,
        /// Amazon S3 replaces it.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must be allowed to perform the <code>s3:PutBucketCORS</code>
        /// action. By default, the bucket owner has this permission and can grant it to others.
        /// </para>
        ///  
        /// <para>
        /// You set this configuration on a bucket so that the bucket can service cross-origin
        /// requests. For example, you might want to enable a request whose origin is <code>http://www.example.com</code>
        /// to access your Amazon S3 bucket at <code>my.example.bucket.com</code> by using the
        /// browser's <code>XMLHttpRequest</code> capability.
        /// </para>
        ///  
        /// <para>
        /// To enable cross-origin resource sharing (CORS) on a bucket, you add the <code>cors</code>
        /// subresource to the bucket. The <code>cors</code> subresource is an XML document in
        /// which you configure rules that identify origins and the HTTP methods that can be executed
        /// on your bucket. The document is limited to 64 KB in size. 
        /// </para>
        ///  
        /// <para>
        /// When Amazon S3 receives a cross-origin request (or a pre-flight OPTIONS request) against
        /// a bucket, it evaluates the <code>cors</code> configuration on the bucket and uses
        /// the first <code>CORSRule</code> rule that matches the incoming browser request to
        /// enable a cross-origin request. For a rule to match, the following conditions must
        /// be met:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The request's <code>Origin</code> header must match <code>AllowedOrigin</code> elements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The request method (for example, GET, PUT, HEAD, and so on) or the <code>Access-Control-Request-Method</code>
        /// header in case of a pre-flight <code>OPTIONS</code> request must be one of the <code>AllowedMethod</code>
        /// elements. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Every header specified in the <code>Access-Control-Request-Headers</code> request
        /// header of a pre-flight request must match an <code>AllowedHeader</code> element. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  For more information about CORS, go to <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/cors.html">Enabling
        /// Cross-Origin Resource Sharing</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>GetBucketCors</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketCors</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>RESTOPTIONSobject</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">Specifies the bucket impacted by the <code>cors</code>configuration.</param>
        /// <param name="configuration">Describes the cross-origin access configuration for objects in an Amazon S3 bucket. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev//cors.html">Enabling Cross-Origin Resource Sharing</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutCORSConfiguration service method, as returned by S3.</returns>
        public virtual void PutCORSConfigurationAsync(string bucketName, CORSConfiguration configuration,  AmazonServiceCallback<PutCORSConfigurationRequest, PutCORSConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new PutCORSConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            PutCORSConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutCORSConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCORSConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutCORSConfigurationAsync(PutCORSConfigurationRequest request, AmazonServiceCallback<PutCORSConfigurationRequest, PutCORSConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutCORSConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutCORSConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutCORSConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutCORSConfigurationRequest,PutCORSConfigurationResponse> responseObject 
                            = new AmazonServiceResult<PutCORSConfigurationRequest,PutCORSConfigurationResponse>((PutCORSConfigurationRequest)req, (PutCORSConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutLifecycleConfiguration

        /// <summary>
        /// Creates a new lifecycle configuration for the bucket or replaces an existing lifecycle
        /// configuration. For information about lifecycle configuration, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Bucket lifecycle configuration now supports specifying a lifecycle rule using an object
        /// key name prefix, one or more object tags, or a combination of both. Accordingly, this
        /// section describes the latest API. The previous version of the API supported filtering
        /// based only on an object key name prefix, which is supported for backward compatibility.
        /// For the related API description, see <a>PutBucketLifecycle</a>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Rules</b> 
        /// </para>
        ///  
        /// <para>
        /// You specify the lifecycle configuration in your request body. The lifecycle configuration
        /// is specified as XML consisting of one or more rules. Each rule consists of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Filter identifying a subset of objects to which the rule applies. The filter can be
        /// based on a key name prefix, object tags, or a combination of both.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Status whether the rule is in effect.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// One or more lifecycle transition and expiration actions that you want Amazon S3 to
        /// perform on the objects identified by the filter. If the state of your bucket is versioning-enabled
        /// or versioning-suspended, you can have many versions of the same object (one current
        /// version and zero or more noncurrent versions). Amazon S3 provides predefined actions
        /// that you can specify for current and noncurrent object versions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/intro-lifecycle-rules.html">Lifecycle
        /// Configuration Elements</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Permissions</b> 
        /// </para>
        ///  
        /// <para>
        /// By default, all Amazon S3 resources are private, including buckets, objects, and related
        /// subresources (for example, lifecycle configuration and website configuration). Only
        /// the resource owner (that is, the AWS account that created it) can access the resource.
        /// The resource owner can optionally grant access permissions to others by writing an
        /// access policy. For this operation, a user must get the s3:PutLifecycleConfiguration
        /// permission.
        /// </para>
        ///  
        /// <para>
        /// You can also explicitly deny permissions. Explicit deny also supersedes any other
        /// permissions. If you want to block users or accounts from removing or deleting objects
        /// from your bucket, you must deny them permissions for the following actions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// s3:DeleteObject
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:DeleteObjectVersion
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// s3:PutLifecycleConfiguration
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// The following are related to <code>PutBucketLifecycleConfiguration</code>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/lifecycle-configuration-examples.html">Examples
        /// of Lifecycle Configuration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteBucketLifecycle</a> 
        /// </para>
        ///  </li> </ul>
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value of this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// <param name="bucketName">The name of the bucket for which to set the configuration.</param>
        /// <param name="configuration">A property of PutLifecycleConfigurationRequest used to execute the PutLifecycleConfiguration service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the PutLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual void PutLifecycleConfigurationAsync(string bucketName, LifecycleConfiguration configuration,  AmazonServiceCallback<PutLifecycleConfigurationRequest, PutLifecycleConfigurationResponse> callback, AsyncOptions options = null)
        {
            var request = new PutLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            PutLifecycleConfigurationAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutLifecycleConfigurationAsync(PutLifecycleConfigurationRequest request, AmazonServiceCallback<PutLifecycleConfigurationRequest, PutLifecycleConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutLifecycleConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutLifecycleConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutLifecycleConfigurationRequest,PutLifecycleConfigurationResponse> responseObject 
                            = new AmazonServiceResult<PutLifecycleConfigurationRequest,PutLifecycleConfigurationResponse>((PutLifecycleConfigurationRequest)req, (PutLifecycleConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutObject

        /// <summary>
        /// Initiates the asynchronous execution of the PutObject operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObject operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutObjectAsync(PutObjectRequest request, AmazonServiceCallback<PutObjectRequest, PutObjectResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutObject is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutObjectRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutObjectResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutObjectRequest,PutObjectResponse> responseObject 
                            = new AmazonServiceResult<PutObjectRequest,PutObjectResponse>((PutObjectRequest)req, (PutObjectResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutObjectLegalHold

        /// <summary>
        /// Initiates the asynchronous execution of the PutObjectLegalHold operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObjectLegalHold operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutObjectLegalHoldAsync(PutObjectLegalHoldRequest request, AmazonServiceCallback<PutObjectLegalHoldRequest, PutObjectLegalHoldResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutObjectLegalHold is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutObjectLegalHoldRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutObjectLegalHoldResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutObjectLegalHoldRequest,PutObjectLegalHoldResponse> responseObject 
                            = new AmazonServiceResult<PutObjectLegalHoldRequest,PutObjectLegalHoldResponse>((PutObjectLegalHoldRequest)req, (PutObjectLegalHoldResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutObjectLockConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the PutObjectLockConfiguration operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObjectLockConfiguration operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutObjectLockConfigurationAsync(PutObjectLockConfigurationRequest request, AmazonServiceCallback<PutObjectLockConfigurationRequest, PutObjectLockConfigurationResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutObjectLockConfiguration is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutObjectLockConfigurationRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutObjectLockConfigurationResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutObjectLockConfigurationRequest,PutObjectLockConfigurationResponse> responseObject 
                            = new AmazonServiceResult<PutObjectLockConfigurationRequest,PutObjectLockConfigurationResponse>((PutObjectLockConfigurationRequest)req, (PutObjectLockConfigurationResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutObjectRetention

        /// <summary>
        /// Initiates the asynchronous execution of the PutObjectRetention operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObjectRetention operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutObjectRetentionAsync(PutObjectRetentionRequest request, AmazonServiceCallback<PutObjectRetentionRequest, PutObjectRetentionResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutObjectRetention is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutObjectRetentionRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutObjectRetentionResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutObjectRetentionRequest,PutObjectRetentionResponse> responseObject 
                            = new AmazonServiceResult<PutObjectRetentionRequest,PutObjectRetentionResponse>((PutObjectRetentionRequest)req, (PutObjectRetentionResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutObjectTagging

        /// <summary>
        /// Initiates the asynchronous execution of the PutObjectTagging operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObjectTagging operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutObjectTaggingAsync(PutObjectTaggingRequest request, AmazonServiceCallback<PutObjectTaggingRequest, PutObjectTaggingResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutObjectTagging is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutObjectTaggingRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutObjectTaggingResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutObjectTaggingRequest,PutObjectTaggingResponse> responseObject 
                            = new AmazonServiceResult<PutObjectTaggingRequest,PutObjectTaggingResponse>((PutObjectTaggingRequest)req, (PutObjectTaggingResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  PutPublicAccessBlock

        /// <summary>
        /// Initiates the asynchronous execution of the PutPublicAccessBlock operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPublicAccessBlock operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void PutPublicAccessBlockAsync(PutPublicAccessBlockRequest request, AmazonServiceCallback<PutPublicAccessBlockRequest, PutPublicAccessBlockResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("PutPublicAccessBlock is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = PutPublicAccessBlockRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = PutPublicAccessBlockResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<PutPublicAccessBlockRequest,PutPublicAccessBlockResponse> responseObject 
                            = new AmazonServiceResult<PutPublicAccessBlockRequest,PutPublicAccessBlockResponse>((PutPublicAccessBlockRequest)req, (PutPublicAccessBlockResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  RestoreObject

        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// 
        ///  
        /// <para>
        /// This operation performs the following types of requests: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>select</code> - Perform a select query on an archived object
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>restore an archive</code> - Restore an archived object
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:RestoreObject</code>
        /// and <code>s3:GetObject</code> actions. The bucket owner has this permission by default
        /// and can grant this permission to others. For more information about permissions, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Querying Archives with Select Requests</b> 
        /// </para>
        ///  
        /// <para>
        /// You use a select type of request to perform SQL queries on archived objects. The archived
        /// objects that are being queried by the select request must be formatted as uncompressed
        /// comma-separated values (CSV) files. You can run queries and custom analytics on your
        /// archived data without having to restore your data to a hotter Amazon S3 tier. For
        /// an overview about select requests, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When making a select request, do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Define an output location for the select query's output. This must be an Amazon S3
        /// bucket in the same AWS Region as the bucket that contains the archive object that
        /// is being queried. The AWS account that initiates the job must have permissions to
        /// write to the S3 bucket. You can specify the storage class and encryption for the output
        /// objects stored in the bucket. For more information about output, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>S3</code> structure in the request body, see
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Managing
        /// Access with ACLs</a> in the <i>Amazon Simple Storage Service Developer Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
        /// Data Using Server-Side Encryption</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Define the SQL expression for the <code>SELECT</code> type of restoration for your
        /// query in the request body's <code>SelectParameters</code> structure. You can use expressions
        /// like the following examples.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following expression returns all records from the specified object.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT * FROM Object</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Assuming that you are not using any headers for data stored in the object, you can
        /// specify columns with positional headers.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s._1, s._2 FROM Object s WHERE s._3 &gt; 100</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have headers and you set the <code>fileHeaderInfo</code> in the <code>CSV</code>
        /// structure in the request body to <code>USE</code>, you can specify headers in the
        /// query. (If you set the <code>fileHeaderInfo</code> field to <code>IGNORE</code>, the
        /// first row is skipped for the query.) You cannot mix ordinal positions with header
        /// column names. 
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s.Id, s.FirstName, s.SSN FROM S3Object s</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about using SQL with Glacier Select restore, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and Glacier Select</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// When making a select request, you can also do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To expedite your queries, specify the <code>Expedited</code> tier. For more information
        /// about tiers, see "Restoring Archives," later in this topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify details about the data serialization format of both the input object that
        /// is being queried and the serialization of the CSV-encoded query results.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are additional important facts about the select feature:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The output results are new Amazon S3 objects. Unlike archive retrievals, they are
        /// stored until explicitly deleted-manually or through a lifecycle policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can issue more than one select request on the same Amazon S3 object. Amazon S3
        /// doesn't deduplicate requests, so avoid issuing duplicate requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Amazon S3 accepts a select request even if the object has already been restored.
        /// A select request doesn’t return error response <code>409</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Restoring Archives</b> 
        /// </para>
        ///  
        /// <para>
        /// Objects in the GLACIER and DEEP_ARCHIVE storage classes are archived. To access an
        /// archived object, you must first initiate a restore request. This restores a temporary
        /// copy of the archived object. In a restore request, you specify the number of days
        /// that you want the restored copy to exist. After the specified period, Amazon S3 deletes
        /// the temporary copy but the object remains archived in the GLACIER or DEEP_ARCHIVE
        /// storage class that object was restored from. 
        /// </para>
        ///  
        /// <para>
        /// To restore a specific object version, you can provide a version ID. If you don't provide
        /// a version ID, Amazon S3 restores the current version.
        /// </para>
        ///  
        /// <para>
        /// The time it takes restore jobs to finish depends on which storage class the object
        /// is being restored from and which data access tier you specify. 
        /// </para>
        ///  
        /// <para>
        /// When restoring an archived object (or using a select request), you can specify one
        /// of the following data access tier options in the <code>Tier</code> element of the
        /// request body: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Expedited</code> </b> - Expedited retrievals allow you to quickly access
        /// your data stored in the GLACIER storage class when occasional urgent requests for
        /// a subset of archives are required. For all but the largest archived objects (250 MB+),
        /// data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// Provisioned capacity ensures that retrieval capacity for Expedited retrievals is available
        /// when you need it. Expedited retrievals and provisioned capacity are not available
        /// for the DEEP_ARCHIVE storage class.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Standard</code> </b> - Standard retrievals allow you to access any of your
        /// archived objects within several hours. This is the default option for the GLACIER
        /// and DEEP_ARCHIVE retrieval requests that do not specify the retrieval option. Standard
        /// retrievals typically complete within 3-5 hours from the GLACIER storage class and
        /// typically complete within 12 hours from the DEEP_ARCHIVE storage class. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Bulk</code> </b> - Bulk retrievals are Amazon S3 Glacier’s lowest-cost
        /// retrieval option, enabling you to retrieve large amounts, even petabytes, of data
        /// inexpensively in a day. Bulk retrievals typically complete within 5-12 hours from
        /// the GLACIER storage class and typically complete within 48 hours from the DEEP_ARCHIVE
        /// storage class.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about archive retrieval options and provisioned capacity for
        /// <code>Expedited</code> data access, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use Amazon S3 restore speed upgrade to change the restore speed to a faster
        /// speed while it is in progress. You upgrade the speed of an in-progress restoration
        /// by issuing another restore request to the same object, setting a new <code>Tier</code>
        /// request element. When issuing a request to upgrade the restore tier, you must choose
        /// a tier that is faster than the tier that the in-progress restore is using. You must
        /// not change any other parameters, such as the <code>Days</code> request element. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html#restoring-objects-upgrade-tier.title.html">
        /// Upgrading the Speed of an In-Progress Restore</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// To get the status of object restoration, you can send a <code>HEAD</code> request.
        /// Operations return the <code>x-amz-restore</code> header, which provides information
        /// about the restoration status, in the response. You can use Amazon S3 event notifications
        /// to notify you when a restore is initiated or completed. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
        /// Amazon S3 Event Notifications</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// After restoring an archived object, you can update the restoration period by reissuing
        /// the request with a new period. Amazon S3 updates the restoration period relative to
        /// the current time and charges only for the request-there are no data transfer charges.
        /// You cannot update the restoration period when Amazon S3 is actively processing your
        /// current restore request for the object.
        /// </para>
        ///  
        /// <para>
        /// If your bucket has a lifecycle configuration with a rule that includes an expiration
        /// action, the object expiration overrides the life span that you specify in a restore
        /// request. For example, if you restore an object copy for 10 days, but the object is
        /// scheduled to expire in 3 days, Amazon S3 deletes the object in 3 days. For more information
        /// about lifecycle configuration, see <a>PutBucketLifecycleConfiguration</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a> in <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Responses</b> 
        /// </para>
        ///  
        /// <para>
        /// A successful operation returns either the <code>200 OK</code> or <code>202 Accepted</code>
        /// status code. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the object copy is not previously restored, then Amazon S3 returns <code>202 Accepted</code>
        /// in the response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the object copy is previously restored, Amazon S3 returns <code>200 OK</code> in
        /// the response. 
        /// </para>
        ///  </li> </ul> <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: RestoreAlreadyInProgress</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: Object restore is already in progress. (This error does not apply to SELECT
        /// type requests.)</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 409 Conflict</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: Client</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: GlacierExpeditedRetrievalNotAvailable</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: Glacier expedited retrievals are currently not available. Try again later.
        /// (Returned if there is insufficient capacity to process the Expedited request. This
        /// error applies only to Expedited retrievals and not to Standard or Bulk retrievals.)</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 503</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: N/A</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketNotificationConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and Glacier Select </a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name or containing the object to restore.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Object key for which the operation was initiated.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual void RestoreObjectAsync(string bucketName, string key,  AmazonServiceCallback<RestoreObjectRequest, RestoreObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            RestoreObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// 
        ///  
        /// <para>
        /// This operation performs the following types of requests: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>select</code> - Perform a select query on an archived object
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>restore an archive</code> - Restore an archived object
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:RestoreObject</code>
        /// and <code>s3:GetObject</code> actions. The bucket owner has this permission by default
        /// and can grant this permission to others. For more information about permissions, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Querying Archives with Select Requests</b> 
        /// </para>
        ///  
        /// <para>
        /// You use a select type of request to perform SQL queries on archived objects. The archived
        /// objects that are being queried by the select request must be formatted as uncompressed
        /// comma-separated values (CSV) files. You can run queries and custom analytics on your
        /// archived data without having to restore your data to a hotter Amazon S3 tier. For
        /// an overview about select requests, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When making a select request, do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Define an output location for the select query's output. This must be an Amazon S3
        /// bucket in the same AWS Region as the bucket that contains the archive object that
        /// is being queried. The AWS account that initiates the job must have permissions to
        /// write to the S3 bucket. You can specify the storage class and encryption for the output
        /// objects stored in the bucket. For more information about output, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>S3</code> structure in the request body, see
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Managing
        /// Access with ACLs</a> in the <i>Amazon Simple Storage Service Developer Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
        /// Data Using Server-Side Encryption</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Define the SQL expression for the <code>SELECT</code> type of restoration for your
        /// query in the request body's <code>SelectParameters</code> structure. You can use expressions
        /// like the following examples.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following expression returns all records from the specified object.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT * FROM Object</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Assuming that you are not using any headers for data stored in the object, you can
        /// specify columns with positional headers.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s._1, s._2 FROM Object s WHERE s._3 &gt; 100</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have headers and you set the <code>fileHeaderInfo</code> in the <code>CSV</code>
        /// structure in the request body to <code>USE</code>, you can specify headers in the
        /// query. (If you set the <code>fileHeaderInfo</code> field to <code>IGNORE</code>, the
        /// first row is skipped for the query.) You cannot mix ordinal positions with header
        /// column names. 
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s.Id, s.FirstName, s.SSN FROM S3Object s</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about using SQL with Glacier Select restore, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and Glacier Select</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// When making a select request, you can also do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To expedite your queries, specify the <code>Expedited</code> tier. For more information
        /// about tiers, see "Restoring Archives," later in this topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify details about the data serialization format of both the input object that
        /// is being queried and the serialization of the CSV-encoded query results.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are additional important facts about the select feature:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The output results are new Amazon S3 objects. Unlike archive retrievals, they are
        /// stored until explicitly deleted-manually or through a lifecycle policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can issue more than one select request on the same Amazon S3 object. Amazon S3
        /// doesn't deduplicate requests, so avoid issuing duplicate requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Amazon S3 accepts a select request even if the object has already been restored.
        /// A select request doesn’t return error response <code>409</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Restoring Archives</b> 
        /// </para>
        ///  
        /// <para>
        /// Objects in the GLACIER and DEEP_ARCHIVE storage classes are archived. To access an
        /// archived object, you must first initiate a restore request. This restores a temporary
        /// copy of the archived object. In a restore request, you specify the number of days
        /// that you want the restored copy to exist. After the specified period, Amazon S3 deletes
        /// the temporary copy but the object remains archived in the GLACIER or DEEP_ARCHIVE
        /// storage class that object was restored from. 
        /// </para>
        ///  
        /// <para>
        /// To restore a specific object version, you can provide a version ID. If you don't provide
        /// a version ID, Amazon S3 restores the current version.
        /// </para>
        ///  
        /// <para>
        /// The time it takes restore jobs to finish depends on which storage class the object
        /// is being restored from and which data access tier you specify. 
        /// </para>
        ///  
        /// <para>
        /// When restoring an archived object (or using a select request), you can specify one
        /// of the following data access tier options in the <code>Tier</code> element of the
        /// request body: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Expedited</code> </b> - Expedited retrievals allow you to quickly access
        /// your data stored in the GLACIER storage class when occasional urgent requests for
        /// a subset of archives are required. For all but the largest archived objects (250 MB+),
        /// data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// Provisioned capacity ensures that retrieval capacity for Expedited retrievals is available
        /// when you need it. Expedited retrievals and provisioned capacity are not available
        /// for the DEEP_ARCHIVE storage class.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Standard</code> </b> - Standard retrievals allow you to access any of your
        /// archived objects within several hours. This is the default option for the GLACIER
        /// and DEEP_ARCHIVE retrieval requests that do not specify the retrieval option. Standard
        /// retrievals typically complete within 3-5 hours from the GLACIER storage class and
        /// typically complete within 12 hours from the DEEP_ARCHIVE storage class. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Bulk</code> </b> - Bulk retrievals are Amazon S3 Glacier’s lowest-cost
        /// retrieval option, enabling you to retrieve large amounts, even petabytes, of data
        /// inexpensively in a day. Bulk retrievals typically complete within 5-12 hours from
        /// the GLACIER storage class and typically complete within 48 hours from the DEEP_ARCHIVE
        /// storage class.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about archive retrieval options and provisioned capacity for
        /// <code>Expedited</code> data access, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use Amazon S3 restore speed upgrade to change the restore speed to a faster
        /// speed while it is in progress. You upgrade the speed of an in-progress restoration
        /// by issuing another restore request to the same object, setting a new <code>Tier</code>
        /// request element. When issuing a request to upgrade the restore tier, you must choose
        /// a tier that is faster than the tier that the in-progress restore is using. You must
        /// not change any other parameters, such as the <code>Days</code> request element. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html#restoring-objects-upgrade-tier.title.html">
        /// Upgrading the Speed of an In-Progress Restore</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// To get the status of object restoration, you can send a <code>HEAD</code> request.
        /// Operations return the <code>x-amz-restore</code> header, which provides information
        /// about the restoration status, in the response. You can use Amazon S3 event notifications
        /// to notify you when a restore is initiated or completed. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
        /// Amazon S3 Event Notifications</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// After restoring an archived object, you can update the restoration period by reissuing
        /// the request with a new period. Amazon S3 updates the restoration period relative to
        /// the current time and charges only for the request-there are no data transfer charges.
        /// You cannot update the restoration period when Amazon S3 is actively processing your
        /// current restore request for the object.
        /// </para>
        ///  
        /// <para>
        /// If your bucket has a lifecycle configuration with a rule that includes an expiration
        /// action, the object expiration overrides the life span that you specify in a restore
        /// request. For example, if you restore an object copy for 10 days, but the object is
        /// scheduled to expire in 3 days, Amazon S3 deletes the object in 3 days. For more information
        /// about lifecycle configuration, see <a>PutBucketLifecycleConfiguration</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a> in <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Responses</b> 
        /// </para>
        ///  
        /// <para>
        /// A successful operation returns either the <code>200 OK</code> or <code>202 Accepted</code>
        /// status code. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the object copy is not previously restored, then Amazon S3 returns <code>202 Accepted</code>
        /// in the response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the object copy is previously restored, Amazon S3 returns <code>200 OK</code> in
        /// the response. 
        /// </para>
        ///  </li> </ul> <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: RestoreAlreadyInProgress</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: Object restore is already in progress. (This error does not apply to SELECT
        /// type requests.)</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 409 Conflict</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: Client</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: GlacierExpeditedRetrievalNotAvailable</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: Glacier expedited retrievals are currently not available. Try again later.
        /// (Returned if there is insufficient capacity to process the Expedited request. This
        /// error applies only to Expedited retrievals and not to Standard or Bulk retrievals.)</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 503</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: N/A</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketNotificationConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and Glacier Select </a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name or containing the object to restore.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Object key for which the operation was initiated.</param>
        /// <param name="days">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual void RestoreObjectAsync(string bucketName, string key, int days,  AmazonServiceCallback<RestoreObjectRequest, RestoreObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.Days = days;
            RestoreObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// 
        ///  
        /// <para>
        /// This operation performs the following types of requests: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>select</code> - Perform a select query on an archived object
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>restore an archive</code> - Restore an archived object
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:RestoreObject</code>
        /// and <code>s3:GetObject</code> actions. The bucket owner has this permission by default
        /// and can grant this permission to others. For more information about permissions, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Querying Archives with Select Requests</b> 
        /// </para>
        ///  
        /// <para>
        /// You use a select type of request to perform SQL queries on archived objects. The archived
        /// objects that are being queried by the select request must be formatted as uncompressed
        /// comma-separated values (CSV) files. You can run queries and custom analytics on your
        /// archived data without having to restore your data to a hotter Amazon S3 tier. For
        /// an overview about select requests, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When making a select request, do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Define an output location for the select query's output. This must be an Amazon S3
        /// bucket in the same AWS Region as the bucket that contains the archive object that
        /// is being queried. The AWS account that initiates the job must have permissions to
        /// write to the S3 bucket. You can specify the storage class and encryption for the output
        /// objects stored in the bucket. For more information about output, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>S3</code> structure in the request body, see
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Managing
        /// Access with ACLs</a> in the <i>Amazon Simple Storage Service Developer Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
        /// Data Using Server-Side Encryption</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Define the SQL expression for the <code>SELECT</code> type of restoration for your
        /// query in the request body's <code>SelectParameters</code> structure. You can use expressions
        /// like the following examples.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following expression returns all records from the specified object.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT * FROM Object</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Assuming that you are not using any headers for data stored in the object, you can
        /// specify columns with positional headers.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s._1, s._2 FROM Object s WHERE s._3 &gt; 100</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have headers and you set the <code>fileHeaderInfo</code> in the <code>CSV</code>
        /// structure in the request body to <code>USE</code>, you can specify headers in the
        /// query. (If you set the <code>fileHeaderInfo</code> field to <code>IGNORE</code>, the
        /// first row is skipped for the query.) You cannot mix ordinal positions with header
        /// column names. 
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s.Id, s.FirstName, s.SSN FROM S3Object s</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about using SQL with Glacier Select restore, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and Glacier Select</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// When making a select request, you can also do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To expedite your queries, specify the <code>Expedited</code> tier. For more information
        /// about tiers, see "Restoring Archives," later in this topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify details about the data serialization format of both the input object that
        /// is being queried and the serialization of the CSV-encoded query results.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are additional important facts about the select feature:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The output results are new Amazon S3 objects. Unlike archive retrievals, they are
        /// stored until explicitly deleted-manually or through a lifecycle policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can issue more than one select request on the same Amazon S3 object. Amazon S3
        /// doesn't deduplicate requests, so avoid issuing duplicate requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Amazon S3 accepts a select request even if the object has already been restored.
        /// A select request doesn’t return error response <code>409</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Restoring Archives</b> 
        /// </para>
        ///  
        /// <para>
        /// Objects in the GLACIER and DEEP_ARCHIVE storage classes are archived. To access an
        /// archived object, you must first initiate a restore request. This restores a temporary
        /// copy of the archived object. In a restore request, you specify the number of days
        /// that you want the restored copy to exist. After the specified period, Amazon S3 deletes
        /// the temporary copy but the object remains archived in the GLACIER or DEEP_ARCHIVE
        /// storage class that object was restored from. 
        /// </para>
        ///  
        /// <para>
        /// To restore a specific object version, you can provide a version ID. If you don't provide
        /// a version ID, Amazon S3 restores the current version.
        /// </para>
        ///  
        /// <para>
        /// The time it takes restore jobs to finish depends on which storage class the object
        /// is being restored from and which data access tier you specify. 
        /// </para>
        ///  
        /// <para>
        /// When restoring an archived object (or using a select request), you can specify one
        /// of the following data access tier options in the <code>Tier</code> element of the
        /// request body: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Expedited</code> </b> - Expedited retrievals allow you to quickly access
        /// your data stored in the GLACIER storage class when occasional urgent requests for
        /// a subset of archives are required. For all but the largest archived objects (250 MB+),
        /// data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// Provisioned capacity ensures that retrieval capacity for Expedited retrievals is available
        /// when you need it. Expedited retrievals and provisioned capacity are not available
        /// for the DEEP_ARCHIVE storage class.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Standard</code> </b> - Standard retrievals allow you to access any of your
        /// archived objects within several hours. This is the default option for the GLACIER
        /// and DEEP_ARCHIVE retrieval requests that do not specify the retrieval option. Standard
        /// retrievals typically complete within 3-5 hours from the GLACIER storage class and
        /// typically complete within 12 hours from the DEEP_ARCHIVE storage class. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Bulk</code> </b> - Bulk retrievals are Amazon S3 Glacier’s lowest-cost
        /// retrieval option, enabling you to retrieve large amounts, even petabytes, of data
        /// inexpensively in a day. Bulk retrievals typically complete within 5-12 hours from
        /// the GLACIER storage class and typically complete within 48 hours from the DEEP_ARCHIVE
        /// storage class.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about archive retrieval options and provisioned capacity for
        /// <code>Expedited</code> data access, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use Amazon S3 restore speed upgrade to change the restore speed to a faster
        /// speed while it is in progress. You upgrade the speed of an in-progress restoration
        /// by issuing another restore request to the same object, setting a new <code>Tier</code>
        /// request element. When issuing a request to upgrade the restore tier, you must choose
        /// a tier that is faster than the tier that the in-progress restore is using. You must
        /// not change any other parameters, such as the <code>Days</code> request element. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html#restoring-objects-upgrade-tier.title.html">
        /// Upgrading the Speed of an In-Progress Restore</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// To get the status of object restoration, you can send a <code>HEAD</code> request.
        /// Operations return the <code>x-amz-restore</code> header, which provides information
        /// about the restoration status, in the response. You can use Amazon S3 event notifications
        /// to notify you when a restore is initiated or completed. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
        /// Amazon S3 Event Notifications</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// After restoring an archived object, you can update the restoration period by reissuing
        /// the request with a new period. Amazon S3 updates the restoration period relative to
        /// the current time and charges only for the request-there are no data transfer charges.
        /// You cannot update the restoration period when Amazon S3 is actively processing your
        /// current restore request for the object.
        /// </para>
        ///  
        /// <para>
        /// If your bucket has a lifecycle configuration with a rule that includes an expiration
        /// action, the object expiration overrides the life span that you specify in a restore
        /// request. For example, if you restore an object copy for 10 days, but the object is
        /// scheduled to expire in 3 days, Amazon S3 deletes the object in 3 days. For more information
        /// about lifecycle configuration, see <a>PutBucketLifecycleConfiguration</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a> in <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Responses</b> 
        /// </para>
        ///  
        /// <para>
        /// A successful operation returns either the <code>200 OK</code> or <code>202 Accepted</code>
        /// status code. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the object copy is not previously restored, then Amazon S3 returns <code>202 Accepted</code>
        /// in the response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the object copy is previously restored, Amazon S3 returns <code>200 OK</code> in
        /// the response. 
        /// </para>
        ///  </li> </ul> <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: RestoreAlreadyInProgress</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: Object restore is already in progress. (This error does not apply to SELECT
        /// type requests.)</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 409 Conflict</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: Client</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: GlacierExpeditedRetrievalNotAvailable</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: Glacier expedited retrievals are currently not available. Try again later.
        /// (Returned if there is insufficient capacity to process the Expedited request. This
        /// error applies only to Expedited retrievals and not to Standard or Bulk retrievals.)</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 503</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: N/A</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketNotificationConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and Glacier Select </a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name or containing the object to restore.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Object key for which the operation was initiated.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual void RestoreObjectAsync(string bucketName, string key, string versionId,  AmazonServiceCallback<RestoreObjectRequest, RestoreObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            RestoreObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// 
        ///  
        /// <para>
        /// This operation performs the following types of requests: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>select</code> - Perform a select query on an archived object
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>restore an archive</code> - Restore an archived object
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To use this operation, you must have permissions to perform the <code>s3:RestoreObject</code>
        /// and <code>s3:GetObject</code> actions. The bucket owner has this permission by default
        /// and can grant this permission to others. For more information about permissions, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
        /// Related to Bucket Subresource Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-access-control.html">Managing
        /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Querying Archives with Select Requests</b> 
        /// </para>
        ///  
        /// <para>
        /// You use a select type of request to perform SQL queries on archived objects. The archived
        /// objects that are being queried by the select request must be formatted as uncompressed
        /// comma-separated values (CSV) files. You can run queries and custom analytics on your
        /// archived data without having to restore your data to a hotter Amazon S3 tier. For
        /// an overview about select requests, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When making a select request, do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Define an output location for the select query's output. This must be an Amazon S3
        /// bucket in the same AWS Region as the bucket that contains the archive object that
        /// is being queried. The AWS account that initiates the job must have permissions to
        /// write to the S3 bucket. You can specify the storage class and encryption for the output
        /// objects stored in the bucket. For more information about output, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/querying-glacier-archives.html">Querying
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about the <code>S3</code> structure in the request body, see
        /// the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutObject</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Managing
        /// Access with ACLs</a> in the <i>Amazon Simple Storage Service Developer Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
        /// Data Using Server-Side Encryption</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i> 
        /// </para>
        ///  </li> </ul> </li> <li> 
        /// <para>
        /// Define the SQL expression for the <code>SELECT</code> type of restoration for your
        /// query in the request body's <code>SelectParameters</code> structure. You can use expressions
        /// like the following examples.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following expression returns all records from the specified object.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT * FROM Object</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Assuming that you are not using any headers for data stored in the object, you can
        /// specify columns with positional headers.
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s._1, s._2 FROM Object s WHERE s._3 &gt; 100</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have headers and you set the <code>fileHeaderInfo</code> in the <code>CSV</code>
        /// structure in the request body to <code>USE</code>, you can specify headers in the
        /// query. (If you set the <code>fileHeaderInfo</code> field to <code>IGNORE</code>, the
        /// first row is skipped for the query.) You cannot mix ordinal positions with header
        /// column names. 
        /// </para>
        ///  
        /// <para>
        ///  <code>SELECT s.Id, s.FirstName, s.SSN FROM S3Object s</code> 
        /// </para>
        ///  </li> </ul> </li> </ul> 
        /// <para>
        /// For more information about using SQL with Glacier Select restore, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and Glacier Select</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// When making a select request, you can also do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To expedite your queries, specify the <code>Expedited</code> tier. For more information
        /// about tiers, see "Restoring Archives," later in this topic.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify details about the data serialization format of both the input object that
        /// is being queried and the serialization of the CSV-encoded query results.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The following are additional important facts about the select feature:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The output results are new Amazon S3 objects. Unlike archive retrievals, they are
        /// stored until explicitly deleted-manually or through a lifecycle policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You can issue more than one select request on the same Amazon S3 object. Amazon S3
        /// doesn't deduplicate requests, so avoid issuing duplicate requests.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  Amazon S3 accepts a select request even if the object has already been restored.
        /// A select request doesn’t return error response <code>409</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Restoring Archives</b> 
        /// </para>
        ///  
        /// <para>
        /// Objects in the GLACIER and DEEP_ARCHIVE storage classes are archived. To access an
        /// archived object, you must first initiate a restore request. This restores a temporary
        /// copy of the archived object. In a restore request, you specify the number of days
        /// that you want the restored copy to exist. After the specified period, Amazon S3 deletes
        /// the temporary copy but the object remains archived in the GLACIER or DEEP_ARCHIVE
        /// storage class that object was restored from. 
        /// </para>
        ///  
        /// <para>
        /// To restore a specific object version, you can provide a version ID. If you don't provide
        /// a version ID, Amazon S3 restores the current version.
        /// </para>
        ///  
        /// <para>
        /// The time it takes restore jobs to finish depends on which storage class the object
        /// is being restored from and which data access tier you specify. 
        /// </para>
        ///  
        /// <para>
        /// When restoring an archived object (or using a select request), you can specify one
        /// of the following data access tier options in the <code>Tier</code> element of the
        /// request body: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b> <code>Expedited</code> </b> - Expedited retrievals allow you to quickly access
        /// your data stored in the GLACIER storage class when occasional urgent requests for
        /// a subset of archives are required. For all but the largest archived objects (250 MB+),
        /// data accessed using Expedited retrievals are typically made available within 1–5 minutes.
        /// Provisioned capacity ensures that retrieval capacity for Expedited retrievals is available
        /// when you need it. Expedited retrievals and provisioned capacity are not available
        /// for the DEEP_ARCHIVE storage class.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Standard</code> </b> - Standard retrievals allow you to access any of your
        /// archived objects within several hours. This is the default option for the GLACIER
        /// and DEEP_ARCHIVE retrieval requests that do not specify the retrieval option. Standard
        /// retrievals typically complete within 3-5 hours from the GLACIER storage class and
        /// typically complete within 12 hours from the DEEP_ARCHIVE storage class. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b> <code>Bulk</code> </b> - Bulk retrievals are Amazon S3 Glacier’s lowest-cost
        /// retrieval option, enabling you to retrieve large amounts, even petabytes, of data
        /// inexpensively in a day. Bulk retrievals typically complete within 5-12 hours from
        /// the GLACIER storage class and typically complete within 48 hours from the DEEP_ARCHIVE
        /// storage class.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about archive retrieval options and provisioned capacity for
        /// <code>Expedited</code> data access, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html">Restoring
        /// Archived Objects</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use Amazon S3 restore speed upgrade to change the restore speed to a faster
        /// speed while it is in progress. You upgrade the speed of an in-progress restoration
        /// by issuing another restore request to the same object, setting a new <code>Tier</code>
        /// request element. When issuing a request to upgrade the restore tier, you must choose
        /// a tier that is faster than the tier that the in-progress restore is using. You must
        /// not change any other parameters, such as the <code>Days</code> request element. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/restoring-objects.html#restoring-objects-upgrade-tier.title.html">
        /// Upgrading the Speed of an In-Progress Restore</a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// To get the status of object restoration, you can send a <code>HEAD</code> request.
        /// Operations return the <code>x-amz-restore</code> header, which provides information
        /// about the restoration status, in the response. You can use Amazon S3 event notifications
        /// to notify you when a restore is initiated or completed. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html">Configuring
        /// Amazon S3 Event Notifications</a> in the <i>Amazon Simple Storage Service Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// After restoring an archived object, you can update the restoration period by reissuing
        /// the request with a new period. Amazon S3 updates the restoration period relative to
        /// the current time and charges only for the request-there are no data transfer charges.
        /// You cannot update the restoration period when Amazon S3 is actively processing your
        /// current restore request for the object.
        /// </para>
        ///  
        /// <para>
        /// If your bucket has a lifecycle configuration with a rule that includes an expiration
        /// action, the object expiration overrides the life span that you specify in a restore
        /// request. For example, if you restore an object copy for 10 days, but the object is
        /// scheduled to expire in 3 days, Amazon S3 deletes the object in 3 days. For more information
        /// about lifecycle configuration, see <a>PutBucketLifecycleConfiguration</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lifecycle-mgmt.html">Object
        /// Lifecycle Management</a> in <i>Amazon Simple Storage Service Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Responses</b> 
        /// </para>
        ///  
        /// <para>
        /// A successful operation returns either the <code>200 OK</code> or <code>202 Accepted</code>
        /// status code. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the object copy is not previously restored, then Amazon S3 returns <code>202 Accepted</code>
        /// in the response. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the object copy is previously restored, Amazon S3 returns <code>200 OK</code> in
        /// the response. 
        /// </para>
        ///  </li> </ul> <p class="title"> <b>Special Errors</b> 
        /// </para>
        ///  <ul> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: RestoreAlreadyInProgress</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: Object restore is already in progress. (This error does not apply to SELECT
        /// type requests.)</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 409 Conflict</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: Client</i> 
        /// </para>
        ///  </li> </ul> </li> <li> <p class="title"> <b/> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Code: GlacierExpeditedRetrievalNotAvailable</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Cause: Glacier expedited retrievals are currently not available. Try again later.
        /// (Returned if there is insufficient capacity to process the Expedited request. This
        /// error applies only to Expedited retrievals and not to Standard or Bulk retrievals.)</i>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>HTTP Status Code: 503</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>SOAP Fault Code Prefix: N/A</i> 
        /// </para>
        ///  </li> </ul> </li> </ul> <p class="title"> <b>Related Resources</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PutBucketLifecycleConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>GetBucketNotificationConfiguration</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-glacier-select-sql-reference.html">SQL
        /// Reference for Amazon S3 Select and Glacier Select </a> in the <i>Amazon Simple Storage
        /// Service Developer Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="bucketName">The bucket name or containing the object to restore.  When using this API with an access point, you must direct requests to the access point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When using this operation using an access point through the AWS SDKs, you provide the access point ARN in place of the bucket name. For more information about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-access-points.html">Using Access Points</a> in the <i>Amazon Simple Storage Service Developer Guide</i>.</param>
        /// <param name="key">Object key for which the operation was initiated.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="days">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">
        ///     A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///     procedure using the AsyncState property.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual void RestoreObjectAsync(string bucketName, string key, string versionId, int days,  AmazonServiceCallback<RestoreObjectRequest, RestoreObjectResponse> callback, AsyncOptions options = null)
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            request.Days = days;
            RestoreObjectAsync(request, callback, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreObject operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void RestoreObjectAsync(RestoreObjectRequest request, AmazonServiceCallback<RestoreObjectRequest, RestoreObjectResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = RestoreObjectRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = RestoreObjectResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<RestoreObjectRequest,RestoreObjectResponse> responseObject 
                            = new AmazonServiceResult<RestoreObjectRequest,RestoreObjectResponse>((RestoreObjectRequest)req, (RestoreObjectResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  SelectObjectContent

        /// <summary>
        /// Initiates the asynchronous execution of the SelectObjectContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SelectObjectContent operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void SelectObjectContentAsync(SelectObjectContentRequest request, AmazonServiceCallback<SelectObjectContentRequest, SelectObjectContentResponse> callback, AsyncOptions options = null)
        {
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = SelectObjectContentRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = SelectObjectContentResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<SelectObjectContentRequest,SelectObjectContentResponse> responseObject 
                            = new AmazonServiceResult<SelectObjectContentRequest,SelectObjectContentResponse>((SelectObjectContentRequest)req, (SelectObjectContentResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
        #region  UploadPart

        /// <summary>
        /// Initiates the asynchronous execution of the UploadPart operation.
        /// This API is supported only when AWSConfigs.HttpClient is set to AWSConfigs.HttpClientOption.UnityWebRequest, the default value for this configuration option is AWSConfigs.HttpClientOption.UnityWWW
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadPart operation on AmazonS3Client.</param>
        /// <param name="callback">An Action delegate that is invoked when the operation completes.</param>
        /// <param name="options">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public virtual void UploadPartAsync(UploadPartRequest request, AmazonServiceCallback<UploadPartRequest, UploadPartResponse> callback, AsyncOptions options = null)
        {
            if (AWSConfigs.HttpClient == AWSConfigs.HttpClientOption.UnityWWW)
            {
                throw new InvalidOperationException("UploadPart is only allowed with AWSConfigs.HttpClientOption.UnityWebRequest API option");
            }
            options = options == null?new AsyncOptions():options;
            var invokeOptions = new InvokeOptions();
            invokeOptions.RequestMarshaller = UploadPartRequestMarshaller.Instance;
            invokeOptions.ResponseUnmarshaller = UploadPartResponseUnmarshaller.Instance;
            Action<AmazonWebServiceRequest, AmazonWebServiceResponse, Exception, AsyncOptions> callbackHelper = null;
            if(callback !=null )
                callbackHelper = (AmazonWebServiceRequest req, AmazonWebServiceResponse res, Exception ex, AsyncOptions ao) => { 
                    AmazonServiceResult<UploadPartRequest,UploadPartResponse> responseObject 
                            = new AmazonServiceResult<UploadPartRequest,UploadPartResponse>((UploadPartRequest)req, (UploadPartResponse)res, ex , ao.State);    
                        callback(responseObject); 
                };
            BeginInvoke(request, invokeOptions, options, callbackHelper);
        }

        #endregion
        
    }
}