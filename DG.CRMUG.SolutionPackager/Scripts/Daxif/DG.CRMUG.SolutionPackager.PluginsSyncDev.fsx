﻿(**
WebResouresSyncDev
=================

Libraries
---------

Config information *)
#load @"DG.CRMUG.SolutionPackager.Config.fsx"

module cfg = DG.CRMUG.SolutionPackager.Config

(** Open libraries for use *)
open DG.Daxif.Modules

(**
DAXIF# operations
-----------------

Sync Plugins Dev *)
let dll  = cfg.rootFolder + @"\..\..\Plugins\bin\Debug\ILMerged.Delegate.CRMUG.SolutionPackager.Plugins.dll"
let proj = cfg.rootFolder + @"\..\..\Plugins\Plugins.csproj"

Plugins.syncSolution
    cfg.wsdlDev' cfg.solution proj dll
        cfg.authType cfg.usrDev cfg.pwdDev cfg.domainDev 
            cfg.log
