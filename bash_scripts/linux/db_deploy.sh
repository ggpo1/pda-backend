#!/usr/bin bash
clear
psql --username=postgres -w -f ../../postgresql/pda_db_tables.sql