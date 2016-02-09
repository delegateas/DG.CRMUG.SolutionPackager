using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xrm.Sdk;

using DG.CRMUG.SolutionPackager.Plugins;

namespace DG.CRMUG.SolutionPackager.Plugins.Helpers
{
    public static class HelperPlugin
    {
        #region Inner classes

        #endregion

        #region Private properties

        #endregion

        #region Public properties

        #endregion

        #region Constructors

        #endregion

        #region Static methods

        public static EventOperation ToEventOperation(this String x)
        {
            return (EventOperation)Enum.Parse(typeof(EventOperation), x);
        }

        public static System.Int32 ToInt(this PipelineStage x)
        {
            return (int)x;
        }

        #endregion

        #region Public methods

        #endregion

        #region Factory methods

        #endregion

        #region Interface members

        #endregion

        #region Protected methods

        #endregion

        #region Private methods

        #endregion

        #region Private classes

        #endregion
    }

    #region Other classes

    public enum EventOperation
    {
        Create                        = 1,
        Retrieve                      = 2,
        RetrieveMultiple              = 4,
        RetrievePrincipalAccess       = 8,
        RetrieveSharedPrincipalAccess = 16,
        Update                        = 32,
        Delete                        = 64,
        Associate                     = 128,
        Disassociate                  = 256,
        SetState                      = 512,
        SetStateDynamicEntity         = 1024,
        GrantAccess                   = 2048,
        ModifyAccess                  = 4096,
        RevokeAccess                  = 8192,
        Assign                        = 16384,
        Merge                         = 32768
    }

    public enum PipelineStage
    {
        PreValidation = 10,
        PreOperation  = 20,
        MainOperation = 30, // Only MS internal use
        PostOperation = 40
    }

    #endregion
}
