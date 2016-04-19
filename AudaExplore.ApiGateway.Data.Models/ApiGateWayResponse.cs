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
    #region ApiGateWayResponse

    /// <summary>
    ///     AudaExplore generic api gateway response object.  This object responsible informing status of the service call, it has properties to hold service status returncode, return message, etc...
    /// </summary>
    [DataContract(Namespace = "http://novo.audaexplore.com/apigateway")]
    public class ApiGateWayResponse
    {
        #region PrivateVariables

        // Holds status of the service
        private ServiceStatus returnCode;
        // Holds login id
        private String login;
        // Holds the machine name
        private String hostName;
        // Holds the time of the response
        private DateTime timeStamp;
        // Holds array of message object
        private List<Message> messages;
        // Holds response payload message
        private String payload;

        #endregion PrivateVariables

        #region ReturnCode

        /// <summary>
        ///  Gets or Sets Holds status of the service
        /// </summary>
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public ServiceStatus ReturnCode
        {
            get
            {
                return this.returnCode;
            }
            set
            {
                this.returnCode = value;
            }
        }

        #endregion ReturnCode

        #region Login

        /// <summary>
        ///     Gets or Sets loginId.  Usually whatever login Id passed will be returned
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

        #region HostName

        /// <summary>
        ///     Gets or Sets HostName.  The service where the actual operation being performed
        /// </summary>
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public String HostName
        {
            get
            {
                return this.hostName;
            }
            set
            {
                this.hostName = value;
            }
        }

        #endregion hostName

        #region TimeStamp

        /// <summary>
        ///     Gets or Sets TimeStamp.  Date and time the service responded
        /// </summary>
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public DateTime TimeStamp
        {
            get
            {
                return this.timeStamp;
            }
            set
            {
                this.timeStamp = value;
            }
        }


        #endregion TimeStamp

        #region Messages

        /// <summary>
        ///     Gets or Sets Messages.  It has the additional information about the workflow being performed or error being happened
        /// </summary>
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public List<Message> Messages
        {
            get
            {
                return this.messages;
            }
            set
            {
                this.messages = value;
            }
        }

        #endregion Messages

        #region Payload

        /// <summary>
        ///     Gets or Sets the Payload.  Certain scenario the service has to return message.  The payload object responsible for sending response message back to the caller
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

    #endregion ApiGateWayResponse
}
