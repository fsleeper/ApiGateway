/*
 * Copyright ©, AudaExplore, USA. This is UNPUBLISHED
 * PROPRIETARY SOURCE CODE of AudaExplore, USA; the contents of this file
 * may not be disclosed to third parties, copied or duplicated in any form, in
 * whole or in part, without the prior written permission of AudaExplore. 
 * ALL RIGHTS RESERVED.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AudaExplore.ApiGateway.Data.Models;


namespace AudaExplore.ApiGateway.Services
{
    #region AppointmentService

    /// <summary>
    ///     Implementation of IAppointmentService
    /// </summary>
    [ServiceBehavior(Namespace = "http://novo.audaexplore.com/dispatch/appointmentservice", Name = "AppointmentService")]    
    public class AppointmentService : IAppointmentService
    {
        #region GetAppointmentDetails

        /// <summary>
        ///     Client will call to retrieve time slots that are currently available for the requested date and service window
        /// </summary>
        /// <param name="apiGatewayRequest">
        ///     Instance of ApiGatewayRequest object
        /// </param>
        /// <returns>
        ///     Returns instance of ApiGateWayResponse object
        /// </returns>
        public ApiGateWayResponse GetAppointmentDetails(ApiGatewayRequest apiGatewayRequest)
        {
            ApiGateWayResponse apiGateWayResponse = new ApiGateWayResponse();

            apiGateWayResponse.Login = apiGatewayRequest.Login;
            apiGateWayResponse.ReturnCode = ServiceStatus.Success;
            apiGateWayResponse.HostName = Environment.MachineName;
            apiGateWayResponse.TimeStamp = DateTime.Now;

            List<Message> messages = new List<Message>();

            Message message = new Message();
            message.MessageCode = "OK";
            message.Description = "OK Description";

            messages.Add(message);

            String payload = "<![CDATA[<AppointmentAvailabilityList>	</AppointmentAvailabilityList>]]>";

            apiGateWayResponse.Payload = payload;

            apiGateWayResponse.Messages = messages;


            return apiGateWayResponse;
        }

        #endregion GetAppointmentDetails
    }

    #endregion AppointmentService
}
