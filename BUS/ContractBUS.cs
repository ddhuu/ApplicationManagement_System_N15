using DAO;
using DTO;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
=======
>>>>>>> 567736b8194d5d0b77c24218a907bd8b412ca159

namespace BUS
{
    public class ContractBUS
    {
<<<<<<< HEAD
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
=======
        public static void AddContract(ContractDTO cont, int idPost)
        {
            ContractDAO.AddContract(cont, idPost);
>>>>>>> 567736b8194d5d0b77c24218a907bd8b412ca159
        }
    }
}
