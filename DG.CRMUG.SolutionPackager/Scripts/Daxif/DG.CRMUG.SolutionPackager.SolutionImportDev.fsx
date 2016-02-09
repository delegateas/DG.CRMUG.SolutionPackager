(**
SolutionImportDev
=================

Libraries
---------

Config information *)
#load @"DG.CRMUG.SolutionPackager.Config.fsx"

module cfg = DG.CRMUG.SolutionPackager.Config

(** Open libraries for use *)
open DG.Daxif.Modules

module cfg = DG.CRMUG.SolutionPackager.Config

(**
DAXIF# operations
-----------------

Import Dev *)
let zip = cfg.solutions + cfg.solution + @".zip"

Solution.import
  cfg.wsdlDev' cfg.solution zip false
    cfg.authType cfg.usrDev cfg.pwdDev cfg.domainDev 
      cfg.log
