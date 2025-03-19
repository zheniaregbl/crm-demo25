create type user_type as enum ('заказчик', 'мастер', 'менеджер', 'оператор');

create table users(
	"id" serial primary key,
	fio text not null,
	phone text not null,
	login text not null,
	"password" text not null,
	"type" user_type not null
);

create table tech_type(
	"id" serial primary key,
	"name" text not null
);

create table home_tech(
	"id" serial primary key,
	"type" int references tech_type("id"),
	model text not null
);

create type request_status as enum ('новая', 'в процессе ремонта', 'готова к выдаче');

create table request(
	"id" serial primary key,
	master int,
	client int references users("id"),
	start_date date not null,
	home_tech int references home_tech("id"),
	problem_desc text not null,
	status request_status not null,
	completion_date date
);

create table "comment"(
	"id" serial primary key,
	request int references request("id"),
	master int references users("id"),
	"message" text not null
);

select r.id as request_id, r.start_date, r.problem_desc, r.status, r.completion_date, c.id as client_id, c.fio as client_fio, c.phone as client_phone, m.id as master_id, m.fio as master_fio, m.phone as master_phone, ht.id as tech_id, ht.model as tech_model, tt.id as tech_type_id, tt.name as tech_type_name
from request r join users c on r.client = c.id
left join users m on r.master = m.id
join home_tech ht on r.home_tech = ht.id
join tech_type tt on ht.type = tt.id
;

select r.id as request_id, r.start_date, r.problem_desc, r.completion_date, c.fio as client_fio, c.phone as client_phone, m.fio as master_fio, m.phone as master_phone, ht.model as tech_model, tt.name as tech_type_name
from request r join users c on r.client = c.id
left join users m on r.master = m.id
join home_tech ht on r.home_tech = ht.id
join tech_type tt on ht.type = tt.id;