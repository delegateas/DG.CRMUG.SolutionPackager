(**
SolutionDiff
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

//let zipSource = cfg.solutions + cfg.solution + @".zip"
//let zipTarget = cfg.solutions + cfg.solution + @"_" + @".zip"

let zipSource = cfg.solutions + cfg.solution + @"_managed.zip"
let zipTarget = cfg.solutions + cfg.solution + @"_managed_" + @".zip"

Diff.summary zipSource zipTarget cfg.log |> ignore

Diff.solution zipSource zipTarget cfg.log