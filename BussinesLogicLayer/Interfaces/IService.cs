using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLogicLayer.Interfaces
{
    public interface IService<TEntity> where TEntity : MyDto
    {
        public bool Create(TEntity entity);
    }
}
