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

        public int Update(Cash_Flow c){
            try{
                _db.cash_flow.Update(c);
                _db.SaveChanges();
                return 0;
            }
            catch{
                return -1;
            }
        }

        public Cash_Flow GetCashFlowById(int id){
            return _db.cash_flow.FirstOrDefault(c => c.idFlow == id);

        }
    }
}