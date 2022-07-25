select m.name, count(e.id)
from [dbo].[managers] as m
join [dbo].[employee] as e
on e.managerId = m.Id
group by m.name