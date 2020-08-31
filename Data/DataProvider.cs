using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreWebAPIApp.API.Models;

namespace CoreWebAPIApp.API.Data
{
    public class DataProvider : IDataProvider
    {
        private readonly DataContext _context;

        public DataProvider(DataContext context)
        {
            this._context = context;
        }

        public void CreateRecord(DBLoan loan)
        {
            this._context.loans.Add(loan);
            this._context.SaveChanges();
        }

        public DBLoan ReadRecord(string id)
        {
            return this._context.loans.FirstOrDefault(t => t.ID == id);
        }

        public void UpdateRecord(DBLoan loan)
        {
            this._context.loans.Update(loan);
            this._context.SaveChanges();
        }

        public void DeleteRecord(string id)
        {
            var recordToDelete = this._context.loans.FirstOrDefault(t => t.ID == id);
            this._context.loans.Remove(recordToDelete);
            this._context.SaveChanges();
        }

        public List<DBLoan> GetAllRecords()
        {
            return this._context.loans.ToList();
        }
    }
}
