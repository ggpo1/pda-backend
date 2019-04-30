drop database if exists pda_database;
create database pda_database;

\c pda_database;

-- database name: pda_database
-- Tables:
    -- Users
        -- userId
        -- username
        -- password
        -- email
    -- Tasks
        -- taskId
        -- title
        -- Status.statusCode
            -- statusCode
            -- statusText
        -- userId
    -- Calendar
        -- 
    -- Purchases
        -- purchaseId
        -- name
        -- categorId
        -- price
        -- Purchase.Categories
            -- categoryId
            -- name
    -- Trainings
        -- trainingId
        -- title
        -- type
        -- date
        -- userId
    -- Books
        -- bookId
        -- title
        -- icon
        -- genreId
        -- userId
        -- Books.Genres
            -- genreId
            -- name
    -- Archive
        -- id
        -- data(JSON)
        -- content_type
        -- user_id
    -- Settings
        -- userId
        -- data(JSON)

-- drop table if exists users cascade;
-- drop table if exists tasks cascade;
-- drop table if exists status cascade;
-- drop table if exists calendar cascade;
-- drop table if exists purchases cascade;
-- drop table if exists categories cascade;
-- drop table if exists trainings cascade;
-- drop table if exists books cascade;
-- drop table if exists genres cascade;
-- drop table if exists archive cascade;
-- drop table if exists settings cascade;

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
create table Tasks.TasksInfo (
    taskId serial,
    title varchar(50),
    statusCode integer,
    userId integer references Users.UsersInfo on update cascade on delete cascade,
    primary key (taskId)
);
-----------------------

-- Calendar schema tables:
-----------------------


-- Books schema tables:
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
