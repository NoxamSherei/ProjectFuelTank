using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelTankModel
{
    public class UserType
    {
        public int Id { get; set; }
        public string PremisionName { get; set; }
        #region Uprawnienia
        public bool IsThemselfProfilManage { get; set; }
        public bool IsOtherProfilManage { get; set; }
        public bool IsFuelCostManage { get; set; }
        public bool IsWashCostManage { get; set; }
        public bool IsGraphicManage { get; set; }
        public bool IsPointsManager { get; set; }

        public bool IsGraphicRegister { get; set; }
        public bool IsCarWashRegister { get; set; }

        public bool IsFuelCostChecking { get; set; }
        public bool IsFuelSurveyCheking { get; set; }

        public bool IsCreateTransactionRaport { get; set; }
        public bool IsCreateFuelRaport { get; set; }
        public bool IsCheckRaports { get; set; }
        #endregion
    }
}
