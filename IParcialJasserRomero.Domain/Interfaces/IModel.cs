using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IParcialJasserRomero.Domain.Interfaces
{
    public interface IModel<T>
    {
        void Create(T t);
        List<T> Read();
    }
}
