﻿using System;
using System.Collections.Generic;

namespace AuthenticatorPro.Data
{
    internal class AuthenticatorComparer : IEqualityComparer<Authenticator>
    {
        public bool Equals(Authenticator x, Authenticator y)
        {
            if(ReferenceEquals(x, y))
                return true;
                
            if(ReferenceEquals(x, null))
                return false;
            
            if(ReferenceEquals(y, null))
                return false;
            
            if(x.GetType() != y.GetType())
                return false;

            return x.Algorithm == y.Algorithm && x.Counter == y.Counter && x.Digits == y.Digits && x.Icon == y.Icon && x.Issuer == y.Issuer &&
                   x.Period == y.Period && x.Ranking == y.Ranking && x.Secret == y.Secret && x.Type == y.Type && x.Username == y.Username;
        }

        public int GetHashCode(Authenticator auth)
        {
            var code = new HashCode();
            code.Add(auth.Algorithm);
            code.Add(auth.Counter); 
            code.Add(auth.Digits);
            code.Add(auth.Icon);
            code.Add(auth.Issuer);
            code.Add(auth.Period);
            code.Add(auth.Ranking);
            code.Add(auth.Secret);
            code.Add(auth.Type);
            code.Add(auth.Username);
            return code.ToHashCode();
        }
    }
}