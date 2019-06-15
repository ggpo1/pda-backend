using System;
using System.Collections.Generic;

namespace pda_backend.Database
{
    public class Auth
    {
        public async string login(string nick, string password)
        {
            return Database.getDataBaseAuth(nick, password);
        }
        public async string registration(string nick, string password)
        {
            return Database.getDataBaseRegistration(nick, password);
        }
    }
}


