drop database if exists pda_database;
create database pda_database;

\c pda_database;

drop schema if exists Users cascade;
drop schema if exists Tasks cascade;
drop schema if exists Books cascade;
drop schema if exists Calendar cascade;
drop schema if exists Purchases cascade;
drop schema if exists Trainings cascade;
drop schema if exists Archive cascade;
drop schema if exists Settings cascade;

create schema Users;
create schema Tasks;
create schema Books;
create schema Calendar;
create schema Purchases;
create schema Trainings;
create schema Archive;
create schema Settings;

-- Users schema tables: 
create table Users.UsersInfo (
    userId serial,
    username varchar(20),
    password  varchar(20),
    primary key (userId)
);
-----------------------

-- Tasks schema tables: 
create table Tasks.TasksStatus (
    statusCode serial,
    statusText varchar(50),
    primary key (statusCode)
);
create table Tasks.TasksInfo (
    taskId serial,
    title varchar(50),
    statusCode integer references Tasks.TasksStatus on update cascade on delete cascade,
    userId integer references Users.UsersInfo on update cascade on delete cascade,
    primary key (taskId)
);
-----------------------

-- Calendar schema tables:
-----------------------

-- Purchases schema tables:
create table Purchases.PurchaseCategories (
    categoryId serial,
    categoryName varchar(50),
    primary key (categoryId)
);
create table Purchases.PurchasesInfo (
    purchaseId serial,
    purchaseName varchar(100),
    categoryId integer references Purchases.PurchaseCategories on update cascade on delete cascade,
    primary key (purchaseId)
);
-----------------------

-- Trainings schema tables:
create table Trainings.TrainingsTypes (
    trainingTypeId serial,
    trainingTypeName varchar(50),
    primary key (trainingTypeId)
);
create table Trainings.TrainingsInfo (
    trainingId serial,
    title varchar(50),
    trainingTypeId integer references Trainings.TrainingsTypes on update cascade on delete cascade,
    trainingDate timestamp,
    userId integer references Users.UsersInfo on update cascade on delete cascade,
    primary key (trainingId)
);
-----------------------

-- Books schema tables:
-- TODO Books period
create table Books.BooksGenres (
    genreId serial,
    genreName varchar(50),
    primary key (genreId)
);
create table Books.BooksInfo (
    bookId serial,
    title varchar (50),
    icon bytea,
    genreId integer references Books.BooksGenres on update cascade on delete cascade,
    userId integer references Users.UsersInfo on update cascade on delete cascade,
    primary key (bookId)
);
-----------------------

-- Trainings schema tables:
create table Trainings.TrainingsInfo (
	trainingId serial,
	trainingTypeId integer references Trainings.TrainingTypes on update cascade on delete cascade,
	trainingDate timestamp
	primary key (trainingId)
);
-----------------------




