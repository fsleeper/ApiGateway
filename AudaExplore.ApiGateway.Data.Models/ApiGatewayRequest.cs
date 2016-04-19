/*
 * Copyright ©, AudaExplore, USA. This is UNPUBLISHED
 * PROPRIETARY SOURCE CODE of AudaExplore, USA; the contents of this file
 * may not be disclosed to third parties, copied or duplicated in any form, in
 * whole or in part, without the prior written permission of AudaExplore. 
 * ALL RIGHTS RESERVED.
 */

using System.Runtime.Serialization;
using System;
using System.Collections.Generic;

namespace AudaExplore.ApiGateway.Data.Models
{
    #region ApiGatewayRequest

    /// <summary>
    ///     AudaExplore generic api gateway request object.  This object has properties to hold credentials, message payload and any other additional information required
    ///     in order to perform workflow
    /// </summary>
    [DataContract(Namespace = "http://novo.audaexplore.com/apigateway")]
    public class ApiGatewayRequest
    {
        #region PrivateVariables

        // Holds login id
        private String login;
        // Holds password
        private String password;
        // Additional optional parameters
        private List<Parameter> parameters;
        // The actual message payload
        private String payload;

        #endregion PrivateVariables

        #region Login

        /// <summary>
        ///     Gets or Sets Login Id
        /// </summary>
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public String Login
        {
            get
            {
                return this.login;
            }
            set
            {
                this.login = value;
            }
        }

        #endregion Login

        #region Password

        /// <summary>
        ///     Gets or Sets Password
        /// </summary>
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public String Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }


        #endregion Password

        #region Parameters

        /// <summary>
        ///     Gets or Sets additional Parameters.  It's name/value pair object
        /// </summary>
        [DataMember(IsRequired = false, EmitDefaultValue = false)]
        public List<Parameter> Parameters
        {
            get
            {
                return this.parameters;
            }
            set
            {
                this.parameters = value;
            }
        }

        #endregion Parameters

        #region Payload

        /// <summary>
        ///     Gets or Sets Payload message
        /// </summary>
        [DataMember(IsRequired = false, EmitDefaultValue = false)]
        public String Payload
        {
            get
            {
                return this.payload;
            }
            set
            {
                this.payload = value;
            }
        }

        #endregion Payload
    }

    #endregion ApiGatewayRequest
}
