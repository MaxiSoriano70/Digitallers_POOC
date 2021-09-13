using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_DAO;
using Entities;

namespace Logic
{
    public class AutorService
    {
        public static List<Autor> GetAutores()
        {
            try
            {
                return AutorDAO.ObtenerAutores();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
