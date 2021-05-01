using System.Collections.Generic;
using System.Linq;
using MoneyMap.Data;
namespace MoneyMap.Data{
    public class Cash_Flow_Service{
        private readonly ApplicationDbContext _db;

        public Cash_Flow_Service(ApplicationDbContext db){
            _db = db;
        }

        public List<Cash_Flow> GetCashFlow (){
            List<Cash_Flow> cf = _db.cash_flow.ToList();
            return cf;

        }

        public int Create( Cash_Flow cf){
            try{
                _db.Add(cf);
                _db.SaveChanges();
                return 0;
            }
            catch{
                return -1;
            }
        }
    }
}