﻿(**
SolutionExportDev
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

Export Dev *)
cfg.ensureFolder cfg.solutions

Solution.export
  cfg.wsdlDev' cfg.solution cfg.solutions false 
    cfg.authType cfg.usrDev cfg.pwdDev cfg.domainDev 
      cfg.log

Solution.export
  cfg.wsdlDev' cfg.solution cfg.solutions true 
    cfg.authType cfg.usrDev cfg.pwdDev cfg.domainDev 
      cfg.log
