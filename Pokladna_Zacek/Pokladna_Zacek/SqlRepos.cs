﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokladna_Zacek
{
    class SqlRepos : IRepos
    {
        private SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Zacek_pokladna_nova;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        
        public List<PoklZaznam> NactiVse()
        {
           
            throw new NotImplementedException();
        }

        public PoklZaznam NactiZaznam(int idPokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public void SmazZaznam(PoklZaznam pokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public void UpravZaznam(PoklZaznam pokladniZaznam)
        {
            throw new NotImplementedException();
        }

        public PoklZaznam VytvorZaznam(PoklZaznam pokladniZaznam)
        {
            throw new NotImplementedException();
        }
    }
}
