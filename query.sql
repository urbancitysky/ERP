SELECT tblPunches.ClockId, tblPunches.Date, tblPunches.Punch, tblPunches.[In/Out], Format(Cstr([tblEmployees.BadgeNumber]), "0000000000" )as BadgeNumber, tblEmployees.[Employee Name],tblPunches.Department
FROM tblPunches 
INNER JOIN tblEmployees ON tblPunches.ClockId = tblEmployees.[Clock Number] 
WHERE (((tblPunches.Date)=#9/21/2017#) AND ((tblPunches.Punch)<#10:30am#)AND((tblPunches.[In/Out])=1) AND ((tblPunches.Punch)<1) AND ((tblPunches.Department) <> 'ASSEMBLE WEB'))AND ((tblPunches.Department) <> '3 RD PARTY-DRIVER')
ORDER BY tblEmployees.[Employee Name];
