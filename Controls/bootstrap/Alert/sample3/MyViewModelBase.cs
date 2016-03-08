﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotVVM.Framework.ViewModel;
using DotVVM.Framework.Controls.Bootstrap;
using DotVVM.Framework.Hosting;

namespace DotvvmWeb.Views.Docs.Controls.bootstrap.Alert.sample3
{
    public class MyViewModelBase : DotvvmViewModelBase
    {

        [Bind(Direction.ServerToClient)]
        public string AlertText { get; set; }

        [Bind(Direction.ServerToClient)]
        public AlertType AlertType { get; set; }


        /// <summary>
        /// Executes the specified action and sets the appropriate alert messages.
        /// </summary>
        protected void ExecuteWithAlert(Action actionToExecute, 
            string successText = "The operation was successful.", 
            string errorText = "Sorry, an unexpected error has occurred.")
        {
            try
            {
                // execute the action
                actionToExecute();

                AlertText = successText;
                AlertType = AlertType.Success;
            }
            catch (DotvvmInterruptRequestExecutionException)
            {
                // this exception is used for redirecting - don't catch it
                throw;
            }
            catch (Exception)
            {
                AlertText = errorText;
                AlertType = AlertType.Danger;
            }
        }

    }
}