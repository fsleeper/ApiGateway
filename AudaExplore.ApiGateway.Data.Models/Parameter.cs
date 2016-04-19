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
    #region Parameter

    /// <summary>
    ///     Parameter object responsbile for receiving additional information from the caller. 
    /// </summary>
    [DataContract(Namespace = "http://novo.audaexplore.com/apigateway")]
    public class Parameter
    {
        #region PrivateVariables

        // Holds name of additional property
        private String name;

        // Hold value of the corresponding property
        private String value;

        #endregion PrivateVariables

        #region Name

        /// <summary>
        ///     Gets or Sets Name.  Custom property defined by specific workflow, if needed.
        /// </summary>
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public String Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        #endregion Name

        #region Value


        /// <summary>
        ///     Gets or Sets Value.  It has corresponding value for the property being passed.  
        /// </summary>
        [DataMember(IsRequired = true, EmitDefaultValue = false)]
        public String Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        #endregion Value
    }

    #endregion Parameter
}
