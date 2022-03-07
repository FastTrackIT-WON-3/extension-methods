using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public interface ITranslatableObject
    {
        void Translate(int dx, int dy);
    }
}
