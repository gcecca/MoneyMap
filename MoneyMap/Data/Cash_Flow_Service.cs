using System;
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

        public Dictionary<string, double> GetInflows(List<Cash_Flow> flows){
            
            Dictionary<string, double> inFlows = new();
            if(flows is null) throw new NullReferenceException();
            foreach(Cash_Flow flow in flows){
                if(flow.movement > 0)
                    if(inFlows.ContainsKey(flow.description))
                        inFlows[flow.description] += (double) flow.movement;
                    else
                        inFlows.Add(flow.description, (double) flow.movement);
            }

            return inFlows;
        }

        public Dictionary<string, double> GetOutflows(List<Cash_Flow> flows){
            
            Dictionary<string, double> inFlows = new();
            if(flows is null) throw new NullReferenceException();
            foreach(Cash_Flow flow in flows){
                if(flow.movement < 0)
                    if(inFlows.ContainsKey(flow.description))
                        inFlows[flow.description] += (double) Math.Abs(flow.movement);
                    else
                        inFlows.Add(flow.description, (double) Math.Abs(flow.movement));
            }

            return inFlows;
        }
    }
}