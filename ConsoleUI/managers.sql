select m.name, count(e.id) as c
from [dbo].[managers] as m
join [dbo].[employee] as e
on e.managerId = m.Id
group by m.name
order by c desc