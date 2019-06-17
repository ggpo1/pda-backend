-- stored proceudres and functions scripts

create or replace function Tasks.l_tasks returns table (taskId int, title varchar, statusCode int, userId)
as $$
begin
return QUERY
	select * from Tasks.TasksInfo;
end;
$$ LANGUAGE plpgsql SECURITY DEFINER;



CREATE or Replace FUNCTION L_customer() returns table (Номер int, Название varchar, Город varchar, Прибыль numeric)
AS $$
begin
RETURN QUERY
		SELECT  id_customer,
				name_company,
				city_customer,
				profit_of_year
		FROM customer;
end;
$$ LANGUAGE plpgsql SECURITY DEFINER;

create schema Users;
create schema Tasks;
create schema Books;
create schema Calendar;
create schema Purchases;
create schema Trainings;
create schema Archive;
create schema Settings;