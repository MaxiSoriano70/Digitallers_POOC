using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using _3_DAO;
namespace Logic
{
    public class EditorialService
    {
        public static List<Editorial> ObtenerEditoriales()
        {
            try
            {
                return EditorialDAO.ObtenerEditoriales();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
