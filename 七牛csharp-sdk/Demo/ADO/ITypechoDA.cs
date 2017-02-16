using System;
using System.Security.Cryptography.X509Certificates;
using Demo.model;

namespace Demo.ADO
{
    public interface ITypechoDA
    {
        int sendWrittings(Content content);
        void updateSlug(int cid);
        
    }
}