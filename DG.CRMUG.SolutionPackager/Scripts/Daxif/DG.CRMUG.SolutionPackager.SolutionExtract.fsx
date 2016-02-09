(**
SolutionExtract
===============

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

Extract solution *)
cfg.ensureFolder cfg.solutions

let map =   cfg.rootFolder + @"\..\..\Solution\DG.CRMUG.SolutionPackager.xml"
let cms =   cfg.rootFolder + @"\..\..\Solution\customizations"
let vsSol = cfg.rootFolder + @"\..\..\Solution\Solution.csproj"

let zip = cfg.solutions + cfg.solution + @".zip"

Solution.extract
  cfg.solution
    zip cms map vsSol
      cfg.log
