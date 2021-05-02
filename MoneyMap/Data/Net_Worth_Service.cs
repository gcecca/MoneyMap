using System.Collections.Generic;
using System.Linq;
using MoneyMap.Data;
namespace MoneyMap.Data{
    public class Net_Worth_Service{
        private readonly ApplicationDbContext _db;

        public Net_Worth_Service(ApplicationDbContext db){
            _db = db;
        }

        public List<Net_Worth> GetMoneyMap (){
            List<Net_Worth> cf = _db.money_map.ToList();
            return cf;

        }
        public int Create( Net_Worth m){
            try{
                _db.Add(m);
                _db.SaveChanges();
                return 0;
            }
            catch{
                return -1;
            }
        }

        public int Update(Net_Worth m){
            try{
                _db.money_map.Update(m);
                _db.SaveChanges();
                return 0;
            }
            catch{
                return -1;
            }
        }

        public Net_Worth GeNetWorthById(int id){
            return _db.money_map.FirstOrDefault(m => m.id == id);

        }
    }
}