using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokladna_Zacek
{
    interface IRepos
    {
        List<PoklZaznam> NactiVse();
        PoklZaznam NactiZaznam(int idPokladniZaznam);
        PoklZaznam VytvorZaznam(PoklZaznam pokladniZaznam);
        void UpravZaznam(PoklZaznam pokladniZaznam);
        void SmazZaznam(PoklZaznam pokladniZaznam);
    } 
}
