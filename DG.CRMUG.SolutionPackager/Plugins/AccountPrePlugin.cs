﻿// <copyright file="AccountPrePlugin.cs" company="">
// Copyright (c) 2014 All Rights Reserved
// </copyright>
// <author></author>
// <date>7/8/2014 1:49:46 PM</date>
// <summary>Implements the AccountPrePlugin Plugin.</summary>
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
// </auto-generated>
namespace DG.CRMUG.SolutionPackager.Plugins
{
  using System;
  using Microsoft.Xrm.Sdk;

  using DG.XrmFramework.BusinessDomain.ServiceContext;

  /// <summary>
  /// AccountPrePlugin Plugin.
  /// </summary>    
  public class AccountPrePlugin : Plugin
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="AccountPrePlugin"/> class.
    /// </summary>
    public AccountPrePlugin()
        : base(typeof(AccountPrePlugin))
    {
      RegisterPluginStep<Account>(
          EventOperation.Create,
          ExecutionStage.PreOperation,
          ExecuteAccountPrePlugin);

      RegisterPluginStep<Account>(
          EventOperation.Update,
          ExecutionStage.PreOperation,
          ExecuteAccountPrePlugin);
    }

    /// <summary>
    /// Executes the plug-in.
    /// </summary>
    /// <param name="localContext">The <see cref="LocalPluginContext"/> which contains the
    /// <see cref="IPluginExecutionContext"/>,
    /// <see cref="IOrganizationService"/>
    /// and <see cref="ITracingService"/>
    /// </param>
    /// <remarks>
    /// For improved performance, Microsoft Dynamics CRM caches plug-in instances.
    /// The plug-in's Execute method should be written to be stateless as the constructor
    /// is not called for every invocation of the plug-in. Also, multiple system threads
    /// could execute the plug-in at the same time. All per invocation state information
    /// is stored in the context. This means that you should not use global variables in plug-ins.
    /// </remarks>
    protected void ExecuteAccountPrePlugin(LocalPluginContext localContext)
    {
      if (localContext == null)
      {
        throw new ArgumentNullException("localContext");
      }

      var eventOperation = localContext.PluginExecutionContext
                                       .MessageName
                                       .ToEventOperation();

      var isUpdate = eventOperation.HasFlag(EventOperation.Update);

      try
      {
#if DEBUG
        throw new Exception("Debug code shouldn't go to TEST/PROD");
#endif
      }
      catch (Exception ex)
      {
        throw new InvalidPluginExecutionException("Error: " + ex.Message);
      }
    }
  }
}
