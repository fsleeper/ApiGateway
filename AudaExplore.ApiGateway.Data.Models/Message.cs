/*
 * Copyright ©, AudaExplore, USA. This is UNPUBLISHED
 * PROPRIETARY SOURCE CODE of AudaExplore, USA; the contents of this file
 * may not be disclosed to third parties, copied or duplicated in any form, in
 * whole or in part, without the prior written permission of AudaExplore. 
 * ALL RIGHTS RESERVED.
 */

using System.Runtime.Serialization;
using System;

namespace AudaExplore.ApiGateway.Data.Models
{
    #region Message

    /// <summary>
    ///     Message object responsible for holding additional status messages.  
    /// </summary>
    [DataContract(Namespace = "http://novo.audaexplore.com/apigateway")]
    public class Message
    {
        #region PrivateVariables

        // Holds message code
        private String messageCode;

        // Holds message code description
        private String description;

        #endregion PrivateVariables

        #region MessageCode

        /// <summary>
        ///     Gets or Sets MessageCode.  Unique code defined AudaExplore workflow engine
        /// </summary>
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public String MessageCode
        {
            get
            {
                return this.messageCode;
            }
            set
            {
                this.messageCode = value;
            }
        }

        #endregion MessageCode

        #region Description

        /// <summary>
        ///     Gets or Sets Description.  Detailed description of the message code
        /// </summary>
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public String Description
        {
            get
            {
                return this.description;
            }
            set
            {
                this.description = value;
            }
        }

        #endregion Description
    }

    #endregion Message
}
