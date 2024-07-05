using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class StrategyBUS
    {
        public static List<StrategyDTO> GetStrategies(int idEnterprise)
        {
            return StrategyDAO.GetStrategies(idEnterprise);
        }

        public static bool insertStrategyEnterprise(int idEnterprise, int idStrategy)
        {
            return StrategyDAO.insertStrategyEnterprise(idEnterprise, idStrategy);
        }
    }
}
