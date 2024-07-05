using DAO;
using DTO;

namespace BUS
{
    public class ContractBUS
    {
        public static void AddContract(ContractDTO cont, int idPost)
        {
            ContractDAO.AddContract(cont, idPost);
        }
    }
}
