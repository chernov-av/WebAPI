using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebAPIApp.API.Models;

namespace CoreWebAPIApp.API.Data
{
    public interface IDataProvider
    {
        void CreateRecord(DBLoan loan);
        DBLoan ReadRecord(string ID);
        void UpdateRecord(DBLoan loan);
        void DeleteRecord(string ID);

        List<DBLoan> GetAllRecords();
    }
}
