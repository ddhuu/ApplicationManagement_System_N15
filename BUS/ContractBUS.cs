using DAO;
using DTO;
using System;
using System.Collections.Generic;


namespace BUS
{
    public class ContractBUS
    {
        public static bool checkDate(DateTime dateToCheck)
        {
            return ContractDAO.checkDate(dateToCheck);
        }
        public static List<ContractDTO> getContractsByOutOfDate()
        {
            return ContractDAO.getContractsByOutOfDate();
        }

        public static ContractDTO getDetailContract(int idEnterprise)
        {
            return ContractDAO.getDetailContract(idEnterprise);
        }

        public static bool updateOutOfDate(ContractDTO selectedContract)
        {
            return ContractDAO.updateOutOfDate(selectedContract);
        }
        public static void AddContract(ContractDTO cont, int idPost)
        {
            ContractDAO.AddContract(cont, idPost);
        }
    }
}
