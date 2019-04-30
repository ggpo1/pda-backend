# INSTALL .NET CORE
dinstall_linux:
	clear
	sudo snap install dotnet-sdk --classic
dinstall_mac:
	clear
dinstall_win:
	clear
# WEBAPI WORKERS
run_linux:
	clear
	dotnet-sdk.dotnet run
run_mac:
	clear
	dotnet run
run_win:
	cls
# DATABASE WORKERS
destroy_sessions:
	clear
	psql --username=postgres -w -d postgres -c "SELECT pg_terminate_backend(pid) FROM pg_stat_activity WHERE pid <> pg_backend_pid() AND datname = 'pda_database';"
deploy_db:
	clear
	psql --username=postgres -w -f postgresql/pda_db_tables.sql
