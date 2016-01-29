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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.CertificateManager.Model;
using Amazon.CertificateManager.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CertificateManager
{
    /// <summary>
    /// Implementation for accessing CertificateManager
    ///
    /// AWS Certificate Manager 
    /// <para>
    /// This is the AWS Certificate Manager (ACM) command line reference. It provides descriptions,
    /// syntax, and usage examples for each ACM command. You can use AWS Certificate Manager
    /// to request SSL/TLS certificates for your AWS-based websites and applications. For
    /// general information about using ACM and for more information about using the console,
    /// see the <a href="url-acm-ug;acm-overview.html">AWS Certificate Manager User Guide</a>.
    /// For more information about using the ACM API, see the <a href="http://docs.aws.amazon.com/acm/latest/APIReference/Welcome.html">
    /// AWS Certificate Manager API Reference</a>. 
    /// </para>
    /// </summary>
    public partial class AmazonCertificateManagerClient : AmazonServiceClient, IAmazonCertificateManager
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCertificateManagerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCertificateManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCertificateManagerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCertificateManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(AmazonCertificateManagerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCertificateManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonCertificateManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCertificateManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCertificateManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Credentials and an
        /// AmazonCertificateManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(AWSCredentials credentials, AmazonCertificateManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCertificateManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCertificateManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCertificateManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCertificateManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCertificateManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCertificateManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCertificateManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCertificateManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCertificateManagerClient Configuration Object</param>
        public AmazonCertificateManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCertificateManagerConfig clientConfig)
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
            return new AWS4Signer();
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

        
        #region  DeleteCertificate

        /// <summary>
        /// Deletes a certificate and its associated private key. If this function succeeds,
        /// the certificate will no longer appear in the list of certificates that can be displayed
        /// by calling the <a>ListCertificates</a> function or be retrieved by calling the <a>GetCertificate</a>
        /// function. The certificate will not be available for use by other AWS services. <note>You
        /// cannot delete a certificate that is being used by another AWS service. To delete a
        /// certificate that is in use, the certificate association must first be removed. </note>
        /// </summary>
        /// <param name="certificateArn"> String that contains the ARN of the certificate to be deleted. This must be of the form:   <code>arn:aws:acm:us-east-1:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>   For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>. </param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another AWS service in the caller's account. Remove
        /// the association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public DeleteCertificateResponse DeleteCertificate(string certificateArn)
        {
            var request = new DeleteCertificateRequest();
            request.CertificateArn = certificateArn;
            return DeleteCertificate(request);
        }


        /// <summary>
        /// Deletes a certificate and its associated private key. If this function succeeds,
        /// the certificate will no longer appear in the list of certificates that can be displayed
        /// by calling the <a>ListCertificates</a> function or be retrieved by calling the <a>GetCertificate</a>
        /// function. The certificate will not be available for use by other AWS services. <note>You
        /// cannot delete a certificate that is being used by another AWS service. To delete a
        /// certificate that is in use, the certificate association must first be removed. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate service method.</param>
        /// 
        /// <returns>The response from the DeleteCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceInUseException">
        /// The certificate is in use by another AWS service in the caller's account. Remove
        /// the association and try again.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public DeleteCertificateResponse DeleteCertificate(DeleteCertificateRequest request)
        {
            var marshaller = new DeleteCertificateRequestMarshaller();
            var unmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return Invoke<DeleteCertificateRequest,DeleteCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCertificate
        ///         operation.</returns>
        public IAsyncResult BeginDeleteCertificate(DeleteCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DeleteCertificateRequestMarshaller();
            var unmarshaller = DeleteCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<DeleteCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCertificate.</param>
        /// 
        /// <returns>Returns a  DeleteCertificateResult from CertificateManager.</returns>
        public  DeleteCertificateResponse EndDeleteCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCertificate

        /// <summary>
        /// Returns a list of the fields contained in the specified certificate. For example,
        /// this function returns the certificate status, a flag that indicates whether the certificate
        /// is associated with any other AWS service, and the date at which the certificate request
        /// was created. The certificate is specified on input by its Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="certificateArn"> String that contains a certificate ARN. The ARN must be of the form:   <code>arn:aws:acm:us-east-1:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>   For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>. </param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public DescribeCertificateResponse DescribeCertificate(string certificateArn)
        {
            var request = new DescribeCertificateRequest();
            request.CertificateArn = certificateArn;
            return DescribeCertificate(request);
        }


        /// <summary>
        /// Returns a list of the fields contained in the specified certificate. For example,
        /// this function returns the certificate status, a flag that indicates whether the certificate
        /// is associated with any other AWS service, and the date at which the certificate request
        /// was created. The certificate is specified on input by its Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate service method.</param>
        /// 
        /// <returns>The response from the DescribeCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public DescribeCertificateResponse DescribeCertificate(DescribeCertificateRequest request)
        {
            var marshaller = new DescribeCertificateRequestMarshaller();
            var unmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return Invoke<DescribeCertificateRequest,DescribeCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCertificate
        ///         operation.</returns>
        public IAsyncResult BeginDescribeCertificate(DescribeCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new DescribeCertificateRequestMarshaller();
            var unmarshaller = DescribeCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<DescribeCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCertificate.</param>
        /// 
        /// <returns>Returns a  DescribeCertificateResult from CertificateManager.</returns>
        public  DescribeCertificateResponse EndDescribeCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCertificate

        /// <summary>
        /// Retrieves an SSL/TLS certificate and certificate chain for the certificate specified
        /// by an ARN. The chain is an ordered list of certificates that contains the root certificate,
        /// intermediate certificates of subordinate CAs, and the ACM certificate. The certificate
        /// and certificate chain are base64 encoded. If you want to decode the certificate chain
        /// to see the individual certificate fields, you can use OpenSSL. 
        /// 
        ///  <note> Currently, ACM certificates can be used only with Elastic Load Balancing and
        /// Amazon CloudFront. </note>
        /// </summary>
        /// <param name="certificateArn"> String that contains a certificate ARN. This must be of the form:   <code>arn:aws:acm:us-east-1:123456789012:certificate/12345678-1234-1234-1234-123456789012</code>   For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon Resource Names (ARNs) and AWS Service Namespaces</a>. </param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public GetCertificateResponse GetCertificate(string certificateArn)
        {
            var request = new GetCertificateRequest();
            request.CertificateArn = certificateArn;
            return GetCertificate(request);
        }


        /// <summary>
        /// Retrieves an SSL/TLS certificate and certificate chain for the certificate specified
        /// by an ARN. The chain is an ordered list of certificates that contains the root certificate,
        /// intermediate certificates of subordinate CAs, and the ACM certificate. The certificate
        /// and certificate chain are base64 encoded. If you want to decode the certificate chain
        /// to see the individual certificate fields, you can use OpenSSL. 
        /// 
        ///  <note> Currently, ACM certificates can be used only with Elastic Load Balancing and
        /// Amazon CloudFront. </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCertificate service method.</param>
        /// 
        /// <returns>The response from the GetCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.RequestInProgressException">
        /// The certificate request is in process and the certificate in your account has not
        /// yet been issued.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public GetCertificateResponse GetCertificate(GetCertificateRequest request)
        {
            var marshaller = new GetCertificateRequestMarshaller();
            var unmarshaller = GetCertificateResponseUnmarshaller.Instance;

            return Invoke<GetCertificateRequest,GetCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCertificate
        ///         operation.</returns>
        public IAsyncResult BeginGetCertificate(GetCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new GetCertificateRequestMarshaller();
            var unmarshaller = GetCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<GetCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCertificate.</param>
        /// 
        /// <returns>Returns a  GetCertificateResult from CertificateManager.</returns>
        public  GetCertificateResponse EndGetCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCertificates

        /// <summary>
        /// Retrieves a list of the certificate ARNs, and the domain name for each ARN, owned
        /// by the calling account. You can filter the list based on the <code>CertificateStatuses</code>
        /// parameter, and you can display up to <code>MaxItems</code> certificates at one time.
        /// If you have more than <code>MaxItems</code> certificates, use the <code>NextToken</code>
        /// marker from the response object in your next call to the <code>ListCertificates</code>
        /// function to retrieve the next set of certificate ARNs.
        /// </summary>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        public ListCertificatesResponse ListCertificates()
        {
            return ListCertificates(new ListCertificatesRequest());
        }

        /// <summary>
        /// Retrieves a list of the certificate ARNs, and the domain name for each ARN, owned
        /// by the calling account. You can filter the list based on the <code>CertificateStatuses</code>
        /// parameter, and you can display up to <code>MaxItems</code> certificates at one time.
        /// If you have more than <code>MaxItems</code> certificates, use the <code>NextToken</code>
        /// marker from the response object in your next call to the <code>ListCertificates</code>
        /// function to retrieve the next set of certificate ARNs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates service method.</param>
        /// 
        /// <returns>The response from the ListCertificates service method, as returned by CertificateManager.</returns>
        public ListCertificatesResponse ListCertificates(ListCertificatesRequest request)
        {
            var marshaller = new ListCertificatesRequestMarshaller();
            var unmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return Invoke<ListCertificatesRequest,ListCertificatesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCertificates operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCertificates
        ///         operation.</returns>
        public IAsyncResult BeginListCertificates(ListCertificatesRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ListCertificatesRequestMarshaller();
            var unmarshaller = ListCertificatesResponseUnmarshaller.Instance;

            return BeginInvoke<ListCertificatesRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCertificates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCertificates.</param>
        /// 
        /// <returns>Returns a  ListCertificatesResult from CertificateManager.</returns>
        public  ListCertificatesResponse EndListCertificates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCertificatesResponse>(asyncResult);
        }

        #endregion
        
        #region  RequestCertificate

        /// <summary>
        /// Requests an ACM certificate for use with other AWS services. To request an ACM certificate,
        /// you must specify the fully qualified domain name (FQDN) for your site. You can also
        /// specify additional FQDNs if users can reach your site by using other names. For each
        /// domain name you specify, email is sent to the domain owner to request approval to
        /// issue the certificate. After receiving approval from the domain owner, the ACM certificate
        /// is issued. For more information, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/overview.html">
        /// AWS Certificate Manager User Guide </a>.
        /// </summary>
        /// <param name="domainName"> Fully qualified domain name (FQDN), such as www.example.com, of the site you want to secure with an SSL/TLS certificate. Use an asterisk (*) to create a wildcard certificate that protects several sites in the same domain. For example, *.example.com protects www.example.com, site.example.com, and images.example.com. </param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have the IAM permissions necessary to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM limit has been exceeded. For example, you may have input more domains than
        /// are allowed or you've requested too many certificates for your account. See the exception
        /// message returned by ACM to determine which limit you have violated. For more information
        /// about ACM limits, see the <a href="http://docs.amazon.com/acm/latest/userguide/limits.html">Limits</a>
        /// topic.
        /// </exception>
        public RequestCertificateResponse RequestCertificate(string domainName)
        {
            var request = new RequestCertificateRequest();
            request.DomainName = domainName;
            return RequestCertificate(request);
        }


        /// <summary>
        /// Requests an ACM certificate for use with other AWS services. To request an ACM certificate,
        /// you must specify the fully qualified domain name (FQDN) for your site. You can also
        /// specify additional FQDNs if users can reach your site by using other names. For each
        /// domain name you specify, email is sent to the domain owner to request approval to
        /// issue the certificate. After receiving approval from the domain owner, the ACM certificate
        /// is issued. For more information, see the <a href="http://docs.aws.amazon.com/acm/latest/userguide/overview.html">
        /// AWS Certificate Manager User Guide </a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestCertificate service method.</param>
        /// 
        /// <returns>The response from the RequestCertificate service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.AccessDeniedException">
        /// You do not have the IAM permissions necessary to perform the requested operation.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.LimitExceededException">
        /// An ACM limit has been exceeded. For example, you may have input more domains than
        /// are allowed or you've requested too many certificates for your account. See the exception
        /// message returned by ACM to determine which limit you have violated. For more information
        /// about ACM limits, see the <a href="http://docs.amazon.com/acm/latest/userguide/limits.html">Limits</a>
        /// topic.
        /// </exception>
        public RequestCertificateResponse RequestCertificate(RequestCertificateRequest request)
        {
            var marshaller = new RequestCertificateRequestMarshaller();
            var unmarshaller = RequestCertificateResponseUnmarshaller.Instance;

            return Invoke<RequestCertificateRequest,RequestCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RequestCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestCertificate operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestCertificate
        ///         operation.</returns>
        public IAsyncResult BeginRequestCertificate(RequestCertificateRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new RequestCertificateRequestMarshaller();
            var unmarshaller = RequestCertificateResponseUnmarshaller.Instance;

            return BeginInvoke<RequestCertificateRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RequestCertificate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestCertificate.</param>
        /// 
        /// <returns>Returns a  RequestCertificateResult from CertificateManager.</returns>
        public  RequestCertificateResponse EndRequestCertificate(IAsyncResult asyncResult)
        {
            return EndInvoke<RequestCertificateResponse>(asyncResult);
        }

        #endregion
        
        #region  ResendValidationEmail

        /// <summary>
        /// Resends the email that requests domain ownership validation. The domain owner or
        /// an authorized representative must approve the ACM certificate before it can be issued.
        /// The certificate can be approved by clicking a link in the mail to navigate to the
        /// Amazon certificate approval website and then clicking <b>I Approve</b>. However, the
        /// validation email can be blocked by spam filters. Therefore, if you do not receive
        /// the original mail, you can request that the mail be resent within 72 hours of requesting
        /// the ACM certificate. If more than 72 hours have elapsed since your original request
        /// or since your last attempt to resend validation mail, you must request a new certificate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResendValidationEmail service method.</param>
        /// 
        /// <returns>The response from the ResendValidationEmail service method, as returned by CertificateManager.</returns>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidArnException">
        /// The requested Amazon Resource Name (ARN) does not refer to an existing resource.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidDomainValidationOptionsException">
        /// One or more values in the <a>DomainValidationOption</a> structure is incorrect.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.InvalidStateException">
        /// Processing has reached an invalid state. For example, this exception can be thrown
        /// if the specified domain is not using email validation, or the current certificate
        /// status does not permit the requested operation. See the exception message returned
        /// by ACM to determine which state is not valid.
        /// </exception>
        /// <exception cref="Amazon.CertificateManager.Model.ResourceNotFoundException">
        /// The specified certificate cannot be found in the caller's account, or the caller's
        /// account cannot be found.
        /// </exception>
        public ResendValidationEmailResponse ResendValidationEmail(ResendValidationEmailRequest request)
        {
            var marshaller = new ResendValidationEmailRequestMarshaller();
            var unmarshaller = ResendValidationEmailResponseUnmarshaller.Instance;

            return Invoke<ResendValidationEmailRequest,ResendValidationEmailResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResendValidationEmail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResendValidationEmail operation on AmazonCertificateManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResendValidationEmail
        ///         operation.</returns>
        public IAsyncResult BeginResendValidationEmail(ResendValidationEmailRequest request, AsyncCallback callback, object state)
        {
            var marshaller = new ResendValidationEmailRequestMarshaller();
            var unmarshaller = ResendValidationEmailResponseUnmarshaller.Instance;

            return BeginInvoke<ResendValidationEmailRequest>(request, marshaller, unmarshaller,
                callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ResendValidationEmail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResendValidationEmail.</param>
        /// 
        /// <returns>Returns a  ResendValidationEmailResult from CertificateManager.</returns>
        public  ResendValidationEmailResponse EndResendValidationEmail(IAsyncResult asyncResult)
        {
            return EndInvoke<ResendValidationEmailResponse>(asyncResult);
        }

        #endregion
        
    }
}